/*
 * Decompiled with CFR 0.152.
 */
package map;

import java.util.HashMap;
import java.util.List;

public class Npc {
    public static HashMap<Integer, List<Npc>> ENTRYS = new HashMap();
    public short iditem;
    public String name;
    public String namegt;
    public String chat;
    public short x;
    public short y;
    public byte isPerson;
    public byte typeIcon;
    public byte wBlock;
    public byte hBlock;
    public byte b3;
    public byte[] dataFrame;
    public short head;
    public short hair;
    public short[] wearing;
}

