/*
 * Decompiled with CFR 0.152.
 */
package template;

import client.Player;
import java.io.DataOutputStream;
import java.io.IOException;
import map.Map;

public class InfoMemList {
    public int id;
    public String name;
    public short level;
    public short head;
    public short hair;
    public short hat;
    public String info;
    public long thongthao;
    public short rank;

    public static void WriteInfoMemList(DataOutputStream dos, InfoMemList temp) throws IOException {
        Player p0 = Map.get_player_by_name_allmap(temp.name);
        if (p0 != null) {
            temp.head = p0.head;
            temp.hair = p0.hair;
            temp.hat = p0.get_hat();
        }
        dos.writeInt(temp.id);
        dos.writeUTF(temp.name);
        dos.writeShort(temp.level);
        dos.writeShort(temp.head);
        dos.writeShort(temp.hair);
        dos.writeShort(temp.hat);
        dos.writeByte(p0 != null ? 1 : 0);
        dos.writeUTF(temp.info);
        dos.writeShort(temp.rank);
    }
}

