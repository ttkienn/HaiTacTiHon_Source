/*
 * Decompiled with CFR 0.152.
 */
package client;

import client.Player;
import core.Manager;
import core.Service;
import core.Util;
import io.Message;
import java.io.IOException;
import java.util.ArrayList;
import template.EffTemplate;
import template.GiftBox;
import template.ItemBoat;
import template.ItemBoatP;
import template.ItemFashion;
import template.ItemFashionP;
import template.ItemFashionP2;
import template.ItemHair;
import template.ItemTemplate3;
import template.ItemTemplate4;
import template.Item_wear;

public class UseItem {
    public static void process(Player p, Message m2) throws IOException {
        short id = m2.reader().readShort();
        byte cat = m2.reader().readByte();
        switch (cat) {
            case 3: {
                UseItem.use_item_3(p, id);
                break;
            }
            case 7: {
                UseItem.use_item_7(p, id);
                break;
            }
            case 105: {
                ItemFashionP2 temp = p.check_fashion(id);
                if (temp != null) {
                    if (temp.is_use) {
                        temp.is_use = false;
                        if (temp.id == 122) {
                            p.tocSuper = 0;
                        }
                        p.update_info_to_all();
                        for (int i = 0; i < p.map.players.size(); ++i) {
                            Player p0 = p.map.players.get(i);
                            Service.charWearing(p, p0, false);
                        }
                        Service.UpdateInfoMaincharInfo(p);
                        ItemFashionP.show_table(p, 105);
                        Service.send_box_ThongBao_OK(p, "Th\u00e1o th\u00e0nh c\u00f4ng " + ItemFashion.get_item((int)temp.id).name);
                        break;
                    }
                    p.update_fashionP2(temp);
                    for (int i = 0; i < p.map.players.size(); ++i) {
                        Player p0 = p.map.players.get(i);
                        Service.charWearing(p, p0, false);
                    }
                    Service.UpdateInfoMaincharInfo(p);
                    ItemFashionP.show_table(p, 105);
                    Service.send_box_ThongBao_OK(p, "M\u1eb7c th\u00e0nh c\u00f4ng " + ItemFashion.get_item((int)temp.id).name);
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Ch\u01b0a mua v\u1eadt ph\u1ea9m n\u00e0y!");
                break;
            }
            case 102: {
                ItemBoatP temp = p.check_itboat(id);
                if (temp != null) {
                    temp.is_use = true;
                    p.update_new_part_boat(temp);
                    ItemBoat.update_part_boat_when_shopping(p);
                    ItemFashionP.show_table(p, 102);
                    Service.send_box_ThongBao_OK(p, "S\u1eed d\u1ee5ng " + ItemBoat.get_item((int)temp.id).name);
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Ch\u01b0a mua v\u1eadt ph\u1ea9m n\u00e0y!");
                break;
            }
            case 103: 
            case 108: {
                ItemFashionP temp = p.check_itfashionP(id, cat);
                if (temp != null) {
                    p.update_itfashionP(temp, cat);
                    for (int i = 0; i < p.map.players.size(); ++i) {
                        Player p0 = p.map.players.get(i);
                        Service.charWearing(p, p0, false);
                    }
                    ItemFashionP.show_table(p, cat);
                    Service.send_box_ThongBao_OK(p, "S\u1eed d\u1ee5ng " + ItemHair.get_item((int)temp.id, (int)cat).name);
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Ch\u01b0a mua v\u1eadt ph\u1ea9m n\u00e0y!");
                break;
            }
        }
    }

    private static void use_item_7(Player p, int id) {
    }

    /*
     * Enabled force condition propagation
     * Lifted jumps to return sites
     */
    private static boolean use_item_4(Player p, int id) throws IOException {
        boolean used = true;
        ItemTemplate4 it_temp = ItemTemplate4.get_it_by_id(id);
        if (it_temp != null) {
            if (it_temp.type == 1 || it_temp.type == 2) {
                if (it_temp.type == 1 && p.type_pk != 0) {
                    EffTemplate eff = p.get_eff(0);
                    if (eff != null) {
                        if (eff.time - System.currentTimeMillis() >= 1000L) return used;
                    }
                    long par = it_temp.value;
                    if (it_temp.id == 173) {
                        par = p.body.get_hp_max(true) / 20;
                    }
                    if ((par = par * (long)(100 + p.body.get_hp_potion_use_percent(true) / 10) / 100L) < 0L) {
                        par = 0L;
                    }
                    if (it_temp.id == 173 && par > 10000L) {
                        par = 10000L;
                    }
                    p.add_new_eff(0, (int)par, it_temp.timedelay);
                    return used;
                } else {
                    if (it_temp.type != 2) return used;
                    if (p.type_pk == 0) return used;
                    EffTemplate eff = p.get_eff(1);
                    if (eff != null) {
                        if (eff.time - System.currentTimeMillis() >= 1000L) return used;
                    }
                    int par = it_temp.value;
                    par = par * (100 + p.body.get_mp_potion_use_percent(true) / 10) / 100;
                    p.add_new_eff(1, par, it_temp.timedelay);
                }
                return used;
            } else {
                switch (id) {
                    case 7: 
                    case 8: 
                    case 9: 
                    case 10: 
                    case 11: 
                    case 12: 
                    case 13: 
                    case 14: 
                    case 15: {
                        ArrayList<GiftBox> list = new ArrayList<GiftBox>();
                        if (85 > Util.random(120)) {
                            int bound1;
                            byte it_color = (byte)(70 > Util.random(120) ? 0 : (20 > Util.random(120) ? 2 : 1));
                            int bound2 = switch (id) {
                                case 8 -> {
                                    bound1 = 192;
                                    yield 384;
                                }
                                case 9 -> {
                                    bound1 = 384;
                                    yield 576;
                                }
                                case 10 -> {
                                    bound1 = 576;
                                    yield 768;
                                }
                                case 11 -> {
                                    bound1 = 768;
                                    yield 960;
                                }
                                case 12 -> {
                                    bound1 = 960;
                                    yield 1152;
                                }
                                case 13 -> {
                                    bound1 = 1152;
                                    yield 1344;
                                }
                                case 14 -> {
                                    bound1 = 1344;
                                    yield 1536;
                                }
                                case 15 -> {
                                    bound1 = 1536;
                                    yield 1728;
                                }
                                default -> {
                                    bound1 = 0;
                                    yield 192;
                                }
                            };
                            ItemTemplate3 template3 = ItemTemplate3.get_it_by_id(Util.random(bound1, bound2));
                            int id_exact = template3.id;
                            if ((template3.typeEquip == 0 || template3.typeEquip == 1 || template3.typeEquip == 3 || template3.typeEquip == 5) && template3.clazz != p.clazz && 90 > Util.random(120)) {
                                template3 = ItemTemplate3.get_item_random(template3.typeEquip, p.clazz, bound1, bound2);
                            }
                            id_exact = template3.id;
                            template3 = ItemTemplate3.get_it_by_id(id_exact -= template3.color - it_color);
                            GiftBox gb1 = new GiftBox();
                            if (template3 != null) {
                                gb1.id = template3.id;
                                gb1.type = (byte)3;
                                gb1.name = template3.name;
                                gb1.icon = template3.icon;
                                gb1.num = 1;
                                gb1.color = template3.color;
                                list.add(gb1);
                            }
                        }
                        GiftBox gb2 = new GiftBox();
                        ItemTemplate4 it_temp4 = ItemTemplate4.get_it_by_id(0);
                        if (it_temp4 != null) {
                            gb2.id = it_temp4.id;
                            gb2.type = (byte)4;
                            gb2.name = it_temp4.name;
                            gb2.icon = it_temp4.icon;
                            gb2.num = Util.random(50, 180);
                            gb2.color = 0;
                            list.add(gb2);
                        }
                        if (80 > Util.random(120)) {
                            GiftBox gb3 = new GiftBox();
                            it_temp4 = ItemTemplate4.get_it_by_id(Util.random(2, 6));
                            if (it_temp4 != null) {
                                gb3.id = it_temp4.id;
                                gb3.type = (byte)4;
                                gb3.name = it_temp4.name;
                                gb3.icon = it_temp4.icon;
                                gb3.num = Util.random(2, 5);
                                gb3.color = 0;
                                list.add(gb3);
                            }
                        }
                        if (list.size() <= 0) return used;
                        Service.send_gift(p, 1, "M\u1edf kh\u00f3a r\u01b0\u01a1ng", ItemTemplate4.get_item_name(id), list, true);
                        return used;
                    }
                    case 16: 
                    case 17: {
                        ArrayList<GiftBox> list = new ArrayList<GiftBox>();
                        if (85 > Util.random(120)) {
                            byte it_color = (byte)(70 > Util.random(120) ? 0 : (20 > Util.random(120) ? 2 : 1));
                            ItemTemplate4 temp4 = id == 16 ? ItemTemplate4.get_it_by_id(it_color == 0 ? Util.random(304, 307) : (it_color == 1 ? Util.random(307, 310) : Util.random(310, 313))) : ItemTemplate4.get_it_by_id(it_color == 0 ? Util.random(536, 539) : (it_color == 1 ? Util.random(539, 542) : Util.random(542, 545)));
                            GiftBox gb1 = new GiftBox();
                            gb1.id = temp4.id;
                            gb1.type = (byte)4;
                            gb1.name = temp4.name;
                            gb1.icon = temp4.icon;
                            gb1.num = 1;
                            gb1.color = 0;
                            list.add(gb1);
                        }
                        GiftBox gb2 = new GiftBox();
                        ItemTemplate4 it_temp4 = ItemTemplate4.get_it_by_id(0);
                        if (it_temp4 != null) {
                            gb2.id = it_temp4.id;
                            gb2.type = (byte)4;
                            gb2.name = it_temp4.name;
                            gb2.icon = it_temp4.icon;
                            gb2.num = Util.random(50, 180);
                            gb2.color = 0;
                            list.add(gb2);
                        }
                        if (80 > Util.random(120)) {
                            GiftBox gb3 = new GiftBox();
                            it_temp4 = ItemTemplate4.get_it_by_id(Util.random(2, 6));
                            if (it_temp4 != null) {
                                gb3.id = it_temp4.id;
                                gb3.type = (byte)4;
                                gb3.name = it_temp4.name;
                                gb3.icon = it_temp4.icon;
                                gb3.num = Util.random(2, 5);
                                gb3.color = 0;
                                list.add(gb3);
                            }
                        }
                        if (list.size() <= 0) return used;
                        Service.send_gift(p, 1, "M\u1edf kh\u00f3a r\u01b0\u01a1ng", ItemTemplate4.get_item_name(id), list, true);
                        return used;
                    }
                    case 18: 
                    case 19: 
                    case 20: 
                    case 21: 
                    case 22: 
                    case 23: 
                    case 24: 
                    case 25: 
                    case 26: {
                        ArrayList<GiftBox> list = new ArrayList<GiftBox>();
                        if (80 > Util.random(120)) {
                            int bound1;
                            byte it_color = (byte)(60 > Util.random(120) ? 1 : (20 > Util.random(120) ? 3 : (20 > Util.random(120) ? 0 : 2)));
                            int bound2 = switch (id) {
                                case 19 -> {
                                    bound1 = 192;
                                    yield 384;
                                }
                                case 20 -> {
                                    bound1 = 384;
                                    yield 576;
                                }
                                case 21 -> {
                                    bound1 = 576;
                                    yield 768;
                                }
                                case 22 -> {
                                    bound1 = 768;
                                    yield 960;
                                }
                                case 23 -> {
                                    bound1 = 960;
                                    yield 1152;
                                }
                                case 24 -> {
                                    bound1 = 1152;
                                    yield 1344;
                                }
                                case 25 -> {
                                    bound1 = 1344;
                                    yield 1536;
                                }
                                case 26 -> {
                                    bound1 = 1536;
                                    yield 1728;
                                }
                                default -> {
                                    bound1 = 0;
                                    yield 192;
                                }
                            };
                            ItemTemplate3 template3 = ItemTemplate3.get_it_by_id(Util.random(bound1, bound2));
                            int id_exact = template3.id;
                            if ((template3.typeEquip == 0 || template3.typeEquip == 1 || template3.typeEquip == 3 || template3.typeEquip == 5) && template3.clazz != p.clazz && 90 > Util.random(120)) {
                                template3 = ItemTemplate3.get_item_random(template3.typeEquip, p.clazz, bound1, bound2);
                            }
                            id_exact = template3.id;
                            template3 = ItemTemplate3.get_it_by_id(id_exact -= template3.color - it_color);
                            GiftBox gb1 = new GiftBox();
                            if (template3 != null) {
                                gb1.id = template3.id;
                                gb1.type = (byte)3;
                                gb1.name = template3.name;
                                gb1.icon = template3.icon;
                                gb1.num = 1;
                                gb1.color = template3.color;
                                list.add(gb1);
                            }
                        }
                        GiftBox gb2 = new GiftBox();
                        ItemTemplate4 it_temp4 = ItemTemplate4.get_it_by_id(0);
                        if (it_temp4 != null) {
                            gb2.id = it_temp4.id;
                            gb2.type = (byte)4;
                            gb2.name = it_temp4.name;
                            gb2.icon = it_temp4.icon;
                            gb2.num = Util.random(100, 500);
                            gb2.color = 0;
                            list.add(gb2);
                        }
                        if (80 > Util.random(120)) {
                            GiftBox gb3 = new GiftBox();
                            it_temp4 = ItemTemplate4.get_it_by_id(Util.random(2, 6));
                            if (it_temp4 != null) {
                                gb3.id = it_temp4.id;
                                gb3.type = (byte)4;
                                gb3.name = it_temp4.name;
                                gb3.icon = it_temp4.icon;
                                gb3.num = Util.random(3, 6);
                                gb3.color = 0;
                                list.add(gb3);
                            }
                        }
                        if (25 > Util.random(120)) {
                            GiftBox gb4 = new GiftBox();
                            short[] id_random = new short[]{44, 50, 56, 62, 68, 74};
                            it_temp4 = ItemTemplate4.get_it_by_id(id_random[Util.random(id_random.length)]);
                            if (it_temp4 != null) {
                                gb4.id = it_temp4.id;
                                gb4.type = (byte)4;
                                gb4.name = it_temp4.name;
                                gb4.icon = it_temp4.icon;
                                gb4.num = 1;
                                gb4.color = 0;
                                list.add(gb4);
                            }
                        }
                        if (list.size() <= 0) return used;
                        Service.send_gift(p, 1, "M\u1edf kh\u00f3a r\u01b0\u01a1ng", ItemTemplate4.get_item_name(id), list, true);
                        return used;
                    }
                    case 27: 
                    case 28: {
                        ArrayList<GiftBox> list = new ArrayList<GiftBox>();
                        if (80 > Util.random(120)) {
                            byte it_color = (byte)(60 > Util.random(120) ? 1 : (20 > Util.random(120) ? 3 : (20 > Util.random(120) ? 0 : 2)));
                            ItemTemplate4 temp4 = id == 27 ? ItemTemplate4.get_it_by_id(it_color == 0 ? Util.random(304, 307) : (it_color == 1 ? Util.random(307, 310) : (it_color == 2 ? Util.random(310, 313) : Util.random(313, 316)))) : ItemTemplate4.get_it_by_id(it_color == 0 ? Util.random(536, 539) : (it_color == 1 ? Util.random(539, 542) : (it_color == 2 ? Util.random(542, 545) : Util.random(545, 548))));
                            GiftBox gb1 = new GiftBox();
                            gb1.id = temp4.id;
                            gb1.type = (byte)4;
                            gb1.name = temp4.name;
                            gb1.icon = temp4.icon;
                            gb1.num = 1;
                            gb1.color = 0;
                            list.add(gb1);
                        }
                        GiftBox gb2 = new GiftBox();
                        ItemTemplate4 it_temp4 = ItemTemplate4.get_it_by_id(0);
                        if (it_temp4 != null) {
                            gb2.id = it_temp4.id;
                            gb2.type = (byte)4;
                            gb2.name = it_temp4.name;
                            gb2.icon = it_temp4.icon;
                            gb2.num = Util.random(100, 500);
                            gb2.color = 0;
                            list.add(gb2);
                        }
                        if (80 > Util.random(120)) {
                            GiftBox gb3 = new GiftBox();
                            it_temp4 = ItemTemplate4.get_it_by_id(Util.random(2, 6));
                            if (it_temp4 != null) {
                                gb3.id = it_temp4.id;
                                gb3.type = (byte)4;
                                gb3.name = it_temp4.name;
                                gb3.icon = it_temp4.icon;
                                gb3.num = Util.random(3, 6);
                                gb3.color = 0;
                                list.add(gb3);
                            }
                        }
                        if (25 > Util.random(120)) {
                            GiftBox gb4 = new GiftBox();
                            short[] id_random = new short[]{44, 50, 56, 62, 68, 74};
                            it_temp4 = ItemTemplate4.get_it_by_id(id_random[Util.random(id_random.length)]);
                            if (it_temp4 != null) {
                                gb4.id = it_temp4.id;
                                gb4.type = (byte)4;
                                gb4.name = it_temp4.name;
                                gb4.icon = it_temp4.icon;
                                gb4.num = 1;
                                gb4.color = 0;
                                list.add(gb4);
                            }
                        }
                        if (list.size() <= 0) return used;
                        Service.send_gift(p, 1, "M\u1edf kh\u00f3a r\u01b0\u01a1ng", ItemTemplate4.get_item_name(id), list, true);
                        return used;
                    }
                    case 29: {
                        if (p.check_already_have_devil_fruit()) {
                            Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 c\u00f3 1 tr\u00e1i \u00e1c qu\u1ef7 trong h\u00e0nh trang!");
                            return false;
                        }
                        int id_add = 86;
                        if (20 > Util.random(120)) {
                            id_add = 87;
                        }
                        if (!p.item.add_item_bag47(4, id_add, 1)) {
                            Service.send_box_ThongBao_OK(p, "H\u00e0nh trang kh\u00f4ng \u0111\u1ee7 ch\u1ed7 tr\u1ed1ng!");
                            return false;
                        }
                        UseItem.open_taq_random(p, id_add, "R\u01b0\u01a1ng \u00e1c qu\u1ef7", "Nh\u1eadn ng\u1eabu nhi\u00ean");
                        return used;
                    }
                    case 31: {
                        int diemGiam = 100;
                        if (p.pointPk >= 1000) {
                            diemGiam = 20;
                        }
                        p.update_point_pk(-diemGiam);
                        Service.send_box_ThongBao_OK(p, "D\u00f9ng v\u1eadt ph\u1ea9m gi\u1ea3m " + diemGiam + ". \u0110i\u1ec3m hi\u1ebfu chi\u1ebfn hi\u1ec7n t\u1ea1i c\u1ee7a b\u1ea1n l\u00e0 " + p.pointPk);
                        return used;
                    }
                    case 40: {
                        p.update_key_boss(1);
                        Service.CountDown_Ticket(p);
                        p.item.update_assets_Inventory(false);
                        Service.send_box_ThongBao_OK(p, "S\u1ed1 l\u01b0\u1ee3ng ch\u00eca hi\u1ec7n t\u1ea1i: " + p.get_key_boss() + " / " + p.get_key_boss_max());
                        return used;
                    }
                    case 158: {
                        if (p.check_already_have_devil_fruit()) {
                            Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 c\u00f3 1 tr\u00e1i \u00e1c qu\u1ef7 trong h\u00e0nh trang!");
                            return false;
                        }
                        int rdom = Util.random(1000);
                        int id_add = rdom < 50 ? 316 : (rdom < 130 ? 32 : (rdom < 210 ? 93 : (rdom < 330 ? 317 : (rdom < 450 ? 92 : (rdom < 580 ? 219 : (rdom < 710 ? 220 : 33))))));
                        if (2 > Util.random(150)) {
                            id_add = (short)(50 > Util.random(120) ? 240 : (50 > Util.random(120) ? 161 : 160));
                        }
                        if (!p.item.add_item_bag47(4, id_add, 1)) {
                            Service.send_box_ThongBao_OK(p, "H\u00e0nh trang kh\u00f4ng \u0111\u1ee7 ch\u1ed7 tr\u1ed1ng!");
                            return false;
                        }
                        if (id_add == 240 || id_add == 161 || id_add == 160) {
                            Manager.gI().chatKTG(0, p.name + " m\u1edf R\u01b0\u01a1ng \u0111\u1ea1i \u00e1c qu\u1ef7 nh\u1eadn \u0111\u01b0\u1ee3c " + ItemTemplate4.get_item_name(id_add) + ", th\u1eadt l\u00e0 may m\u1eafn", 5);
                        }
                        UseItem.open_taq_random(p, id_add, "R\u01b0\u01a1ng \u0111\u1ea1i \u00e1c qu\u1ef7", "Nh\u1eadn ng\u1eabu nhi\u00ean");
                        return used;
                    }
                    case 32: 
                    case 33: 
                    case 34: 
                    case 88: 
                    case 90: 
                    case 91: 
                    case 92: 
                    case 93: 
                    case 160: 
                    case 161: 
                    case 219: 
                    case 220: 
                    case 240: 
                    case 316: 
                    case 317: 
                    case 318: 
                    case 427: {
                        Service.send_box_yesno(p, id + 4000, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 mu\u1ed1n s\u1eed d\u1ee5ng " + ItemTemplate4.get_it_by_id((int)id).name, new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{-1, -1});
                        return false;
                    }
                    case 80: {
                        EffTemplate eff = p.get_eff(2);
                        if (eff != null && eff.time > System.currentTimeMillis() + 3000L) {
                            if (eff.time - System.currentTimeMillis() < 604800000L) {
                                eff.time += 0x6DDD00L;
                            }
                        } else {
                            p.add_new_eff(2, 2, 0x6DDD00L);
                        }
                        Service.CountDown_Ticket(p);
                        Service.send_box_ThongBao_OK(p, "D\u00f9ng x2 exp th\u00e0nh c\u00f4ng, l\u01b0u \u00fd th\u1eddi gian c\u1ed9ng d\u1ed3n t\u1ed1i \u0111a 7 ng\u00e0y");
                        return used;
                    }
                    case 86: {
                        Service.send_box_yesno(p, 35, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 mu\u1ed1n s\u1eed d\u1ee5ng Tr\u00e1i \u00c1c Qu\u1ef7?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{-1, -1});
                        return false;
                    }
                    case 87: {
                        Service.send_box_yesno(p, 37, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 mu\u1ed1n s\u1eed d\u1ee5ng Tr\u00e1i \u00c1c Qu\u1ef7 trung c\u1ea5p?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{-1, -1});
                        return false;
                    }
                    case 112: 
                    case 113: 
                    case 114: 
                    case 115: 
                    case 116: 
                    case 117: 
                    case 118: 
                    case 119: 
                    case 120: 
                    case 121: {
                        UseItem.open_box(p, ItemTemplate4.get_it_by_id((int)id).type, (id - 111) * 10);
                        return used;
                    }
                    case 122: 
                    case 123: 
                    case 124: 
                    case 125: 
                    case 126: 
                    case 127: 
                    case 128: 
                    case 129: 
                    case 130: 
                    case 131: {
                        UseItem.open_box(p, ItemTemplate4.get_it_by_id((int)id).type, (id - 121) * 10);
                        return used;
                    }
                    case 133: {
                        EffTemplate eff = p.get_eff(17);
                        if (eff != null && eff.time > System.currentTimeMillis() + 3000L) {
                            if (eff.time - System.currentTimeMillis() < 604800000L) {
                                eff.time += 0x6DDD00L;
                            }
                        } else {
                            p.add_new_eff(17, 3, 0x6DDD00L);
                        }
                        eff = p.get_eff(17);
                        Service.send_box_ThongBao_OK(p, "Th\u1eddi gian EXP \u0111\u1eb7c bi\u1ec7t c\u00f2n l\u1ea1i " + Util.get_time_str_by_sec2(eff.time - System.currentTimeMillis()) + "\nL\u01b0u \u00fd th\u1eddi gian c\u1ed9ng d\u1ed3n t\u1ed1i \u0111a 7 ng\u00e0y");
                        return used;
                    }
                    case 159: {
                        EffTemplate eff = p.get_eff(3);
                        if (eff != null && eff.time > System.currentTimeMillis() + 3000L) {
                            if (eff.time - System.currentTimeMillis() < 604800000L) {
                                eff.time += 0x6DDD00L;
                            }
                        } else {
                            p.add_new_eff(3, 3, 0x6DDD00L);
                        }
                        eff = p.get_eff(3);
                        Service.send_box_ThongBao_OK(p, "Th\u1eddi gian x2 k\u1ef9 n\u0103ng EXP c\u00f2n l\u1ea1i " + Util.get_time_str_by_sec2(eff.time - System.currentTimeMillis()) + "\nC\u00f3 th\u1ec3 xem l\u1ea1i \u1edf npc Robin, L\u01b0u \u00fd th\u1eddi gian c\u1ed9ng d\u1ed3n t\u1ed1i \u0111a 7 ng\u00e0y");
                        return used;
                    }
                    case 179: {
                        EffTemplate eff = p.get_eff(4);
                        if (eff != null && eff.time > System.currentTimeMillis() + 3000L) {
                            if (eff.time - System.currentTimeMillis() >= 604800000L) return used;
                            eff.time += 300000L;
                            return used;
                        }
                        p.add_new_eff(4, 50, 300000L);
                        p.update_info_to_all();
                        return used;
                    }
                    case 455: {
                        int random_color = 10 > Util.random(120) ? 3 : (50 > Util.random(120) ? 2 : 1);
                        for (int i = 0; i < p.skill_point.size(); ++i) {
                            if (p.skill_point.get((int)i).temp.indexSkillInServer != 666) continue;
                            random_color = 70 > Util.random(100) ? 3 : 2;
                            break;
                        }
                        int id_random = 0;
                        switch (random_color) {
                            case 1: {
                                id_random = 5 > Util.random(120) ? 12012 : (20 > Util.random(120) ? 12011 : (40 > Util.random(120) ? 12010 : 12009));
                                break;
                            }
                            case 2: {
                                id_random = 5 > Util.random(120) ? 12008 : (20 > Util.random(120) ? 12007 : (40 > Util.random(120) ? 12006 : 12005));
                                break;
                            }
                            case 3: {
                                id_random = 5 > Util.random(120) ? 12004 : (20 > Util.random(120) ? 12003 : (40 > Util.random(120) ? 12002 : 12001));
                            }
                        }
                        ArrayList<GiftBox> list = new ArrayList<GiftBox>();
                        ItemTemplate3 itemTemplate3 = ItemTemplate3.get_it_by_id(id_random);
                        if (itemTemplate3 != null) {
                            GiftBox gb4 = new GiftBox();
                            gb4.id = (short)id_random;
                            gb4.type = (byte)3;
                            gb4.name = itemTemplate3.name;
                            gb4.icon = itemTemplate3.icon;
                            gb4.num = 1;
                            gb4.color = itemTemplate3.color;
                            list.add(gb4);
                        }
                        if (list.size() <= 0) return used;
                        Service.send_gift(p, 1, "M\u1edf r\u01b0\u01a1ng Dial", "Nh\u1eadn \u0111\u01b0\u1ee3c", list, true);
                        return used;
                    }
                    case 519: {
                        switch (p.map.template.id) {
                            case 1: 
                            case 9: 
                            case 17: 
                            case 25: 
                            case 33: 
                            case 41: 
                            case 49: 
                            case 69: 
                            case 83: 
                            case 93: 
                            case 113: 
                            case 191: {
                                ArrayList<GiftBox> listGift = new ArrayList<GiftBox>();
                                int id_random = Util.random(493, 518);
                                ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(id_random);
                                GiftBox giftBox = new GiftBox();
                                giftBox.id = (short)id_random;
                                giftBox.type = (byte)4;
                                giftBox.name = itemTemplate4.name;
                                giftBox.icon = itemTemplate4.icon;
                                giftBox.num = 1;
                                giftBox.color = 0;
                                listGift.add(giftBox);
                                Service.send_gift(p, 0, "R\u01b0\u01a1ng h\u00e0nh tr\u00ecnh", "Ph\u1ea7n th\u01b0\u1edfng", listGift, true);
                                return used;
                            }
                        }
                        Service.send_box_ThongBao_OK(p, "H\u00e3y \u0111\u1ee9ng \u1edf l\u00e0ng \u0111\u1ec3 m\u1edf r\u01b0\u01a1ng");
                        return false;
                    }
                    case 548: {
                        EffTemplate eff = p.get_eff(8);
                        if (eff != null && eff.time > System.currentTimeMillis() + 3000L) {
                            if (eff.time - System.currentTimeMillis() < 2592000000L) {
                                eff.time += 0x6DDD00L;
                            }
                        } else {
                            p.add_new_eff(8, 2, 0x6DDD00L);
                        }
                        eff = p.get_eff(8);
                        Service.send_box_ThongBao_OK(p, "Th\u1eddi gian kh\u00f3a EXP c\u00f2n l\u1ea1i " + Util.get_time_str_by_sec2(eff.time - System.currentTimeMillis()) + "\nC\u00f3 th\u1ec3 xem l\u1ea1i \u1edf npc Robin, L\u01b0u \u00fd th\u1eddi gian c\u1ed9ng d\u1ed3n t\u1ed1i \u0111a 30 ng\u00e0y");
                        return used;
                    }
                    default: {
                        Service.send_box_ThongBao_OK(p, "Hi\u1ec7n t\u1ea1i " + ItemTemplate4.get_item_name(id) + " ch\u01b0a s\u1eed d\u1ee5ng \u0111\u01b0\u1ee3c");
                        return false;
                    }
                }
            }
        } else {
            Service.send_box_ThongBao_OK(p, "V\u1eadt ph\u1ea9m l\u1ed7i, h\u00e3y b\u00e1o cho admin");
            return false;
        }
    }

    private static void open_taq_random(Player p, int id, String name1, String name2) throws IOException {
        Message m = new Message(-34);
        m.writer().writeByte(21);
        m.writer().writeShort(-1);
        m.writer().writeUTF(name1);
        m.writer().writeUTF(name2);
        m.writer().writeByte(1);
        ItemTemplate4 it_temp = ItemTemplate4.get_it_by_id(id);
        m.writer().writeByte(4);
        m.writer().writeUTF(it_temp.name);
        m.writer().writeShort(it_temp.icon);
        m.writer().writeInt(1);
        m.writer().writeByte(0);
        p.conn.addmsg(m);
        m.cleanup();
    }

    private static void open_box(Player p, byte type, int level) throws IOException {
        if (level == 90 || level == 100) {
            ArrayList<GiftBox> list = new ArrayList<GiftBox>();
            switch (level) {
                case 90: {
                    GiftBox gb1 = new GiftBox();
                    ItemTemplate4 it_temp4 = ItemTemplate4.get_it_by_id(Util.random(313, 316));
                    if (it_temp4 == null) break;
                    gb1.id = it_temp4.id;
                    gb1.type = (byte)4;
                    gb1.name = it_temp4.name;
                    gb1.icon = it_temp4.icon;
                    gb1.num = Util.random(1, 4);
                    gb1.color = 0;
                    list.add(gb1);
                    break;
                }
                case 100: {
                    GiftBox gb1 = new GiftBox();
                    ItemTemplate4 it_temp4 = ItemTemplate4.get_it_by_id(Util.random(545, 548));
                    if (it_temp4 == null) break;
                    gb1.id = it_temp4.id;
                    gb1.type = (byte)4;
                    gb1.name = it_temp4.name;
                    gb1.icon = it_temp4.icon;
                    gb1.num = Util.random(1, 4);
                    gb1.color = 0;
                    list.add(gb1);
                    break;
                }
            }
            if (list.size() > 0) {
                Service.send_gift(p, 1, "M\u1edf kh\u00f3a r\u01b0\u01a1ng cam " + level + " c\u00f9ng h\u1ec7", "M\u1ea3nh trang b\u1ecb " + level, list, true);
            }
        } else {
            switch (type) {
                case 22: {
                    int bound1 = level / 10 * 192;
                    int bound2 = (level / 10 + 1) * 192;
                    ArrayList<Item_wear> list_receiv = new ArrayList<Item_wear>();
                    Item_wear temp = new Item_wear();
                    int id_add = 0;
                    if (90 > Util.random(120)) {
                        while (ItemTemplate3.get_it_by_id((int)id_add).color != 3 || ItemTemplate3.get_it_by_id((int)id_add).typeEquip >= 6 || ItemTemplate3.get_it_by_id((int)id_add).clazz != 0 && ItemTemplate3.get_it_by_id((int)id_add).clazz != p.clazz) {
                            id_add = Util.random(bound1, bound2);
                        }
                    } else {
                        while (ItemTemplate3.get_it_by_id((int)id_add).color != 3 || ItemTemplate3.get_it_by_id((int)id_add).typeEquip >= 6) {
                            id_add = Util.random(bound1, bound2);
                        }
                    }
                    if (id_add > 0) {
                        temp.setup_template_by_id(id_add);
                        list_receiv.add(temp);
                        if (temp.template != null) {
                            temp.numLoKham = (byte)(50 > Util.random(120) ? 0 : (70 > Util.random(120) ? 1 : 2));
                            p.item.add_item_bag3(temp);
                        }
                        Service.open_box_item3_orange(p, list_receiv, 545, "M\u1edf Kh\u00f3a R\u01b0\u01a1ng", "R\u01b0\u01a1ng \u0110\u1ed3 Cam Lv" + level);
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "L\u1ed7i, h\u00e3y th\u1eed l\u1ea1i");
                    break;
                }
                case 23: {
                    int bound1 = level / 10 * 192;
                    int bound2 = (level / 10 + 1) * 192;
                    ArrayList<Item_wear> list_receiv = new ArrayList<Item_wear>();
                    Item_wear temp = new Item_wear();
                    int id_add = 0;
                    while (ItemTemplate3.get_it_by_id((int)id_add).color != 3 || ItemTemplate3.get_it_by_id((int)id_add).typeEquip >= 6 || ItemTemplate3.get_it_by_id((int)id_add).clazz != 0 && ItemTemplate3.get_it_by_id((int)id_add).clazz != p.clazz) {
                        id_add = Util.random(bound1, bound2);
                    }
                    if (id_add > 0) {
                        temp.setup_template_by_id(id_add);
                        list_receiv.add(temp);
                        if (temp.template != null) {
                            temp.numLoKham = (byte)(50 > Util.random(120) ? 0 : (70 > Util.random(120) ? 1 : 2));
                            p.item.add_item_bag3(temp);
                        }
                        Service.open_box_item3_orange(p, list_receiv, 545, "M\u1edf Kh\u00f3a R\u01b0\u01a1ng", "R\u01b0\u01a1ng \u0110\u1ed3 Cam c\u00f9ng h\u1ec7 Lv" + level);
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "L\u1ed7i, h\u00e3y th\u1eed l\u1ea1i");
                    break;
                }
            }
        }
    }

    private static void use_item_3(Player p, int id) throws IOException {
        if (p.use_item_3 == -1) {
            if (p.item.able_bag() < 1) {
                Service.send_box_ThongBao_OK(p, "h\u00e3y \u0111\u1ec3 tr\u1ed1ng 1 \u00f4 trong h\u00e0nh trang m\u1edbi th\u1ef1c hi\u1ec7n \u0111c nh\u00e9");
                return;
            }
            Item_wear it = p.item.bag3[id];
            if (it != null) {
                if (UseItem.check_it_can_wear(it.template.typeEquip)) {
                    p.use_item_3 = id;
                    if (it.typelock == 1 || it.valueKichAn == 12) {
                        p.wear_item(it);
                    } else {
                        Service.send_box_yesno(p, 0, "Th\u00f4ng b\u00e1o", "Khi trang b\u1ecb l\u00ean ng\u01b0\u1eddi v\u1eadt ph\u1ea9m " + ItemTemplate3.get_it_by_id((int)it.template.id).name + " s\u1ebd chuy\u1ec3n sang tr\u1ea1ng th\u00e1i kh\u00f3a kh\u00f4ng th\u1ec3 giao d\u1ecbch. B\u1ea1n c\u00f3 mu\u1ed1n trang b\u1ecb?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, 1});
                    }
                } else if (it.template.id == 11001) {
                    ArrayList<String> name_skill = new ArrayList<String>();
                    for (int i = 0; i < p.skill_point.size(); ++i) {
                        if (p.skill_point.get((int)i).temp.ID < 2000 || p.skill_point.get((int)i).temp.typeSkill != 1) continue;
                        name_skill.add(p.skill_point.get((int)i).temp.name);
                    }
                    if (name_skill.size() > 0) {
                        String[] str = new String[name_skill.size() + 1];
                        byte[] select = new byte[name_skill.size() + 1];
                        for (int i = 0; i < str.length - 1; ++i) {
                            str[i] = (String)name_skill.get(i);
                            select[i] = -1;
                        }
                        str[str.length - 1] = "H\u1ee7y";
                        select[str.length - 1] = -1;
                        p.data_yesno = new int[]{id};
                        Service.send_box_yesno(p, 38, "Th\u00f4ng b\u00e1o", "B\u1ea1n mu\u1ed1n d\u00f9ng cho skill n\u00e0o hi\u1ec7n t\u1ea1i?", str, select);
                    } else {
                        Service.send_box_ThongBao_OK(p, "Ch\u01b0a c\u00f3 k\u1ef9 n\u0103ng n\u00e0o c\u00f3 th\u1ec3 d\u00f9ng v\u1edbi v\u1eadt ph\u1ea9m n\u00e0y");
                    }
                } else {
                    Service.send_box_ThongBao_OK(p, "Ch\u01b0a c\u00f3 ch\u1ee9c n\u0103ng");
                }
            }
        }
    }

    public static boolean check_it_can_wear(byte type) {
        return type >= 0 && type <= 5 || type == 7;
    }

    public static void use_item_potion(Player p, int id) throws IOException {
        int numInBag = p.item.total_item_bag_by_id(4, id);
        if (numInBag > 0 && UseItem.use_item_4(p, id)) {
            if (id != 271) {
                p.item.remove_item47(4, id, 1);
            }
            Message m2 = new Message(-13);
            m2.writer().writeShort(id);
            m2.writer().writeShort(p.item.total_item_bag_by_id(4, id));
            p.conn.addmsg(m2);
            m2.cleanup();
            p.item.update_Inventory(-1, false);
        }
    }
}

