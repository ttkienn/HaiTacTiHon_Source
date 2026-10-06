/*
 * Decompiled with CFR 0.152.
 */
package activities;

import activities.Rebuild_Item;
import client.Player;
import core.Service;
import core.Util;
import io.Message;
import java.io.IOException;
import java.util.ArrayList;
import template.ItemBag47;
import template.ItemFashion;
import template.ItemFashionP2;
import template.ItemTemplate4;
import template.ItemTemplate7;
import template.Upgrade_Skin_Info;

public class Upgrade_Skin {
    public static byte[] PERCENT = new byte[]{1, 3, 4, 5, 10, 20};

    public static void show_table(Player p) throws IOException {
        int i;
        p.upgrade_skin = new Upgrade_Skin_Info();
        p.upgrade_skin.upgrade_skin_data = new short[]{-1, -1, -1, -1, -1, -1};
        Message m = new Message(81);
        m.writer().writeByte(0);
        m.writer().writeByte(105);
        m.writer().writeByte(p.fashion.size());
        for (int i2 = 0; i2 < p.fashion.size(); ++i2) {
            ItemFashion temp = ItemFashion.get_item(p.fashion.get((int)i2).id);
            if (temp == null) continue;
            m.writer().writeShort(temp.ID);
            m.writer().writeUTF("HTTH");
            m.writer().writeUTF("M\u00e3i \u0111\u1ec9nh");
            m.writer().writeShort(temp.idIcon);
            m.writer().writeByte(p.fashion.get((int)i2).level);
        }
        ArrayList<ItemBag47> list_da_kham = new ArrayList<ItemBag47>();
        for (i = 0; i < p.item.bag47.size(); ++i) {
            ItemBag47 it47 = p.item.bag47.get(i);
            if (it47.category == 4) {
                ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(it47.id);
                if (itemTemplate4.type == 12 && itemTemplate4.id < 80 && Upgrade_Skin.check_id_ngoc(itemTemplate4.id)) {
                    list_da_kham.add(it47);
                }
            }
            if (it47.category != 7 || it47.id != 16 && it47.id != 17) continue;
            list_da_kham.add(it47);
        }
        m.writer().writeByte(list_da_kham.size());
        for (i = 0; i < list_da_kham.size(); ++i) {
            if (((ItemBag47)list_da_kham.get((int)i)).category == 4) {
                ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(((ItemBag47)list_da_kham.get((int)i)).id);
                m.writer().writeByte(4);
                m.writer().writeShort(itemTemplate4.id);
                m.writer().writeShort(((ItemBag47)list_da_kham.get((int)i)).quant);
                m.writer().writeUTF(itemTemplate4.name);
                m.writer().writeShort(itemTemplate4.icon);
                continue;
            }
            if (((ItemBag47)list_da_kham.get((int)i)).category != 7 || ((ItemBag47)list_da_kham.get((int)i)).id != 16 && ((ItemBag47)list_da_kham.get((int)i)).id != 17) continue;
            ItemTemplate7 itemTemplate7 = ItemTemplate7.get_it_by_id(((ItemBag47)list_da_kham.get((int)i)).id);
            m.writer().writeByte(7);
            m.writer().writeShort(itemTemplate7.id);
            m.writer().writeShort(((ItemBag47)list_da_kham.get((int)i)).quant);
            m.writer().writeUTF(itemTemplate7.name);
            m.writer().writeShort(itemTemplate7.icon);
        }
        p.conn.addmsg(m);
        m.cleanup();
    }

    private static boolean check_id_ngoc(short id) {
        return Rebuild_Item.get_percent_hop_ngoc(id) > 1;
    }

