/*
 * Decompiled with CFR 0.152.
 */
package template;

import activities.Market;
import org.json.simple.JSONArray;
import template.ItemTemplate4;
import template.ItemTemplate7;

public class PotionMarket {
    public short index;
    public short id;
    public byte category;
    public short quant;
    public long time_market;
    public int price_market;
    public String seller;
    public byte type_market;

    public void load_json(JSONArray js) {
        ItemTemplate7 itemTemplate7;
        this.index = (short)-1;
        this.id = Short.parseShort(js.get(0).toString());
        this.category = Byte.parseByte(js.get(1).toString());
        if (this.category == 4) {
            ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(this.id);
            if (itemTemplate4 != null) {
                this.quant = Short.parseShort(js.get(2).toString());
                this.time_market = System.currentTimeMillis() + Long.parseLong(js.get(3).toString());
                this.price_market = Integer.parseInt(js.get(4).toString());
                this.seller = js.get(5).toString();
                this.type_market = Byte.parseByte(js.get(6).toString());
                this.index = Market.get_index();
            }
        } else if (this.category == 7 && (itemTemplate7 = ItemTemplate7.get_it_by_id(this.id)) != null) {
            this.quant = Short.parseShort(js.get(2).toString());
            this.time_market = System.currentTimeMillis() + Long.parseLong(js.get(3).toString());
            this.price_market = Integer.parseInt(js.get(4).toString());
            this.seller = js.get(5).toString();
            this.type_market = Byte.parseByte(js.get(6).toString());
            this.index = Market.get_index();
        }
    }
}

