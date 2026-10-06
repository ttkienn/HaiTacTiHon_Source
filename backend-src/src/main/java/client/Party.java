/*
 * Decompiled with CFR 0.152.
 */
package client;

import client.Player;
import core.Service;
import io.Message;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import template.Option;

public class Party {
    public List<Player> list;
    public List<Option> list_op = new ArrayList<Option>();

    public Party(Player p) {
        this.list = new ArrayList<Player>();
        this.list.add(p);
        this.add_buff_party(p.clazz);
    }

    private synchronized void add_buff_party(byte clazz) {
        Option op_select = null;
        switch (clazz) {
            case 1: {
                for (int i = 0; i < this.list_op.size(); ++i) {
                    if (this.list_op.get((int)i).id != 17) continue;
                    op_select = this.list_op.get(i);
                    break;
                }
                if (op_select != null) break;
                op_select = new Option(17, 250);
                this.list_op.add(op_select);
                break;
            }
            case 2: {
                for (int i = 0; i < this.list_op.size(); ++i) {
                    if (this.list_op.get((int)i).id != 1) continue;
                    op_select = this.list_op.get(i);
                    break;
                }
                if (op_select != null) break;
                op_select = new Option(1, 150);
                this.list_op.add(op_select);
                break;
            }
            case 3: {
                for (int i = 0; i < this.list_op.size(); ++i) {
                    if (this.list_op.get((int)i).id != 4) continue;
                    op_select = this.list_op.get(i);
                    break;
                }
                if (op_select != null) break;
                op_select = new Option(4, 250);
                this.list_op.add(op_select);
                break;
            }
            case 4: {
                for (int i = 0; i < this.list_op.size(); ++i) {
                    if (this.list_op.get((int)i).id != 23) continue;
                    op_select = this.list_op.get(i);
                    break;
                }
                if (op_select != null) break;
                op_select = new Option(23, 250);
                this.list_op.add(op_select);
                break;
            }
            case 5: {
                for (int i = 0; i < this.list_op.size(); ++i) {
                    if (this.list_op.get((int)i).id != 25) continue;
                    op_select = this.list_op.get(i);
                    break;
                }
                if (op_select != null) break;
                op_select = new Option(25, 100);
                this.list_op.add(op_select);
            }
        }
    }

