/*
 * Decompiled with CFR 0.152.
 */
package template;

import client.Player;
import io.Message;
import java.io.DataInputStream;
import java.io.FileInputStream;
import java.io.FilterInputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class ItemBoat {
    public static List<ItemBoat> ENTRYS = new ArrayList<ItemBoat>();
    public byte id;
    public String name;
    public byte type;
    public short idimg;
    public short icon;

    private static ItemBoat readUpdateItemBoat(DataInputStream dis) throws IOException {
        ItemBoat temp = new ItemBoat();
        temp.id = dis.readByte();
        temp.name = dis.readUTF();
        temp.type = dis.readByte();
        temp.idimg = dis.readShort();
        temp.icon = dis.readShort();
        return temp;
    }

    public static void update_part_boat_when_shopping(Player p) throws IOException {
        Message m = new Message(-62);
        m.writer().writeShort(p.index_map);
        m.writer().writeByte(0);
        m.writer().writeByte(4);
        short[] part_boat = p.get_part_boat();
        m.writer().writeShort(part_boat[0]);
        m.writer().writeShort(part_boat[1]);
        m.writer().writeShort(part_boat[2]);
        m.writer().writeShort(part_boat[3]);
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static ItemBoat get_item(int id) {
        for (int i = 0; i < ENTRYS.size(); ++i) {
            if (ItemBoat.ENTRYS.get((int)i).id != id) continue;
            return ENTRYS.get(i);
        }
        return null;
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    static {
        FileInputStream fis = null;
        FilterInputStream dis = null;
        try {
            fis = new FileInputStream("data/msg/boat");
            dis = new DataInputStream(fis);
            ((DataInputStream)dis).readByte();
            ((DataInputStream)dis).readUTF();
            ((DataInputStream)dis).readByte();
            int size = ((DataInputStream)dis).readShort();
            for (int i = 0; i < size; ++i) {
                ItemBoat itboat = ItemBoat.readUpdateItemBoat((DataInputStream)dis);
                ((DataInputStream)dis).readInt();
                ((DataInputStream)dis).readShort();
                ENTRYS.add(itboat);
            }
        }
        catch (IOException e) {
            e.printStackTrace();
        }
        finally {
            if (dis != null) {
                try {
                    dis.close();
                }
                catch (IOException e) {
                    e.printStackTrace();
                }
            }
            if (fis != null) {
                try {
                    fis.close();
                }
                catch (IOException e) {
                    e.printStackTrace();
                }
            }
        }
    }
}

