/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import io.Message;
import java.io.IOException;
import template.ItemTemplate7;
import template.Item_wear;

public class Split_Item {
    public static void process(Player p, Message m2) throws IOException {
        Item_wear it_select;
        byte act = m2.reader().readByte();
        short id = m2.reader().readShort();
        byte cat = m2.reader().readByte();
        short num = m2.reader().readShort();
        if (act == 0 && cat == 3 && num == 1) {
            Item_wear it_select2 = p.item.bag3[id];
            if (it_select2 != null) {
                Message m = new Message(-50);
                m.writer().writeByte(0);
                m.writer().writeByte(0);
                m.writer().writeShort(id);
                m.writer().writeByte(3);
                m.writer().writeShort(1);
                p.conn.addmsg(m);
                m.cleanup();
            }
        } else if (act == 1 && cat == 3 && num == 1 && (it_select = p.item.bag3[id]) != null && p.data_yesno == null && !p.isTachTB) {
            p.data_yesno = new int[]{id};
            int id_7 = 2;
            if (it_select.template.color == 2) {
                id_7 = 3;
            } else if (it_select.template.color == 3) {
                id_7 = 4;
            }
            p.isTachTB = true;
            Service.send_box_yesno(p, 11, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 th\u1eadt s\u1ef1 mu\u1ed1n ph\u00e1 h\u1ee7y v\u1eadt ph\u1ea9m " + it_select.template.name + " v\u00e0 nh\u1eadn 1 " + ItemTemplate7.get_it_by_id((int)id_7).name + " kh\u00f4ng?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, 1});
        }
    }

    public static void show_table(Player p) throws IOException {
        Message m = new Message(-50);
        m.writer().writeByte(0);
        m.writer().writeByte(3);
        p.conn.addmsg(m);
        m.cleanup();
    }
}

