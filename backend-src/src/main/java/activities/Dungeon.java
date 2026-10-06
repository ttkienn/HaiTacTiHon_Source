/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import map.Map;
import map.Mob;

public class Dungeon {
    public List<Map> maps;
    public List<Mob> mobs;
    public long time;
    public byte mode;
    public Set<Integer> checkG;

    public void create() {
        this.time = System.currentTimeMillis() + 900000L;
        this.maps = new ArrayList<Map>();
        this.mobs = new ArrayList<Mob>();
        int index = -2;
        for (int j = 167; j < 177; ++j) {
            Map mapTemplate = Map.get_map_by_id(j)[0];
            Map map_dungeon = new Map();
            map_dungeon.template = mapTemplate.template;
            map_dungeon.zone_id = 0;
            map_dungeon.list_mob = new int[0];
            for (int i = 0; i < mapTemplate.list_mob.length; ++i) {
                Mob temp = Mob.ENTRYS.get(mapTemplate.list_mob[i]);
                Mob mob_add = new Mob();
                mob_add.mob_template = temp.mob_template;
                mob_add.x = temp.x;
                mob_add.y = temp.y;
                mob_add.hp_max = temp.mob_template.hp_max;
                mob_add.hp = 9978;
                mob_add.hp = this.mode < 7 ? (mob_add.hp += this.mode * 5000) : (mob_add.hp += this.mode * 50000);
                mob_add.hp_max = mob_add.hp;
                mob_add.level = 35 + this.mode * 10;
                if (mob_add.level > 100) {
                    mob_add.level = 100;
                }
                mob_add.isdie = false;
                mob_add.id_target = -1;
                mob_add.index = index--;
                mob_add.map = map_dungeon;
                mob_add.boss_info = null;
                this.mobs.add(mob_add);
            }
            map_dungeon.start_map();
            map_dungeon.map_dungeon = this;
            map_dungeon.map_dungeon.checkG = new HashSet<Integer>();
            map_dungeon.map_dungeon.checkG.add(167);
            Map.add_map_plus(map_dungeon);
            this.maps.add(map_dungeon);
        }
    }

    public Mob get_mob(Player p, int id) {
        for (int i = 0; i < this.mobs.size(); ++i) {
            Mob mob = this.mobs.get(i);
            if (!p.map.equals(mob.map) || mob.index != id) continue;
            return mob;
        }
        return null;
    }
}

