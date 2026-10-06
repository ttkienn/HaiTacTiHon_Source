/*
 * Decompiled with CFR 0.152.
 */
package core;

import activities.Friend;
import client.Clan;
import client.Item;
import client.Player;
import database.SQL;
import io.Message;
import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import map.Map;
import org.json.simple.JSONArray;
import org.json.simple.JSONValue;
import template.InfoMemList;
import template.ItemFashion;
import template.ItemFashionP;
import template.ItemFashionP2;
import template.ItemTemplate3;
import template.Item_wear;
import template.Level;

public class BXH {
    public static List<InfoMemList> CAOTHU = new ArrayList<InfoMemList>();
    public static List<InfoMemList> PVP = new ArrayList<InfoMemList>();
    public static List<InfoMemList> WANTED = new ArrayList<InfoMemList>();

    public static void send(Player p, int type, int page) throws IOException {
        if (page < 0) {
            page = 0;
        }
        Message m = new Message(-30);
        switch (type) {
            case 7: {
                int bound1 = 0;
                int bound2 = PVP.size();
                if (PVP.size() > 10) {
                    if ((page + 1) * 10 > PVP.size()) {
                        bound1 = 10 * page;
                        bound2 = PVP.size();
                        while (bound1 >= bound2) {
                            bound1 -= 10;
                            --page;
                        }
                    } else {
                        bound1 = 10 * page;
                        bound2 = bound1 + 10;
                    }
                } else {
                    page = 0;
                }
                m.writer().writeByte(7);
                m.writer().writeUTF("Top PVP");
                m.writer().writeByte(page);
                m.writer().writeByte(bound2 - bound1);
                for (int i = bound1; i < bound2; ++i) {
                    InfoMemList temp = PVP.get(i);
                    InfoMemList.WriteInfoMemList(m.writer(), temp);
                }
                break;
            }
            case 4: {
                int bound1 = 0;
                int bound2 = CAOTHU.size();
                if (CAOTHU.size() > 10) {
                    if ((page + 1) * 10 > CAOTHU.size()) {
                        bound1 = 10 * page;
                        bound2 = CAOTHU.size();
                        while (bound1 >= bound2) {
                            bound1 -= 10;
                            --page;
                        }
                    } else {
                        bound1 = 10 * page;
                        bound2 = bound1 + 10;
                    }
                } else {
                    page = 0;
                }
                m.writer().writeByte(4);
                m.writer().writeUTF("Cao Th\u1ee7");
                m.writer().writeByte(page);
                m.writer().writeByte(bound2 - bound1);
                for (int i = bound1; i < bound2; ++i) {
                    InfoMemList temp = CAOTHU.get(i);
                    InfoMemList.WriteInfoMemList(m.writer(), temp);
                }
                break;
            }
            case 6: {
                int bound1 = 0;
                int bound2 = Clan.BXH.size();
                if (Clan.BXH.size() > 10) {
                    if ((page + 1) * 10 > Clan.BXH.size()) {
                        bound1 = 10 * page;
                        bound2 = Clan.BXH.size();
                        while (bound1 >= bound2) {
                            bound1 -= 10;
                            --page;
                        }
                    } else {
                        bound1 = 10 * page;
                        bound2 = bound1 + 10;
                    }
                } else {
                    page = 0;
                }
                m.writer().writeByte(6);
                m.writer().writeUTF("B\u0103ng H\u1ea3i T\u1eb7c");
                m.writer().writeByte(page);
                m.writer().writeByte(bound2 - bound1);
                for (int i = bound1; i < bound2; ++i) {
                    String clan_name = Clan.BXH.get(i);
                    Clan clan = Clan.get_clan_by_name(clan_name);
                    m.writer().writeShort(clan.id);
                    m.writer().writeUTF(clan.name);
                    String info = "TS: %s - Lv: %s + %s";
                    float percent = (float)clan.xp * 100.0f / (float)Clan.get_xp_max(clan.level, clan.trungsinh);
                    if (percent > 100.0f) {
                        percent = 100.0f;
                    }
                    m.writer().writeUTF(String.format(info, clan.trungsinh, clan.level, String.format("%.2f", Float.valueOf(percent))) + "%");
                    m.writer().writeShort(-1);
                    m.writer().writeShort(i);
                }
                break;
            }
            case 9: {
                int bound1 = 0;
                int bound2 = WANTED.size() > 10 ? 10 : WANTED.size();
                page = 0;
                m.writer().writeByte(9);
                m.writer().writeUTF("Truy n\u00e3");
                m.writer().writeByte(page);
                m.writer().writeByte(bound2 - bound1);
                for (int i = bound1; i < bound2; ++i) {
                    InfoMemList temp = WANTED.get(i);
                    Player p0 = Map.get_player_by_name_allmap(temp.name);
                    short[] part = new short[]{-1, -1, -1};
                    if (p0 != null) {
                        temp.head = p0.head;
                        temp.hair = p0.hair;
                        temp.hat = p0.get_hat();
                        if (p0.item.it_body[0] != null) {
                            part[2] = p0.item.it_body[0].template.part;
                        }
                        if (p0.item.it_body[5] != null) {
                            part[1] = p0.item.it_body[5].template.part;
                        }
                        if (p0.item.it_body[3] != null) {
                            part[0] = p0.item.it_body[3].template.part;
                        }
                    }
                    m.writer().writeInt(temp.id);
                    m.writer().writeUTF(temp.name);
                    m.writer().writeShort(temp.head);
                    m.writer().writeShort(temp.hair);
                    m.writer().writeShort(temp.hat);
                    m.writer().writeShort(part[0]);
                    m.writer().writeShort(part[1]);
                    m.writer().writeShort(part[2]);
                    m.writer().writeInt(i);
                    m.writer().writeInt((int)temp.thongthao);
                }
                break;
            }
        }
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static void process(Player p, Message m2) throws IOException {
        byte type = m2.reader().readByte();
        byte idlist = m2.reader().readByte();
        byte page = m2.reader().readByte();
        switch (type) {
            case 2: {
                if (idlist != 2 || page != 0) break;
                Message m = new Message(-30);
                m.writer().writeByte(2);
                m.writer().writeUTF("K\u1ebb Th\u00f9");
                m.writer().writeByte(0);
                m.writer().writeByte(p.enemy_list.size());
                for (int i = 0; i < p.enemy_list.size(); ++i) {
                    Friend.ReadInfoMemList(m.writer(), p.enemy_list.get(i));
                }
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 3: {
                BXH.send(p, idlist, page);
            }
        }
    }

    public static void update() {
        BXH.updateCaoThu();
        BXH.updatePVP();
        BXH.updateWanted();
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private static void updateWanted() {
        ArrayList<InfoMemList> list_add = new ArrayList<InfoMemList>();
        Connection connection = null;
        PreparedStatement ps = null;
        ResultSet rs = null;
        try {
            connection = SQL.gI().getCon();
            ps = connection.prepareStatement("SELECT `id`, `name`, `clazz`, `wanted_point`, `body`, `it_body`, `fashion`, `site` FROM `players` WHERE `wanted_point` > 0 ORDER BY `wanted_point` DESC LIMIT 50;");
            rs = ps.executeQuery();
            while (rs.next()) {
                int i0;
                Object tempf;
                JSONArray js_temp;
                int i02;
                InfoMemList temp = new InfoMemList();
                temp.id = rs.getInt("id");
                temp.name = rs.getString("name");
                temp.thongthao = rs.getInt("wanted_point");
                ArrayList<Object> fashion = new ArrayList<Object>();
                ArrayList<Object> itfashionP = new ArrayList<Object>();
                JSONArray js0 = (JSONArray)JSONValue.parse(rs.getString("fashion"));
                JSONArray js_temp_2 = (JSONArray)JSONValue.parse(js0.get(0).toString());
                for (i02 = 0; i02 < js_temp_2.size(); ++i02) {
                    js_temp = (JSONArray)JSONValue.parse(js_temp_2.get(i02).toString());
                    tempf = new ItemFashionP();
                    ((ItemFashionP)tempf).category = Byte.parseByte(js_temp.get(0).toString());
                    ((ItemFashionP)tempf).id = Short.parseShort(js_temp.get(1).toString());
                    ((ItemFashionP)tempf).icon = Short.parseShort(js_temp.get(2).toString());
                    ((ItemFashionP)tempf).is_use = Byte.parseByte(js_temp.get(3).toString()) == 1;
                    itfashionP.add(tempf);
                }
                js_temp_2.clear();
                js_temp_2 = (JSONArray)JSONValue.parse(js0.get(1).toString());
                for (i02 = 0; i02 < js_temp_2.size(); ++i02) {
                    js_temp = (JSONArray)JSONValue.parse(js_temp_2.get(i02).toString());
                    tempf = new ItemFashionP2();
                    ((ItemFashionP2)tempf).id = Short.parseShort(js_temp.get(0).toString());
                    ((ItemFashionP2)tempf).is_use = Byte.parseByte(js_temp.get(1).toString()) == 1;
                    fashion.add(tempf);
                }
                js0.clear();
                int hair_ = -1;
                int head_ = -1;
                short[] fashion_ = null;
                for (i0 = 0; i0 < fashion.size(); ++i0) {
                    ItemFashion tempF;
                    if (!((ItemFashionP2)fashion.get((int)i0)).is_use || (tempF = ItemFashion.get_item(((ItemFashionP2)fashion.get((int)i0)).id)) == null) continue;
                    fashion_ = tempF.mWearing;
                    break;
                }
                if (fashion_ != null && fashion_[6] != -1) {
                    hair_ = -2;
                    head_ = fashion_[6];
                } else {
                    for (i0 = 0; i0 < itfashionP.size(); ++i0) {
                        if (((ItemFashionP)itfashionP.get((int)i0)).category != 103 || !((ItemFashionP)itfashionP.get((int)i0)).is_use) continue;
                        hair_ = ((ItemFashionP)itfashionP.get((int)i0)).icon;
                    }
                    for (i0 = 0; i0 < itfashionP.size(); ++i0) {
                        if (((ItemFashionP)itfashionP.get((int)i0)).category != 108 || !((ItemFashionP)itfashionP.get((int)i0)).is_use) continue;
                        head_ = ((ItemFashionP)itfashionP.get((int)i0)).icon;
                    }
                }
                JSONArray js = (JSONArray)JSONValue.parse(rs.getString("body"));
                temp.head = (short)(head_ != -1 ? head_ : (int)Short.parseShort(js.get(0).toString()));
                temp.hair = (short)(hair_ != -1 ? hair_ : (int)Short.parseShort(js.get(1).toString()));
                js.clear();
                Item_wear[] it = new Item_wear[8];
                js = (JSONArray)JSONValue.parse(rs.getString("it_body"));
                for (int i1 = 0; i1 < js.size(); ++i1) {
                    JSONArray js2 = (JSONArray)JSONValue.parse(js.get(i1).toString());
                    Item_wear temp2 = new Item_wear();
                    Item.readUpdateItem(js2.toString(), temp2);
                    it[temp2.index] = temp2;
                }
                js.clear();
                js = (JSONArray)JSONValue.parse(rs.getString("site"));
                boolean is_show_hat = Byte.parseByte(js.get(6).toString()) == 1;
                js.clear();
                temp.hat = !is_show_hat || it[1] == null ? (short)-1 : (fashion_ != null && fashion_[1] != -1 ? fashion_[1] : ItemTemplate3.get_it_by_id((int)it[1].template.id).part);
                list_add.add(temp);
            }
        }
        catch (SQLException e) {
            e.printStackTrace();
            list_add.clear();
        }
        finally {
            try {
                if (rs != null) {
                    rs.close();
                }
                if (ps != null) {
                    ps.close();
                }
                if (connection != null) {
                    connection.close();
                }
            }
            catch (SQLException e) {
                e.printStackTrace();
            }
        }
        if (list_add.size() > 0) {
            for (int i = 0; i < list_add.size(); ++i) {
                ((InfoMemList)list_add.get((int)i)).rank = (short)i;
            }
            WANTED.clear();
            WANTED.addAll(list_add);
            list_add.clear();
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private static void updatePVP() {
        ArrayList<InfoMemList> list_add = new ArrayList<InfoMemList>();
        Connection connection = null;
        PreparedStatement ps = null;
        ResultSet rs = null;
        try {
            connection = SQL.gI().getCon();
            ps = connection.prepareStatement("SELECT `id`, `name`, `clazz`, `pvppoint`, `body`, `it_body`, `fashion`, `site` FROM `players` WHERE `pvppoint` > 0 ORDER BY `pvppoint` DESC LIMIT 50;");
            rs = ps.executeQuery();
            while (rs.next()) {
                int i0;
                Object tempf;
                JSONArray js_temp;
                int i02;
                InfoMemList temp = new InfoMemList();
                temp.id = rs.getInt("id");
                temp.name = rs.getString("name");
                temp.thongthao = rs.getInt("pvppoint");
                ArrayList<Object> fashion = new ArrayList<Object>();
                ArrayList<Object> itfashionP = new ArrayList<Object>();
                JSONArray js0 = (JSONArray)JSONValue.parse(rs.getString("fashion"));
                JSONArray js_temp_2 = (JSONArray)JSONValue.parse(js0.get(0).toString());
                for (i02 = 0; i02 < js_temp_2.size(); ++i02) {
                    js_temp = (JSONArray)JSONValue.parse(js_temp_2.get(i02).toString());
                    tempf = new ItemFashionP();
                    ((ItemFashionP)tempf).category = Byte.parseByte(js_temp.get(0).toString());
                    ((ItemFashionP)tempf).id = Short.parseShort(js_temp.get(1).toString());
                    ((ItemFashionP)tempf).icon = Short.parseShort(js_temp.get(2).toString());
                    ((ItemFashionP)tempf).is_use = Byte.parseByte(js_temp.get(3).toString()) == 1;
                    itfashionP.add(tempf);
                }
                js_temp_2.clear();
                js_temp_2 = (JSONArray)JSONValue.parse(js0.get(1).toString());
                for (i02 = 0; i02 < js_temp_2.size(); ++i02) {
                    js_temp = (JSONArray)JSONValue.parse(js_temp_2.get(i02).toString());
                    tempf = new ItemFashionP2();
                    ((ItemFashionP2)tempf).id = Short.parseShort(js_temp.get(0).toString());
                    ((ItemFashionP2)tempf).is_use = Byte.parseByte(js_temp.get(1).toString()) == 1;
                    fashion.add(tempf);
                }
                js0.clear();
                int hair_ = -1;
                int head_ = -1;
                short[] fashion_ = null;
                for (i0 = 0; i0 < fashion.size(); ++i0) {
                    ItemFashion tempF;
                    if (!((ItemFashionP2)fashion.get((int)i0)).is_use || (tempF = ItemFashion.get_item(((ItemFashionP2)fashion.get((int)i0)).id)) == null) continue;
                    fashion_ = tempF.mWearing;
                    break;
                }
                if (fashion_ != null && fashion_[6] != -1) {
                    hair_ = -2;
                    head_ = fashion_[6];
                } else {
                    for (i0 = 0; i0 < itfashionP.size(); ++i0) {
                        if (((ItemFashionP)itfashionP.get((int)i0)).category != 103 || !((ItemFashionP)itfashionP.get((int)i0)).is_use) continue;
                        hair_ = ((ItemFashionP)itfashionP.get((int)i0)).icon;
                    }
                    for (i0 = 0; i0 < itfashionP.size(); ++i0) {
                        if (((ItemFashionP)itfashionP.get((int)i0)).category != 108 || !((ItemFashionP)itfashionP.get((int)i0)).is_use) continue;
                        head_ = ((ItemFashionP)itfashionP.get((int)i0)).icon;
                    }
                }
                JSONArray js = (JSONArray)JSONValue.parse(rs.getString("body"));
                temp.head = (short)(head_ != -1 ? head_ : (int)Short.parseShort(js.get(0).toString()));
                temp.hair = (short)(hair_ != -1 ? hair_ : (int)Short.parseShort(js.get(1).toString()));
                js.clear();
                Item_wear[] it = new Item_wear[8];
                js = (JSONArray)JSONValue.parse(rs.getString("it_body"));
                for (int i1 = 0; i1 < js.size(); ++i1) {
                    JSONArray js2 = (JSONArray)JSONValue.parse(js.get(i1).toString());
                    Item_wear temp2 = new Item_wear();
                    Item.readUpdateItem(js2.toString(), temp2);
                    it[temp2.index] = temp2;
                }
                js.clear();
                js = (JSONArray)JSONValue.parse(rs.getString("site"));
                boolean is_show_hat = Byte.parseByte(js.get(6).toString()) == 1;
                js.clear();
                temp.hat = !is_show_hat || it[1] == null ? (short)-1 : (fashion_ != null && fashion_[1] != -1 ? fashion_[1] : ItemTemplate3.get_it_by_id((int)it[1].template.id).part);
                temp.info = String.format("\u0110i\u1ec3m: %s", temp.thongthao);
                list_add.add(temp);
            }
        }
        catch (SQLException e) {
            e.printStackTrace();
            list_add.clear();
        }
        finally {
            try {
                if (rs != null) {
                    rs.close();
                }
                if (ps != null) {
                    ps.close();
                }
                if (connection != null) {
                    connection.close();
                }
            }
            catch (SQLException e) {
                e.printStackTrace();
            }
        }
        if (list_add.size() > 0) {
            for (int i = 0; i < list_add.size(); ++i) {
                ((InfoMemList)list_add.get((int)i)).rank = (short)i;
            }
            PVP.clear();
            PVP.addAll(list_add);
            list_add.clear();
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private static void updateCaoThu() {
        ArrayList<InfoMemList> list_add = new ArrayList<InfoMemList>();
        Connection connection = null;
        PreparedStatement ps = null;
        ResultSet rs = null;
        try {
            connection = SQL.gI().getCon();
            ps = connection.prepareStatement("SELECT `id`, `name`, `clazz`, `level`, `body`, `it_body`, `fashion`, `site` FROM `players` ORDER BY `exp` DESC LIMIT 50;");
            rs = ps.executeQuery();
            while (rs.next()) {
                int i0;
                Object tempf;
                JSONArray js_temp;
                int i02;
                InfoMemList temp = new InfoMemList();
                temp.id = rs.getInt("id");
                temp.name = rs.getString("name");
                JSONArray js0 = BXH.safeArray(rs.getString("level"));
                if (js0.size() < 3) {
                    js0.clear();
                    js0.add(1);
                    js0.add(0);
                    js0.add(0);
                }
                temp.level = BXH.safeShort(js0, 0, (short)1);
                long exp = BXH.safeLong(js0, 1, 0L);
                temp.thongthao = BXH.safeShort(js0, 2, (short)0);
                ArrayList<Object> fashion = new ArrayList<Object>();
                ArrayList<Object> itfashionP = new ArrayList<Object>();
                js0.clear();
                js0 = BXH.safeArray(rs.getString("fashion"));
                JSONArray js_temp_2 = js0.size() > 0 ? BXH.safeArray(String.valueOf(js0.get(0))) : new JSONArray();
                for (i02 = 0; i02 < js_temp_2.size(); ++i02) {
                    js_temp = BXH.safeArray(String.valueOf(js_temp_2.get(i02)));
                    if (js_temp.size() < 4) continue;
                    tempf = new ItemFashionP();
                    ((ItemFashionP)tempf).category = Byte.parseByte(js_temp.get(0).toString());
                    ((ItemFashionP)tempf).id = Short.parseShort(js_temp.get(1).toString());
                    ((ItemFashionP)tempf).icon = Short.parseShort(js_temp.get(2).toString());
                    ((ItemFashionP)tempf).is_use = Byte.parseByte(js_temp.get(3).toString()) == 1;
                    itfashionP.add(tempf);
                }
                js_temp_2.clear();
                js_temp_2 = js0.size() > 1 ? BXH.safeArray(String.valueOf(js0.get(1))) : new JSONArray();
                for (i02 = 0; i02 < js_temp_2.size(); ++i02) {
                    js_temp = BXH.safeArray(String.valueOf(js_temp_2.get(i02)));
                    if (js_temp.size() < 2) continue;
                    tempf = new ItemFashionP2();
                    ((ItemFashionP2)tempf).id = Short.parseShort(js_temp.get(0).toString());
                    ((ItemFashionP2)tempf).is_use = Byte.parseByte(js_temp.get(1).toString()) == 1;
                    fashion.add(tempf);
                }
                js0.clear();
                int hair_ = -1;
                int head_ = -1;
                short[] fashion_ = null;
                for (i0 = 0; i0 < fashion.size(); ++i0) {
                    ItemFashion tempF;
                    if (!((ItemFashionP2)fashion.get((int)i0)).is_use || (tempF = ItemFashion.get_item(((ItemFashionP2)fashion.get((int)i0)).id)) == null) continue;
                    fashion_ = tempF.mWearing;
                    break;
                }
                if (fashion_ != null && fashion_[6] != -1) {
                    hair_ = -2;
                    head_ = fashion_[6];
                } else {
                    for (i0 = 0; i0 < itfashionP.size(); ++i0) {
                        if (((ItemFashionP)itfashionP.get((int)i0)).category != 103 || !((ItemFashionP)itfashionP.get((int)i0)).is_use) continue;
                        hair_ = ((ItemFashionP)itfashionP.get((int)i0)).icon;
                    }
                    for (i0 = 0; i0 < itfashionP.size(); ++i0) {
                        if (((ItemFashionP)itfashionP.get((int)i0)).category != 108 || !((ItemFashionP)itfashionP.get((int)i0)).is_use) continue;
                        head_ = ((ItemFashionP)itfashionP.get((int)i0)).icon;
                    }
                }
                JSONArray js = BXH.safeArray(rs.getString("body"));
                temp.head = (short)(head_ != -1 ? head_ : (int)BXH.safeShort(js, 0, (short)0));
                temp.hair = (short)(hair_ != -1 ? hair_ : (int)BXH.safeShort(js, 1, (short)36));
                js.clear();
                Item_wear[] it = new Item_wear[8];
                js = BXH.safeArray(rs.getString("it_body"));
                for (int i1 = 0; i1 < js.size(); ++i1) {
                    try {
                        JSONArray js2 = BXH.safeArray(String.valueOf(js.get(i1)));
                        Item_wear temp2 = new Item_wear();
                        Item.readUpdateItem(js2.toString(), temp2);
                        if (temp2.index < 0 || temp2.index >= it.length) continue;
                        it[temp2.index] = temp2;
                        continue;
                    }
                    catch (Exception js2) {
                        // empty catch block
                    }
                }
                js.clear();
                js = BXH.safeArray(rs.getString("site"));
                boolean is_show_hat = BXH.safeByte(js, 6, (byte)1) == 1;
                js.clear();
                temp.hat = !is_show_hat || it[1] == null ? (short)-1 : (fashion_ != null && fashion_[1] != -1 ? fashion_[1] : ItemTemplate3.get_it_by_id((int)it[1].template.id).part);
                float percent = temp.level >= 100 ? (float)exp * 100.0f / (float)Level.LEVEL_THONGTHAO[(int)temp.thongthao] : (temp.level > 0 && temp.level <= Level.ENTRYS.length ? (float)exp * 100.0f / (float)Level.ENTRYS[temp.level - 1].exp : 0.0f);
                temp.info = String.format("C\u1ea5p %s + %s - TT: %s", temp.level, String.format("%.2f", Float.valueOf(percent)) + "%", temp.thongthao);
                list_add.add(temp);
            }
        }
        catch (SQLException e) {
            e.printStackTrace();
            list_add.clear();
        }
        finally {
            try {
                if (rs != null) {
                    rs.close();
                }
                if (ps != null) {
                    ps.close();
                }
                if (connection != null) {
                    connection.close();
                }
            }
            catch (SQLException e) {
                e.printStackTrace();
            }
        }
        if (list_add.size() > 0) {
            for (int i = 0; i < list_add.size(); ++i) {
                ((InfoMemList)list_add.get((int)i)).rank = (short)i;
            }
            CAOTHU.clear();
            CAOTHU.addAll(list_add);
            list_add.clear();
        }
    }

    public static int get_Thanh_tich_level(Player p) {
        try {
            for (int i = 0; i < CAOTHU.size() && i <= 9; ++i) {
                if (!BXH.CAOTHU.get((int)i).name.equals(p.name)) continue;
                if (i == 0 || i == 1 || i == 2) {
                    return i;
                }
                return 3;
            }
        }
        catch (Exception exception) {
            // empty catch block
        }
        return -1;
    }

    public static int get_Thanh_tich_pvp(Player p) {
        try {
            for (int i = 0; i < PVP.size() && i <= 9; ++i) {
                if (!BXH.PVP.get((int)i).name.equals(p.name)) continue;
                if (i == 0 || i == 1 || i == 2) {
                    return i;
                }
                return 3;
            }
        }
        catch (Exception exception) {
            // empty catch block
        }
        return -1;
    }

    public static int get_rank_wanted(String name) {
        try {
            for (int i = 0; i < WANTED.size(); ++i) {
                if (!BXH.WANTED.get((int)i).name.equals(name)) continue;
                return i;
            }
        }
        catch (Exception exception) {
            // empty catch block
        }
        return -1;
    }

    private static JSONArray safeArray(String data) {
        try {
            Object parsed = JSONValue.parse(data);
            if (parsed instanceof JSONArray) {
                return (JSONArray)parsed;
            }
        }
        catch (Exception exception) {
            // empty catch block
        }
        return new JSONArray();
    }

    private static short safeShort(JSONArray arr, int index, short defaultValue) {
        try {
            if (arr != null && index >= 0 && index < arr.size() && arr.get(index) != null) {
                return Short.parseShort(arr.get(index).toString());
            }
        }
        catch (Exception exception) {
            // empty catch block
        }
        return defaultValue;
    }

    private static byte safeByte(JSONArray arr, int index, byte defaultValue) {
        try {
            if (arr != null && index >= 0 && index < arr.size() && arr.get(index) != null) {
                return Byte.parseByte(arr.get(index).toString());
            }
        }
        catch (Exception exception) {
            // empty catch block
        }
        return defaultValue;
    }

    private static long safeLong(JSONArray arr, int index, long defaultValue) {
        try {
            if (arr != null && index >= 0 && index < arr.size() && arr.get(index) != null) {
                return Long.parseLong(arr.get(index).toString());
            }
        }
        catch (Exception exception) {
            // empty catch block
        }
        return defaultValue;
    }
}

