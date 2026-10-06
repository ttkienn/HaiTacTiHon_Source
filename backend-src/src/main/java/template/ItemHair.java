/*
 * Decompiled with CFR 0.152.
 */
package template;

import java.io.DataInputStream;
import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class ItemHair {
    public static List<ItemHair> ENTRYS = new ArrayList<ItemHair>();
    public final byte ID;
    public final short idIcon;
    public final String name;
    public final int beri;
    public final short ruby;
    public byte type;

    public ItemHair(byte ID, short IDIcon, String name, int b, short r, int type) {
        this.ID = ID;
        this.idIcon = IDIcon;
        this.name = name;
        this.beri = b;
        this.ruby = r;
        this.type = (byte)type;
    }

    public static ItemHair readUpdateItemHair(DataInputStream dis) throws IOException {
        byte b = dis.readByte();
        String name = dis.readUTF();
        dis.readByte();
        short idicon = dis.readShort();
        dis.readShort();
        int price = dis.readInt();
        short priceRuby = dis.readShort();
        return new ItemHair(b, idicon, name, price, priceRuby, 108);
    }

    public static ItemHair get_item(int id, int type) {
        for (int i = 0; i < ENTRYS.size(); ++i) {
            ItemHair temp = ENTRYS.get(i);
            if (temp.ID != id || temp.type != type) continue;
            return temp;
        }
        return null;
    }

    public static int get_size_type(int type) {
        int size = 0;
        for (int i = 0; i < ENTRYS.size(); ++i) {
            ItemHair temp = ENTRYS.get(i);
            if (temp.type != type) continue;
            ++size;
        }
        return size;
    }

    public static ItemHair read_json_it_hair(ResultSet rs) throws SQLException {
        byte b = rs.getByte("id");
        String name = rs.getString("name");
        short idicon = rs.getShort("icon");
        int price = rs.getInt("beri");
        short priceRuby = rs.getShort("ruby");
        return new ItemHair(b, idicon, name, price, priceRuby, 103);
    }
}

