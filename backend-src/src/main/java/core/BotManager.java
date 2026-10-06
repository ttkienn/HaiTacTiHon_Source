/*
 * Decompiled with CFR 0.152.
 */
package core;

import client.Player;
import core.Bot;
import database.SQL;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import map.Map;
import org.json.simple.JSONArray;
import org.json.simple.JSONValue;

public class BotManager
extends Thread {
    private static BotManager instance;
    private boolean isRunning = true;
    private final List<Bot> bots = new ArrayList<Bot>();
    public static int MAX_BOTS;
    public static int MIN_BOTS;
    public static int MAX_TOTAL_BOTS;
    public static long BOT_SPAWN_INTERVAL_MS;
    public static boolean AI_CHAT_ENABLED;
    public static boolean AI_MARKET_ENABLED;
    public static boolean AI_TRADE_ENABLED;
    public static boolean AI_FRIEND_ENABLED;
    public static boolean AI_PARTY_ENABLED;
    public static boolean AI_SHIPPING_ENABLED;
    public static boolean AI_DUNGEON_HELP_ENABLED;
    private final List<String> dbBotNames = new ArrayList<String>();
    private int nameIdx = 0;
    private final HashMap<Integer, Integer> mapBotTargets = new HashMap();
    private long nextAutoSpawnTime = 0L;

    public static BotManager gI() {
        if (instance == null) {
            instance = new BotManager();
        }
        return instance;
    }

    public BotManager() {
        this.setName("BotManager");
        this.resetBotOnlineStatus();
        this.loadDbBotNames();
        this.loadMapBotConfig();
        this.loadBotAiConfig();
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private void resetBotOnlineStatus() {
        Connection c = null;
        Statement st = null;
        try {
            c = SQL.gI().getCon();
            st = c.createStatement();
            st.executeUpdate("UPDATE accounts SET onl = 0 WHERE note = 'BOT'");
        }
        catch (Exception e) {
            System.err.println("[BotManager] Could not reset bot online status: " + e.getMessage());
        }
        finally {
            try {
                if (st != null) {
                    st.close();
                }
            }
            catch (Exception exception) {}
            try {
                if (c != null) {
                    c.close();
                }
            }
            catch (Exception exception) {}
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private void markBotOnline(Bot bot, boolean online) {
        if (bot == null || bot.name == null || bot.name.isEmpty()) {
            return;
        }
        Connection c = null;
        PreparedStatement ps = null;
        try {
            c = SQL.gI().getCon();
            ps = c.prepareStatement("UPDATE accounts SET onl = ? WHERE note = 'BOT' AND (`user` = ? OR `char` LIKE ?)");
            ps.setInt(1, online ? 1 : 0);
            ps.setString(2, bot.name);
            ps.setString(3, "%\"" + bot.name + "\"%");
            ps.executeUpdate();
        }
        catch (Exception e) {
            System.err.println("[BotManager] Could not update bot online status for " + bot.name + ": " + e.getMessage());
        }
        finally {
            try {
                if (ps != null) {
                    ps.close();
                }
            }
            catch (Exception exception) {}
            try {
                if (c != null) {
                    c.close();
                }
            }
            catch (Exception exception) {}
        }
    }

    private void saveBotSnapshot(Bot bot) {
        if (bot == null || bot.map == null || bot.item == null || bot.id <= 0) {
            return;
        }
        try {
            Player.flush(bot, false);
        }
        catch (Exception e) {
            System.err.println("[BotManager] Could not save bot snapshot for " + bot.name + ": " + e.getMessage());
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private void loadDbBotNames() {
        Connection c = null;
        Statement st = null;
        ResultSet rs = null;
        try {
            c = SQL.gI().getCon();
            st = c.createStatement();
            rs = st.executeQuery("SELECT `user`, `char` FROM accounts WHERE note='BOT' AND `lock`=0 ORDER BY id");
            while (rs.next()) {
                String charData = rs.getString("char");
                String botName = this.getFirstCharacterName(charData);
                if (botName == null || botName.isEmpty()) continue;
                this.dbBotNames.add(botName);
            }
            System.out.println("[BotManager] Loaded " + this.dbBotNames.size() + " DB bot characters.");
        }
        catch (Exception e) {
            System.err.println("[BotManager] Could not load DB bots: " + e.getMessage());
        }
        finally {
            try {
                if (rs != null) {
                    rs.close();
                }
            }
            catch (Exception exception) {}
            try {
                if (st != null) {
                    st.close();
                }
            }
            catch (Exception exception) {}
            try {
                if (c != null) {
                    c.close();
                }
            }
            catch (Exception exception) {}
        }
        Collections.shuffle(this.dbBotNames);
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private void loadMapBotConfig() {
        HashMap<Integer, Integer> hashMap = this.mapBotTargets;
        synchronized (hashMap) {
            this.mapBotTargets.clear();
        }
        Connection c = null;
        Statement st = null;
        ResultSet rs = null;
        try {
            c = SQL.gI().getCon();
            st = c.createStatement();
            st.executeUpdate("CREATE TABLE IF NOT EXISTS `bot_map_config` (`map_id` INT NOT NULL PRIMARY KEY,`target_bot` INT NOT NULL DEFAULT 1,`updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP)");
            rs = st.executeQuery("SELECT map_id, target_bot FROM bot_map_config WHERE target_bot >= 0");
            HashMap<Integer, Integer> hashMap2 = this.mapBotTargets;
            synchronized (hashMap2) {
                while (rs.next()) {
                    this.mapBotTargets.put(rs.getInt("map_id"), rs.getInt("target_bot"));
                }
            }
            System.out.println("[BotManager] Loaded " + this.mapBotTargets.size() + " map bot configs.");
        }
        catch (Exception e) {
            System.err.println("[BotManager] Could not load map bot config: " + e.getMessage());
        }
        finally {
            try {
                if (rs != null) {
                    rs.close();
                }
            }
            catch (Exception exception) {}
            try {
                if (st != null) {
                    st.close();
                }
            }
            catch (Exception exception) {}
            try {
                if (c != null) {
                    c.close();
                }
            }
            catch (Exception exception) {}
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private void loadBotAiConfig() {
        Connection c = null;
        Statement st = null;
        ResultSet rs = null;
        try {
            c = SQL.gI().getCon();
            st = c.createStatement();
            st.executeUpdate("CREATE TABLE IF NOT EXISTS `bot_ai_config` (`id` INT NOT NULL PRIMARY KEY DEFAULT 1,`chat_enabled` TINYINT NOT NULL DEFAULT 1,`market_enabled` TINYINT NOT NULL DEFAULT 1,`trade_enabled` TINYINT NOT NULL DEFAULT 1,`friend_enabled` TINYINT NOT NULL DEFAULT 1,`party_enabled` TINYINT NOT NULL DEFAULT 1,`shipping_enabled` TINYINT NOT NULL DEFAULT 1,`dungeon_help_enabled` TINYINT NOT NULL DEFAULT 1,`updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP)");
            this.ensureBotAiColumn(st, "chat_enabled", "`chat_enabled` TINYINT NOT NULL DEFAULT 1");
            this.ensureBotAiColumn(st, "market_enabled", "`market_enabled` TINYINT NOT NULL DEFAULT 1");
            this.ensureBotAiColumn(st, "trade_enabled", "`trade_enabled` TINYINT NOT NULL DEFAULT 1");
            this.ensureBotAiColumn(st, "friend_enabled", "`friend_enabled` TINYINT NOT NULL DEFAULT 1");
            this.ensureBotAiColumn(st, "party_enabled", "`party_enabled` TINYINT NOT NULL DEFAULT 1");
            this.ensureBotAiColumn(st, "shipping_enabled", "`shipping_enabled` TINYINT NOT NULL DEFAULT 1");
            this.ensureBotAiColumn(st, "dungeon_help_enabled", "`dungeon_help_enabled` TINYINT NOT NULL DEFAULT 1");
            st.executeUpdate("INSERT IGNORE INTO `bot_ai_config` (`id`) VALUES (1)");
            rs = st.executeQuery("SELECT * FROM `bot_ai_config` WHERE id = 1 LIMIT 1");
            if (rs.next()) {
                AI_CHAT_ENABLED = rs.getInt("chat_enabled") == 1;
                AI_MARKET_ENABLED = rs.getInt("market_enabled") == 1;
                AI_TRADE_ENABLED = rs.getInt("trade_enabled") == 1;
                AI_FRIEND_ENABLED = rs.getInt("friend_enabled") == 1;
                AI_PARTY_ENABLED = rs.getInt("party_enabled") == 1;
                AI_SHIPPING_ENABLED = rs.getInt("shipping_enabled") == 1;
                AI_DUNGEON_HELP_ENABLED = rs.getInt("dungeon_help_enabled") == 1;
            }
            System.out.println("[BotManager] Bot AI feature config loaded.");
        }
        catch (Exception e) {
            System.err.println("[BotManager] Could not load bot AI config: " + e.getMessage());
        }
        finally {
            try {
                if (rs != null) {
                    rs.close();
                }
            }
            catch (Exception exception) {}
            try {
                if (st != null) {
                    st.close();
                }
            }
            catch (Exception exception) {}
            try {
                if (c != null) {
                    c.close();
                }
            }
            catch (Exception exception) {}
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private void ensureBotAiColumn(Statement st, String column, String definition) throws Exception {
        ResultSet rs = null;
        try {
            rs = st.executeQuery("SELECT COUNT(*) FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'bot_ai_config' AND COLUMN_NAME = '" + column + "'");
            if (rs.next() && rs.getInt(1) == 0) {
                st.executeUpdate("ALTER TABLE `bot_ai_config` ADD COLUMN " + definition);
            }
        }
        finally {
            try {
                if (rs != null) {
                    rs.close();
                }
            }
            catch (Exception exception) {}
        }
    }

    public void configureAiFeatures(boolean chat, boolean market, boolean trade, boolean friend, boolean party, boolean shipping, boolean dungeonHelp) {
        AI_CHAT_ENABLED = chat;
        AI_MARKET_ENABLED = market;
        AI_TRADE_ENABLED = trade;
        AI_FRIEND_ENABLED = friend;
        AI_PARTY_ENABLED = party;
        AI_SHIPPING_ENABLED = shipping;
        AI_DUNGEON_HELP_ENABLED = dungeonHelp;
    }

    private String getFirstCharacterName(String charData) {
        try {
            if (charData == null || charData.trim().isEmpty() || "[]".equals(charData.trim())) {
                return null;
            }
            Object parsed = JSONValue.parse(charData);
            if (!(parsed instanceof JSONArray)) {
                return null;
            }
            JSONArray chars = (JSONArray)parsed;
            if (chars.isEmpty() || chars.get(0) == null) {
                return null;
            }
            return chars.get(0).toString();
        }
        catch (Exception e) {
            return null;
        }
    }

    private String nextBotName() {
        if (!this.dbBotNames.isEmpty()) {
            String name = this.dbBotNames.get(this.nameIdx % this.dbBotNames.size());
            ++this.nameIdx;
            return name;
        }
        return Bot.generateBotName();
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public void spawnBot(String name, Map m) {
        List<Bot> list = this.bots;
        synchronized (list) {
            if (this.bots.size() >= MAX_TOTAL_BOTS) {
                return;
            }
            for (Bot b : this.bots) {
                if (b.name == null || !b.name.equals(name)) continue;
                return;
            }
            Bot bot = new Bot(name, m);
            this.bots.add(bot);
            try {
                if (bot.map != null) {
                    bot.map.enter_map(bot);
                    this.saveBotSnapshot(bot);
                    this.markBotOnline(bot, true);
                    for (int i = 0; i < bot.map.players.size(); ++i) {
                        Player p0 = bot.map.players.get(i);
                        if (p0 == null || p0.conn == null) continue;
                        try {
                            bot.map.send_char_in4_inmap(p0, bot.index_map);
                            continue;
                        }
                        catch (Exception exception) {
                            // empty catch block
                        }
                    }
                }
            }
            catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public void spawnBot(String name, short mapId) {
        List<Bot> list = this.bots;
        synchronized (list) {
            if (this.bots.size() >= MAX_TOTAL_BOTS) {
                return;
            }
            for (Bot b : this.bots) {
                if (b.name == null || !b.name.equals(name)) continue;
                return;
            }
            Bot bot = new Bot(name, mapId);
            this.bots.add(bot);
            try {
                if (bot.map != null) {
                    bot.map.enter_map(bot);
                    this.saveBotSnapshot(bot);
                    this.markBotOnline(bot, true);
                    for (int i = 0; i < bot.map.players.size(); ++i) {
                        Player p0 = bot.map.players.get(i);
                        if (p0 == null || p0.conn == null) continue;
                        try {
                            bot.map.send_char_in4_inmap(p0, bot.index_map);
                            continue;
                        }
                        catch (Exception exception) {
                            // empty catch block
                        }
                    }
                }
            }
            catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public void killBot(Bot bot) {
        List<Bot> list = this.bots;
        synchronized (list) {
            if (this.bots.remove(bot) && bot.map != null) {
                try {
                    Player.flush(bot, false);
                    bot.map.remove_obj(bot.index_map, 0);
                    bot.map.leave_map(bot, 0);
                    this.markBotOnline(bot, false);
                }
                catch (Exception exception) {
                    // empty catch block
                }
            }
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public void killAllBots() {
        List<Bot> list = this.bots;
        synchronized (list) {
            for (Bot bot : new ArrayList<Bot>(this.bots)) {
                if (bot.map == null) continue;
                try {
                    Player.flush(bot, false);
                    bot.map.remove_obj(bot.index_map, 0);
                    bot.map.leave_map(bot, 0);
                    this.markBotOnline(bot, false);
                }
                catch (Exception exception) {}
            }
            this.bots.clear();
            this.resetBotOnlineStatus();
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public void reloadDbNames() {
        List<String> list = this.dbBotNames;
        synchronized (list) {
            this.dbBotNames.clear();
            this.nameIdx = 0;
            this.loadDbBotNames();
        }
        this.loadMapBotConfig();
        this.loadBotAiConfig();
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public void setMapTarget(int mapId, int targetBot) {
        if (targetBot < 0) {
            targetBot = 0;
        }
        HashMap<Integer, Integer> hashMap = this.mapBotTargets;
        synchronized (hashMap) {
            this.mapBotTargets.put(mapId, targetBot);
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private int getTargetForMap(Map m, int realPlayers) {
        if (realPlayers <= 0) {
            return 0;
        }
        HashMap<Integer, Integer> hashMap = this.mapBotTargets;
        synchronized (hashMap) {
            Integer custom = this.mapBotTargets.get(m.template.id);
            if (custom != null) {
                return custom;
            }
        }
        return MAX_BOTS;
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public int getBotCount() {
        List<Bot> list = this.bots;
        synchronized (list) {
            return this.bots.size();
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    @Override
    public void run() {
        while (this.isRunning) {
            try {
                Thread.sleep(1000L);
                boolean spawnedThisTick = false;
                List<Bot> list = this.bots;
                synchronized (list) {
                    for (Bot bot : new ArrayList<Bot>(this.bots)) {
                        try {
                            bot.update();
                        }
                        catch (Exception exception) {}
                    }
                }
                for (Map[] mapArr : Map.ENTRYS) {
                    if (mapArr == null) continue;
                    for (Map m : mapArr) {
                        if (m == null || m.template == null || Map.is_map_boss(m.template.id) || Map.is_map_dungeon(m.template.id)) continue;
                        int realPlayers = 0;
                        ArrayList<Bot> mapBots = new ArrayList<Bot>();
                        List<Player> list2 = m.players;
                        synchronized (list2) {
                            for (int i = 0; i < m.players.size(); ++i) {
                                Player p = m.players.get(i);
                                if (p == null) continue;
                                if (p instanceof Bot) {
                                    mapBots.add((Bot)p);
                                    continue;
                                }
                                if (p.conn == null) continue;
                                ++realPlayers;
                            }
                        }
                        int target = this.getTargetForMap(m, realPlayers);
                        if (!spawnedThisTick && mapBots.size() < target && System.currentTimeMillis() >= this.nextAutoSpawnTime) {
                            String name = this.nextBotName();
                            this.spawnBot(name, m);
                            this.nextAutoSpawnTime = System.currentTimeMillis() + BOT_SPAWN_INTERVAL_MS;
                            spawnedThisTick = true;
                            continue;
                        }
                        if (mapBots.size() <= target) continue;
                        this.killBot((Bot)mapBots.get(mapBots.size() - 1));
                    }
                }
            }
            catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    static {
        MAX_BOTS = 5;
        MIN_BOTS = 0;
        MAX_TOTAL_BOTS = 1000;
        BOT_SPAWN_INTERVAL_MS = 12000L;
        AI_CHAT_ENABLED = true;
        AI_MARKET_ENABLED = true;
        AI_TRADE_ENABLED = true;
        AI_FRIEND_ENABLED = true;
        AI_PARTY_ENABLED = true;
        AI_SHIPPING_ENABLED = true;
        AI_DUNGEON_HELP_ENABLED = true;
    }
}

