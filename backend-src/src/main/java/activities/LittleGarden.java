/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Clan;
import client.Player;
import io.Message;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import map.Map;

public class LittleGarden {
    public static List<Clan> LIST = new ArrayList<Clan>();

    public static void send_info(Player p) throws IOException {
        if (p.map.map_little_garden != null) {
            Message m = new Message(-79);
            m.writer().writeByte(0);
            m.writer().writeByte(0);
            m.writer().writeInt(10);
            m.writer().writeInt(10);
            p.conn.addmsg(m);
            m.cleanup();
            m = new Message(-79);
            m.writer().writeByte(0);
            m.writer().writeByte(1);
            m.writer().writeInt(10);
            m.writer().writeInt(10);
            p.conn.addmsg(m);
            m.cleanup();
            LittleGarden.update_info(p);
        }
    }

    private static void update_info(Player p) throws IOException {
        if (p.map.map_little_garden != null) {
            Message m = new Message(-79);
            m.writer().writeByte(1);
            m.writer().writeByte(0);
            m.writer().writeInt(p.map.map_little_garden.hp_1);
            m.writer().writeInt(p.map.map_little_garden.mp_1);
            p.conn.addmsg(m);
            m.cleanup();
            m = new Message(-79);
            m.writer().writeByte(1);
            m.writer().writeByte(1);
            m.writer().writeInt(p.map.map_little_garden.hp_2);
            m.writer().writeInt(p.map.map_little_garden.mp_2);
            p.conn.addmsg(m);
            m.cleanup();
        }
    }

    public static void update_mp(Map map, int type, int quant) throws IOException {
        Message m;
        if (type == 4) {
            m = new Message(-79);
            m.writer().writeByte(1);
            m.writer().writeByte(0);
            m.writer().writeInt(map.map_little_garden.hp_1);
            map.map_little_garden.mp_1 += quant;
            if (quant == 0) {
                map.map_little_garden.mp_2 = 0;
            }
            m.writer().writeInt(map.map_little_garden.mp_1);
            map.send_msg_all_p(m, null, true);
            m.cleanup();
            if (map.map_little_garden.mp_1 >= 10) {
                map.map_little_garden.mp_1 = 0;
                LittleGarden.update_dame(map, type);
            }
        } else if (type == 5) {
            m = new Message(-79);
            m.writer().writeByte(1);
            m.writer().writeByte(1);
            m.writer().writeInt(map.map_little_garden.hp_2);
            map.map_little_garden.mp_2 += quant;
            if (quant == 0) {
                map.map_little_garden.mp_1 = 0;
            }
            m.writer().writeInt(map.map_little_garden.mp_2);
            map.send_msg_all_p(m, null, true);
            m.cleanup();
            if (map.map_little_garden.mp_2 >= 10) {
                LittleGarden.update_dame(map, type);
                map.map_little_garden.mp_2 = 0;
            }
        }
        if (quant == 0) {
            if (type == 5) {
                m = new Message(-79);
                m.writer().writeByte(1);
                m.writer().writeByte(0);
                m.writer().writeInt(map.map_little_garden.hp_1);
                m.writer().writeInt(map.map_little_garden.mp_1);
                map.send_msg_all_p(m, null, true);
                m.cleanup();
            } else if (type == 4) {
                m = new Message(-79);
                m.writer().writeByte(1);
                m.writer().writeByte(1);
                m.writer().writeInt(map.map_little_garden.hp_2);
                m.writer().writeInt(map.map_little_garden.mp_2);
                map.send_msg_all_p(m, null, true);
                m.cleanup();
            }
        }
    }

    public static void update_hp(Map map, int type, int quant) throws IOException {
        if (type == 4) {
            Message m = new Message(-79);
            m.writer().writeByte(1);
            m.writer().writeByte(0);
            map.map_little_garden.hp_1 += quant;
            if (map.map_little_garden.hp_1 > 20) {
                map.map_little_garden.hp_1 = 20;
            }
            m.writer().writeInt(map.map_little_garden.hp_1);
            m.writer().writeInt(map.map_little_garden.mp_1);
            map.send_msg_all_p(m, null, true);
            m.cleanup();
        } else if (type == 5) {
            Message m = new Message(-79);
            m.writer().writeByte(1);
            m.writer().writeByte(1);
            map.map_little_garden.hp_2 += quant;
            if (map.map_little_garden.hp_2 > 20) {
                map.map_little_garden.hp_2 = 20;
            }
            m.writer().writeInt(map.map_little_garden.hp_2);
            m.writer().writeInt(map.map_little_garden.mp_2);
            map.send_msg_all_p(m, null, true);
            m.cleanup();
        }
    }

    private static void update_dame(Map map, int type) throws IOException {
        Message m = null;
        if (type == 4) {
            m = new Message(-79);
            m.writer().writeByte(2);
            m.writer().writeByte(0);
            m.writer().writeInt(1);
            map.map_little_garden.hp_2 -= 2;
            map.send_msg_all_p(m, null, true);
            m.cleanup();
        } else if (type == 5) {
            m = new Message(-79);
            m.writer().writeByte(2);
            m.writer().writeByte(1);
            m.writer().writeInt(1);
            map.map_little_garden.hp_1 -= 2;
            map.send_msg_all_p(m, null, true);
            m.cleanup();
        }
        m = new Message(-79);
        m.writer().writeByte(1);
        m.writer().writeByte(0);
        m.writer().writeInt(map.map_little_garden.hp_1);
        m.writer().writeInt(map.map_little_garden.mp_1);
        map.send_msg_all_p(m, null, true);
        m.cleanup();
        m = new Message(-79);
        m.writer().writeByte(1);
        m.writer().writeByte(1);
        m.writer().writeInt(map.map_little_garden.hp_2);
        m.writer().writeInt(map.map_little_garden.mp_2);
        map.send_msg_all_p(m, null, true);
        m.cleanup();
        if (map.map_little_garden.hp_1 <= 0) {
            m = new Message(-79);
            m.writer().writeByte(3);
            m.writer().writeByte(0);
            map.send_msg_all_p(m, null, true);
            m.cleanup();
            map.map_little_garden.is_finish = true;
        } else if (map.map_little_garden.hp_2 <= 0) {
            m = new Message(-79);
            m.writer().writeByte(3);
            m.writer().writeByte(1);
            map.send_msg_all_p(m, null, true);
            m.cleanup();
            map.map_little_garden.is_finish = true;
        }
    }

    public static synchronized void add_clan_wait(Clan clan) {
        LIST.add(clan);
    }

    public static synchronized void remove_clan_wait(Clan clan) {
        LIST.remove(clan);
    }
}

