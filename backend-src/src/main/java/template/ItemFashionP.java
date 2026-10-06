/*
 * Decompiled with CFR 0.152.
 */
package template;

import client.Player;
import io.Message;
import java.io.IOException;
import template.ItemBoat;
import template.ItemBoatP;
import template.ItemFashion;
import template.ItemFashionP2;
import template.ItemHair;
import template.Upgrade_Skin_Info;

public class ItemFashionP {
    public byte category;
    public short id;
    public short icon;
    public boolean is_use;

    public static void show_table(Player p, int type) throws IOException {
        switch (type) {
            case 103: {
                Message m = new Message(-19);
                m.writer().writeByte(103);
                m.writer().writeUTF("Ti\u1ec7m t\u00f3c");
                m.writer().writeByte(103);
                m.writer().writeShort(ItemHair.get_size_type(103));
                for (int i = 0; i < ItemHair.ENTRYS.size(); ++i) {
                    ItemHair temp = ItemHair.ENTRYS.get(i);
                    if (temp.type != 103) continue;
                    m.writer().writeByte(temp.ID);
                    m.writer().writeUTF(temp.name);
                    m.writer().writeByte(0);
                    m.writer().writeShort(temp.idIcon);
                    m.writer().writeShort(0);
                    m.writer().writeInt(0);
                    if (p.check_itfashionP(temp.ID, 103) != null) {
                        m.writer().writeShort(0);
                        continue;
                    }
                    m.writer().writeShort(500);
                }
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 102: {
                Message m = new Message(-19);
                m.writer().writeByte(102);
                m.writer().writeUTF("\u0110\u00f3ng thuy\u1ec1n");
                m.writer().writeByte(102);
                m.writer().writeShort(ItemBoat.ENTRYS.size());
                for (int i = 0; i < ItemBoat.ENTRYS.size(); ++i) {
                    m.writer().writeByte(ItemBoat.ENTRYS.get((int)i).id);
                    m.writer().writeUTF(ItemBoat.ENTRYS.get((int)i).name);
                    m.writer().writeByte(ItemBoat.ENTRYS.get((int)i).type);
                    m.writer().writeShort(ItemBoat.ENTRYS.get((int)i).idimg);
                    m.writer().writeShort(ItemBoat.ENTRYS.get((int)i).icon);
                    m.writer().writeInt(0);
                    ItemBoatP my_boat = p.check_itboat(ItemBoat.ENTRYS.get((int)i).id);
                    m.writer().writeShort(my_boat == null ? 5 : 0);
                }
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 105: {
                int ver_ = Integer.parseInt(p.conn.version.replace(".", ""));
                Message m = new Message(-19);
                m.writer().writeByte(105);
                m.writer().writeUTF("Th\u1eddi trang");
                m.writer().writeByte(105);
                m.writer().writeShort(ItemFashion.ENTRYS.size());
                for (int i = 0; i < ItemFashion.ENTRYS.size(); ++i) {
                    m.writer().writeByte(ItemFashion.ENTRYS.get((int)i).ID);
                    m.writer().writeUTF(ItemFashion.ENTRYS.get((int)i).name);
                    ItemFashionP2 myFashion = p.check_fashion(ItemFashion.ENTRYS.get((int)i).ID);
                    Object info = ItemFashion.ENTRYS.get((int)i).info;
                    if (myFashion != null && myFashion.level > 0) {
                        info = (String)info + "\n (+" + myFashion.level + ") To\u00e0n b\u1ed9 ch\u1ec9 s\u1ed1 \u0111\u01b0\u1ee3c + " + Upgrade_Skin_Info.get_op_level(myFashion.level) + "%";
                    }
                    m.writer().writeUTF((String)info);
                    m.writer().writeShort(ItemFashion.ENTRYS.get((int)i).idIcon);
                    m.writer().writeByte(ItemFashion.ENTRYS.get((int)i).mWearing.length);
                    for (int j = 0; j < ItemFashion.ENTRYS.get((int)i).mWearing.length; ++j) {
                        m.writer().writeShort(ItemFashion.ENTRYS.get((int)i).mWearing[j]);
                    }
                    if (myFashion == null && ItemFashion.ENTRYS.get((int)i).price == -1) {
                        m.writer().writeInt(-1);
                        m.writer().writeShort(0);
                    } else {
                        m.writer().writeInt(0);
                        if (myFashion != null) {
                            m.writer().writeShort(0);
                        } else {
                            m.writer().writeShort(ItemFashion.ENTRYS.get((int)i).price);
                        }
                    }
                    if (ver_ < 115) continue;
                    if (myFashion != null) {
                        m.writer().writeByte(myFashion.level);
                        continue;
                    }
                    m.writer().writeByte(0);
                }
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 108: {
                Message m = new Message(-19);
                m.writer().writeByte(112);
                m.writer().writeUTF("Th\u1ea9m m\u1ef9 vi\u1ec7n");
                m.writer().writeByte(108);
                m.writer().writeShort(ItemHair.get_size_type(108));
                for (int i = 0; i < ItemHair.ENTRYS.size(); ++i) {
                    ItemHair temp = ItemHair.ENTRYS.get(i);
                    if (temp.type != 108) continue;
                    m.writer().writeByte(temp.ID);
                    m.writer().writeUTF(temp.name);
                    m.writer().writeByte(0);
                    m.writer().writeShort(temp.idIcon);
                    m.writer().writeShort(0);
                    m.writer().writeInt(0);
                    if (p.check_itfashionP(temp.ID, 108) != null) {
                        m.writer().writeShort(0);
                        continue;
                    }
                    m.writer().writeShort(500);
                }
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
        }
    }
}

