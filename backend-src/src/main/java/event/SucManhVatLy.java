/*
 * Decompiled with CFR 0.152.
 */
package event;

import client.Player;
import core.Service;
import core.Util;
import java.io.IOException;

public class SucManhVatLy {
    public static void start(Player p) throws IOException {
        if (p.sucmanhvatly < 12) {
            if (p.lucthuc[2] < 500) {
                Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 500 exp l\u1ee5c th\u1ee9c");
                return;
            }
            if (p.get_vang() < 5000000L) {
                Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 5 tri\u1ec7u bery");
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
                ++p.sucmanhvatly;
                Service.UpdateInfoMaincharInfo(p);
                Service.send_box_ThongBao_OK(p, "Th\u00e0nh c\u00f4ng luy\u1ec7n th\u1ec3 \u0111\u1ebfn t\u1ea7ng " + p.sucmanhvatly + "\n\u0110\u1ea1t \u0111\u01b0\u1ee3c:\n+ " + p.sucmanhvatly * 20 + " s\u00e1t th\u01b0\u01a1ng\r\n+ " + p.sucmanhvatly * 20 + " ph\u00f2ng th\u1ee7\r\n+ " + String.format("%.2f", Float.valueOf((float)p.sucmanhvatly * 0.2f)) + "% Ch\u00ed M\u1ea1ng\r\n+ " + String.format("%.2f", Float.valueOf((float)p.sucmanhvatly * 0.2f)) + "% Xuy\u00ean gi\u00e1p\r\n+ " + p.sucmanhvatly * 2000 + " m\u00e1u\r\n+ " + p.sucmanhvatly * 2000 + " mana");
            } else {
                Service.send_box_ThongBao_OK(p, "Th\u1ea5t b\u1ea1i, h\u00e3y ngh\u1ec9 ngh\u01a1i v\u00e0 th\u1eed l\u1ea1i");
            }
            Service.UpdateInfoMaincharInfo(p);
        } else {
            Service.send_box_ThongBao_OK(p, "\u0110\u00e3 \u0111\u1ea1t c\u1ea3nh gi\u1edbi t\u1ed1i \u0111a");
        }
    }

    public static void send_info(Player p) throws IOException {
        String notice = "Hi\u1ec7n t\u1ea1i: luy\u1ec7n \u0111\u1ebfn t\u1ea7ng " + p.sucmanhvatly + " / 12.\nT\u1ea7ng ti\u1ebfp theo c\u1ea7n  5 tri\u1ec7u beri v\u00e0 2.000 ruby, t\u1ef7 l\u1ec7 30%\nExp: " + p.lucthuc[2];
        Service.send_box_ThongBao_OK(p, notice);
    }
}

