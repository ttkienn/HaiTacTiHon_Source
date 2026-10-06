/*
 * Decompiled with CFR 0.152.
 */
package template;

import java.util.ArrayList;
import java.util.List;

public class ItemTemplate7 {
    public static List<ItemTemplate7> ENTRYS = new ArrayList<ItemTemplate7>();
    public short id;
    public String name;
    public byte type;
    public byte icon;
    public int price;
    public short priceruby;
    public byte istrade;

    public static ItemTemplate7 get_it_by_id(int id) {
        for (int i = 0; i < ENTRYS.size(); ++i) {
            if (ItemTemplate7.ENTRYS.get((int)i).id != id) continue;
            return ENTRYS.get(i);
        }
        return null;
    }

    public static String get_item_name(int id) {
        String s = "";
        for (int i = 0; i < ENTRYS.size(); ++i) {
            if (ItemTemplate7.ENTRYS.get((int)i).id != id) continue;
            s = ItemTemplate7.ENTRYS.get((int)i).name;
            break;
        }
        return s;
    }

    public static ItemTemplate7 get_it_by_name(String name) {
        for (int i = 0; i < ENTRYS.size(); ++i) {
            if (!ItemTemplate7.ENTRYS.get((int)i).name.equals(name)) continue;
            return ENTRYS.get(i);
        }
        return null;
    }
}

