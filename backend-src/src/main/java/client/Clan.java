/*
 * Decompiled with CFR 0.152.
 */
package client;

import client.Clazz;
import client.Player;
import core.Service;
import core.Util;
import database.SQL;
import io.Message;
import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import map.Map;
import org.json.simple.JSONArray;
import template.Clan_chat;
import template.Clan_member;
import template.EffTemplate;
import template.ItemBag47;
import template.ItemTemplate8;

public class Clan {
    public static List<Clan> ENTRY;
    public static List<String> BXH;
    public List<Clan_member> members;
    public short icon;
    public String name;
    public short id;
    public short level;
    public int xp;
    public short maxAttri;
    public short pointAttri;
    public short[] opAttri;
    public String thongbao;
    public byte trungsinh;
    public int countAction;
    public int ruby;
    public int beri;
    public List<Clan_chat> chat;
    public byte allowRequest;
    public List<Clan_member> mem_request;
    public List<ItemBag47> list_it;
    public List<EffTemplate> buff;
    public Map map_create;

    public static int get_icon_clan(String name) {
        for (int i = 0; i < ENTRY.size(); ++i) {
            for (int j = 0; j < Clan.ENTRY.get((int)i).members.size(); ++j) {
                if (!Clan.ENTRY.get((int)i).members.get((int)j).name.equals(name)) continue;
                return Clan.ENTRY.get((int)i).icon;
            }
        }
        return -1;
    }

    public static Clan get_my_clan(String name) {
        for (int i = 0; i < ENTRY.size(); ++i) {
            for (int j = 0; j < Clan.ENTRY.get((int)i).members.size(); ++j) {
                if (!Clan.ENTRY.get((int)i).members.get((int)j).name.equals(name)) continue;
                return ENTRY.get(i);
            }
        }
        return null;
    }

    public static Clan get_clan_by_id(int id) {
        for (int i = 0; i < ENTRY.size(); ++i) {
            if (Clan.ENTRY.get((int)i).id != id) continue;
            return ENTRY.get(i);
        }
        return null;
    }

    public static Clan get_clan_by_name(String name) {
        for (int i = 0; i < ENTRY.size(); ++i) {
            if (!Clan.ENTRY.get((int)i).name.equals(name)) continue;
            return ENTRY.get(i);
        }
        return null;
    }

    public static void send_info(Player p, boolean b) throws IOException {
        if (p.clan != null) {
            Message m = new Message(-52);
            m.writer().writeByte(0);
            m.writer().writeShort(p.clan.id);
            m.writer().writeUTF(p.clan.name);
            if (b) {
                p.list_msg_cache.add(m);
            } else {
                p.conn.addmsg(m);
            }
            m.cleanup();
            Clan.set_data(p, b);
            Clan.send_Attri(p, b);
            Clan.update_list_member(p, b);
            Clan.send_me_to_other(p, p, b);
            Clan.send_notice(p, false);
            p.clan.send_inventory(p, b);
            Clan.send_xp(p, b);
            Clan.send_money(p, b);
        }
    }

    public static void send_money(Player p, boolean b) throws IOException {
        if (p.clan != null) {
            Message m = new Message(-52);
            m.writer().writeByte(17);
            m.writer().writeInt(p.clan.get_ngoc());
            m.writer().writeInt(p.clan.get_vang());
            if (b) {
                p.list_msg_cache.add(m);
            } else {
                p.conn.addmsg(m);
            }
            m.cleanup();
        }
    }

    public static void send_me_to_other(Player p0, Player p, boolean b) throws IOException {
        if (p0.clan != null && p0.conn != null) {
            Message m = new Message(-52);
            m.writer().writeByte(5);
            m.writer().writeShort(p0.index_map);
            m.writer().writeShort(p0.clan.id);
            m.writer().writeShort(p0.clan.icon);
            for (int i = 0; i < p0.clan.members.size(); ++i) {
                if (!p0.clan.members.get((int)i).name.equals(p0.name)) continue;
                m.writer().writeByte(p0.clan.members.get((int)i).levelInclan);
                break;
            }
            m.writer().writeByte(0);
            if (b) {
                p.list_msg_cache.add(m);
            } else {
                p.conn.addmsg(m);
            }
            m.cleanup();
        }
    }

    public static synchronized void reset_day() {
        for (int i = 0; i < ENTRY.size(); ++i) {
            Clan.ENTRY.get((int)i).chat.clear();
            for (int j = 0; j < Clan.ENTRY.get((int)i).members.size(); ++j) {
                Clan_member mem = Clan.ENTRY.get((int)i).members.get(j);
                mem.numquest = 0;
            }
        }
    }

    public static synchronized List<Clan> get_list_now_clan() {
        ArrayList<Clan> result = new ArrayList<Clan>();
        for (int i = 0; i < ENTRY.size(); ++i) {
            result.add(ENTRY.get(i));
        }
        return result;
    }

    public int get_vang() {
        return this.beri;
    }

    public int get_ngoc() {
        return this.ruby;
    }

    private static void send_xp(Player p, boolean b) throws IOException {
        Message m = new Message(-52);
        m.writer().writeByte(16);
        m.writer().writeByte(p.clan.xp >= Clan.get_xp_max(p.clan.level, p.clan.trungsinh) ? (p.clan.level == 15 ? 2 : 1) : 0);
        m.writer().writeInt(p.clan.xp);
        if (b) {
            p.list_msg_cache.add(m);
        } else {
            p.conn.addmsg(m);
        }
        m.cleanup();
    }

