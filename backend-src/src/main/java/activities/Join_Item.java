/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import io.Message;
import java.io.IOException;
import template.ItemTemplate7;

public class Join_Item {
    public static short[][] ID = new short[][]{{1, 0}, {3, 2, 1}, {9, 8}, {8, 9}, {11, 5}};
    public static short[][] NUM = new short[][]{{1, 5}, {1, 5, 1}, {1, 5}, {4, 1}, {1, 5}};
    public static String[] NAME = new String[]{"\u0110\u1ec3 gh\u00e9p 1 nguy\u00ean li\u1ec7u B\u1ed9t c\u01b0\u1eddng h\u00f3a b\u1ea1n c\u1ea7n c\u00f3\n5 \u0110\u00e1 ng\u0169 s\u1eafc", "\u0110\u1ec3 gh\u00e9p 1 nguy\u00ean li\u1ec7u B\u1ed9t t\u00edm b\u1ea1n c\u1ea7n c\u00f3\n5 B\u1ed9t than + 1 B\u1ed9t c\u01b0\u1eddng h\u00f3a", "\u0110\u1ec3 gh\u00e9p 1 nguy\u00ean li\u1ec7u \u0110\u00e1 \u00e1c qu\u1ef7 b\u1ea1n c\u1ea7n c\u00f3\n5 Tinh th\u1ec3 \u0111\u00e1 \u00e1c qu\u1ef7", "\u0110\u1ec3 gh\u00e9p 4 nguy\u00ean li\u1ec7u Tinh th\u1ec3 \u0111\u00e1 \u00e1c qu\u1ef7 b\u1ea1n c\u1ea7n c\u00f3\n1 \u0110\u00e1 \u00e1c qu\u1ef7", "\u0110\u1ec3 gh\u00e9p 1 nguy\u00ean li\u1ec7u Thi\u00ean th\u1ea1ch may m\u1eafn b\u1ea1n c\u1ea7n c\u00f3\n5 Ng\u00f4i sao may m\u1eafn"};

    public static void show_table(Player p, int index) throws IOException {
        p.last_index_join_item = (byte)index;
        Message m = new Message(-50);
        m.writer().writeByte(1);
        m.writer().writeByte(0);
        m.writer().writeUTF(NAME[index]);
        m.writer().writeByte(ID[index].length);
        for (int i = 0; i < ID[index].length; ++i) {
            m.writer().writeShort(ID[index][i]);
            m.writer().writeByte(7);
            m.writer().writeShort(NUM[index][i]);
        }
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static void process(Player p, Message m2) throws IOException {
        byte act = m2.reader().readByte();
        short id = m2.reader().readShort();
        byte cat = m2.reader().readByte();
        short num = m2.reader().readShort();
        if (act == 1 && cat == 7 && num > 0) {
            int i;
            short[] id_request = new short[]{-1, -1, -1};
            short[] num_request = new short[]{0, 0, 0};
            for (i = 0; i < ID.length; ++i) {
                if (ID[i][0] != id) continue;
                for (int j = 1; j < NUM[i].length; ++j) {
                    int quant = num * NUM[i][j];
                    if (p.item.total_item_bag_by_id(7, ID[i][j]) < quant) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + quant + " " + ItemTemplate7.get_it_by_id((int)Join_Item.ID[i][j]).name);
                        return;
                    }
                    id_request[j] = ID[i][j];
                    num_request[j] = (short)quant;
                }
                id_request[0] = ID[i][0];
                num_request[0] = NUM[i][0];
            }
            for (i = 1; i < id_request.length; ++i) {
                if (num_request[i] <= 0) continue;
                p.item.remove_item47(7, id_request[i], num_request[i]);
            }
            p.item.add_item_bag47(7, id_request[0], num * num_request[0]);
            p.item.update_Inventory(-1, false);
            Message m = new Message(-50);
            m.writer().writeByte(1);
            m.writer().writeByte(1);
            m.writer().writeUTF("Th\u00e0nh c\u00f4ng");
            m.writer().writeShort(id_request[0]);
            m.writer().writeByte(7);
            m.writer().writeShort(num * num_request[0]);
            p.conn.addmsg(m);
            m.cleanup();
        } else if (act == 4 && id == 0 && cat == 0 && num == 0) {
            Join_Item.show_table(p, p.last_index_join_item);
        }
    }
}

