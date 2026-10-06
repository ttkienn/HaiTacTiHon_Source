/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import core.Util;
import io.Message;
import java.io.IOException;
import template.ItemTemplate4;
import template.ItemTemplate7;
import template.Skill_info;

public class UpgradeDevil {
    public static void show_table(Player p, int index) throws IOException {
        switch (index) {
            case 1: {
                Message m = new Message(45);
                m.writer().writeByte(13);
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 2: {
                Message m = new Message(45);
                m.writer().writeByte(8);
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 3: {
                Message m = new Message(45);
                m.writer().writeByte(20);
                m.writer().writeUTF("Gh\u00e9p v\u1eadt ph\u1ea9m");
                m.writer().writeByte(1);
                m.writer().writeShort(451);
                m.writer().writeShort(5);
                m.writer().writeByte(4);
                m.writer().writeShort(402);
                m.writer().writeInt(10000);
                m.writer().writeShort(0);
                m.writer().writeInt(0);
                m.writer().writeShort(452);
                m.writer().writeShort(1);
                m.writer().writeByte(4);
                m.writer().writeShort(403);
                m.writer().writeByte(20);
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 4: {
                Message m = new Message(45);
                m.writer().writeByte(20);
                m.writer().writeUTF("Gh\u00e9p v\u1eadt ph\u1ea9m");
                m.writer().writeByte(1);
                m.writer().writeShort(454);
                m.writer().writeShort(5);
                m.writer().writeByte(4);
                m.writer().writeShort(405);
                m.writer().writeInt(10000);
                m.writer().writeShort(0);
                m.writer().writeInt(0);
                m.writer().writeShort(453);
                m.writer().writeShort(1);
                m.writer().writeByte(4);
                m.writer().writeShort(404);
                m.writer().writeByte(20);
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 5: {
                Message m = new Message(45);
                m.writer().writeByte(20);
                m.writer().writeUTF("Gh\u00e9p v\u1eadt ph\u1ea9m");
                m.writer().writeByte(2);
                m.writer().writeShort(452);
                m.writer().writeShort(1);
                m.writer().writeByte(4);
                m.writer().writeShort(403);
                m.writer().writeShort(453);
                m.writer().writeShort(1);
                m.writer().writeByte(4);
                m.writer().writeShort(404);
                m.writer().writeInt(15000);
                m.writer().writeShort(0);
                m.writer().writeInt(2000);
                m.writer().writeShort(455);
                m.writer().writeShort(1);
                m.writer().writeByte(4);
                m.writer().writeShort(407);
                m.writer().writeByte(p.get_tyle_ghep_dial());
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
        }
    }

    public static void process(Player p, Message m2) throws IOException {
        byte act = m2.reader().readByte();
        short id = m2.reader().readShort();
        byte cat = m2.reader().readByte();
        short num = m2.reader().readShort();
        if (act == 9 && cat == 104 && (num == 0 || num == 1)) {
            Skill_info sk_temp = p.get_skill_temp(id);
            if (sk_temp != null) {
                if (sk_temp.lvdevil > 4) {
                    Service.send_box_ThongBao_OK(p, sk_temp.temp.name + " \u0111\u00e3 \u0111\u01b0\u1ee3c c\u01b0\u1eddng h\u00f3a t\u1ed1i \u0111a!");
                    return;
                }
                if (p.item.total_item_bag_by_id(7, 9) > 9) {
                    Message m = new Message(45);
                    m.writer().writeByte(9);
                    m.writer().writeByte(0);
                    m.writer().writeShort(id);
                    m.writer().writeByte(104);
                    m.writer().writeShort(1);
                    p.conn.addmsg(m);
                    m.cleanup();
                    m = new Message(45);
                    m.writer().writeByte(9);
                    m.writer().writeByte(1);
                    m.writer().writeShort(9);
                    m.writer().writeByte(7);
                    m.writer().writeShort(10);
                    p.conn.addmsg(m);
                    m.cleanup();
                } else {
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng c\u00f3 \u0111\u1ee7 " + ItemTemplate7.get_it_by_id((int)9).name);
                }
            }
        } else if (act == 12 && cat == 104 && num == 0) {
            Skill_info sk_temp = p.get_skill_temp(id);
            if (sk_temp != null) {
                if (sk_temp.lvdevil > 4) {
                    Service.send_box_ThongBao_OK(p, sk_temp.temp.name + " \u0111\u00e3 \u0111\u01b0\u1ee3c c\u01b0\u1eddng h\u00f3a t\u1ed1i \u0111a!");
                    return;
                }
                int percent = sk_temp.lvdevil == 0 ? 10 : (sk_temp.lvdevil == 1 ? 8 : (sk_temp.lvdevil == 2 ? 6 : (sk_temp.lvdevil == 3 ? 5 : 4)));
                p.data_yesno = new int[]{id};
                Service.send_box_yesno(p, 33, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 th\u1eadt s\u1ef1 mu\u1ed1n c\u01b0\u1eddng h\u00f3a " + sk_temp.temp.name + " kh\u00f4ng? Th\u00e0nh c\u00f4ng s\u1ebd t\u0103ng th\u00eam " + percent + "% v\u00e0o c\u1ea5p \u00e1c qu\u1ef7", new String[]{"50.000", "5", "\u0110\u00f3ng"}, new byte[]{6, 7, 1});
            }
        } else if (act == 14 && id == 29 && cat == 4 && num == 1) {
            if (p.item.total_item_bag_by_id(7, 9) < 10) {
                Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng c\u00f3 \u0111\u1ee7 " + ItemTemplate7.get_it_by_id((int)9).name);
                return;
            }
            if (p.item.total_item_bag_by_id(4, 29) < 1) {
                Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng c\u00f3 \u0111\u1ee7 " + ItemTemplate4.get_it_by_id((int)29).name);
                return;
            }
            Message m = new Message(45);
            m.writer().writeByte(14);
            m.writer().writeByte(0);
            m.writer().writeShort(29);
            m.writer().writeByte(4);
            m.writer().writeShort(1);
            p.conn.addmsg(m);
            m.cleanup();
            m = new Message(45);
            m.writer().writeByte(14);
            m.writer().writeByte(1);
            m.writer().writeShort(9);
            m.writer().writeByte(7);
            m.writer().writeShort(10);
            p.conn.addmsg(m);
            m.cleanup();
            m = new Message(45);
            m.writer().writeByte(19);
            m.writer().writeByte(5);
            p.conn.addmsg(m);
            m.cleanup();
        } else if (act == 17 && id == 29 && cat == 4 && num == 1) {
            if (p.item.total_item_bag_by_id(7, 9) < 10) {
                Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng c\u00f3 \u0111\u1ee7 " + ItemTemplate7.get_it_by_id((int)9).name);
                return;
            }
            if (p.item.total_item_bag_by_id(4, 29) < 1) {
                Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng c\u00f3 \u0111\u1ee7 " + ItemTemplate4.get_it_by_id((int)29).name);
                return;
            }
            Service.send_box_yesno(p, 34, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 th\u1eadt s\u1ef1 mu\u1ed1n n\u00e2ng c\u1ea5p r\u01b0\u01a1ng \u00e1c qu\u1ef7? th\u1ea5t b\u1ea1i s\u1ebd kh\u00f4ng m\u1ea5t r\u01b0\u01a1ng \u00e1c qu\u1ef7", new String[]{"50.000", "5", "\u0110\u00f3ng"}, new byte[]{6, 7, 1});
        } else if (act == 20 && id == 452 && cat == 4 && num == 0) {
            if (p.item.able_bag() > 0) {
                if (p.item.total_item_bag_by_id(4, 451) < 5) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 5 trang gi\u1ea5y");
                    return;
                }
                if (p.get_vang() < 10000L) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 10.000 beri");
                    return;
                }
                boolean suc = 20 > Util.random(120);
                Message m = new Message(45);
                m.writer().writeByte(21);
                m.writer().writeByte(suc ? 1 : 0);
                m.writer().writeUTF(suc ? "Ch\u00fac m\u1eebng b\u1ea1n gh\u00e9p th\u00e0nh c\u00f4ng s\u00e1ch c\u00f4ng th\u1ee9c" : "R\u1ea5t ti\u1ebfc b\u1ea1n \u0111\u00e3 gh\u00e9p th\u1ea5t b\u1ea1i");
                p.conn.addmsg(m);
                m.cleanup();
                p.update_vang(-10000L);
                p.update_money();
                p.item.remove_item47(4, 451, 5);
                if (suc) {
                    p.item.add_item_bag47(4, 452, 1);
                }
                p.item.update_Inventory(-1, false);
            } else {
                Service.send_box_ThongBao_OK(p, "Ch\u1eeba \u00edt nh\u1ea5t m\u1ed9t \u00f4 tr\u1ed1ng \u0111\u1ec3 gh\u00e9p v\u1eadt ph\u1ea9m n\u00e0y");
            }
        } else if (act == 20 && id == 453 && cat == 4 && num == 0) {
            if (p.item.able_bag() > 0) {
                if (p.item.total_item_bag_by_id(4, 454) < 5) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 5 m\u1ea3nh v\u1ecf \u1ed1c");
                    return;
                }
                if (p.get_vang() < 10000L) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 10.000 beri");
                    return;
                }
                boolean suc = 20 > Util.random(120);
                Message m = new Message(45);
                m.writer().writeByte(21);
                m.writer().writeByte(suc ? 1 : 0);
                m.writer().writeUTF(suc ? "Ch\u00fac m\u1eebng b\u1ea1n gh\u00e9p th\u00e0nh c\u00f4ng v\u1ecf \u1ed1c" : "R\u1ea5t ti\u1ebfc b\u1ea1n \u0111\u00e3 gh\u00e9p th\u1ea5t b\u1ea1i");
                p.conn.addmsg(m);
                m.cleanup();
                p.update_vang(-10000L);
                p.update_money();
                p.item.remove_item47(4, 454, 5);
                if (suc) {
                    p.item.add_item_bag47(4, 453, 1);
                }
                p.item.update_Inventory(-1, false);
            } else {
                Service.send_box_ThongBao_OK(p, "Ch\u1eeba \u00edt nh\u1ea5t m\u1ed9t \u00f4 tr\u1ed1ng \u0111\u1ec3 gh\u00e9p v\u1eadt ph\u1ea9m n\u00e0y");
            }
        } else if (act == 20 && id == 455 && cat == 4 && num == 0) {
            if (p.item.able_bag() > 0) {
                if (p.item.total_item_bag_by_id(4, 452) < 1) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 1 s\u00e1ch c\u00f4ng th\u1ee9c");
                    return;
                }
                if (p.item.total_item_bag_by_id(4, 453) < 1) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 1 v\u1ecf \u1ed1c");
                    return;
                }
                if (p.get_vang() < 15000L) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 15.000 beri");
                    return;
                }
                if (p.get_vnd() < 2000) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 2.000 extol");
                    return;
                }
                boolean suc = p.get_tyle_ghep_dial() > Util.random(150);
                Message m = new Message(45);
                m.writer().writeByte(21);
                m.writer().writeByte(suc ? 1 : 0);
                m.writer().writeUTF(suc ? "Ch\u00fac m\u1eebng b\u1ea1n gh\u00e9p th\u00e0nh c\u00f4ng r\u01b0\u01a1ng dial" : "R\u1ea5t ti\u1ebfc b\u1ea1n \u0111\u00e3 gh\u00e9p th\u1ea5t b\u1ea1i");
                p.conn.addmsg(m);
                m.cleanup();
                p.update_vang(-15000L);
                p.update_vnd(-2000L);
                p.update_money();
                p.item.remove_item47(4, 452, 1);
                p.item.remove_item47(4, 453, 1);
                if (suc) {
                    p.item.add_item_bag47(4, 455, 1);
                }
                p.item.update_Inventory(-1, false);
                p.update_skill_exp(5000, 20L);
            } else {
                Service.send_box_ThongBao_OK(p, "Ch\u1eeba \u00edt nh\u1ea5t m\u1ed9t \u00f4 tr\u1ed1ng \u0111\u1ec3 gh\u00e9p v\u1eadt ph\u1ea9m n\u00e0y");
            }
        }
    }
}

