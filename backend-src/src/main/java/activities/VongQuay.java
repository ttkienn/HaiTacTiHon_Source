/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import core.Util;
import io.Message;
import java.io.IOException;
import template.ItemBag47;
import template.ItemTemplate4;
import template.ItemTemplate7;

public class VongQuay {
    public static short[] ID_ITEM = new short[]{174, 173, 221, 222, 223, 7, 159, 133, 112, 224, 29, 225, 48, 158};

    private static ItemBag47 get_random(Player p) {
        ItemBag47 result = null;
        if (70 > Util.random(120)) {
            return result;
        }
        int random = Util.random(10000);
        if (random < 3000 && random > 2200 && p.level > 19) {
            if (70 > Util.random(120)) {
                result = new ItemBag47();
                result.id = (short)29;
                result.category = (byte)4;
                result.quant = 1;
            } else {
                result = new ItemBag47();
                result.id = (short)158;
                result.category = (byte)4;
                result.quant = 1;
            }
        } else if (random < 1600 && random > 1300 && p.level > 19) {
            result = new ItemBag47();
            result.id = (short)(5 > Util.random(120) ? -3 : -2);
            result.category = (byte)7;
            result.quant = 1;
        } else if (random < 800 && p.level > 19) {
            if (60 > Util.random(120)) {
                result = new ItemBag47();
                result.id = (short)221;
                result.category = (byte)4;
                result.quant = 1;
            } else if (50 > Util.random(120)) {
                result = new ItemBag47();
                result.id = (short)222;
                result.category = (byte)4;
                result.quant = 1;
            } else if (40 > Util.random(120)) {
                result = new ItemBag47();
                result.id = (short)223;
                result.category = (byte)4;
                result.quant = 1;
            } else if (30 > Util.random(120)) {
                result = new ItemBag47();
                result.id = (short)224;
                result.category = (byte)4;
                result.quant = 1;
            } else if (20 > Util.random(120)) {
                result = new ItemBag47();
                result.id = (short)225;
                result.category = (byte)4;
                result.quant = 1;
            } else {
                result = new ItemBag47();
                result.id = (short)226;
                result.category = (byte)4;
                result.quant = 1;
            }
        } else {
            if (random < 2000) {
                result = new ItemBag47();
                result.id = (short)((p.level < 11 ? 11 : (int)p.level) / 10 + 111);
                result.category = (byte)4;
                result.quant = 1;
                return result;
            }
            if (random < 5000 && p.level > 19) {
                short[] rd = new short[]{48, 54, 60, 66, 72, 78};
                result = new ItemBag47();
                result.id = rd[Util.random(rd.length)];
                result.category = (byte)4;
                result.quant = 1;
            } else if (random < 8000) {
                if (33 > Util.random(120)) {
                    result = new ItemBag47();
                    result.id = (short)(p.level / 10 + 7);
                    result.category = (byte)4;
                    result.quant = 1;
                } else if (33 > Util.random(120)) {
                    result = new ItemBag47();
                    result.id = (short)159;
                    result.category = (byte)4;
                    result.quant = 1;
                } else {
                    result = new ItemBag47();
                    result.id = (short)133;
                    result.category = (byte)4;
                    result.quant = 1;
                }
            } else if (50 > Util.random(120)) {
                result = new ItemBag47();
                result.id = (short)173;
                result.category = (byte)4;
                result.quant = (short)Util.random(2, 6);
            } else {
                result = new ItemBag47();
                result.id = (short)174;
                result.category = (byte)4;
                result.quant = (short)Util.random(2, 6);
            }
        }
        return result;
    }

