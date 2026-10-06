/*
 * Decompiled with CFR 0.152.
 */
package client;

import client.Clan;
import client.Player;
import core.Manager;
import core.Service;
import core.Util;
import database.SQL;
import io.Message;
import java.io.IOException;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.regex.Pattern;
import map.Map;
import template.Clan_chat;
import template.Clan_member;
import template.EffTemplate;
import template.GiftTemplate;
import template.ItemBag47;
import template.ItemFashion;
import template.ItemFashionP;
import template.ItemFashionP2;
import template.ItemHair;
import template.ItemTemplate3;
import template.ItemTemplate4;
import template.ItemTemplate7;
import template.ItemTemplate8;
import template.Item_wear;
import template.Level;

public class ClientInput {
    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public static void process(Player p, Message m2) throws IOException {
        short id = m2.reader().readShort();
        String[] name = new String[m2.reader().readByte()];
        for (int i = 0; i < name.length; ++i) {
            name[i] = m2.reader().readUTF();
        }
        switch (id) {
            case 11: {
                if (name.length != 1) break;
                if (!Util.isnumber(name[0])) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                long value = Integer.parseInt(name[0]);
                if (value <= 0L) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                if (p.clan == null) break;
                if (value > 2000000000L || value + (long)p.clan.get_ngoc() > 2000000000L) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 d\u01b0 qu\u00e1 l\u1edbn, h\u00e3y th\u1eed l\u1ea1i sau");
                    return;
                }
                if ((long)p.get_ngoc() < value) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 " + value + " ruby");
                    return;
                }
                p.update_ngoc(-value);
                p.update_money();
                p.clan.update_ruby((int)value);
                for (int i = 0; i < p.clan.members.size(); ++i) {
                    Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i).name);
                    if (p0 == null) continue;
                    Clan.send_info(p0, false);
                }
                Service.send_box_ThongBao_OK(p, "G\u00f3p " + value + " ruby v\u00e0o qu\u1ef9 b\u0103ng th\u00e0nh c\u00f4ng");
                break;
            }
            case 10: {
                if (name.length != 1) break;
                if (name[0].length() < 3) {
                    Service.send_box_ThongBao_OK(p, "T\u00ean b\u0103ng n\u00ean nhi\u1ec1u h\u01a1n 3 k\u00fd t\u1ef1");
                    return;
                }
                if (p.get_ngoc() < 2000) {
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng \u0111\u1ee7 2000 ruby");
                    return;
                }
                if (Clan.get_clan_by_name(name[0]) != null) {
                    Service.send_box_ThongBao_OK(p, "T\u00ean b\u0103ng n\u00e0y \u0111\u00e3 \u0111\u01b0\u1ee3c s\u1eed d\u1ee5ng, h\u00e3y s\u1eed d\u1ee5ng t\u00ean kh\u00e1c");
                    return;
                }
                Clan clan = new Clan();
                clan.id = (short)Clan.get_clan_id();
                clan.name = name[0];
                clan.opAttri = new short[]{0, 0, 0, 0, 0};
                clan.pointAttri = (short)2;
                clan.maxAttri = (short)20;
                clan.icon = 0;
                clan.level = 1;
                clan.xp = 0;
                clan.thongbao = "";
                clan.trungsinh = 0;
                clan.countAction = 0;
                clan.allowRequest = 1;
                clan.chat = new ArrayList<Clan_chat>();
                clan.mem_request = new ArrayList<Clan_member>();
                clan.list_it = new ArrayList<ItemBag47>();
                clan.buff = new ArrayList<EffTemplate>();
                clan.members = new ArrayList<Clan_member>();
                Clan_member mem = new Clan_member();
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
                mem.levelInclan = 0;
                mem.clazz = p.clazz;
                clan.members.add(mem);
                if (Clan.create_new_clan(clan)) {
                    p.update_ngoc(-2000L);
                    p.update_money();
                    p.clan = clan;
                    Clan.send_info(p, false);
                    for (int i = 0; i < p.map.players.size(); ++i) {
                        if (p.map.players.get(i).equals(p)) continue;
                        Clan.send_me_to_other(p, p.map.players.get(i), false);
                    }
                    Message m = new Message(-19);
                    m.writer().writeByte(98);
                    m.writer().writeUTF("C\u1eeda h\u00e0ng bi\u1ec3u t\u01b0\u1ee3ng");
                    m.writer().writeByte(107);
                    m.writer().writeShort(10);
                    for (int i = 0; i < 10; ++i) {
                        m.writer().writeShort(i);
                        m.writer().writeShort(i);
                        m.writer().writeUTF("Huy hi\u1ec7u " + (i + 1));
                        m.writer().writeUTF("\u0110\u01b0\u1ee3c l\u00e0m t\u1eeb g\u00ec \u0111\u1ea5y kh\u00f4ng bi\u1ebft n\u1eefa, mua \u0111eo v\u00e0o r\u1ea5t \u0111\u1eb9p");
                        m.writer().writeShort(0);
                    }
                    p.conn.addmsg(m);
                    m.cleanup();
                    break;
                }
                Service.send_box_ThongBao_OK(p, "T\u00ean b\u0103ng n\u00e0y \u0111\u00e3 \u0111\u01b0\u1ee3c s\u1eed d\u1ee5ng, h\u00e3y th\u1eed l\u1ea1i t\u00ean kh\u00e1c");
                break;
            }
            case 7: {
                if (name.length != 1 || p.data_yesno == null || p.data_yesno.length != 3) break;
                if (!Util.isnumber(name[0])) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                int value = Integer.parseInt(name[0]);
                if (value < 20000 || value > 1000000000) {
                    Service.send_box_ThongBao_OK(p, "M\u1ee9c gi\u00e1 b\u00e1n t\u1ed1i thi\u1ec3u l\u00e0 20.000 Extol v\u00e0 t\u1ed1i \u0111a l\u00e0 1.000.000.000 Extol");
                    return;
                }
                int type = p.data_yesno[0];
                int id_ = p.data_yesno[1];
                int value_ = p.data_yesno[2];
                p.data_yesno = new int[]{type, id_, value_, value};
                if (type == 4) {
                    Service.send_box_yesno(p, 22, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 mu\u1ed1n b\u00e1n " + value_ + " " + ItemTemplate4.get_item_name(id_) + " v\u1edbi gi\u00e1 " + Util.number_format(value) + " Extol? Ph\u00ed \u0111\u1ec3 \u0111\u0103ng b\u00e1n l\u00e0 2.000 Extol", new String[]{"2.000 Extol", "Kh\u00f4ng"}, new byte[]{-1, -1});
                    break;
                }
                if (type != 7) break;
                Service.send_box_yesno(p, 22, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 mu\u1ed1n b\u00e1n " + value_ + " " + ItemTemplate7.get_item_name(id_) + " v\u1edbi gi\u00e1 " + Util.number_format(value) + " Extol? Ph\u00ed \u0111\u1ec3 \u0111\u0103ng b\u00e1n l\u00e0 2.000 Extol", new String[]{"2.000 Extol", "Kh\u00f4ng"}, new byte[]{-1, -1});
                break;
            }
            case 6: {
                if (name.length != 1 || p.data_yesno == null || p.data_yesno.length != 1) break;
                if (!Util.isnumber(name[0])) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                int value = Integer.parseInt(name[0]);
                if (value < 20000 || value > 1000000000) {
                    Service.send_box_ThongBao_OK(p, "M\u1ee9c gi\u00e1 b\u00e1n t\u1ed1i thi\u1ec3u l\u00e0 20.000 Extol v\u00e0 t\u1ed1i \u0111a l\u00e0 1.000.000.000 Extol");
                    return;
                }
                int price = p.data_yesno[0];
                p.data_yesno = new int[]{price, value};
                Service.send_box_yesno(p, 18, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 mu\u1ed1n b\u00e1n " + price + " tri\u1ec7u beri v\u1edbi gi\u00e1 " + Util.number_format(value) + " Extol? Ph\u00ed \u0111\u1ec3 \u0111\u0103ng b\u00e1n l\u00e0 2.000 Extol", new String[]{"2.000 Extol", "Kh\u00f4ng"}, new byte[]{-1, -1});
                break;
            }
            case 5: {
                if (name.length != 1 || p.data_yesno == null) break;
                if (!Util.isnumber(name[0])) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                int value = Integer.parseInt(name[0]);
                if (value < 20000 || value > 1000000000) {
                    Service.send_box_ThongBao_OK(p, "M\u1ee9c gi\u00e1 b\u00e1n t\u1ed1i thi\u1ec3u l\u00e0 20.000 Extol v\u00e0 t\u1ed1i \u0111a l\u00e0 1.000.000.000 Extol");
                    return;
                }
                Item_wear it_select = p.item.bag3[p.data_yesno[0]];
                if (it_select == null) break;
                p.data_yesno = new int[]{it_select.index, value};
                Service.send_box_yesno(p, 17, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 mu\u1ed1n b\u00e1n v\u1eadt ph\u1ea9m " + it_select.template.name + " v\u1edbi gi\u00e1 " + Util.number_format(value) + " Extol? Ph\u00ed \u0111\u1ec3 \u0111\u0103ng b\u00e1n l\u00e0 2.000 Extol", new String[]{"2.000 Extol", "Kh\u00f4ng"}, new byte[]{-1, -1});
                break;
            }
            case 4: {
                if (name.length != 1 || p.data_yesno != null) break;
                if (!Util.isnumber(name[0])) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                long value = Long.parseLong(name[0]) * 1000L;
                if (value <= 0L) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                if ((long)p.get_vnd() < value) {
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng \u0111\u1ee7 " + Util.number_format(value) + " extol");
                    return;
                }
                int ruby = (int)(value / 1000L);
                p.data_yesno = new int[]{ruby};
                Service.send_box_yesno(p, 9, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 th\u1eadt s\u1ef1 mu\u1ed1n \u0111\u1ed5i " + Util.number_format(value) + " Extol \u0111\u1ec3 \u0111\u1ed5i l\u1ea5y " + Util.number_format(ruby) + " Ruby kh\u00f4ng?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, 1});
                break;
            }
            case 8: {
                if (name.length != 1 || p.data_yesno != null) break;
                if (!Util.isnumber(name[0])) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                long value = Long.parseLong(name[0]) * 5L;
                if (value <= 0L) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                if ((long)p.conn.coin < value) {
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng \u0111\u1ee7 " + Util.number_format(value) + " coin");
                    return;
                }
                int ruby = (int)(value / 5L);
                p.data_yesno = new int[]{ruby};
                Service.send_box_yesno(p, 60, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 th\u1eadt s\u1ef1 mu\u1ed1n \u0111\u1ed5i " + Util.number_format(value) + " Coin \u0111\u1ec3 \u0111\u1ed5i l\u1ea5y " + Util.number_format(ruby) + " Ruby kh\u00f4ng?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, 1});
                break;
            }
            case 9: {
                if (name.length != 1 || p.data_yesno != null) break;
                if (!Util.isnumber(name[0])) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                long value = Long.parseLong(name[0]) / 5000L;
                if (value <= 0L) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                if ((long)p.conn.coin < value) {
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng \u0111\u1ee7 " + Util.number_format(value) + " coin");
                    return;
                }
                int beri = (int)(value * 5000L);
                p.data_yesno = new int[]{beri};
                Service.send_box_yesno(p, 61, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 th\u1eadt s\u1ef1 mu\u1ed1n \u0111\u1ed5i " + Util.number_format(value) + " Coin \u0111\u1ec3 \u0111\u1ed5i l\u1ea5y " + Util.number_format(beri) + " Beri kh\u00f4ng?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, 1});
                break;
            }
            case 2: {
                if (name.length != 2) break;
                name[0] = name[0].replace(" ", "");
                name[1] = name[1].replace(" ", "");
                name[0] = name[0].toLowerCase();
                name[1] = name[1].toLowerCase();
                if (name[0].contains("admin") || name[1].contains("admin")) {
                    Service.send_box_ThongBao_OK(p, "T\u00ean t\u00e0i kho\u1ea3n v\u00e0 m\u1eadt kh\u1ea9u kh\u00f4ng \u0111\u01b0\u1ee3c tr\u00f9ng admin!");
                    return;
                }
                Pattern pat = Pattern.compile("^[a-zA-Z0-9@.]{1,30}$");
                if (!pat.matcher(name[0]).matches() || !pat.matcher(name[1]).matches()) {
                    Service.send_box_ThongBao_OK(p, "T\u00ean t\u00e0i kho\u1ea3n v\u00e0 m\u1eadt kh\u1ea9u ph\u1ea3i d\u00e0i h\u01a1n 6 v\u00e0 kh\u00f4ng ch\u1ee9a k\u00fd t\u1ef1 \u0111\u1eb7c bi\u1ec7t!");
                    return;
                }
                Connection conn = null;
                Statement st = null;
                try {
                    conn = SQL.gI().getCon();
                    st = conn.createStatement();
                    st.executeUpdate("UPDATE `accounts` SET `user` = '" + name[0] + "', `pass` = '" + name[1] + "' WHERE BINARY `user` = '" + p.conn.user + "' AND BINARY `pass` = '" + p.conn.pass + "' LIMIT 1;");
                }
                catch (SQLException e) {
                    Service.send_box_ThongBao_OK(p, "T\u00ean \u0111\u00e3 \u0111\u01b0\u1ee3c s\u1eed d\u1ee5ng, h\u00e3y th\u1eed l\u1ea1i!");
                    return;
                }
                finally {
                    try {
                        if (st != null) {
                            st.close();
                        }
                        if (conn != null) {
                            conn.close();
                        }
                    }
                    catch (SQLException e) {
                        e.printStackTrace();
                    }
                }
                p.conn.user = name[0];
                p.conn.pass = name[1];
                Message m = new Message(-59);
                m.writer().writeUTF(name[0]);
                m.writer().writeUTF(name[1]);
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 1: {
                if (p.conn.status != 1) {
                    Service.send_box_ThongBao_OK(p, "Ch\u01b0a K\u00edch ho\u1ea1t kh\u00f4ng th\u1ec3 nh\u1eadn Giftcode");
                    return;
                }
                if (name.length != 1) break;
                Pattern pattern = Pattern.compile("^[a-zA-Z0-9]{1,20}$");
                if (!pattern.matcher(name[0]).matches()) {
                    Service.send_box_ThongBao_OK(p, "K\u00fd t\u1ef1 kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                Service.send_box_ThongBao_OK(p, "Xin h\u00e3y \u0111\u1ee3i gi\u00e2y l\u00e1t...");
                Connection conn = null;
                ResultSet rs = null;
                Statement st = null;
                GiftTemplate temp = null;
                try {
                    conn = SQL.gI().getCon();
                    st = conn.createStatement();
                    rs = st.executeQuery("SELECT * FROM `giftcode` WHERE BINARY `giftname` = '" + name[0] + "' LIMIT 1;");
                    if (!rs.next()) {
                        Service.send_box_ThongBao_OK(p, "Giftcode kh\u00f4ng t\u1ed3n t\u1ea1i ho\u1eb7c \u0111\u00e3 \u0111\u01b0\u1ee3c nh\u1eadp");
                        return;
                    }
                    temp = new GiftTemplate(rs.getString("giftname"), rs.getInt("luotnhap"), rs.getInt("gioihan"), rs.getString("thongbao"), rs.getInt("beri"), rs.getInt("ruby"), rs.getString("item"), rs.getString("used"), rs.getString("special"));
                }
                catch (SQLException e) {
                    e.printStackTrace();
                    Service.send_box_ThongBao_OK(p, "C\u00f3 l\u1ed7i x\u1ea3y ra h\u00e3y th\u1eed l\u1ea1i!");
                    return;
                }
                finally {
                    try {
                        if (rs != null) {
                            rs.close();
                        }
                        if (st != null) {
                            st.close();
                        }
                        if (conn != null) {
                            conn.close();
                        }
                    }
                    catch (SQLException e) {
                        e.printStackTrace();
                    }
                }
                if (temp == null) break;
                if (temp.luotnhap >= temp.gioihan) {
                    Service.send_box_ThongBao_OK(p, "Giftcode n\u00e0y \u0111\u00e3 \u0111\u1ea1t l\u01b0\u1ee3t nh\u1eadp t\u1ed1i \u0111a!");
                    return;
                }
                if (!temp.used.isEmpty()) {
                    String[] used_ = temp.used.split(",");
                    for (int i = 0; i < used_.length; ++i) {
                        if (used_[i].isBlank() || !used_[i].equals(p.name)) continue;
                        Service.send_box_ThongBao_OK(p, "Giftcode kh\u00f4ng t\u1ed3n t\u1ea1i ho\u1eb7c \u0111\u00e3 \u0111\u01b0\u1ee3c nh\u1eadp");
                        return;
                    }
                }
                if (!temp.special.isEmpty()) {
                    boolean can_receiv = false;
                    String[] used_ = temp.special.split(",");
                    for (int i = 0; i < used_.length; ++i) {
                        if (used_[i].isBlank() || !used_[i].equals(p.name)) continue;
                        can_receiv = true;
                        break;
                    }
                    if (!can_receiv) {
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng c\u00f3 t\u00ean trong danh s\u00e1ch nh\u1eadn giftcode n\u00e0y!");
                        return;
                    }
                }
                int requiredBagSlots = 0;
                if (temp.type != null) {
                    for (int i = 0; i < temp.type.length; ++i) {
                        if (temp.type[i] == 3 || temp.type[i] == 4 || temp.type[i] == 7) {
                            ++requiredBagSlots;
                        }
                        if (temp.type[i] == 105) {
                            ItemFashion fashion = ItemFashion.get_item(temp.id[i]);
                            if (fashion == null) {
                                Service.send_box_ThongBao_OK(p, "Giftcode c\u00f3 th\u1eddi trang kh\u00f4ng h\u1ee3p l\u1ec7 (ID " + temp.id[i] + ")");
                                return;
                            }
                            if (p.check_fashion(temp.id[i]) != null) {
                                Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 s\u1edf h\u1eefu th\u1eddi trang " + fashion.name);
                                return;
                            }
                        }
                        if (temp.type[i] == 103) {
                            ItemHair hair = ItemHair.get_item(temp.id[i], 103);
                            if (hair == null) {
                                Service.send_box_ThongBao_OK(p, "Giftcode c\u00f3 ki\u1ec3u t\u00f3c kh\u00f4ng h\u1ee3p l\u1ec7 (ID " + temp.id[i] + ")");
                                return;
                            }
                            if (p.check_itfashionP(temp.id[i], 103) != null) {
                                Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 s\u1edf h\u1eefu ki\u1ec3u t\u00f3c " + hair.name);
                                return;
                            }
                        }
                        if (temp.type[i] != 8) continue;
                        boolean validClanItem = false;
                        for (ItemTemplate8 itemTemplate8 : ItemTemplate8.ENTRYS) {
                            if (itemTemplate8.id != temp.id[i]) continue;
                            validClanItem = true;
                            break;
                        }
                        if (!validClanItem) {
                            Service.send_box_ThongBao_OK(p, "Giftcode c\u00f3 v\u1eadt ph\u1ea9m Bang kh\u00f4ng h\u1ee3p l\u1ec7 (ID " + temp.id[i] + ")");
                            return;
                        }
                        if (p.clan != null) continue;
                        Service.send_box_ThongBao_OK(p, "Giftcode c\u00f3 v\u1eadt ph\u1ea9m Bang. B\u1ea1n c\u1ea7n tham gia m\u1ed9t Bang tr\u01b0\u1edbc khi nh\u1eadn");
                        return;
                    }
                }
                if (requiredBagSlots > p.item.able_bag()) {
                    Service.send_box_ThongBao_OK(p, "\u0110\u1ec3 nh\u1eadn giftcode n\u00e0y h\u00e3y chu\u1ea9n b\u1ecb \u00edt nh\u1ea5t " + requiredBagSlots + " \u00f4 tr\u1ed1ng trong h\u00e0nh trang");
                    return;
                }
                GiftTemplate.update_used(temp, p.name);
                p.update_vang(temp.beri);
                p.update_ngoc(temp.ruby);
                p.update_money();
                if (temp.type != null) {
                    block68: for (int i = 0; i < temp.type.length; ++i) {
                        switch (temp.type[i]) {
                            case 3: {
                                Item_wear it_add = new Item_wear();
                                it_add.setup_template_by_id(temp.id[i]);
                                if (it_add.template == null) continue block68;
                                p.item.add_item_bag3(it_add);
                                continue block68;
                            }
                            case 4: 
                            case 7: {
                                if (temp.type[i] == 4 && temp.id[i] == 6) {
                                    p.update_ticket(temp.quant[i]);
                                    p.update_money();
                                    continue block68;
                                }
                                p.item.add_item_bag47(temp.type[i], temp.id[i], temp.quant[i]);
                                continue block68;
                            }
                            case 105: {
                                ItemFashion fashion = ItemFashion.get_item(temp.id[i]);
                                if (fashion == null || p.check_fashion(fashion.ID) != null) continue block68;
                                ItemFashionP2 ownedFashion = new ItemFashionP2();
                                ownedFashion.id = fashion.ID;
                                ownedFashion.level = 0;
                                p.fashion.add(ownedFashion);
                                p.update_fashionP2(ownedFashion);
                                continue block68;
                            }
                            case 103: {
                                ItemHair hair = ItemHair.get_item(temp.id[i], 103);
                                if (hair == null || p.check_itfashionP(hair.ID, 103) != null) continue block68;
                                ItemFashionP ownedHair = new ItemFashionP();
                                ownedHair.category = (byte)103;
                                ownedHair.id = hair.ID;
                                ownedHair.icon = hair.idIcon;
                                p.itfashionP.add(ownedHair);
                                p.update_itfashionP(ownedHair, 103);
                                continue block68;
                            }
                            case 8: {
                                ItemTemplate8 clanItem = null;
                                for (ItemTemplate8 itemTemplate8 : ItemTemplate8.ENTRYS) {
                                    if (itemTemplate8.id != temp.id[i]) continue;
                                    clanItem = itemTemplate8;
                                    break;
                                }
                                if (clanItem == null || p.clan == null) continue block68;
                                ItemBag47 ownedItem = null;
                                for (ItemBag47 item3 : p.clan.list_it) {
                                    if (item3.id != clanItem.id) continue;
                                    ownedItem = item3;
                                    break;
                                }
                                if (ownedItem == null) {
                                    ownedItem = new ItemBag47();
                                    ownedItem.category = (byte)4;
                                    ownedItem.id = clanItem.id;
                                    p.clan.list_it.add(ownedItem);
                                }
                                ownedItem.quant = (short)(ownedItem.quant + temp.quant[i]);
                                p.clan.send_inventory(p, false);
                                continue block68;
                            }
                        }
                    }
                    p.item.update_Inventory(-1, false);
                }
                String notice = "B\u1ea1n nh\u1eadn \u0111\u01b0\u1ee3c:\nBeri : " + temp.beri + "\nRuby : " + temp.ruby + "\nItem :\n";
                if (temp.type != null) {
                    block71: for (int i = 0; i < temp.type.length; ++i) {
                        switch (temp.type[i]) {
                            case 3: {
                                notice = notice + ItemTemplate3.get_it_by_id((int)temp.id[i]).name + " x" + temp.quant[i] + "\n";
                                continue block71;
                            }
                            case 4: {
                                notice = notice + ItemTemplate4.get_it_by_id((int)temp.id[i]).name + " x" + temp.quant[i] + "\n";
                                continue block71;
                            }
                            case 7: {
                                notice = notice + ItemTemplate7.get_it_by_id((int)temp.id[i]).name + " x" + temp.quant[i] + "\n";
                                continue block71;
                            }
                            case 105: {
                                ItemFashion fashion = ItemFashion.get_item(temp.id[i]);
                                if (fashion == null) continue block71;
                                notice = notice + fashion.name + " x1\n";
                                continue block71;
                            }
                            case 103: {
                                ItemHair hair = ItemHair.get_item(temp.id[i], 103);
                                if (hair == null) continue block71;
                                notice = notice + hair.name + " x1\n";
                                continue block71;
                            }
                            case 8: {
                                for (ItemTemplate8 itemTemplate8 : ItemTemplate8.ENTRYS) {
                                    if (itemTemplate8.id != temp.id[i]) continue;
                                    notice = notice + itemTemplate8.name + " x" + temp.quant[i] + " (Kho Bang)\n";
                                    continue block71;
                                }
                                continue block71;
                            }
                        }
                    }
                }
                notice = notice + "\n" + temp.notice;
                Service.send_box_ThongBao_OK(p, notice);
                break;
            }
            case 32002: {
                if (!p.conn.user.equals("admin") || name.length != 3) break;
                if (!(Util.isnumber(name[0]) && Util.isnumber(name[1]) && Util.isnumber(name[2]))) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                int value1 = Integer.parseInt(name[0]);
                int value2 = Integer.parseInt(name[1]);
                int value3 = Integer.parseInt(name[2]);
                if (value3 <= 0 || value3 > 32000) {
                    value3 = 1;
                }
                switch (value1) {
                    case 3: {
                        ItemTemplate3 temp = ItemTemplate3.get_it_by_id(value2);
                        if (temp == null) break;
                        Item_wear it_add = new Item_wear();
                        it_add.setup_template_by_id(temp);
                        if (it_add.template != null) {
                            p.item.add_item_bag3(it_add);
                        }
                        p.item.update_Inventory(-1, false);
                        Service.send_box_ThongBao_OK(p, "L\u1ea5y th\u00e0nh c\u00f4ng " + temp.name);
                        break;
                    }
                    case 4: {
                        ItemTemplate4 temp = ItemTemplate4.get_it_by_id(value2);
                        if (temp == null) break;
                        p.item.add_item_bag47(4, temp.id, value3);
                        p.item.update_Inventory(-1, false);
                        Service.send_box_ThongBao_OK(p, "L\u1ea5y th\u00e0nh c\u00f4ng " + value3 + " " + temp.name);
                        break;
                    }
                    case 7: {
                        ItemTemplate7 temp = ItemTemplate7.get_it_by_id(value2);
                        if (temp == null) break;
                        p.item.add_item_bag47(7, temp.id, value3);
                        p.item.update_Inventory(-1, false);
                        Service.send_box_ThongBao_OK(p, "L\u1ea5y th\u00e0nh c\u00f4ng " + value3 + " " + temp.name);
                        break;
                    }
                }
                break;
            }
            case 32000: {
                if (!p.conn.user.equals("admin") || name.length != 1) break;
                if (!Util.isnumber(name[0])) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                int value = Integer.parseInt(name[0]);
                if (value > 100) {
                    value = 100;
                }
                if (value == 1) {
                    value = 2;
                }
                p.level = (short)(value - 1);
                p.exp = Level.ENTRYS[p.level - 1].exp - 1L;
                p.update_exp(1L, false);
                p.reset_point(0);
                break;
            }
            case 32001: {
                if (!p.conn.user.equals("admin") || name.length != 1) break;
                if (!Util.isnumber(name[0])) {
                    Service.send_box_ThongBao_OK(p, "S\u1ed1 nh\u1eadp kh\u00f4ng h\u1ee3p l\u1ec7");
                    return;
                }
                int value = Integer.parseInt(name[0]);
                if (value < 0 || value > 10000000) {
                    value = 1;
                }
                Manager.gI().exp = value;
                Service.send_box_ThongBao_OK(p, "Thay \u0111\u1ed5i xp x" + value);
            }
        }
    }
}

