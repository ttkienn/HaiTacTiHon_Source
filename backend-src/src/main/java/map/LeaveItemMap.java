/*
 * Decompiled with CFR 0.152.
 */
package map;

import client.Player;
import core.Manager;
import core.Util;
import io.Message;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import map.Map;
import map.Mob;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.JSONValue;
import template.DataTemplate;
import template.ItemMap;
import template.ItemSell;
import template.ItemTemplate3;
import template.ItemTemplate4;
import template.ItemTemplate7;
import template.QuestP;

public class LeaveItemMap {
    public static short[] ITEM_POTION = new short[]{0, 2, 3, 4, 5};

    public static void leave_item4(Map map, Mob mob_target, Player p) throws IOException {
        ItemMap itm = new ItemMap();
        itm.id = ITEM_POTION[Util.random(ITEM_POTION.length)];
        if (50 > Util.random(120)) {
            itm.id = mob_target.level / 10 + 7;
        }
        ItemTemplate4 temp4 = ItemTemplate4.get_it_by_id(itm.id);
        itm.category = (byte)4;
        itm.icon = temp4.icon;
        itm.color = 0;
        if (itm.id == 0 || itm.id == 1) {
            int vang_random = mob_target.level * (itm.id == 1 ? 2 : 12);
            vang_random -= vang_random * Util.random(10) / 100;
            vang_random = vang_random * (1000 + p.body.get_percent_beri_train()) / 1000;
            itm.quant = vang_random *= Manager.gI().beri_rate;
            itm.name = vang_random + " " + temp4.name;
        } else {
            itm.quant = Util.random(1, 2);
            itm.name = temp4.name;
        }
        itm.id_master = p.index_map;
        itm.time_exist = System.currentTimeMillis() + 50000L;
        itm.index = (short)map.get_index_item_map();
        ArrayList<ItemMap> list_show = new ArrayList<ItemMap>();
        if (itm.index > -1 && p.item.total_item_bag_by_id(4, itm.id) < 2000) {
            map.list_it_map[itm.index] = itm;
            list_show.add(itm);
        }
        try {
            JSONArray js_drops;
            if (Manager.gI().monster_drops != null && !Manager.gI().monster_drops.equals("[]") && (js_drops = (JSONArray)JSONValue.parse(Manager.gI().monster_drops)) != null) {
                for (int r = 0; r < js_drops.size(); ++r) {
                    Object temp_add;
                    JSONObject drop_obj = (JSONObject)js_drops.get(r);
                    int rate = Integer.parseInt(drop_obj.get("rate").toString());
                    int final_rate = rate * Manager.gI().drop_rate;
                    if (final_rate <= Util.random(120)) continue;
                    int type = Integer.parseInt(drop_obj.get("type").toString());
                    int id = Integer.parseInt(drop_obj.get("id").toString());
                    int quant = Integer.parseInt(drop_obj.get("quant").toString());
                    ItemMap custom_itm = new ItemMap();
                    custom_itm.id = id;
                    custom_itm.category = (byte)type;
                    custom_itm.color = 0;
                    custom_itm.quant = quant;
                    if (type == 4 || type == 7) {
                        temp_add = ItemTemplate4.get_it_by_id(id);
                        if (temp_add != null) {
                            custom_itm.icon = ((ItemTemplate4)temp_add).icon;
                            custom_itm.name = ((ItemTemplate4)temp_add).name;
                        }
                    } else if (type == 3 && (temp_add = ItemTemplate3.get_it_by_id(id)) != null) {
                        custom_itm.icon = ((ItemTemplate3)temp_add).icon;
                        custom_itm.name = ((ItemTemplate3)temp_add).name;
                        custom_itm.color = ((ItemTemplate3)temp_add).color;
                    }
                    custom_itm.id_master = p.index_map;
                    custom_itm.time_exist = System.currentTimeMillis() + 50000L;
                    custom_itm.index = (short)map.get_index_item_map();
                    if (custom_itm.index <= -1 || p.item.total_item_bag_by_id(type, id) >= 2000) continue;
                    map.list_it_map[custom_itm.index] = custom_itm;
                    list_show.add(custom_itm);
                }
            }
        }
        catch (Exception e) {
            e.printStackTrace();
        }
        if (list_show.size() > 0) {
            LeaveItemMap.show_item_map(map, list_show, mob_target, p);
        }
    }

