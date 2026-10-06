/*
 * Decompiled with CFR 0.152.
 */
package event;

import client.Player;
import core.Service;
import core.Util;
import java.io.IOException;

public class LucThuc {
    public static String[] NAME = new String[]{"Geppo", "Tekkai", "Shigan", "Rankyaku", "Soru", "Kami-e", "Rokuogan"};
    public static String[] NAME_2 = new String[]{"S\u01a1 c\u1ea5p", "Trung c\u1ea5p", "Cao C\u1ea5p"};
    public static int[][] op = new int[][]{{5, 6, 7, 8, 9}, {5, 6, 7, 8, 9}, {5, 6, 7, 8, 9, 10}, {5, 6, 7, 8, 9, 10, 11, 12}, {5, 6, 7, 8, 9, 10, 11, 12}, {5, 6, 7, 8, 9, 10, 11, 12, 13}, {5, 6, 7, 8, 9, 10, 11, 12, 13}};
    public static int[][] par = new int[][]{{1, 1, 1, 1, 1}, {3, 3, 3, 3, 3}, {5, 5, 5, 5, 5, 5}, {7, 7, 7, 7, 7, 7, 10, 10}, {9, 9, 9, 9, 9, 9, 20, 10}, {12, 12, 12, 12, 12, 12, 20, 20, 10}, {15, 15, 15, 15, 15, 15, 20, 20, 20}};

    public static void start(Player p) throws IOException {
        if (p.lucthuc[0] < 11) {
            if (p.lucthuc[1] < 5) {
                if (p.lucthuc[2] < 500) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 500 exp l\u1ee5c th\u1ee9c");
                    return;
                }
                if (p.get_vang() < 10000000L) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 10tr v\u00e0ng");
                    return;
                }
                if (p.get_ngoc() < 3000) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 3k ng\u1ecdc");
                    return;
                }
                p.lucthuc[2] = p.lucthuc[2] - 500;
                p.update_vang(-10000000L);
                p.update_ngoc(-3000L);
                p.update_money();
                p.lucthuc[1] = p.lucthuc[1] + 1;
                Service.UpdateInfoMaincharInfo(p);
                Service.send_box_ThongBao_OK(p, "Th\u00e0nh c\u00f4ng n\u00e2ng c\u1ea5p t\u1ea1i c\u1ea3nh gi\u1edbi " + NAME[p.lucthuc[0] - 1] + " \u0111\u1ea1t c\u1ea5p " + NAME_2[p.lucthuc[1] - 1]);
            } else {
                if (p.lucthuc[2] < 1000) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 1000 exp l\u1ee5c th\u1ee9c");
                    return;
                }
                if (p.get_vang() < 20000000L) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 20 tri\u1ec7u beri");
                    return;
                }
                if (p.get_ngoc() < 5000) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 5.000 ruby");
                    return;
                }
                p.lucthuc[2] = p.lucthuc[2] - 1000;
                p.update_vang(-20000000L);
                p.update_ngoc(-10000L);
                p.update_money();
                if (10 > Util.random(150) && p.lucthuc[1] == 5) {
                    p.lucthuc[1] = 1;
                    p.lucthuc[0] = p.lucthuc[0] + 1;
                    Service.send_box_ThongBao_OK(p, "Th\u00e0nh c\u00f4ng \u0111\u1ed9t ph\u00e1 c\u1ea3nh gi\u1edbi " + NAME[p.lucthuc[0] - 2] + "\n\u0110\u1ea1t c\u1ea3nh gi\u1edbi m\u1edbi: + " + NAME[p.lucthuc[0] - 1]);
                    Service.UpdateInfoMaincharInfo(p);
                } else {
                    Service.send_box_ThongBao_OK(p, "Th\u1ea5t b\u1ea1i, h\u00e3y ngh\u1ec9 ngh\u01a1i v\u00e0 th\u1eed l\u1ea1i");
                }
            }
        } else {
            Service.send_box_ThongBao_OK(p, "\u0110\u00e3 \u0111\u1ea1t c\u1ea3nh gi\u1edbi t\u1ed1i \u0111a");
        }
    }

    public static void send_info(Player p) throws IOException {
        if (p.lucthuc[0] < 11) {
            Object notice = "Hi\u1ec7n t\u1ea1i:";
            notice = (String)notice + "\nC\u1ea3nh gi\u1edbi: " + NAME[p.lucthuc[0] - 1] + " c\u1ea5p " + NAME_2[p.lucthuc[1] - 1] + "\nExp: " + p.lucthuc[2];
            Service.send_box_ThongBao_OK(p, (String)notice);
        } else {
            Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111\u1ea1t tuy\u1ec7t k\u1ef9 Rokuogan, k\u1ef9 thu\u1eadt t\u1ed1i cao c\u1ee7a L\u1ee5c Th\u1ee9c, m\u1ed9t lo\u1ea1i v\u00f5 thu\u1eadt \u0111\u1eb7c bi\u1ec7t trong One Piece.");
        }
    }
}

