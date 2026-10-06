/*
 * Decompiled with CFR 0.152.
 */
package template;

import client.Player;
import java.util.ArrayList;
import java.util.Collection;
import java.util.HashMap;
import java.util.List;
import template.ItemTemplate3;

public class ItemSell {
    public int id;
    public int price;
    public static HashMap<Integer, List<List<ItemSell>>> ENTRYS = new HashMap();
    public static short[] ITEM_POTION_SELL = new short[]{2, 3, 85, 5, 4, 15, 16, 29, 43, 40, 89, 80, 31, 6, 232, 361, 548, 173, 174};
    public static byte[] ITEM_MATERIAL_SELL = new byte[]{1, 2, 3, 4, 5, 6, 9};

    public ItemSell(int id, int price) {
        this.id = id;
        this.price = price;
    }

    public static List<ItemSell> get_it_sell(int level, int clazz) {
        ArrayList<ItemSell> result = new ArrayList<ItemSell>();
        if ((level /= 10) < 2) {
            result.addAll((Collection)ENTRYS.get(0).get(clazz));
            result.addAll((Collection)ENTRYS.get(1).get(clazz));
            result.addAll((Collection)ENTRYS.get(2).get(clazz));
        } else if (level > 7) {
            result.addAll((Collection)ENTRYS.get(7).get(clazz));
            result.addAll((Collection)ENTRYS.get(8).get(clazz));
            result.addAll((Collection)ENTRYS.get(9).get(clazz));
        } else {
            result.addAll((Collection)ENTRYS.get(level - 1).get(clazz));
            result.addAll((Collection)ENTRYS.get(level).get(clazz));
            result.addAll((Collection<ItemSell>)ENTRYS.get(level + 1).get(clazz));
        }
        return result;
    }

    public static boolean check_item_sell_potion(short id) {
        int i;
        for (i = 0; i < ITEM_POTION_SELL.length; ++i) {
            if (ITEM_POTION_SELL[i] != id) continue;
            return true;
        }
        for (i = 7; i <= 28; ++i) {
            if (i != id) continue;
            return true;
        }
        return false;
    }

    public static short[] get_it_sell_potion(Player p) {
        short[] result = new short[ITEM_POTION_SELL.length];
        for (int i = 0; i < result.length; ++i) {
            result[i] = ITEM_POTION_SELL[i];
        }
        result[5] = (short)(7 + p.level / 10);
        result[6] = (short)(18 + p.level / 10);
        return result;
    }

    public static byte[] get_it_sell_material() {
        return ITEM_MATERIAL_SELL;
    }

    public static boolean check_item_sell_material(short id) {
        for (int i = 0; i < ITEM_MATERIAL_SELL.length; ++i) {
            if (ITEM_MATERIAL_SELL[i] != id) continue;
            return true;
        }
        return false;
    }

    static {
        for (int i = 0; i < ItemTemplate3.ENTRYS.size(); ++i) {
            ItemTemplate3 it_temp = ItemTemplate3.ENTRYS.get(i);
            if (it_temp.beri <= 0) continue;
            ItemSell temp = new ItemSell(it_temp.id, it_temp.beri);
            List<List<ItemSell>> list_temp = ENTRYS.get(it_temp.level / 10);
            if (list_temp == null) {
                list_temp = new ArrayList<List<ItemSell>>();
                for (int j = 0; j < 5; ++j) {
                    list_temp.add(new ArrayList());
                }
                ENTRYS.put(it_temp.level / 10, list_temp);
            }
            List<ItemSell> temp1 = list_temp.get(it_temp.clazz - 1);
            temp1.add(temp);
        }
    }
}

