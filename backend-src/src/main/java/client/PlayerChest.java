/*
 * Decompiled with CFR 0.152.
 */
package client;

import client.Player;
import core.Service;
import io.Message;
import java.io.IOException;
import template.Item_wear;

public class PlayerChest {
    public static void process(Player p, Message m2) throws IOException {
        byte act = m2.reader().readByte();
        short id = m2.reader().readShort();
        byte cat = m2.reader().readByte();
        int num = m2.reader().readInt();
        if (!(act != 1 && act != 2 || cat != 4 || id != 180 && id != 181 && id != 182)) {
            return;
        }
        if (act == 1) {
            if (p.item.able_box() < 1) {
                Service.send_box_ThongBao_OK(p, "R\u01b0\u01a1ng \u0111\u00e3 \u0111\u1ea7y!");
                return;
            }
            switch (cat) {
                case 3: {
                    Item_wear it_select = p.item.bag3[id];
                    if (it_select == null) break;
                    Item_wear it_add = new Item_wear();
                    it_add.clone_obj(it_select);
                    p.item.bag3[id] = null;
                    if (p.item.add_item_box3(it_add)) break;
                    p.item.bag3[id] = it_select;
                    Service.send_box_ThongBao_OK(p, "R\u01b0\u01a1ng \u0111\u00e3 \u0111\u1ea7y!");
                    break;
                }
                case 4: 
                case 7: {
                    if (p.item.total_item_bag_by_id(cat, id) < num) break;
                    int num_in_box = p.item.total_item_box_by_id(cat, id);
                    if (num + num_in_box > 2000) {
                        num = 2000 - num_in_box;
                    }
                    if (num > 0) {
                        p.item.remove_item47(cat, id, num);
                        p.item.add_item_box47(cat, id, num);
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "R\u01b0\u01a1ng \u0111\u00e3 \u0111\u1ea7y!");
                    break;
                }
                default: {
                    return;
                }
            }
            p.item.update_Inventory(-1, false);
            p.item.update_Inventory_box(-1, false);
        } else if (act == 2) {
            if (p.item.able_bag() < 1) {
                Service.send_box_ThongBao_OK(p, "R\u01b0\u01a1ng \u0111\u00e3 \u0111\u1ea7y!");
                return;
            }
            switch (cat) {
                case 3: {
                    Item_wear it_select = p.item.box3[id];
                    if (it_select == null) break;
                    Item_wear it_add = new Item_wear();
                    it_add.clone_obj(it_select);
                    p.item.box3[id] = null;
                    if (p.item.add_item_bag3(it_add)) break;
                    p.item.box3[id] = it_select;
                    Service.send_box_ThongBao_OK(p, "R\u01b0\u01a1ng \u0111\u00e3 \u0111\u1ea7y!");
                    break;
                }
                case 4: 
                case 7: {
                    if (p.item.total_item_box_by_id(cat, id) < num) break;
                    int num_in_bag = p.item.total_item_bag_by_id(cat, id);
                    if (num + num_in_bag > 2000) {
                        num = 2000 - num_in_bag;
                    }
                    if (num > 0) {
                        p.item.remove_item47_box(cat, id, num);
                        p.item.add_item_bag47(cat, id, num);
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "R\u01b0\u01a1ng \u0111\u00e3 \u0111\u1ea7y!");
                    break;
                }
                default: {
                    return;
                }
            }
            p.item.update_Inventory(-1, false);
            p.item.update_Inventory_box(-1, false);
        } else if (act == 5) {
            Service.send_box_ThongBao_OK(p, "\u0110\u00e3 m\u1edf r\u1ed9ng t\u1ed1i \u0111a");
        }
    }
}

