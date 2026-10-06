/*
 * Decompiled with CFR 0.152.
 */
package client;

import client.Player;
import core.Service;
import core.Util;
import io.Message;
import java.io.IOException;
import java.util.ArrayList;
import template.EffTemplate;
import template.Skill_info;

public class Buff {
    public static void process(Player p, Message m2) throws IOException {
        short id = m2.reader().readShort();
        byte cat = m2.reader().readByte();
        int size = m2.reader().readByte();
        short[] id2 = null;
        if (size > 0) {
            id2 = new short[size];
            for (int i = 0; i < size; ++i) {
                id2[i] = m2.reader().readShort();
            }
        }
        int time_buff = 0;
        ArrayList<Integer> list_id = new ArrayList<Integer>();
        ArrayList<Integer> list_par = new ArrayList<Integer>();
        Skill_info sk_info = null;
        for (int i = 0; i < p.skill_point.size(); ++i) {
            if (p.skill_point.get((int)i).temp.ID != id || p.skill_point.get((int)i).temp.Lv_RQ <= 0) continue;
            sk_info = p.skill_point.get(i);
            block20: for (int j = 0; j < sk_info.temp.op.size(); ++j) {
                switch (sk_info.temp.op.get((int)j).id) {
                    case 32: {
                        time_buff = sk_info.temp.op.get(j).getParam() * 100;
                        continue block20;
                    }
                    default: {
                        if (sk_info.temp.op.get((int)j).id == 25 || sk_info.temp.op.get((int)j).id >= 28 && sk_info.temp.op.get((int)j).id != 53 || sk_info.temp.op.get((int)j).id < 0) continue block20;
                        list_id.add(sk_info.temp.op.get((int)j).id);
                        list_par.add(sk_info.temp.op.get(j).getParam());
                    }
                }
            }
            break;
        }
        if (sk_info != null && time_buff > 0 && cat == 0 && size == 1) {
            Service.use_potion(p, 1, -sk_info.temp.manaLost);
            Service.pet(p, p, false);
            Service.UpdateInfoMaincharInfo(p);
            Message m = new Message(20);
            m.writer().writeByte(1);
            m.writer().writeShort(id);
            m.writer().writeShort(p.index_map);
            m.writer().writeByte(0);
            m.writer().writeShort(sk_info.temp.idIcon);
            m.writer().writeShort(sk_info.get_eff_skill());
            m.writer().writeInt(time_buff);
            m.writer().writeByte(0);
            m.writer().writeByte(1);
            m.writer().writeShort(p.index_map);
            m.writer().writeByte(list_id.size());
            for (int i = 0; i < list_id.size(); ++i) {
                m.writer().writeByte((Integer)list_id.get(i));
                m.writer().writeShort((Integer)list_par.get(i));
                EffTemplate eff = p.get_eff((Integer)list_id.get(i));
                if (eff == null) {
                    p.add_new_eff((Integer)list_id.get(i) + 100, (Integer)list_par.get(i), time_buff);
                    continue;
                }
                eff.time += (long)time_buff;
            }
            switch (id) {
                case 2009: {
                    m.writer().writeByte(3);
                    m.writer().writeShort(308);
                    m.writer().writeShort(309);
                    m.writer().writeShort(310);
                    Message m12 = new Message(20);
                    m12.writer().writeByte(1);
                    m12.writer().writeShort(id);
                    m12.writer().writeShort(p.index_map);
                    m12.writer().writeByte(0);
                    m12.writer().writeShort(sk_info.temp.idIcon);
                    m12.writer().writeShort(sk_info.get_eff_skill());
                    m12.writer().writeInt(time_buff);
                    m12.writer().writeByte(0);
                    m12.writer().writeByte(1);
                    m12.writer().writeShort(p.index_map);
                    m12.writer().writeByte(3);
                    m12.writer().writeShort(308);
                    m12.writer().writeShort(309);
                    m12.writer().writeShort(310);
                    for (int i = 0; i < p.map.players.size(); ++i) {
                        if (p.map.players.get(i).equals(p)) continue;
                        p.map.players.get((int)i).conn.addmsg(m12);
                    }
                    m12.cleanup();
                    break;
                }
                case 2016: {
                    m.writer().writeByte(3);
                    m.writer().writeShort(341);
                    m.writer().writeShort(342);
                    m.writer().writeShort(343);
                    Message m12 = new Message(20);
                    m12.writer().writeByte(1);
                    m12.writer().writeShort(id);
                    m12.writer().writeShort(p.index_map);
                    m12.writer().writeByte(0);
                    m12.writer().writeShort(sk_info.temp.idIcon);
                    m12.writer().writeShort(sk_info.get_eff_skill());
                    m12.writer().writeInt(time_buff);
                    m12.writer().writeByte(0);
                    m12.writer().writeByte(1);
                    m12.writer().writeShort(p.index_map);
                    m12.writer().writeByte(3);
                    m12.writer().writeShort(341);
                    m12.writer().writeShort(342);
                    m12.writer().writeShort(343);
                    for (int i = 0; i < p.map.players.size(); ++i) {
                        if (p.map.players.get(i).equals(p)) continue;
                        p.map.players.get((int)i).conn.addmsg(m12);
                    }
                    m12.cleanup();
                    break;
                }
                case 2037: {
                    m.writer().writeByte(3);
                    m.writer().writeShort(490);
                    m.writer().writeShort(491);
                    m.writer().writeShort(492);
                    p.add_new_eff(6, 1, time_buff);
                    Message m12 = new Message(20);
                    m12.writer().writeByte(1);
                    m12.writer().writeShort(id);
                    m12.writer().writeShort(p.index_map);
                    m12.writer().writeByte(0);
                    m12.writer().writeShort(sk_info.temp.idIcon);
                    m12.writer().writeShort(sk_info.get_eff_skill());
                    m12.writer().writeInt(time_buff);
                    m12.writer().writeByte(0);
                    m12.writer().writeByte(1);
                    m12.writer().writeShort(p.index_map);
                    m12.writer().writeByte(3);
                    m12.writer().writeShort(490);
                    m12.writer().writeShort(491);
                    m12.writer().writeShort(492);
                    for (int i = 0; i < p.map.players.size(); ++i) {
                        if (p.map.players.get(i).equals(p)) continue;
                        p.map.players.get((int)i).conn.addmsg(m12);
                    }
                    m12.cleanup();
                    break;
                }
                case 2040: {
                    m.writer().writeByte(3);
                    m.writer().writeShort(659);
                    m.writer().writeShort(660);
                    m.writer().writeShort(661);
                    p.add_new_eff(6, 1, time_buff);
                    Message m12 = new Message(20);
                    m12.writer().writeByte(1);
                    m12.writer().writeShort(id);
                    m12.writer().writeShort(p.index_map);
                    m12.writer().writeByte(0);
                    m12.writer().writeShort(sk_info.temp.idIcon);
                    m12.writer().writeShort(sk_info.get_eff_skill());
                    m12.writer().writeInt(time_buff);
                    m12.writer().writeByte(0);
                    m12.writer().writeByte(1);
                    m12.writer().writeShort(p.index_map);
                    m12.writer().writeByte(3);
                    m12.writer().writeShort(659);
                    m12.writer().writeShort(660);
                    m12.writer().writeShort(661);
                    for (int i = 0; i < p.map.players.size(); ++i) {
                        if (p.map.players.get(i).equals(p)) continue;
                        p.map.players.get((int)i).conn.addmsg(m12);
                    }
                    m12.cleanup();
                    break;
                }
                default: {
                    m.writer().writeByte(0);
                }
            }
            p.conn.addmsg(m);
            m.cleanup();
            p.send_skill();
            p.update_info_to_all();
            if (id != 2009 && id != 2016 && id != 2037 && id != 2040 && sk_info.temp.typeSkill == 2 && sk_info.temp.nTarget > 1 && p.party != null) {
                int num_party_eff = 1;
                for (int j = 0; j < p.party.list.size(); ++j) {
                    Player p0 = p.party.list.get(j);
                    if (p0.conn != null && !p0.name.equals(p.name) && p0.map.equals(p.map)) {
                        m = new Message(20);
                        m.writer().writeByte(0);
                        m.writer().writeShort(id);
                        m.writer().writeShort(p0.index_map);
                        m.writer().writeByte(0);
                        m.writer().writeShort(sk_info.temp.idIcon);
                        m.writer().writeShort(sk_info.get_eff_skill());
                        m.writer().writeInt(time_buff);
                        m.writer().writeByte(0);
                        m.writer().writeByte(1);
                        m.writer().writeShort(p0.index_map);
                        m.writer().writeByte(list_id.size());
                        for (int i = 0; i < list_id.size(); ++i) {
                            m.writer().writeByte((Integer)list_id.get(i));
                            m.writer().writeShort((Integer)list_par.get(i));
                            EffTemplate eff = p0.get_eff((Integer)list_id.get(i));
                            if (eff != null) continue;
                            p0.add_new_eff((Integer)list_id.get(i) + 100, (Integer)list_par.get(i), time_buff);
                        }
                        m.writer().writeByte(0);
                        p0.conn.addmsg(m);
                        m.cleanup();
                        p0.update_info_to_all();
                        ++num_party_eff;
                    }
                    if (num_party_eff >= sk_info.temp.nTarget) break;
                }
            }
            switch (id) {
                case 1010: {
                    p.add_new_eff(11, 1, time_buff);
                    break;
                }
                case 1011: {
                    p.add_new_eff(12, 1, time_buff);
                    break;
                }
                case 1012: {
                    p.add_new_eff(13, 1, time_buff);
                    Service.Main_char_Info(p);
                    break;
                }
                case 1013: {
                    p.add_new_eff(14, 1, time_buff);
                    break;
                }
                case 1014: {
                    if (id2 == null) break;
                    Player p2 = null;
                    for (int i = 0; i < p.map.players.size(); ++i) {
                        if (p.map.players.get((int)i).index_map == p.index_map || p2 != null && (Math.abs(p.map.players.get((int)i).x - p.x) >= Math.abs(p.map.players.get((int)i).x - p2.x) || Math.abs(p.map.players.get((int)i).y - p.y) >= Math.abs(p.map.players.get((int)i).y - p2.y))) continue;
                        p2 = p.map.players.get(i);
                    }
                    if (p2 == null || !(p.typePirate == 0 && p2.typePirate == 2 || p.typePirate == 2 && p2.typePirate == 0 || p.typePirate == 1 && p2.typePirate == 2 || p.typePirate == 2 && p2.typePirate == 1 || p.type_pk == 14 && p2.type_pk == 15 || p.type_pk == 15 && p2.type_pk == 14 || p.typePirate == 2 && p2.typePirate == 2 || p.type_pk == 0 || p2.type_pk == 1 || p.type_pk == 3 && p2.type_pk == 3 || p2.type_pk == 0 || p.type_pk == 3 && p2.type_pk >= 4 && p2.type_pk <= 8 || p2.type_pk == 3 && p.type_pk >= 4 && p.type_pk <= 8) && (p.type_pk < 4 || p.type_pk > 8 || p2.type_pk < 4 || p2.type_pk > 8 || p.type_pk == p2.type_pk) || Math.abs(p2.x - p.x) >= 200 || Math.abs(p2.y - p.y) >= 200) break;
                    m = new Message(-15);
                    m.writer().writeByte(4);
                    m.writer().writeShort(p.index_map);
                    m.writer().writeByte(0);
                    m.writer().writeShort(500);
                    m.writer().writeShort(p2.index_map);
                    m.writer().writeByte(0);
                    p.map.send_msg_all_p(m, p, true);
                    m.cleanup();
                    Buff.send_choang(p, p2, 4000);
                    break;
                }
                case 2059: {
                    EffTemplate eff = p.get_eff(18);
                    if (eff == null) {
                        if (3 > Util.random(120)) {
                            p.add_new_eff(18, 280, time_buff);
                            break;
                        }
                        p.add_new_eff(18, 180, time_buff);
                        break;
                    }
                    eff.time += (long)time_buff;
                    if (3 > Util.random(120)) {
                        eff.param = 280;
                        break;
                    }
                    eff.param = 180;
                    break;
                }
                case 2056: {
                    Message m2055 = new Message(74);
                    m2055.writer().writeByte(1);
                    m2055.writer().writeShort(p.index_map);
                    m2055.writer().writeShort(3);
                    m2055.writer().writeInt(time_buff);
                    m2055.writer().writeByte(0);
                    m2055.writer().writeByte(10);
                    p.map.send_msg_all_p(m2055, null, true);
                    m2055.cleanup();
                    break;
                }
            }
        }
    }

    public static void send_choang(Player p, Player p2, int time) throws IOException {
        Message m = new Message(28);
        m.writer().writeShort(p2.index_map);
        m.writer().writeByte(0);
        m.writer().writeInt(p2.hp);
        m.writer().writeInt(p2.body.get_hp_max(true));
        m.writer().writeShort(1);
        m.writer().writeShort(time / 100);
        p.map.send_msg_all_p(m, p, true);
        m.cleanup();
    }
}

