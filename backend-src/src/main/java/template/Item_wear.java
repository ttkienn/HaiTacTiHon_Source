/*
 * Decompiled with CFR 0.152.
 */
package template;

import core.Util;
import java.util.ArrayList;
import java.util.List;
import template.ItemMarket;
import template.ItemTemplate3;
import template.Option;

public class Item_wear {
    public ItemTemplate3 template;
    public byte levelup;
    public byte typelock;
    public byte numHoleDaDuc;
    public int timeUse;
    public short valueChetac;
    public byte isHoanMy;
    public byte valueKichAn;
    public List<Option> option_item;
    public List<Option> option_item_2;
    public byte numLoKham;
    public short[] mdakham;
    public byte index;

    public void setup_template_by_id(ItemTemplate3 it_temp) {
        if (it_temp != null) {
            int i;
            this.template = it_temp;
            this.levelup = 0;
            this.typelock = it_temp.typelock;
            this.numHoleDaDuc = it_temp.numHoleDaDuc;
            this.timeUse = 0;
            this.valueChetac = (short)Util.random(50, 100);
            this.isHoanMy = it_temp.isHoanMy;
            this.valueKichAn = it_temp.valueKichAn;
            this.option_item = new ArrayList<Option>();
            for (i = 0; i < it_temp.option_item.size(); ++i) {
                int param_random = it_temp.option_item.get(i).getParam();
                if (param_random > 5 && param_random <= 10) {
                    if ((param_random -= Util.random(5)) < 5) {
                        param_random = 5;
                    }
                } else if (param_random > 10) {
                    param_random = param_random * Util.random(90, 101) / 100;
                }
                this.option_item.add(new Option(it_temp.option_item.get((int)i).id, param_random));
            }
            this.option_item_2 = new ArrayList<Option>();
            this.numLoKham = it_temp.numLoKham;
            this.mdakham = new short[it_temp.mdakham.length];
            for (i = 0; i < it_temp.mdakham.length; ++i) {
                this.mdakham[i] = it_temp.mdakham[i];
            }
            this.index = 0;
        }
    }

    public void setup_template_by_id(int id) {
        ItemTemplate3 it_temp = ItemTemplate3.get_it_by_id(id);
        if (it_temp != null) {
            int i;
            this.template = it_temp;
            this.levelup = 0;
            this.typelock = it_temp.typelock;
            this.numHoleDaDuc = it_temp.numHoleDaDuc;
            this.timeUse = 0;
            this.valueChetac = (short)Util.random(50, 100);
            this.isHoanMy = it_temp.isHoanMy;
            this.valueKichAn = it_temp.valueKichAn;
            this.option_item = new ArrayList<Option>();
            for (i = 0; i < it_temp.option_item.size(); ++i) {
                int param_random = it_temp.option_item.get(i).getParam();
                if (param_random > 5 && param_random <= 10) {
                    if ((param_random -= Util.random(5)) < 5) {
                        param_random = 5;
                    }
                } else if (param_random > 10) {
                    param_random = param_random * Util.random(90, 101) / 100;
                }
                this.option_item.add(new Option(it_temp.option_item.get((int)i).id, param_random));
            }
            this.option_item_2 = new ArrayList<Option>();
            this.numLoKham = it_temp.numLoKham;
            this.mdakham = new short[it_temp.mdakham.length];
            for (i = 0; i < it_temp.mdakham.length; ++i) {
                this.mdakham[i] = it_temp.mdakham[i];
            }
            this.index = 0;
        }
    }

    public void clone_obj(Item_wear it_temp) {
        if (it_temp != null) {
            int i;
            this.template = it_temp.template;
            this.levelup = it_temp.levelup;
            this.typelock = it_temp.typelock;
            this.numHoleDaDuc = it_temp.numHoleDaDuc;
            this.timeUse = it_temp.timeUse;
            this.valueChetac = it_temp.valueChetac;
            this.isHoanMy = it_temp.isHoanMy;
            this.valueKichAn = it_temp.valueKichAn;
            this.option_item = new ArrayList<Option>();
            for (i = 0; i < it_temp.option_item.size(); ++i) {
                this.option_item.add(new Option(it_temp.option_item.get((int)i).id, it_temp.option_item.get(i).getParam()));
            }
            this.option_item_2 = new ArrayList<Option>();
            for (i = 0; i < it_temp.option_item_2.size(); ++i) {
                this.option_item_2.add(new Option(it_temp.option_item_2.get((int)i).id, it_temp.option_item_2.get(i).getParam()));
            }
            this.numLoKham = it_temp.numLoKham;
            this.mdakham = new short[it_temp.mdakham.length];
            for (i = 0; i < it_temp.mdakham.length; ++i) {
                this.mdakham[i] = it_temp.mdakham[i];
            }
            this.index = it_temp.index;
        }
    }

    public void clone_obj(ItemMarket it) {
        int i;
        this.template = it.template;
        this.levelup = it.levelup;
        this.typelock = it.typelock;
        this.numHoleDaDuc = it.numHoleDaDuc;
        this.timeUse = it.timeUse;
        this.valueChetac = it.valueChetac;
        this.isHoanMy = it.isHoanMy;
        this.valueKichAn = it.valueKichAn;
        this.option_item = new ArrayList<Option>();
        for (i = 0; i < it.option_item.size(); ++i) {
            this.option_item.add(new Option(it.option_item.get((int)i).id, it.option_item.get(i).getParam()));
        }
        this.option_item_2 = new ArrayList<Option>();
        for (i = 0; i < it.option_item_2.size(); ++i) {
            this.option_item_2.add(new Option(it.option_item_2.get((int)i).id, it.option_item_2.get(i).getParam()));
        }
        this.numLoKham = it.numLoKham;
        this.mdakham = new short[it.mdakham.length];
        for (i = 0; i < it.mdakham.length; ++i) {
            this.mdakham[i] = it.mdakham[i];
        }
        this.index = 0;
    }
}