    public static void leave_item4_little_garden(Map map, Mob mob_target, Player p) throws IOException {
        ItemMap itm = new ItemMap();
        switch (mob_target.mob_template.mob_id) {
            case 81: {
                itm.id = Util.random(94, 97);
                break;
            }
            default: {
                itm.id = 2 > Util.random(180) ? (15 > Util.random(120) ? 98 : 100) : (15 > Util.random(120) ? 97 : 99);
            }
        }
        ItemTemplate4 temp4 = ItemTemplate4.get_it_by_id(itm.id);
        itm.category = (byte)4;
        itm.icon = temp4.icon;
        itm.color = 0;
        itm.quant = 1;
        itm.name = temp4.name;
        itm.id_master = p.index_map;
        itm.time_exist = System.currentTimeMillis() + 50000L;
        itm.index = (short)map.get_index_item_map();
        if (itm.index > -1 && p.item.total_item_bag_by_id(4, itm.id) < 2000) {
            map.list_it_map[itm.index] = itm;
            ArrayList<ItemMap> list_show = new ArrayList<ItemMap>();
            list_show.add(itm);
            LeaveItemMap.show_item_map(map, list_show, mob_target, p);
        }
    }

    public static void leave_item7(Map map, Mob mob_target, Player p) throws IOException {
        ItemMap itm = new ItemMap();
        itm.id = 0;
        ItemTemplate7 temp7 = ItemTemplate7.get_it_by_id(itm.id);
        itm.category = (byte)7;
        itm.icon = temp7.icon;
        itm.color = 0;
        itm.quant = Util.random(1, 2);
        itm.name = temp7.name;
        itm.id_master = p.index_map;
        itm.time_exist = System.currentTimeMillis() + 50000L;
        itm.index = (short)map.get_index_item_map();
        if (itm.index > -1 && p.item.total_item_bag_by_id(7, itm.id) < 2000) {
            map.list_it_map[itm.index] = itm;
            ArrayList<ItemMap> list_show = new ArrayList<ItemMap>();
            list_show.add(itm);
            LeaveItemMap.show_item_map(map, list_show, mob_target, p);
        }
    }

    public static void leave_item_quest(Map map, Mob mob_target, Player p) throws IOException {
        ArrayList<QuestP> questCheck = new ArrayList<QuestP>();
        for (int j = 0; j < p.list_quest.size(); ++j) {
            QuestP tempP = p.list_quest.get(j);
            if (tempP.template.statusQuest != 1) continue;
            for (int k = 0; k < tempP.data.length; ++k) {
                if (tempP.data[k].length != 4 || tempP.data[k][0] != 2 || questCheck.contains(tempP)) continue;
                questCheck.add(tempP);
            }
        }
        ItemMap itm = new ItemMap();
        itm.id = -1;
        itm.category = (byte)5;
        itm.icon = -1;
        itm.color = 0;
        itm.quant = 1;
        itm.name = "";
        itm.id_master = p.index_map;
        itm.time_exist = System.currentTimeMillis() + 50000L;
        itm.index = (short)map.get_index_item_map();
        block2: for (int j = 0; j < questCheck.size(); ++j) {
            QuestP tempP = (QuestP)questCheck.get(j);
            for (int i = 0; i < tempP.data.length; ++i) {
                if (tempP.data[i][1] == 0 && mob_target.mob_template.mob_id == 1) {
                    itm.id = 0;
                    itm.icon = 0;
                } else if (tempP.data[i][1] == 2 && mob_target.mob_template.mob_id == 46) {
                    itm.id = 2;
                    itm.icon = 2;
                } else if (tempP.data[i][1] == 1 && mob_target.mob_template.mob_id == 6) {
                    itm.id = 1;
                    itm.icon = 1;
                } else if (tempP.data[i][1] == 3 && mob_target.mob_template.mob_id == 47) {
                    itm.id = 3;
                    itm.icon = 3;
                } else if (tempP.data[i][1] == 4 && mob_target.mob_template.mob_id == 48) {
                    itm.id = 4;
                    itm.icon = 4;
                } else if (tempP.data[i][1] == 5 && mob_target.mob_template.mob_id == 49) {
                    itm.id = 5;
                    itm.icon = 5;
                } else if (tempP.data[i][1] == 6 && mob_target.mob_template.mob_id == 50) {
                    itm.id = 6;
                    itm.icon = 6;
                } else if (tempP.data[i][1] == 7 && mob_target.mob_template.mob_id == 51) {
                    itm.id = 7;
                    itm.icon = 7;
                } else if (tempP.data[i][1] == 8 && mob_target.mob_template.mob_id == 52) {
                    itm.id = 8;
                    itm.icon = 8;
                } else if (tempP.data[i][1] == 9 && mob_target.mob_template.mob_id == 54) {
                    itm.id = 9;
                    itm.icon = 9;
                } else if (tempP.data[i][1] == 10 && mob_target.mob_template.mob_id == 55) {
                    itm.id = 10;
                    itm.icon = 10;
                } else if (tempP.data[i][1] == 11 && mob_target.mob_template.mob_id == 60) {
                    itm.id = 11;
                    itm.icon = 11;
                } else if (tempP.data[i][1] == 12 && mob_target.mob_template.mob_id == 61) {
                    itm.id = 12;
                    itm.icon = 12;
                } else if (tempP.data[i][1] == 13 && mob_target.mob_template.mob_id == 71) {
                    itm.id = 13;
                    itm.icon = 13;
                } else if (tempP.data[i][1] == 14 && mob_target.mob_template.mob_id == 72) {
                    itm.id = 14;
                    itm.icon = 14;
                } else if (tempP.data[i][1] == 15 && mob_target.mob_template.mob_id == 95) {
                    itm.id = 15;
                    itm.icon = 15;
                } else if (tempP.data[i][1] == 16 && mob_target.mob_template.mob_id == 113) {
                    itm.id = 16;
                    itm.icon = 16;
                } else if (tempP.data[i][1] == 17 && mob_target.mob_template.mob_id == 100) {
                    itm.id = 17;
                    itm.icon = 17;
                }
                if (itm.id > -1) continue block2;
            }
        }
        if (itm.id > -1 && itm.index > -1) {
            itm.name = DataTemplate.NamePotionquest[itm.id];
            map.list_it_map[itm.index] = itm;
            ArrayList<ItemMap> list_show = new ArrayList<ItemMap>();
            list_show.add(itm);
            LeaveItemMap.show_item_map(map, list_show, mob_target, p);
        }
    }

