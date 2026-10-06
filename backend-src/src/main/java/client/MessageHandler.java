/*
 * Decompiled with CFR 0.152.
 */
package client;

import activities.Chat;
import activities.ChuyenHoa;
import activities.Fight;
import activities.Friend;
import activities.HanhTrinh;
import activities.Join_Item;
import activities.Learn_Skill;
import activities.LittleGarden;
import activities.Market;
import activities.Max_Level;
import activities.Pvp;
import activities.Rebuild_Item;
import activities.Red_Line;
import activities.Ship;
import activities.Split_Item;
import activities.TableTickOption;
import activities.Trade;
import activities.UpgradeDevil;
import activities.UpgradeDial;
import activities.UpgradeItem;
import activities.UpgradeSuperItem;
import activities.Upgrade_Skin;
import activities.VongQuay;
import activities.Wanted;
import client.Buff;
import client.Clan;
import client.ClientInput;
import client.ClientYesNo;
import client.Party;
import client.Pet;
import client.Player;
import client.PlayerChest;
import client.Quest;
import client.UseItem;
import client.Wanted_Chest;
import core.BXH;
import core.Manager;
import core.MenuController;
import core.Service;
import core.Util;
import database.SQL;
import event.EventSpecial;
import io.Message;
import io.Session;
import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import map.Map;
import template.EffTemplate;
import template.ItemBoat;

public class MessageHandler {
    private Session conn;

    public MessageHandler(Session session) {
        this.conn = session;
    }

