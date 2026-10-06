/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import io.Message;
import java.io.IOException;
import java.util.List;
import template.ItemBag47;
import template.ItemTemplate4;
import template.ItemTemplate4_Info;

public class HanhTrinh {
    public static final String[] NAME = new String[]{"L\u00e0ng Foosha", "TT. V\u1ecf S\u00f2", "TT. Orange", "L\u00e0ng Sirup", "Baratie", "L\u00e0ng h\u1ea1t d\u1ebb", "TT. Kh\u1edfi \u0110\u1ea7u", "TT. Whiskey", "TT. HORN", "TT. Nanohana", "\u0110\u1ea3o tr\u1eddi", "Water 7"};
    public static final short[] ICON = new short[]{803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814};
    public static final short[] LANG = new short[]{1, 9, 17, 25, 33, 41, 49, 69, 83, 93, 113, 191};

    public static void show_table(Player p, int type) throws IOException {
        if (type == 0) {
            Message m = new Message(79);
            m.writer().writeByte(4);
            m.writer().writeUTF("B\u1ea3n \u0111\u1ed3 h\u00e0nh tr\u00ecnh");
            m.writer().writeByte(NAME.length);
            for (int i = 0; i < NAME.length; ++i) {
                m.writer().writeUTF(NAME[i]);
                m.writer().writeShort(p.get_icon_daHanhTrinh(i));
            }
            p.conn.addmsg(m);
            m.cleanup();
        } else if (type == 1) {
            Message m = new Message(79);
            m.writer().writeByte(0);
            m.writer().writeShort(HanhTrinh.get_map(p));
            m.writer().writeUTF(p.map.template.name);
            List<ItemBag47> list_DaHanhTrinh = p.get_list_daHanhTrinh_total(p.map.template.id);
            m.writer().writeByte(list_DaHanhTrinh.size());
            for (int i = 0; i < list_DaHanhTrinh.size(); ++i) {
                ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(list_DaHanhTrinh.get((int)i).id);
                m.writer().writeUTF(itemTemplate4.name);
                m.writer().writeByte(4);
                m.writer().writeShort(itemTemplate4.id);
                m.writer().writeByte(1);
                m.writer().writeShort(itemTemplate4.icon);
                ItemTemplate4_Info temp_info = ItemTemplate4_Info.get_by_id(itemTemplate4.indexInfoPotion);
                if (temp_info != null) {
                    m.writer().writeUTF(temp_info.info);
                    continue;
                }
                m.writer().writeUTF("Ch\u01b0a c\u00f3 th\u00f4ng tin");
            }
            p.conn.addmsg(m);
            m.cleanup();
            HanhTrinh.update_da_kham(p);
        }
    }

    public static int get_map(Player p) {
        for (int i = 0; i < LANG.length; ++i) {
            if (p.map.template.id != LANG[i]) continue;
            return ICON[i];
        }
        return ICON[0];
    }

    public static void update_da_kham(Player p) throws IOException {
        Message m = new Message(79);
        m.writer().writeByte(1);
        ItemBag47 it_select = p.get_daHanhTrinh(p.map.template.id);
        if (it_select != null) {
            m.writer().writeByte(1);
            ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(it_select.id);
            m.writer().writeUTF(itemTemplate4.name);
            m.writer().writeByte(4);
            m.writer().writeShort(itemTemplate4.id);
            m.writer().writeShort(itemTemplate4.icon);
            ItemTemplate4_Info temp_info = ItemTemplate4_Info.get_by_id(itemTemplate4.indexInfoPotion);
            if (temp_info != null) {
                m.writer().writeUTF(temp_info.info);
            } else {
                m.writer().writeUTF("Ch\u01b0a c\u00f3 th\u00f4ng tin");
            }
        } else {
            m.writer().writeByte(0);
        }
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static void process(Player p, Message m2) throws IOException {
        ItemTemplate4 itemTemplate4;
        byte act = m2.reader().readByte();
        short id = m2.reader().readShort();
        if (act == 2) {
            ItemTemplate4 itemTemplate42 = ItemTemplate4.get_it_by_id(id);
            if (itemTemplate42 != null) {
                ItemBag47 it_select = null;
                for (int i = 0; i < p.daHanhTrinh.size(); ++i) {
                    if (p.daHanhTrinh.get((int)i).category <= -1 || p.map.template.id != LANG[p.daHanhTrinh.get((int)i).category] || p.daHanhTrinh.get((int)i).id != id || p.daHanhTrinh.get((int)i).quant != 0) continue;
                    it_select = p.daHanhTrinh.get(i);
                }
                if (it_select != null) {
                    p.data_yesno = new int[]{id};
                    Service.send_box_yesno(p, 58, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 mu\u1ed1n kh\u1ea3m " + itemTemplate42.name + "?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, -1});
                } else {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 1 " + itemTemplate42.name);
                }
            }
        } else if (act == 3 && (itemTemplate4 = ItemTemplate4.get_it_by_id(id)) != null) {
            ItemBag47 it_select = null;
            for (int i = 0; i < p.daHanhTrinh.size(); ++i) {
                if (p.daHanhTrinh.get((int)i).category <= -1 || p.map.template.id != LANG[p.daHanhTrinh.get((int)i).category] || p.daHanhTrinh.get((int)i).id != id || p.daHanhTrinh.get((int)i).quant != 1) continue;
                it_select = p.daHanhTrinh.get(i);
            }
            if (it_select != null) {
                p.data_yesno = new int[]{id};
                Service.send_box_yesno(p, 59, "Th\u00f4ng b\u00e1o", "B\u1ea1n mu\u1ed1n t\u00e1ch " + itemTemplate4.name + " v\u1edbi ph\u00ed 100 ruby?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, -1});
            } else {
                Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 1 " + itemTemplate4.name);
            }
        }
    }
}

