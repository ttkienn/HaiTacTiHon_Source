/*
 * Decompiled with CFR 0.152.
 */
package template;

import client.Player;
import java.util.ArrayList;
import java.util.List;
import map.Map;

public class Ship_pet {
    private static List<Ship_pet> LIST = new ArrayList<Ship_pet>();
    public short index_map;
    public short x;
    public short y;
    public String name;
    public int hp_max;
    public int hp;
    public long time;
    public Player main_ship;
    public Map map;
    public long time_buff_hp;
    public long time_start;
    public String mainBaoVe = "";
    public int id_map_save;

    public static synchronized void add(Ship_pet t) {
        LIST.add(t);
    }

    public static synchronized void remv(Ship_pet t) {
        LIST.remove(t);
    }

    public static synchronized Ship_pet get_pet(int id) {
        for (int i = 0; i < LIST.size(); ++i) {
            if (Ship_pet.LIST.get((int)i).index_map != id) continue;
            return LIST.get(i);
        }
        return null;
    }

    public static synchronized Ship_pet get_pet(Player p) {
        Ship_pet result = null;
        for (int i = 0; i < LIST.size(); ++i) {
            if (Ship_pet.LIST.get((int)i).main_ship == null || !Ship_pet.LIST.get((int)i).main_ship.name.equals(p.name)) continue;
            result = LIST.get(i);
            p.typePirate = result.main_ship.typePirate;
            p.id_ship_packet = result.main_ship.id_ship_packet;
            result.main_ship = p;
            break;
        }
        return result;
    }
}

