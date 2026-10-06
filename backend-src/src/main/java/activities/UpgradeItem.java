/*
 * Decompiled with CFR 0.152.
 */
package activities;

import activities.Rebuild_Item;
import client.Item;
import client.Player;
import core.Service;
import core.Util;
import io.Message;
import java.io.ByteArrayInputStream;
import java.io.DataInputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import template.DataUpgrade;
import template.ItemTemplate3;
import template.ItemTemplate7;
import template.Item_wear;
import template.UpgradeMaterialTemplate;

public class UpgradeItem {
    public static List<DataUpgrade> DATA = new ArrayList<DataUpgrade>();

    public static void show_table_upgrade(Player p) throws IOException {
        Message m = new Message(-48);
        m.writer().writeByte(7);
        p.conn.addmsg(m);
        m.cleanup();
        p.tool_upgrade = new int[]{-1, -1};
    }

    public static void process(Player p, Message m2) throws IOException {
        byte type = m2.reader().readByte();
        short id = m2.reader().readShort();
        byte bery_gem = m2.reader().readByte();
        if (type == 8 && id == 0 && bery_gem == 0) {
            Service.Send_UI_Shop(p, 6);
        } else if (type == 7 && id == 0 && bery_gem == 0) {
            UpgradeItem.show_table_upgrade(p);
        } else if (type == 13 && id == 0 && bery_gem == 0) {
            Rebuild_Item.show_table(p, 4);
        } else if (type == 10 && id == 0 && bery_gem == 0) {
            Rebuild_Item.show_table(p, 2);
        } else if (type == 12 && id == 0 && bery_gem == 0) {
            Rebuild_Item.show_table(p, 1);
        } else if (type == 9 && id == 0 && bery_gem == 0) {
            Rebuild_Item.show_table(p, 3);
        } else if (type == 11 && id == 0 && bery_gem == 0) {
            Service.Send_UI_Shop(p, 111);
        } else if (type == 4 && bery_gem == 0) {
            Item_wear it = p.item.bag3[id];
            if (it != null) {
                if (it.template.typeEquip > 5) {
                    Service.send_box_ThongBao_OK(p, "V\u1eadt ph\u1ea9m kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                if (it.levelup < 10) {
                    Message m = new Message(-48);
                    m.writer().writeByte(4);
                    m.writer().writeShort(id);
                    p.conn.addmsg(m);
                    m.cleanup();
                } else {
                    Service.send_box_ThongBao_OK(p, "Trang b\u1ecb \u0111\u00e3 c\u01b0\u1eddng h\u00f3a c\u1ea5p t\u1ed1i \u0111a");
                }
            }
        } else if (type == 1 && bery_gem == 0) {
            Item_wear it = p.item.bag3[id];
            if (it != null) {
                if (it.levelup > 9) {
                    Service.send_box_ThongBao_OK(p, "\u0110\u00e3 n\u00e2ng c\u1ea5p t\u1ed1i \u0111a!");
                    return;
                }
                Message m = new Message(-48);
                m.writer().writeByte(1);
                m.writer().writeUTF("X\u00e1c nh\u1eadn mu\u1ed1n n\u00e2ng c\u1ea5p v\u1eadt ph\u1ea9m l\u00ean +" + (it.levelup + 1));
                m.writer().writeInt(UpgradeItem.DATA.get((int)it.levelup).beri);
                m.writer().writeShort(UpgradeItem.DATA.get((int)it.levelup).ruby);
                m.writer().writeShort(id);
                p.conn.addmsg(m);
                m.cleanup();
            }
        } else if (type == 2) {
            Item_wear it = p.item.bag3[id];
            if (it != null) {
                boolean suc;
                if (it.levelup > 9) {
                    Service.send_box_ThongBao_OK(p, "\u0110\u00e3 n\u00e2ng c\u1ea5p t\u1ed1i \u0111a!");
                    return;
                }
                if (it.template.typeEquip > 7) {
                    Service.send_box_ThongBao_OK(p, "Trang b\u1ecb n\u00e0y kh\u00f4ng th\u1ec3 n\u00e2ng c\u1ea5p!");
                    return;
                }
                int[] material_req = UpgradeItem.get_material(it.levelup, it.template.color);
                if (material_req[0] > -1) {
                    if (p.item.total_item_bag_by_id(7, material_req[0]) < material_req[1]) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 b\u1ed9t c\u01b0\u1eddng h\u00f3a");
                        return;
                    }
                    if (p.item.total_item_bag_by_id(7, material_req[2]) < material_req[3]) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + ItemTemplate7.get_it_by_id((int)material_req[2]).name);
                        return;
                    }
                } else {
                    Service.send_box_ThongBao_OK(p, "\u0110\u00e3 c\u00f3 l\u1ed7i x\u1ea3y ra");
                    return;
                }
                if (bery_gem == 1) {
                    if (p.get_vang() < (long)UpgradeItem.DATA.get((int)it.levelup).beri) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + UpgradeItem.DATA.get((int)it.levelup).beri + " beri");
                        return;
                    }
                    p.update_vang(-UpgradeItem.DATA.get((int)it.levelup).beri);
                    p.update_money();
                } else {
                    if (p.get_ngoc() < UpgradeItem.DATA.get((int)it.levelup).ruby) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + UpgradeItem.DATA.get((int)it.levelup).ruby + " ruby");
                        return;
                    }
                    p.update_ngoc(-UpgradeItem.DATA.get((int)it.levelup).ruby);
                    p.update_money();
                }
                p.item.remove_item47(7, material_req[0], material_req[1]);
                p.item.remove_item47(7, material_req[2], material_req[3]);
                for (int i = 0; i < 2; ++i) {
                    if (p.tool_upgrade[i] == -1 || p.item.total_item_bag_by_id(7, p.tool_upgrade[i]) >= 1) continue;
                    p.tool_upgrade[i] = -1;
                }
                int percent = UpgradeItem.DATA.get((int)it.levelup).per;
                if (p.tool_upgrade[1] != -1) {
                    if (p.tool_upgrade[1] == 5) {
                        percent = percent * 15 / 10;
                    } else if (p.tool_upgrade[1] == 11) {
                        percent *= 2;
                    }
                }
                boolean bl = suc = (percent >= 1000 ? 1200 : (int)percent) > Util.random(1200);
                if (suc) {
                    it.levelup = (byte)(it.levelup + 1);
                    if (it.levelup == 10) {
                        UpgradeItem.show_table_upgrade(p);
                    }
                    UpgradeItem.notice_upgrade(p, 2, "B\u1ea1n \u0111\u00e3 c\u01b0\u1eddng h\u00f3a th\u00e0nh c\u00f4ng " + it.template.name + " l\u00ean c\u1ea5p " + it.levelup);
                } else {
                    if (p.tool_upgrade[0] == -1) {
                        it.levelup = UpgradeItem.DATA.get((int)it.levelup).prelevel;
                    }
                    UpgradeItem.notice_upgrade(p, 3, "C\u01b0\u1eddng h\u00f3a th\u1ea5t b\u1ea1i, v\u1eadt ph\u1ea9m v\u1ec1 c\u1ea5p " + it.levelup);
                }
                if (p.tool_upgrade[0] != -1) {
                    p.item.remove_item47(7, p.tool_upgrade[0], 1);
                }
                if (p.tool_upgrade[1] != -1) {
                    p.item.remove_item47(7, p.tool_upgrade[1], 1);
                }
                if (p.item.total_item_bag_by_id(7, p.tool_upgrade[0]) < 1) {
                    p.tool_upgrade[0] = -1;
                }
                if (p.item.total_item_bag_by_id(7, p.tool_upgrade[1]) < 1) {
                    p.tool_upgrade[1] = -1;
                }
                p.item.update_Inventory(-1, false);
            }
        } else if (type == 6 && (bery_gem == 1 || bery_gem == 0)) {
            if (bery_gem == 0 || p.item.total_item_bag_by_id(7, id) > 0) {
                Message m5 = new Message(-48);
                m5.writer().writeByte(6);
                m5.writer().writeByte(bery_gem);
                m5.writer().writeShort(id);
                p.conn.addmsg(m5);
                m5.cleanup();
                p.tool_upgrade[0] = bery_gem == 0 ? -1 : (int)id;
            }
        } else if (type == 5 && (bery_gem == 1 || bery_gem == 0)) {
            if (bery_gem == 0 || p.item.total_item_bag_by_id(7, id) > 0) {
                Message m5 = new Message(-48);
                m5.writer().writeByte(5);
                m5.writer().writeByte(bery_gem);
                m5.writer().writeShort(id);
                p.conn.addmsg(m5);
                m5.cleanup();
                p.tool_upgrade[1] = bery_gem == 0 ? -1 : (int)id;
            }
        } else if (type == 15 && id == -1 && bery_gem == 0 && p.item.it_heart != null && p.item.it_heart.levelup < 99) {
            int ruby_req = 0;
            if (p.item.it_heart.levelup % 5 == 4) {
                ruby_req = (p.item.it_heart.levelup / 5 + 1) * 10;
            }
            Service.send_box_yesno(p, 28, "Th\u00f4ng b\u00e1o", "\u0110\u1ec3 ti\u1ebfn h\u00e0nh ph\u1eabu thu\u1eadt tim, b\u1ea1n c\u1ea7n c\u00f3 " + Util.number_format(1200000L + (long)p.item.it_heart.levelup * 200000L) + " beri" + (String)(ruby_req > 0 ? " v\u00e0 " + ruby_req + " ruby " : "") + ". B\u1ea1n th\u1eadt s\u1ef1 mu\u1ed1n ph\u1eabu thu\u1eadt?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{-1, -1});
        }
    }

    private static int[] get_material(int level, int color) {
        int[] result = new int[]{-1, -1, -1, -1};
        DataUpgrade temp = DATA.get(level);
        for (int i = 0; i < temp.material.length; ++i) {
            if (temp.material[i].type == -1) {
                result[0] = temp.material[i].id;
                result[1] = temp.material[i].quant;
            }
            if (temp.material[i].type != color) continue;
            result[2] = temp.material[i].id;
            result[3] = temp.material[i].quant;
        }
        return result;
    }

    private static void notice_upgrade(Player p, int type, String s) throws IOException {
        Message m = new Message(-48);
        m.writer().writeByte(type);
        m.writer().writeUTF(s);
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static void show_table_upgrade_heart(Player p) throws IOException {
        UpgradeItem.send_heart_info(p, false);
        Message m = new Message(-48);
        m.writer().writeByte(15);
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static void send_heart_info(Player p, boolean b) throws IOException {
        if (p.item.it_heart != null) {
            Message m = new Message(19);
            m.writer().writeShort(p.index_map);
            m.writer().writeByte(0);
            m.writer().writeShort(p.get_head());
            m.writer().writeShort(p.get_hair());
            m.writer().writeByte(8);
            short[] fashion = p.get_fashion();
            for (int i = 0; i < 8; ++i) {
                Item_wear it_w = p.item.it_body[i];
                if (i == 7 && p.item.it_heart != null) {
                    it_w = p.item.it_heart;
                }
                if (it_w != null) {
                    m.writer().writeByte(1);
                    if (p.index_map == p.index_map) {
                        Item.readUpdateItem(m.writer(), it_w, p);
                    }
                    if (i == 1 && !p.is_show_hat) {
                        m.writer().writeShort(-1);
                        continue;
                    }
                    if (fashion != null && fashion[i] != -1) {
                        m.writer().writeShort(fashion[i]);
                        continue;
                    }
                    m.writer().writeShort(ItemTemplate3.get_it_by_id((int)it_w.template.id).part);
                    continue;
                }
                m.writer().writeByte(0);
                m.writer().writeShort(-1);
            }
            m.writer().writeShort(-1);
            m.writer().writeShort(-1);
            m.writer().writeShort(-1);
            p.conn.addmsg(m);
            m.cleanup();
        }
    }

    public static void show_eff_get_heart(Player p) throws IOException {
        Message m = new Message(-15);
        m.writer().writeByte(24);
        m.writer().writeShort(p.index_map);
        m.writer().writeByte(0);
        m.writer().writeShort(-1);
        p.conn.addmsg(m);
        m.cleanup();
    }

    static {
        try (ByteArrayInputStream bais = new ByteArrayInputStream(Util.loadfile("data/msg/login/request/msg-7_12"));
             DataInputStream dis = new DataInputStream(bais);){
            int n = dis.readByte();
            for (int i = 0; i < n; ++i) {
                DataUpgrade temp = new DataUpgrade();
                temp.level = dis.readByte();
                temp.per = dis.readShort();
                temp.prelevel = dis.readByte();
                temp.beri = dis.readInt();
                temp.beri_white = dis.readInt();
                temp.ruby = dis.readShort();
                temp.att = dis.readShort();
                int n2 = dis.readByte();
                temp.material = new UpgradeMaterialTemplate[n2];
                for (int j = 0; j < n2; ++j) {
                    temp.material[j] = new UpgradeMaterialTemplate(dis.readByte(), dis.readByte(), dis.readShort());
                }
                DATA.add(temp);
            }
        }
        catch (IOException e) {
            e.printStackTrace();
        }
    }
}

