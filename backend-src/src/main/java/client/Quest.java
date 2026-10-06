/*
 * Decompiled with CFR 0.152.
 */
package client;

import client.Player;
import core.Service;
import core.Util;
import io.Message;
import java.io.DataOutputStream;
import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import org.json.simple.JSONArray;
import org.json.simple.JSONValue;
import template.GiftBox;
import template.ItemBag47;
import template.ItemTemplate4;
import template.ItemTemplate7;
import template.QuestP;

public class Quest {
    private static List<Quest> ENTRY = new ArrayList<Quest>();
    public static Quest QUEST_FINISH;
    public short id;
    public short index;
    public byte statusQuest;
    public byte typeMainSub;
    public byte typeActionQuest;
    public String name;
    public short idNpc;
    public String talk;
    public byte typeQ;
    public String strNpcMap;
    public short lvRequest;
    public String strNhacNho;
    public String showDialog;
    public short[][] data_quest;
    public short idMapHelp;
    public short idNpcSub;
    public List<GiftBox> gift;
    public String infoFinish;

    public static void add(ResultSet rs) throws SQLException {
        JSONArray js2;
        int i;
        Quest t = new Quest();
        t.index = rs.getShort("index_server");
        t.statusQuest = rs.getByte("statusQuest");
        t.typeMainSub = rs.getByte("typeMainSub");
        t.typeActionQuest = rs.getByte("typeActionQuest");
        t.name = rs.getString("name");
        t.idNpc = rs.getShort("idNpc");
        t.talk = rs.getString("talk");
        t.typeQ = rs.getByte("typeQ");
        t.strNpcMap = rs.getString("strNpcMap");
        t.lvRequest = rs.getShort("lvRequest");
        t.strNhacNho = rs.getString("strNhacNho");
        t.showDialog = rs.getString("showDialog");
        JSONArray js = (JSONArray)JSONValue.parse(rs.getString("data_quest"));
        t.data_quest = new short[js.size()][];
        for (i = 0; i < t.data_quest.length; ++i) {
            js2 = (JSONArray)js.get(i);
            t.data_quest[i] = new short[js2.size()];
            for (int j = 0; j < t.data_quest[i].length; ++j) {
                t.data_quest[i][j] = Short.parseShort(js2.get(j).toString());
            }
        }
        js.clear();
        t.idMapHelp = rs.getShort("idMapHelp");
        t.idNpcSub = rs.getShort("idNpcSub");
        t.id = rs.getShort("id");
        t.gift = new ArrayList<GiftBox>();
        js = (JSONArray)JSONValue.parse(rs.getString("gift"));
        for (i = 0; i < js.size(); ++i) {
            js2 = (JSONArray)js.get(i);
            GiftBox temp = new GiftBox();
            temp.type = Byte.parseByte(js2.get(0).toString());
            temp.name = js2.get(1).toString();
            temp.icon = Short.parseShort(js2.get(2).toString());
            temp.num = Integer.parseInt(js2.get(3).toString());
            temp.color = Byte.parseByte(js2.get(4).toString());
            if (temp.type == 4) {
                if (temp.name.equals("XP Clan")) {
                    temp.id = (short)-10;
                } else if (temp.name.equals("Bery Clan")) {
                    temp.id = (short)-11;
                } else if (temp.name.equals("Ruby Clan")) {
                    temp.id = (short)-12;
                } else {
                    ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_name(temp.name);
                    if (itemTemplate4 != null && itemTemplate4.icon == temp.icon) {
                        temp.id = itemTemplate4.id;
                    } else {
                        System.out.println("load gift quest err " + temp.name + " id " + t.id);
                        System.exit(0);
                    }
                }
            } else if (temp.type == 7) {
                ItemTemplate7 itemTemplate7 = ItemTemplate7.get_it_by_name(temp.name);
                if (itemTemplate7 != null && itemTemplate7.icon == temp.icon) {
                    temp.id = itemTemplate7.id;
                } else {
                    System.out.println("load gift quest err " + temp.name + " id " + t.id);
                    System.exit(0);
                }
            } else if (temp.type == 99) {
                temp.id = (short)-1;
            } else {
                System.out.println("load gift quest err " + temp.name + " id " + t.id);
                System.exit(0);
            }
            t.gift.add(temp);
        }
        t.infoFinish = rs.getString("infoFinish");
        ENTRY.add(t);
    }

    public static Quest get_quest(int id_quest) {
        for (int i = 0; i < ENTRY.size(); ++i) {
            if (Quest.ENTRY.get((int)i).id != id_quest) continue;
            return ENTRY.get(i);
        }
        return QUEST_FINISH;
    }