    public static void process(Player p, Message m2) throws IOException {
        if (m2.reader().available() == 6) {
            byte type = m2.reader().readByte();
            byte cat = m2.reader().readByte();
            short id = m2.reader().readShort();
            byte pos = m2.reader().readByte();
            byte bovao = m2.reader().readByte();
            if (type == 1 && cat == 105 && pos == 0 && bovao == 1) {
                ItemFashionP2 myFashion = p.check_fashion(id);
                if (myFashion != null && p.upgrade_skin != null) {
                    int i;
                    Message m3 = new Message(81);
                    m3.writer().writeByte(5);
                    m3.writer().writeByte(105);
                    m3.writer().writeByte(p.fashion.size());
                    for (int i2 = 0; i2 < p.fashion.size(); ++i2) {
                        ItemFashion temp = ItemFashion.get_item(p.fashion.get((int)i2).id);
                        if (temp == null) continue;
                        m3.writer().writeShort(temp.ID);
                        m3.writer().writeUTF("");
                        m3.writer().writeUTF("");
                        m3.writer().writeShort(temp.idIcon);
                        m3.writer().writeByte(p.fashion.get((int)i2).level);
                    }
                    ArrayList<ItemBag47> list_da_kham = new ArrayList<ItemBag47>();
                    for (i = 0; i < p.item.bag47.size(); ++i) {
                        ItemBag47 it47 = p.item.bag47.get(i);
                        if (it47.category == 4) {
                            ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(it47.id);
                            if (itemTemplate4.type == 12 && itemTemplate4.id < 80 && Upgrade_Skin.check_id_ngoc(itemTemplate4.id)) {
                                list_da_kham.add(it47);
                            }
                        }
                        if (it47.category != 7 || it47.id != 16 && it47.id != 17) continue;
                        list_da_kham.add(it47);
                    }
                    m3.writer().writeByte(list_da_kham.size());
                    for (i = 0; i < list_da_kham.size(); ++i) {
                        if (((ItemBag47)list_da_kham.get((int)i)).category == 4) {
                            ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(((ItemBag47)list_da_kham.get((int)i)).id);
                            m3.writer().writeByte(4);
                            m3.writer().writeShort(itemTemplate4.id);
                            m3.writer().writeShort(((ItemBag47)list_da_kham.get((int)i)).quant);
                            m3.writer().writeUTF(itemTemplate4.name);
                            m3.writer().writeShort(itemTemplate4.icon);
                            continue;
                        }
                        if (((ItemBag47)list_da_kham.get((int)i)).category != 7 || ((ItemBag47)list_da_kham.get((int)i)).id != 16 && ((ItemBag47)list_da_kham.get((int)i)).id != 17) continue;
                        ItemTemplate7 itemTemplate7 = ItemTemplate7.get_it_by_id(((ItemBag47)list_da_kham.get((int)i)).id);
                        m3.writer().writeByte(7);
                        m3.writer().writeShort(itemTemplate7.id);
                        m3.writer().writeShort(((ItemBag47)list_da_kham.get((int)i)).quant);
                        m3.writer().writeUTF(itemTemplate7.name);
                        m3.writer().writeShort(itemTemplate7.icon);
                    }
                    p.conn.addmsg(m3);
                    m3.cleanup();
                }
                if (myFashion != null && p.upgrade_skin != null) {
                    Message m = new Message(81);
                    m.writer().writeByte(1);
                    m.writer().writeByte(105);
                    m.writer().writeShort(id);
                    m.writer().writeByte(0);
                    m.writer().writeByte(0);
                    m.writer().writeByte(1);
                    m.writer().writeInt(Upgrade_Skin.get_beri_up(myFashion.level));
                    m.writer().writeShort(Upgrade_Skin.get_ruby_up(myFashion.level));
                    m.writer().writeInt(Upgrade_Skin.get_extol_up(myFashion.level));
                    p.conn.addmsg(m);
                    m.cleanup();
                    p.upgrade_skin.skin = myFashion;
                }
            } else if (type == 1 && cat == 7 && (id == 16 || id == 17) && pos == 1 && bovao == 1) {
                if (p.item.total_item_bag_by_id(7, id) > 0 && p.upgrade_skin != null && p.upgrade_skin.skin != null) {
                    int percent2 = 20;
                    Message m = new Message(81);
                    m.writer().writeByte(1);
                    m.writer().writeByte(7);
                    m.writer().writeShort(id);
                    m.writer().writeByte(percent2);
                    m.writer().writeByte(pos);
                    m.writer().writeByte(1);
                    m.writer().writeInt(Upgrade_Skin.get_beri_up(p.upgrade_skin.skin.level));
                    m.writer().writeShort(Upgrade_Skin.get_ruby_up(p.upgrade_skin.skin.level));
                    m.writer().writeInt(Upgrade_Skin.get_extol_up(p.upgrade_skin.skin.level));
                    p.conn.addmsg(m);
                    m.cleanup();
                    p.upgrade_skin.upgrade_skin_data[1] = id;
                }
            } else if (type == 1 && cat == 7 && (id == 16 || id == 17) && pos == 1 && bovao == 0) {
                if (p.upgrade_skin != null && p.upgrade_skin.skin != null) {
                    Message m = new Message(81);
                    m.writer().writeByte(1);
                    m.writer().writeByte(7);
                    m.writer().writeShort(id);
                    m.writer().writeByte(0);
                    m.writer().writeByte(pos);
                    m.writer().writeByte(0);
                    m.writer().writeInt(Upgrade_Skin.get_beri_up(p.upgrade_skin.skin.level));
                    m.writer().writeShort(Upgrade_Skin.get_ruby_up(p.upgrade_skin.skin.level));
                    m.writer().writeInt(Upgrade_Skin.get_extol_up(p.upgrade_skin.skin.level));
                    p.conn.addmsg(m);
                    m.cleanup();
                    p.upgrade_skin.upgrade_skin_data[1] = -1;
                }
            } else if (type == 1 && cat == 4 && bovao == 1) {
                if (p.item.total_item_bag_by_id(4, id) > 0 && p.upgrade_skin != null && p.upgrade_skin.skin != null && pos > 0 && pos < p.upgrade_skin.upgrade_skin_data.length && id < 80 && Upgrade_Skin.check_id_ngoc(id)) {
                    int percent = 20;
                    Message m = new Message(81);
                    m.writer().writeByte(1);
                    m.writer().writeByte(4);
                    m.writer().writeShort(id);
                    m.writer().writeByte(percent);
                    m.writer().writeByte(pos);
                    m.writer().writeByte(1);
                    m.writer().writeInt(Upgrade_Skin.get_beri_up(p.upgrade_skin.skin.level));
                    m.writer().writeShort(Upgrade_Skin.get_ruby_up(p.upgrade_skin.skin.level));
                    m.writer().writeInt(Upgrade_Skin.get_extol_up(p.upgrade_skin.skin.level));
                    p.conn.addmsg(m);
                    m.cleanup();
                    p.upgrade_skin.upgrade_skin_data[pos] = id;
                    if (p.upgrade_skin != null && p.upgrade_skin.skin != null && (p.upgrade_skin.upgrade_skin_data[1] == 16 || p.upgrade_skin.upgrade_skin_data[1] == 17) && p.item.total_item_bag_by_id(7, p.upgrade_skin.upgrade_skin_data[1]) > 0) {
                        int percent2 = 20;
                        m = new Message(81);
                        m.writer().writeByte(1);
                        m.writer().writeByte(7);
                        m.writer().writeShort(p.upgrade_skin.upgrade_skin_data[1]);
                        m.writer().writeByte(percent2);
                        m.writer().writeByte(1);
                        m.writer().writeByte(1);
                        m.writer().writeInt(Upgrade_Skin.get_beri_up(p.upgrade_skin.skin.level));
                        m.writer().writeShort(Upgrade_Skin.get_ruby_up(p.upgrade_skin.skin.level));
                        m.writer().writeInt(Upgrade_Skin.get_extol_up(p.upgrade_skin.skin.level));
                        p.conn.addmsg(m);
                        m.cleanup();
                    }
                }
            } else if (type == 1 && cat == 4 && bovao == 0 && p.upgrade_skin != null && p.upgrade_skin.skin != null && pos > 0 && pos < p.upgrade_skin.upgrade_skin_data.length) {
                Message m = new Message(81);
                m.writer().writeByte(1);
                m.writer().writeByte(4);
                m.writer().writeShort(id);
                m.writer().writeByte(0);
                m.writer().writeByte(pos);
                m.writer().writeByte(0);
                m.writer().writeInt(Upgrade_Skin.get_beri_up(p.upgrade_skin.skin.level));
                m.writer().writeShort(Upgrade_Skin.get_ruby_up(p.upgrade_skin.skin.level));
                m.writer().writeInt(Upgrade_Skin.get_extol_up(p.upgrade_skin.skin.level));
                p.conn.addmsg(m);
                m.cleanup();
                p.upgrade_skin.upgrade_skin_data[pos] = -1;
                if (p.upgrade_skin != null && p.upgrade_skin.skin != null && (p.upgrade_skin.upgrade_skin_data[1] == 16 || p.upgrade_skin.upgrade_skin_data[1] == 17) && p.item.total_item_bag_by_id(7, p.upgrade_skin.upgrade_skin_data[1]) > 0) {
                    int percent2 = 20;
                    m = new Message(81);
                    m.writer().writeByte(1);
                    m.writer().writeByte(7);
                    m.writer().writeShort(p.upgrade_skin.upgrade_skin_data[1]);
                    m.writer().writeByte(percent2);
                    m.writer().writeByte(1);
                    m.writer().writeByte(1);
                    m.writer().writeInt(Upgrade_Skin.get_beri_up(p.upgrade_skin.skin.level));
                    m.writer().writeShort(Upgrade_Skin.get_ruby_up(p.upgrade_skin.skin.level));
                    m.writer().writeInt(Upgrade_Skin.get_extol_up(p.upgrade_skin.skin.level));
                    p.conn.addmsg(m);
                    m.cleanup();
                }
            }
        } else if (m2.reader().available() == 3) {
            ItemFashionP2 myFashion;
            byte type = m2.reader().readByte();
            short id = m2.reader().readShort();
            if (type == 4 && (myFashion = p.check_fashion(id)) != null && p.upgrade_skin != null && p.upgrade_skin.skin != null && p.upgrade_skin.skin.id == myFashion.id) {
                boolean check_da_kham = false;
                for (int i = 0; i < p.upgrade_skin.upgrade_skin_data.length; ++i) {
                    if (p.upgrade_skin.upgrade_skin_data[i] == -1) continue;
                    check_da_kham = true;
                    break;
                }
                if (check_da_kham) {
                    ItemFashion itF = ItemFashion.get_item(myFashion.id);
                    Message m = new Message(81);
                    m.writer().writeByte(4);
                    m.writer().writeUTF("X\u00e1c nh\u1eadn n\u00e2ng c\u1ea5p th\u1eddi trang " + itF.name);
                    m.writer().writeShort(id);
                    p.conn.addmsg(m);
                    m.cleanup();
                } else {
                    Service.send_box_ThongBao_OK(p, "H\u00e3y b\u1ecf \u0111\u00e1 kh\u1ea3m tr\u01b0\u1edbc");
                }
            }
        } else {
            byte type = m2.reader().readByte();
            if (type == 2) {
                boolean suc;
                if (p.upgrade_skin != null && p.upgrade_skin.skin != null && p.upgrade_skin.skin.level >= 42) {
                    Service.send_box_ThongBao_OK(p, "T\u1ea1m th\u1eddi m\u1edf n\u00e2ng \u0111\u1ebfn +42 th\u00f4i");
                    return;
                }
                if (p.upgrade_skin.skin == null) {
                    return;
                }
                int beri_req = Upgrade_Skin.get_beri_up(p.upgrade_skin.skin.level);
                int ruby_req = Upgrade_Skin.get_ruby_up(p.upgrade_skin.skin.level);
                int extol_req = Upgrade_Skin.get_extol_up(p.upgrade_skin.skin.level);
                if (p.get_vang() < (long)beri_req) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + Util.number_format(beri_req) + " beri");
                    return;
                }
                if (p.get_ngoc() < ruby_req) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + Util.number_format(ruby_req) + " ruby");
                    return;
                }
                if (p.get_vnd() < extol_req) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + Util.number_format(extol_req) + " extol");
                    return;
                }
                int percent = Util.random(20, 80);
                p.update_vang(-beri_req);
                p.update_ngoc(-ruby_req);
                p.update_vnd(-extol_req);
                p.update_money();
                boolean bl = suc = (percent >= 100 ? 120 : percent) > Util.random(120);
                if (suc) {
                    p.upgrade_skin.skin.level = (byte)(p.upgrade_skin.skin.level + 1);
                } else if (p.upgrade_skin.skin.level % 3 != 0) {
                    p.upgrade_skin.skin.level = (byte)(p.upgrade_skin.skin.level - p.upgrade_skin.skin.level % 3);
                }
                Message m = new Message(81);
                m.writer().writeByte(3);
                m.writer().writeByte(suc ? 0 : 1);
                m.writer().writeShort(p.upgrade_skin.skin.id);
                m.writer().writeByte(105);
                m.writer().writeUTF(suc ? "Ch\u00fac m\u1eebng b\u1ea1n c\u01b0\u1eddng h\u00f3a th\u00e0nh c\u00f4ng l\u00ean +" + p.upgrade_skin.skin.level : "R\u1ea5t ti\u1ebfc vi\u1ec7c n\u00e2ng c\u1ea5p th\u1ea5t b\u1ea1i, th\u1eddi trang r\u1edbt v\u1ec1 +" + p.upgrade_skin.skin.level);
                p.conn.addmsg(m);
                m.cleanup();
                p.upgrade_skin.skin = null;
                p.upgrade_skin.upgrade_skin_data = new short[]{-1, -1, -1, -1, -1, -1};
                p.item.update_Inventory(-1, false);
                p.update_info_to_all();
            } else if (type == 6) {
                m2.reader().readShort();
                int size = m2.reader().readByte();
                for (int i = 0; i < size; ++i) {
                    m2.reader().readShort();
                }
                Message m = new Message(81);
                m.writer().writeByte(6);
                m.writer().writeByte(0);
                p.conn.addmsg(m);
                m.cleanup();
            }
        }
    }

    private static int get_extol_up(int level) {
        return Upgrade_Skin.get_ruby_up(level) * 1000;
    }

    private static int get_ruby_up(int level) {
        if (level == 2) {
            return 5;
        }
        int result = 0;
        if (level == 2 || level % 3 == 2) {
            for (int i = 0; i < level; ++i) {
                if (i != 2 && i % 3 != 2) continue;
                result += 5;
            }
        }
        return result;
    }

    private static int get_beri_up(int level) {
        int result = 7500;
        int moc_buff = 22500;
        for (int i = 0; i <= level; ++i) {
            if (i == 2 || i % 3 == 2) {
                result += moc_buff;
                if (moc_buff >= 30000) continue;
                moc_buff += 7500;
                continue;
            }
            result += 3750;
        }
        return result;
    }
}

