/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import core.Util;
import io.Message;
import java.io.IOException;
import template.Item_wear;
import template.Option;

public class UpgradeDial {
    public static void show_table(Player p) throws IOException {
        Message m = new Message(-94);
        m.writer().writeByte(7);
        p.conn.addmsg(m);
        m.cleanup();
        p.tool_dial = new byte[]{0, 0, 0};
    }

    public static void process(Player p, Message m2) throws IOException {
        Item_wear it_select;
        byte type = m2.reader().readByte();
        short id = m2.reader().readShort();
        byte beri_gem = m2.reader().readByte();
        byte num = m2.reader().readByte();
        if (type == 4 && beri_gem == 0 && num == 0) {
            Item_wear it_select2 = p.item.bag3[id];
            if (it_select2 != null) {
                if (it_select2.template.typeEquip == 7) {
                    Message m = new Message(-94);
                    m.writer().writeByte(4);
                    m.writer().writeShort(id);
                    m.writer().writeByte(3);
                    m.writer().writeShort(4);
                    m.writer().writeShort(UpgradeDial.get_botvang(it_select2.levelup));
                    m.writer().writeShort(1);
                    m.writer().writeShort(UpgradeDial.get_botCH(it_select2.levelup));
                    m.writer().writeShort(13);
                    m.writer().writeShort(UpgradeDial.get_longvu(it_select2.levelup));
                    m.writer().writeInt(UpgradeDial.get_beri_up(it_select2.levelup));
                    m.writer().writeInt(UpgradeDial.get_ruby_up(it_select2.levelup));
                    m.writer().writeInt(UpgradeDial.get_extol_up(it_select2.levelup));
                    m.writer().writeByte(it_select2.levelup == 0 || it_select2.levelup == 3 ? 0 : 85);
                    p.conn.addmsg(m);
                    m.cleanup();
                } else {
                    Service.send_box_ThongBao_OK(p, "Ch\u1ec9 c\u00f3 th\u1ec3 b\u1ecf dial v\u00e0o \u0111\u1ec3 n\u00e2ng c\u1ea5p");
                }
            }
            p.tool_dial = new byte[]{0, 0, 0};
        } else if (type == 5 && id == 11 && (beri_gem == 0 || beri_gem == 1)) {
            if (num >= 0 && num <= 3) {
                Message m = new Message(-94);
                m.writer().writeByte(5);
                m.writer().writeByte(beri_gem);
                m.writer().writeShort(id);
                m.writer().writeByte(num);
                m.writer().writeByte(10);
                p.conn.addmsg(m);
                m.cleanup();
                p.tool_dial[0] = num;
            } else {
                Service.send_box_ThongBao_OK(p, "Ch\u1ec9 b\u1ecf t\u1ed1i \u0111a 3 m\u00f3n");
            }
        } else if (type == 6 && id == 6 && (beri_gem == 0 || beri_gem == 1)) {
            if (num >= 0 && num <= 3) {
                Message m = new Message(-94);
                m.writer().writeByte(6);
                m.writer().writeByte(beri_gem);
                m.writer().writeShort(id);
                m.writer().writeByte(num);
                m.writer().writeByte(beri_gem == 0 ? 0 : 5 * num);
                p.conn.addmsg(m);
                m.cleanup();
                p.tool_dial[1] = num;
            } else {
                Service.send_box_ThongBao_OK(p, "Ch\u1ec9 b\u1ecf t\u1ed1i \u0111a 3 m\u00f3n");
            }
        } else if (type == 14 && id == 10 && (beri_gem == 0 || beri_gem == 1) && num >= 0 && num <= 1) {
            Message m = new Message(-94);
            m.writer().writeByte(14);
            m.writer().writeByte(beri_gem);
            m.writer().writeShort(id);
            p.conn.addmsg(m);
            m.cleanup();
            p.tool_dial[2] = num;
        } else if (type == 1 && beri_gem == 0 && num == 0 && (it_select = p.item.bag3[id]) != null) {
            if (it_select.template.typeEquip == 7) {
                if (it_select.levelup < 5) {
                    boolean suc;
                    int beri_req = UpgradeDial.get_beri_up(it_select.levelup);
                    int extol_req = UpgradeDial.get_extol_up(it_select.levelup);
                    if (p.get_vang() < (long)beri_req) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + beri_req + " beri");
                        return;
                    }
                    if (p.get_vnd() < extol_req) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + extol_req + " extol");
                        return;
                    }
                    int botCH_req = UpgradeDial.get_botCH(it_select.levelup);
                    int botvang_req = UpgradeDial.get_botvang(it_select.levelup);
                    int longvu_req = UpgradeDial.get_longvu(it_select.levelup);
                    if (p.item.total_item_bag_by_id(7, 1) < botCH_req) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + botCH_req + " B\u1ed9t c\u01b0\u1eddng h\u00f3a");
                        return;
                    }
                    if (p.item.total_item_bag_by_id(7, 4) < botvang_req) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + botvang_req + " B\u1ed9t v\u00e0ng");
                        return;
                    }
                    if (p.item.total_item_bag_by_id(7, 13) < longvu_req) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + longvu_req + " L\u00f4ng v\u0169");
                        return;
                    }
                    if (p.tool_dial[0] > 0 && p.item.total_item_bag_by_id(7, 11) < p.tool_dial[0]) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + p.tool_dial[0] + " Thi\u00ean th\u1ea1ch may m\u1eafn");
                        return;
                    }
                    if (p.tool_dial[1] > 0 && p.item.total_item_bag_by_id(7, 6) < p.tool_dial[1]) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + p.tool_dial[1] + " Mai r\u00f9a");
                        return;
                    }
                    if (p.tool_dial[2] > 0 && p.item.total_item_bag_by_id(7, 10) < p.tool_dial[2]) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + p.tool_dial[2] + " Khi\u00ean");
                        return;
                    }
                    p.update_vang(-beri_req);
                    p.update_vnd(-extol_req);
                    p.update_money();
                    p.item.remove_item47(7, 1, botCH_req);
                    p.item.remove_item47(7, 4, botvang_req);
                    p.item.remove_item47(7, 13, longvu_req);
                    if (p.tool_dial[0] > 0) {
                        p.item.remove_item47(7, 11, p.tool_dial[0]);
                    }
                    if (p.tool_dial[1] > 0) {
                        p.item.remove_item47(7, 6, p.tool_dial[1]);
                    }
                    if (p.tool_dial[2] > 0) {
                        p.item.remove_item47(7, 10, p.tool_dial[2]);
                    }
                    boolean bl = suc = 80 - it_select.levelup * 20 + p.tool_dial[0] * 15 > Util.random(200);
                    if (suc) {
                        it_select.levelup = (byte)(it_select.levelup + 1);
                        Message m = new Message(-94);
                        m.writer().writeByte(2);
                        m.writer().writeUTF("N\u00e2ng c\u1ea5p th\u00e0nh c\u00f4ng v\u1eadt ph\u1ea9m l\u00ean +" + it_select.levelup);
                        p.conn.addmsg(m);
                        m.cleanup();
                    } else {
                        int percent_rotcap = 85 - p.tool_dial[1] * 5 - p.tool_dial[2] * 20;
                        if (percent_rotcap > Util.random(100)) {
                            byte tier_save = it_select.levelup >= 3 ? (byte)3 : 0;
                            it_select.levelup = (byte)(it_select.levelup - Util.random(1, 3));
                            if (it_select.levelup < tier_save) {
                                it_select.levelup = tier_save;
                            }
                        }
                        Message m = new Message(-94);
                        m.writer().writeByte(3);
                        m.writer().writeUTF("R\u1ea5t ti\u1ebfc n\u00e2ng c\u1ea5p th\u1ea5t b\u1ea1i, v\u1eadt ph\u1ea9m r\u1edbt c\u1ea5p v\u1ec1 +" + it_select.levelup);
                        p.conn.addmsg(m);
                        m.cleanup();
                    }
                    if (it_select.levelup == 3 || it_select.levelup == 5 || it_select.template.name.equals("Dial Truy\u1ec1n thuy\u1ebft") && it_select.levelup == 1) {
                        if (it_select.template.name.equals("Dial Th\u1ea7n Tho\u1ea1i")) {
                            boolean add = false;
                            if (it_select.levelup == 3 && it_select.option_item.size() == 2) {
                                add = true;
                            } else if (it_select.levelup == 5 && it_select.option_item.size() == 3) {
                                add = true;
                            }
                            if (add) {
                                int random_add = Util.random(7);
                                switch (random_add) {
                                    case 0: {
                                        it_select.option_item.add(new Option(Util.random(5, 10), Util.random(5, 10)));
                                        break;
                                    }
                                    case 1: {
                                        it_select.option_item.add(new Option(Util.random(19, 21), Util.random(25, 50)));
                                        break;
                                    }
                                    case 2: {
                                        int value_random = Util.random(10, 15);
                                        while (value_random == 11) {
                                            value_random = Util.random(10, 15);
                                        }
                                        it_select.option_item.add(new Option(value_random, Util.random(100, 200)));
                                        break;
                                    }
                                    case 3: {
                                        it_select.option_item.add(new Option(56, Util.random(100, 200)));
                                        break;
                                    }
                                    case 4: {
                                        it_select.option_item.add(new Option(4, Util.random(100, 200)));
                                        break;
                                    }
                                    case 5: {
                                        it_select.option_item.add(new Option(53, Util.random(50, 150)));
                                        break;
                                    }
                                    case 6: {
                                        it_select.option_item.add(new Option(51, Util.random(30, 80)));
                                    }
                                }
                            }
                        } else if (it_select.template.name.equals("Dial Truy\u1ec1n thuy\u1ebft")) {
                            boolean add = false;
                            if (it_select.levelup == 1 && it_select.option_item.size() == 3) {
                                add = true;
                            } else if (it_select.levelup == 3 && it_select.option_item.size() == 4) {
                                add = true;
                            } else if (it_select.levelup == 5 && it_select.option_item.size() == 5) {
                                add = true;
                            }
                            if (add) {
                                int random_add = Util.random(11);
                                switch (random_add) {
                                    case 0: {
                                        it_select.option_item.add(new Option(Util.random(5, 10), Util.random(5, 10)));
                                        break;
                                    }
                                    case 1: {
                                        it_select.option_item.add(new Option(Util.random(19, 21), Util.random(25, 50)));
                                        break;
                                    }
                                    case 2: {
                                        int value_random = Util.random(10, 15);
                                        while (value_random == 11) {
                                            value_random = Util.random(10, 15);
                                        }
                                        it_select.option_item.add(new Option(value_random, Util.random(100, 200)));
                                        break;
                                    }
                                    case 3: {
                                        it_select.option_item.add(new Option(56, Util.random(100, 200)));
                                        break;
                                    }
                                    case 4: {
                                        it_select.option_item.add(new Option(4, Util.random(100, 200)));
                                        break;
                                    }
                                    case 5: {
                                        it_select.option_item.add(new Option(53, Util.random(50, 150)));
                                        break;
                                    }
                                    case 6: {
                                        it_select.option_item.add(new Option(51, Util.random(30, 80)));
                                        break;
                                    }
                                    case 7: {
                                        it_select.option_item.add(new Option(50, Util.random(30, 80)));
                                        break;
                                    }
                                    case 8: {
                                        it_select.option_item.add(new Option(52, Util.random(30, 80)));
                                        break;
                                    }
                                    case 9: {
                                        it_select.option_item.add(new Option(63, Util.random(30, 80)));
                                        break;
                                    }
                                    case 10: {
                                        it_select.option_item.add(new Option(49, Util.random(30, 80)));
                                    }
                                }
                            }
                        } else if (it_select.template.name.equals("Dial S\u1eed Thi")) {
                            boolean add = false;
                            if (it_select.levelup == 3 && it_select.option_item.size() == 1) {
                                add = true;
                            } else if (it_select.levelup == 5 && it_select.option_item.size() == 2) {
                                add = true;
                            }
                            if (add) {
                                int random_add = Util.random(5);
                                switch (random_add) {
                                    case 0: {
                                        it_select.option_item.add(new Option(Util.random(5, 10), Util.random(5, 10)));
                                        break;
                                    }
                                    case 1: {
                                        it_select.option_item.add(new Option(Util.random(19, 21), Util.random(25, 50)));
                                        break;
                                    }
                                    case 2: {
                                        int value_random = Util.random(10, 15);
                                        while (value_random == 11) {
                                            value_random = Util.random(10, 15);
                                        }
                                        it_select.option_item.add(new Option(value_random, Util.random(100, 200)));
                                        break;
                                    }
                                    case 3: {
                                        it_select.option_item.add(new Option(56, Util.random(100, 200)));
                                        break;
                                    }
                                    case 4: {
                                        it_select.option_item.add(new Option(4, Util.random(100, 200)));
                                    }
                                }
                            }
                        } else if (it_select.template.name.equals("Dial Si\u00eau N\u0103ng")) {
                            boolean add = false;
                            if (it_select.levelup == 3 && it_select.option_item.size() == 1) {
                                add = true;
                            } else if (it_select.levelup == 5 && it_select.option_item.size() == 2) {
                                add = true;
                            }
                            if (add) {
                                int random_add = Util.random(4);
                                switch (random_add) {
                                    case 0: {
                                        it_select.option_item.add(new Option(Util.random(5, 10), Util.random(5, 10)));
                                        break;
                                    }
                                    case 1: {
                                        it_select.option_item.add(new Option(Util.random(19, 21), Util.random(25, 50)));
                                        break;
                                    }
                                    case 2: {
                                        int value_random = Util.random(10, 15);
                                        while (value_random == 11) {
                                            value_random = Util.random(10, 15);
                                        }
                                        it_select.option_item.add(new Option(value_random, Util.random(100, 200)));
                                        break;
                                    }
                                    case 3: {
                                        it_select.option_item.add(new Option(56, Util.random(100, 200)));
                                    }
                                }
                            }
                        }
                    }
                    p.item.update_Inventory(-1, false);
                    p.tool_dial = new byte[]{0, 0, 0};
                } else {
                    Service.send_box_ThongBao_OK(p, "Hi\u1ec7n t\u1ea1i trang b\u1ecb \u0111\u00e3 n\u00e2ng c\u1ea5p t\u1ed1i \u0111a");
                }
            } else {
                Service.send_box_ThongBao_OK(p, "Ch\u1ec9 c\u00f3 th\u1ec3 b\u1ecf dial v\u00e0o \u0111\u1ec3 n\u00e2ng c\u1ea5p");
            }
        }
    }

    private static int get_longvu(byte levelup) {
        return (levelup + 1) * 4;
    }

    private static int get_botCH(byte levelup) {
        return (levelup + 1) * 100;
    }

    private static int get_botvang(byte levelup) {
        return (levelup + 1) * 70;
    }

    private static int get_beri_up(byte levelup) {
        return (levelup + 1) * 500000;
    }

    private static int get_ruby_up(byte levelup) {
        return 0;
    }

    private static int get_extol_up(byte levelup) {
        return (levelup + 1) * 2000;
    }
}

