/*
 * Decompiled with CFR 0.152.
 */
package map;

import java.util.List;
import map.Boat_In_Map;
import map.Npc;
import map.Vgo;

public class MapTemplate {
    public static List<MapTemplate> ENTRYS;
    public int id;
    public String name;
    public List<Vgo> vgos;
    public List<Npc> npcs;
    public byte max_zone;
    public byte max_player;
    public byte[][] data;
    public byte IDBack;
    public int HBack;
    public List<Boat_In_Map> list_boat;
    public short maxW;
    public short maxH;
    public byte type_view_p;
    public byte b;
    public byte specMap;
    public byte id_eff_map;
    public byte level;
    public byte typeChangeMap;
    public byte[][] mPosMapTrain;
    public String strTimeChange;
}

