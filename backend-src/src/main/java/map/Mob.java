/*
 * Decompiled with CFR 0.152.
 */
package map;

import java.util.HashMap;
import map.Boss;
import map.Map;
import template.MobTemplate;

public class Mob {
    public static final HashMap<Integer, Mob> ENTRYS = new HashMap();
    public static final int TIME_RESPAWN = 7;
    public short x;
    public short y;
    public int hp;
    public int hp_max;
    public int level;
    public MobTemplate mob_template;
    public boolean isdie;
    public int id_target;
    public int index;
    public long time_skill;
    public long time_refresh;
    public Boss boss_info;
    public Map map;
}