    public static void show_table(Player p) throws IOException {
        Message m = new Message(54);
        m.writer().writeByte(0);
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static void process(Player p, Message m2) throws IOException {
        byte action = m2.reader().readByte();
        switch (action) {
            case 3: {
                Message m = new Message(54);
                m.writer().writeByte(3);
                m.writer().writeByte(ID_ITEM.length);
                for (int i = 0; i < ID_ITEM.length; ++i) {
                    m.writer().writeByte(4);
                    m.writer().writeShort(ItemTemplate4.get_it_by_id((int)VongQuay.ID_ITEM[i]).icon);
                }
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 4: {
                Service.send_box_yesno(p, 36, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u1ea7n mua bao nhi\u00eau th\u1ebb quay? Gi\u00e1 m\u1ed7i th\u1ebb quay l\u00e0 15 ruby", new String[]{"1 th\u1ebb", "3 th\u1ebb", "H\u1ee7y"}, new byte[]{-1, -1, 1});
                break;
            }
            case 1: 
            case 2: {
                int quant_reward = 0;
                if (action == 1) {
                    if (p.item.total_item_bag_by_id(4, 232) < 1) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 v\u00e9!");
                        return;
                    }
                    p.item.remove_item47(4, 232, 1);
                    quant_reward = 3;
                } else {
                    if (p.item.total_item_bag_by_id(4, 232) < 3) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 v\u00e9!");
                        return;
                    }
                    p.item.remove_item47(4, 232, 3);
                    quant_reward = 9;
                }
                ItemBag47[] list_reward = new ItemBag47[quant_reward];
                for (int i = 0; i < quant_reward; ++i) {
                    list_reward[i] = VongQuay.get_random(p);
                }
                if (list_reward[0] == null && list_reward[1] == null && list_reward[2] == null) {
                    ItemBag47 it = new ItemBag47();
                    it.id = (short)Util.random(2, 6);
                    it.category = (byte)4;
                    it.quant = (short)Util.random(1, 6);
                    list_reward[Util.random((int)3)] = it;
                }
                boolean add_vang = false;
                Message m = new Message(54);
                m.writer().writeByte(action);
                m.writer().writeByte(list_reward.length);
                for (int i = 0; i < list_reward.length; ++i) {
                    if (list_reward[i] == null) {
                        if (!add_vang && 15 > Util.random(120)) {
                            int vang_receiv = 10 > Util.random(120) ? Util.random(10000, 20000) : Util.random(1000, 2000);
                            m.writer().writeByte(4);
                            m.writer().writeUTF("Beri");
                            m.writer().writeShort(0);
                            m.writer().writeInt(vang_receiv);
                            m.writer().writeByte(0);
                            p.update_vang(vang_receiv);
                            p.update_money();
                            add_vang = true;
                            continue;
                        }
                        m.writer().writeByte(0);
                        m.writer().writeUTF("");
                        m.writer().writeShort(-1);
                        m.writer().writeInt(0);
                        m.writer().writeByte(0);
                        continue;
                    }
                    if (list_reward[i].id == -2) {
                        ItemTemplate7 template7 = ItemTemplate7.get_it_by_id(16);
                        m.writer().writeByte(7);
                        m.writer().writeUTF(template7.name);
                        m.writer().writeShort(template7.icon);
                        m.writer().writeInt(1);
                        m.writer().writeByte(0);
                        if (p.item.add_item_bag47(7, template7.id, 1)) continue;
                    }
                    if (list_reward[i].id == -3) {
                        ItemTemplate7 template7 = ItemTemplate7.get_it_by_id(17);
                        m.writer().writeByte(7);
                        m.writer().writeUTF(template7.name);
                        m.writer().writeShort(template7.icon);
                        m.writer().writeInt(1);
                        m.writer().writeByte(0);
                        if (p.item.add_item_bag47(7, template7.id, 1)) continue;
                    }
                    ItemTemplate4 template4 = ItemTemplate4.get_it_by_id(list_reward[i].id);
                    m.writer().writeByte(4);
                    m.writer().writeUTF(template4.name);
                    m.writer().writeShort(template4.icon);
                    m.writer().writeInt(1);
                    m.writer().writeByte(0);
                    if (p.item.add_item_bag47(4, template4.id, 1)) continue;
                }
                p.conn.addmsg(m);
                m.cleanup();
                p.item.update_Inventory(-1, false);
                break;
            }
        }
    }
}

