/*
 * Decompiled with CFR 0.152.
 */
package core;

import activities.Market;
import client.Clan;
import client.Player;
import core.BXH;
import map.Map;
import template.ShopTichLuy;

public class SaveData {
    public static void process() {
        long t = System.currentTimeMillis();
        for (Map[] mapall : Map.ENTRYS) {
            for (Map map : mapall) {
                for (int i = 0; i < map.players.size(); ++i) {
                    try {
                        Player p0 = map.players.get(i);
                        Player.flush(p0, false);
                        continue;
                    }
                    catch (Exception exception) {
                        // empty catch block
                    }
                }
            }
        }
        for (int i = 0; i < Map.get_map_plus().size(); ++i) {
            for (int i1 = 0; i1 < Map.get_map_plus().get((int)i).players.size(); ++i1) {
                try {
                    Player p0 = Map.get_map_plus().get((int)i).players.get(i1);
                    Player.flush(p0, false);
                    continue;
                }
                catch (Exception exception) {
                    // empty catch block
                }
            }
        }
        BXH.update();
        Market.update();
        Clan.update();
        ShopTichLuy.update();
        System.out.println("SAVE DATA OK " + (System.currentTimeMillis() - t));
    }
}

