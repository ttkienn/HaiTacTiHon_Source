/*
 * Decompiled with CFR 0.152.
 */
package client;

import client.Player;
import java.util.ArrayList;
import java.util.List;
import map.Map;
import map.Mob;

public class MapBossInfo {
    private static List<MapBossInfo> ENTRY = new ArrayList<MapBossInfo>();
    public Map map;
    public short x_new;
    public short y_new;
    public Map returnMap;
    public short returnX;
    public short returnY;
    public short rewardId;
    public long exitAt;
    public List<Mob> mob;

    public static Mob get_mob(Player p, int id) {
        for (int i = 0; i < ENTRY.size(); ++i) {
            for (int k = 0; k < MapBossInfo.ENTRY.get((int)i).mob.size(); ++k) {
                if (!MapBossInfo.ENTRY.get((int)i).mob.get((int)k).map.equals(p.map) || MapBossInfo.ENTRY.get((int)i).mob.get((int)k).index != id) continue;
                return MapBossInfo.ENTRY.get((int)i).mob.get(k);
            }
        }
        return null;
    }

    public static synchronized void add(MapBossInfo t) {
        ENTRY.add(t);
    }

    public static synchronized void remove(MapBossInfo t) {
        ENTRY.remove(t);
    }

    public static List<Mob> get_list_mob(Map map) {
        for (int i = 0; i < ENTRY.size(); ++i) {
            if (!MapBossInfo.ENTRY.get((int)i).map.equals(map)) continue;
            return MapBossInfo.ENTRY.get((int)i).mob;
        }
        return null;
    }
}
