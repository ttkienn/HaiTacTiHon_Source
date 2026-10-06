/*
 * Decompiled with CFR 0.152.
 */
package template;

import java.io.DataOutputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import template.Option;

public class ItemTemplate3 {
    public static List<ItemTemplate3> ENTRYS = new ArrayList<ItemTemplate3>();
    public short id;
    public String name;
    public byte clazz;
    public byte typeEquip;
    public short icon;
    public short level;
    public byte color;
    public byte typelock;
    public byte numHoleDaDuc;
    public short valueChetac;
    public byte isHoanMy;
    public byte valueKichAn;
    public List<Option> option_item;
    public List<Option> option_item_2;
    public byte numLoKham;
    public short[] mdakham;
    public short part;
    public int beri;
    public int ruby;

    public static ItemTemplate3 get_it_by_id(int id) {
        for (int i = 0; i < ENTRYS.size(); ++i) {
            if (ItemTemplate3.ENTRYS.get((int)i).id != id) continue;
            return ENTRYS.get(i);
        }
        return null;
    }

    public static void readUpdateItem(DataOutputStream dos, ItemTemplate3 it) throws IOException {
        int i;
        dos.writeShort(it.id);
        dos.writeUTF(it.name);
        dos.writeByte(it.clazz);
        dos.writeByte(it.typeEquip);
        dos.writeShort(it.icon);
        dos.writeShort(it.level);
        dos.writeByte(0);
        dos.writeByte(it.color);
        dos.writeByte(0);
        dos.writeByte(it.typelock);
        dos.writeByte(it.numHoleDaDuc);
        dos.writeInt(0);
        dos.writeShort(it.valueChetac);
        dos.writeByte(it.isHoanMy);
        dos.writeByte(it.valueKichAn);
        dos.writeByte(it.option_item.size());
        for (i = 0; i < it.option_item.size(); ++i) {
            dos.writeByte(it.option_item.get((int)i).id);
            dos.writeShort(it.option_item.get(i).getParam());
        }
        dos.writeByte(it.option_item_2.size());
        for (i = 0; i < it.option_item_2.size(); ++i) {
            dos.writeByte(it.option_item_2.get((int)i).id);
            dos.writeShort(it.option_item_2.get(i).getParam());
        }
        dos.writeByte(it.numLoKham);
        dos.writeByte(it.mdakham.length);
        for (i = 0; i < it.mdakham.length; ++i) {
            dos.writeShort(it.mdakham[i]);
        }
    }

    public static ItemTemplate3 get_item_random(byte typeEquip, byte clazz, int bound1, int bound2) {
        for (int i = bound1; i < bound2; ++i) {
            if (ItemTemplate3.ENTRYS.get((int)i).typeEquip != typeEquip || ItemTemplate3.ENTRYS.get((int)i).clazz != clazz) continue;
            return ENTRYS.get(i);
        }
        return null;
    }
}

