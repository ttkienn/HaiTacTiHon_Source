/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import io.Message;
import java.io.IOException;
import template.Item_wear;

public class ChuyenHoa {
    public static void show_table(Player p) throws IOException {
        Message m = new Message(-77);
        m.writer().writeByte(0);
        p.conn.addmsg(m);
        m.cleanup();
        p.item_chuyenhoa_save_0 = null;
        p.item_chuyenhoa_save_1 = null;
    }

    public static void process(Player p, Message m2) throws IOException {
        byte type = m2.reader().readByte();
        short idLeft = m2.reader().readShort();
        int idRight = -1;
        if (type == 2 || type == 3) {
            idRight = m2.reader().readShort();
        }
        switch (type) {
            case 1: {
                Item_wear it_select;
                if (idRight != -1 || idLeft >= p.item.bag3.length || (it_select = p.item.bag3[idLeft]) == null) break;
                Message m = new Message(-77);
                m.writer().writeByte(1);
                if (it_select.levelup <= 5) {
                    m.writer().writeByte(1);
                    p.item_chuyenhoa_save_1 = it_select;
                } else {
                    m.writer().writeByte(0);
                    p.item_chuyenhoa_save_0 = it_select;
                }
                m.writer().writeShort(idLeft);
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 2: {
                if (p.item_chuyenhoa_save_0 == null || p.item_chuyenhoa_save_1 == null || p.item_chuyenhoa_save_0.levelup <= p.item_chuyenhoa_save_1.levelup) break;
                if (p.item_chuyenhoa_save_1.template.level > 50 && p.item_chuyenhoa_save_1.template.level > p.item_chuyenhoa_save_0.template.level + 10) {
                    Service.send_box_ThongBao_OK(p, "Trang b\u1ecb 5x tr\u1edf l\u00ean, khi chuy\u1ec3n h\u00f3a ch\u1ec9 \u0111\u01b0\u1ee3c chuy\u1ec3n h\u00f3a cho trang b\u1ecb cao h\u01a1n 1 c\u1ea5p trang b\u1ecb!");
                    return;
                }
                if (p.item_chuyenhoa_save_0.template.typeEquip == 7 || p.item_chuyenhoa_save_1.template.typeEquip == 7) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng th\u1ec3 th\u1ef1c hi\u1ec7n chuy\u1ec3n h\u00f3a \u0111\u1ed1i v\u1edbi dial!");
                    return;
                }
                Service.send_box_yesno(p, 6, "Th\u00f4ng b\u00e1o", "B\u1ea1n mu\u1ed1n th\u1ef1c hi\u1ec7n chuy\u1ec3n s\u1ed1 c\u01b0\u1eddng h\u00f3a 2 m\u00f3n \u0111\u1ed3 v\u1edbi m\u1ee9c ph\u00ed l\u00e0 250 Ruby?", new String[]{"250", "\u0110\u00f3ng"}, new byte[]{7, -1});
            }
        }
    }

    public static void show_result(Player p, String s, int lv) throws IOException {
        Message m = new Message(-77);
        m.writer().writeByte(3);
        m.writer().writeUTF(s);
        m.writer().writeByte(lv);
        p.conn.addmsg(m);
        m.cleanup();
    }
}

