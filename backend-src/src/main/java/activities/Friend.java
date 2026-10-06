/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import io.Message;
import java.io.DataOutputStream;
import java.io.IOException;
import java.util.ArrayList;
import map.Map;
import template.FriendTemp;

public class Friend {
    public static void process(Player p, Message m2) throws IOException {
        byte type = m2.reader().readByte();
        short id = (short)m2.reader().readInt();
        switch (type) {
            case 0: {
                Player p0 = p.map.get_player_by_id_inmap(id);
                if (p0 != null) {
                    if (p.friend_list.size() < 100) {
                        for (int i = 0; i < p.friend_list.size(); ++i) {
                            if (!p.friend_list.get((int)i).name.equals(p0.name)) continue;
                            Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng \u0111\u00e3 c\u00f3 trong danh s\u00e1ch b\u1ea1n b\u00e8");
                            return;
                        }
                    } else {
                        Service.send_box_ThongBao_OK(p, "\u0110\u1ea7y danh s\u00e1ch");
                        return;
                    }
                }
                if (p0 != null && p0.index_map != p.index_map) {
                    Message m = new Message(-29);
                    m.writer().writeByte(0);
                    m.writer().writeShort(p.index_map);
                    m.writer().writeUTF(p.name);
                    p0.conn.addmsg(m);
                    m.cleanup();
                    break;
                }
                Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng offline");
                break;
            }
            case 3: {
                Player p0 = p.map.get_player_by_id_inmap(id);
                if (p0 == null) {
                    Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng kh\u00f4ng c\u00f3 m\u1eb7t trong map");
                    return;
                }
                if (p.friend_list.size() < 100) {
                    for (int i = 0; i < p.friend_list.size(); ++i) {
                        if (!p.friend_list.get((int)i).name.equals(p0.name)) continue;
                        Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng \u0111\u00e3 c\u00f3 trong danh s\u00e1ch b\u1ea1n b\u00e8");
                        return;
                    }
                } else {
                    Service.send_box_ThongBao_OK(p, "Danh s\u00e1ch b\u1ea1n b\u00e8 \u0111\u00e3 \u0111\u1ea7y, kh\u00f4ng th\u1ec3 th\u00eam n\u1eefa");
                    return;
                }
                if (p0.index_map == p.index_map) break;
                p.friend_list.add(new FriendTemp(p0));
                p.friend_list.get((int)(p.friend_list.size() - 1)).id = p.friend_list.indexOf(p.friend_list.get(p.friend_list.size() - 1));
                p0.friend_list.add(new FriendTemp(p));
                p0.friend_list.get((int)(p0.friend_list.size() - 1)).id = p0.friend_list.indexOf(p0.friend_list.get(p0.friend_list.size() - 1));
                Message m = new Message(-29);
                m.writer().writeByte(3);
                Friend.ReadInfoMemList(m.writer(), p.friend_list.get(p.friend_list.size() - 1));
                p.conn.addmsg(m);
                m.cleanup();
                m = new Message(-29);
                m.writer().writeByte(3);
                Friend.ReadInfoMemList(m.writer(), p0.friend_list.get(p0.friend_list.size() - 1));
                p0.conn.addmsg(m);
                m.cleanup();
                Service.send_box_ThongBao_OK(p, "B\u1ea1n tr\u1edf th\u00e0nh b\u1ea1n b\u00e8 v\u1edbi " + p0.name);
                Service.send_box_ThongBao_OK(p0, "B\u1ea1n tr\u1edf th\u00e0nh b\u1ea1n b\u00e8 v\u1edbi " + p.name);
                break;
            }
            case 2: {
                if (id != 0) break;
                Friend.update_list(p);
                break;
            }
            case 1: {
                if (id >= p.friend_list.size()) break;
                p.friend_list.remove(id);
                Friend.update_list(p);
            }
        }
    }

    private static void update_list(Player p) throws IOException {
        ArrayList<FriendTemp> list_remove = new ArrayList<FriendTemp>();
        for (int i = 0; i < p.friend_list.size(); ++i) {
            Player p0 = Map.get_player_by_name_allmap(p.friend_list.get((int)i).name);
            boolean can_remove = true;
            if (p0 == null) continue;
            for (int j = 0; j < p0.friend_list.size(); ++j) {
                if (!p0.friend_list.get((int)j).name.equals(p.name)) continue;
                can_remove = false;
                break;
            }
            if (!can_remove) continue;
            list_remove.add(p.friend_list.get(i));
        }
        p.friend_list.removeAll(list_remove);
        Message m = new Message(-29);
        m.writer().writeByte(2);
        m.writer().writeByte(p.friend_list.size());
        for (int i = 0; i < p.friend_list.size(); ++i) {
            Friend.ReadInfoMemList(m.writer(), p.friend_list.get(i));
        }
        p.conn.addmsg(m);
        m.cleanup();
    }

    public static void ReadInfoMemList(DataOutputStream dos, FriendTemp temp) throws IOException {
        Player p0 = Map.get_player_by_name_allmap(temp.name);
        if (p0 != null) {
            temp.level = p0.level;
            temp.head = p0.head;
            temp.hair = p0.hair;
        }
        dos.writeInt(temp.id);
        dos.writeUTF(temp.name);
        dos.writeShort(temp.level);
        dos.writeShort(temp.head);
        dos.writeShort(temp.hair);
        dos.writeShort(temp.hat);
        dos.writeByte(p0 != null ? 1 : 0);
        String info = p0 == null ? "Offline" : p0.map.template.name + " khu " + (p0.map.zone_id + 1);
        dos.writeUTF(info);
        dos.writeShort(temp.rank);
    }
}