    public void process_msg(Message m) throws IOException {
        switch (m.cmd) {
            case -86: {
                if (this.conn.p == null) break;
                Wanted_Chest.process(this.conn.p, m);
                break;
            }
            case -85: {
                if (this.conn.p == null) break;
                Wanted.process(this.conn.p, m);
                break;
            }
            case -35: {
                if (this.conn.p == null) break;
                Fight.process(this.conn.p, m);
                break;
            }
            case -80: {
                if (this.conn.p == null) break;
                Pet.process(this.conn.p, m);
                break;
            }
            case 79: {
                if (this.conn.p == null) break;
                HanhTrinh.process(this.conn.p, m);
                break;
            }
            case -94: {
                if (this.conn.p == null) break;
                UpgradeDial.process(this.conn.p, m);
                break;
            }
            case 81: {
                if (this.conn.p == null) break;
                Upgrade_Skin.process(this.conn.p, m);
                break;
            }
            case -53: {
                if (this.conn.p == null) break;
                Ship.process(this.conn.p, m);
                break;
            }
            case 74: {
                byte type = m.reader().readByte();
                short id = m.reader().readShort();
                if (this.conn.p == null || type != 0) break;
                try {
                    Message m2 = new Message(74);
                    m2.writer().writeByte(0);
                    m2.writer().writeShort(id);
                    byte[] data1 = Util.loadfile("data/template/skill/x" + this.conn.zoomlv + "/data/" + id);
                    byte[] data2 = Util.loadfile("data/template/skill/x" + this.conn.zoomlv + "/img/" + id + ".png");
                    m2.writer().writeShort(data1.length);
                    m2.writer().write(data1);
                    m2.writer().write(data2);
                    this.conn.addmsg(m2);
                    m2.cleanup();
                }
                catch (Exception m2) {}
                break;
            }
            case 43: {
                if (this.conn.p == null) break;
                byte type = m.reader().readByte();
                byte value = m.reader().readByte();
                if (type == 0) {
                    if (value != 1 && value != 0) break;
                    this.conn.p.is_show_hat = !this.conn.p.is_show_hat;
                    Service.charWearing(this.conn.p, this.conn.p, false);
                    Service.update_PK(this.conn.p, this.conn.p, false);
                    this.conn.p.update_info_to_all();
                    Service.send_box_ThongBao_OK(this.conn.p, this.conn.p.is_show_hat ? "\u00c4\u0090\u0102\u00a3 b\u00e1\u00ba\u00adt hi\u00e1\u00bb\u0192n th\u00e1\u00bb\u2039 n\u0102\u00b3n" : "\u00c4\u0090\u0102\u00a3 t\u00e1\u00ba\u00aft hi\u00e1\u00bb\u0192n th\u00e1\u00bb\u2039 n\u0102\u00b3n");
                    break;
                }
                if (type != 1 || value != 1 && value != 0) break;
                this.conn.p.is_show_weapon = !this.conn.p.is_show_weapon;
                Service.charWearing(this.conn.p, this.conn.p, false);
                Service.update_PK(this.conn.p, this.conn.p, false);
                this.conn.p.update_info_to_all();
                Service.send_box_ThongBao_OK(this.conn.p, this.conn.p.is_show_weapon ? "\u00c4\u0090\u0102\u00a3 b\u00e1\u00ba\u00adt hi\u00e1\u00bb\u0192n th\u00e1\u00bb\u2039 v\u00c5\u00a9 kh\u0102\u00ad th\u00e1\u00bb\u009di trang" : "\u00c4\u0090\u0102\u00a3 t\u00e1\u00ba\u00aft hi\u00e1\u00bb\u0192n th\u00e1\u00bb\u2039 v\u00c5\u00a9 kh\u0102\u00ad th\u00e1\u00bb\u009di trang");
                break;
            }
            case -91: {
                if (this.conn.p == null) break;
                break;
            }
            case -63: {
                if (this.conn.p == null) break;
                Pvp.process(this.conn.p, m);
                break;
            }
            case 68: {
                if (this.conn.p == null || this.conn.p.map == null) break;
                this.conn.p.tocSuper = (short)(this.conn.p.tocSuper + 1);
                if (this.conn.p.tocSuper > 2) {
                    this.conn.p.tocSuper = 0;
                }
                for (int i = 0; i < this.conn.p.map.players.size(); ++i) {
                    Player p0 = this.conn.p.map.players.get(i);
                    Service.charWearing(this.conn.p, p0, false);
                }
                break;
            }
            case -95: {
                break;
            }
            case -36: {
                int i;
                int id = m.reader().readInt();
                if (this.conn.p == null) break;
                Player p0 = null;
                for (i = 0; i < this.conn.p.friend_list.size(); ++i) {
                    if (this.conn.p.friend_list.get((int)i).id != id) continue;
                    p0 = Map.get_player_by_name_allmap(this.conn.p.friend_list.get((int)i).name);
                    break;
                }
                if (p0 == null) {
                    for (i = 0; i < this.conn.p.enemy_list.size(); ++i) {
                        if (this.conn.p.enemy_list.get((int)i).id != id) continue;
                        p0 = Map.get_player_by_name_allmap(this.conn.p.enemy_list.get((int)i).name);
                        break;
                    }
                }
                boolean check = false;
                if (p0 != null) {
                    int i2;
                    if (Map.map_cant_save_site(p0.map.template.id)) {
                        Service.send_box_ThongBao_OK(this.conn.p, "Kh\u0102\u00b4ng th\u00e1\u00bb\u0192 d\u00e1\u00bb\u2039ch chuy\u00e1\u00bb\u0192n \u00c4\u2018\u00e1\u00ba\u00bfn l\u0102\u00bac n\u0102\u00a0y");
                        return;
                    }
                    for (i2 = 0; i2 < p0.friend_list.size(); ++i2) {
                        if (!p0.friend_list.get((int)i2).name.equals(this.conn.p.name)) continue;
                        check = true;
                        break;
                    }
                    if (!check) {
                        for (i2 = 0; i2 < this.conn.p.enemy_list.size(); ++i2) {
                            if (!this.conn.p.enemy_list.get((int)i2).name.equals(p0.name)) continue;
                            check = true;
                            break;
                        }
                    }
                    if (check) {
                        this.conn.p.data_yesno = new int[]{id};
                        Service.send_box_yesno(this.conn.p, 43, "Th\u0102\u00b4ng b\u0102\u00a1o", "D\u00e1\u00bb\u2039ch chuy\u00e1\u00bb\u0192n \u00c4\u2018\u00e1\u00ba\u00bfn ng\u00c6\u00b0\u00e1\u00bb\u009di n\u0102\u00a0y m\u00e1\u00ba\u00a5t 5 ruby, x\u0102\u00a1c nh\u00e1\u00ba\u00adn d\u00e1\u00bb\u2039ch chuy\u00e1\u00bb\u0192n?", new String[]{"5", "Kh\u0102\u00b4ng"}, new byte[]{7, -1});
                    }
                }
                if (check) break;
                Service.send_box_ThongBao_OK(this.conn.p, "\u00c4\u0090\u00e1\u00bb\u2018i ph\u00c6\u00b0\u00c6\u00a1ng kh\u0102\u00b4ng online ho\u00e1\u00ba\u00b7c kh\u0102\u00b4ng c\u0102\u00b3 trong danh s\u0102\u00a1ch");
                break;
            }
            case -52: {
                if (this.conn.p == null) break;
                byte type = m.reader().readByte();
                if (this.conn.p.clan == null && type != 11 && type != 12) break;
                Clan.process(this.conn.p, m, type);
                break;
            }
            case 49: {
                if (this.conn.p == null) break;
                Max_Level.process(this.conn.p, m);
                break;
            }
            case 80: {
                if (this.conn.p == null) break;
                EventSpecial.process(this.conn.p, m);
                break;
            }
            case -71: {
                if (this.conn.p == null || this.conn.p.map == null || this.conn.p.map.map_pvp != null || this.conn.p.map.map_little_garden != null || this.conn.p.type_pk != -1 || this.conn.p.typePirate != -1 || this.conn.p.pointPk != 0 || m.reader().readByte() != 1 || this.conn.p.item.total_item_bag_by_id(4, 89) <= 0) break;
                this.conn.p.item.remove_item47(4, 89, 1);
                this.conn.p.item.update_Inventory(-1, false);
                this.conn.p.isdie = false;
                Service.use_potion(this.conn.p, 0, this.conn.p.body.get_hp_max(true));
                Service.use_potion(this.conn.p, 1, this.conn.p.body.get_mp_max(true));
                Message m2 = new Message(-71);
                m2.writer().writeByte(1);
                m2.writer().writeShort(this.conn.p.index_map);
                m2.writer().writeByte(0);
                m2.writer().writeInt(1800);
                this.conn.p.map.send_msg_all_p(m2, this.conn.p, true);
                m2.cleanup();
                EffTemplate eff = this.conn.p.get_eff(7);
                if (eff != null) {
                    eff.time = System.currentTimeMillis() + 900000L;
                    break;
                }
                this.conn.p.add_new_eff(7, 1, 900000L);
                break;
            }
            case -74: {
                if (this.conn.p == null) break;
                TableTickOption.process(this.conn.p, m);
                break;
            }
            case 44: {
                if (this.conn.p == null) break;
                Market.process(this.conn.p, m);
                break;
            }
            case -23: {
                if (this.conn.p == null) break;
                Quest.process(this.conn.p, m);
                break;
            }
            case -72: {
                if (this.conn.p == null || this.conn.p.map == null) break;
                if (this.conn.p.map.template.id == 64) {
                    Red_Line.process(this.conn.p, m);
                    break;
                }
                if (this.conn.p.map.map_ThuThachVeThan == null || this.conn.p.map.map_ThuThachVeThan.isFinish) break;
                Red_Line.process_TTVT(this.conn.p, m);
                break;
            }
            case 66: {
                if (this.conn.p == null) break;
                UpgradeSuperItem.process(this.conn.p, m);
                break;
            }
            case -30: {
                if (this.conn.p == null) break;
                BXH.process(this.conn.p, m);
                break;
            }
            case -50: {
                if (this.conn.p == null) break;
                byte type = m.reader().readByte();
                if (type == 0) {
                    Split_Item.process(this.conn.p, m);
                    break;
                }
                if (type != 1) break;
                Join_Item.process(this.conn.p, m);
                break;
            }
            case -62: {
                if (this.conn.p == null) break;
                ItemBoat.update_part_boat_when_shopping(this.conn.p);
                break;
            }
            case -28: {
                if (this.conn.p == null) break;
                Learn_Skill.process(this.conn.p, m);
                break;
            }
            case 45: {
                if (this.conn.p == null) break;
                UpgradeDevil.process(this.conn.p, m);
                break;
            }
            case -25: {
                if (this.conn.p == null) break;
                Party.process(this.conn.p, m);
                break;
            }
            case 20: {
                if (this.conn.p == null || this.conn.p.map == null || this.conn.p.isdie || this.conn.p.get_eff(201) != null) break;
                Buff.process(this.conn.p, m);
                break;
            }
            case -32: {
                if (this.conn.p == null) break;
                PlayerChest.process(this.conn.p, m);
                break;
            }
            case 54: {
                if (this.conn.p == null) break;
                VongQuay.process(this.conn.p, m);
                break;
            }
            case 18: {
                if (this.conn.p == null) break;
                Chat.process(this.conn.p, m, 0);
                break;
            }
            case -29: {
                if (this.conn.p == null) break;
                Friend.process(this.conn.p, m);
                break;
            }
            case -49: {
                if (this.conn.status != 1) {
                    Service.send_box_ThongBao_OK(this.conn.p, "Ch\u00c6\u00b0a K\u0102\u00adch ho\u00e1\u00ba\u00a1t kh\u0102\u00b4ng th\u00e1\u00bb\u0192 giao d\u00e1\u00bb\u2039ch");
                    return;
                }
                Trade.process(this.conn.p, m);
                break;
            }
            case -67: {
                if (this.conn.p == null) break;
                Rebuild_Item.process(this.conn.p, m);
                break;
            }
            case -77: {
                if (this.conn.p == null) break;
                ChuyenHoa.process(this.conn.p, m);
                break;
            }
            case -16: {
                if (this.conn.p == null) break;
                this.conn.p.plus_point(m);
                break;
            }
            case -13: {
                if (this.conn.p == null) break;
                short id = m.reader().readShort();
                UseItem.use_item_potion(this.conn.p, id);
                break;
            }
            case -11: {
                if (this.conn.p == null) break;
                ClientYesNo.process(this.conn.p, m);
                break;
            }
            case -58: {
                if (this.conn.p == null) break;
                ClientInput.process(this.conn.p, m);
                break;
            }
            case -46: {
                int i;
                if (this.conn.status != 1) {
                    Service.send_box_ThongBao_OK(this.conn.p, "Ch\u00c6\u00b0a K\u0102\u00adch ho\u00e1\u00ba\u00a1t kh\u0102\u00b4ng th\u00e1\u00bb\u0192 chat KTG");
                    return;
                }
                if (this.conn.p == null) break;
                byte type = m.reader().readByte();
                String text = m.reader().readUTF();
                if (type == 0) {
                    if (this.conn.p.get_ngoc() < 5) {
                        Service.send_box_ThongBao_OK(this.conn.p, "Kh\u0102\u00b4ng \u00c4\u2018\u00e1\u00bb\u00a7 5 ruby \u00c4\u2018\u00e1\u00bb\u0192 chat KTG");
                        return;
                    }
                    this.conn.p.update_ngoc(-5L);
                    this.conn.p.update_money();
                    Manager.gI().chatKTG(this.conn.p, this.conn.p.name + ": " + text);
                    break;
                }
                if (type != 1 || this.conn.p.clan == null) break;
                boolean check = false;
                for (i = 0; i < this.conn.p.clan.members.size(); ++i) {
                    if (!this.conn.p.clan.members.get((int)i).name.equals(this.conn.p.name) || this.conn.p.clan.members.get((int)i).levelInclan != 1 && this.conn.p.clan.members.get((int)i).levelInclan != 0) continue;
                    check = true;
                    break;
                }
                if (!check) break;
                if (this.conn.p.clan.get_ngoc() < 15) {
                    Service.send_box_ThongBao_OK(this.conn.p, "Kh\u0102\u00b4ng \u00c4\u2018\u00e1\u00bb\u00a7 15 ruby b\u00c4\u0192ng \u00c4\u2018\u00e1\u00bb\u0192 chat KTG");
                    return;
                }
                this.conn.p.clan.update_ruby(-15L);
                for (i = 0; i < this.conn.p.clan.members.size(); ++i) {
                    Player p0 = Map.get_player_by_name_allmap(this.conn.p.clan.members.get((int)i).name);
                    if (p0 == null) continue;
                    Clan.send_money(p0, false);
                }
                Message m23 = new Message(-31);
                m23.writer().writeByte(type);
                m23.writer().writeUTF(this.conn.p.clan.name + ": " + text);
                m23.writer().writeByte(0);
                m23.writer().writeShort(this.conn.p.clan.icon);
                for (Map[] mapall : Map.ENTRYS) {
                    for (Map map : mapall) {
                        for (int i3 = 0; i3 < map.players.size(); ++i3) {
                            Player p0 = map.players.get(i3);
                            p0.conn.addmsg(m23);
                        }
                    }
                }
                m23.cleanup();
                break;
            }
            case -48: {
                if (this.conn.p == null) break;
                UpgradeItem.process(this.conn.p, m);
                break;
            }
            case -22: {
                if (this.conn.p == null) break;
                UseItem.process(this.conn.p, m);
                break;
            }
            case -105: {
                if (this.conn.p == null) break;
                Service.request_item4_info(this.conn.p, m);
                break;
            }
            case -21: {
                if (this.conn.p == null) break;
                Service.sell_item(this.conn.p, m);
                break;
            }
            case 12: {
                if (this.conn.p == null) break;
                this.conn.p.map.pick_item(this.conn.p, m);
                break;
            }
            case -42: {
                String name;
                Player p0;
                if (this.conn.p == null || (p0 = Map.get_player_by_name_allmap(name = m.reader().readUTF())) == null) break;
                Service.send_view_other_player(p0, this.conn.p);
                break;
            }
            case 14: {
                if (this.conn.p == null) break;
                byte type = m.reader().readByte();
                byte act = m.reader().readByte();
                if (act != 0) break;
                this.conn.p.map.change_flag(this.conn.p, type);
                break;
            }
            case 6: {
                if (this.conn.p == null) break;
                this.conn.p.request_live_from_die(m);
                break;
            }
            case -18: {
                if (this.conn.p == null) break;
                Service.buy_item(this.conn.p, m);
                break;
            }
            case -5: {
                if (this.conn.p == null) break;
                short id = m.reader().readShort();
                this.conn.p.map.send_char_in4_inmap(this.conn.p, id);
                break;
            }
            case 46: {
                if (this.conn.p == null) break;
                Service.checkPlayInMap(this.conn.p, m);
                break;
            }
            case 0: {
                if (this.conn.p == null) break;
                m.reader().readShort();
                m.reader().readByte();
                while (this.conn.p.list_msg_cache.size() > 0) {
                    try {
                        Message m_send = this.conn.p.list_msg_cache.take();
                        this.conn.addmsg(m_send);
                    }
                    catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }
                Service.getThanhTich(this.conn.p, this.conn.p);
                this.conn.p.map.send_in4_obj_inmap(this.conn.p);
                this.conn.p.wait_change_map = false;
                if (this.conn.p.map.template.id == 1000) {
                    Pvp.show_table(this.conn.p);
                }
                if (this.conn.p.map.map_pvp != null) {
                    Pvp.show_info(this.conn.p, 0, 0, 0, 3);
                }
                this.conn.p.map.change_flag(this.conn.p, this.conn.p.type_pk);
                Service.update_PK(this.conn.p, this.conn.p, false);
                this.conn.p.map.send_weather(this.conn.p);
                if (this.conn.p.ship_pet != null && this.conn.p.ship_pet.map == null) {
                    this.conn.p.ship_pet.map = this.conn.p.map;
                    this.conn.p.ship_pet.id_map_save = this.conn.p.map.template.id;
                    this.conn.p.ship_pet.x = this.conn.p.x;
                    this.conn.p.ship_pet.y = this.conn.p.y;
                    Message m_local = new Message(1);
                    m_local.writer().writeByte(0);
                    m_local.writer().writeShort(this.conn.p.ship_pet.index_map);
                    m_local.writer().writeShort(this.conn.p.ship_pet.x);
                    m_local.writer().writeShort(this.conn.p.ship_pet.y);
                    for (int j = 0; j < this.conn.p.map.players.size(); ++j) {
                        Player p0 = this.conn.p.map.players.get(j);
                        p0.conn.addmsg(m_local);
                    }
                    m_local.cleanup();
                }
                if (Map.is_map_dungeon(this.conn.p.map.template.id) && this.conn.p.dungeon != null) {
                    Service.send_time_cool_down(this.conn.p, this.conn.p.dungeon.time, "Th\u00e1\u00bb\u009di gian", 2);
                    break;
                }
                if (this.conn.p.map.template.id == 9999 && this.conn.p.map.clan_resource != null) {
                    Service.send_time_cool_down(this.conn.p, this.conn.p.map.clan_resource.time, "Th\u00e1\u00bb\u009di gian", 2);
                    break;
                }
                if (this.conn.p.map.template.id == 81 && this.conn.p.map.map_little_garden != null) {
                    LittleGarden.send_info(this.conn.p);
                    Service.send_time_cool_down(this.conn.p, this.conn.p.map.map_little_garden.time, "Th\u00e1\u00bb\u009di gian", 2);
                    break;
                }
                if (this.conn.p.map.template.id == 984) {
                    this.conn.p.map.update_boat(this.conn.p, this.conn.p, false);
                    Red_Line.init_key_TTVT(this.conn.p);
                    break;
                }
                if (this.conn.p.map.map_pvp != null && this.conn.p.map.map_pvp.type_map == 1) {
                    this.conn.p.update_info_to_all();
                    break;
                }
                if (this.conn.p.map.template.id != 119) break;
                Wanted.show_table(this.conn.p);
                Service.Wanted(this.conn.p, false);
                Wanted_Chest.send_box(this.conn.p);
                break;
            }
            case 23: {
                if (this.conn.p == null || this.conn.p.isdie) break;
                if (this.conn.p.ship_pet != null) {
                    Service.send_box_ThongBao_OK(this.conn.p, "Kh\u0102\u00b4ng th\u00e1\u00bb\u0192 chuy\u00e1\u00ba\u00bfn khu khi \u00c4\u2018ang chuy\u00e1\u00bb\u0192n h\u0102\u00a0ng");
                    break;
                }
                Service.area_select(this.conn.p, m);
                break;
            }
            case 17: {
                if (this.conn.p == null) break;
                this.conn.p.map.send_chat(this.conn.p, m);
                break;
            }
            case -20: {
                if (this.conn.p == null) break;
                MenuController.process_menu(this.conn.p, m);
                break;
            }
            case -19: {
                if (this.conn.p == null) break;
                MenuController.send_menu(this.conn.p, m);
                break;
            }
            case 2: {
                if (this.conn.p == null || this.conn.p.map == null) break;
                this.conn.p.map.use_skill(this.conn.p, m);
                break;
            }
            case -70: {
                if (this.conn.p == null) break;
                this.conn.p.map.update_num_player_in_map(this.conn.p);
                break;
            }
            case -45: {
                if (this.conn.p == null) break;
                this.conn.p.update_point_pk(0);
                Service.CountDown_Ticket(this.conn.p);
                Service.charWearing(this.conn.p, this.conn.p, false);
                break;
            }
            case -33: {
                if (this.conn.p == null) break;
                Service.rms_process(this.conn.p, m);
                break;
            }
            case 1: {
                if (this.conn.p == null || this.conn.p.map == null) break;
                this.conn.p.map.send_move(this.conn.p, m);
                break;
            }
            case 4: {
                if (this.conn.p == null) break;
                Service.request_mob_in4(this.conn.p, m);
                break;
            }
            case 48: {
                if (this.conn.p == null) break;
                Service.send_obj_template(this.conn.p, m);
                break;
            }
            case -9: {
                if (this.conn.p != null) break;
                this.login(m);
                break;
            }
            case -8: {
                this.conn.create_char(m);
                break;
            }
            case -51: {
                Service.send_icon(m, this.conn);
                break;
            }
            case -82: {
                this.conn.ReadPartNew(m);
                break;
            }
            case -38: {
                this.conn.send_data_from_server(m);
                break;
            }
            case -2: {
                if (this.conn.user != null || this.conn.pass != null) break;
                this.conn.login(m);
                break;
            }
            case -6: {
                this.conn.Check_Data_Ver();
                break;
            }
            case -7: {
                this.conn.request_data_update(m);
            }
        }
    }

