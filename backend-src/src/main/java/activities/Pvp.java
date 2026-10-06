/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import client.Quest;
import core.Service;
import io.Message;
import java.io.IOException;
import map.Map;
import map.Npc;
import map.Vgo;
import template.EffTemplate;
import template.Map_pvp;

public class Pvp {
    public static void show_table(Player p) throws IOException {
        Service.UpdatePvpPoint(p);
        Message m = new Message(-63);
        m.writer().writeByte(0);
        m.writer().writeShort(p.map.players.size());
        p.conn.addmsg(m);
        m.cleanup();
        p.pvp_target = null;
        p.pvp_accept = false;
    }

    public static void pvp_notice(Player p, int type) throws IOException {
        Message m = new Message(36);
        m.writer().writeByte(type);
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static void show_info(Player p, int countDown, int left, int right, int maxWin) throws IOException {
        Message m = new Message(-73);
        m.writer().writeByte(5);
        m.writer().writeShort(countDown);
        m.writer().writeByte(left);
        m.writer().writeByte(right);
        m.writer().writeByte(maxWin);
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static void find_out_other(Player p, Player p0) throws IOException {
        Message m = new Message(-63);
        m.writer().writeByte(3);
        m.writer().writeUTF("\u1ea8n danh");
        m.writer().writeByte(0);
        p.conn.addmsg(m);
        m.cleanup();
        p.pvp_accept = false;
        EffTemplate ef = p.get_eff(19);
        if (ef != null) {
            ef.time = System.currentTimeMillis() + 30000L;
        } else {
            p.add_new_eff(19, 1, 30000L);
        }
    }

    public static synchronized void process(Player p, Message m2) throws IOException {
        byte act = m2.reader().readByte();
        switch (act) {
            case 2: {
                if (p.pvp_target == null || !p.pvp_target.equals(p)) break;
                Pvp.stop_find(p);
                break;
            }
            case 1: {
                Pvp.start_find(p);
                break;
            }
            case 4: {
                if (p.pvp_target == null || p.pvp_target.equals(p) || p.pvp_target.conn == null || !p.map.equals(p.pvp_target.map) || p.map.template.id != 1000) break;
                Message m = new Message(-63);
                m.writer().writeByte(4);
                m.writer().writeByte(0);
                p.conn.addmsg(m);
                m.cleanup();
                m = new Message(-63);
                m.writer().writeByte(4);
                m.writer().writeByte(1);
                p.pvp_target.conn.addmsg(m);
                m.cleanup();
                p.pvp_accept = true;
                if (!p.pvp_accept || !p.pvp_target.pvp_accept) break;
                if (p.get_pvp_ticket() < 1) {
                    if (p.pvp_target.get_pvp_ticket() < 1) {
                        Pvp.show_table(p.pvp_target);
                        Pvp.stop_find(p.pvp_target);
                        Service.send_box_ThongBao_OK(p.pvp_target, "B\u1ea1n kh\u00f4ng \u0111\u1ee7 v\u00e9 pvp!");
                    } else {
                        Pvp.show_table(p.pvp_target);
                        Pvp.start_find(p.pvp_target);
                        Service.send_box_ThongBao_OK(p.pvp_target, "\u0110\u1ed1i ph\u01b0\u01a1ng kh\u00f4ng \u0111\u1ee7 v\u00e9 pvp, b\u1ea1n \u0111\u01b0\u1ee3c x\u1ebfp v\u00e0o h\u00e0ng \u0111\u1ee3i ti\u1ebfp!");
                    }
                    Pvp.show_table(p);
                    Pvp.stop_find(p);
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng \u0111\u1ee7 v\u00e9 pvp!");
                    return;
                }
                if (p.pvp_target.get_pvp_ticket() < 1) {
                    Pvp.show_table(p.pvp_target);
                    Pvp.stop_find(p.pvp_target);
                    Service.send_box_ThongBao_OK(p.pvp_target, "B\u1ea1n kh\u00f4ng \u0111\u1ee7 v\u00e9 pvp!");
                    Pvp.show_table(p);
                    Pvp.start_find(p);
                    Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng kh\u00f4ng \u0111\u1ee7 v\u00e9 pvp, b\u1ea1n \u0111\u01b0\u1ee3c x\u1ebfp v\u00e0o h\u00e0ng \u0111\u1ee3i ti\u1ebfp!");
                    return;
                }
                p.update_pvp_ticket(-1);
                p.pvp_target.update_pvp_ticket(-1);
                p.map.leave_map(p, 2);
                p.pvp_target.map.leave_map(p.pvp_target, 2);
                p.type_pk = (byte)-1;
                p.pvp_target.type_pk = (byte)-1;
                Map maptemp = Map.get_map_by_id(58)[0];
                Map map_create = new Map();
                map_create.template = maptemp.template;
                map_create.zone_id = 0;
                map_create.list_mob = new int[0];
                p.map = map_create;
                p.x = (short)320;
                p.y = (short)240;
                p.xold = p.x;
                p.yold = p.y;
                p.map.goto_map(p);
                Service.update_PK(p, p, true);
                Service.pet(p, p, true);
                Quest.update_map_have_side_quest(p, true);
                p.pvp_target.map = map_create;
                p.pvp_target.x = (short)380;
                p.pvp_target.y = (short)240;
                p.pvp_target.xold = p.x;
                p.pvp_target.yold = p.y;
                p.pvp_target.map.goto_map(p.pvp_target);
                Service.update_PK(p.pvp_target, p.pvp_target, true);
                Service.pet(p.pvp_target, p.pvp_target, true);
                Quest.update_map_have_side_quest(p.pvp_target, true);
                map_create.map_pvp = new Map_pvp();
                map_create.map_pvp.time_pvp = 5;
                map_create.map_pvp.status_pvp = 0;
                map_create.map_pvp.num_win_p1 = 0;
                map_create.map_pvp.num_win_p2 = 0;
                map_create.map_pvp.type_map = 0;
                map_create.start_map();
                Map.add_map_plus(map_create);
                break;
            }
            case 5: {
                if (p.pvp_target != null && !p.pvp_target.equals(p) && p.pvp_target.conn != null) {
                    Pvp.show_table(p.pvp_target);
                    Pvp.start_find(p.pvp_target);
                    Service.send_box_ThongBao_OK(p.pvp_target, "\u0110\u1ed1i th\u1ee7 r\u1eddi \u0111i, b\u1ea1n quay l\u1ea1i h\u00e0ng ch\u1edd");
                }
                p.pvp_target = null;
                Vgo vgo = new Vgo();
                vgo.map_go = Map.get_map_by_id(p.id_map_save);
                for (int i = 0; i < vgo.map_go[0].template.npcs.size(); ++i) {
                    Npc npc_temp = vgo.map_go[0].template.npcs.get(i);
                    if (!npc_temp.namegt.equals("B\u1ea3n \u0111\u1ed3")) continue;
                    vgo.xnew = npc_temp.x;
                    if (npc_temp.y < 250) {
                        vgo.ynew = (short)(npc_temp.y + 20);
                        break;
                    }
                    vgo.ynew = (short)(npc_temp.y - 40);
                    break;
                }
                if (vgo.xnew == 0 || vgo.ynew == 0) {
                    vgo.xnew = (short)(vgo.map_go[0].template.maxW / 2);
                    vgo.ynew = (short)(vgo.map_go[0].template.maxH / 2);
                }
                p.goto_map(vgo);
                break;
            }
        }
    }

    private static void stop_find(Player p) throws IOException {
        Message m = new Message(-63);
        m.writer().writeByte(2);
        p.conn.addmsg(m);
        m.cleanup();
        p.pvp_target = null;
    }

    public static void start_find(Player p) throws IOException {
        Message m = new Message(-63);
        m.writer().writeByte(1);
        p.conn.addmsg(m);
        m.cleanup();
        p.pvp_target = p;
        p.pvp_accept = false;
    }
}

