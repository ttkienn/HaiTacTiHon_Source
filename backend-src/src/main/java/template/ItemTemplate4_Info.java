/*
 * Decompiled with CFR 0.152.
 */
package template;

import java.util.List;

public class ItemTemplate4_Info {
    public static List<ItemTemplate4_Info> ENTRY;
    public short id;
    public String info;

    public static ItemTemplate4_Info get_by_id(short id) {
        for (int i = 0; i < ENTRY.size(); ++i) {
            if (ItemTemplate4_Info.ENTRY.get((int)i).id != id) continue;
            return ENTRY.get(i);
        }
        return null;
    }
}