    public static void process(Player p, Message m2) throws IOException {
        byte type = m2.reader().readByte();
        int id = -1;
        if (type == 0 || type == 2 || type == 4 || type == 6) {
            id = m2.reader().readShort();
        }
        switch (type) {
            case 0: {
                Player p0 = p.map.get_player_by_id_inmap(id);
                if (p0 != null) {
                    if (p0.party != null) {
                        Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng \u0111ang \u1edf trong nh\u00f3m kh\u00e1c!");
                        break;
                    }
                    Message m = new Message(-25);
                    m.writer().writeByte(0);
                    m.writer().writeShort(p.index_map);
                    m.writer().writeUTF(p.name);
                    p0.conn.addmsg(m);
                    m.cleanup();
                    if (p.party != null) break;
                    p.party = new Party(p);
                    p.party.send_info();
                    break;
                }
                Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng offline");
                break;
            }
            case 4: {
                Player p0 = p.map.get_player_by_id_inmap(id);
                if (p0 != null) {
                    if (p0.party != null) {
                        p0.party.add_new_mem(p);
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng \u0111\u00e3 h\u1ee7y nh\u00f3m");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng offline");
                break;
            }
            case 3: {
                if (p.party == null || !p.party.list.get(0).equals(p)) break;
                p.party.delete();
                break;
            }
            case 2: {
                Player p0;
                if (p.party == null || (p0 = p.map.get_player_by_id_inmap(id)) == null) break;
                p.party.remove_mem(p0);
                if (p0.index_map == p.index_map) {
                    Service.send_box_ThongBao_OK(p0, "B\u1ea1n r\u1eddi kh\u1ecfi nh\u00f3m");
                    break;
                }
                Service.send_box_ThongBao_OK(p0, "B\u1ea1n b\u1ecb \u0111u\u1ed5i kh\u1ecfi nh\u00f3m");
            }
        }
    }

    public synchronized void remove_mem(Player p) throws IOException {
        for (int i = 0; i < this.list.size(); ++i) {
            Player p0 = this.list.get(i);
            if (!p0.equals(p)) continue;
            Message m = new Message(-25);
            m.writer().writeByte(3);
            p0.conn.addmsg(m);
            m.cleanup();
            p0.party = null;
            this.list.remove(p);
            this.send_info();
            break;
        }
    }

    private synchronized void delete() throws IOException {
        Message m = new Message(-25);
        m.writer().writeByte(3);
        for (int i = 0; i < this.list.size(); ++i) {
            Player p0 = this.list.get(i);
            p0.party = null;
            if (p0.conn == null) continue;
            p0.conn.addmsg(m);
            Service.send_box_ThongBao_OK(p0, "Nh\u00f3m \u0111\u00e3 gi\u1ea3i t\u00e1n");
        }
        m.cleanup();
        this.list.clear();
    }

    private synchronized void add_new_mem(Player p) throws IOException {
        if (this.list.size() < 4) {
            this.list.add(p);
            p.party = this;
            this.add_buff_party(p.clazz);
            this.send_info();
            Service.send_box_ThongBao_OK(p, "V\u00e0o nh\u00f3m th\u00e0nh c\u00f4ng!");
        } else {
            Service.send_box_ThongBao_OK(this.list.get(0), "Nh\u00f3m \u0111\u1ea7y!");
        }
    }

    public synchronized boolean try_add_bot_mem(Player p) throws IOException {
        if (p == null || p.party != null || this.list.size() >= 4) {
            return false;
        }
        for (int i = 0; i < this.list.size(); ++i) {
            if (!this.list.get((int)i).name.equals(p.name)) continue;
            return false;
        }
        this.add_new_mem(p);
        return true;
    }

    public void send_info() throws IOException {
        Player p0;
        int i;
        for (int i2 = 0; i2 < this.list.size(); ++i2) {
            Player p02 = this.list.get(i2);
            if (p02.conn != null) continue;
            this.list.remove(p02);
            --i2;
        }
        Message m = new Message(-25);
        m.writer().writeByte(5);
        m.writer().writeByte(this.list.size());
        for (i = 0; i < this.list.size(); ++i) {
            p0 = this.list.get(i);
            m.writer().writeShort(p0.index_map);
            m.writer().writeUTF(p0.name);
            m.writer().writeShort(p0.map.template.id);
            m.writer().writeByte(i == 0 ? 1 : 0);
            m.writer().writeByte(p0.map.zone_id);
        }
        for (i = 0; i < this.list.size(); ++i) {
            p0 = this.list.get(i);
            p0.conn.addmsg(m);
        }
        m.cleanup();
        for (i = 0; i < this.list.size(); ++i) {
            p0 = this.list.get(i);
            List<Option> op_select = this.get_list_buff_now(p0);
            m = new Message(32);
            if (op_select.size() > 0) {
                m.writer().writeByte(op_select.size());
                for (int i4 = 0; i4 < op_select.size(); ++i4) {
                    m.writer().writeByte(op_select.get((int)i4).id);
                    m.writer().writeShort(op_select.get(i4).getParam());
                }
            } else {
                m.writer().writeByte(1);
                m.writer().writeByte(1);
                m.writer().writeShort(0);
            }
            p0.conn.addmsg(m);
            m.cleanup();
            p0.update_info_to_all();
        }
    }

    public synchronized List<Option> get_list_buff_now(Player p0) {
        int num_P = 0;
        ArrayList<Option> result = new ArrayList<Option>();
        for (int i2 = 0; i2 < this.list.size(); ++i2) {
            Player p0_2 = this.list.get(i2);
            Option op_select = null;
            if (p0.map.equals(p0_2.map)) {
                block0 : switch (p0_2.clazz) {
                    case 1: {
                        for (int i3 = 0; i3 < this.list_op.size(); ++i3) {
                            if (this.list_op.get((int)i3).id != 17) continue;
                            op_select = this.list_op.get(i3);
                            break block0;
                        }
                        break;
                    }
                    case 2: {
                        for (int i3 = 0; i3 < this.list_op.size(); ++i3) {
                            if (this.list_op.get((int)i3).id != 1) continue;
                            op_select = this.list_op.get(i3);
                            break block0;
                        }
                        break;
                    }
                    case 3: {
                        for (int i3 = 0; i3 < this.list_op.size(); ++i3) {
                            if (this.list_op.get((int)i3).id != 4) continue;
                            op_select = this.list_op.get(i3);
                            break block0;
                        }
                        break;
                    }
                    case 4: {
                        for (int i3 = 0; i3 < this.list_op.size(); ++i3) {
                            if (this.list_op.get((int)i3).id != 23) continue;
                            op_select = this.list_op.get(i3);
                            break block0;
                        }
                        break;
                    }
                    case 5: {
                        for (int i3 = 0; i3 < this.list_op.size(); ++i3) {
                            if (this.list_op.get((int)i3).id != 25) continue;
                            op_select = this.list_op.get(i3);
                            break block0;
                        }
                        break;
                    }
                }
                ++num_P;
            }
            if (op_select == null) continue;
            Option op_can_add = null;
            for (int i = 0; i < result.size(); ++i) {
                if (op_select.id != ((Option)result.get((int)i)).id) continue;
                op_can_add = (Option)result.get(i);
                break;
            }
            if (op_can_add != null) continue;
            result.add(op_select);
        }
        if (num_P < 2 && result.size() < 2) {
            result.clear();
        }
        return result;
    }
}

