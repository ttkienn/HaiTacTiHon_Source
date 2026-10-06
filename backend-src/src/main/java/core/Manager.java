/*
 * Decompiled with CFR 0.152.
 */
package core;

import activities.Market;
import activities.Rebuild_Item;
import activities.Red_Line;
import activities.UpgradeItem;
import activities.VongQuay;
import client.Body;
import client.Clan;
import client.Pet;
import client.Player;
import client.Quest;
import core.Service;
import core.Util;
import database.SQL;
import event.TaiXiu;
import io.Message;
import java.io.ByteArrayInputStream;
import java.io.DataInputStream;
import java.io.File;
import java.io.IOException;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import map.Boat_In_Map;
import map.Boss;
import map.Map;
import map.MapTemplate;
import map.Mob;
import map.Npc;
import map.Vgo;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.JSONValue;
import template.Clan_chat;
import template.Clan_member;
import template.DaThanThoai;
import template.EffTemplate;
import template.ItemBag47;
import template.ItemBoat;
import template.ItemFashion;
import template.ItemHair;
import template.ItemMarket;
import template.ItemOptionTemplate;
import template.ItemSell;
import template.ItemTemplate3;
import template.ItemTemplate4;
import template.ItemTemplate4_Info;
import template.ItemTemplate7;
import template.ItemTemplate8;
import template.Level;
import template.MobTemplate;
import template.Option;
import template.Part;
import template.PartImg;
import template.PotionMarket;
import template.ShopTichLuy;
import template.Skill_Template;
import template.Skill_info;
import template.Top_Dame;

public class Manager {
    private static Manager instance;
    public static String[] NAME_ITEM_SELL_TEMP;
    public boolean debug;
    public String mysql_host;
    public String mysql_database;
    public String mysql_user;
    public String mysql_pass;
    public String server_host;
    public int server_port;
    public int exp;
    public int beri_rate = 1;
    public int drop_rate = 1;
    public String monster_drops = "[]";
    public boolean server_admin;
    private int index_mob;
    private TaiXiu tx;
    private static int a;

    public static Manager gI() {
        if (instance == null) {
            instance = new Manager();
        }
        return instance;
    }

    public void init() {
        this.index_mob = 1;
        try {
            this.load_config();
            ByteArrayInputStream bais = new ByteArrayInputStream(Util.loadfile("data/msg/hair"));
            DataInputStream dis = new DataInputStream(bais);
            dis.close();
            bais.close();
            bais = new ByteArrayInputStream(Util.loadfile("data/msg/head"));
            dis = new DataInputStream(bais);
            this.load_hair(dis, 108);
            dis.close();
            bais.close();
            DaThanThoai.data_shop = Util.loadfile("data/msg/dathanthoaishop");
        }
        catch (Exception e) {
            System.out.println("config load err!");
            System.exit(0);
        }
        this.load_database();
        this.start_service();
    }

    private void start_service() {
        for (Map[] mapall : Map.ENTRYS) {
            for (Map map : mapall) {
                if (Map.is_map_boss(map.template.id) || Map.is_map_dungeon(map.template.id)) continue;
                map.start_map();
            }
        }
        this.tx = new TaiXiu();
        a = Rebuild_Item.ID_SELL.length;
        a = Red_Line.KEY0.length;
        a = UpgradeItem.DATA.size();
        a = Body.Point3_Template_hp.length;
        a = ItemBoat.ENTRYS.size();
        a = ItemSell.ENTRYS.size();
        a = VongQuay.ID_ITEM.length;
        a = Level.ENTRYS.length;
        a = Skill_info.EXP.length;
        System.out.println("Start Service OK, " + a);
    }

    private void stop_service() {
        for (Map[] mapall : Map.ENTRYS) {
            for (Map map : mapall) {
                map.stop_map();
            }
        }
        this.tx.close();
        for (int i = 0; i < Map.get_map_plus().size(); ++i) {
            Map.get_map_plus().get(i).stop_map();
        }
    }

