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

public class Ship {
    public static void show_table(Player p) throws IOException {
        if (p.map.template.id == 1 && p.typePirate == 0) {
            Message m = new Message(-19);
            m.writer().writeByte(101);
            m.writer().writeUTF("L\u00e1i bu\u00f4n");
            m.writer().writeByte(4);
            m.writer().writeShort(4);
            m.writer().writeShort(39);
            m.writer().writeShort(1);
            m.writer().writeShort(38);
            m.writer().writeShort(1);
            m.writer().writeShort(37);
            m.writer().writeShort(1);
            m.writer().writeShort(36);
            m.writer().writeShort(1);
            p.conn.addmsg(m);
            m.cleanup();
            Ship.notice_ship_packet(p, 36);
        }
    }

    private static void notice_ship_packet(Player p, int type) throws IOException {
        if (p.map.template.id == 1 && p.typePirate == 0) {
            Message m = new Message(-53);
            m.writer().writeByte(0);
            m.writer().writeUTF("G\u00f3i h\u00e0ng hi\u1ec7n t\u1ea1i c\u1ee7a b\u1ea1n l\u00e0 " + ItemTemplate4.get_item_name(type));
            m.writer().writeShort(type);
            p.conn.addmsg(m);
            m.cleanup();
            p.id_ship_packet = (short)type;
        }
    }

    public static void process(Player p, Message m2) throws IOException {
        if (p.map.template.id == 1 && p.typePirate == 0) {
            byte act = m2.reader().readByte();
            switch (act) {
                case 0: {
                    if (p.item.total_item_bag_by_id(4, 361) > 0) {
                        if (80 > Util.random(120)) {
                            Ship.notice_ship_packet(p, 36);
                        } else if (90 > Util.random(120)) {
                            Ship.notice_ship_packet(p, 37);
                        } else if (95 > Util.random(120)) {
                            Ship.notice_ship_packet(p, 38);
                        } else {
                            Ship.notice_ship_packet(p, 39);
                        }
                        p.item.remove_item47(4, 361, 1);
                        p.item.update_Inventory(-1, false);
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 1 " + ItemTemplate4.get_item_name(361));
                    break;
                }
                case 1: {
                    if (p.id_ship_packet == -1) break;
                    Service.send_box_yesno(p, 50, "Th\u00f4ng b\u00e1o", "\u0110\u1ec3 tham gia l\u00e1i bu\u00f4n, b\u1ea1n ph\u1ea3i m\u1ea5t 10.000 beri, b\u1ea1n c\u00f3 mu\u1ed1n tham gia?", new String[]{"10.000", "H\u1ee7y"}, new byte[]{6, -1});
                }
            }
        }
    }

    public static void notice_start_shipping(Player p) throws IOException {
        if (p.map.template.id == 1 && p.typePirate == 0 && p.id_ship_packet != -1) {
            Message m = new Message(-53);
            m.writer().writeByte(1);
            m.writer().writeUTF("G\u00f3i h\u00e0ng " + ItemTemplate4.get_item_name(p.id_ship_packet) + " c\u1ee7a b\u1ea1n \u0111ang \u0111\u01b0\u1ee3c chuy\u1ec3n \u0111\u1ebfn, l\u00ean \u0111\u01b0\u1eddng may m\u1eafn");
            p.conn.addmsg(m);
            m.cleanup();
        }
    }
}