    public void login(Message m2) throws IOException {
        short id = m2.reader().readShort();
        m2.reader().readByte();
        m2.reader().readShort();
        this.login_into_char_select(id);
    }

    public void login_into_char_select(short id) throws IOException {
        if (this.conn.list_char != null && id < this.conn.list_char.size()) {
            Player p0 = new Player(this.conn, this.conn.list_char.get(id));
            if (!p0.setup()) {
                this.conn.disconnect();
                return;
            }
            p0.setin4();
            if (Map.get_player_by_name_allmap(p0.name) != null) {
                this.conn.disconnect();
                return;
            }
            this.conn.p = p0;
            Message m = new Message(-7);
            m.writer().writeByte(17);
            m.writer().writeLong(System.currentTimeMillis());
            this.conn.addmsg(m);
            m.cleanup();
            Service.UpdateInfoMaincharInfo(this.conn.p);
            Service.Main_char_Info(this.conn.p);
            Service.UpdatePvpPoint(this.conn.p);
            Service.update_PK(this.conn.p, this.conn.p, false);
            Service.getThanhTich(this.conn.p, this.conn.p);
            this.conn.p.item.send_maxbag_Inventory();
            this.conn.p.map.goto_map(this.conn.p);
            Service.update_PK(this.conn.p, this.conn.p, true);
            Service.pet(this.conn.p, this.conn.p, true);
            this.conn.p.item.update_Inventory(-1, true);
            this.conn.p.item.update_assets_Inventory(true);
            Service.ChestWanted(this.conn.p, true);
            this.conn.p.item.send_maxbox_Inventory();
            this.conn.p.item.update_assets_Box(true);
            this.conn.p.item.update_Inventory_box(-1, true);
            Quest.send_List_Quest(this.conn.p, true);
            Quest.update_map_have_side_quest(this.conn.p, true);
            Service.Weapon_fashion(this.conn.p, this.conn.p, true);
            UpgradeItem.send_heart_info(this.conn.p, true);
            Service.charWearing(this.conn.p, this.conn.p, true);
            this.conn.p.map.send_boat(this.conn.p, true);
            this.conn.p.map.update_boat(this.conn.p, this.conn.p, true);
            Service.login_ok(this.conn.p, true);
            Service.Wanted(this.conn.p, true);
            Clan.send_info(this.conn.p, true);
            this.conn.p.item.update_assets_Inventory(true);
            MessageHandler.sendGameNoticeTabs(this.conn.p);
        }
    }