    private void load_hair(DataInputStream dis, int type) throws IOException {
        dis.readByte();
        dis.readUTF();
        dis.readByte();
        int n = dis.readShort();
        for (int i = 0; i < n; ++i) {
            ItemHair temp = ItemHair.readUpdateItemHair(dis);
            temp.type = (byte)type;
            ItemHair.ENTRYS.add(temp);
        }
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    private void load_database() {
        Connection conn = null;
        Statement ps = null;
        ResultSet rs = null;
        try {
            JSONArray js_in;
            int i;
            Object temp;
            conn = SQL.gI().getCon();
            ps = conn.createStatement();
            try {
                String query_config = "SELECT * FROM `server_config` WHERE id = 1;";
                rs = ps.executeQuery(query_config);
                if (rs.next()) {
                    this.exp = rs.getInt("exp_rate");
                    this.beri_rate = rs.getInt("beri_rate");
                    this.drop_rate = rs.getInt("drop_rate");
                    this.monster_drops = rs.getString("monster_drops");
                    if (this.monster_drops == null) {
                        this.monster_drops = "[]";
                    }
                }
                rs.close();
            }
            catch (Exception e) {
                System.out.println("No server config found, using defaults");
            }
            String query = "SELECT * FROM `mobs`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                temp = new MobTemplate();
                ((MobTemplate)temp).mob_id = Short.parseShort(rs.getString("id"));
                ((MobTemplate)temp).name = rs.getString("name");
                ((MobTemplate)temp).level = Short.parseShort(rs.getString("level"));
                ((MobTemplate)temp).hp_max = Integer.parseInt(rs.getString("hp"));
                ((MobTemplate)temp).hOne = Short.parseShort(rs.getString("hOne"));
                ((MobTemplate)temp).typemove = Byte.parseByte(rs.getString("typemove"));
                ((MobTemplate)temp).ishuman = Byte.parseByte(rs.getString("ishuman"));
                ((MobTemplate)temp).typemonster = Byte.parseByte(rs.getString("typemonster"));
                JSONArray js = (JSONArray)JSONValue.parse(rs.getString("idicon"));
                if (((MobTemplate)temp).ishuman == 0) {
                    ((MobTemplate)temp).icon = Short.parseShort(js.get(1).toString());
                } else if (((MobTemplate)temp).ishuman == 1) {
                    ((MobTemplate)temp).head = Short.parseShort(js.get(1).toString());
                    ((MobTemplate)temp).hair = Short.parseShort(js.get(2).toString());
                    JSONArray js2 = (JSONArray)JSONValue.parse(js.get(3).toString());
                    ((MobTemplate)temp).wearing = new short[js2.size()];
                    for (int i2 = 0; i2 < ((MobTemplate)temp).wearing.length; ++i2) {
                        ((MobTemplate)temp).wearing[i2] = Short.parseShort(js2.get(i2).toString());
                    }
                }
                js.clear();
                js = (JSONArray)JSONValue.parse(rs.getString("skill"));
                ((MobTemplate)temp).skill = new short[js.size()];
                for (i = 0; i < ((MobTemplate)temp).skill.length; ++i) {
                    ((MobTemplate)temp).skill[i] = Short.parseShort(js.get(i).toString());
                }
                js.clear();
                MobTemplate.ENTRYS.add((MobTemplate)temp);
            }
            rs.close();
            System.out.println("load mob ok");
            query = "SELECT * FROM `shoptichluy` ORDER BY `type`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                temp = new ShopTichLuy();
                ((ShopTichLuy)temp).id = rs.getShort("id");
                ((ShopTichLuy)temp).type = rs.getByte("type");
                ((ShopTichLuy)temp).point = rs.getInt("point");
                ((ShopTichLuy)temp).info = rs.getString("info");
                ((ShopTichLuy)temp).limit = rs.getInt("limit");
                ((ShopTichLuy)temp).limit_data = new HashMap();
                JSONArray jsar = (JSONArray)JSONValue.parse(rs.getString("limit_data"));
                for (i = 0; i < jsar.size(); ++i) {
                    JSONArray js_in2 = (JSONArray)jsar.get(i);
                    int value = Integer.parseInt(js_in2.get(1).toString());
                    ((ShopTichLuy)temp).limit_data.put(js_in2.get(0).toString(), value);
                }
                ShopTichLuy.ENTRY.add((ShopTichLuy)temp);
            }
            rs.close();
            query = "SELECT * FROM `maps`;";
            rs = ps.executeQuery(query);
            MapTemplate.ENTRYS = new ArrayList<MapTemplate>();
            while (rs.next()) {
                int i3;
                short id_map = rs.getShort("id");
                File f = new File("data/map/" + id_map);
                if (!f.exists()) continue;
                MapTemplate map_temp = new MapTemplate();
                map_temp.id = id_map;
                map_temp.name = rs.getString("name");
                map_temp.max_zone = rs.getByte("maxzone");
                map_temp.max_player = rs.getByte("maxplayer");
                JSONArray js_npc = (JSONArray)JSONValue.parse(rs.getString("npcs"));
                map_temp.npcs = new ArrayList<Npc>();
                for (i3 = 0; i3 < js_npc.size(); ++i3) {
                    JSONArray js_npc_temp = (JSONArray)JSONValue.parse(js_npc.get(i3).toString());
                    Npc npc = new Npc();
                    npc.iditem = Short.parseShort(js_npc_temp.get(0).toString());
                    npc.name = js_npc_temp.get(1).toString();
                    npc.namegt = js_npc_temp.get(2).toString();
                    npc.chat = js_npc_temp.get(3).toString();
                    npc.x = Short.parseShort(js_npc_temp.get(4).toString());
                    npc.y = Short.parseShort(js_npc_temp.get(5).toString());
                    npc.isPerson = Byte.parseByte(js_npc_temp.get(6).toString());
                    npc.typeIcon = Byte.parseByte(js_npc_temp.get(7).toString());
                    npc.wBlock = Byte.parseByte(js_npc_temp.get(8).toString());
                    npc.hBlock = Byte.parseByte(js_npc_temp.get(9).toString());
                    npc.b3 = Byte.parseByte(js_npc_temp.get(10).toString());
                    JSONArray js_npc_temp_2 = (JSONArray)JSONValue.parse(js_npc_temp.get(11).toString());
                    npc.dataFrame = new byte[js_npc_temp_2.size()];
                    for (int j = 0; j < npc.dataFrame.length; ++j) {
                        npc.dataFrame[j] = Byte.parseByte(js_npc_temp_2.get(j).toString());
                    }
                    npc.head = Short.parseShort(js_npc_temp.get(12).toString());
                    npc.hair = Short.parseShort(js_npc_temp.get(13).toString());
                    JSONArray js_npc_temp_3 = (JSONArray)JSONValue.parse(js_npc_temp.get(14).toString());
                    npc.wearing = new short[js_npc_temp_3.size()];
                    for (int k = 0; k < npc.wearing.length; ++k) {
                        npc.wearing[k] = Short.parseShort(js_npc_temp_3.get(k).toString());
                    }
                    map_temp.npcs.add(npc);
                }
                js_npc.clear();
                js_npc = (JSONArray)JSONValue.parse(rs.getString("boat"));
                map_temp.list_boat = new ArrayList<Boat_In_Map>();
                for (i3 = 0; i3 < js_npc.size(); ++i3) {
                    JSONArray js_temp = (JSONArray)js_npc.get(i3);
                    Boat_In_Map temp_boat = new Boat_In_Map();
                    temp_boat.x = Short.parseShort(js_temp.get(0).toString());
                    temp_boat.y = Short.parseShort(js_temp.get(1).toString());
                    map_temp.list_boat.add(temp_boat);
                }
                js_npc.clear();
                map_temp.vgos = new ArrayList<Vgo>();
                js_npc = (JSONArray)JSONValue.parse(rs.getString("vgos"));
                for (i3 = 0; i3 < js_npc.size(); ++i3) {
                    JSONArray js_0 = (JSONArray)js_npc.get(i3);
                    Vgo vgo_temp = new Vgo();
                    vgo_temp.id_map_go = Short.parseShort(js_0.get(0).toString());
                    vgo_temp.xold = Short.parseShort(js_0.get(1).toString());
                    vgo_temp.yold = Short.parseShort(js_0.get(2).toString());
                    vgo_temp.xnew = Short.parseShort(js_0.get(3).toString());
                    vgo_temp.ynew = Short.parseShort(js_0.get(4).toString());
                    if (vgo_temp.id_map_go == -1) continue;
                    map_temp.vgos.add(vgo_temp);
                }
                js_npc.clear();
                map_temp.type_view_p = rs.getByte("typeViewPlayer");
                map_temp.b = rs.getByte("b");
                map_temp.specMap = rs.getByte("specMap");
                js_npc = (JSONArray)JSONValue.parse(rs.getString("data"));
                map_temp.data = new byte[2][];
                for (i3 = 0; i3 < js_npc.size(); ++i3) {
                    js_in = (JSONArray)js_npc.get(i3);
                    map_temp.data[i3] = new byte[js_in.size()];
                    for (int j = 0; j < map_temp.data[i3].length; ++j) {
                        map_temp.data[i3][j] = Byte.parseByte(js_in.get(j).toString());
                    }
                }
                js_npc.clear();
                js_npc = (JSONArray)JSONValue.parse(rs.getString("MapBack"));
                map_temp.IDBack = Byte.parseByte(js_npc.get(0).toString());
                map_temp.HBack = Short.parseShort(js_npc.get(1).toString());
                map_temp.maxW = Short.parseShort(js_npc.get(2).toString());
                map_temp.maxH = Short.parseShort(js_npc.get(3).toString());
                js_npc.clear();
                map_temp.id_eff_map = rs.getByte("id_eff_map");
                map_temp.level = rs.getByte("level");
                map_temp.typeChangeMap = rs.getByte("typeChangeMap");
                js_npc = (JSONArray)JSONValue.parse(rs.getString("mPosMapTrain"));
                map_temp.mPosMapTrain = new byte[js_npc.size()][];
                for (i3 = 0; i3 < js_npc.size(); ++i3) {
                    js_in = (JSONArray)js_npc.get(i3);
                    map_temp.mPosMapTrain[i3] = new byte[js_in.size()];
                    for (int j = 0; j < map_temp.mPosMapTrain[i3].length; ++j) {
                        map_temp.mPosMapTrain[i3][j] = Byte.parseByte(js_in.get(j).toString());
                    }
                }
                js_npc.clear();
                map_temp.strTimeChange = rs.getString("strTimeChange");
                MapTemplate.ENTRYS.add(map_temp);
                String mob_json = rs.getString("mobs");
                Map[] m_temp = new Map[map_temp.max_zone];
                for (int i2 = 0; i2 < m_temp.length; ++i2) {
                    m_temp[i2] = new Map();
                    m_temp[i2].zone_id = (byte)i2;
                    m_temp[i2].template = map_temp;
                    JSONArray js = (JSONArray)JSONValue.parse(mob_json);
                    m_temp[i2].list_mob = new int[js.size()];
                    for (int i4 = 0; i4 < js.size(); ++i4) {
                        JSONArray js2 = (JSONArray)JSONValue.parse(js.get(i4).toString());
                        Mob temp2 = new Mob();
                        temp2.mob_template = MobTemplate.ENTRYS.get(Integer.parseInt(js2.get(0).toString()));
                        temp2.x = Short.parseShort(js2.get(1).toString());
                        temp2.y = Short.parseShort(js2.get(2).toString());
                        temp2.hp = temp2.hp_max = temp2.mob_template.hp_max;
                        temp2.level = temp2.mob_template.level;
                        temp2.isdie = false;
                        temp2.id_target = -1;
                        temp2.index = this.index_mob;
                        temp2.map = m_temp[i2];
                        temp2.boss_info = null;
                        Mob.ENTRYS.put(this.index_mob, temp2);
                        m_temp[i2].list_mob[i4] = this.index_mob++;
                    }
                }
                Map.ENTRYS.add(m_temp);
            }
            rs.close();
            for (int i5 = 0; i5 < MapTemplate.ENTRYS.size(); ++i5) {
                for (int j = 0; j < MapTemplate.ENTRYS.get((int)i5).vgos.size(); ++j) {
                    Vgo vgo = MapTemplate.ENTRYS.get((int)i5).vgos.get(j);
                    vgo.map_go = Map.get_map_by_id(vgo.id_map_go);
                    if (vgo.map_go != null) continue;
                    vgo.map_go = Map.get_map_by_id(1);
                }
            }
            System.out.println("load map ok");
            query = "SELECT * FROM `parts`;";
            Part.ENTRY = new ArrayList<Part>();
            rs = ps.executeQuery(query);
            while (rs.next()) {
                byte type = rs.getByte("type");
                JSONArray js = (JSONArray)JSONValue.parse(rs.getString("data"));
                Part part = new Part(type);
                part.id = rs.getShort("id");
                for (int i6 = 0; i6 < js.size(); ++i6) {
                    JSONArray js_in3 = (JSONArray)js.get(i6);
                    part.pi[i6] = new PartImg();
                    part.pi[i6].id = Short.parseShort(js_in3.get(0).toString());
                    part.pi[i6].dx = Byte.parseByte(js_in3.get(1).toString());
                    part.pi[i6].dy = Byte.parseByte(js_in3.get(2).toString());
                }
                Part.ENTRY.add(part);
            }
            rs.close();
            query = "SELECT * FROM `item3`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                ItemTemplate3 temp3 = new ItemTemplate3();
                temp3.id = rs.getShort("id");
                temp3.name = rs.getString("name");
                temp3.clazz = rs.getByte("clazz");
                temp3.typeEquip = rs.getByte("typeequip");
                temp3.icon = rs.getShort("icon");
                temp3.level = rs.getShort("level");
                temp3.color = rs.getByte("color");
                temp3.typelock = rs.getByte("typelock");
                temp3.numHoleDaDuc = rs.getByte("numHoleDaDuc");
                temp3.valueChetac = (short)100;
                temp3.isHoanMy = rs.getByte("ishoanmy");
                temp3.valueKichAn = rs.getByte("valuekichan");
                JSONArray js = (JSONArray)JSONValue.parse(rs.getString("op_1"));
                temp3.option_item = new ArrayList<Option>();
                for (int i7 = 0; i7 < js.size(); ++i7) {
                    JSONArray js2 = (JSONArray)JSONValue.parse(js.get(i7).toString());
                    temp3.option_item.add(new Option(Byte.parseByte(js2.get(0).toString()), Short.parseShort(js2.get(1).toString())));
                }
                js.clear();
                temp3.option_item_2 = new ArrayList<Option>();
                js = (JSONArray)JSONValue.parse(rs.getString("op_2"));
                for (int k = 0; k < js.size(); ++k) {
                    JSONArray js2 = (JSONArray)JSONValue.parse(js.get(k).toString());
                    temp3.option_item_2.add(new Option(Byte.parseByte(js2.get(0).toString()), Short.parseShort(js2.get(1).toString())));
                }
                js.clear();
                temp3.numLoKham = rs.getByte("numlokham");
                js = (JSONArray)JSONValue.parse(rs.getString("mdakham"));
                temp3.mdakham = new short[js.size()];
                for (int l = 0; l < temp3.mdakham.length; ++l) {
                    temp3.mdakham[l] = Short.parseShort(js.get(l).toString());
                }
                temp3.part = rs.getShort("part");
                temp3.beri = rs.getInt("beri");
                temp3.ruby = rs.getInt("ruby");
                ItemTemplate3.ENTRYS.add(temp3);
            }
            rs.close();
            query = "SELECT * FROM `item4_info`;";
            ItemTemplate4_Info.ENTRY = new ArrayList<ItemTemplate4_Info>();
            rs = ps.executeQuery(query);
            while (rs.next()) {
                ItemTemplate4_Info temp4 = new ItemTemplate4_Info();
                temp4.id = rs.getShort("id");
                temp4.info = rs.getString("info");
                ItemTemplate4_Info.ENTRY.add(temp4);
            }
            rs.close();
            query = "SELECT * FROM `item4`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                ItemTemplate4 temp5 = new ItemTemplate4();
                temp5.id = rs.getShort("id");
                temp5.name = rs.getString("name");
                temp5.icon = rs.getShort("icon");
                temp5.indexInfoPotion = rs.getShort("indexInfoPotion");
                temp5.beri = rs.getInt("price");
                temp5.ruby = rs.getShort("priceruby");
                temp5.istrade = rs.getByte("istrade");
                temp5.type = rs.getByte("hpmpother");
                temp5.timedelay = rs.getShort("timedelay");
                temp5.value = rs.getShort("value");
                temp5.timeactive = rs.getShort("timeactive");
                temp5.nameuse = rs.getString("nameuse");
                ItemTemplate4.ENTRYS.add(temp5);
            }
            rs.close();
            query = "SELECT * FROM `item7`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                ItemTemplate7 temp6 = new ItemTemplate7();
                temp6.id = rs.getShort("id");
                temp6.name = rs.getString("name");
                temp6.type = rs.getByte("type");
                temp6.icon = rs.getByte("icon");
                temp6.price = rs.getInt("price");
                temp6.priceruby = rs.getShort("priceruby");
                temp6.istrade = rs.getByte("istrade");
                ItemTemplate7.ENTRYS.add(temp6);
            }
            rs.close();
            System.out.println("load item ok");
            Skill_Template.ENTRYS = new ArrayList<Skill_Template>();
            query = "SELECT * FROM `skill` ORDER BY `id_index`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                Skill_Template temp_add = new Skill_Template(rs.getShort("id_index"), rs.getShort("id_2"), rs.getShort("icon"), rs.getByte("typeSkill"), rs.getByte("typeBuff"), rs.getString("name"), rs.getShort("typeEffSkill"), rs.getShort("range"));
                temp_add.getData(rs.getByte("nTarget"), rs.getShort("rangeLan"), rs.getInt("damage"), rs.getShort("manaLost"), rs.getInt("timeDelay"), rs.getByte("nKick"), rs.getString("info"), rs.getByte("Lv_RQ"), rs.getByte("typeDevil"));
                temp_add.op = new ArrayList<Option>();
                JSONArray js = (JSONArray)JSONValue.parse(rs.getString("option"));
                for (int j = 0; j < js.size(); ++j) {
                    JSONArray js2 = (JSONArray)JSONValue.parse(js.get(j).toString());
                    temp_add.op.add(new Option(Byte.parseByte(js2.get(0).toString()), Integer.parseInt(js2.get(1).toString())));
                }
                js.clear();
                js = (JSONArray)JSONValue.parse(rs.getString("EffSpec"));
                temp_add.idEffSpec = Byte.parseByte(js.get(0).toString());
                temp_add.perEffSpec = Short.parseShort(js.get(1).toString());
                temp_add.timeEffSpec = Short.parseShort(js.get(2).toString());
                js.clear();
                Skill_Template.ENTRYS.add(temp_add);
            }
            rs.close();
            System.out.println("load skill ok");
            ItemOptionTemplate.ENTRYS = new ArrayList<ItemOptionTemplate>();
            query = "SELECT * FROM `itemoption`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                ItemOptionTemplate temp7 = new ItemOptionTemplate();
                temp7.id = rs.getShort("id");
                temp7.name = rs.getString("name");
                temp7.color = rs.getByte("color");
                temp7.percent = rs.getByte("percent");
                ItemOptionTemplate.ENTRYS.add(temp7);
            }
            rs.close();
            System.out.println("load item op temp ok");
            ItemFashion.ENTRYS = new ArrayList<ItemFashion>();
            query = "SELECT * FROM `fashiontemplate`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                int id = rs.getInt("id");
                short icon = rs.getShort("icon");
                String name = rs.getString("name");
                String info = rs.getString("info");
                JSONArray js = (JSONArray)JSONValue.parse(rs.getString("mwear"));
                short[] wear = new short[js.size()];
                for (int i8 = 0; i8 < wear.length; ++i8) {
                    wear[i8] = Short.parseShort(js.get(i8).toString());
                }
                js.clear();
                js = (JSONArray)JSONValue.parse(rs.getString("op"));
                ArrayList<Option> op = new ArrayList<Option>();
                for (int i9 = 0; i9 < js.size(); ++i9) {
                    JSONArray js2 = (JSONArray)JSONValue.parse(js.get(i9).toString());
                    op.add(new Option(Byte.parseByte(js2.get(0).toString()), Integer.parseInt(js2.get(1).toString())));
                }
                ItemFashion.ENTRYS.add(new ItemFashion((byte)id, icon, name, info, wear, op, rs.getInt("price")));
            }
            rs.close();
            System.out.println("load fashion temp ok");
            Boss.ENTRYS = new ArrayList<Boss>();
            query = "SELECT * FROM `boss`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                int id = rs.getInt("id");
                int mob_id = rs.getInt("mob_id");
                String site = rs.getString("site");
                int hp = rs.getInt("hp");
                String skill = rs.getString("skill");
                String buff = rs.getString("buff");
                int level = rs.getInt("level");
                String rewards = rs.getString("rewards");
                if (rewards == null || rewards.isEmpty()) {
                    rewards = "[]";
                }
                JSONArray js = (JSONArray)JSONValue.parse(site);
                short temp_x = Short.parseShort(js.get(1).toString());
                short temp_y = Short.parseShort(js.get(2).toString());
                Map[] map = Map.get_map_by_id(Short.parseShort(js.get(0).toString()));
                js.clear();
                for (int i10 = 0; i10 < map.length; ++i10) {
                    int i2;
                    if (i10 == 0) continue;
                    Boss boss_temp = new Boss();
                    boss_temp.id = id;
                    boss_temp.mob = new Mob();
                    boss_temp.mob.mob_template = MobTemplate.ENTRYS.get(mob_id);
                    boss_temp.mob.x = temp_x;
                    boss_temp.mob.y = temp_y;
                    boss_temp.mob.hp_max = hp;
                    boss_temp.mob.hp = 0;
                    boss_temp.mob.level = level;
                    boss_temp.mob.isdie = true;
                    boss_temp.mob.id_target = -1;
                    boss_temp.mob.index = this.index_mob;
                    boss_temp.index_mob_save = this.index_mob;
                    this.index_mob += 10;
                    boss_temp.mob.boss_info = boss_temp;
                    boss_temp.mob.map = map[i10];
                    Mob.ENTRYS.put(boss_temp.mob.index, boss_temp.mob);
                    for (int j = 0; j < 10; ++j) {
                        Mob.ENTRYS.put(boss_temp.mob.index + j, boss_temp.mob);
                    }
                    js = (JSONArray)JSONValue.parse(skill);
                    boss_temp.skill = new short[js.size()];
                    for (i2 = 0; i2 < boss_temp.skill.length; ++i2) {
                        boss_temp.skill[i2] = Short.parseShort(js.get(i2).toString());
                    }
                    boss_temp.time_atk = new long[boss_temp.skill.length];
                    boss_temp.TopDame = new ArrayList<Top_Dame>();
                    boss_temp.levelBoss = 1;
                    boss_temp.rewards = rewards;
                    js.clear();
                    js = (JSONArray)JSONValue.parse(buff);
                    boss_temp.buff = new ArrayList<Option>();
                    for (i2 = 0; i2 < js.size(); ++i2) {
                        JSONArray js2 = (JSONArray)js.get(i2);
                        boss_temp.buff.add(new Option(Byte.parseByte(js2.get(0).toString()), Integer.parseInt(js2.get(1).toString())));
                    }
                    Boss.ENTRYS.add(boss_temp);
                }
            }
            rs.close();
            System.out.println("load boss ok, mob size : " + (this.index_mob - 1));
            query = "SELECT * FROM `itemhair`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                ItemHair.ENTRYS.add(ItemHair.read_json_it_hair(rs));
            }
            rs.close();
            System.out.println("load item hair ok");
            ItemTemplate8.ENTRYS = new ArrayList<ItemTemplate8>();
            query = "SELECT * FROM `item8`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                ItemTemplate8 temp8 = new ItemTemplate8();
                temp8.id = rs.getShort("id");
                temp8.name = rs.getString("name");
                temp8.icon = rs.getShort("icon");
                temp8.info = rs.getString("info");
                temp8.beri = rs.getInt("price");
                temp8.ruby = rs.getShort("priceruby");
                temp8.istrade = rs.getByte("istrade");
                temp8.type = rs.getByte("hpmpother");
                temp8.timedelay = rs.getShort("timedelay");
                temp8.value = rs.getShort("value");
                temp8.timeactive = rs.getShort("timeactive");
                temp8.nameuse = rs.getString("nameuse");
                ItemTemplate8.ENTRYS.add(temp8);
            }
            rs.close();
            System.out.println("load item clan ok");
            Clan.ENTRY = new ArrayList<Clan>();
            Clan.BXH = new ArrayList<String>();
            query = "SELECT * FROM `clan`;";
            HashSet<String> name_check = new HashSet<String>();
            rs = ps.executeQuery(query);
            while (rs.next()) {
                int i11;
                Clan clan = new Clan();
                clan.id = rs.getShort("id");
                clan.name = rs.getString("name");
                JSONArray js = (JSONArray)JSONValue.parse(rs.getString("info"));
                clan.icon = Short.parseShort(js.get(0).toString());
                clan.level = Short.parseShort(js.get(1).toString());
                clan.xp = Integer.parseInt(js.get(2).toString());
                clan.maxAttri = Short.parseShort(js.get(3).toString());
                clan.pointAttri = Short.parseShort(js.get(4).toString());
                clan.trungsinh = Byte.parseByte(js.get(5).toString());
                switch (clan.trungsinh) {
                    case 1: {
                        clan.maxAttri = (short)25;
                        break;
                    }
                    case 2: {
                        clan.maxAttri = (short)30;
                        break;
                    }
                    case 3: {
                        clan.maxAttri = (short)35;
                        break;
                    }
                    case 4: {
                        clan.maxAttri = (short)40;
                        break;
                    }
                    case 5: {
                        clan.maxAttri = (short)45;
                        break;
                    }
                    case 6: {
                        clan.maxAttri = (short)50;
                        break;
                    }
                    default: {
                        clan.maxAttri = (short)20;
                    }
                }
                clan.countAction = Integer.parseInt(js.get(6).toString());
                clan.ruby = Integer.parseInt(js.get(7).toString());
                clan.beri = Integer.parseInt(js.get(8).toString());
                clan.allowRequest = Byte.parseByte(js.get(9).toString());
                clan.opAttri = new short[]{0, 0, 0, 0, 0};
                JSONArray js2 = (JSONArray)js.get(10);
                for (i11 = 0; i11 < clan.opAttri.length; ++i11) {
                    clan.opAttri[i11] = Short.parseShort(js2.get(i11).toString());
                }
                clan.thongbao = rs.getString("notice");
                js.clear();
                clan.chat = new ArrayList<Clan_chat>();
                clan.mem_request = new ArrayList<Clan_member>();
                clan.members = new ArrayList<Clan_member>();
                js = (JSONArray)JSONValue.parse(rs.getString("member"));
                for (i11 = 0; i11 < js.size(); ++i11) {
                    js_in = (JSONArray)js.get(i11);
                    Clan_member mem = new Clan_member();
                    mem.id = (short)i11;
                    mem.name = js_in.get(0).toString();
                    mem.level = Short.parseShort(js_in.get(1).toString());
                    mem.levelInclan = Byte.parseByte(js_in.get(2).toString());
                    mem.donate = Short.parseShort(js_in.get(3).toString());
                    mem.gopRuby = Short.parseShort(js_in.get(4).toString());
                    mem.numquest = Short.parseShort(js_in.get(5).toString());
                    mem.conghien = Integer.parseInt(js_in.get(6).toString());
                    mem.head = Short.parseShort(js_in.get(7).toString());
                    mem.hair = Short.parseShort(js_in.get(8).toString());
                    mem.hat = Short.parseShort(js_in.get(9).toString());
                    mem.clazz = Byte.parseByte(js_in.get(10).toString());
                    boolean add = true;
                    int num_clazz = 0;
                    for (int j = 0; j < clan.members.size(); ++j) {
                        if (clan.members.get((int)j).clazz != mem.clazz) continue;
                        ++num_clazz;
                    }
                    if (num_clazz >= 4) {
                        System.out.println("err load clan >=4 " + clan.name + " " + mem.name);
                        add = false;
                    }
                    if (add && !name_check.contains(mem.name)) {
                        name_check.add(mem.name);
                    } else {
                        add = false;
                    }
                    if (!add) continue;
                    clan.members.add(mem);
                }
                js.clear();
                clan.list_it = new ArrayList<ItemBag47>();
                js = (JSONArray)JSONValue.parse(rs.getString("item"));
                for (i11 = 0; i11 < js.size(); ++i11) {
                    js_in = (JSONArray)js.get(i11);
                    ItemBag47 itemBag47 = new ItemBag47();
                    itemBag47.category = (byte)4;
                    itemBag47.id = Short.parseShort(js_in.get(0).toString());
                    itemBag47.quant = Short.parseShort(js_in.get(1).toString());
                    clan.list_it.add(itemBag47);
                }
                clan.buff = new ArrayList<EffTemplate>();
                js = (JSONArray)JSONValue.parse(rs.getString("buff"));
                for (i11 = 0; i11 < js.size(); ++i11) {
                    js_in = (JSONArray)js.get(i11);
                    clan.buff.add(new EffTemplate(Byte.parseByte(js_in.get(0).toString()), Integer.parseInt(js_in.get(1).toString()), Long.parseLong(js_in.get(2).toString())));
                }
                Clan.add_new_clan(clan);
            }
            rs.close();
            System.out.println("load clan ok");
            query = "SELECT * FROM `quests`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                Quest.add(rs);
            }
            Quest.add_finish_quest();
            rs.close();
            System.out.println("load quest ok");
            query = "SELECT * FROM `pet_template`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                Pet tempPet = new Pet();
                tempPet.id = rs.getShort("id");
                tempPet.name = rs.getString("name");
                tempPet.type = rs.getByte("type");
                tempPet.icon = rs.getShort("icon");
                tempPet.frame = rs.getShort("frame");
                Pet.ENTRY.add(tempPet);
            }
            rs.close();
            System.out.println("load pet ok");
            query = "SELECT * FROM `market`;";
            rs = ps.executeQuery(query);
            while (rs.next()) {
                JSONArray js2;
                int i12;
                Market tempMarket = new Market();
                tempMarket.type = rs.getByte("id");
                JSONObject jsob = (JSONObject)JSONValue.parse(rs.getString("data"));
                tempMarket.item3 = new ArrayList<ItemMarket>();
                JSONArray js = (JSONArray)JSONValue.parse(jsob.get("item3").toString());
                for (i12 = 0; i12 < js.size(); ++i12) {
                    js2 = (JSONArray)js.get(i12);
                    ItemMarket itemMarket = new ItemMarket();
                    itemMarket.load_json(js2);
                    if (itemMarket.index == -1) continue;
                    tempMarket.item3.add(itemMarket);
                }
                js.clear();
                tempMarket.item47 = new ArrayList<PotionMarket>();
                js = (JSONArray)JSONValue.parse(jsob.get("item47").toString());
                for (i12 = 0; i12 < js.size(); ++i12) {
                    js2 = (JSONArray)js.get(i12);
                    PotionMarket potionMarket = new PotionMarket();
                    potionMarket.load_json(js2);
                    if (potionMarket.index == -1) continue;
                    tempMarket.item47.add(potionMarket);
                }
                js.clear();
                Market.ENTRY.add(tempMarket);
            }
            System.out.println("load market ok");
        }
        catch (SQLException e) {
            e.printStackTrace();
            System.exit(0);
        }
        finally {
            try {
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
            catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }

    private void load_config() throws IOException {
        byte[] ab = Util.loadfile("htth.conf");
        if (ab == null) {
            System.out.println("Config file not found!");
            System.exit(0);
        }
        String data = new String(ab);
        HashMap<String, String> configMap = new HashMap<String, String>();
        StringBuilder sbd = new StringBuilder();
        boolean bo = false;
        for (int i = 0; i <= data.length(); ++i) {
            char es;
            if (i == data.length() || (es = data.charAt(i)) == '\n') {
                int j;
                bo = false;
                String sbf = sbd.toString().trim();
                if (sbf != null && !sbf.equals("") && sbf.charAt(0) != '#' && (j = sbf.indexOf(58)) > 0) {
                    String key = sbf.substring(0, j).trim();
                    String value = sbf.substring(j + 1).trim();
                    configMap.put(key, value);
                    System.out.println("config: " + key + ": " + value);
                }
                sbd.setLength(0);
                continue;
            }
            if (es == '#') {
                bo = true;
            }
            if (bo) continue;
            sbd.append(es);
        }
        this.server_port = configMap.containsKey("port") ? Integer.parseInt((String)configMap.get("port")) : 2236;
        this.server_host = configMap.containsKey("server-host") ? (String)configMap.get("server-host") : "0.0.0.0";
        this.debug = configMap.containsKey("debug") ? Boolean.parseBoolean((String)configMap.get("debug")) : false;
        this.mysql_host = configMap.containsKey("mysql-host") ? (String)configMap.get("mysql-host") : "127.0.0.1";
        this.mysql_user = configMap.containsKey("mysql-user") ? (String)configMap.get("mysql-user") : "root";
        this.mysql_pass = configMap.containsKey("mysql-password") ? (String)configMap.get("mysql-password") : "";
        this.mysql_database = configMap.containsKey("mysql-database") ? (String)configMap.get("mysql-database") : "database";
        this.exp = configMap.containsKey("exp") ? Integer.parseInt((String)configMap.get("exp")) : 1;
        this.server_admin = configMap.containsKey("serveradmin") ? Boolean.parseBoolean((String)configMap.get("serveradmin")) : false;
    }

    public void close() {
        this.stop_service();
    }

    public void chatKTG(Player p, String text) throws IOException {
        if (p.conn.user.equals("admin") || p.time_chat_ktg < System.currentTimeMillis()) {
            p.time_chat_ktg = System.currentTimeMillis() + 30000L;
            this.chatKTG(1, text, 0);
            Service.send_box_ThongBao_OK(p, "Chat KTG th\u00e0nh c\u00f4ng v\u1edbi n\u1ed9i dung: " + text);
        } else {
            Service.send_box_ThongBao_OK(p, "Ch\u1edd " + (p.time_chat_ktg - System.currentTimeMillis()) / 1000L + "s");
        }
    }

    public void chatKTG(int type, String text, int color) throws IOException {
        Message m = new Message(-31);
        m.writer().writeByte(type);
        m.writer().writeUTF(text);
        m.writer().writeByte(color);
        m.writer().writeShort(-1);
        for (Map[] mapall : Map.ENTRYS) {
            for (Map map : mapall) {
                for (int i = 0; i < map.players.size(); ++i) {
                    Player p0 = map.players.get(i);
                    if (p0.conn == null) continue;
                    p0.conn.addmsg(m);
                }
            }
        }
        List<Map> mapplus = Map.get_map_plus();
        for (int i = 0; i < mapplus.size(); ++i) {
            for (int i12 = 0; i12 < mapplus.get((int)i).players.size(); ++i12) {
                Player p0 = mapplus.get((int)i).players.get(i12);
                if (p0.conn == null) continue;
                p0.conn.addmsg(m);
            }
        }
        m.cleanup();
    }

    public TaiXiu TaiXiu() {
        return this.tx;
    }

    static {
        NAME_ITEM_SELL_TEMP = new String[]{"Shop Trang B\u1ecb V\u00f5 S\u0129", "Shop Trang B\u1ecb Ki\u1ebfm Kh\u00e1ch", "Shop Trang B\u1ecb \u0110\u1ea7u B\u1ebfp", "Shop Trang B\u1ecb Hoa Ti\u00eau", "Shop Trang B\u1ecb X\u1ea1 Th\u1ee7"};
        a = 0;
    }
}

