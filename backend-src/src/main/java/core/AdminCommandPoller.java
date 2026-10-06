/*
 * Decompiled with CFR 0.152.
 */
package core;

import client.Player;
import core.Bot;
import core.BotManager;
import core.Manager;
import core.SaveData;
import core.Service;
import database.SQL;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import map.Map;
import map.Vgo;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.JSONValue;
import org.json.simple.parser.JSONParser;
import template.GiftBox;
import template.ItemFashion;
import template.ItemHair;
import template.ItemTemplate4;
import template.ItemTemplate7;
import template.ItemTemplate8;
import template.Item_wear;

public class AdminCommandPoller
extends Thread {
    private boolean isRunning = true;
    private final JSONParser parser = new JSONParser();

    public AdminCommandPoller() {
        this.setName("AdminCommandPoller");
    }

    public void stopPoller() {
        this.isRunning = false;
    }

    @Override
    public void run() {
        while (this.isRunning) {
            try {
                Thread.sleep(3000L);
                this.processCommands();
            }
            catch (InterruptedException interruptedException) {
            }
            catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private void processCommands() {
        Connection conn = null;
        Statement st = null;
        ResultSet rs = null;
        try {
            conn = SQL.gI().getCon();
            if (conn == null) {
                return;
            }
            st = conn.createStatement();
            rs = st.executeQuery("SELECT * FROM `web_admin_commands` WHERE `status` = 0 ORDER BY `id` ASC;");
            ArrayList<Integer> processedIds = new ArrayList<Integer>();
            while (rs.next()) {
                int id = rs.getInt("id");
                String command = rs.getString("command");
                String targetUser = rs.getString("target_user");
                String dataStr = rs.getString("data");
                try {
                    // Gift delivery requires a live Player and room for non-overflowing consumables.
                    if ("SEND_MAIL".equals(command) && !this.canReceiveMail(targetUser, dataStr)) continue;
                    this.executeCommand(command, targetUser, dataStr);
                    processedIds.add(id);
                }
                catch (Exception ex) {
                    System.err.println("Error executing web command ID " + id + ": " + ex.getMessage());
                    processedIds.add(id);
                }
            }
            if (!processedIds.isEmpty()) {
                StringBuilder idsStr = new StringBuilder();
                for (int i = 0; i < processedIds.size(); ++i) {
                    idsStr.append(processedIds.get(i));
                    if (i >= processedIds.size() - 1) continue;
                    idsStr.append(",");
                }
                st.executeUpdate("UPDATE `web_admin_commands` SET `status` = 1 WHERE `id` IN (" + idsStr.toString() + ");");
            }
        }
        catch (SQLException e) {
            e.printStackTrace();
        }
        finally {
            try {
                if (rs != null) {
                    rs.close();
                }
                if (st != null) {
                    st.close();
                }
                if (conn != null) {
                    conn.close();
                }
            }
            catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     * Enabled force condition propagation
     * Lifted jumps to return sites
     */
    private void executeCommand(String command, String targetUser, String dataStr) throws Exception {
        if ("SEND_NOTICE".equals(command)) {
            JSONObject data = (JSONObject)this.parser.parse(dataStr);
            String message = (String)data.get("message");
            if (message == null || message.isEmpty()) return;
            int type = data.get("type") != null ? ((Long)data.get("type")).intValue() : 0;
            int color = data.get("color") != null ? ((Long)data.get("color")).intValue() : 5;
            Manager.gI().chatKTG(type, message, color);
            return;
        }
        if ("KICK".equals(command)) {
            if (targetUser == null || targetUser.isEmpty()) return;
            Player p = Map.get_player_by_name_allmap(targetUser);
            if (p != null && p.conn != null) {
                p.conn.disconnect();
            }
            try (Connection db = SQL.gI().getCon();
                 PreparedStatement ps = db.prepareStatement("UPDATE accounts SET onl = 0 WHERE `char` LIKE ?");){
                ps.setString(1, "%\"" + targetUser + "\"%");
                ps.executeUpdate();
                return;
            }
        }
        if ("SEND_MAIL".equals(command)) {
            Player p;
            if (targetUser == null || targetUser.isEmpty() || (p = Map.get_player_by_name_allmap(targetUser)) == null) return;
            this.sendMailToPlayer(p, dataStr);
            return;
        }
        if ("SEND_MAIL_ALL".equals(command)) {
            for (Map[] mapArr : Map.ENTRYS) {
                if (mapArr == null) continue;
                for (Map m : mapArr) {
                    ArrayList<Player> snapshot;
                    if (m == null) continue;
                    List<Player> list = m.players;
                    synchronized (list) {
                        snapshot = new ArrayList<Player>(m.players);
                    }
                    for (Player p : snapshot) {
                        if (p == null || p.conn == null || p instanceof Bot) continue;
                        try {
                            this.sendMailToPlayer(p, dataStr);
                        }
                        catch (Exception exception) {}
                    }
                }
            }
            return;
        }
        if ("SPAWN_BOT".equals(command)) {
            JSONObject data = (JSONObject)this.parser.parse(dataStr);
            String name = (String)data.get("name");
            String mapIdStr = String.valueOf(data.get("map") != null ? data.get("map") : Integer.valueOf(1));
            BotManager.gI().spawnBot(name, (short)Integer.parseInt(mapIdStr));
            return;
        }
        if ("KILL_BOT".equals(command)) {
            BotManager.gI().killAllBots();
            return;
        }
        if ("RECHARGE".equals(command)) {
            JSONObject data = (JSONObject)this.parser.parse(dataStr);
            long amount = data.get("amount") != null ? (Long)data.get("amount") : 0L;
            Connection conn = null;
            Statement ps = null;
            ResultSet rs = null;
            try {
                JSONArray point;
                String pi;
                JSONArray chars;
                String charStr;
                conn = SQL.gI().getCon();
                ps = conn.createStatement();
                rs = ps.executeQuery("SELECT `char` FROM `accounts` WHERE BINARY `user` = '" + targetUser + "' LIMIT 1;");
                if (!rs.next() || (charStr = rs.getString("char")) == null || charStr.isEmpty() || charStr.equals("[]") || (chars = (JSONArray)JSONValue.parse(charStr)) == null || chars.size() <= 0) return;
                String charName = chars.get(0).toString();
                Player p = Map.get_player_by_name_allmap(charName);
                if (p != null) {
                    p.update_vnd(amount);
                    Manager.gI().chatKTG(0, "[Admin] T\u00e0i kho\u1ea3n " + targetUser + " \u0111\u00e3 n\u1ea1p th\u00e0nh c\u00f4ng " + amount + " Extol!", 5);
                    return;
                }
                Statement ps2 = conn.createStatement();
                ResultSet rs2 = ps2.executeQuery("SELECT `point_inven` FROM `players` WHERE BINARY `name` = '" + charName + "' LIMIT 1;");
                if (rs2.next() && (pi = rs2.getString("point_inven")) != null && (point = (JSONArray)JSONValue.parse(pi)) != null && point.size() > 2) {
                    long oldVnd = Long.parseLong(point.get(2).toString());
                    point.set(2, oldVnd + amount);
                    Statement ps3 = conn.createStatement();
                    ps3.executeUpdate("UPDATE `players` SET `point_inven` = '" + point.toJSONString() + "' WHERE BINARY `name` = '" + charName + "';");
                    ps3.close();
                }
                rs2.close();
                ps2.close();
                return;
            }
            catch (Exception e) {
                e.printStackTrace();
                return;
            }
            finally {
                if (rs != null) {
                    rs.close();
                }
                if (ps != null) {
                    ps.close();
                }
                if (conn != null) {
                    conn.close();
                }
            }
        }
        if ("CONFIG_BOT".equals(command)) {
            JSONObject data = (JSONObject)this.parser.parse(dataStr);
            if (data.get("max") != null) {
                BotManager.MAX_BOTS = ((Long)data.get("max")).intValue();
            }
            if (data.get("min") != null) {
                BotManager.MIN_BOTS = ((Long)data.get("min")).intValue();
            }
            if (data.get("total") == null) return;
            BotManager.MAX_TOTAL_BOTS = ((Long)data.get("total")).intValue();
            return;
        }
        if ("CONFIG_BOT_MAP".equals(command)) {
            JSONObject data = (JSONObject)this.parser.parse(dataStr);
            if (data.get("map") == null || data.get("target") == null) return;
            int mapId = ((Long)data.get("map")).intValue();
            int target = ((Long)data.get("target")).intValue();
            BotManager.gI().setMapTarget(mapId, target);
            return;
        }
        if ("CONFIG_BOT_AI".equals(command)) {
            JSONObject data = (JSONObject)this.parser.parse(dataStr);
            boolean chat = this.getBool(data, "chat", true);
            boolean market = this.getBool(data, "market", true);
            boolean trade = this.getBool(data, "trade", true);
            boolean friend = this.getBool(data, "friend", true);
            boolean party = this.getBool(data, "party", true);
            boolean shipping = this.getBool(data, "shipping", true);
            boolean dungeon = this.getBool(data, "dungeon", true);
            BotManager.gI().configureAiFeatures(chat, market, trade, friend, party, shipping, dungeon);
            System.out.println("[AdminPoller] Bot AI feature config updated.");
            return;
        }
        if ("RELOAD_BOT".equals(command)) {
            BotManager.gI().reloadDbNames();
            System.out.println("[AdminPoller] Bot DB names reloaded.");
            return;
        }
        if ("SPAWN_BOSS".equals(command)) {
            JSONObject data = (JSONObject)this.parser.parse(dataStr);
            int bossId = data.get("boss_id") != null ? ((Long)data.get("boss_id")).intValue() : 0;
            Manager.gI().chatKTG(0, "[Admin] Boss " + bossId + " \u0111ang xu\u1ea5t hi\u1ec7n!", 5);
            return;
        }
        if ("TELEPORT".equals(command)) {
            JSONObject data = (JSONObject)this.parser.parse(dataStr);
            int mapId = data.get("map") != null ? ((Long)data.get("map")).intValue() : 1;
            Map[] targetMaps = Map.get_map_by_id(mapId);
            if (targetMaps == null || targetMaps.length == 0) {
                return;
            }
            Vgo fakeVgo = new Vgo();
            fakeVgo.map_go = targetMaps;
            fakeVgo.id_map_go = (short)mapId;
            fakeVgo.xnew = (short)300;
            fakeVgo.ynew = (short)200;
            fakeVgo.xold = (short)300;
            fakeVgo.yold = (short)200;
            if ("ALL".equals(targetUser) || targetUser == null || targetUser.isEmpty()) {
                for (Map[] mapArr : Map.ENTRYS) {
                    if (mapArr == null) continue;
                    for (Map m : mapArr) {
                        ArrayList<Player> snapshot;
                        if (m == null) continue;
                        List<Player> list = m.players;
                        synchronized (list) {
                            snapshot = new ArrayList<Player>(m.players);
                        }
                        for (Player p : snapshot) {
                            if (p == null || p.conn == null || p instanceof Bot) continue;
                            try {
                                p.change_map(fakeVgo);
                            }
                            catch (Exception exception) {}
                        }
                    }
                }
                return;
            }
            Player p = Map.get_player_by_name_allmap(targetUser);
            if (p == null || p.conn == null) return;
            try {
                p.change_map(fakeVgo);
                return;
            }
            catch (Exception exception) {}
            return;
        }
        if ("WHISPER".equals(command)) {
            Player p;
            JSONObject data = (JSONObject)this.parser.parse(dataStr);
            String msg = (String)data.get("message");
            if (msg == null || targetUser == null || targetUser.isEmpty() || (p = Map.get_player_by_name_allmap(targetUser)) == null || p.conn == null) return;
            Manager.gI().chatKTG(0, "[Admin \u2192 " + targetUser + "] " + msg, 3);
            return;
        } else if ("SERVER_CONTROL".equals(command)) {
            JSONObject data = (JSONObject)this.parser.parse(dataStr);
            String act = (String)data.get("action");
            if ("save_all".equals(act)) {
                Manager.gI().chatKTG(0, "[Server] \u0110ang l\u01b0u d\u1eef li\u1ec7u t\u1ea5t c\u1ea3 nh\u00e2n v\u1eadt...", 5);
                SaveData.process();
                return;
            } else if ("gc".equals(act)) {
                System.gc();
                Manager.gI().chatKTG(0, "[Server] \u0110\u00e3 gi\u1ea3i ph\u00f3ng b\u1ed9 nh\u1edb.", 5);
                return;
            } else {
                if (!"restart".equals(act)) return;
                Manager.gI().chatKTG(0, "[Server] Server s\u1ebd kh\u1edfi \u0111\u1ed9ng l\u1ea1i trong 30 gi\u00e2y!", 5);
                new Thread(() -> {
                    try {
                        Thread.sleep(30000L);
                        System.exit(0);
                    }
                    catch (Exception exception) {
                        // empty catch block
                    }
                }).start();
            }
            return;
        } else if ("UPDATE_CONFIG".equals(command) || "UPDATE_SERVER_CONFIG".equals(command)) {
            try {
                Connection conn = SQL.gI().getCon();
                Statement ps = conn.createStatement();
                ResultSet rs = ps.executeQuery("SELECT * FROM `server_config` WHERE id = 1;");
                if (rs.next()) {
                    Manager.gI().exp = rs.getInt("exp_rate");
                    Manager.gI().beri_rate = rs.getInt("beri_rate");
                    Manager.gI().drop_rate = rs.getInt("drop_rate");
                    Manager.gI().monster_drops = rs.getString("monster_drops");
                    if (Manager.gI().monster_drops == null) {
                        Manager.gI().monster_drops = "[]";
                    }
                }
                rs.close();
                ps.close();
                conn.close();
                Manager.gI().chatKTG(0, "[Admin] C\u1ea5u h\u00ecnh m\u00e1y ch\u1ee7 \u0111\u00e3 \u0111\u01b0\u1ee3c c\u1eadp nh\u1eadt tr\u1ef1c ti\u1ebfp!", 5);
                return;
            }
            catch (Exception e) {
                e.printStackTrace();
            }
            return;
        } else {
            Player p;
            int vip;
            if (!"SET_VIP".equals(command)) return;
            JSONObject data = (JSONObject)this.parser.parse(dataStr);
            int n = vip = data.get("vip") != null ? ((Long)data.get("vip")).intValue() : 0;
            if (vip < 0) {
                vip = 0;
            }
            if (vip > 7) {
                vip = 7;
            }
            if (targetUser == null || targetUser.isEmpty() || (p = Map.get_player_by_name_allmap(targetUser)) == null || p.conn == null) return;
            p.conn.vip = vip;
            Service.send_box_ThongBao_OK(p, "C\u1ea5p VIP c\u1ee7a b\u1ea1n \u0111\u00e3 \u0111\u01b0\u1ee3c c\u1eadp nh\u1eadt th\u00e0nh VIP " + vip);
        }
    }

    private boolean getBool(JSONObject data, String key, boolean defaultValue) {
        Object value = data.get(key);
        if (value == null) {
            return defaultValue;
        }
        if (value instanceof Boolean) {
            return (Boolean)value;
        }
        if (value instanceof Number) {
            return ((Number)value).intValue() != 0;
        }
        return "1".equals(value.toString()) || "true".equalsIgnoreCase(value.toString());
    }

    private boolean canReceiveMail(String name, String dataStr) throws Exception {
        Player p = name == null ? null : Map.get_player_by_name_allmap(name);
        if (p == null || p.conn == null) return false;
        JSONObject data = (JSONObject)this.parser.parse(dataStr);
        JSONArray items = (JSONArray)data.get("items");
        if (items == null) return true;
        for (Object entry : items) {
            JSONArray item = (JSONArray)entry;
            int type = ((Number)item.get(0)).intValue();
            int id = ((Number)item.get(1)).intValue();
            int count = ((Number)item.get(2)).intValue();
            if (type == 4 && id >= 2 && id <= 28 && id != 6
                    && p.item.total_item_bag_by_id(4, id) + count > 2000) return false;
        }
        return true;
    }

    private void sendMailToPlayer(Player p, String dataStr) throws Exception {
        JSONArray items;
        ItemTemplate4 item;
        GiftBox gb;
        JSONObject data = (JSONObject)this.parser.parse(dataStr);
        String title = data.get("title") != null ? (String)data.get("title") : "Qu\u00e0 t\u1eb7ng t\u1eeb Admin";
        String notice = data.get("notice") != null ? (String)data.get("notice") : "";
        long beri = data.get("beri") != null ? (Long)data.get("beri") : 0L;
        long ruby = data.get("ruby") != null ? (Long)data.get("ruby") : 0L;
        ArrayList<GiftBox> gifts = new ArrayList<GiftBox>();
        if (beri > 0L) {
            gb = new GiftBox();
            gb.type = (byte)4;
            gb.id = 0;
            gb.name = "Beri";
            gb.num = (int)beri;
            item = ItemTemplate4.get_it_by_id(0);
            if (item != null) {
                gb.icon = item.icon;
            }
            gifts.add(gb);
        }
        if (ruby > 0L) {
            gb = new GiftBox();
            gb.type = (byte)4;
            gb.id = 1;
            gb.name = "Ruby";
            gb.num = (int)ruby;
            item = ItemTemplate4.get_it_by_id(1);
            if (item != null) {
                gb.icon = item.icon;
            }
            gifts.add(gb);
        }
        if ((items = (JSONArray)data.get("items")) != null) {
            for (Object itemObj : items) {
                JSONArray itemArr = (JSONArray)itemObj;
                if (itemArr.size() < 3) continue;
                byte type = ((Long)itemArr.get(0)).byteValue();
                short id = ((Long)itemArr.get(1)).shortValue();
                short quant = ((Long)itemArr.get(2)).shortValue();
                block0 : switch (type) {
                    case 3: {
                        Item_wear it_add = new Item_wear();
                        it_add.setup_template_by_id(id);
                        if (it_add.template == null) break;
                        GiftBox giftBox = new GiftBox();
                        giftBox.type = (byte)3;
                        giftBox.id = id;
                        giftBox.name = it_add.template.name;
                        giftBox.icon = it_add.template.icon;
                        giftBox.num = quant;
                        gifts.add(giftBox);
                        break;
                    }
                    case 4: 
                    case 7: {
                        GiftBox gb3 = new GiftBox();
                        gb3.type = type;
                        gb3.id = id;
                        gb3.num = quant;
                        if (type == 4) {
                            ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(id);
                            if (itemTemplate4 == null) break;
                            gb3.name = itemTemplate4.name;
                            gb3.icon = itemTemplate4.icon;
                        } else {
                            ItemTemplate7 itemTemplate7 = ItemTemplate7.get_it_by_id(id);
                            if (itemTemplate7 == null) break;
                            gb3.name = itemTemplate7.name;
                            gb3.icon = itemTemplate7.icon;
                        }
                        gifts.add(gb3);
                        break;
                    }
                    case 105: {
                        ItemFashion fashion = ItemFashion.get_item(id);
                        if (fashion == null || p.check_fashion(fashion.ID) != null) break;
                        GiftBox giftBox = new GiftBox();
                        giftBox.type = (byte)105;
                        giftBox.id = id;
                        giftBox.name = fashion.name;
                        giftBox.icon = fashion.idIcon;
                        giftBox.num = 1;
                        gifts.add(giftBox);
                        break;
                    }
                    case 103: {
                        ItemHair hair = ItemHair.get_item(id, 103);
                        if (hair == null || p.check_itfashionP(hair.ID, 103) != null) break;
                        GiftBox giftBox = new GiftBox();
                        giftBox.type = (byte)103;
                        giftBox.id = id;
                        giftBox.name = hair.name;
                        giftBox.icon = hair.idIcon;
                        giftBox.num = 1;
                        gifts.add(giftBox);
                        break;
                    }
                    case 8: {
                        if (p.clan == null) break;
                        for (ItemTemplate8 itemTemplate8 : ItemTemplate8.ENTRYS) {
                            if (itemTemplate8.id != id) continue;
                            GiftBox gb4 = new GiftBox();
                            gb4.type = (byte)8;
                            gb4.id = id;
                            gb4.name = itemTemplate8.name;
                            gb4.icon = itemTemplate8.icon;
                            gb4.num = quant;
                            gifts.add(gb4);
                            break block0;
                        }
                        break;
                    }
                }
            }
        }
        Service.send_gift(p, 1, title, notice, gifts, true);
    }
}