    private static void sendGameNoticeTabs(Player p) throws IOException {
        for (String[] tab : MessageHandler.loadGameNoticeTabs()) {
            Message msg = new Message(18);
            msg.writer().writeUTF(tab[0]);
            msg.writer().writeUTF(tab[1]);
            p.list_msg_cache.add(msg);
        }
    }

    private static List<String[]> loadGameNoticeTabs() {
        ArrayList<String[]> tabs = new ArrayList<String[]>();
        try (Connection con = SQL.gI().getCon();
             Statement st = con.createStatement();){
            st.executeUpdate("CREATE TABLE IF NOT EXISTS `admin_game_notices` (`id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,`slot_key` VARCHAR(32) NOT NULL UNIQUE,`tab_title` VARCHAR(80) NOT NULL,`content` TEXT NOT NULL,`enabled` TINYINT NOT NULL DEFAULT 1,`sort_order` INT NOT NULL DEFAULT 0,`updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci");
            MessageHandler.seedGameNoticeTab(con, "news", "Tin \u0111\u1ebfn", MessageHandler.defaultNews(), 1);
            MessageHandler.seedGameNoticeTab(con, "race", "\u0110ua Top", MessageHandler.defaultRace(), 2);
            MessageHandler.seedGameNoticeTab(con, "giftcode", "GiftCode", MessageHandler.defaultGiftCode(), 3);
            try (PreparedStatement ps = con.prepareStatement("SELECT `tab_title`, `content` FROM `admin_game_notices` WHERE `enabled` = 1 ORDER BY `sort_order` ASC, `id` ASC");
                 ResultSet rs = ps.executeQuery();){
                while (rs.next()) {
                    String title = rs.getString("tab_title");
                    String content = rs.getString("content");
                    if (title == null || title.trim().isEmpty() || content == null) continue;
                    tabs.add(new String[]{title, content});
                }
            }
        }
        catch (Exception e) {
            System.err.println("[Notice] Cannot load game notice tabs, using defaults: " + e.getMessage());
        }
        if (tabs.isEmpty()) {
            tabs.add(new String[]{"Tin \u0111\u1ebfn", MessageHandler.defaultNews()});
            tabs.add(new String[]{"\u0110ua Top", MessageHandler.defaultRace()});
            tabs.add(new String[]{"GiftCode", MessageHandler.defaultGiftCode()});
        }
        return tabs;
    }