    public static void process(Player p, Message m2, int type) throws IOException {
        block0 : switch (type) {
            case 13: {
                if (p.clan.members.get((int)0).name.equals(p.name)) {
                    if (p.clan.xp >= Clan.get_xp_max(p.clan.level, p.clan.trungsinh)) {
                        if (p.clan.get_ngoc() < Clan.get_ngoc_upgrade(p.clan.level, p.clan.trungsinh)) {
                            Service.send_box_ThongBao_OK(p, "C\u1ea7n " + Util.number_format(Clan.get_ngoc_upgrade(p.clan.level, p.clan.trungsinh)) + " ruby b\u0103ng \u0111\u1ec3 th\u1ef1c hi\u1ec7n n\u00e2ng c\u1ea5p");
                            return;
                        }
                        if (p.clan.get_vang() < Clan.get_vang_upgrade(p.clan.level)) {
                            Service.send_box_ThongBao_OK(p, "C\u1ea7n " + Util.number_format(Clan.get_vang_upgrade(p.clan.level)) + " beri b\u0103ng \u0111\u1ec3 th\u1ef1c hi\u1ec7n n\u00e2ng c\u1ea5p");
                            return;
                        }
                        if (p.clan.level >= 14 && p.clan.trungsinh >= 6) {
                            Service.send_box_ThongBao_OK(p, "C\u00f3 l\u1ed7i x\u1ea3y ra");
                            return;
                        }
                        p.clan.update_ruby(-Clan.get_ngoc_upgrade(p.clan.level, p.clan.trungsinh));
                        p.clan.update_beri(-Clan.get_vang_upgrade(p.clan.level));
                        p.clan.xp -= Clan.get_xp_max(p.clan.level, p.clan.trungsinh);
                        p.clan.level = (short)(p.clan.level + 1);
                        p.clan.pointAttri = (short)(p.clan.pointAttri + 2);
                        if (p.clan.level >= 16) {
                            p.clan.level = 1;
                            p.clan.opAttri = new short[]{0, 0, 0, 0, 0};
                            p.clan.pointAttri = (short)2;
                            p.clan.maxAttri = (short)20;
                            p.clan.trungsinh = (byte)(p.clan.trungsinh + 1);
                            switch (p.clan.trungsinh) {
                                case 1: {
                                    p.clan.maxAttri = (short)25;
                                    break;
                                }
                                case 2: {
                                    p.clan.maxAttri = (short)30;
                                    break;
                                }
                                case 3: {
                                    p.clan.maxAttri = (short)35;
                                    break;
                                }
                                case 4: {
                                    p.clan.maxAttri = (short)40;
                                    break;
                                }
                                case 5: {
                                    p.clan.maxAttri = (short)45;
                                    break;
                                }
                                case 6: {
                                    p.clan.maxAttri = (short)50;
                                }
                            }
                        }
                        for (int i1 = 0; i1 < p.clan.members.size(); ++i1) {
                            Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i1).name);
                            if (p0 == null) continue;
                            Clan.send_info(p0, false);
                        }
                        if (p.clan.level == 1) {
                            Service.send_box_ThongBao_OK(p, "Tr\u00f9ng sinh b\u0103ng th\u00e0nh c\u00f4ng l\u00ean " + p.clan.trungsinh);
                            break;
                        }
                        Service.send_box_ThongBao_OK(p, "N\u00e2ng c\u1ea5p bang th\u00e0nh c\u00f4ng l\u00ean c\u1ea5p " + p.clan.level);
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "Ch\u01b0a \u0111\u1ee7 \u0111i\u1ec1u ki\u1ec7n n\u00e2ng c\u1ea5p bang");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng ph\u1ea3i thuy\u1ec1n tr\u01b0\u1edfng");
                break;
            }
            case 14: {
                short id = m2.reader().readShort();
                m2.reader().readByte();
                if (p.clan.members.get((int)0).name.equals(p.name)) {
                    int i;
                    ItemBag47 it_select = null;
                    for (i = 0; i < p.clan.list_it.size(); ++i) {
                        if (p.clan.list_it.get((int)i).id != id) continue;
                        if (p.clan.list_it.get((int)i).quant <= 0) break;
                        it_select = p.clan.list_it.get(i);
                        break;
                    }
                    if (it_select != null) {
                        switch (id) {
                            case 0: {
                                EffTemplate eff = null;
                                for (int i2 = 0; i2 < p.clan.buff.size(); ++i2) {
                                    if (p.clan.buff.get((int)i2).id != 0) continue;
                                    eff = p.clan.buff.get(i2);
                                }
                                if (eff != null) {
                                    eff.time = eff.time > System.currentTimeMillis() ? (eff.time += 3600000L) : System.currentTimeMillis() + 3600000L;
                                } else {
                                    eff = new EffTemplate(0, 2, System.currentTimeMillis() + 3600000L);
                                    p.clan.buff.add(eff);
                                }
                                Clan_chat chat = new Clan_chat();
                                chat.idMem = p.clan.members.get((int)0).id;
                                chat.name = p.clan.members.get((int)0).name;
                                chat.str = "s\u1eed d\u1ee5ng b\u00f9a kinh nghi\u1ec7m lv1 t\u00e1c d\u1ee5ng c\u00f2n " + (eff.time - System.currentTimeMillis()) / 1000L + "s";
                                chat.time = System.currentTimeMillis();
                                chat.typeChat = (byte)-3;
                                p.clan.add_chat(chat);
                                p.clan.send_chat(chat, null);
                                it_select.quant = (short)(it_select.quant - 1);
                                if (it_select.quant <= 0) {
                                    p.clan.list_it.remove(it_select);
                                }
                                for (int i1 = 0; i1 < p.clan.members.size(); ++i1) {
                                    Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i1).name);
                                    if (p0 == null) continue;
                                    Clan.send_info(p0, false);
                                }
                                break block0;
                            }
                            case 1: {
                                EffTemplate eff = null;
                                for (int i3 = 0; i3 < p.clan.buff.size(); ++i3) {
                                    if (p.clan.buff.get((int)i3).id != 1) continue;
                                    eff = p.clan.buff.get(i3);
                                }
                                if (eff != null) {
                                    eff.time = eff.time > System.currentTimeMillis() ? (eff.time += 3600000L) : System.currentTimeMillis() + 3600000L;
                                } else {
                                    eff = new EffTemplate(1, 2, System.currentTimeMillis() + 3600000L);
                                    p.clan.buff.add(eff);
                                }
                                Clan_chat chat = new Clan_chat();
                                chat.idMem = p.clan.members.get((int)0).id;
                                chat.name = p.clan.members.get((int)0).name;
                                chat.str = "s\u1eed d\u1ee5ng b\u00f9a kinh nghi\u1ec7m lv2 t\u00e1c d\u1ee5ng c\u00f2n " + (eff.time - System.currentTimeMillis()) / 1000L + "s";
                                chat.time = System.currentTimeMillis();
                                chat.typeChat = (byte)-3;
                                p.clan.add_chat(chat);
                                p.clan.send_chat(chat, null);
                                it_select.quant = (short)(it_select.quant - 1);
                                if (it_select.quant <= 0) {
                                    p.clan.list_it.remove(it_select);
                                }
                                for (int i1 = 0; i1 < p.clan.members.size(); ++i1) {
                                    Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i1).name);
                                    if (p0 == null) continue;
                                    Clan.send_info(p0, false);
                                }
                                break block0;
                            }
                            case 2: {
                                EffTemplate eff = null;
                                for (int i4 = 0; i4 < p.clan.buff.size(); ++i4) {
                                    if (p.clan.buff.get((int)i4).id != 2) continue;
                                    eff = p.clan.buff.get(i4);
                                }
                                if (eff != null) {
                                    eff.time = eff.time > System.currentTimeMillis() ? (eff.time += 3600000L) : System.currentTimeMillis() + 3600000L;
                                } else {
                                    eff = new EffTemplate(2, 2, System.currentTimeMillis() + 3600000L);
                                    p.clan.buff.add(eff);
                                }
                                Clan_chat chat = new Clan_chat();
                                chat.idMem = p.clan.members.get((int)0).id;
                                chat.name = p.clan.members.get((int)0).name;
                                chat.str = "s\u1eed d\u1ee5ng b\u00f9a hp t\u00e1c d\u1ee5ng c\u00f2n " + (eff.time - System.currentTimeMillis()) / 1000L + "s";
                                chat.time = System.currentTimeMillis();
                                chat.typeChat = (byte)-3;
                                p.clan.add_chat(chat);
                                p.clan.send_chat(chat, null);
                                it_select.quant = (short)(it_select.quant - 1);
                                if (it_select.quant <= 0) {
                                    p.clan.list_it.remove(it_select);
                                }
                                for (int i1 = 0; i1 < p.clan.members.size(); ++i1) {
                                    Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i1).name);
                                    if (p0 == null) continue;
                                    Clan.send_info(p0, false);
                                }
                                break block0;
                            }
                            case 3: {
                                EffTemplate eff = null;
                                for (int i5 = 0; i5 < p.clan.buff.size(); ++i5) {
                                    if (p.clan.buff.get((int)i5).id != 3) continue;
                                    eff = p.clan.buff.get(i5);
                                }
                                if (eff != null) {
                                    eff.time = eff.time > System.currentTimeMillis() ? (eff.time += 3600000L) : System.currentTimeMillis() + 3600000L;
                                } else {
                                    eff = new EffTemplate(3, 2, System.currentTimeMillis() + 3600000L);
                                    p.clan.buff.add(eff);
                                }
                                Clan_chat chat = new Clan_chat();
                                chat.idMem = p.clan.members.get((int)0).id;
                                chat.name = p.clan.members.get((int)0).name;
                                chat.str = "s\u1eed d\u1ee5ng b\u00f9a mp t\u00e1c d\u1ee5ng c\u00f2n " + (eff.time - System.currentTimeMillis()) / 1000L + "s";
                                chat.time = System.currentTimeMillis();
                                chat.typeChat = (byte)-3;
                                p.clan.add_chat(chat);
                                p.clan.send_chat(chat, null);
                                it_select.quant = (short)(it_select.quant - 1);
                                if (it_select.quant <= 0) {
                                    p.clan.list_it.remove(it_select);
                                }
                                for (int i1 = 0; i1 < p.clan.members.size(); ++i1) {
                                    Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i1).name);
                                    if (p0 == null) continue;
                                    Clan.send_info(p0, false);
                                }
                                break block0;
                            }
                            case 4: {
                                EffTemplate eff = null;
                                for (int i6 = 0; i6 < p.clan.buff.size(); ++i6) {
                                    if (p.clan.buff.get((int)i6).id != 4) continue;
                                    eff = p.clan.buff.get(i6);
                                }
                                if (eff != null) {
                                    eff.time = eff.time > System.currentTimeMillis() ? (eff.time += 3600000L) : System.currentTimeMillis() + 3600000L;
                                } else {
                                    eff = new EffTemplate(4, 2, System.currentTimeMillis() + 3600000L);
                                    p.clan.buff.add(eff);
                                }
                                Clan_chat chat = new Clan_chat();
                                chat.idMem = p.clan.members.get((int)0).id;
                                chat.name = p.name;
                                chat.str = "s\u1eed d\u1ee5ng b\u00f9a t\u1ed5ng h\u1ee3p t\u00e1c d\u1ee5ng c\u00f2n " + (eff.time - System.currentTimeMillis()) / 1000L + "s";
                                chat.time = System.currentTimeMillis();
                                chat.typeChat = (byte)-3;
                                p.clan.add_chat(chat);
                                p.clan.send_chat(chat, null);
                                it_select.quant = (short)(it_select.quant - 1);
                                if (it_select.quant <= 0) {
                                    p.clan.list_it.remove(it_select);
                                }
                                for (int i1 = 0; i1 < p.clan.members.size(); ++i1) {
                                    Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i1).name);
                                    if (p0 == null) continue;
                                    Clan.send_info(p0, false);
                                }
                                break block0;
                            }
                            case 6: {
                                int i1;
                                it_select.quant = (short)(it_select.quant - 1);
                                if (it_select.quant <= 0) {
                                    p.clan.list_it.remove(it_select);
                                }
                                p.clan.update_beri(10000L);
                                for (i1 = 0; i1 < p.clan.members.size(); ++i1) {
                                    Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i1).name);
                                    if (p0 == null) continue;
                                    Clan.send_info(p0, false);
                                }
                                break block0;
                            }
                            case 7: {
                                int i1;
                                it_select.quant = (short)(it_select.quant - 1);
                                if (it_select.quant <= 0) {
                                    p.clan.list_it.remove(it_select);
                                }
                                p.clan.pointAttri = 0;
                                for (i = 1; i <= p.clan.level; ++i) {
                                    p.clan.pointAttri = (short)(p.clan.pointAttri + 2);
                                }
                                p.clan.opAttri = new short[]{0, 0, 0, 0, 0};
                                for (i1 = 0; i1 < p.clan.members.size(); ++i1) {
                                    Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i1).name);
                                    if (p0 == null) continue;
                                    Clan.send_info(p0, false);
                                }
                                Service.send_box_ThongBao_OK(p, "T\u1ea9y ti\u1ec1m n\u0103ng b\u0103ng th\u00e0nh c\u00f4ng");
                                break;
                            }
                            default: {
                                Service.send_box_ThongBao_OK(p, "Hi\u1ec7n t\u1ea1i " + ItemTemplate8.ENTRYS.get((int)id).name + " ch\u01b0a th\u1ec3 s\u1eed d\u1ee5ng, \u0111\u1ee3i m\u00ecnh 1 th\u1eddi gian n\u1eefa s\u1ebd c\u1eadp nh\u1eadt s\u1edbm nh\u1ea5t nha");
                                break;
                            }
                        }
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 1 " + ItemTemplate8.ENTRYS.get((int)id).name + " trong h\u00e0nh trang b\u0103ng");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng ph\u1ea3i thuy\u1ec1n tr\u01b0\u1edfng");
                break;
            }
            case 15: {
                Service.input_text(p, 11, "\u0110\u00f3ng g\u00f3p b\u0103ng", new String[]{"Nh\u1eadp s\u1ed1 ruby mu\u1ed1n g\u00f3p"});
                break;
            }
            case 3: {
                String strChat = m2.reader().readUTF();
                byte chucVu = m2.reader().readByte();
                Clan_member getMem = null;
                for (int i = 0; i < p.clan.members.size(); ++i) {
                    if (!p.clan.members.get((int)i).name.equals(p.name) || p.clan.members.get((int)i).levelInclan != 0 && p.clan.members.get((int)i).levelInclan != 1) continue;
                    getMem = p.clan.members.get(i);
                    break;
                }
                if (chucVu != 0 && getMem != null) {
                    int i;
                    Clan_member mem = null;
                    for (int i7 = 0; i7 < p.clan.members.size(); ++i7) {
                        if (!p.clan.members.get((int)i7).name.equals(strChat)) continue;
                        mem = p.clan.members.get(i7);
                        break;
                    }
                    if (mem == null) break;
                    if (mem.levelInclan == 0) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng th\u1ec3 th\u1ef1c hi\u1ec7n ch\u1ee9c n\u0103ng n\u00e0y!");
                        return;
                    }
                    if (mem.levelInclan == chucVu) {
                        Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng \u0111\u00e3 c\u00f3 ch\u1ee9c v\u1ee5 n\u00e0y");
                        return;
                    }
                    int numThuyenPho = 0;
                    int numHoaTieu = 0;
                    for (int i8 = 0; i8 < p.clan.members.size(); ++i8) {
                        if (p.clan.members.get((int)i8).levelInclan == 1) {
                            ++numThuyenPho;
                        }
                        if (p.clan.members.get((int)i8).levelInclan != 2) continue;
                        ++numHoaTieu;
                    }
                    if (chucVu == 1 && numThuyenPho >= 2) {
                        Service.send_box_ThongBao_OK(p, "Trong b\u0103ng ch\u1ec9 c\u00f3 th\u1ec3 t\u1ed1i \u0111a 2 thuy\u1ec1n ph\u00f3!");
                        return;
                    }
                    if (chucVu == 2 && numHoaTieu >= 1) {
                        Service.send_box_ThongBao_OK(p, "Trong b\u0103ng ch\u1ec9 c\u00f3 th\u1ec3 t\u1ed1i \u0111a 1 hoa ti\u00eau!");
                        return;
                    }
                    mem.levelInclan = chucVu;
                    Player p0 = Map.get_player_by_name_allmap(mem.name);
                    if (p0 != null) {
                        Clan.send_info(p0, false);
                        for (i = 0; i < p.map.players.size(); ++i) {
                            if (p.map.players.get(i).equals(p0)) continue;
                            Clan.send_me_to_other(p0, p.map.players.get(i), false);
                        }
                        Service.send_box_ThongBao_OK(p0, "B\u1ea1n \u0111\u01b0\u1ee3c phong th\u00e0nh " + (mem.levelInclan == 1 ? "Thuy\u1ec1n ph\u00f3" : (mem.levelInclan == 2 ? "Hoa ti\u00eau" : "thuy\u1ec1n vi\u00ean")));
                    }
                    for (i = 0; i < p.clan.members.size(); ++i) {
                        Player p0ther = Map.get_player_by_name_allmap(p.clan.members.get((int)i).name);
                        if (p0ther == null) continue;
                        Clan.update_list_member(p0ther, false);
                        Clan.send_info(p0ther, false);
                    }
                    Clan_chat chat = new Clan_chat();
                    chat.idMem = p.clan.members.get((int)0).id;
                    chat.name = p.name;
                    chat.str = "phong ch\u1ee9c " + mem.name + " th\u00e0nh " + (mem.levelInclan == 1 ? "Thuy\u1ec1n ph\u00f3" : (mem.levelInclan == 2 ? "Hoa ti\u00eau" : "thuy\u1ec1n vi\u00ean"));
                    chat.time = System.currentTimeMillis();
                    chat.typeChat = (byte)-3;
                    p.clan.add_chat(chat);
                    p.clan.send_chat(chat, null);
                    Service.send_box_ThongBao_OK(p, "Phong ch\u1ee9c " + mem.name + " th\u00e0nh " + (mem.levelInclan == 1 ? "Thuy\u1ec1n ph\u00f3" : (mem.levelInclan == 2 ? "Hoa ti\u00eau" : "thuy\u1ec1n vi\u00ean")) + " th\u00e0nh c\u00f4ng");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng ph\u1ea3i thuy\u1ec1n tr\u01b0\u1edfng");
                break;
            }
            case 1: {
                String strChat = m2.reader().readUTF();
                byte chucVu = m2.reader().readByte();
                Clan_member getMem = null;
                for (int i = 0; i < p.clan.members.size(); ++i) {
                    if (!p.clan.members.get((int)i).name.equals(p.name) || p.clan.members.get((int)i).levelInclan != 0 && p.clan.members.get((int)i).levelInclan != 1) continue;
                    getMem = p.clan.members.get(i);
                    break;
                }
                if (chucVu != 0 || getMem == null) break;
                Clan_member mem = null;
                for (int i = 0; i < p.clan.members.size(); ++i) {
                    if (!p.clan.members.get((int)i).name.equals(strChat)) continue;
                    mem = p.clan.members.get(i);
                    break;
                }
                if (mem == null) break;
                if (mem.levelInclan == 0) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng th\u1ec3 th\u1ef1c hi\u1ec7n ch\u1ee9c n\u0103ng n\u00e0y!");
                    return;
                }
                p.clan.members.remove(mem);
                Player p0 = Map.get_player_by_name_allmap(mem.name);
                if (p0 != null) {
                    Clan.send_info(p0, false);
                    for (int i = 0; i < p.map.players.size(); ++i) {
                        if (p.map.players.get(i).equals(p0)) continue;
                        Clan.send_me_to_other(p0, p.map.players.get(i), false);
                    }
                    Service.send_box_ThongBao_OK(p0, "B\u1ea1n b\u1ecb tr\u1ee5c xu\u1ea5t kh\u1ecfi b\u0103ng " + p.clan.name);
                    Message m = new Message(-52);
                    m.writer().writeByte(10);
                    m.writer().writeShort(p0.index_map);
                    p.map.send_msg_all_p(m, p0, true);
                    m.cleanup();
                    p0.clan = null;
                }
                for (int i = 0; i < p.clan.members.size(); ++i) {
                    Player p0ther = Map.get_player_by_name_allmap(p.clan.members.get((int)i).name);
                    if (p0ther == null) continue;
                    Clan.update_list_member(p0ther, false);
                    Clan.send_info(p0ther, false);
                    Message m_out = new Message(-52);
                    m_out.writer().writeByte(12);
                    m_out.writer().writeByte(1);
                    m_out.writer().writeUTF(mem.name);
                    p0ther.conn.addmsg(m_out);
                    m_out.cleanup();
                }
                Clan_chat chat = new Clan_chat();
                chat.idMem = p.clan.members.get((int)0).id;
                chat.name = p.name;
                chat.str = mem.name + " b\u1ecb tr\u1ee5c xu\u1ea5t kh\u1ecfi b\u0103ng";
                chat.time = System.currentTimeMillis();
                chat.typeChat = (byte)-2;
                p.clan.add_chat(chat);
                p.clan.send_chat(chat, null);
                Service.send_box_ThongBao_OK(p, mem.name + " b\u1ecb tr\u1ee5c xu\u1ea5t kh\u1ecfi b\u0103ng th\u00e0nh c\u00f4ng");
                break;
            }
            case 4: {
                int i;
                if (p.clan == null) break;
                for (i = 0; i < p.clan.members.size(); ++i) {
                    if (!p.clan.members.get((int)i).name.equals(p.name)) continue;
                    p.clan.members.remove(i);
                    break;
                }
                Clan.send_info(p, false);
                for (i = 0; i < p.map.players.size(); ++i) {
                    if (p.map.players.get(i).equals(p)) continue;
                    Clan.send_me_to_other(p, p.map.players.get(i), false);
                }
                for (i = 0; i < p.clan.members.size(); ++i) {
                    Player p0ther;
                    if (p.clan.members.get((int)i).name.equals(p.name) || (p0ther = Map.get_player_by_name_allmap(p.clan.members.get((int)i).name)) == null) continue;
                    Clan.update_list_member(p0ther, false);
                    Clan.send_info(p0ther, false);
                    Message m_out = new Message(-52);
                    m_out.writer().writeByte(12);
                    m_out.writer().writeByte(1);
                    m_out.writer().writeUTF(p.name);
                    p0ther.conn.addmsg(m_out);
                    m_out.cleanup();
                }
                Message m = new Message(-52);
                m.writer().writeByte(10);
                m.writer().writeShort(p.index_map);
                p.map.send_msg_all_p(m, p, true);
                m.cleanup();
                Service.send_box_ThongBao_OK(p, "R\u1eddi b\u0103ng " + p.clan.name + " th\u00e0nh c\u00f4ng");
                Clan_chat chat = new Clan_chat();
                chat.idMem = p.clan.members.get((int)0).id;
                chat.name = p.clan.members.get((int)0).name;
                chat.str = p.name + " r\u1eddi b\u0103ng";
                chat.time = System.currentTimeMillis();
                chat.typeChat = (byte)-2;
                p.clan.add_chat(chat);
                p.clan.send_chat(chat, null);
                p.clan = null;
                break;
            }
            case 17: {
                Clan.update_list_member(p, false);
                break;
            }
            case 0: {
                String strChat = m2.reader().readUTF();
                m2.reader().readByte();
                Clan_member mem = null;
                for (int i = 0; i < p.clan.members.size(); ++i) {
                    if (!p.clan.members.get((int)i).name.equals(p.name)) continue;
                    mem = p.clan.members.get(i);
                    break;
                }
                if (mem == null) break;
                Clan_chat chat = new Clan_chat();
                chat.idMem = mem.id;
                chat.name = p.name;
                chat.str = strChat;
                chat.time = System.currentTimeMillis();
                chat.typeChat = (byte)(mem.levelInclan == 0 ? -1 : -4);
                p.clan.add_chat(chat);
                p.clan.send_chat(chat, null);
                break;
            }
            case 5: {
                String strChat = m2.reader().readUTF();
                m2.reader().readByte();
                if (!p.clan.members.get((int)0).name.equals(p.name)) break;
                p.clan.thongbao = strChat;
                for (int i = 0; i < p.clan.members.size(); ++i) {
                    Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i).name);
                    if (p0 == null) continue;
                    Clan.send_notice(p0, false);
                }
                Clan_chat chat = new Clan_chat();
                chat.idMem = p.clan.members.get((int)0).id;
                chat.name = p.name;
                chat.str = strChat;
                chat.time = System.currentTimeMillis();
                chat.typeChat = (byte)-3;
                p.clan.add_chat(chat);
                p.clan.send_chat(chat, null);
                break;
            }
            case 6: {
                byte chucVu = m2.reader().readByte();
                m2.reader().readByte();
                if (p.clan.members.get((int)0).name.equals(p.name)) {
                    if (p.clan.pointAttri > 0) {
                        if (p.clan.opAttri[chucVu] + Clan.get_point_trungsinh_plus(p.clan) >= p.clan.maxAttri) {
                            Service.send_box_ThongBao_OK(p, "Hi\u1ec7n t\u1ea1i ti\u1ec1m n\u0103ng t\u1ed1i \u0111a l\u00e0 " + p.clan.maxAttri);
                            break;
                        }
                        p.clan.pointAttri = (short)(p.clan.pointAttri - 1);
                        byte by = chucVu;
                        p.clan.opAttri[by] = (short)(p.clan.opAttri[by] + 1);
                        for (int i = 0; i < p.clan.members.size(); ++i) {
                            Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i).name);
                            if (p0 == null) continue;
                            Clan.send_Attri(p0, false);
                            p0.update_info_to_all();
                        }
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 1 \u0111i\u1ec3m ti\u1ec1m n\u0103ng");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng ph\u1ea3i thuy\u1ec1n tr\u01b0\u1edfng");
                break;
            }
            case 7: {
                int j;
                int i;
                Clan_member mem;
                Clan_member clan_mem = null;
                for (int i9 = 0; i9 < p.clan.members.size(); ++i9) {
                    if (!p.clan.members.get((int)i9).name.equals(p.name)) continue;
                    clan_mem = p.clan.members.get(i9);
                    break;
                }
                if (clan_mem == null || clan_mem.levelInclan < 0 || clan_mem.levelInclan > 2) break;
                m2.reader().readUTF();
                int id = m2.reader().readInt();
                Clan_chat clan_chat = null;
                for (int i10 = 0; i10 < p.clan.chat.size(); ++i10) {
                    if (p.clan.chat.get((int)i10).idChat != id) continue;
                    clan_chat = p.clan.chat.get(i10);
                    break;
                }
                if (clan_chat == null || (mem = p.clan.get_mem_request(clan_chat.str.replace(" xin v\u00e0o b\u0103ng", ""))) == null) break;
                ArrayList<Clan_chat> list_remove = new ArrayList<Clan_chat>();
                for (i = 0; i < p.clan.chat.size(); ++i) {
                    if (!p.clan.chat.get((int)i).str.equals(clan_chat.str)) continue;
                    list_remove.add(p.clan.chat.get(i));
                }
                for (i = 0; i < list_remove.size(); ++i) {
                    for (j = 0; j < p.clan.members.size(); ++j) {
                        Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)j).name);
                        if (p0 == null) continue;
                        p.clan.remove_chat(p0, ((Clan_chat)list_remove.get((int)i)).idChat);
                    }
                }
                p.clan.chat.removeAll(list_remove);
                int num_clazz = 0;
                for (j = 0; j < p.clan.members.size(); ++j) {
                    if (p.clan.members.get((int)j).clazz != mem.clazz) continue;
                    ++num_clazz;
                }
                if (num_clazz >= 4) {
                    Service.send_box_ThongBao_OK(p, "B\u0103ng \u0111\u00e3 \u0111\u1ea7y \u0111\u1ee7 4/4 " + Clazz.NAME[mem.clazz - 1]);
                    return;
                }
                if (p.clan.members.size() >= Clan.get_mem_max(p.clan.level, p.clan.trungsinh)) {
                    Service.send_box_ThongBao_OK(p, "B\u0103ng \u0111\u1ea7y \u0111\u1ee7 ng\u01b0\u1eddi r\u1ed3i");
                } else {
                    boolean checkCoMat = false;
                    for (int i11 = 0; i11 < p.clan.members.size(); ++i11) {
                        if (!p.clan.members.get((int)i11).name.equals(mem.name)) continue;
                        checkCoMat = true;
                        break;
                    }
                    if (!checkCoMat) {
                        int i12;
                        Player p0 = Map.get_player_by_name_allmap(mem.name);
                        if (p0 != null) {
                            p0.clan = p.clan;
                            mem.id = (short)Clan_member.get_id(p0.clan.members);
                            p.clan.members.add(mem);
                            Clan.send_info(p0, false);
                            for (i12 = 0; i12 < p.map.players.size(); ++i12) {
                                if (p.map.players.get(i12).equals(p0)) continue;
                                Clan.send_me_to_other(p0, p.map.players.get(i12), false);
                            }
                            Service.send_box_ThongBao_OK(p0, "Tham gia b\u0103ng h\u1ea3i t\u1eb7c " + p.clan.name + " th\u00e0nh c\u00f4ng");
                        }
                        for (i12 = 0; i12 < p.clan.members.size(); ++i12) {
                            Player p0ther = Map.get_player_by_name_allmap(p.clan.members.get((int)i12).name);
                            if (p0ther == null) continue;
                            Clan.update_list_member(p0ther, false);
                            Clan.send_info(p0ther, false);
                        }
                    } else {
                        Service.send_box_ThongBao_OK(p, "\u0110\u00e3 c\u00f3 m\u1eb7t trong b\u0103ng");
                    }
                }
                p.clan.mem_request.remove(mem);
                break;
            }
            case 16: {
                int i;
                Clan_member mem;
                Clan_member clan_mem = null;
                for (int i13 = 0; i13 < p.clan.members.size(); ++i13) {
                    if (!p.clan.members.get((int)i13).name.equals(p.name)) continue;
                    clan_mem = p.clan.members.get(i13);
                    break;
                }
                if (clan_mem == null || clan_mem.levelInclan < 0 || clan_mem.levelInclan > 2) break;
                m2.reader().readUTF();
                int id = m2.reader().readInt();
                Clan_chat clan_chat = null;
                for (int i14 = 0; i14 < p.clan.chat.size(); ++i14) {
                    if (p.clan.chat.get((int)i14).idChat != id) continue;
                    clan_chat = p.clan.chat.get(i14);
                    break;
                }
                if (clan_chat == null || (mem = p.clan.get_mem_request(clan_chat.str.replace(" xin v\u00e0o b\u0103ng", ""))) == null) break;
                ArrayList<Clan_chat> list_remove = new ArrayList<Clan_chat>();
                for (i = 0; i < p.clan.chat.size(); ++i) {
                    if (!p.clan.chat.get((int)i).str.equals(clan_chat.str)) continue;
                    list_remove.add(p.clan.chat.get(i));
                }
                for (i = 0; i < list_remove.size(); ++i) {
                    for (int j = 0; j < p.clan.members.size(); ++j) {
                        Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)j).name);
                        if (p0 == null) continue;
                        p.clan.remove_chat(p0, ((Clan_chat)list_remove.get((int)i)).idChat);
                    }
                }
                p.clan.chat.removeAll(list_remove);
                p.clan.mem_request.remove(mem);
                break;
            }
            case 9: {
                Clan.set_data(p, false);
                Clan.send_Attri(p, false);
                Clan.update_list_member(p, false);
                for (int i = 0; i < p.clan.chat.size(); ++i) {
                    p.clan.send_chat(p.clan.chat.get(i), p);
                }
                break;
            }
            case 11: {
                int id = m2.reader().readInt();
                Clan clan = Clan.get_clan_by_id(id);
                if (clan == null) break;
                if (clan.allowRequest == 0) {
                    Service.send_box_ThongBao_OK(p, "B\u0103ng n\u00e0y \u0111\u00e3 \u0111\u1ea7y \u0111\u1ee7 ng\u01b0\u1eddi");
                    break;
                }
                boolean check = true;
                String request_chat = p.name + " xin v\u00e0o b\u0103ng";
                long time = 0L;
                for (int i = 0; i < clan.chat.size(); ++i) {
                    if (clan.chat.get((int)i).typeChat != 1 || !clan.chat.get((int)i).str.equals(request_chat) || System.currentTimeMillis() - clan.chat.get((int)i).time >= 0L) continue;
                    time = 600000L - (System.currentTimeMillis() - clan.chat.get((int)i).time);
                    check = false;
                    break;
                }
                if (check) {
                    Clan_member mem = null;
                    for (int i = 0; i < clan.mem_request.size(); ++i) {
                        if (!clan.mem_request.get((int)i).name.equals(p.name)) continue;
                        mem = clan.mem_request.get(i);
                        break;
                    }
                    if (mem == null) {
                        mem = new Clan_member();
                        mem.name = p.name;
                        mem.conghien = 0;
                        mem.donate = 0;
                        mem.gopRuby = (short)32000;
                        mem.numquest = (short)3;
                        mem.id = 0;
                        mem.hair = (short)p.get_hair();
                        mem.head = (short)p.get_head();
                        mem.hat = p.get_hat();
                        mem.level = p.level;
                        mem.levelInclan = (byte)10;
                        mem.clazz = p.clazz;
                        clan.mem_request.add(mem);
                    }
                    Clan_chat chat = new Clan_chat();
                    chat.idMem = clan.members.get((int)0).id;
                    chat.name = clan.members.get((int)0).name;
                    chat.str = request_chat;
                    chat.time = System.currentTimeMillis();
                    chat.typeChat = 1;
                    clan.add_chat(chat);
                    clan.send_chat(chat, null);
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Xin v\u00e0o sau " + time / 1000L + "s n\u1eefa");
                break;
            }
            case 10: {
                int id = m2.reader().readInt();
                Player p0 = p.map.get_player_by_id_inmap(id);
                if (p0 != null) {
                    Message m = new Message(-52);
                    m.writer().writeByte(7);
                    m.writer().writeInt(p.index_map);
                    m.writer().writeUTF(p.name);
                    p0.conn.addmsg(m);
                    m.cleanup();
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Nh\u00e2n v\u1eadt hi\u1ec7n \u0111ang offline ho\u1eb7c kh\u00f4ng \u1edf trong map");
                break;
            }
            case 12: {
                if (p.clan != null) {
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111ang \u1edf trong 1 b\u0103ng h\u1ea3i t\u1eb7c kh\u00e1c");
                    break;
                }
                int id = m2.reader().readInt();
                Player p0 = p.map.get_player_by_id_inmap(id);
                if (p0 != null && p0.clan != null) {
                    if (p0.clan.members.size() >= Clan.get_mem_max(p0.clan.level, p0.clan.trungsinh)) {
                        Service.send_box_ThongBao_OK(p, "B\u0103ng h\u1ea3i t\u1eb7c \u0111\u00e3 n\u00e0y \u0111\u1ee7 ng\u01b0\u1eddi");
                        break;
                    }
                    Clan_member clan_mem = null;
                    for (int i = 0; i < p0.clan.members.size(); ++i) {
                        if (!p0.clan.members.get((int)i).name.equals(p0.name)) continue;
                        clan_mem = p0.clan.members.get(i);
                        break;
                    }
                    if (clan_mem != null && clan_mem.levelInclan >= 0 && clan_mem.levelInclan <= 2) {
                        int num_clazz = 0;
                        for (int j = 0; j < p0.clan.members.size(); ++j) {
                            if (p0.clan.members.get((int)j).clazz != p.clazz) continue;
                            ++num_clazz;
                        }
                        if (num_clazz >= 4) {
                            Service.send_box_ThongBao_OK(p, "B\u0103ng \u0111\u00e3 \u0111\u1ea7y \u0111\u1ee7 4/4 " + Clazz.NAME[p.clazz - 1]);
                            return;
                        }
                        boolean checkCoMat = false;
                        for (int i = 0; i < p0.clan.members.size(); ++i) {
                            if (!p0.clan.members.get((int)i).name.equals(p.name)) continue;
                            checkCoMat = true;
                            break;
                        }
                        if (!checkCoMat) {
                            int i;
                            p.clan = p0.clan;
                            Clan_member mem = new Clan_member();
                            mem.name = p.name;
                            mem.conghien = 0;
                            mem.donate = 0;
                            mem.gopRuby = (short)32000;
                            mem.numquest = (short)3;
                            mem.id = (short)Clan_member.get_id(p0.clan.members);
                            mem.hair = (short)p.get_hair();
                            mem.head = (short)p.get_head();
                            mem.hat = p.get_hat();
                            mem.level = p.level;
                            mem.levelInclan = (byte)10;
                            mem.clazz = p.clazz;
                            p0.clan.members.add(mem);
                            Clan.send_info(p, false);
                            for (i = 0; i < p.map.players.size(); ++i) {
                                if (p.map.players.get(i).equals(p)) continue;
                                Clan.send_me_to_other(p, p.map.players.get(i), false);
                            }
                            for (i = 0; i < p0.clan.members.size(); ++i) {
                                Player p0ther;
                                if (p0.clan.members.get((int)i).name.equals(p.name) || (p0ther = Map.get_player_by_name_allmap(p0.clan.members.get((int)i).name)) == null) continue;
                                Clan.update_list_member(p0ther, false);
                                Clan.send_info(p0ther, false);
                            }
                            Service.send_box_ThongBao_OK(p, "Tham gia b\u0103ng h\u1ea3i t\u1eb7c " + p0.clan.name + " th\u00e0nh c\u00f4ng");
                            break;
                        }
                        Service.send_box_ThongBao_OK(p, "\u0110\u00e3 c\u00f3 m\u1eb7t trong b\u0103ng");
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng kh\u00f4ng ph\u1ea3i l\u00e0 \u0111\u1ed9i tr\u01b0\u1edfng");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Nh\u00e2n v\u1eadt hi\u1ec7n \u0111ang offline ho\u1eb7c kh\u00f4ng \u1edf trong map");
            }
        }
    }

    private void remove_chat(Player p, int idChat) throws IOException {
        Message m = new Message(-52);
        m.writer().writeByte(11);
        m.writer().writeShort(idChat);
        p.conn.addmsg(m);
        m.cleanup();
    }

    private Clan_member get_mem_request(String str) {
        for (int i = 0; i < this.mem_request.size(); ++i) {
            if (!this.mem_request.get((int)i).name.equals(str)) continue;
            return this.mem_request.get(i);
        }
        return null;
    }

    private static void send_notice(Player p, boolean b) throws IOException {
        if (p.conn != null) {
            Message m = new Message(-52);
            m.writer().writeByte(14);
            m.writer().writeUTF(p.clan.thongbao);
            if (b) {
                p.list_msg_cache.add(m);
            } else {
                p.conn.addmsg(m);
            }
            m.cleanup();
        }
    }

    private void send_chat(Clan_chat chat, Player p) throws IOException {
        for (int i = 0; i < this.members.size(); ++i) {
            Player p0 = Map.get_player_by_name_allmap(this.members.get((int)i).name);
            if (p0 == null || p != null && !p0.equals(p)) continue;
            Message m = new Message(-52);
            m.writer().writeByte(8);
            m.writer().writeByte(chat.typeChat);
            m.writer().writeShort(chat.idChat);
            m.writer().writeShort(chat.idMem);
            m.writer().writeUTF(chat.name);
            m.writer().writeUTF(chat.str);
            m.writer().writeLong(chat.time);
            p0.conn.addmsg(m);
            m.cleanup();
        }
    }

    private synchronized void add_chat(Clan_chat chat) {
        int id_get = 0;
        for (int i = 0; i < this.chat.size(); ++i) {
            id_get = Math.max(id_get, this.chat.get((int)i).idChat);
        }
        chat.idChat = id_get + 1;
        this.chat.add(chat);
    }

    public static void set_data(Player p, boolean b) throws IOException {
        if (p.clan != null) {
            Message m = new Message(-52);
            m.writer().writeByte(2);
            m.writer().writeShort(p.clan.icon);
            m.writer().writeUTF(p.clan.members.get((int)0).name);
            m.writer().writeShort(p.clan.level);
            m.writer().writeInt(p.clan.xp);
            m.writer().writeInt(Clan.get_xp_max(p.clan.level, p.clan.trungsinh));
            m.writer().writeByte(p.clan.members.size());
            m.writer().writeByte(Clan.get_mem_max(p.clan.level, p.clan.trungsinh));
            m.writer().writeInt(Clan.get_rank(p.clan));
            m.writer().writeUTF(p.clan.thongbao);
            m.writer().writeByte(p.clan.trungsinh);
            m.writer().writeInt(p.clan.countAction);
            if (b) {
                p.list_msg_cache.add(m);
            } else {
                p.conn.addmsg(m);
            }
            m.cleanup();
        }
    }

    private static int get_mem_max(short level, int trungsinh) {
        int max = 10;
        if (trungsinh == 0) {
            if (level == 1) {
                max = 5;
            } else if (level == 2) {
                max = 6;
            } else if (level == 3) {
                max = 7;
            } else if (level == 4) {
                max = 8;
            } else if (level == 5) {
                max = 9;
            }
        } else {
            max += trungsinh;
        }
        if (max > 13) {
            max = 13;
        }
        return max;
    }

    public static void update_list_member(Player p, boolean b) throws IOException {
        if (p.clan != null) {
            int ver_ = Integer.parseInt(p.conn.version.replace(".", ""));
            Message m = new Message(-52);
            m.writer().writeByte(3);
            m.writer().writeByte(p.clan.members.size());
            for (int i = 0; i < p.clan.members.size(); ++i) {
                Clan_member mem = p.clan.members.get(i);
                Player p0 = Map.get_player_by_name_allmap(mem.name);
                if (p0 != null) {
                    mem.head = (short)p0.get_head();
                    mem.hair = (short)p0.get_hair();
                    mem.hat = p0.get_hat();
                    mem.name = p0.name;
                    mem.level = p0.level;
                }
                m.writer().writeShort(mem.id);
                m.writer().writeUTF(mem.name);
                m.writer().writeShort(mem.level);
                m.writer().writeByte(mem.levelInclan);
                m.writer().writeShort(mem.donate);
                m.writer().writeShort(mem.gopRuby);
                m.writer().writeShort(mem.numquest);
                if (ver_ >= 111) {
                    m.writer().writeInt(mem.conghien);
                }
                m.writer().writeShort(mem.head);
                m.writer().writeShort(mem.hair);
                m.writer().writeShort(mem.hat);
                m.writer().writeByte(p0 != null ? 1 : 0);
            }
            if (b) {
                p.list_msg_cache.add(m);
            } else {
                p.conn.addmsg(m);
            }
            m.cleanup();
        }
    }

    private static void send_Attri(Player p, boolean b) throws IOException {
        Message m = new Message(-52);
        m.writer().writeByte(4);
        m.writer().writeShort(p.clan.maxAttri);
        m.writer().writeShort(p.clan.pointAttri);
        for (int i = 0; i < 5; ++i) {
            m.writer().writeShort(p.clan.opAttri[i] + Clan.get_point_trungsinh_plus(p.clan));
        }
        if (b) {
            p.list_msg_cache.add(m);
        } else {
            p.conn.addmsg(m);
        }
        m.cleanup();
    }

    public static int get_point_trungsinh_plus(Clan clan) {
        return clan.trungsinh * 4;
    }

    private static int get_rank(Clan clan) {
        for (int i = 0; i < BXH.size(); ++i) {
            if (!BXH.get(i).equals(clan.name)) continue;
            return i + 1;
        }
        return 9999;
    }

    public static synchronized int get_clan_id() {
        int result = -1;
        for (int i = 0; i < ENTRY.size(); ++i) {
            result = Math.max(result, Clan.ENTRY.get((int)i).id);
        }
        return ++result;
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public static boolean create_new_clan(Clan clan) {
        Connection connection = null;
        PreparedStatement ps = null;
        try {
            int i;
            connection = SQL.gI().getCon();
            ps = connection.prepareStatement("INSERT INTO `clan` (`id`, `name`, `info`, `notice`, `member`, `item`, `xp`, `buff`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)");
            ps.clearParameters();
            ps.setInt(1, clan.id);
            ps.setNString(2, clan.name);
            JSONArray js = new JSONArray();
            js.add(clan.icon);
            js.add(clan.level);
            js.add(clan.xp);
            js.add(clan.maxAttri);
            js.add(clan.pointAttri);
            js.add(clan.trungsinh);
            js.add(clan.countAction);
            js.add(clan.ruby);
            js.add(clan.beri);
            js.add(clan.allowRequest);
            JSONArray js2 = new JSONArray();
            for (i = 0; i < clan.opAttri.length; ++i) {
                js2.add(clan.opAttri[i]);
            }
            js.add(js2);
            ps.setNString(3, js.toJSONString());
            js.clear();
            js2.clear();
            ps.setNString(4, clan.thongbao);
            for (i = 0; i < clan.members.size(); ++i) {
                JSONArray js_in = new JSONArray();
                Clan_member mem = clan.members.get(i);
                js_in.add(mem.name);
                js_in.add(mem.level);
                js_in.add(mem.levelInclan);
                js_in.add(mem.donate);
                js_in.add(mem.gopRuby);
                js_in.add(mem.numquest);
                js_in.add(mem.conghien);
                js_in.add(mem.head);
                js_in.add(mem.hair);
                js_in.add(mem.hat);
                js_in.add(mem.clazz);
                js.add(js_in);
            }
            ps.setNString(5, js.toJSONString());
            ps.setNString(6, "[]");
            ps.setLong(7, 0L);
            ps.setNString(8, "[]");
            js.clear();
            ps.executeUpdate();
        }
        catch (SQLException e) {
            boolean bl = false;
            return bl;
        }
        finally {
            try {
                if (ps != null) {
                    ps.close();
                }
                if (connection != null) {
                    connection.close();
                }
            }
            catch (SQLException e) {
                e.printStackTrace();
            }
        }
        Clan.add_new_clan(clan);
        return true;
    }

    public static synchronized void add_new_clan(Clan clan) {
        ENTRY.add(clan);
    }

    public static synchronized void delete_clan(Clan clan) {
        ENTRY.remove(clan);
    }

    public static int get_xp_max(int level, int ts) {
        return 10000 * level;
    }

    private static int get_ngoc_upgrade(short level, int trungsinh) {
        return 100 * level;
    }

    private static int get_vang_upgrade(short level) {
        return level * 5000;
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public static synchronized void update() {
        Connection connection = null;
        PreparedStatement ps = null;
        try {
            connection = SQL.gI().getCon();
            ps = connection.prepareStatement("UPDATE `clan` SET `info` = ?, `member` = ?, item = ?, `xp` = ?, `buff` = ? WHERE `id` = ?");
            for (int i = 0; i < ENTRY.size(); ++i) {
                int j;
                JSONArray js_in;
                int i2;
                Clan clan = ENTRY.get(i);
                ps.clearParameters();
                JSONArray js = new JSONArray();
                js.add(clan.icon);
                js.add(clan.level);
                js.add(clan.xp);
                js.add(clan.maxAttri);
                js.add(clan.pointAttri);
                js.add(clan.trungsinh);
                js.add(clan.countAction);
                js.add(clan.ruby);
                js.add(clan.beri);
                js.add(clan.allowRequest);
                JSONArray js2 = new JSONArray();
                for (i2 = 0; i2 < clan.opAttri.length; ++i2) {
                    js2.add(clan.opAttri[i2]);
                }
                js.add(js2);
                ps.setNString(1, js.toJSONString());
                js.clear();
                for (i2 = 0; i2 < clan.members.size(); ++i2) {
                    js_in = new JSONArray();
                    Clan_member mem = clan.members.get(i2);
                    js_in.add(mem.name);
                    js_in.add(mem.level);
                    js_in.add(mem.levelInclan);
                    js_in.add(mem.donate);
                    js_in.add(mem.gopRuby);
                    js_in.add(mem.numquest);
                    js_in.add(mem.conghien);
                    js_in.add(mem.head);
                    js_in.add(mem.hair);
                    js_in.add(mem.hat);
                    js_in.add(mem.clazz);
                    js.add(js_in);
                }
                ps.setNString(2, js.toJSONString());
                js.clear();
                for (int j2 = 0; j2 < clan.list_it.size(); ++j2) {
                    js_in = new JSONArray();
                    js_in.add(clan.list_it.get((int)j2).id);
                    js_in.add(clan.list_it.get((int)j2).quant);
                    js.add(js_in);
                }
                ps.setNString(3, js.toJSONString());
                js.clear();
                long xp_total = clan.xp;
                if (xp_total > (long)Clan.get_xp_max(clan.level, clan.trungsinh)) {
                    xp_total = Clan.get_xp_max(clan.level, clan.trungsinh);
                }
                for (j = 1; j < clan.level; ++j) {
                    xp_total += (long)Clan.get_xp_max(j, clan.trungsinh);
                }
                ps.setLong(4, xp_total += (long)(2400000 * clan.trungsinh));
                for (j = 0; j < clan.buff.size(); ++j) {
                    JSONArray js_in2 = new JSONArray();
                    js_in2.add(clan.buff.get((int)j).id);
                    js_in2.add(clan.buff.get((int)j).param);
                    js_in2.add(clan.buff.get((int)j).time);
                    js.add(js_in2);
                }
                ps.setNString(5, js.toJSONString());
                js.clear();
                ps.setInt(6, clan.id);
                ps.executeUpdate();
            }
        }
        catch (SQLException e) {
            e.printStackTrace();
        }
        finally {
            try {
                if (ps != null) {
                    ps.close();
                }
                if (connection != null) {
                    connection.close();
                }
            }
            catch (SQLException e) {
                e.printStackTrace();
            }
        }
        BXH.clear();
        connection = null;
        ps = null;
        ResultSet rs = null;
        try {
            connection = SQL.gI().getCon();
            ps = connection.prepareStatement("SELECT `name` FROM `clan` ORDER BY `xp` DESC");
            rs = ps.executeQuery();
            while (rs.next()) {
                BXH.add(rs.getString("name"));
            }
        }
        catch (SQLException e) {
            e.printStackTrace();
        }
        finally {
            try {
                if (rs != null) {
                    rs.close();
                }
                if (ps != null) {
                    ps.close();
                }
                if (connection != null) {
                    connection.close();
                }
            }
            catch (SQLException e) {
                e.printStackTrace();
            }
        }
        connection = null;
        ps = null;
        try {
            connection = SQL.gI().getCon();
            ps = connection.prepareStatement("UPDATE `clan` SET `notice` = ? WHERE `id` = ?");
            for (int i = 0; i < ENTRY.size(); ++i) {
                Clan clan = ENTRY.get(i);
                ps.clearParameters();
                ps.setNString(1, clan.thongbao);
                ps.setInt(2, clan.id);
                ps.executeUpdate();
            }
        }
        catch (SQLException e) {
            e.printStackTrace();
        }
        finally {
            try {
                if (ps != null) {
                    ps.close();
                }
                if (connection != null) {
                    connection.close();
                }
            }
            catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }

    public static int get_ngoc_icon(short id) {
        int result = 50;
        if (id >= 293 && id < 370) {
            result = 200;
        }
        return result;
    }

    public synchronized void update_xp(int num) {
        this.xp += num;
    }

    public synchronized void update_beri(long num) {
        if (num + (long)this.beri <= 2000000000L) {
            this.beri = (int)((long)this.beri + num);
        }
    }

    public synchronized void update_ruby(long num) {
        if (num + (long)this.ruby <= 2000000000L) {
            this.ruby = (int)((long)this.ruby + num);
        }
    }

    public void send_inventory(Player p, boolean b) throws IOException {
        Message m = new Message(-52);
        m.writer().writeByte(19);
        m.writer().writeByte(0);
        m.writer().writeByte(8);
        m.writer().writeByte(p.clan.list_it.size());
        for (int i = 0; i < p.clan.list_it.size(); ++i) {
            m.writer().writeShort(p.clan.list_it.get((int)i).id);
            m.writer().writeShort(p.clan.list_it.get((int)i).quant);
        }
        if (b) {
            p.list_msg_cache.add(m);
        } else {
            p.conn.addmsg(m);
        }
        m.cleanup();
    }

    public boolean check_buff(int i) {
        for (int j = 0; j < this.buff.size(); ++j) {
            if (this.buff.get((int)j).id != i || this.buff.get((int)j).time <= System.currentTimeMillis()) continue;
            return true;
        }
        return false;
    }

    public void chat_on_board(short id, String name, String s, int typeChat) throws IOException {
        Clan_chat chat = new Clan_chat();
        chat.idMem = id;
        chat.name = name;
        chat.str = s;
        chat.time = System.currentTimeMillis();
        chat.typeChat = (byte)typeChat;
        this.add_chat(chat);
        this.send_chat(chat, null);
    }
}