    public static void write_Quest(DataOutputStream dos, QuestP q) throws IOException {
        switch (q.template.statusQuest) {
            case 0: {
                dos.writeShort(q.template.index);
                dos.writeByte(q.template.typeMainSub);
                dos.writeByte(q.template.typeActionQuest);
                dos.writeUTF(q.template.name);
                dos.writeShort(q.template.idNpc);
                dos.writeUTF(q.template.talk);
                dos.writeByte(q.template.typeQ);
                dos.writeUTF(q.template.showDialog);
                dos.writeUTF(q.template.strNpcMap);
                dos.writeShort(q.template.lvRequest);
                break;
            }
            case 1: {
                dos.writeShort(q.template.index);
                dos.writeByte(q.template.typeMainSub);
                dos.writeByte(q.template.typeActionQuest);
                dos.writeUTF(q.template.name);
                dos.writeShort(q.template.idNpc);
                dos.writeUTF(q.template.strNhacNho);
                dos.writeUTF(q.template.showDialog);
                dos.writeByte(q.template.data_quest.length);
                for (int i = 0; i < q.data.length; ++i) {
                    dos.writeByte(q.data[i][0]);
                    if (q.data[i][0] != 1 && q.data[i][0] != 2) continue;
                    dos.writeShort(q.data[i][1]);
                    dos.writeShort(q.data[i][2]);
                    dos.writeShort(q.data[i][3]);
                }
                dos.writeUTF(q.template.strNpcMap);
                dos.writeShort(q.template.idMapHelp);
                break;
            }
            case 2: {
                dos.writeShort(q.template.index);
                dos.writeByte(q.template.typeMainSub);
                dos.writeByte(q.template.typeActionQuest);
                dos.writeUTF(q.template.name);
                dos.writeShort(q.template.idNpc);
                dos.writeShort(q.template.idNpcSub);
                dos.writeUTF(q.template.talk);
                dos.writeByte(q.template.typeQ);
                dos.writeUTF(q.template.showDialog);
                dos.writeUTF(q.template.strNpcMap);
                dos.writeUTF(q.template.strNhacNho);
            }
        }
    }