    private static void seedGameNoticeTab(Connection con, String key, String title, String content, int order) throws Exception {
        try (PreparedStatement ps = con.prepareStatement("INSERT IGNORE INTO `admin_game_notices` (`slot_key`, `tab_title`, `content`, `enabled`, `sort_order`) VALUES (?, ?, ?, 1, ?)");){
            ps.setString(1, key);
            ps.setString(2, title);
            ps.setString(3, content);
            ps.setInt(4, order);
            ps.executeUpdate();
        }
    }

    private static String defaultNews() {
        return "Th\u00f4ng b\u00e1o: UPDATE - Ch\u1ee9c N\u0103ng Tuy\u1ec7t K\u1ef9 L\u1ee5c Th\u1ee9c\n\nC\u00f9ng v\u1edbi Haki, Tr\u00e1i \u00e1c qu\u1ef7 v\u00e0 Karate Ng\u01b0\u1eddi c\u00e1 th\u00ec L\u1ee5c Th\u1ee9c l\u00e0 m\u1ed9t trong nh\u1eefng s\u1ee9c m\u1ea1nh \u0111\u1ed9c \u0111\u00e1o c\u1ee7a One Piece.\n\nChi ti\u1ebft: https://haitactihon.com/forum/game/6/Huong-Dan-0.html";
    }

    private static String defaultRace() {
        return "Th\u1eddi gian: \u0111ang c\u1eadp nh\u1eadt\nPh\u1ea7n th\u01b0\u1edfng \u0111ua top:\n- TOP 1: Trang b\u1ecb cao c\u1ea5p, th\u1eddi trang hi\u1ebfm, \u0111\u00e1 kh\u1ea3m v\u00e0 Beri.\n- TOP 2-3: Trang b\u1ecb cao c\u1ea5p, \u0111\u00e1 h\u1ea3i th\u1ea1ch v\u00e0 Beri.\n- TOP 4-10: Trang b\u1ecb +10, \u0111\u00e1 kh\u1ea3m v\u00e0 Beri.\n\nAdmin c\u00f3 th\u1ec3 ch\u1ec9nh n\u1ed9i dung n\u00e0y trong trang Qu\u1ea3n l\u00fd th\u00f4ng b\u00e1o.";
    }

    private static String defaultGiftCode() {
        return "GiftCode:\n- TanThu\n- ThanhVien\n- htth2024\n- baotri";
    }
}

