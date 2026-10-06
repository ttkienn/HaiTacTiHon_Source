/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Item;
import client.Player;
import core.Service;
import core.Util;
import io.Message;
import java.io.IOException;
import java.util.ArrayList;
import template.ItemBag47;
import template.ItemTemplate4;
import template.ItemTemplate7;
import template.Item_wear;

public class Trade {
    public static void process(Player p, Message m2) throws IOException {
        byte action = m2.reader().readByte();
        short id = -1;
        int cat = -1;
        int num = -1;
        String str = "";
        if (action == 1 || action == 6) {
            id = m2.reader().readShort();
            cat = m2.reader().readByte();
            num = m2.reader().readInt();
        }
        if (action == 2) {
            str = m2.reader().readUTF();
        }
        switch (action) {
            case 6: {
                if (num == 1) {
                    Player p0 = p.map.get_player_by_id_inmap(id);
                    if (p0 != null) {
                        if (p0.trade_target == null || !p0.trade_target.equals(p)) {
                            Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng \u0111ang giao d\u1ecbch v\u1edbi ng\u01b0\u1eddi kh\u00e1c");
                            p.fee_trade = 0;
                            p.money_trade = 0L;
                            p.is_lock_trade = false;
                            p.is_accept_trade = false;
                            p.list_item_trade3 = null;
                            p.list_item_trade47 = null;
                            p.trade_target = null;
                            return;
                        }
                        Trade.show_table(p, p.trade_target.name);
                        Trade.show_table(p.trade_target, p.name);
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng kh\u00f4ng online");
                    break;
                }
                if (num != 0) break;
                Player p0 = p.map.get_player_by_id_inmap(id);
                if (p0 != null) {
                    if (p0.conn.status != 1) {
                        Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng ch\u01b0a K\u00edch ho\u1ea1t kh\u00f4ng th\u1ec3 giao d\u1ecbch");
                        return;
                    }
                    if (p0.trade_target != null) {
                        Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng \u0111ang c\u00f3 giao d\u1ecbch");
                        return;
                    }
                    if (p.trade_target != null) {
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111ang \u0111\u1ee3i \u0111\u1ed1i ph\u01b0\u01a1ng ch\u1ea5p nh\u1eadn l\u1eddi m\u1eddi giao d\u1ecbch");
                        return;
                    }
                    p0.trade_target = p;
                    p.trade_target = p0;
                    Message m = new Message(-49);
                    m.writer().writeByte(6);
                    m.writer().writeByte(1);
                    m.writer().writeShort(p.index_map);
                    m.writer().writeUTF(p.name);
                    p0.conn.addmsg(m);
                    m.cleanup();
                    break;
                }
                Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng kh\u00f4ng online");
                break;
            }
            case 1: {
                ItemTemplate4 it_temp;
                if (p.trade_target != null && p.is_lock_trade) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng th\u1ec3 th\u1ef1c hi\u1ec7n khi \u0111\u00e3 kh\u00f3a giao d\u1ecbch");
                    return;
                }
                if (num == 1 && cat == 3 && p.trade_target != null) {
                    Item_wear it_select = p.item.bag3[id];
                    if (it_select == null) break;
                    boolean send_or_remove = true;
                    for (int i = 0; i < p.list_item_trade3.size(); ++i) {
                        if (!it_select.equals(p.list_item_trade3.get(i))) continue;
                        p.list_item_trade3.remove(it_select);
                        send_or_remove = false;
                        break;
                    }
                    if (p.trade_target.item.able_bag() - p.list_item_trade3.size() - p.list_item_trade47.size() < 1) {
                        Service.send_box_ThongBao_OK(p, "H\u00e0nh trang \u0111\u1ed1i ph\u01b0\u01a1ng kh\u00f4ng \u0111\u1ee7 ch\u1ed7 tr\u1ed1ng");
                        return;
                    }
                    if (send_or_remove) {
                        if (Trade.can_add_item_trade(p)) {
                            if (it_select.typelock == 1) {
                                Service.send_box_ThongBao_OK(p, "Trang b\u1ecb \u0111\u00e3 kh\u00f3a kh\u00f4ng th\u1ec3 giao d\u1ecbch!");
                                return;
                            }
                            Message m = new Message(-49);
                            m.writer().writeByte(1);
                            m.writer().writeByte(1);
                            m.writer().writeByte(3);
                            m.writer().writeByte(1);
                            Item.readUpdateItem(m.writer(), it_select, p);
                            p.trade_target.conn.addmsg(m);
                            m.cleanup();
                            m = new Message(-49);
                            m.writer().writeByte(1);
                            m.writer().writeByte(0);
                            m.writer().writeByte(3);
                            m.writer().writeByte(1);
                            Item.readUpdateItem(m.writer(), it_select, p);
                            p.conn.addmsg(m);
                            m.cleanup();
                            p.list_item_trade3.add(it_select);
                            break;
                        }
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng th\u1ec3 th\u00eam v\u1eadt ph\u1ea9m");
                        break;
                    }
                    Message m = new Message(-49);
                    m.writer().writeByte(1);
                    m.writer().writeByte(1);
                    m.writer().writeByte(3);
                    m.writer().writeByte(0);
                    m.writer().writeShort(id);
                    p.trade_target.conn.addmsg(m);
                    m.cleanup();
                    m = new Message(-49);
                    m.writer().writeByte(1);
                    m.writer().writeByte(0);
                    m.writer().writeByte(3);
                    m.writer().writeByte(0);
                    m.writer().writeShort(id);
                    p.conn.addmsg(m);
                    m.cleanup();
                    break;
                }
                if (num > 0 && cat == 6 && id == 0 && p.trade_target != null) {
                    if (num > 2000000000) {
                        Service.send_box_ThongBao_OK(p, "Giao d\u1ecbch t\u1ed1i \u0111a 2 t\u1ef7");
                    }
                    long beri_quant = (long)num * 12L / 10L;
                    if (p.get_vang() < beri_quant) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + Util.number_format(beri_quant) + " beri, ph\u00ed giao d\u1ecbch beri 20%");
                        return;
                    }
                    Message m = new Message(-49);
                    m.writer().writeByte(1);
                    m.writer().writeByte(1);
                    m.writer().writeByte(6);
                    m.writer().writeInt(num);
                    p.trade_target.conn.addmsg(m);
                    m.cleanup();
                    m = new Message(-49);
                    m.writer().writeByte(1);
                    m.writer().writeByte(0);
                    m.writer().writeByte(6);
                    m.writer().writeInt(num);
                    p.conn.addmsg(m);
                    m.cleanup();
                    p.money_trade = num;
                    break;
                }
                if (num > 0 && cat == 7 && p.trade_target != null) {
                    ItemTemplate7 it_temp2 = ItemTemplate7.get_it_by_id(id);
                    if (it_temp2 == null) break;
                    boolean send_or_remove = true;
                    for (int i = 0; i < p.list_item_trade47.size(); ++i) {
                        if (p.list_item_trade47.get((int)i).category != 7 || p.list_item_trade47.get((int)i).id != id) continue;
                        send_or_remove = false;
                        p.list_item_trade47.remove(p.list_item_trade47.get(i));
                        break;
                    }
                    if (send_or_remove) {
                        if (p.item.total_item_bag_by_id(7, id) < num) {
                            Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + num + " " + it_temp2.name);
                            return;
                        }
                        if (it_temp2.istrade == 1) {
                            Service.send_box_ThongBao_OK(p, "V\u1eadt ph\u1ea9m n\u00e0y kh\u00f4ng th\u1ec3 giao d\u1ecbch!");
                            return;
                        }
                        int num_in_target_bag = p.trade_target.item.total_item_bag_by_id(7, id);
                        if (num > 2000 || num_in_target_bag + num > 2000 || num_in_target_bag == 0 && p.trade_target.item.able_bag() - p.list_item_trade3.size() - p.list_item_trade47.size() < 1) {
                            Service.send_box_ThongBao_OK(p, "H\u00e0nh trang \u0111\u1ed1i ph\u01b0\u01a1ng kh\u00f4ng \u0111\u1ee7 ch\u1ed7 tr\u1ed1ng");
                            return;
                        }
                        if (it_temp2.istrade == 0 && Trade.can_add_item_trade(p)) {
                            for (int i = 0; i < p.item.bag47.size(); ++i) {
                                if (p.item.bag47.get((int)i).category != 7 || p.item.bag47.get((int)i).id != id) continue;
                                ItemBag47 it_add = new ItemBag47();
                                it_add.category = (byte)7;
                                it_add.id = id;
                                it_add.quant = (short)num;
                                p.list_item_trade47.add(it_add);
                                break;
                            }
                            Message m = new Message(-49);
                            m.writer().writeByte(1);
                            m.writer().writeByte(1);
                            m.writer().writeByte(7);
                            m.writer().writeByte(1);
                            m.writer().writeByte(id);
                            m.writer().writeShort(num);
                            p.trade_target.conn.addmsg(m);
                            m.cleanup();
                            m = new Message(-49);
                            m.writer().writeByte(1);
                            m.writer().writeByte(0);
                            m.writer().writeByte(7);
                            m.writer().writeByte(1);
                            m.writer().writeByte(id);
                            m.writer().writeShort(num);
                            p.conn.addmsg(m);
                            m.cleanup();
                            break;
                        }
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng th\u1ec3 th\u00eam v\u1eadt ph\u1ea9m");
                        break;
                    }
                    Message m = new Message(-49);
                    m.writer().writeByte(1);
                    m.writer().writeByte(1);
                    m.writer().writeByte(7);
                    m.writer().writeByte(0);
                    m.writer().writeShort(id);
                    p.trade_target.conn.addmsg(m);
                    m.cleanup();
                    m = new Message(-49);
                    m.writer().writeByte(1);
                    m.writer().writeByte(0);
                    m.writer().writeByte(7);
                    m.writer().writeByte(0);
                    m.writer().writeShort(id);
                    p.conn.addmsg(m);
                    m.cleanup();
                    break;
                }
                if (num <= 0 || cat != 4 || p.trade_target == null || (it_temp = ItemTemplate4.get_it_by_id(id)) == null) break;
                boolean send_or_remove = true;
                for (int i = 0; i < p.list_item_trade47.size(); ++i) {
                    if (p.list_item_trade47.get((int)i).category != 4 || p.list_item_trade47.get((int)i).id != id) continue;
                    send_or_remove = false;
                    p.list_item_trade47.remove(p.list_item_trade47.get(i));
                    break;
                }
                int num_in_target_bag = p.trade_target.item.total_item_bag_by_id(4, id);
                if (num > 2000 || num_in_target_bag + num > 2000 || num_in_target_bag == 0 && p.trade_target.item.able_bag() - p.list_item_trade3.size() - p.list_item_trade47.size() < 1) {
                    Service.send_box_ThongBao_OK(p, "H\u00e0nh trang \u0111\u1ed1i ph\u01b0\u01a1ng kh\u00f4ng \u0111\u1ee7 ch\u1ed7 tr\u1ed1ng");
                    return;
                }
                if (send_or_remove) {
                    if (p.item.total_item_bag_by_id(4, id) < num) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + num + " " + it_temp.name);
                        return;
                    }
                    if (it_temp.istrade == 1) {
                        Service.send_box_ThongBao_OK(p, "V\u1eadt ph\u1ea9m n\u00e0y kh\u00f4ng th\u1ec3 giao d\u1ecbch!");
                        return;
                    }
                    if (it_temp.istrade == 0 && Trade.can_add_item_trade(p)) {
                        for (int i = 0; i < p.item.bag47.size(); ++i) {
                            if (p.item.bag47.get((int)i).category != 4 || p.item.bag47.get((int)i).id != id) continue;
                            ItemBag47 it_add = new ItemBag47();
                            it_add.category = (byte)4;
                            it_add.id = id;
                            it_add.quant = (short)num;
                            p.list_item_trade47.add(it_add);
                            break;
                        }
                        Message m = new Message(-49);
                        m.writer().writeByte(1);
                        m.writer().writeByte(1);
                        m.writer().writeByte(4);
                        m.writer().writeByte(1);
                        m.writer().writeShort(id);
                        m.writer().writeShort(num);
                        p.trade_target.conn.addmsg(m);
                        m.cleanup();
                        m = new Message(-49);
                        m.writer().writeByte(1);
                        m.writer().writeByte(0);
                        m.writer().writeByte(4);
                        m.writer().writeByte(1);
                        m.writer().writeShort(id);
                        m.writer().writeShort(num);
                        p.conn.addmsg(m);
                        m.cleanup();
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng th\u1ec3 th\u00eam v\u1eadt ph\u1ea9m");
                    break;
                }
                Message m = new Message(-49);
                m.writer().writeByte(1);
                m.writer().writeByte(1);
                m.writer().writeByte(4);
                m.writer().writeByte(0);
                m.writer().writeShort(id);
                p.trade_target.conn.addmsg(m);
                m.cleanup();
                m = new Message(-49);
                m.writer().writeByte(1);
                m.writer().writeByte(0);
                m.writer().writeByte(4);
                m.writer().writeByte(0);
                m.writer().writeShort(id);
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 5: {
                if (id != -1 || cat != -1 || num != -1 || p.trade_target == null) break;
                Trade.end_trade_by_disconnect(p.trade_target, p, 0, "");
                Trade.end_trade_by_disconnect(p, p.trade_target, 0, "");
                break;
            }
            case 2: {
                if (id != -1 || cat != -1 || num != -1 || str.isEmpty() || p.trade_target == null) break;
                Message m = new Message(-49);
                m.writer().writeByte(2);
                m.writer().writeByte(1);
                m.writer().writeUTF(str);
                p.trade_target.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 3: {
                if (id != -1 || cat != -1 || num != -1 || p.trade_target == null || p.is_lock_trade) break;
                Message m = new Message(-49);
                m.writer().writeByte(3);
                m.writer().writeByte(1);
                p.trade_target.conn.addmsg(m);
                m.cleanup();
                m = new Message(-49);
                m.writer().writeByte(3);
                m.writer().writeByte(0);
                p.conn.addmsg(m);
                m.cleanup();
                p.is_lock_trade = true;
                if (p.money_trade > 0L) {
                    p.fee_trade = (int)((long)p.fee_trade + (10L + p.money_trade / 2000L));
                }
                for (int i = 0; i < p.list_item_trade3.size(); ++i) {
                    Item_wear it_select = p.list_item_trade3.get(i);
                    p.fee_trade += it_select.template.color * 50;
                    p.fee_trade += 5000 * it_select.numLoKham;
                    p.fee_trade += 5000 * it_select.mdakham.length;
                    p.fee_trade += 5000 * it_select.levelup;
                    if (it_select.valueKichAn > -1) {
                        p.fee_trade += 10000;
                    }
                    p.fee_trade += 10000 * it_select.isHoanMy;
                }
                int fee_item4 = 0;
                for (int i = 0; i < p.list_item_trade47.size(); ++i) {
                    fee_item4 += p.list_item_trade47.get((int)i).quant;
                }
                if (fee_item4 > 0 && fee_item4 <= 100) {
                    fee_item4 = 20;
                }
                if (fee_item4 > 100) {
                    fee_item4 /= 5;
                }
                p.fee_trade += fee_item4;
                Service.send_box_ThongBao_OK(p.trade_target, p.name + " \u0111\u00e3 kh\u00f3a giao d\u1ecbch, m\u1ee9c ph\u00ed giao d\u1ecbch hi\u1ec7n t\u1ea1i l\u00e0 " + p.trade_target.fee_trade + " Ruby");
                Service.send_box_ThongBao_OK(p, p.name + " \u0111\u00e3 kh\u00f3a giao d\u1ecbch, m\u1ee9c ph\u00ed giao d\u1ecbch hi\u1ec7n t\u1ea1i l\u00e0 " + p.fee_trade + " Ruby");
                break;
            }
            case 4: {
                if (id != -1 || cat != -1 || num != -1 || p.trade_target == null || !p.is_lock_trade || !p.trade_target.is_lock_trade || p.is_accept_trade) break;
                p.is_accept_trade = true;
                if (p.trade_target.is_accept_trade) {
                    Object it_add;
                    int i;
                    p.trade_target.update_ngoc(-p.trade_target.fee_trade);
                    p.update_ngoc(-p.fee_trade);
                    p.update_vang(-(p.money_trade * 12L) / 10L);
                    p.trade_target.update_vang(-(p.trade_target.money_trade * 12L) / 10L);
                    p.update_vang(p.trade_target.money_trade);
                    p.trade_target.update_vang(p.money_trade);
                    if (p.get_vang() < 0L) {
                        p.update_vang(-p.get_vang());
                        p.trade_target.update_vang(p.get_vang());
                    }
                    if (p.trade_target.get_vang() < 0L) {
                        p.trade_target.update_vang(-p.trade_target.get_vang());
                        p.update_vang(p.trade_target.get_vang());
                    }
                    p.update_money();
                    p.trade_target.update_money();
                    for (i = 0; i < p.list_item_trade3.size(); ++i) {
                        p.item.remove_item_wear(p.list_item_trade3.get(i));
                    }
                    for (i = 0; i < p.trade_target.list_item_trade3.size(); ++i) {
                        p.trade_target.item.remove_item_wear(p.trade_target.list_item_trade3.get(i));
                    }
                    for (i = 0; i < p.trade_target.list_item_trade3.size(); ++i) {
                        it_add = new Item_wear();
                        ((Item_wear)it_add).clone_obj(p.trade_target.list_item_trade3.get(i));
                        if (((Item_wear)it_add).template == null) continue;
                        p.item.add_item_bag3((Item_wear)it_add);
                    }
                    for (i = 0; i < p.list_item_trade3.size(); ++i) {
                        it_add = new Item_wear();
                        ((Item_wear)it_add).clone_obj(p.list_item_trade3.get(i));
                        if (it_add == null) continue;
                        p.trade_target.item.add_item_bag3((Item_wear)it_add);
                    }
                    for (i = 0; i < p.list_item_trade47.size(); ++i) {
                        p.item.remove_item47(p.list_item_trade47.get((int)i).category, p.list_item_trade47.get((int)i).id, p.list_item_trade47.get((int)i).quant);
                    }
                    for (i = 0; i < p.trade_target.list_item_trade47.size(); ++i) {
                        p.trade_target.item.remove_item47(p.trade_target.list_item_trade47.get((int)i).category, p.trade_target.list_item_trade47.get((int)i).id, p.trade_target.list_item_trade47.get((int)i).quant);
                    }
                    for (i = 0; i < p.trade_target.list_item_trade47.size(); ++i) {
                        it_add = p.trade_target.list_item_trade47.get(i);
                        p.item.add_item_bag47(((ItemBag47)it_add).category, ((ItemBag47)it_add).id, ((ItemBag47)it_add).quant);
                    }
                    for (i = 0; i < p.list_item_trade47.size(); ++i) {
                        it_add = p.list_item_trade47.get(i);
                        p.trade_target.item.add_item_bag47(((ItemBag47)it_add).category, ((ItemBag47)it_add).id, ((ItemBag47)it_add).quant);
                    }
                    p.item.update_Inventory(-1, false);
                    p.trade_target.item.update_Inventory(-1, false);
                    Trade.end_trade_by_disconnect(p.trade_target, p, 1, "");
                    Trade.end_trade_by_disconnect(p, p.trade_target, 1, "");
                    break;
                }
                Message m = new Message(-49);
                m.writer().writeByte(4);
                m.writer().writeByte(1);
                p.trade_target.conn.addmsg(m);
                m.cleanup();
                m = new Message(-49);
                m.writer().writeByte(4);
                m.writer().writeByte(0);
                p.conn.addmsg(m);
                m.cleanup();
            }
        }
    }

    private static boolean can_add_item_trade(Player p) {
        return p.list_item_trade3.size() + p.list_item_trade47.size() < 4;
    }

    public static void end_trade_by_disconnect(Player p_mine, Player p_target, int type, String name_exit) throws IOException {
        Message m = new Message(-49);
        m.writer().writeByte(5);
        m.writer().writeByte(0);
        if (type == 1) {
            m.writer().writeUTF("Giao d\u1ecbch v\u1edbi " + p_target.name + " ho\u00e0n t\u1ea5t");
        } else if (type == 0) {
            m.writer().writeUTF(p_target.name + " h\u1ee7y giao d\u1ecbch");
        } else if (type == 2) {
            m.writer().writeUTF("Giao d\u1ecbch b\u1ecb h\u1ee7y b\u1ecf v\u00ec " + name_exit + " kh\u00f4ng \u0111\u1ee7 kh\u1ea3 n\u0103ng \u0111\u1ec3 tr\u1ea3 ph\u00ed cho giao d\u1ecbch n\u00e0y");
        }
        p_mine.conn.addmsg(m);
        m.cleanup();
        p_mine.fee_trade = 0;
        p_mine.money_trade = 0L;
        p_mine.is_lock_trade = false;
        p_mine.is_accept_trade = false;
        p_mine.list_item_trade3 = null;
        p_mine.list_item_trade47 = null;
        p_mine.trade_target = null;
    }

    public static void show_table(Player p, String name) throws IOException {
        Message m = new Message(-49);
        m.writer().writeByte(0);
        m.writer().writeByte(0);
        m.writer().writeUTF(name);
        p.conn.addmsg(m);
        m.cleanup();
        p.list_item_trade3 = new ArrayList<Item_wear>();
        p.list_item_trade47 = new ArrayList<ItemBag47>();
        p.fee_trade = 0;
        p.money_trade = 0L;
        p.is_lock_trade = false;
        p.is_accept_trade = false;
    }
}

