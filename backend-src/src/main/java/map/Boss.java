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
import map.Vgo;
import template.Option;
import template.Top_Dame;

public class Boss {
    public static List<Boss> ENTRYS;
    public static byte[] BOSS_LIVE;
    public static byte[] BOSS_AREA;
    public static byte[] TIME_NOW;
    public int id;
    public Mob mob;
    public byte levelBoss;
    public short[] skill;
    public List<Option> buff;
    public long[] time_atk;
    public List<Top_Dame> TopDame;
    public int index_mob_save;
    public String rewards = "[]";

    public static void create_boss() {
        for (short i0 = 135; i0 < 141; ++i0) {
            ArrayList<Boss> list_init = new ArrayList<Boss>();
            for (int i = 0; i < ENTRYS.size(); ++i) {
                Boss temp = ENTRYS.get(i);
                temp.TopDame.clear();
                if (!temp.mob.isdie || i0 != temp.mob.mob_template.mob_id) continue;
                list_init.add(temp);
            }
            if (list_init.size() <= 0 || BOSS_LIVE[i0 - 135] != 0) continue;
            Boss temp = (Boss)list_init.get(Util.random(list_init.size()));
            if (!temp.mob.isdie) continue;
            temp.mob.isdie = false;
            temp.mob.hp = temp.mob.hp_max;
            temp.mob.id_target = -1;
            temp.levelBoss = 1;
            temp.mob.index = temp.index_mob_save;
            try {
                Boss.BOSS_AREA[i0 - 135] = temp.mob.map.zone_id;
                temp.mob.map.can_PK = false;
                Manager.gI().chatKTG(0, "Si\u00eau tr\u00f9m \u0111\u00e3 xu\u1ea5t hi\u1ec7n h\u00e3y c\u00f9ng s\u0103n th\u00f4i n\u00e0o. " + temp.mob.mob_template.name + " xu\u1ea5t hi\u1ec7n t\u1ea1i " + temp.mob.map.template.name + " khu " + (temp.mob.map.zone_id + 1), 5);
                System.out.println("boss " + temp.mob.mob_template.name + " map " + temp.mob.map.template.name + " khu " + (temp.mob.map.zone_id + 1));
                ArrayList<Player> list_p = new ArrayList<Player>();
                for (int j = 0; j < temp.mob.map.players.size(); ++j) {
                    Player p0 = temp.mob.map.players.get(j);
                    if (p0.level / 10 == temp.mob.level / 10) continue;
                    list_p.add(p0);
                }
                Vgo vgo = new Vgo();
                vgo.map_go = Map.get_map_by_id(temp.mob.map.template.id);
                list_p.forEach(l -> {
                    try {
                        vgo.xnew = l.x;
                        vgo.ynew = l.y;
                        l.goto_map(vgo);
                    }
                    catch (IOException e) {
                        e.printStackTrace();
                    }
                });
                Message m_local = new Message(1);
                m_local.writer().writeByte(1);
                m_local.writer().writeShort(temp.mob.index);
                m_local.writer().writeShort(temp.mob.x);
                m_local.writer().writeShort(temp.mob.y);
                for (int j = 0; j < temp.mob.map.players.size(); ++j) {
                    Player p0 = temp.mob.map.players.get(j);
                    p0.conn.addmsg(m_local);
                }
                m_local.cleanup();
            }
            catch (IOException iOException) {
                // empty catch block
            }
            Boss.BOSS_LIVE[i0 - 135] = 1;
        }
    }

    public static Mob get_mob(Player p, int id) {
        for (int i = 0; i < ENTRYS.size(); ++i) {
            Boss tempB = ENTRYS.get(i);
            if (tempB.mob.isdie || tempB.mob.map.template.id != p.map.template.id || tempB.mob.index != id) continue;
            Mob temp_mob = tempB.mob;
            if (temp_mob.isdie) continue;
            return temp_mob;
        }
        return null;
    }

    public static void result_boss() {
        int i;
        short[][] list = new short[][]{{135}, {136}, {137}, {138}, {139}, {140}};
        for (int i12 = 0; i12 < list.length; ++i12) {
            List<Top_Dame> list_select = null;
            for (int i2 = 0; i2 < ENTRYS.size(); ++i2) {
                if (list[i12][0] == Boss.ENTRYS.get((int)i2).mob.mob_template.mob_id && Boss.ENTRYS.get((int)i2).TopDame.size() > 0) {
                    list_select = Boss.ENTRYS.get((int)i2).TopDame;
                    break;
                }
                Boss.ENTRYS.get((int)i2).mob.map.can_PK = true;
            }
            if (list_select == null) continue;
            List<Top_Dame> i2 = Util.sort(list_select);
        }
        ArrayList<Boss> list_remove = new ArrayList<Boss>();
        for (i = 0; i < ENTRYS.size(); ++i) {
            Boss temp = ENTRYS.get(i);
            if (temp.mob.isdie) continue;
            list_remove.add(temp);
        }
        for (i = 0; i < list_remove.size(); ++i) {
            Boss temp = (Boss)list_remove.get(i);
            temp.mob.isdie = true;
            try {
                temp.mob.map.remove_obj(temp.mob.index, 1);
                continue;
            }
            catch (IOException e) {
                e.printStackTrace();
            }
        }
        try {
            Manager.gI().chatKTG(0, "Ho\u1ea1t \u0111\u1ed9ng s\u0103n si\u00eau tr\u00f9m h\u00f4m nay \u0111\u00e3 k\u1ebft th\u00fac", 5);
        }
        catch (IOException e) {
            e.printStackTrace();
        }
        BOSS_LIVE = new byte[]{0, 0, 0, 0, 0, 0};
        BOSS_AREA = new byte[]{-1, -1, -1, -1, -1, -1};
    }

    static {
        BOSS_LIVE = new byte[]{0, 0, 0, 0, 0, 0};
        BOSS_AREA = new byte[]{-1, -1, -1, -1, -1, -1};
        TIME_NOW = new byte[]{18, 0, 0};
    }
}
