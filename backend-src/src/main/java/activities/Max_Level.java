/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import io.Message;
import java.io.IOException;

public class Max_Level {
    public static void process(Player p, Message m2) throws IOException {
        byte act = m2.reader().readByte();
        short id = m2.reader().readShort();
        if (act == 0 && p.level >= 100) {
            if (p.pointAttributeThongThao < 1) {
                Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 1 \u0111i\u1ec3m th\u00f4ng th\u1ea1o");
                return;
            }
            String[] name = new String[]{"Kh\u00e1ng ph\u00e9p", "MP+", "Kh\u00e1ng v\u1eadt l\u00fd", "T\u0103ng ph\u00f2ng th\u1ee7", "HP+", "T\u0103ng t\u1ea5n c\u00f4ng"};
            short[] id_op = new short[]{27, 16, 26, 4, 15, 1};
            for (int i = 0; i < id_op.length; ++i) {
                if (id_op[i] != id) continue;
                p.data_yesno = new int[]{i};
                Service.send_box_yesno(p, 41, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 mu\u1ed1n c\u1ed9ng 1 \u0111i\u1ec3m v\u00e0o " + name[i] + "?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, 1});
                break;
            }
        }
    }

    public static void show_table(Player p) throws IOException {
        Max_Level.set_pointMaxLevelAttri(p);
        Message m = new Message(49);
        m.writer().writeByte(2);
        m.writer().writeShort(p.pointAttributeThongThao);
        p.conn.addmsg(m);
        m.cleanup();
    }

    private static void set_pointMaxLevelAttri(Player p) throws IOException {
        Message m = new Message(49);
        m.writer().writeByte(0);
        m.writer().writeShort(p.thongthao);
        String[] name = new String[]{"Kh\u00e1ng ph\u00e9p", "MP+", "Kh\u00e1ng v\u1eadt l\u00fd", "T\u0103ng ph\u00f2ng th\u1ee7", "HP+", "T\u0103ng t\u1ea5n c\u00f4ng"};
        short[] id_op = new short[]{27, 16, 26, 4, 15, 1};
        m.writer().writeByte(name.length);
        for (int i = 0; i < name.length; ++i) {
            m.writer().writeShort(id_op[i]);
            m.writer().writeUTF(name[i]);
            int value = 0;
            for (int j = 0; j < p.list_op_thongthao.size(); ++j) {
                if (p.list_op_thongthao.get((int)j).id != id_op[i]) continue;
                value += p.list_op_thongthao.get(j).getParam();
            }
            m.writer().writeShort(value);
            m.writer().writeShort(80);
        }
        p.conn.addmsg(m);
        m.cleanup();
    }
}