    public static void process(Player p, Message m2) throws IOException {
        byte act = m2.reader().readByte();
        short id = m2.reader().readShort();
        QuestP temp = p.get_quest(id);
        switch (act) {
            case 1: {
                if (temp != null && temp.template.equals(QUEST_FINISH)) {
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 ho\u00e0n th\u00e0nh h\u1ebft nhi\u1ec7m v\u1ee5 hi\u1ec7n t\u1ea1i");
                    return;
                }
                if (temp == null || temp.template.statusQuest != 0) break;
                if (temp.template.id < 0) {
                    if (p.list_quest.get((int)0).template.id < 11) {
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n ph\u1ea3i ho\u00e0n th\u00e0nh nhi\u1ec7m v\u1ee5 B\u00e0i t\u1eadp \u0111\u1ea7u ti\u00ean m\u1edbi c\u00f3 th\u1ec3 nh\u1eadn nhi\u1ec7m v\u1ee5 l\u1eb7p");
                        break;
                    }
                    p.data_yesno = new int[]{id};
                    Service.send_box_yesno(p, 15, "Th\u00f4ng b\u00e1o", "Nh\u1eadn nhi\u1ec7m v\u1ee5 l\u1eb7p m\u1ea5t 3 b\u00e1nh m\u00ec, b\u1ea1n c\u00f3 mu\u1ed1n nh\u1eadn kh\u00f4ng?", new String[]{"3", "H\u1ee7y"}, new byte[]{8, -1});
                    break;
                }
                Quest.remove_old_and_send_next(p, temp);
                Message m = new Message(-23);
                m.writer().writeByte(5);
                m.writer().writeShort(temp.template.index);
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 4: {
                if (temp != null && temp.template.equals(QUEST_FINISH)) {
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 ho\u00e0n th\u00e0nh h\u1ebft nhi\u1ec7m v\u1ee5 hi\u1ec7n t\u1ea1i");
                    return;
                }
                if (temp == null || temp.template.statusQuest != 2) break;
                Quest.remove_old_and_send_next(p, temp);
                ArrayList<ItemBag47> list_remove = new ArrayList<ItemBag47>();
                for (int i = 0; i < p.item.bag47.size(); ++i) {
                    if (p.item.bag47.get((int)i).category != 5) continue;
                    list_remove.add(p.item.bag47.get(i));
                }
                p.item.bag47.removeAll(list_remove);
                p.item.update_Inventory(-1, false);
                break;
            }
        }
    }

    public static void remove_old_and_send_next(Player p, QuestP temp) throws IOException {
        Message m = new Message(-23);
        m.writer().writeByte(2);
        m.writer().writeShort(temp.template.index);
        p.conn.addmsg(m);
        m.cleanup();
        if (temp.template.id < 0 && temp.template.statusQuest == 2) {
            Quest.remove_side_quest(p, temp);
        } else {
            Quest.next_quest(p, temp);
            m = new Message(-23);
            m.writer().writeByte(1);
            m.writer().writeByte(temp.template.statusQuest);
            Quest.write_Quest(m.writer(), temp);
            p.conn.addmsg(m);
            m.cleanup();
        }
        if (p.pointPk > 0) {
            p.update_point_pk(-25);
        }
    }

    private static void remove_side_quest(Player p, QuestP questP) throws IOException {
        if (questP.template.gift.size() > 0) {
            Quest.send_gift(p, questP);
        }
        p.list_quest.remove(questP);
        Quest.update_map_have_side_quest(p, false);
    }

    public static void next_quest(Player p, QuestP questP) throws IOException {
        if (questP.template.gift.size() > 0) {
            Quest.send_gift(p, questP);
        }
        questP.template = Quest.get_quest(questP.template.id + 1);
        questP.data = new short[questP.template.data_quest.length][];
        for (int i = 0; i < questP.data.length; ++i) {
            questP.data[i] = new short[questP.template.data_quest[i].length];
            for (int j = 0; j < questP.data[i].length; ++j) {
                questP.data[i][j] = questP.template.data_quest[i][j];
            }
        }
    }

    private static void send_gift(Player p, QuestP questP) throws IOException {
        ArrayList<GiftBox> result = new ArrayList<GiftBox>();
        for (int i = 0; i < questP.template.gift.size(); ++i) {
            GiftBox temp = new GiftBox();
            temp.type = questP.template.gift.get((int)i).type;
            temp.name = questP.template.gift.get((int)i).name;
            temp.icon = questP.template.gift.get((int)i).icon;
            temp.num = questP.template.gift.get((int)i).num;
            temp.color = questP.template.gift.get((int)i).color;
            temp.id = questP.template.gift.get((int)i).id;
            result.add(temp);
        }
        if (questP.template.id >= -1000 && questP.template.id < 0) {
            ++p.time_nvl;
            if (p.time_nvl % 10 == 0) {
                GiftBox temp = new GiftBox();
                temp.type = (byte)4;
                temp.name = "ruby";
                temp.icon = 1;
                temp.num = 85;
                temp.color = (byte)5;
                temp.id = 1;
                result.add(temp);
            }
            int xptt = Util.random(1, 100);
            p.lucthuc[2] = p.lucthuc[2] + xptt;
        }
        Service.send_gift(p, 0, "Nhi\u1ec7m v\u1ee5 ho\u00e0n th\u00e0nh!", questP.template.infoFinish, result, true);
    }

    public static void send_List_Quest(Player p, boolean save_cache) throws IOException {
        int i;
        ArrayList<QuestP> q0 = new ArrayList<QuestP>();
        ArrayList<QuestP> q1 = new ArrayList<QuestP>();
        ArrayList<QuestP> q2 = new ArrayList<QuestP>();
        block5: for (int i2 = 0; i2 < p.list_quest.size(); ++i2) {
            QuestP temp = p.list_quest.get(i2);
            switch (temp.template.statusQuest) {
                case 0: {
                    q0.add(temp);
                    continue block5;
                }
                case 1: {
                    q1.add(temp);
                    continue block5;
                }
                case 2: {
                    q2.add(temp);
                }
            }
        }
        Message m = new Message(-23);
        m.writer().writeByte(0);
        m.writer().writeByte(q0.size());
        for (i = 0; i < q0.size(); ++i) {
            Quest.write_Quest(m.writer(), (QuestP)q0.get(i));
        }
        m.writer().writeByte(q1.size());
        for (i = 0; i < q1.size(); ++i) {
            Quest.write_Quest(m.writer(), (QuestP)q1.get(i));
        }
        m.writer().writeByte(q2.size());
        for (i = 0; i < q2.size(); ++i) {
            Quest.write_Quest(m.writer(), (QuestP)q2.get(i));
        }
        if (save_cache) {
            p.list_msg_cache.add(m);
        } else {
            p.conn.addmsg(m);
        }
        m.cleanup();
    }

    public static void update_map_have_side_quest(Player p, boolean save_cache) throws IOException {
        QuestP questP;
        int i;
        ArrayList<QuestP> list_remove = new ArrayList<QuestP>();
        for (i = 0; i < p.list_quest.size(); ++i) {
            if (p.list_quest.get((int)i).template.id >= 0 || p.list_quest.get((int)i).template.statusQuest != 0) continue;
            list_remove.add(p.list_quest.get(i));
        }
        if (list_remove.size() > 0) {
            for (i = 0; i < list_remove.size(); ++i) {
                Message m = new Message(-23);
                m.writer().writeByte(2);
                m.writer().writeShort(((QuestP)list_remove.get((int)i)).template.index);
                if (save_cache) {
                    p.list_msg_cache.add(m);
                } else {
                    p.conn.addmsg(m);
                }
                m.cleanup();
                p.list_quest.remove(list_remove.get(i));
            }
            list_remove.clear();
        }
        Quest side_q = null;
        for (int i2 = 0; i2 < ENTRY.size(); ++i2) {
            if (Quest.ENTRY.get((int)i2).id < 0 && Quest.ENTRY.get((int)i2).id >= -1000 && Quest.ENTRY.get((int)i2).statusQuest == 0) {
                for (int j = 0; j < p.map.template.npcs.size(); ++j) {
                    if (p.map.template.npcs.get((int)j).iditem != Quest.ENTRY.get((int)i2).idNpc) continue;
                    side_q = ENTRY.get(i2);
                    break;
                }
            }
            if (side_q != null) break;
        }
        if (side_q != null && (questP = p.get_quest(side_q.index)) == null) {
            QuestP quest_add = new QuestP();
            quest_add.template = side_q;
            quest_add.data = new short[quest_add.template.data_quest.length][];
            for (int i3 = 0; i3 < quest_add.data.length; ++i3) {
                quest_add.data[i3] = new short[quest_add.template.data_quest[i3].length];
                for (int j = 0; j < quest_add.data[i3].length; ++j) {
                    quest_add.data[i3][j] = quest_add.template.data_quest[i3][j];
                }
            }
            p.list_quest.add(quest_add);
            Message m = new Message(-23);
            m.writer().writeByte(1);
            m.writer().writeByte(quest_add.template.statusQuest);
            Quest.write_Quest(m.writer(), quest_add);
            if (save_cache) {
                p.list_msg_cache.add(m);
            } else {
                p.conn.addmsg(m);
            }
            m.cleanup();
        }
    }

    public static void add_finish_quest() {
        if (ENTRY.size() > 0) {
            Quest last = ENTRY.get(ENTRY.size() - 1);
            QUEST_FINISH = new Quest();
            Quest.QUEST_FINISH.index = (short)(last.index + 1);
            Quest.QUEST_FINISH.statusQuest = (byte)2;
            Quest.QUEST_FINISH.typeMainSub = 0;
            Quest.QUEST_FINISH.typeActionQuest = 0;
            Quest.QUEST_FINISH.name = "L\u00e0ng C\u1ed1i Xay Gi\u00f3";
            Quest.QUEST_FINISH.idNpc = (short)-1;
            Quest.QUEST_FINISH.talk = "1 Ch\u00e0o m\u1eebng b\u1ea1n \u0111\u1ebfn server H\u00e0nh Tr\u00ecnh H\u1ea3i T\u1eb7c, ch\u00fac c\u00e1c b\u1ea1n c\u00f3 m\u1ed9t tr\u1ea3i nghi\u1ec7m tuy\u1ec7t v\u1eddi, nhi\u1ec7m v\u1ee5 hi\u1ec7n t\u1ea1i \u0111\u00e3 h\u1ebft";
            Quest.QUEST_FINISH.typeQ = 0;
            Quest.QUEST_FINISH.strNpcMap = "Tr\u01b0\u1edfng l\u00e0ng - L\u00e0ng C\u1ed1i Xay Gi\u00f3";
            Quest.QUEST_FINISH.lvRequest = 1;
            Quest.QUEST_FINISH.strNhacNho = "nhacnho";
            Quest.QUEST_FINISH.showDialog = "H\u00e3y ti\u1ebfp t\u1ee5c n\u00f3i chuy\u1ec7n v\u1edbi tr\u01b0\u1edfng l\u00e0ng.";
            Quest.QUEST_FINISH.data_quest = new short[0][];
            Quest.QUEST_FINISH.idMapHelp = (short)-1;
            Quest.QUEST_FINISH.idNpcSub = (short)-1;
            Quest.QUEST_FINISH.id = (short)(last.id + 1);
            Quest.QUEST_FINISH.gift = new ArrayList<GiftBox>();
            Quest.QUEST_FINISH.infoFinish = "info finish";
        }
    }
}

