/*
 * Decompiled with CFR 0.152.
 */
package client;

import client.MyPet;
import client.Player;
import core.Service;
import io.Message;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Pet {
    public static List<Pet> ENTRY = new ArrayList<Pet>();
    public short id;
    public short icon;
    public short frame;
    public String name;
    public byte type;

    public static void process(Player p, Message m2) throws IOException {
        byte act = m2.reader().readByte();
        if (act == 3) {
            Pet.show_inven(p);
        } else if (act == 4) {
            try {
                byte type = m2.reader().readByte();
                short id = m2.reader().readShort();
                if (type == 1) {
                    MyPet pet_select = null;
                    for (int i = 0; i < p.my_pet.size(); ++i) {
                        p.my_pet.get((int)i).isUse = false;
                        if (p.my_pet.get((int)i).id != id || p.my_pet.get((int)i).isUse) continue;
                        pet_select = p.my_pet.get(i);
                    }
                    if (pet_select != null && !pet_select.isUse) {
                        pet_select.isUse = true;
                        Pet.show_inven(p);
                        Service.send_box_ThongBao_OK(p, "Trang b\u1ecb " + pet_select.template.name + " th\u00e0nh c\u00f4ng");
                        p.update_info_to_all();
                    }
                } else if (type == 0) {
                    MyPet pet_select = null;
                    for (int i = 0; i < p.my_pet.size(); ++i) {
                        if (p.my_pet.get((int)i).id != id || !p.my_pet.get((int)i).isUse) continue;
                        pet_select = p.my_pet.get(i);
                        break;
                    }
                    if (pet_select != null && pet_select.isUse) {
                        pet_select.isUse = false;
                        Pet.show_inven(p);
                        Service.send_box_ThongBao_OK(p, "Th\u00e1o " + pet_select.template.name + " th\u00e0nh c\u00f4ng");
                        p.update_info_to_all();
                    }
                }
            }
            catch (IOException iOException) {
                // empty catch block
            }
        }
    }

    private static void show_inven(Player p) throws IOException {
        int i;
        Message m = new Message(-80);
        m.writer().writeByte(3);
        m.writer().writeShort(p.my_pet.size());
        for (i = 0; i < p.my_pet.size(); ++i) {
            p.my_pet.get((int)i).id = (short)i;
            m.writer().writeShort(p.my_pet.get((int)i).id);
            m.writer().writeUTF(p.my_pet.get((int)i).template.name);
            m.writer().writeUTF(p.my_pet.get((int)i).template.name);
            m.writer().writeShort(p.my_pet.get((int)i).template.icon);
            m.writer().writeByte(110);
            m.writer().writeByte(p.my_pet.get((int)i).isUse ? 1 : 0);
            m.writer().writeByte(0);
        }
        p.conn.addmsg(m);
        m.cleanup();
        for (i = 0; i < p.map.players.size(); ++i) {
            Player p0 = p.map.players.get(i);
            Service.pet(p, p0, false);
        }
    }

    public static Pet getTemplate(int id) {
        for (int i = 0; i < ENTRY.size(); ++i) {
            if (Pet.ENTRY.get((int)i).id != id) continue;
            return ENTRY.get(i);
        }
        return null;
    }
}

