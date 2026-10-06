/*
 * Decompiled with CFR 0.152.
 */
package template;

import java.util.ArrayList;
import java.util.List;

public class ItemTemplate4 {
    public static List<ItemTemplate4> ENTRYS = new ArrayList<ItemTemplate4>();
    public short icon;
    public short id;
    public String name;
    public byte type;
    public short ruby;
    public int beri;
    public byte istrade;
    public short timedelay;
    public short value;
    public short timeactive;
    public String nameuse;
    public short indexInfoPotion;

    public static ItemTemplate4 get_it_by_id(int id) {
        for (int i = 0; i < ENTRYS.size(); ++i) {
            if (ItemTemplate4.ENTRYS.get((int)i).id != id) continue;
            return ENTRYS.get(i);
        }
        return null;
    }

    public static ItemTemplate4 get_it_by_name(String name) {
        for (int i = 0; i < ENTRYS.size(); ++i) {
            if (!ItemTemplate4.ENTRYS.get((int)i).name.equals(name)) continue;
            return ENTRYS.get(i);
        }
        return null;
    }

    public static String get_item_name(int id) {
        String s = "";
        for (int i = 0; i < ENTRYS.size(); ++i) {
            if (ItemTemplate4.ENTRYS.get((int)i).id != id) continue;
            s = ItemTemplate4.ENTRYS.get((int)i).name;
            break;
        }
        return s;
    }
}

