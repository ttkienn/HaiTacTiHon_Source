/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import io.Message;
import java.io.IOException;
import template.Skill_Template;
import template.Skill_info;

public class Learn_Skill {
    public static void process(Player p, Message m2) throws IOException {
        byte act = m2.reader().readByte();
        short id = m2.reader().readShort();
        switch (act) {
            case 0: {
                int i;
                Skill_info sk_temp = null;
                for (i = 0; i < p.skill_point.size(); ++i) {
                    if (p.skill_point.get((int)i).temp.Lv_RQ != -1 || p.skill_point.get((int)i).temp.indexSkillInServer != id) continue;
                    sk_temp = p.skill_point.get(i);
                    break;
                }
                if (sk_temp == null) {
                    for (i = 0; i < p.skill_point.size(); ++i) {
                        if (p.skill_point.get((int)i).temp.Lv_RQ == -1 || p.skill_point.get((int)i).temp.indexSkillInServer != id - 1) continue;
                        sk_temp = p.skill_point.get(i);
                        break;
                    }
                }
                if (sk_temp != null) {
                    if (p.get_vang() < 10000L) {
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng \u0111\u1ee7 10k Beri. Ph\u00ed h\u1ecdc k\u1ef9 n\u0103ng n\u00e0y l\u00e0 10k Beri!");
                        return;
                    }
                    if (Skill_Template.learn_skill(sk_temp)) {
                        p.update_vang(-10000L);
                        p.update_money();
                        p.send_skill();
                        p.update_info_to_all();
                        Service.send_box_ThongBao_OK(p, "H\u1ecdc Th\u00e0nh c\u00f4ng " + sk_temp.temp.name);
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "C\u00f3 l\u1ed7i x\u1ea3y ra khi h\u1ecdc skill, h\u00e3y b\u00e1o cho admin fix ngay");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "C\u00f3 l\u1ed7i x\u1ea3y ra, h\u00e3y th\u1eed l\u1ea1i");
                break;
            }
        }
    }

    public static void request_learn_new_skill(Player p, Skill_info temp) throws IOException {
        Message m = new Message(-28);
        m.writer().writeByte(0);
        p.write_data_skill(m.writer(), temp);
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static void send_skill_percent(Player p, Skill_info sk_info) throws IOException {
        Message m = new Message(-28);
        m.writer().writeByte(2);
        m.writer().writeShort(sk_info.temp.ID);
        m.writer().writeShort(sk_info.get_percent());
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static void remove_skill(Player p, Skill_info sk_info) throws IOException {
        Message m = new Message(-28);
        m.writer().writeByte(3);
        m.writer().writeShort(sk_info.temp.ID);
        p.conn.addmsg(m);
        m.cleanup();
    }
}

