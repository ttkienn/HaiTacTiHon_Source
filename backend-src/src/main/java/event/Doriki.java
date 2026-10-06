/*
 * Decompiled with CFR 0.152.
 */
package event;

import client.Player;
import core.Service;
import core.Util;
import java.io.IOException;

public class Doriki {
    public static String[] NAME = new String[]{"Tr\u1eafng", "Xanh", "L\u1ee5c", "Cam", "V\u00e0ng", "T\u00edm", "\u0110\u1ecf", "\u0110en"};

    public static void start(Player p) throws IOException {
        if (p.doriki[0] < 8) {
            if (p.lucthuc[2] < 500) {
                Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 500 exp l\u1ee5c th\u1ee9c");
                return;
            }
            if (p.get_vang() < 5000000L) {
                Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 5 tri\u1ec7u beri");
                return;
            }
            if (p.get_ngoc() < 2000) {
                Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 2.000 ruby");
                return;
            }
            p.lucthuc[2] = p.lucthuc[2] - 500;
            p.update_vang(-5000000L);
            p.update_ngoc(-2000L);
            p.update_money();
            if (30 > Util.random(150)) {
                p.doriki[1] = p.doriki[1] + 1;
                if (p.doriki[1] == 6) {
                    p.doriki[0] = p.doriki[0] + 1;
                    p.doriki[1] = 1;
                    Service.send_box_ThongBao_OK(p, "Th\u00e0nh c\u00f4ng t\u0103ng c\u1ea5p " + NAME[p.doriki[0] - 2] + "\n\u0110\u1ea1t \u0111\u01b0\u1ee3c:\n+ " + ((p.doriki[0] - 1) * 5 + p.doriki[1]) + "% s\u00e1t th\u01b0\u01a1ng \r\n+ " + ((p.doriki[0] - 1) * 5 + p.doriki[1]) + "% m\u00e1u\r\n+ " + ((p.doriki[0] - 1) * 5 + p.doriki[1]) + "% mana\r\n+ " + ((p.doriki[0] - 1) * 5 + p.doriki[1]) + "% ph\u00f2ng th\u1ee7.");
                } else {
                    Service.send_box_ThongBao_OK(p, "Th\u00e0nh c\u00f4ng t\u0103ng c\u1ea5p " + NAME[p.doriki[0] - 1] + " l\u00ean t\u1ea7ng th\u1ee9 " + p.doriki[1] + "\n\u0110\u1ea1t \u0111\u01b0\u1ee3c:\n+ " + ((p.doriki[0] - 1) * 5 + p.doriki[1]) + "% s\u00e1t th\u01b0\u01a1ng \r\n+ " + ((p.doriki[0] - 1) * 5 + p.doriki[1]) + "% m\u00e1u\r\n+ " + ((p.doriki[0] - 1) * 5 + p.doriki[1]) + "% mana\r\n+ " + ((p.doriki[0] - 1) * 5 + p.doriki[1]) + "% ph\u00f2ng th\u1ee7.");
                }
                Service.UpdateInfoMaincharInfo(p);
            } else {
                Service.send_box_ThongBao_OK(p, "Th\u1ea5t b\u1ea1i, h\u00e3y ngh\u1ec9 ngh\u01a1i v\u00e0 th\u1eed l\u1ea1i");
            }
        } else {
            Service.send_box_ThongBao_OK(p, "\u0110\u00e3 \u0111\u1ea1t c\u1ea3nh gi\u1edbi t\u1ed1i \u0111a");
        }
    }

    public static void send_info(Player p) throws IOException {
        if (p.doriki[0] < 8) {
            Object notice = "";
            notice = (String)notice + "\nDoriki hi\u1ec7n t\u1ea1i: " + NAME[p.doriki[0] - 1] + " c\u1ea5p " + p.doriki[1] + "\nExp: " + p.lucthuc[2];
            Service.send_box_ThongBao_OK(p, (String)notice);
        } else {
            Service.send_box_ThongBao_OK(p, "\u0110\u1ea1t t\u1ed1i \u0111a");
        }
    }
}

