/*
 * Decompiled with CFR 0.152.
 */
package client;

import client.Player;
import core.Service;
import core.Util;
import io.Message;
import java.io.IOException;
import java.util.ArrayList;
import template.GiftBox;
import template.ItemTemplate4;

public class Wanted_Chest {
    public static final String[] NAME = new String[]{"R\u01b0\u01a1ng g\u1ed7", "R\u01b0\u01a1ng v\u00e0ng", "R\u01b0\u01a1ng ma thu\u1eadt", "R\u01b0\u01a1ng kh\u1ed5ng l\u1ed3", "R\u01b0\u01a1ng si\u00eau ma thu\u1eadt", "R\u01b0\u01a1ng th\u1ea7n tho\u1ea1i"};
    public short maxTimeUse;
    public short Ruby;
    public short id;
    public long timeUse;

    public static void send_box(Player p) throws IOException {
        for (int i = 0; i < p.wanted_chest.length; ++i) {
            if (p.wanted_chest[i] != null) {
                Wanted_Chest temp = p.wanted_chest[i];
                Message m = new Message(-86);
                m.writer().writeByte(0);
                m.writer().writeByte(i);
                m.writer().writeShort(temp.id);
                m.writer().writeShort(500 + temp.id);
                m.writer().writeByte(109);
                m.writer().writeUTF(NAME[temp.id]);
                m.writer().writeShort(temp.maxTimeUse);
                long time_minute = temp.timeUse - System.currentTimeMillis();
                if (time_minute < 0L) {
                    time_minute = 0L;
                }
                m.writer().writeShort((short)(time_minute /= 60000L));
                m.writer().writeShort(temp.Ruby);
                p.conn.addmsg(m);
                m.cleanup();
                continue;
            }
            Message m = new Message(-86);
            m.writer().writeByte(1);
            m.writer().writeByte(i);
            p.conn.addmsg(m);
            m.cleanup();
        }
    }

