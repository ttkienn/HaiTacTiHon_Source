/*
 * Decompiled with CFR 0.152.
 */
package template;

import client.Player;
import org.json.simple.JSONArray;

public class FriendTemp {
    public int id;
    public String name;
    public short head;
    public short hair;
    public short hat;
    public short level;
    public String info;
    public short rank;

    public FriendTemp(Player p0) {
        this.name = p0.name;
        this.level = p0.level;
        this.head = p0.head;
        this.hair = p0.hair;
        this.hat = (short)-1;
        this.info = "";
        this.rank = 0;
    }

    public FriendTemp(JSONArray js) {
        this.id = Integer.parseInt(js.get(0).toString());
        this.name = js.get(1).toString();
        this.level = Short.parseShort(js.get(2).toString());
        this.head = Short.parseShort(js.get(3).toString());
        this.hair = Short.parseShort(js.get(4).toString());
        this.hat = Short.parseShort(js.get(5).toString());
        this.info = js.get(6).toString();
        this.rank = Short.parseShort(js.get(7).toString());
    }

    public JSONArray toJSONArray() {
        JSONArray js = new JSONArray();
        js.add(this.id);
        js.add(this.name);
        js.add(this.level);
        js.add(this.head);
        js.add(this.hair);
        js.add(this.hat);
        js.add(this.info);
        js.add(this.rank);
        return js;
    }
}

