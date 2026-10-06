/*
 * Decompiled with CFR 0.152.
 */
package template;

import java.util.List;

public class Clan_member {
    public String name;
    public short id;
    public short level;
    public byte levelInclan;
    public short donate;
    public short gopRuby;
    public short numquest;
    public int conghien;
    public short head;
    public short hair;
    public short hat;
    public byte clazz;

    public static int get_id(List<Clan_member> members) {
        int result = 0;
        for (int i = 0; i < members.size(); ++i) {
            result = Math.max(result, members.get((int)i).id);
        }
        return ++result;
    }
}