    public static void show_item_map(Map map, List<ItemMap> list_show, Mob mob_target, Player p) throws IOException {
        Message m = new Message(11);
        m.writer().writeByte(list_show.size());
        for (int i = 0; i < list_show.size(); ++i) {
            ItemMap itm = list_show.get(i);
            m.writer().writeShort(itm.index);
            m.writer().writeByte(itm.category);
            m.writer().writeShort(itm.icon);
            m.writer().writeByte(itm.color);
            m.writer().writeUTF(itm.name);
            m.writer().writeShort(mob_target != null ? mob_target.index : -1);
            m.writer().writeByte(1);
            if (p == null) {
                p = map.get_player_by_id_inmap(itm.id_master);
            }
            m.writer().writeShort(p != null ? (int)p.index_map : -1);
        }
        map.send_msg_all_p(m, null, true);
        m.cleanup();
    }

    public static void leave_item3(Map map, Mob mob_target, Player p) throws IOException {
        byte it_color = (byte)(80 <= Util.random(120) ? 1 : 0);
        List<ItemSell> list_sell = ItemSell.get_it_sell(p.level, Util.random(5));
        ItemSell it_sell_temp = list_sell.get(Util.random(list_sell.size()));
        ItemTemplate3 template3 = ItemTemplate3.get_it_by_id(it_sell_temp.id);
        for (int dem = 0; dem < 100 && it_color != template3.color; ++dem) {
            it_sell_temp = list_sell.get(Util.random(list_sell.size()));
            template3 = ItemTemplate3.get_it_by_id(it_sell_temp.id);
        }
        ItemMap itm = new ItemMap();
        itm.id = template3.id;
        itm.category = (byte)3;
        itm.icon = template3.icon;
        itm.color = template3.color;
        itm.quant = 1;
        itm.name = template3.name;
        itm.id_master = p.index_map;
        itm.time_exist = System.currentTimeMillis() + 50000L;
        itm.index = (short)map.get_index_item_map();
        if (itm.index > -1) {
            map.list_it_map[itm.index] = itm;
            ArrayList<ItemMap> list_show = new ArrayList<ItemMap>();
            list_show.add(itm);
            LeaveItemMap.show_item_map(map, list_show, mob_target, p);
        }
    }
}