    public static void process(Player p, Message m2) throws IOException {
        byte act = m2.reader().readByte();
        short id = m2.reader().readShort();
        if (act == 0) {
            for (int i = 0; i < p.wanted_chest.length; ++i) {
                if (p.wanted_chest[i] == null || p.wanted_chest[i].id != id) continue;
                long time = p.wanted_chest[i].timeUse - System.currentTimeMillis();
                if (time < 0L) {
                    GiftBox gb_;
                    ArrayList<GiftBox> list_gift = new ArrayList<GiftBox>();
                    int beri_receiv = Util.random(10000, 50000);
                    GiftBox gb_beri = new GiftBox();
                    ItemTemplate4 it_temp4 = ItemTemplate4.get_it_by_id(0);
                    if (it_temp4 != null) {
                        gb_beri.id = it_temp4.id;
                        gb_beri.type = (byte)4;
                        gb_beri.name = it_temp4.name;
                        gb_beri.icon = it_temp4.icon;
                        gb_beri.num = beri_receiv;
                        gb_beri.color = 0;
                        list_gift.add(gb_beri);
                    }
                    if (60 > Util.random(120)) {
                        gb_ = new GiftBox();
                        it_temp4 = ItemTemplate4.get_it_by_id(18 + p.level / 10);
                        if (it_temp4 != null) {
                            gb_.id = it_temp4.id;
                            gb_.type = (byte)4;
                            gb_.name = it_temp4.name;
                            gb_.icon = it_temp4.icon;
                            gb_.num = Util.random(1, 3);
                            gb_.color = 0;
                            list_gift.add(gb_);
                        }
                    }
                    if (p.level >= 10 && 40 > Util.random(120)) {
                        gb_ = new GiftBox();
                        it_temp4 = ItemTemplate4.get_it_by_id(111 + p.level / 10);
                        if (it_temp4 != null) {
                            gb_.id = it_temp4.id;
                            gb_.type = (byte)4;
                            gb_.name = it_temp4.name;
                            gb_.icon = it_temp4.icon;
                            gb_.num = Util.random(1, 3);
                            gb_.color = 0;
                            list_gift.add(gb_);
                        }
                    }
                    if (p.level >= 10 && 30 > Util.random(120)) {
                        gb_ = new GiftBox();
                        it_temp4 = ItemTemplate4.get_it_by_id(121 + p.level / 10);
                        if (it_temp4 != null) {
                            gb_.id = it_temp4.id;
                            gb_.type = (byte)4;
                            gb_.name = it_temp4.name;
                            gb_.icon = it_temp4.icon;
                            gb_.num = Util.random(1, 3);
                            gb_.color = 0;
                            list_gift.add(gb_);
                        }
                    }
                    if (p.level >= 10 && 20 > Util.random(120)) {
                        gb_ = new GiftBox();
                        it_temp4 = ItemTemplate4.get_it_by_id(29);
                        if (it_temp4 != null) {
                            gb_.id = it_temp4.id;
                            gb_.type = (byte)4;
                            gb_.name = it_temp4.name;
                            gb_.icon = it_temp4.icon;
                            gb_.num = Util.random(1, 3);
                            gb_.color = 0;
                            list_gift.add(gb_);
                        }
                    }
                    if (p.level >= 10 && 5 > Util.random(120)) {
                        gb_ = new GiftBox();
                        it_temp4 = ItemTemplate4.get_it_by_id(158);
                        if (it_temp4 != null) {
                            gb_.id = it_temp4.id;
                            gb_.type = (byte)4;
                            gb_.name = it_temp4.name;
                            gb_.icon = it_temp4.icon;
                            gb_.num = Util.random(1, 3);
                            gb_.color = 0;
                            list_gift.add(gb_);
                        }
                    }
                    Service.send_gift(p, 1, "R\u01b0\u01a1ng truy n\u00e3", "Ph\u1ea7n th\u01b0\u1edfng", list_gift, true);
                    p.wanted_chest[i] = null;
                    Wanted_Chest.send_box(p);
                    break;
                }
                Service.send_box_ThongBao_OK(p, "M\u1edf sau " + Util.get_time_str_by_sec2(time) + " n\u1eefa");
                break;
            }
        }
    }

    public static void receiv_ruong(Player p) throws IOException {
        for (int i = 0; i < p.wanted_chest.length; ++i) {
            if (p.wanted_chest[i] != null) continue;
            p.wanted_chest[i] = new Wanted_Chest();
            p.wanted_chest[i].id = p.get_wanted_point() >= 10000000 ? (short)Util.random(6) : (p.get_wanted_point() >= 5000000 && p.get_wanted_point() < 10000000 ? (short)Util.random(5) : (p.get_wanted_point() >= 1500000 && p.get_wanted_point() < 5000000 ? (short)Util.random(4) : (p.get_wanted_point() >= 750000 && p.get_wanted_point() < 1500000 ? (short)Util.random(3) : (p.get_wanted_point() >= 1 && p.get_wanted_point() < 750000 ? (short)Util.random(2) : (short)0))));
            switch (p.wanted_chest[i].id) {
                case 0: {
                    p.wanted_chest[i].timeUse = System.currentTimeMillis() + 5400000L;
                    break;
                }
                case 1: {
                    p.wanted_chest[i].timeUse = System.currentTimeMillis() + 10800000L;
                    break;
                }
                case 2: {
                    p.wanted_chest[i].timeUse = System.currentTimeMillis() + 43200000L;
                    break;
                }
                case 3: {
                    p.wanted_chest[i].timeUse = System.currentTimeMillis() + 43200000L;
                    break;
                }
                case 4: {
                    p.wanted_chest[i].timeUse = System.currentTimeMillis() + 64800000L;
                    break;
                }
                case 5: {
                    p.wanted_chest[i].timeUse = System.currentTimeMillis() + 86400000L;
                }
            }
            p.wanted_chest[i].Ruby = 1;
            p.wanted_chest[i].maxTimeUse = 0;
            Wanted_Chest.send_box(p);
            break;
        }
    }
}

