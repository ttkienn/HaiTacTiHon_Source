/*
 * Decompiled with CFR 0.152.
 */
package core;

import activities.ChuyenHoa;
import activities.Dungeon;
import activities.HanhTrinh;
import activities.HelpDialog;
import activities.Join_Item;
import activities.Market;
import activities.Max_Level;
import activities.Rebuild_Item;
import activities.Ship;
import activities.Split_Item;
import activities.TableTickOption;
import activities.UpgradeDevil;
import activities.UpgradeDial;
import activities.UpgradeItem;
import activities.UpgradeSuperItem;
import activities.Upgrade_Skin;
import activities.VongQuay;
import client.Body;
import client.Clazz;
import client.MapBossInfo;
import client.Player;
import client.Quest;
import core.BXH;
import core.Manager;
import core.SaveData;
import core.ServerManager;
import core.Service;
import core.Util;
import database.SQL;
import event.Doriki;
import event.EventSpecial;
import event.LucThuc;
import event.SucManhVatLy;
import io.Message;
import io.SessionManager;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import map.Map;
import map.MapCanGoTo;
import map.Mob;
import map.Npc;
import map.Vgo;
import org.joda.time.LocalTime;
import template.Clan_member;
import template.DaThanThoai;
import template.EffTemplate;
import template.ItemFashion;
import template.ItemFashionP;
import template.ItemTemplate4;
import template.ItemTemplate7;
import template.ItemTemplate8;
import template.QuestP;
import template.Ship_pet;
import template.ShopTichLuy;
import template.Skill_Template;
import template.Skill_info;
import template.TaiXiuInfo;

public class MenuController {
    public static int[] ID_MAP_LANG = new int[]{1, 9, 17, 25, 33, 41, 49, 66, 69, 79, 83, 93, 107, 113, 191};

    public static void send_menu(Player p, Message m) throws IOException {
        if (!p.isdie) {
            short type = m.reader().readShort();
            boolean in_map = false;
            for (int i = 0; i < p.map.template.npcs.size(); ++i) {
                if (type != p.map.template.npcs.get((int)i).iditem) continue;
                in_map = true;
                break;
            }
            if (!in_map) {
                return;
            }
            switch (type) {
                case -140: {
                    MenuController.send_dynamic_menu(p, (int)type, "WIPPER", new String[]{"Ch\u1ebf t\u1ea1o DIAL", "Th\u1eed th\u00e1ch v\u1ec7 th\u1ea7n"}, null);
                    break;
                }
                case -86: {
                    MenuController.send_dynamic_menu(p, (int)type, "Ph\u00f3 b\u1ea3n", new String[]{"\u0110\u00e1 \u0111\u00edt Mr3", "Ph\u00f3 b\u1ea3n kh\u1ed5ng l\u1ed3", "H\u01b0\u1edbng d\u1eabn Ph\u00f3 b\u1ea3n kh\u1ed5ng l\u1ed3"}, new short[]{150, 142, 148});
                    break;
                }
                case -77: {
                    MenuController.send_dynamic_menu(p, (int)type, "Ms Gym", new String[]{"BXH \u0110\u1ea5u tr\u01b0\u1eddng", "H\u01b0\u1edbng d\u1eabn"}, null);
                    break;
                }
                case -73: {
                    MenuController.send_dynamic_menu(p, (int)type, "Croket", new String[]{"H\u01b0\u1edbng d\u1eabn"}, null);
                    break;
                }
                case -84: {
                    if (p.clan != null) {
                        if (p.clan.members.get((int)0).name.equals(p.name)) {
                            if (p.clan.allowRequest == 1) {
                                MenuController.send_dynamic_menu(p, (int)type, "B\u0103ng h\u1ea3i t\u1eb7c", new String[]{"Nhi\u1ec7m v\u1ee5 b\u0103ng", "Huy hi\u1ec7u h\u00e0nh tr\u00ecnh", "Ph\u00f3 b\u1ea3n b\u0103ng", "C\u1eeda h\u00e0ng bi\u1ec3u t\u01b0\u1ee3ng", "C\u1eeda h\u00e0ng v\u1eadt ph\u1ea9m", "Kh\u00f3a xin v\u00e0o b\u0103ng"}, new short[]{141, 171, 146, 143, 144, 118});
                                break;
                            }
                            MenuController.send_dynamic_menu(p, (int)type, "B\u0103ng h\u1ea3i t\u1eb7c", new String[]{"Nhi\u1ec7m v\u1ee5 b\u0103ng", "Huy hi\u1ec7u h\u00e0nh tr\u00ecnh", "Ph\u00f3 b\u1ea3n b\u0103ng", "C\u1eeda h\u00e0ng bi\u1ec3u t\u01b0\u1ee3ng", "C\u1eeda h\u00e0ng v\u1eadt ph\u1ea9m", "M\u1edf xin v\u00e0o b\u0103ng"}, new short[]{141, 171, 146, 143, 144, 118});
                            break;
                        }
                        MenuController.send_dynamic_menu(p, (int)type, "B\u0103ng h\u1ea3i t\u1eb7c", new String[]{"Nhi\u1ec7m v\u1ee5 b\u0103ng", "Huy hi\u1ec7u h\u00e0nh tr\u00ecnh", "Ph\u00f3 b\u1ea3n b\u0103ng"}, new short[]{141, 171, 146});
                        break;
                    }
                    MenuController.send_dynamic_menu(p, (int)type, "B\u0103ng h\u1ea3i t\u1eb7c", new String[]{"\u0110\u0103ng k\u00fd b\u0103ng h\u1ea3i t\u1eb7c (2000 Ruby)", "H\u01b0\u1edbng d\u1eabn"}, null);
                    break;
                }
                case -138: {
                    MenuController.send_dynamic_menu(p, (int)type, "C\u01b0\u1eddng h\u00f3a m\u00e1u", new String[]{"Ph\u1eabu thu\u1eadt", "H\u01b0\u1edbng d\u1eabn"}, null);
                    break;
                }
                case -106: 
                case -91: 
                case -71: 
                case -48: {
                    switch (p.map.template.id) {
                        case 9: {
                            MenuController.send_dynamic_menu(p, (int)type, "Zosaku", new String[]{"S\u0103n tr\u00f9m", "Th\u00e1ch \u0111\u1ea5u", "V\u01b0\u1ee3t li\u00ean \u1ea3i", "Tr\u1eadn chi\u1ebfn l\u1edbn", "Th\u1ee3 s\u0103n h\u1ea3i t\u1eb7c"}, new short[]{136, 137, 138, 146, 111});
                            break;
                        }
                        case 17: 
                        case 33: 
                        case 69: 
                        case 93: 
                        case 113: 
                        case 189: 
                        case 191: {
                            MenuController.send_dynamic_menu(p, (int)type, "Zosaku", new String[]{"S\u0103n tr\u00f9m", "Th\u00e1ch \u0111\u1ea5u", "V\u01b0\u1ee3t li\u00ean \u1ea3i", "Tr\u1eadn chi\u1ebfn l\u1edbn"}, new short[]{136, 137, 138, 146});
                            break;
                        }
                        case 25: {
                            MenuController.send_dynamic_menu(p, (int)type, "Zosaku", new String[]{"S\u0103n tr\u00f9m", "Th\u00e1ch \u0111\u1ea5u", "V\u01b0\u1ee3t li\u00ean \u1ea3i", "Tr\u1eadn chi\u1ebfn l\u1edbn", "V\u01b0\u1ee3t \u1ea3i \u0111\u01a1n"}, new short[]{136, 137, 138, 146, 138});
                            break;
                        }
                        case 41: {
                            MenuController.send_dynamic_menu(p, (int)type, "Zosaku", new String[]{"S\u0103n tr\u00f9m", "Th\u00e1ch \u0111\u1ea5u", "V\u01b0\u1ee3t li\u00ean \u1ea3i", "Tr\u1eadn chi\u1ebfn l\u1edbn", "B\u1ea3o v\u1ec7 kho b\u00e1u Namie"}, new short[]{136, 137, 138, 146, 139});
                            break;
                        }
                        case 49: {
                            MenuController.send_dynamic_menu(p, (int)type, "Zosaku", new String[]{"S\u0103n tr\u00f9m", "Th\u00e1ch \u0111\u1ea5u", "V\u01b0\u1ee3t li\u00ean \u1ea3i", "Tr\u1eadn chi\u1ebfn l\u1edbn", "L\u1ec7nh truy n\u00e3"}, new short[]{136, 137, 138, 146, 160});
                            break;
                        }
                        case 83: {
                            MenuController.send_dynamic_menu(p, (int)type, "Zosaku", new String[]{"S\u0103n tr\u00f9m", "Th\u00e1ch \u0111\u1ea5u", "V\u01b0\u1ee3t si\u00eau li\u00ean \u1ea3i", "Tr\u1eadn chi\u1ebfn l\u1edbn"}, new short[]{136, 137, 159, 146});
                        }
                    }
                    break;
                }
                case -72: {
                    if (p.map.template.id == 17) {
                        MenuController.send_dynamic_menu(p, (int)type, "Nami", new String[]{"\u0110\u1ed5i Ruby", "Th\u00e0nh t\u00edch h\u1eb1ng ng\u00e0y", "T\u00edch l\u0169y n\u1ea1p th\u1ebb", "\u0110\u1ea5u gi\u00e1", "\u0110i\u1ec3m n\u1ea1p t\u00edch l\u0169y", "Ch\u1ee3 mua b\u00e1n"}, new short[]{132, 134, 110, 169, 170, 170, 152});
                        break;
                    }
                    MenuController.send_dynamic_menu(p, (int)type, "Nami", new String[]{"\u0110\u1ed5i Ruby", "Th\u00e0nh t\u00edch h\u1eb1ng ng\u00e0y", "T\u00edch l\u0169y n\u1ea1p th\u1ebb", "\u0110\u1ea5u gi\u00e1", "\u0110i\u1ec3m n\u1ea1p t\u00edch l\u0169y"}, new short[]{132, 134, 110, 169, 170, 170});
                    break;
                }
                case -997: {
                    switch (p.map.template.id) {
                        case 1: {
                            MenuController.send_dynamic_menu(p, (int)type, "H\u01b0\u1edbng d\u1eabn", new String[]{"\u0110\u0103ng k\u00fd t\u00e0i kho\u1ea3n", "Nhi\u1ec7m v\u1ee5 t\u00e2n th\u1ee7", "V\u1eadt ph\u1ea9m", "V\u1eadn bu\u00f4n", "Trang b\u1ecb", "K\u1ef9 n\u0103ng"}, null);
                            break;
                        }
                        case 9: {
                            MenuController.send_dynamic_menu(p, (int)type, "H\u01b0\u1edbng d\u1eabn", new String[]{"B\u1ea3ng x\u1ebfp h\u1ea1ng", "Nhi\u1ec7m v\u1ee5 h\u00e0ng ng\u00e0y", "C\u01b0\u1eddng h\u00f3a trang b\u1ecb", "Kh\u1ea3m \u0111\u00e1", "Chuy\u1ec3n h\u00f3a", "S\u0103n tr\u00f9m", "Ph\u00f3 b\u1ea3n li\u00ean t\u1ea7ng", "Ph\u00f3 b\u1ea3n PvP", "Kh\u00f3a b\u1ea3o v\u1ec7", "N\u1ea1p ti\u1ec1n"}, null);
                            break;
                        }
                        case 17: {
                            MenuController.send_dynamic_menu(p, (int)type, "H\u01b0\u1edbng d\u1eabn", new String[]{"Ch\u1ee3 mua b\u00e1n", "V\u00f2ng xoay kho b\u00e1u", "Ho\u00e0n m\u1ef9", "K\u00edch \u1ea9n", "Thu\u1ed9c t\u00ednh k\u00edch \u1ea9n (1-4)", "Thu\u1ed9c t\u00ednh k\u00edch \u1ea9n (5-8)", "Thu\u1ed9c t\u00ednh k\u00edch \u1ea9n (9-13)"}, null);
                            break;
                        }
                        case 25: {
                            MenuController.send_dynamic_menu(p, (int)type, "H\u01b0\u1edbng d\u1eabn", new String[]{"C\u01b0\u1eddng h\u00f3a \u00e1c qu\u1ef7"}, null);
                            break;
                        }
                        case 33: {
                            MenuController.send_dynamic_menu(p, (int)type, "H\u01b0\u1edbng d\u1eabn", new String[]{"B\u0103ng h\u1ea3i t\u1eb7c", "Ph\u00f3 b\u1ea3n b\u0103ng", "Ph\u00f3 b\u1ea3n kh\u1ed5ng l\u1ed3", "B\u1ea3o v\u1ec7 ph\u00e1o \u0111\u00e0i"}, null);
                            break;
                        }
                        case 41: {
                            MenuController.send_dynamic_menu(p, (int)type, "H\u01b0\u1edbng d\u1eabn", new String[]{"B\u1ea3o v\u1ec7 kho b\u00e1u Namie", "Si\u00eau boss"}, null);
                            break;
                        }
                        case 49: {
                            MenuController.send_dynamic_menu(p, (int)type, "H\u01b0\u1edbng d\u1eabn", new String[]{"L\u1ec7nh truy n\u00e3", "Si\u00eau boss"}, null);
                            break;
                        }
                        case 66: {
                            MenuController.send_dynamic_menu(p, (int)type, "H\u01b0\u1edbng d\u1eabn", new String[]{"V\u01b0\u1ee3t Redline"}, null);
                            break;
                        }
                        case 69: {
                            MenuController.send_dynamic_menu(p, (int)type, "H\u01b0\u1edbng d\u1eabn", new String[]{"Tr\u00e1i \u00e1c qu\u1ef7", "\u0110\u1ea5u tr\u01b0\u1eddng t\u1ef1 do", "Si\u00eau boss"}, null);
                            break;
                        }
                        case 79: {
                            MenuController.send_dynamic_menu(p, (int)type, "H\u01b0\u1edbng d\u1eabn", new String[]{"\u0110\u00e1 \u0111\u00edt Mr.3", "Ph\u00f3 b\u1ea3n kh\u1ed5ng l\u1ed3"}, null);
                        }
                    }
                    break;
                }
                case -100: {
                    MenuController.send_dynamic_menu(p, (int)type, "S\u1ef1 ki\u1ec7n", new String[]{"T/g x2 k\u1ef9 n\u0103ng EXP", "T/g kh\u00f3a exp", "H\u1ee7y t/g kh\u00f3a exp", "T\u00e0i x\u1ec9u"}, null);
                    break;
                }
                case -37: {
                    MenuController.send_dynamic_menu(p, (int)type, "B\u1ebfp tr\u01b0\u1edfng", new String[]{"H\u1ecdc Skill", "T\u1ea9y ti\u1ec1m n\u0103ng", "X\u00f3a n\u1ed9i t\u1ea1i", "Ng\u01b0\u1eddi gi\u1edbi thi\u1ec7u", "\u0110\u00e1 h\u00e0nh tr\u00ecnh"}, new short[]{123, 124, 125, 138, 127});
                    break;
                }
                case -4: {
                    if (p.level >= 100) {
                        MenuController.send_dynamic_menu(p, (int)type, "Gap", new String[]{"H\u1ecdc Skill", "T\u1ea9y ti\u1ec1m n\u0103ng", "X\u00f3a n\u1ed9i t\u1ea1i", "Ng\u01b0\u1eddi gi\u1edbi thi\u1ec7u", "Th\u00f4ng th\u1ea1o"}, new short[]{123, 124, 125, 138, 138});
                        break;
                    }
                    MenuController.send_dynamic_menu(p, (int)type, "Gap", new String[]{"H\u1ecdc Skill", "T\u1ea9y ti\u1ec1m n\u0103ng", "X\u00f3a n\u1ed9i t\u1ea1i", "Ng\u01b0\u1eddi gi\u1edbi thi\u1ec7u"}, new short[]{123, 124, 125, 138});
                    break;
                }
                case -153: 
                case -152: 
                case -151: 
                case -150: 
                case -149: 
                case -148: {
                    MenuController.Show_List_Map_Tele(p, 0, -144);
                    break;
                }
                case -131: 
                case -130: 
                case -129: 
                case -128: 
                case -127: 
                case -126: 
                case -125: 
                case -123: {
                    MenuController.Show_List_Map_Tele(p, 0, -124);
                    break;
                }
                case -115: 
                case -114: 
                case -113: 
                case -112: 
                case -111: 
                case -110: 
                case -109: 
                case -108: {
                    MenuController.Show_List_Map_Tele(p, 0, -107);
                    break;
                }
                case -96: 
                case -94: 
                case -93: 
                case -92: {
                    MenuController.Show_List_Map_Tele(p, 0, -85);
                    break;
                }
                case -83: 
                case -81: 
                case -80: 
                case -79: {
                    MenuController.Show_List_Map_Tele(p, 0, 0);
                    break;
                }
                case -63: 
                case -62: 
                case -61: 
                case -59: {
                    MenuController.Show_List_Map_Tele(p, 0, -60);
                    break;
                }
                case -58: 
                case -51: 
                case -50: 
                case -49: {
                    MenuController.Show_List_Map_Tele(p, 0, -44);
                    break;
                }
                case -57: 
                case -42: 
                case -41: 
                case -40: {
                    MenuController.Show_List_Map_Tele(p, 0, -36);
                    break;
                }
                case -56: 
                case -34: 
                case -33: 
                case -32: {
                    MenuController.Show_List_Map_Tele(p, 0, -28);
                    break;
                }
                case -55: 
                case -26: 
                case -25: 
                case -24: {
                    MenuController.Show_List_Map_Tele(p, 0, -20);
                    break;
                }
                case -54: 
                case -18: 
                case -17: 
                case -16: {
                    MenuController.Show_List_Map_Tele(p, 0, -12);
                    break;
                }
                case -53: 
                case -10: 
                case -9: 
                case -8: {
                    MenuController.Show_List_Map_Tele(p, 0, -5);
                    break;
                }
                case -6: {
                    Service.Send_UI_Shop(p, 99);
                    break;
                }
                case -145: 
                case -122: 
                case -118: 
                case -103: 
                case -87: 
                case -74: 
                case -67: 
                case -45: 
                case -31: 
                case -21: 
                case -13: 
                case -1: {
                    if (p.conn.status != 1) {
                        MenuController.send_dynamic_menu(p, (int)type, MenuController.get_name_npc(type), new String[]{"K\u00edch Ho\u1ea1t T\u00e0i Kho\u1ea3n", "Th\u00e1ch \u0111\u1ea5u", "Cao th\u1ee7", "B\u0103ng h\u1ea3i t\u1eb7c", "Truy n\u00e3", "\u0110\u00e1 h\u00e0nh tr\u00ecnh", "\u0110i\u1ec3m Danh", "\u0110i\u1ec3m Danh Vip " + p.conn.vip}, null);
                        break;
                    }
                    MenuController.send_dynamic_menu(p, (int)type, MenuController.get_name_npc(type), new String[]{"Th\u00e1ch \u0111\u1ea5u", "Cao th\u1ee7", "B\u0103ng h\u1ea3i t\u1eb7c", "Truy n\u00e3", "\u0110\u00e1 h\u00e0nh tr\u00ecnh", "\u0110i\u1ec3m Danh", "\u0110i\u1ec3m Danh Vip " + p.conn.vip}, null);
                    break;
                }
                case -133: {
                    MenuController.send_dynamic_menu(p, (int)type, "Kho B\u00e1u", new String[]{"V\u00f2ng quay kho b\u00e1u", "Ho\u00e0n m\u1ef9 - K\u00edch \u1ea9n", "V\u00f2ng quay \u1ed1c s\u00ean", "L\u1ee5c Th\u1ee9c", "S\u1ee9c M\u1ea1nh V\u1eadt L\u00fd", "Doriki"}, null);
                    break;
                }
                case -105: 
                case -90: 
                case -70: 
                case -47: {
                    if (p.map.template.id == 25) {
                        MenuController.send_dynamic_menu(p, (int)type, "Johny", new String[]{"C\u01b0\u1eddng H\u00f3a", "Kh\u1ea3m \u0111\u00e1", "Chuy\u1ec3n h\u00f3a", "Gh\u00e9p m\u1ea3nh trang b\u1ecb", "C\u01b0\u1eddng h\u00f3a th\u1eddi trang", "C\u01b0\u1eddng h\u00f3a \u00e1c qu\u1ef7"}, new short[]{126, 127, 128, 126, 126, 154});
                        break;
                    }
                    MenuController.send_dynamic_menu(p, (int)type, "Johny", new String[]{"C\u01b0\u1eddng H\u00f3a", "Kh\u1ea3m \u0111\u00e1", "Chuy\u1ec3n h\u00f3a", "Gh\u00e9p m\u1ea3nh trang b\u1ecb", "C\u01b0\u1eddng h\u00f3a th\u1eddi trang"}, new short[]{126, 127, 128, 126, 126});
                    break;
                }
                case -147: 
                case -120: 
                case -116: 
                case -102: 
                case -89: 
                case -76: 
                case -68: 
                case -46: 
                case -39: 
                case -29: 
                case -22: 
                case -14: 
                case -2: {
                    MenuController.send_dynamic_menu(p, (int)type, MenuController.get_name_npc(type), new String[]{"Qu\u00e1n \u0103n", "V\u1eadn Chuy\u1ec3n H\u00e0ng", "Ti\u1ec7m t\u00f3c", "\u0110\u00f3ng thuy\u1ec1n", "Th\u1eddi trang", "Th\u1ea9m m\u1ef9 vi\u1ec7n"}, new short[]{104, 107, 106, 105, 108, 158});
                    break;
                }
                case -144: 
                case -132: 
                case -124: 
                case -107: 
                case -97: 
                case -85: 
                case -82: 
                case -60: 
                case -44: 
                case -36: 
                case -28: 
                case -20: 
                case -12: 
                case -5: 
                case 0: {
                    MenuController.send_dynamic_menu(p, (int)type, "", new String[]{"Trong l\u00e0ng", "Th\u1ebf gi\u1edbi"});
                    break;
                }
                case -7: {
                    MenuController.Menu_Change_Zone(p);
                    break;
                }
                case -146: 
                case -121: 
                case -117: 
                case -101: 
                case -88: 
                case -75: 
                case -69: 
                case -38: 
                case -30: 
                case -23: 
                case -15: 
                case -3: {
                    MenuController.send_dynamic_menu(p, (int)type, MenuController.get_name_npc(type), new String[]{Clazz.NAME[p.clazz - 1], "H\u1ec7 kh\u00e1c", !p.is_show_hat ? "B\u1eadt hi\u1ec3n th\u1ecb n\u00f3n" : "T\u1eaft hi\u1ec3n th\u1ecb n\u00f3n", "Kh\u00f3a b\u1ea3o v\u1ec7", "Th\u00f9ng r\u00e1c"}, new short[]{Clazz.ICON[p.clazz - 1], 116, 117, 118, 113});
                    break;
                }
                case -119: {
                    break;
                }
                default: {
                    MenuController.send_dynamic_menu(p, (int)type, MenuController.get_name_npc(type) + " id " + type, new String[]{"Ch\u01b0a c\u00f3"}, new short[]{117});
                }
            }
        }
    }

    private static String get_name_npc(int type) {
        switch (type) {
            case -145: {
                return "Icebug";
            }
            case -122: {
                return "Gan";
            }
            case -118: {
                return "Cricket";
            }
            case -103: {
                return "Cobran";
            }
            case -87: {
                return "Daltont";
            }
            case -74: {
                return "Mr Opera";
            }
            case -67: {
                return "Mastersun";
            }
            case -45: {
                return "Genzo";
            }
            case -31: {
                return "B\u0103ng h\u1ea3i t\u1eb7c nh\u00ed";
            }
            case -1: {
                return "Tr\u01b0\u1edfng l\u00e0ng";
            }
            case -146: {
                return "Paule";
            }
            case -147: {
                return "kookoroo";
            }
            case -120: {
                return "Conic";
            }
            case -121: {
                return "Pagada";
            }
            case -117: {
                return "Spect";
            }
            case -116: {
                return "Terri";
            }
            case -101: {
                return "Kohzak";
            }
            case -102: {
                return "Yoshi moto";
            }
            case -89: {
                return "Dr Kure";
            }
            case -88: {
                return "Stook";
            }
            case -75: {
                return "Ms Vivi";
            }
            case -76: {
                return "Mr Acrobatic";
            }
            case -68: {
                return "Sapie";
            }
            case -46: {
                return "Noziko";
            }
            case -39: {
                return "Cami";
            }
            case -29: {
                return "Kaiya";
            }
            case -21: {
                return "Th\u1ecb Tr\u01b0\u1edfng";
            }
            case -13: {
                return "Cobi";
            }
            case -69: {
                return "Masu";
            }
            case -3: {
                return "Guru";
            }
            case -15: {
                return "M\u1eb9 Rita";
            }
            case -23: {
                return "Poroy";
            }
            case -30: {
                return "Merri";
            }
            case -38: {
                return "Partty";
            }
            case -2: {
                return "Machiko";
            }
            case -14: {
                return "Rita";
            }
            case -22: {
                return "Cho Cho";
            }
        }
        return "NPC";
    }

    public static void process_menu(Player p, Message m2) throws IOException {
        if (!p.isdie) {
            short idNPC = m2.reader().readShort();
            m2.reader().readByte();
            byte index = m2.reader().readByte();
            switch (idNPC) {
                case 1003: {
                    MenuController.Menu_SucManhVatLy(p, index);
                    break;
                }
                case 1001: {
                    MenuController.Menu_Doriki(p, index);
                    break;
                }
                case 1002: {
                    MenuController.Menu_LucThuc(p, index);
                    break;
                }
                case 978: {
                    if (index == 0) {
                        HanhTrinh.show_table(p, 1);
                        break;
                    }
                    if (index == 1) {
                        HanhTrinh.show_table(p, 0);
                        break;
                    }
                    if (index != 2) break;
                    Service.send_box_ThongBao_OK(p, "M\u1ed7i khi b\u1ea1n ti\u00eau di\u1ec7t boss cu\u1ed1i m\u1ed7i l\u00e0ng s\u1ebd c\u00f3 10% c\u01a1 h\u1ed9i nh\u1eadn \u0111\u01b0\u1ee3c \u0111\u00e1 h\u00e0nh tr\u00ecnh. G\u1eb7p tr\u01b0\u1edfng l\u00e0ng xem \u0111\u00e1 ki\u1ebfm \u0111\u01b0\u1ee3c");
                    break;
                }
                case 979: {
                    if (index == 0) {
                        Message m = new Message(-19);
                        m.writer().writeByte(97);
                        m.writer().writeUTF("C\u1eeda h\u00e0ng bi\u1ec3u t\u01b0\u1ee3ng th\u01b0\u1eddng");
                        m.writer().writeByte(107);
                        m.writer().writeShort(278);
                        for (int i = 0; i < 278; ++i) {
                            m.writer().writeShort(i);
                            m.writer().writeShort(i);
                            m.writer().writeUTF("Huy hi\u1ec7u " + (i + 1));
                            m.writer().writeUTF("\u0110\u01b0\u1ee3c l\u00e0m t\u1eeb g\u00ec \u0111\u1ea5y kh\u00f4ng bi\u1ebft n\u1eefa, mua \u0111eo v\u00e0o r\u1ea5t \u0111\u1eb9p");
                            if (i < 10) {
                                m.writer().writeShort(0);
                                continue;
                            }
                            m.writer().writeShort(50);
                        }
                        p.conn.addmsg(m);
                        m.cleanup();
                        break;
                    }
                    if (index != 1) break;
                    Message m = new Message(-19);
                    m.writer().writeByte(97);
                    m.writer().writeUTF("C\u1eeda h\u00e0ng bi\u1ec3u t\u01b0\u1ee3ng cao c\u1ea5p");
                    m.writer().writeByte(107);
                    m.writer().writeShort(76);
                    for (int i = 293; i < 370; ++i) {
                        if (i == 303) continue;
                        m.writer().writeShort(i);
                        m.writer().writeShort(i);
                        m.writer().writeUTF("Huy hi\u1ec7u " + (i + 1));
                        m.writer().writeUTF("\u0110\u01b0\u1ee3c l\u00e0m t\u1eeb g\u00ec \u0111\u1ea5y kh\u00f4ng bi\u1ebft n\u1eefa, mua \u0111eo v\u00e0o r\u1ea5t \u0111\u1eb9p");
                        if (i < 10) {
                            m.writer().writeShort(0);
                            continue;
                        }
                        m.writer().writeShort(200);
                    }
                    p.conn.addmsg(m);
                    m.cleanup();
                    break;
                }
                case 980: {
                    switch (index) {
                        case 0: 
                        case 1: 
                        case 2: {
                            UpgradeDevil.show_table(p, index + 2);
                            break;
                        }
                        case 3: {
                            UpgradeDial.show_table(p);
                            break;
                        }
                        case 4: {
                            Rebuild_Item.show_table(p, 10);
                        }
                    }
                    break;
                }
                case 981: {
                    if (index != 0) break;
                    break;
                }
                case 982: {
                    if (p.ship_pet != null && p.name_ThoSanHaiTac != null && index < p.name_ThoSanHaiTac.length) {
                        Player p0 = Map.get_player_by_name_allmap(p.name_ThoSanHaiTac[index]);
                        if (p0 != null && p0.name_ThoSanHaiTac == null) {
                            p0.name_ThoSanHaiTac = new String[]{p.name};
                            Service.send_box_yesno(p0, 53, "Th\u00f4ng b\u00e1o", p.name + " mu\u1ed1n m\u1eddi b\u1ea1n b\u1ea3o v\u1ec7 h\u00e0ng, b\u1ea1n h\u00e3y tr\u1ea3 l\u1eddi?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, 1});
                            Service.send_box_ThongBao_OK(p, "G\u1eedi y\u00eau c\u1ea7u th\u00e0nh c\u00f4ng, \u0111\u1ee3i \u0111\u1ed1i ph\u01b0\u01a1ng x\u00e1c nh\u1eadn");
                            break;
                        }
                        Service.send_box_ThongBao_OK(p, "\u0110\u1ed1i ph\u01b0\u01a1ng \u0111\u00e3 r\u1eddi \u0111i, h\u00e3y th\u1eed l\u1ea1i");
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "H\u00e3y nh\u1eadn h\u00e0ng tr\u01b0\u1edbc");
                    break;
                }
                case 984: {
                    if (p.clan == null) break;
                    switch (index) {
                        case 0: {
                            break;
                        }
                        case 1: {
                            if (p.clan.map_create != null) {
                                p.type_pk = p.clan.map_create.map_little_garden.clan1.equals(p.clan) ? (byte)4 : (byte)5;
                                Vgo vgo = new Vgo();
                                vgo.map_go = new Map[1];
                                vgo.map_go[0] = p.clan.map_create;
                                vgo.xnew = (short)350;
                                vgo.ynew = (short)260;
                                p.goto_map(vgo);
                                break;
                            }
                            boolean check_tt_tp = false;
                            for (int i = 0; i < p.clan.members.size(); ++i) {
                                if (!p.clan.members.get((int)i).name.equals(p.name) || p.clan.members.get((int)i).levelInclan != 0 && p.clan.members.get((int)i).levelInclan != 1) continue;
                                check_tt_tp = true;
                                break;
                            }
                            if (check_tt_tp) {
                                if (p.tableTickOption == null) {
                                    int time_h = LocalTime.now().getHourOfDay();
                                    if ((Util.is_DayofWeek(2) || Util.is_DayofWeek(4) || Util.is_DayofWeek(6)) && time_h == 21) {
                                        int i;
                                        p.tableTickOption = new TableTickOption();
                                        p.tableTickOption.listP = new ArrayList<Player>();
                                        p.tableTickOption.idDialog = 0;
                                        p.tableTickOption.listP.add(p);
                                        for (i = 0; i < p.clan.members.size(); ++i) {
                                            Player p0 = Map.get_player_by_name_allmap(p.clan.members.get((int)i).name);
                                            if (p0 == null || p0.index_map == p.index_map || !p0.map.equals(p.map)) continue;
                                            p.tableTickOption.listP.add(p0);
                                        }
                                        p.tableTickOption.list_check = new byte[p.tableTickOption.listP.size()];
                                        p.tableTickOption.list_check[0] = 1;
                                        for (i = 1; i < p.tableTickOption.list_check.length; ++i) {
                                            p.tableTickOption.list_check[i] = 0;
                                        }
                                        TableTickOption.show_table(p, "Ph\u00f3 b\u1ea3n kh\u1ed5ng l\u1ed3");
                                        break;
                                    }
                                    Service.send_box_ThongBao_OK(p, "Ph\u00f3 b\u1ea3n ho\u1ea1t \u0111\u1ed9ng v\u00e0o 21h t\u1ed1i th\u1ee9 3, 5, 7");
                                    break;
                                }
                                Service.send_box_ThongBao_OK(p, "B\u0103ng \u0111\u00e3 \u0111\u0103ng k\u00fd, \u0111ang ch\u1edd gh\u00e9p \u0111\u1ed9i!");
                                break;
                            }
                            Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng ph\u1ea3i thuy\u1ec1n tr\u01b0\u1edfng");
                        }
                    }
                    break;
                }
                case 985: {
                    if (p.ship_pet != null) break;
                    p.typePirate = index == 0 || index == 1 || index == 2 ? (int)index : -1;
                    p.update_info_to_all();
                    break;
                }
                case 986: {
                    MenuController.Menu_VanChuyenHang(p, index);
                    break;
                }
                case 987: {
                    if (index != 0) break;
                    Message m = new Message(-19);
                    m.writer().writeByte(118);
                    m.writer().writeUTF("C\u1eeda h\u00e0ng t\u00edch l\u0169y n\u1ea1p");
                    m.writer().writeByte(11);
                    m.writer().writeShort(ShopTichLuy.ENTRY.size());
                    for (int i = 0; i < ShopTichLuy.ENTRY.size(); ++i) {
                        ShopTichLuy temp = ShopTichLuy.ENTRY.get(i);
                        m.writer().writeShort(temp.id);
                        m.writer().writeByte(temp.type);
                        switch (temp.type) {
                            case 4: {
                                ItemTemplate4 temp4 = ItemTemplate4.get_it_by_id(temp.id);
                                m.writer().writeUTF(temp4.name);
                                m.writer().writeShort(temp4.icon);
                                break;
                            }
                            case 7: {
                                ItemTemplate7 temp7 = ItemTemplate7.get_it_by_id(temp.id);
                                m.writer().writeUTF(temp7.name);
                                m.writer().writeShort(temp7.icon);
                                break;
                            }
                            case 105: {
                                ItemFashion temp105 = ItemFashion.get_item(temp.id);
                                m.writer().writeUTF(temp105.name);
                                m.writer().writeShort(temp105.idIcon);
                                break;
                            }
                        }
                        String info = temp.info + "\n" + temp.point + " \u0111i\u1ec3m t\u00edch l\u0169y.";
                        if (temp.limit > 0) {
                            int time = 0;
                            if (temp.limit_data.containsKey(p.name)) {
                                time = temp.limit_data.get(p.name);
                            }
                            info = info + "\n\u0110\u1ed5i t\u1ed1i \u0111a: " + temp.limit + " l\u1ea7n.\nHi\u1ec7n t\u1ea1i \u0111\u00e3 \u0111\u1ed5i: " + time + "/" + temp.limit + ".";
                        }
                        m.writer().writeUTF(info);
                    }
                    p.conn.addmsg(m);
                    m.cleanup();
                    break;
                }
                case 988: {
                    if (index >= 0 && index <= 12 && p.dungeon == null) {
                        byte save = index;
                        p.data_yesno = new int[]{save};
                        if (save < 7) {
                            Service.send_box_yesno(p, 52, "Th\u00f4ng b\u00e1o", "V\u00e0o ph\u00f3 b\u1ea3n \u0111\u01a1n c\u1ea5p \u0111\u1ed9 " + (index + 3) + " c\u1ea7n 1 ch\u00eca kh\u00f3a ph\u00f3 b\u1ea3n", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, 1});
                            break;
                        }
                        Service.send_box_yesno(p, 52, "Th\u00f4ng b\u00e1o", "V\u00e0o ph\u00f3 b\u1ea3n \u0111\u01a1n c\u1ea5p \u0111\u1ed9 " + (index + 3) + " c\u1ea7n 2 ch\u00eca kh\u00f3a ph\u00f3 b\u1ea3n", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, 1});
                        break;
                    }
                    p.dungeon.mobs.clear();
                    for (int i = 0; i < p.dungeon.maps.size(); ++i) {
                        p.dungeon.maps.get(i).stop_map();
                    }
                    p.dungeon = null;
                    Service.send_box_ThongBao_OK(p, "C\u00f3 l\u1ed7i x\u1ea3y ra");
                    break;
                }
                case 989: {
                    if (index == 0) {
                        EventSpecial.show_table(p, 0);
                        break;
                    }
                    if (index != 1) break;
                    TaiXiuInfo t = Manager.gI().TaiXiu().get_my_result(p);
                    if (t != null) {
                        if (t.isReceive == 0) {
                            t.isReceive = 1;
                            p.update_vang(t.money);
                            p.update_money();
                            Service.send_box_ThongBao_OK(p, "Nh\u1eadn " + t.money + " beri");
                            Manager.gI().TaiXiu().remove_result(p);
                            break;
                        }
                        Service.send_box_ThongBao_OK(p, "\u0110\u00e3 nh\u1eadn r\u1ed3i!");
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "Kh\u00f4ng th\u1ea5y th\u00f4ng tin");
                    break;
                }
                case 990: {
                    break;
                }
                case -140: {
                    if (index == 0) {
                        MenuController.send_dynamic_menu(p, 980, "WIPPER", new String[]{"Gh\u00e9p s\u00e1ch c\u00f4ng th\u1ee9c", "Gh\u00e9p v\u1ecf \u1ed1c", "Ch\u1ebf t\u1ea1o dial", "C\u01b0\u1eddng h\u00f3a dial", "\u0110\u1ee5c l\u1ed7 dial"}, null);
                        break;
                    }
                    if (index != 1) break;
                    if (p.party == null || p.party.list.size() != 2 || !p.party.list.get((int)0).name.equals(p.name)) {
                        Service.send_box_ThongBao_OK(p, "H\u00e3y t\u1ea1o nh\u00f3m 2 ng\u01b0\u1eddi \u0111\u1ec3 v\u00e0o ph\u00f3 b\u1ea3n");
                        return;
                    }
                    Service.send_box_yesno(p, 56, "Th\u00f4ng b\u00e1o", "Ph\u00f3 b\u1ea3n th\u1eed th\u00e1ch v\u1ec7 th\u1ea7n m\u1ed7i l\u1ea7n \u0111i t\u1ed1n 1 ch\u00eca kh\u00f3a, x\u00e1c nh\u1eadn v\u00e0o?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, 1});
                    break;
                }
                case -86: {
                    break;
                }
                case -77: {
                    break;
                }
                case -73: {
                    break;
                }
                case -84: {
                    if (p.clan != null) {
                        MenuController.Menu_Clan(p, index);
                        break;
                    }
                    if (index == 0) {
                        Service.input_text(p, 10, "\u0110\u0103ng k\u00fd b\u0103ng (2000 Ruby)", new String[]{"T\u00ean b\u0103ng"});
                        break;
                    }
                    if (index != 1) break;
                    String txt = "B\u0103ng H\u1ea3i T\u1eb7c\n Gi\u1edd \u0111\u00e2y b\u1ea1n c\u00f3 th\u1ec3 t\u1eadp trung c\u00e1c ng\u01b0\u1eddi b\u1ea1n c\u1ee7a m\u00ecnh l\u1ea1i \u0111\u1ec3 t\u1ea1o th\u00e0nh 1 nh\u00f3m c\u00f9ng nhau luy\u1ec7n t\u1eadp v\u00e0 tham gia c\u00e1c ho\u1ea1t \u0111\u1ed9ng d\u00e0nh ri\u00eang cho nh\u00f3m r\u1ed3i. \bN\u1ebfu l\u00e0 thuy\u1ec1n Tr\u01b0\u1edfng b\u1ea1n s\u1ebd c\u00f3 m\u1ecdi quy\u1ec1n h\u00e0nh trong B\u0103ng c\u1ee7a m\u00ecnh. T\u1eeb thay \u0111\u1ed5i Icon B\u0103ng cho t\u1edbi qu\u1ea3n l\u00fd th\u00e0nh vi\u00ean, mua s\u1eed d\u1ee5ng v\u1eadt ph\u1ea9m, c\u1ed9ng \u0111i\u1ec3m ti\u1ec1m n\u0103ng , hay th\u00f4ng b\u00e1o to\u00e0n B\u0103ng.\bThuy\u1ec1n ph\u00f3 b\u1ea1n s\u1ebd \u0111\u01b0\u1ee3c Th\u00f4ng b\u00e1o to\u00e0n Clan v\u00e0 qu\u1ea3n l\u00fd th\u00e0nh vi\u00ean. C\u00f2n Hoa ti\u00eau th\u00ec Qu\u1ea3n l\u00fd th\u00e0nh vi\u00ean l\u00e0 vi\u1ec7c b\u1ea1n c\u00f3 th\u1ec3 l\u00e0m.\bNgo\u00e0i ra th\u00ec t\u1eb7ng qu\u00e0, l\u00e0m nhi\u1ec7m v\u1ee5, \u0111\u00f3ng g\u00f3p hay nh\u1eadn c\u00e1c l\u1ee3i \u00edch t\u1eeb c\u00e1c v\u1eadt ph\u1ea9m B\u0103ng th\u00ec t\u1ea5t c\u1ea3 m\u1ecdi ng\u01b0\u1eddi \u0111\u1ec1u c\u00f3.\bH\u00e3y tham gia v\u00e0o B\u0103ng ngay s\u1ebd c\u00f3 r\u1ea5t nhi\u1ec1u ho\u1ea1t \u0111\u1ed9ng hay v\u00e0 th\u00fa v\u1ecb m\u00e0 ch\u1ec9 d\u00e0nh cho B\u0103ng H\u1ea3i t\u1eb7c th\u00f4i nh\u00e9. ";
                    Service.Help_From_Server(p, -84, txt);
                    break;
                }
                case -138: {
                    MenuController.Menu_Law(p, index);
                    break;
                }
                case 991: {
                    switch (index) {
                        case 0: {
                            Rebuild_Item.show_table(p, 6);
                            break;
                        }
                        case 1: {
                            Rebuild_Item.show_table(p, 7);
                            break;
                        }
                        case 2: {
                            Rebuild_Item.show_table(p, 8);
                        }
                    }
                    break;
                }
                case -106: 
                case -91: 
                case -71: 
                case -48: {
                    MenuController.Menu_Zosaku(p, index);
                    break;
                }
                case 992: {
                    Join_Item.show_table(p, index);
                    break;
                }
                case 993: {
                    switch (index) {
                        case 0: {
                            Service.input_text(p, 4, "\u0110\u1ed5i Extol Sang Ruby", new String[]{"Ruby mu\u1ed1n \u0111\u1ed5i"});
                            break;
                        }
                        case 1: {
                            Service.send_box_yesno(p, 10, "Th\u00f4ng b\u00e1o", "B\u1ea1n mu\u1ed1n \u0111\u1ed5i 1000 ruby sang 750.000 extol?", new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{2, 1});
                            break;
                        }
                        case 2: {
                            Service.send_box_ThongBao_OK(p, "\u0110ang b\u1ea3o tr\u00ec, anh em l\u00ean web n\u1ea1p nha");
                            break;
                        }
                        case 3: {
                            Service.input_text(p, 1, "Qu\u00e0 t\u1eb7ng m\u00e1y ch\u1ee7", new String[]{"Nh\u1eadp giftcode"});
                            break;
                        }
                        case 4: {
                            if (p.conn.status != 1) {
                                Service.send_box_ThongBao_OK(p, "Ch\u01b0a K\u00edch ho\u1ea1t kh\u00f4ng th\u1ec3 \u0111\u1ed5i coin");
                                return;
                            }
                            Service.input_text(p, 8, "\u0110\u1ed5i Coin Sang Ruby", new String[]{"10 coin = 2 ruby"});
                            break;
                        }
                        case 5: {
                            if (p.conn.status != 1) {
                                Service.send_box_ThongBao_OK(p, "Ch\u01b0a K\u00edch ho\u1ea1t kh\u00f4ng th\u1ec3 \u0111\u1ed5i Beri");
                                return;
                            }
                            Service.input_text(p, 9, "\u0110\u1ed5i Coin Sang Beri", new String[]{"1 coin = 5000 beri"});
                            break;
                        }
                        case 6: {
                            Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111ang s\u1edf h\u1eefu " + Util.number_format(p.conn.coin) + " Coin.\nN\u1ebfu b\u1ea1n v\u1eeba \u0111\u1ed5i coin vui l\u00f2ng tho\u00e1t game v\u00e0o l\u1ea1i \u0111\u1ec3 xem ch\u00ednh x\u00e1c coin");
                        }
                    }
                    break;
                }
                case -72: {
                    MenuController.Menu_Nami(p, index);
                    break;
                }
                case 994: {
                    if (index == 0) break;
                    if (index == 1) {
                        String txt = "Kh\u00f3a b\u1ea3o v\u1ec7\nAi c\u0169ng c\u00f3 nh\u1eefng m\u00f3n \u0111\u1ed3 m\u00ecnh r\u1ea5t qu\u00fd tr\u1ecdng v\u00e0 kh\u00f4ng mu\u1ed1n m\u1ea5t n\u00f3.\nCh\u1ee9c n\u0103ng kh\u00f3a b\u1ea3o v\u1ec7 s\u1ebd gi\u00fap b\u1ea1n l\u00e0m \u0111i\u1ec1u \u0111\u00f3.\bSau khi \u0111\u0103ng k\u00fd \u0111\u1eb7t kh\u00f3a th\u00ec c\u00e1c thao t\u00e1c c\u00f3 \u1ea3nh h\u01b0\u1edfng \u0111\u1ebfn t\u00e0i kho\u1ea3n c\u1ee7a b\u1ea1n s\u1ebd ph\u1ea3i nh\u1eadp \u0111\u00fang m\u00e3 \u0111\u1ec3 x\u00e1c nh\u1eadn \u0111\u00f3 ch\u00ednh l\u00e0 b\u1ea1n ch\u1ee9 kh\u00f4ng ph\u1ea3i ai kh\u00e1c.\bTrong m\u1ed9t l\u1ea7n \u0111\u0103ng nh\u1eadp b\u1ea1n ch\u1ec9 c\u1ea7n m\u1edf kh\u00f3a duy nh\u1ea5t 1 l\u1ea7n. N\u1ebfu c\u1ea7n bi\u1ebft th\u00eam chi ti\u1ebft vui l\u00f2ng li\u00ean h\u1ec7 admin \u0111\u1eb9p trai.";
                        switch (p.map.template.id) {
                            case 1: {
                                Service.Help_From_Server(p, -3, txt);
                                break;
                            }
                            case 9: {
                                Service.Help_From_Server(p, -15, txt);
                                break;
                            }
                            case 17: {
                                Service.Help_From_Server(p, -23, txt);
                                break;
                            }
                            case 25: {
                                Service.Help_From_Server(p, -30, txt);
                                break;
                            }
                            case 33: {
                                Service.Help_From_Server(p, -38, txt);
                                break;
                            }
                            case 49: {
                                Service.Help_From_Server(p, -69, txt);
                                break;
                            }
                            case 69: {
                                Service.Help_From_Server(p, -75, txt);
                                break;
                            }
                            case 83: {
                                Service.Help_From_Server(p, -88, txt);
                            }
                        }
                        break;
                    }
                    if (index != 2) break;
                    break;
                }
                case 995: {
                    MenuController.Select_Map_Tele_world(p, index);
                    break;
                }
                case 996: {
                    if (p.ship_pet != null) {
                        Service.send_box_ThongBao_OK(p, "Kh\u00f4ng th\u1ec3 chuy\u1ec3n map khi \u0111ang chuy\u1ec3n h\u00e0ng");
                        break;
                    }
                    MenuController.Select_Map_Tele(p, index);
                    break;
                }
                case -997: {
                    MenuController.Menu_HuongDan(p, index);
                    break;
                }
                case -100: {
                    MenuController.Menu_Robin(p, index);
                    break;
                }
                case 997: {
                    MenuController.Menu_Remove_Skill(p, index);
                    break;
                }
                case 998: {
                    MenuController.Menu_Learn_Skill(p, index);
                    break;
                }
                case 999: {
                    MenuController.startBossHunt(p, index);
                    break;
                }
                case -37: {
                    if (index < 4) {
                        MenuController.Menu_Gap(p, index);
                        break;
                    }
                    if (index != 4) break;
                    MenuController.send_dynamic_menu(p, 978, "\u0110\u00e1 h\u00e0nh tr\u00ecnh", new String[]{"Kho h\u00e0nh tr\u00ecnh", "B\u1ea3n \u0111\u1ed3 h\u00e0nh tr\u00ecnh", "H\u01b0\u1edbng d\u1eabn"}, null);
                    break;
                }
                case -4: {
                    MenuController.Menu_Gap(p, index);
                    break;
                }
                case -145: 
                case -122: 
                case -118: 
                case -103: 
                case -87: 
                case -74: 
                case -67: 
                case -45: 
                case -31: 
                case -21: 
                case -13: 
                case -1: {
                    MenuController.Menu_TruongLang(p, index);
                    break;
                }
                case 120: {
                    break;
                }
                case -133: {
                    MenuController.Menu_Buggi(p, index);
                    break;
                }
                case 9999: {
                    MenuController.Menu_Admin(p, index);
                    break;
                }
                case 32003: {
                    int[] shop_pos = new int[4];
                    int pos = 0;
                    for (int i = 0; i < 5; ++i) {
                        if (i + 1 == p.clazz) continue;
                        shop_pos[pos++] = i;
                    }
                    Service.Send_UI_Shop(p, shop_pos[index]);
                    break;
                }
                case 32002: {
                    switch (index) {
                        case 0: {
                            Service.Send_UI_Shop(p, 6);
                            break;
                        }
                        case 1: 
                        case 2: {
                            UpgradeDevil.show_table(p, index);
                        }
                    }
                    break;
                }
                case 32001: {
                    MenuController.Menu_KhamNgoc(p, index);
                    break;
                }
                case 32000: {
                    MenuController.Menu_Rebuilt_Item(p, index);
                    break;
                }
                case -105: 
                case -90: 
                case -70: 
                case -47: {
                    MenuController.Menu_Johny(p, index);
                    break;
                }
                case -147: 
                case -120: 
                case -116: 
                case -102: 
                case -89: 
                case -76: 
                case -68: 
                case -46: 
                case -39: 
                case -29: 
                case -22: 
                case -14: 
                case -2: {
                    MenuController.Menu_Machiko(p, index);
                    break;
                }
                case -146: 
                case -121: 
                case -117: 
                case -101: 
                case -88: 
                case -75: 
                case -69: 
                case -38: 
                case -30: 
                case -23: 
                case -15: 
                case -3: {
                    MenuController.Menu_Guru(p, index);
                    break;
                }
                case -144: 
                case -132: 
                case -124: 
                case -107: 
                case -97: 
                case -85: 
                case -82: 
                case -60: 
                case -44: 
                case -36: 
                case -28: 
                case -20: 
                case -12: 
                case -5: 
                case 0: {
                    MenuController.Show_List_Map_Tele(p, index, idNPC);
                }
            }
        }
    }

    private static void Menu_LucThuc(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                String notice = "\u0110i\u1ec1u ki\u1ec7n c\u1ea7n \u0111\u1ec3 c\u00f3 th\u1ec3 luy\u1ec7n L\u1ee5c Th\u1ee9c:\r\n\u2022 \u0110\u1ea1t 8000 \u0111i\u1ec3m Doriki\r\n\u2022 \u00cdt nh\u1ea5t l\u00e0 lv 70\r\n\u2022 S\u1ee9c M\u1ea1nh V\u1eadt L\u00fd \u0111\u1ea1t t\u1ed1i \u0111a \r\n- Khi t\u00edch \u0111\u1ee7 kinh nghi\u1ec7m \u0111\u1ebfn npc: Buggi \u0111\u1ec3 t\u0103ng c\u1ea5p.\r\n- Ph\u00ed m\u1ed7i c\u1ea5p l\u00e0 10 tri\u1ec7u beri v\u00e0 3.000 ruby, 500 exp L\u1ee5c Th\u1ee9c, 100% t\u1ef7 l\u1ec7 th\u00e0nh c\u00f4ng.\r\n- Khi c\u1ea3nh gi\u1edbi \u0111\u1ea1t \u0111\u1ebfn Cao C\u1ea5p, \u0111\u1ebfn npc: Buggi \u0111\u1ec3 \u0111\u1ed9t ph\u00e1.\r\nPh\u00ed \u0111\u1ed9t ph\u00e1 l\u00e0 20 tri\u1ec7u beri v\u00e0 5.000 ruby, 1000 exp L\u1ee5c Th\u1ee9c  10% t\u1ef7 l\u1ec7 th\u00e0nh c\u00f4ng.";
                Service.send_box_ThongBao_OK(p, notice);
                break;
            }
            case 1: {
                if (p.level >= 110 && p.doriki[0] >= 8 && p.sucmanhvatly == 12) {
                    LucThuc.start(p);
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Ch\u01b0a \u0111\u1ee7 \u0111i\u1ec1u ki\u1ec7n \u0111\u1ec3 c\u00f3 th\u1ec3 luy\u1ec7n l\u1ee5c th\u1ee9c");
                break;
            }
            case 2: {
                LucThuc.send_info(p);
                break;
            }
            default: {
                Service.send_box_ThongBao_OK(p, "Ch\u01b0a c\u00f3 ch\u1ee9c n\u0103ng");
            }
        }
    }

    private static void Menu_Doriki(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                String notice = " M\u1ed7i Doriki g\u1ed3m c\u00f3 5 c\u1ea5p\r\n- T\u1ef7 l\u1ec7 n\u00e2ng c\u1ea5p th\u00e0nh c\u00f4ng l\u00e0 30% \r\n- Khi n\u00e2ng c\u1ea5p c\u1ea7n  beri v\u00e0 ruby. \r\n- M\u1ed7i c\u1ea5p c\u1ea7n  5 tri\u1ec7u beri, 2.000 ruby.\r\n- Khi n\u00e2ng cao m\u1ed7i c\u1ea5p ng\u01b0\u1eddi ch\u01a1i s\u1ebd nh\u1eadn \u0111c:\r\n+ 1% s\u00e1t th\u01b0\u01a1ng \r\n+ 1% m\u00e1u\r\n+ 1% mana\r\n+ 1% ph\u00f2ng th\u1ee7.";
                Service.send_box_ThongBao_OK(p, notice);
                break;
            }
            case 1: {
                Doriki.start(p);
                break;
            }
            case 2: {
                Doriki.send_info(p);
                break;
            }
            default: {
                Service.send_box_ThongBao_OK(p, "Ch\u01b0a c\u00f3 ch\u1ee9c n\u0103ng");
            }
        }
    }

    private static void Menu_SucManhVatLy(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                String notice = "Ch\u1ee9c n\u0103ng S\u1ee9c M\u1ea1nh V\u1eadt L\u00fd:\r\n+T\u1ed5ng c\u1ed9ng c\u00f3 12 t\u1ea7ng \r\n\u0110i\u1ec1u ki\u1ec7n \u0111\u1ec3 \u0111\u1ed9t ph\u00e1:\r\n\u2022 C\u00e1c h\u1ea3i t\u1eb7c ph\u1ea3i tr\u00ean lv 60 \r\n\u2022 5 tri\u1ec7u beri \u2022 2.000 ruby \r\n- T\u1ef7 l\u1ec7 th\u00e0nh c\u00f4ng 30% \r\nM\u1ed7i c\u1ea5p s\u1ebd \u0111\u1ea1t \u0111c:\r\n+ 200 s\u00e1t th\u01b0\u01a1ng \r\n+ 200 ph\u00f2ng th\u1ee7\r\n+ 2% Ch\u00ed M\u1ea1ng\r\n+ 2% Xuy\u00ean gi\u00e1p\r\n+ 2000 m\u00e1u\r\n+ 2000 mana";
                Service.send_box_ThongBao_OK(p, notice);
                break;
            }
            case 1: {
                if (p.level < 60) {
                    Service.send_box_ThongBao_OK(p, "Level ch\u01b0a \u0111\u1ee7, c\u1ea7n c\u1ea5p 60 tr\u1edf l\u00ean");
                    break;
                }
                SucManhVatLy.start(p);
                break;
            }
            case 2: {
                SucManhVatLy.send_info(p);
                break;
            }
            default: {
                Service.send_box_ThongBao_OK(p, "Ch\u01b0a c\u00f3 ch\u1ee9c n\u0103ng");
            }
        }
    }

    private static void Menu_VanChuyenHang(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                if (p.map.template.id == 1) {
                    if (p.typePirate == 0) {
                        if (p.time_ship >= 5) {
                            Service.send_box_ThongBao_OK(p, "H\u00f4m nay \u0111\u00e3 v\u1eadn chuy\u1ebfn t\u1ed1i \u0111a!");
                            return;
                        }
                        if (p.ship_pet == null) {
                            Ship.show_table(p);
                            break;
                        }
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111ang c\u00f3 g\u00f3i h\u00e0ng!");
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n ph\u1ea3i \u0111\u0103ng k\u00fd l\u00e0 l\u00e1i bu\u00f4n!");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Ch\u1ec9 c\u00f3 th\u1ec3 b\u1eaft \u0111\u1ea7u v\u1eadn chuy\u1ec3n h\u00e0ng t\u1eeb l\u00e0ng c\u1ed1i xay gi\u00f3!");
                break;
            }
            case 1: {
                if (p.id_ship_packet != -1 && p.ship_pet != null && (p.map.template.id == 9 || p.map.template.id == 17 || p.map.template.id == 25)) {
                    if (p.id_ship_packet != -1) {
                        Player p0;
                        if (!p.ship_pet.map.equals(p.map) || Math.abs(p.ship_pet.x - p.x) >= 150 || Math.abs(p.ship_pet.y - p.y) >= 150) {
                            Service.send_box_ThongBao_OK(p, "Ta kh\u00f4ng th\u1ea5y v\u1eadt ph\u1ea9m bu\u00f4n c\u1ee7a ng\u01b0\u01a1i!");
                            return;
                        }
                        if (p.typePirate == 0 && p.time_ship >= 5) {
                            Service.send_box_ThongBao_OK(p, "H\u00f4m nay \u0111\u00e3 v\u1eadn chuy\u1ebfn t\u1ed1i \u0111a!");
                            return;
                        }
                        int beri_total = 0;
                        switch (p.id_ship_packet) {
                            case 36: {
                                beri_total = 30000;
                                break;
                            }
                            case 37: {
                                beri_total = 100000;
                                break;
                            }
                            case 38: {
                                beri_total = 200000;
                                break;
                            }
                            case 39: {
                                beri_total = 400000;
                            }
                        }
                        if (p.map.template.id == 17) {
                            beri_total = beri_total * 15 / 10;
                        } else if (p.map.template.id == 25) {
                            beri_total *= 2;
                        }
                        if (p.typePirate == 2) {
                            beri_total = beri_total * 3 / 10;
                        }
                        p.update_vang(beri_total);
                        Message m = new Message(3);
                        m.writer().writeShort(p.ship_pet.index_map);
                        m.writer().writeByte(2);
                        for (int i = 0; i < p.map.players.size(); ++i) {
                            p0 = p.map.players.get(i);
                            if (p0 == null || p0.conn == null) continue;
                            p0.conn.addmsg(m);
                        }
                        m.cleanup();
                        Ship_pet.remv(p.ship_pet);
                        String name_BaoVe = p.ship_pet.mainBaoVe;
                        p.ship_pet = null;
                        p.id_ship_packet = (short)-1;
                        if (!name_BaoVe.isEmpty()) {
                            p0 = Map.get_player_by_name_allmap(name_BaoVe);
                            if (p0 != null && p0.name_ThoSanHaiTac.length == 1 && p0.name_ThoSanHaiTac[0].equals(p.name)) {
                                p0.update_vang(beri_total /= 3);
                                p.update_vang(-beri_total);
                                p0.update_money();
                                Service.send_box_ThongBao_OK(p0, "B\u1ea3o v\u1ec7 h\u00e0ng th\u00e0nh c\u00f4ng nh\u1eadn " + beri_total + " beri");
                                p0.name_ThoSanHaiTac = null;
                                Service.send_box_ThongBao_OK(p, "Tr\u1ea3 h\u00e0ng th\u00e0nh c\u00f4ng nh\u1eadn " + beri_total + " beri");
                            } else {
                                Service.send_box_ThongBao_OK(p, "Tr\u1ea3 h\u00e0ng th\u00e0nh c\u00f4ng nh\u1eadn " + beri_total + " beri");
                            }
                        } else {
                            Service.send_box_ThongBao_OK(p, "Tr\u1ea3 h\u00e0ng th\u00e0nh c\u00f4ng nh\u1eadn " + beri_total + " beri");
                        }
                        if (p.typePirate == 0) {
                            p.time_ship = (byte)(p.time_ship + 1);
                        }
                        p.name_ThoSanHaiTac = null;
                        p.update_money();
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng c\u00f3 g\u00f3i h\u00e0ng n\u00e0o c\u1ea3!");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Kh\u00f4ng th\u1ec3 tr\u1ea3 h\u00e0ng t\u1ea1i \u0111\u00e2y!");
                break;
            }
            case 2: {
                Service.send_box_ThongBao_OK(p, "H\u00e3y ch\u1ecdn ch\u1ee9c n\u0103ng th\u1ee3 s\u0103n h\u1ea3i t\u1eb7c v\u00e0 \u0111\u1ee9ng trong map \u0111\u1ec3 l\u00e1i bu\u00f4n thu\u00ea s\u1ebd c\u00f3 th\u00f4ng b\u00e1o");
                break;
            }
            case 3: {
                if (p.ship_pet != null) {
                    int i;
                    ArrayList<String> name = new ArrayList<String>();
                    for (i = 0; i < p.map.players.size(); ++i) {
                        if (p.map.players.get((int)i).typePirate != 1) continue;
                        name.add(p.map.players.get((int)i).name);
                    }
                    if (name.size() > 0) {
                        p.name_ThoSanHaiTac = new String[name.size()];
                        for (i = 0; i < name.size(); ++i) {
                            p.name_ThoSanHaiTac[i] = (String)name.get(i);
                        }
                        MenuController.send_dynamic_menu(p, 982, "Ch\u1ecdn th\u1ee3 s\u0103n h\u1ea3i t\u1eb7c", p.name_ThoSanHaiTac, null);
                        break;
                    }
                    MenuController.send_dynamic_menu(p, 982, "Ch\u1ecdn th\u1ee3 s\u0103n h\u1ea3i t\u1eb7c", new String[]{"Tr\u1ed1ng"}, null);
                    break;
                }
                Service.send_box_ThongBao_OK(p, "H\u00e3y nh\u1eadn h\u00e0ng tr\u01b0\u1edbc");
                break;
            }
            case 4: {
                if (p.ship_pet == null) {
                    Message m = new Message(-20);
                    m.writer().writeByte(1);
                    m.writer().writeShort(985);
                    m.writer().writeByte(0);
                    m.writer().writeUTF("\u0110\u0103ng k\u00fd ch\u1ee9c n\u0103ng");
                    m.writer().writeByte(4);
                    String[] name = new String[]{"L\u00e1i bu\u00f4n", "Th\u1ee3 s\u0103n H\u1ea3i T\u1eb7c", "H\u1ea3i T\u1eb7c", "Kh\u00f4ng \u0111\u0103ng k\u00fd"};
                    for (int i = 0; i < 4; ++i) {
                        m.writer().writeUTF(name[i]);
                        m.writer().writeByte(0);
                        if (p.typePirate == i) {
                            m.writer().writeByte(3);
                            continue;
                        }
                        m.writer().writeByte(7);
                    }
                    p.conn.addmsg(m);
                    m.cleanup();
                    break;
                }
                Service.send_box_ThongBao_OK(p, "H\u1ee7y chuy\u1ebfn h\u00e0ng hi\u1ec7n t\u1ea1i tr\u01b0\u1edbc khi th\u1ef1c hi\u1ec7n ch\u1ee9c n\u0103ng n\u00e0y");
                break;
            }
            case 5: {
                if (p.ship_pet == null) break;
                if (p.ship_pet.map != null) {
                    p.ship_pet.map.remove_obj(p.ship_pet.index_map, 0);
                }
                Ship_pet.remv(p.ship_pet);
                p.ship_pet = null;
                p.id_ship_packet = (short)-1;
                Service.send_box_ThongBao_OK(p, "H\u1ee7y chuy\u1ebfn bu\u00f4n th\u00e0nh c\u00f4ng");
                break;
            }
            case 6: {
                if (p.ship_pet != null) {
                    if (p.map.template.id > p.ship_pet.id_map_save) {
                        Service.send_box_ThongBao_OK(p, "Hi\u1ec7n t\u1ea1i ch\u1ec9 c\u00f3 th\u1ec3 g\u1ecdi l\u1ea1c \u0111\u00e0 t\u1eeb " + Map.get_map_by_id((int)p.ship_pet.id_map_save)[0].template.name + " tr\u1edf l\u1ea1i");
                        return;
                    }
                    if (p.ship_pet.map != null) {
                        p.ship_pet.map.remove_obj(p.ship_pet.index_map, 0);
                    }
                    int index_map_new = -3;
                    p.ship_pet.index_map = (short)index_map_new;
                    p.ship_pet.map = p.map;
                    p.ship_pet.x = p.x;
                    p.ship_pet.y = p.y;
                    Message m_local = new Message(1);
                    m_local.writer().writeByte(0);
                    m_local.writer().writeShort(p.ship_pet.index_map);
                    m_local.writer().writeShort(p.ship_pet.x);
                    m_local.writer().writeShort(p.ship_pet.y);
                    for (int j = 0; j < p.map.players.size(); ++j) {
                        Player p0 = p.map.players.get(j);
                        if (p0 == null || p0.conn == null) continue;
                        p0.conn.addmsg(m_local);
                    }
                    m_local.cleanup();
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Kh\u00f4ng t\u00ecm th\u1ea5y chuy\u1ebfn h\u00e0ng");
                break;
            }
            case 7: {
                if (p.ship_pet != null && p.ship_pet.map != null) {
                    Service.send_box_ThongBao_OK(p, "V\u1ecb tr\u00ed: " + p.ship_pet.map.template.name + " khu " + (p.ship_pet.map.zone_id + 1) + " t\u1ecda \u0111\u1ed9 " + p.ship_pet.x + " " + p.ship_pet.y);
                    break;
                }
                p.ship_pet = null;
                Service.send_box_ThongBao_OK(p, "Kh\u00f4ng t\u00ecm th\u1ea5y chuy\u1ebfn h\u00e0ng");
                break;
            }
            case 8: {
                Service.send_box_ThongBao_OK(p, "H\u00f4m nay \u0111\u00e3 ho\u00e0n th\u00e0nh " + p.time_ship + " chuy\u1ebfn");
            }
        }
    }

    private static void Menu_Clan(Player p, byte index) throws IOException {
        if (p.clan == null || index > 2 && !p.clan.members.get((int)0).name.equals(p.name)) {
            return;
        }
        switch (index) {
            case 0: {
                Clan_member clan_mem = null;
                for (int i = 0; i < p.clan.members.size(); ++i) {
                    if (!p.clan.members.get((int)i).name.equals(p.name)) continue;
                    clan_mem = p.clan.members.get(i);
                    break;
                }
                if (clan_mem == null) break;
                if (clan_mem.numquest >= 3) {
                    Service.send_box_ThongBao_OK(p, "H\u00f4m nay \u0111\u00e3 h\u1ebft nhi\u1ec7m v\u1ee5, h\u00e3y quay l\u1ea1i v\u00e0o ng\u00e0y mai");
                    return;
                }
                QuestP questP = null;
                for (int i = 0; i < p.list_quest.size(); ++i) {
                    if (p.list_quest.get((int)i).template.id >= -2000) continue;
                    questP = p.list_quest.get(i);
                    break;
                }
                if (questP == null) {
                    Service.send_box_yesno(p, 42, "Th\u00f4ng b\u00e1o", "B\u1ea1n mu\u1ed1n nh\u1eadn nhi\u1ec7m v\u1ee5 B\u0103ng h\u1ea3i t\u1eb7c c\u1ea5p " + (clan_mem.numquest + 1), new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{-1, -1});
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Nhi\u1ec7m v\u1ee5 hi\u1ec7n t\u1ea1i ch\u01b0a ho\u00e0n th\u00e0nh");
                break;
            }
            case 2: {
                MenuController.send_dynamic_menu(p, 984, "Ph\u00f3 b\u1ea3n b\u0103ng", new String[]{"Ph\u00f3 b\u1ea3n PVP", "Ph\u00f3 b\u1ea3n kh\u1ed5ng l\u1ed3"}, null);
                break;
            }
            case 3: {
                MenuController.send_dynamic_menu(p, 979, "Icon b\u0103ng", new String[]{"C\u1eeda h\u00e0ng th\u01b0\u1eddng", "C\u1eeda h\u00e0ng cao c\u1ea5p"}, null);
                break;
            }
            case 4: {
                Message m = new Message(-19);
                m.writer().writeByte(110);
                m.writer().writeUTF("C\u1eeda h\u00e0ng v\u1eadt ph\u1ea9m b\u0103ng");
                m.writer().writeByte(8);
                m.writer().writeShort(ItemTemplate8.ENTRYS.size());
                for (int i = 0; i < ItemTemplate8.ENTRYS.size(); ++i) {
                    m.writer().writeShort(i);
                    m.writer().writeShort(1);
                }
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 5: {
                if (p.clan.allowRequest == 1) {
                    p.clan.allowRequest = 0;
                    Service.send_box_ThongBao_OK(p, "Kh\u00f3a m\u1ecdi ng\u01b0\u1eddi xin v\u00e0o b\u0103ng th\u00e0nh c\u00f4ng");
                    break;
                }
                p.clan.allowRequest = 1;
                Service.send_box_ThongBao_OK(p, "Cho ph\u00e9p m\u1ecdi ng\u01b0\u1eddi xin v\u00e0o b\u0103ng th\u00e0nh c\u00f4ng");
            }
        }
    }

    private static void Menu_Law(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                if (p.item.it_heart == null) {
                    String text = "\u0110\u1ec3 c\u00f3 th\u1ec3 t\u00e1ch tim \u0111\u01b0\u1ee3c b\u1ea1n s\u1ebd m\u1ea5t %s b\u1ed9t v\u00e0ng, %s \u0111\u00e1 \u00e1c qu\u1ef7, %s \u0111\u00e1 h\u1ea3i th\u1ea1ch c\u1ea5p 1, %s.000.000 beri. B\u1ea1n th\u1eadt s\u1ef1 mu\u1ed1n t\u00e1ch?";
                    Service.send_box_yesno(p, 27, "Th\u00f4ng b\u00e1o", String.format(text, p.level < 40 ? 120 : 100, p.level < 40 ? 120 : 100, p.level < 40 ? 120 : 100, p.level < 40 ? 12 : 10), new String[]{"\u0110\u1ed3ng \u00fd", "H\u1ee7y"}, new byte[]{-1, -1});
                    break;
                }
                if (p.item.it_heart.levelup > 98) {
                    Service.send_box_ThongBao_OK(p, "\u0110\u00e3 n\u00e2ng c\u1ea5p t\u1ed1i \u0111a");
                    break;
                }
                UpgradeItem.show_table_upgrade_heart(p);
                break;
            }
            case 1: {
                String txt = "CH\u1ee8C N\u0102NG T\u00c1CH TR\u00c1I TIM\b\u0110\u01b0\u1ee3c m\u1ec7nh danh l\u00e0 b\u00e1c s\u0129 t\u1eed th\u1ea7n\nLaw ch\u1ee9a n\u0103ng l\u1ef1c c\u1ef1c k\u1ef3 qu\u00e1i d\u1ecb\nV\u1edbi n\u0103ng l\u1ef1c \u0111\u00f3, anh ta c\u00f3 th\u1ec3 bi\u1ebfn b\u1ea5t k\u1ef3 ai tr\u1edf n\u00ean m\u1ea1nh h\u01a1n bao gi\u1edd h\u1ebft\bH\u00e3y chu\u1ea9n b\u1ecb tr\u01b0\u1edbc b\u1ed9t v\u00e0ng, \u0111\u00e1 h\u1ea3i th\u1ea1ch, \u0111\u00e1 \u00e1c qu\u1ef7 v\u00e0 beri \u0111\u1ec3 \u0111\u1ebfn g\u1eb7p Law v\u00e0 ti\u1ebfn h\u00e0nh t\u00e1ch tr\u00e1i tim\bSau khi t\u00e1ch tr\u00e1i tim s\u1ebd t\u0103ng 10% HP cu\u1ed1i\bB\u1ea1n c\u00f3 th\u1ec3 \u0111\u1ebfn g\u1eb7p Law \u0111\u1ec3 ph\u1eabu thu\u1eadt, gi\u00fap t\u0103ng c\u1ea5p cho qu\u1ea3 tim m\u00e1u \u0111\u01b0\u1ee3c m\u1ea1nh m\u1ebd h\u01a1n";
                Service.Help_From_Server(p, -138, txt);
                break;
            }
        }
    }

    private static void Menu_Nami(Player p, byte index) throws IOException {
        if (p.map.template.id == 17 && index == 5) {
            Market.show_table(p);
        } else {
            switch (index) {
                case 0: {
                    MenuController.send_dynamic_menu(p, 993, "Nami", new String[]{"\u0110\u1ed5i Ruby", "\u0110\u1ed5i extol", "N\u1ea1p ti\u1ec1n", "GiftCode", "\u0110\u1ed5i Ruby", "\u0110\u1ed5i Beri", "Xem Coin", "M\u00e3 qu\u00e0 t\u1eb7ng"}, new short[]{128, 128, 132, 161, 127, 162, 140, 140});
                    break;
                }
                case 1: {
                    break;
                }
                case 2: {
                    break;
                }
                case 3: {
                    MenuController.send_dynamic_menu(p, 981, "\u0110\u1ea5u gi\u00e1", new String[]{"\u0110\u1ea5u gi\u00e1"}, null);
                    break;
                }
                case 4: {
                    MenuController.send_dynamic_menu(p, 987, "\u0110i\u1ec3m t\u00edch l\u0169y", new String[]{"V\u00e0o c\u1eeda h\u00e0ng"}, null);
                }
            }
        }
    }

    private static void Menu_Zosaku(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                String[] levels = new String[10];
                for (int i = 0; i < levels.length; ++i) {
                    levels[i] = "Boss cấp " + (i + 1) * 10;
                }
                MenuController.send_dynamic_menu(p, 999, "Săn trùm", levels, null);
                break;
            }
            case 3: {
                break;
            }
            case 1: {
                Vgo vgo = new Vgo();
                vgo.map_go = Map.get_map_by_id(1000);
                if (vgo.map_go == null) break;
                boolean full = false;
                if (!full) {
                    vgo.xnew = (short)Util.random(150, 300);
                    vgo.ynew = (short)Util.random(200, 300);
                    p.goto_map(vgo);
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Map \u0111\u1ea7y h\u00e3y quay l\u1ea1i sau");
                break;
            }
            case 2: {
                if (p.party == null || p.party.list.size() < 2 || !p.party.list.get(0).equals(p)) {
                    Service.send_box_ThongBao_OK(p, "Hãy tạo nhóm ít nhất 2 người và để trưởng nhóm đăng ký");
                    break;
                }
                for (Player member : p.party.list) {
                    if (member.conn == null || member.map != p.map || Math.abs(member.x - p.x) >= 100
                        || Math.abs(member.y - p.y) >= 100 || member.get_key_boss() < 2 || member.dungeon != null) {
                        Service.send_box_ThongBao_OK(p, member.name + " cần đứng gần, có 2 chìa khóa và chưa ở trong phó bản");
                        return;
                    }
                }
                Dungeon dungeon = new Dungeon();
                dungeon.mode = zosakuDungeonMode(p.level);
                dungeon.create();
                for (Player member : p.party.list) {
                    member.update_key_boss(-2);
                    member.update_money();
                    Service.CountDown_Ticket(member);
                    member.dungeon = dungeon;
                    Vgo vgo = new Vgo();
                    vgo.map_go = new Map[]{dungeon.maps.get(0)};
                    vgo.xnew = 350;
                    vgo.ynew = 260;
                    member.goto_map(vgo);
                }
                break;
            }
            case 4: {
                if (p.map.template.id == 25) {
                    String[] name = new String[12];
                    for (int i = 0; i < name.length; ++i) {
                        name[i] = "C\u1ea5p \u0111\u1ed9 " + (i + 3);
                    }
                    short[] icon = new short[12];
                    for (int i = 0; i < icon.length; ++i) {
                        icon[i] = (short)(i < 2 ? 164 : (i < 5 ? 165 : (i < 7 ? 166 : 167)));
                    }
                    MenuController.send_dynamic_menu(p, 988, "V\u01b0\u1ee3t \u1ea3i \u0111\u01a1n", name, icon);
                    break;
                }
                if (p.map.template.id != 49) break;
                Vgo vgo = new Vgo();
                vgo.map_go = Map.get_map_by_id(119);
                if (vgo.map_go == null) break;
                boolean full = false;
                if (!full) {
                    vgo.xnew = (short)Util.random(120, 380);
                    vgo.ynew = (short)Util.random(230, 330);
                    p.goto_map(vgo);
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Map \u0111\u1ea7y h\u00e3y quay l\u1ea1i sau");
            }
        }
    }

    static int zosakuBossLevel(int index) {
        return index >= 0 && index < 10 ? (index + 1) * 10 : -1;
    }

    static short zosakuBossChestId(int index) {
        return (short)(index >= 0 && index < 10 ? 19 + index : -1);
    }

    static byte zosakuDungeonMode(int level) {
        return (byte)Math.min(11, Math.max(0, level / 10 - 3));
    }

    private static void startBossHunt(Player p, byte index) throws IOException {
        int level = zosakuBossLevel(index);
        if (level < 0 || p.map_boss_info != null) {
            Service.send_box_ThongBao_OK(p, "Không thể tạo map săn trùm lúc này");
            return;
        }
        int[] mapIds = new int[]{5, 13, 21, 29, 37, 45, 53, 73, 87, 102};
        Map mapTemplate = Map.get_map_by_id(mapIds[index])[0];
        Map arenaTemplate = Map.get_map_by_id(198)[0];
        Mob mobTemplate = null;
        for (int mobId : mapTemplate.list_mob) {
            Mob candidate = Mob.ENTRYS.get(mobId);
            if (candidate != null && (mobTemplate == null || candidate.mob_template.hp_max > mobTemplate.mob_template.hp_max)) {
                mobTemplate = candidate;
            }
        }
        if (mobTemplate == null) {
            Service.send_box_ThongBao_OK(p, "Map này chưa có dữ liệu boss");
            return;
        }

        Map bossMap = new Map();
        bossMap.template = arenaTemplate.template;
        bossMap.zone_id = 0;
        bossMap.list_mob = new int[0];
        Mob boss = new Mob();
        boss.mob_template = mobTemplate.mob_template;
        Mob arenaMob = Mob.ENTRYS.get(arenaTemplate.list_mob[0]);
        boss.x = arenaMob.x;
        boss.y = arenaMob.y;
        boss.hp_max = boss.mob_template.hp_max + Body.Point3_Template_hp[level];
        boss.hp = boss.hp_max;
        boss.level = level;
        boss.isdie = false;
        boss.id_target = -1;
        boss.index = -2;
        boss.map = bossMap;
        boss.boss_info = null;

        p.map_boss_info = new MapBossInfo();
        p.map_boss_info.map = bossMap;
        p.map_boss_info.returnMap = p.map;
        p.map_boss_info.returnX = p.x;
        p.map_boss_info.returnY = p.y;
        p.map_boss_info.rewardId = zosakuBossChestId(index);
        p.map_boss_info.mob = new ArrayList<>();
        p.map_boss_info.mob.add(boss);
        MapBossInfo.add(p.map_boss_info);
        p.map.leave_map(p, 2);
        p.map = bossMap;
        p.x = (short)Math.max(24, boss.x - 250);
        p.y = boss.y;
        p.xold = p.x;
        p.yold = p.y;
        bossMap.goto_map(p);
        Service.update_PK(p, p, true);
        Service.pet(p, p, true);
        Quest.update_map_have_side_quest(p, true);
        bossMap.start_map();
        Map.add_map_plus(bossMap);
    }

    private static void Select_Map_Tele(Player p, byte index) throws IOException {
        if (p.map_tele != null) {
            Map[] map_go = Map.get_map_by_id(p.map_tele[index]);
            if (p.map.template.id == map_go[0].template.id) {
                Service.send_box_ThongBao_OK(p, "\u0110ang \u1edf map n\u00e0y r\u1ed3i!");
            } else {
                Vgo vgo = new Vgo();
                vgo.map_go = map_go;
                for (int i = 0; i < vgo.map_go[0].template.npcs.size(); ++i) {
                    Npc npc_temp = vgo.map_go[0].template.npcs.get(i);
                    if (!npc_temp.namegt.equals("B\u1ea3n \u0111\u1ed3")) continue;
                    vgo.xnew = npc_temp.x;
                    if (npc_temp.y < 250) {
                        vgo.ynew = (short)(npc_temp.y + 20);
                        break;
                    }
                    vgo.ynew = (short)(npc_temp.y - 20);
                    break;
                }
                if (vgo.xnew == 0 || vgo.ynew == 0) {
                    vgo.xnew = (short)(vgo.map_go[0].template.maxW / 2);
                    vgo.ynew = (short)(vgo.map_go[0].template.maxH / 2);
                }
                p.goto_map(vgo);
            }
        }
        p.map_tele = null;
    }

    private static void Select_Map_Tele_world(Player p, byte index) throws IOException {
        if (p.map_tele != null && index < p.map_tele.length) {
            p.data_yesno = new int[]{index};
            Service.send_box_yesno(p, 5, "", "B\u1ea1n c\u00f3 mu\u1ed1n d\u1ecbch chuy\u1ec3n qua " + Map.get_map_by_id((int)p.map_tele[index])[0].template.name + " ?", new String[]{"20", "H\u1ee7y"}, new byte[]{6, -1});
        }
    }

    private static void Menu_HuongDan(Player p, byte index) throws IOException {
        switch (p.map.template.id) {
            case 1: {
                HelpDialog.show_LangCoiXayGio(p, index);
                break;
            }
            case 9: {
                HelpDialog.show_ThiTranVoSo(p, index);
                break;
            }
            case 17: {
                HelpDialog.show_ThiTranOrange(p, index);
                break;
            }
            case 25: {
                HelpDialog.show_LangSiRup(p, index);
                break;
            }
            case 33: {
                HelpDialog.show_ThuyenBarati(p, index);
                break;
            }
            case 41: {
                HelpDialog.show_LangHatDe(p, index);
                break;
            }
            case 49: {
                HelpDialog.show_ThiTranKhoiDau(p, index);
                break;
            }
            case 66: {
                HelpDialog.show_MomSinhDoi(p, index);
                break;
            }
            case 69: {
                HelpDialog.show_ThiTranWhiskey(p, index);
                break;
            }
            case 79: {
                HelpDialog.show_DaoLittleGrand(p, index);
            }
        }
    }

    private static void Menu_Remove_Skill(Player p, byte index) throws IOException {
        for (int i = 0; i < p.skill_point.size(); ++i) {
            Skill_info temp = p.skill_point.get(i);
            if (temp.temp.ID < 1000 || temp.temp.ID >= 2000 || temp.temp.Lv_RQ <= 0 || (index = (byte)(index - 1)) != -1) continue;
            p.data_yesno = new int[]{i};
            Service.send_box_yesno(p, 4, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 ch\u1eafc mu\u1ed1n x\u00f3a k\u1ef9 n\u0103ng " + temp.temp.name + " n\u00e0y kh\u00f4ng? Ph\u00ed x\u00f3a k\u1ef9 n\u0103ng n\u00e0y l\u00e0 2 ruby", new String[]{"2", "Kh\u00f4ng"}, new byte[]{7, -1});
            break;
        }
    }

    private static void Menu_Robin(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                EffTemplate eff = p.get_eff(3);
                if (eff != null) {
                    Service.send_box_ThongBao_OK(p, "Th\u1eddi gian x2 k\u1ef9 n\u0103ng EXP c\u00f2n l\u1ea1i " + Util.get_time_str_by_sec2(eff.time - System.currentTimeMillis()) + "\nL\u01b0u \u00fd c\u1ed9ng d\u1ed3n t\u1ed1i \u0111a 7 ng\u00e0y");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Th\u1eddi gian x2 k\u1ef9 n\u0103ng EXP c\u00f2n l\u1ea1i 0 s.");
                break;
            }
            case 1: {
                EffTemplate eff = p.get_eff(8);
                if (eff != null) {
                    Service.send_box_ThongBao_OK(p, "Th\u1eddi gian kh\u00f3a EXP c\u00f2n l\u1ea1i " + Util.get_time_str_by_sec2(eff.time - System.currentTimeMillis()) + "\nL\u01b0u \u00fd c\u1ed9ng d\u1ed3n t\u1ed1i \u0111a 30 ng\u00e0y");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "Th\u1eddi gian kh\u00f3a EXP c\u00f2n l\u1ea1i 0 s.");
                break;
            }
            case 2: {
                EffTemplate effTemplate = p.get_eff(8);
                if (effTemplate == null) break;
                effTemplate.time = 0L;
                Service.send_box_ThongBao_OK(p, "H\u1ee7y th\u00e0nh c\u00f4ng");
                break;
            }
            case 3: {
                if (p.conn.status != 1) {
                    Service.send_box_ThongBao_OK(p, "Ch\u01b0a k\u00edch ho\u1ea1t kh\u00f4ng th\u1ec3 tham gia");
                    return;
                }
                MenuController.send_dynamic_menu(p, 989, "T\u00e0i x\u1ec9u", new String[]{"Tham gia", "Nh\u1eadn th\u01b0\u1edfng"}, null);
            }
        }
    }

    private static void Menu_Learn_Skill(Player p, byte index) throws IOException {
        for (int i = 0; i < p.skill_point.size(); ++i) {
            Skill_info temp = p.skill_point.get(i);
            if ((temp.temp.ID >= 4 || temp.temp.Lv_RQ != -1) && (temp.temp.ID <= 3 || temp.temp.ID >= 2000 || temp.temp.Lv_RQ >= 5) || (index = (byte)(index - 1)) != -1) continue;
            p.data_yesno = new int[]{i};
            if (temp.temp.ID < 4) {
                Service.send_box_yesno(p, 3, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 mu\u1ed1n h\u1ecdc k\u1ef9 n\u0103ng " + temp.temp.name + "?", new String[]{"10.000", "Kh\u00f4ng"}, new byte[]{6, -1});
                break;
            }
            Skill_Template sk_temp = null;
            if (temp.temp.ID > 3 && temp.temp.ID < 2000 && temp.temp.Lv_RQ > -1) {
                sk_temp = Skill_Template.get_temp(temp.temp.indexSkillInServer + 1, 0L);
            }
            Service.send_box_yesno(p, 3, "Th\u00f4ng b\u00e1o", "B\u1ea1n c\u00f3 mu\u1ed1n h\u1ecdc chi\u00eau n\u1ed9i t\u1ea1i " + (sk_temp != null ? sk_temp.name : temp.temp.name) + "?", new String[]{"10.000", "Kh\u00f4ng"}, new byte[]{6, -1});
            break;
        }
    }

    private static void Menu_Gap(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                ArrayList<String> str_ = new ArrayList<String>();
                ArrayList<Integer> icon_ = new ArrayList<Integer>();
                for (int i = 0; i < p.skill_point.size(); ++i) {
                    Skill_info temp = p.skill_point.get(i);
                    if ((temp.temp.ID >= 4 || temp.temp.Lv_RQ != -1) && (temp.temp.ID <= 3 || temp.temp.ID >= 2000 || temp.temp.Lv_RQ >= 5)) continue;
                    if (temp.temp.ID > 3 && temp.temp.ID < 2000 && temp.temp.Lv_RQ > -1) {
                        Skill_Template sk_temp = Skill_Template.get_temp(temp.temp.indexSkillInServer + 1, 0L);
                        str_.add(sk_temp.name);
                        icon_.add(Integer.valueOf(sk_temp.idIcon));
                        continue;
                    }
                    str_.add(temp.temp.name);
                    icon_.add(Integer.valueOf(temp.temp.idIcon));
                }
                if (str_.size() == 0) {
                    str_.add("Hi\u1ec7n t\u1ea1i kh\u00f4ng c\u00f3 k\u1ef9 n\u0103ng th\u00edch h\u1ee3p \u0111\u1ec3 h\u1ecdc");
                    icon_ = null;
                }
                MenuController.send_dynamic_menu(p, 998, "H\u1ecdc k\u1ef9 n\u0103ng - Gap", str_, icon_);
                break;
            }
            case 1: {
                if (p.get_ngoc() < 5) {
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n kh\u00f4ng \u0111\u1ee7 ti\u1ec1n, h\u1ed3i \u0111i\u1ec3m ti\u1ec1m n\u0103ng ph\u1ea3i c\u1ea7n 5 Ruby.");
                    return;
                }
                Service.send_box_yesno(p, 2, "", "B\u1ea1n c\u00f3 th\u1eadt s\u1ef1 mu\u1ed1n h\u1ed3i \u0111i\u1ec3m ti\u1ec1m n\u0103ng?\nM\u1ee9c ph\u00ed l\u00e0 5 Ruby.", new String[]{"5", "H\u1ee7y"}, new byte[]{7, -1});
                break;
            }
            case 2: {
                ArrayList<String> str_ = new ArrayList<String>();
                ArrayList<Integer> icon_ = new ArrayList<Integer>();
                for (int i = 0; i < p.skill_point.size(); ++i) {
                    Skill_info temp = p.skill_point.get(i);
                    if (temp.temp.ID < 1000 || temp.temp.ID >= 2000 || temp.temp.Lv_RQ <= 0) continue;
                    str_.add(temp.temp.name);
                    icon_.add(Integer.valueOf(temp.temp.idIcon));
                }
                if (str_.size() == 0) {
                    str_ = null;
                    icon_ = null;
                }
                if (icon_ == null) {
                    MenuController.send_dynamic_menu(p, 997, "X\u00f3a k\u1ef9 n\u0103ng - Gap", new String[]{"Hi\u1ec7n t\u1ea1i ch\u01b0a h\u1ecdc n\u1ed9i t\u1ea1i g\u00ec"}, null);
                    break;
                }
                MenuController.send_dynamic_menu(p, 997, "X\u00f3a k\u1ef9 n\u0103ng - Gap", str_, icon_);
                break;
            }
            case 4: {
                if (p.level < 100) break;
                Max_Level.show_table(p);
            }
        }
    }

    private static void Menu_TruongLang(Player p, byte index) throws IOException {
        if (p.conn.status == 1) {
            index = (byte)(index + 1);
        }
        switch (index) {
            case 0: {
                p.conn.status = 1;
                p.update_status(1);
                Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 k\u00edch ho\u1ea1t th\u00e0nh c\u00f4ng!");
                break;
            }
            case 1: {
                BXH.send(p, 7, 0);
                break;
            }
            case 2: {
                BXH.send(p, 4, 0);
                break;
            }
            case 3: {
                BXH.send(p, 6, 0);
                break;
            }
            case 4: {
                BXH.send(p, 9, 0);
                break;
            }
            case 5: {
                MenuController.send_dynamic_menu(p, 978, "\u0110\u00e1 h\u00e0nh tr\u00ecnh", new String[]{"Kho h\u00e0nh tr\u00ecnh", "B\u1ea3n \u0111\u1ed3 h\u00e0nh tr\u00ecnh", "H\u01b0\u1edbng d\u1eabn"}, null);
                break;
            }
            case 6: {
                if (p.diemdanh == 0) {
                    p.diemdanh = 1;
                    int ruby = Util.random(1, 200);
                    int beri = Util.random(1, 1000000);
                    p.update_ngoc(ruby);
                    p.update_vang(beri);
                    p.update_money();
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111i\u1ec3m danh th\u00e0nh c\u00f4ng, \u0111\u01b0\u1ee3c " + ruby + " ruby " + beri + " Beri");
                    break;
                }
                Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111i\u1ec3m danh h\u00f4m nay r\u1ed3i");
                break;
            }
            case 7: {
                if (p.diemdanhvip == 0) {
                    p.diemdanhvip = 1;
                    if (p.conn.vip == 0) {
                        int ruby = 100;
                        p.update_ngoc(ruby);
                        p.update_money();
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111i\u1ec3m danh vip 0 th\u00e0nh c\u00f4ng, \u0111\u01b0\u1ee3c " + ruby + " ruby ");
                        return;
                    }
                    if (p.conn.vip == 1) {
                        int ruby = 215;
                        p.update_ngoc(ruby);
                        p.update_money();
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111i\u1ec3m danh vip 1 th\u00e0nh c\u00f4ng, \u0111\u01b0\u1ee3c " + ruby + " ruby ");
                        return;
                    }
                    if (p.conn.vip == 2) {
                        int ruby = 1000;
                        p.update_ngoc(ruby);
                        p.update_money();
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111i\u1ec3m danh vip 2 th\u00e0nh c\u00f4ng, \u0111\u01b0\u1ee3c " + ruby + " ruby ");
                        return;
                    }
                    if (p.conn.vip == 3) {
                        int ruby = 2000;
                        p.update_ngoc(ruby);
                        p.update_money();
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111i\u1ec3m danh vip 3 th\u00e0nh c\u00f4ng, \u0111\u01b0\u1ee3c " + ruby + " ruby ");
                        return;
                    }
                    if (p.conn.vip == 4) {
                        int ruby = 3000;
                        p.update_ngoc(ruby);
                        p.update_money();
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111i\u1ec3m danh vip 4 th\u00e0nh c\u00f4ng, \u0111\u01b0\u1ee3c " + ruby + " ruby ");
                        return;
                    }
                    if (p.conn.vip == 5) {
                        int ruby = 7000;
                        p.update_ngoc(ruby);
                        p.update_money();
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111i\u1ec3m danh vip 5 th\u00e0nh c\u00f4ng, \u0111\u01b0\u1ee3c " + ruby + " ruby ");
                        return;
                    }
                    if (p.conn.vip == 6) {
                        int ruby = 20000;
                        p.update_ngoc(ruby);
                        p.update_money();
                        Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111i\u1ec3m danh vip 6 th\u00e0nh c\u00f4ng, \u0111\u01b0\u1ee3c " + ruby + " ruby ");
                        return;
                    }
                    if (p.conn.vip != 7) break;
                    int ruby = 50000;
                    p.update_ngoc(ruby);
                    p.update_money();
                    Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111i\u1ec3m danh vip th\u00e0nh c\u00f4ng, \u0111\u01b0\u1ee3c " + ruby + " ruby ");
                    return;
                }
                Service.send_box_ThongBao_OK(p, "B\u1ea1n \u0111\u00e3 \u0111i\u1ec3m danh vip h\u00f4m nay r\u1ed3i");
            }
        }
    }

    private static void Menu_Buggi(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                VongQuay.show_table(p);
                break;
            }
            case 1: {
                MenuController.send_dynamic_menu(p, 991, "Ho\u00e0n m\u1ef9 - K\u00edch \u1ea9n", new String[]{"Ho\u00e0n m\u1ef9", "K\u00edch \u1ea9n", "Ph\u1ee5c h\u1ed3i ch\u1ebf t\u00e1c"}, null);
                break;
            }
            case 2: {
                Service.send_box_ThongBao_OK(p, "Ch\u1ee9c n\u0103ng ch\u01b0a ra m\u1eaft");
                break;
            }
            case 3: {
                MenuController.send_dynamic_menu(p, 1002, "L\u1ee5c Th\u1ee9c", new String[]{"H\u01b0\u1edbng d\u1eabn", "Luy\u1ec7n L\u1ee5c Th\u1ee9c", "C\u1ea3nh Gi\u1edbi"}, null);
                break;
            }
            case 4: {
                MenuController.send_dynamic_menu(p, 1003, "S\u1ee9c M\u1ea1nh V\u1eadt L\u00fd", new String[]{"H\u01b0\u1edbng d\u1eabn", "T\u0103ng S\u1ee9c M\u1ea1nh", "Th\u1ec3 Tr\u1ea1ng"}, null);
                break;
            }
            case 5: {
                MenuController.send_dynamic_menu(p, 1001, "Doriki", new String[]{"H\u01b0\u1edbng d\u1eabn", "N\u00e2ng C\u1ea5p", "Doriki"}, null);
            }
        }
    }

    private static void Menu_KhamNgoc(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                Service.Send_UI_Shop(p, 111);
                break;
            }
            case 1: 
            case 2: 
            case 3: 
            case 4: 
            case 5: {
                Rebuild_Item.show_table(p, index);
                break;
            }
            case 6: {
                Message m = new Message(-19);
                m.writer().write(DaThanThoai.data_shop);
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 7: {
                String txt = "Kh\u1ea3m v\u1eadt ph\u1ea9m g\u1ed3m 2 ch\u1ee9c n\u0103ng ch\u00ednh:\nKh\u1ea3m \u0111\u00e1 v\u00e0o v\u1eadt ph\u1ea9m\nGh\u00e9p \u0111\u00e1\bKh\u1ea3m \u0111\u00e1 v\u00e0o v\u1eadt ph\u1ea9m:\nM\u1ed7i v\u1eadt ph\u1ea9m m\u1edbi khi m\u1edf r\u01b0\u01a1ng s\u1ebd c\u00f3 ng\u1eabu nhi\u00ean c\u00e1c L\u1ed7 Kh\u1ea3m d\u1ec3 b\u1ea1n c\u00f3 th\u1ec3 g\u1eafn nh\u1eefng vi\u00eand \u0111\u00e1 \u0111\u1eb7c bi\u1ec7t v\u00e0o gi\u00fap t\u0103ng s\u1ee9c m\u1ea1nh cho b\u1ea3n th\u00e2n.\bB\u1ea1n c\u00f3 th\u1ec3 \u0111\u1ee5c l\u1ed7 \u0111\u1ec3 c\u00f3 th\u1ec3 g\u1eafn \u0111\u01b0\u1ee3c nhi\u1ec1u \u0111\u00e1 h\u01a1n (t\u1ed1i \u0111a 2 l\u1ea7n).\nNgo\u00e0i ra c\u00f2n c\u00f3 ch\u1ee9c n\u0103ng l\u1ea5y \u0111\u00e1 t\u1eeb v\u1eadt ph\u1ea9m \u0111\u00e3 kh\u1ea3m \u0111\u1ec3 g\u1eafn v\u00e0o v\u1eadt ph\u1ea9m m\u1edbi.\bGh\u00e9p \u0111\u00e1:\n\u0110\u00e1 kh\u1ea3m r\u1ea9t \u0111a d\u1ea1ng v\u00e0 m\u1ed7i lo\u1ea1i c\u00f3 6 c\u1ea5p \u0111\u1ed9 kh\u00e1c nhau.\bB\u1ea1n c\u00f3 th\u1ec3 d\u00f9ng 3 vi\u00ean \u0111\u00e1 c\u1ea5p th\u1ea5p \u0111\u1ec3 gh\u00e9p th\u00e0nh vi\u00ean \u0111\u00e1 c\u1ea5p cao h\u01a1n c\u00f9ng lo\u1ea1i.";
                Service.Help_From_Server(p, -47, txt);
                break;
            }
        }
    }

    private static void Menu_Admin(Player p, byte index) throws IOException {
        if (p.conn.user.equals("admin")) {
            switch (index) {
                case 0: {
                    new Thread(() -> {
                        System.out.println("START CLOSE SERVER");
                        SaveData.process();
                        try {
                            ServerManager.gI().close();
                        }
                        catch (IOException e) {
                            e.printStackTrace();
                            System.exit(0);
                        }
                        for (int i = SessionManager.CLIENT_ENTRYS.size() - 1; i >= 0; --i) {
                            try {
                                SessionManager.CLIENT_ENTRYS.get((int)i).p = null;
                                SessionManager.CLIENT_ENTRYS.get(i).disconnect();
                                continue;
                            }
                            catch (Exception e) {
                                e.printStackTrace();
                                System.err.println("err 1 menu admin");
                            }
                        }
                        System.out.println("WAIT TO SHUTDOWN SERVICE");
                        try {
                            Thread.sleep(5000L);
                        }
                        catch (InterruptedException e) {
                            e.printStackTrace();
                            System.exit(0);
                        }
                        Manager.gI().close();
                        SQL.gI().close();
                        System.out.println("CLOSE SERVER");
                    }).start();
                    break;
                }
                case 1: {
                    p.update_vang(1000000000L);
                    p.update_ngoc(1000000000L);
                    p.update_money();
                    break;
                }
                case 2: {
                    Service.input_text(p, 32000, "Uplevel", new String[]{"Nh\u1eadp level"});
                    break;
                }
                case 3: {
                    Service.input_text(p, 32001, "SetXP", new String[]{"Nh\u1eadp m\u1ee9c"});
                    break;
                }
                case 4: {
                    Service.input_text(p, 32002, "Get Item", new String[]{"Type item", "Id item", "S\u1ed1 l\u01b0\u1ee3ng"});
                    break;
                }
                case 5: {
                    SaveData.process();
                    Service.send_box_ThongBao_OK(p, "Th\u00e0nh c\u00f4ng");
                }
            }
        }
    }

    private static void Menu_Rebuilt_Item(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                Service.Send_UI_Shop(p, 6);
                break;
            }
            case 1: {
                int[] id = new int[]{1, 3, 9, 8, 11};
                String[] name = new String[id.length];
                byte[] icon = new byte[id.length];
                for (int i = 0; i < id.length; ++i) {
                    ItemTemplate7 temp = ItemTemplate7.get_it_by_id(id[i]);
                    name[i] = temp.name;
                    icon[i] = temp.icon;
                }
                MenuController.send_dynamic_menu(p, 992, "Gh\u00e9p nguy\u00ean li\u1ec7u", name, icon, 7);
                break;
            }
            case 2: {
                Split_Item.show_table(p);
                break;
            }
            case 3: {
                UpgradeItem.show_table_upgrade(p);
                break;
            }
            case 4: {
                UpgradeSuperItem.show_table(p);
            }
        }
    }

    private static void Menu_Johny(Player p, byte index) throws IOException {
        if (p.map.template.id == 25 && index == 5) {
            MenuController.send_dynamic_menu(p, 32002, "C\u01b0\u1eddng h\u00f3a \u00e1c qu\u1ef7", new String[]{"C\u1eeda h\u00e0ng \u0111\u00e1 kh\u1ea3m", "C\u01b0\u1eddng h\u00f3a R\u01b0\u01a1ng \u00e1c qu\u1ef7", "C\u01b0\u1eddng h\u00f3a K\u1ef9 n\u0103ng"}, new short[]{129, 155, 156});
        } else {
            switch (index) {
                case 0: {
                    MenuController.send_dynamic_menu(p, 32000, "C\u01b0\u1eddng H\u00f3a", new String[]{"C\u1eeda h\u00e0ng Nguy\u00ean li\u1ec7u", "Gh\u00e9p nguy\u00ean li\u1ec7u", "T\u00e1ch nguy\u00ean li\u1ec7u", "C\u01b0\u1eddng h\u00f3a \u0111\u1ed3", "C\u01b0\u1eddng h\u00f3a cao c\u1ea5p"}, new short[]{129, 127, 130, 131, 163});
                    break;
                }
                case 1: {
                    MenuController.send_dynamic_menu(p, 32001, "Kh\u1ea3m \u0110\u00e1", new String[]{"C\u1eeda H\u00e0ng \u0110\u00e1 Kh\u1ea3m", "Gh\u00e9p \u0110\u00e1", "\u0110\u1ee5c l\u1ed7 kh\u1ea3m", "Kh\u1ea3m V\u1eadt Ph\u1ea9m", "T\u00e1ch \u0110\u00e1", "\u0110\u00e1 si\u00eau c\u1ea5p", "\u0110\u00e1 th\u1ea7n tho\u1ea1i", "H\u01b0\u1edbng d\u1eabn"}, new short[]{129, 127, 133, 126, 130, 141, 132, 148});
                    break;
                }
                case 2: {
                    ChuyenHoa.show_table(p);
                    break;
                }
                case 3: {
                    Rebuild_Item.show_table(p, 9);
                    break;
                }
                case 4: {
                    int ver_ = Integer.parseInt(p.conn.version.replace(".", ""));
                    if (ver_ >= 115) {
                        Upgrade_Skin.show_table(p);
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "H\u00e3y s\u1eed d\u1ee5ng phi\u00ean b\u1ea3n t\u1eeb 1.1.5 tr\u1edf l\u00ean");
                    break;
                }
            }
        }
    }

    private static void Menu_Machiko(Player p, byte index) throws IOException {
        switch (index) {
            case 0: {
                Service.Send_UI_Shop(p, 20);
                break;
            }
            case 1: {
                Message m = new Message(-20);
                m.writer().writeByte(6);
                m.writer().writeShort(986);
                m.writer().writeByte(0);
                m.writer().writeUTF("V\u1eadn chuy\u1ec3n h\u00e0ng");
                m.writer().writeByte(10);
                String[] name = new String[]{"L\u1ea5y H\u00e0ng", "Tr\u1ea3 h\u00e0ng", "\u0110\u0103ng k\u00fd b\u1ea3o v\u1ec7 h\u00e0ng", "Thu\u00ea b\u1ea3o v\u1ec7 h\u00e0ng", "\u0110\u0103ng k\u00fd ch\u1ee9c n\u0103ng", "H\u1ee7y v\u1eadn bu\u00f4n", "G\u1ecdi L\u1ea1c \u0111\u00e0 tr\u1edf v\u1ec1", "Xem v\u1ecb tr\u00ed l\u1ea1c \u0111\u00e0", "Xem s\u1ed1 l\u1ea7n v\u1eadn bu\u00f4n", "H\u01b0\u1edbng d\u1eabn"};
                short[] icon = new short[]{107, 109, 110, 111, 110, 111, 151, -1, 114, 114};
                byte[] b7 = new byte[]{3, 3, 3, 3, 7, 3, 3, 7, 7, 7};
                for (int i = 0; i < 10; ++i) {
                    m.writer().writeUTF(name[i]);
                    m.writer().writeShort(icon[i]);
                    m.writer().writeByte(b7[i]);
                }
                p.conn.addmsg(m);
                m.cleanup();
                break;
            }
            case 2: {
                ItemFashionP.show_table(p, 103);
                break;
            }
            case 3: {
                ItemFashionP.show_table(p, 102);
                break;
            }
            case 4: {
                ItemFashionP.show_table(p, 105);
                break;
            }
            case 5: {
                ItemFashionP.show_table(p, 108);
            }
        }
    }

    private static void Menu_Guru(Player p, int index) throws IOException {
        switch (index) {
            case 0: {
                Service.Send_UI_Shop(p, p.clazz - 1);
                break;
            }
            case 1: {
                String[] other_clazz_name = new String[4];
                short[] other_clazz_icon = new short[4];
                int pos = 0;
                for (int i = 0; i < 5; ++i) {
                    if (i + 1 == p.clazz) continue;
                    other_clazz_name[pos] = Clazz.NAME[i];
                    other_clazz_icon[pos++] = Clazz.ICON[i];
                }
                MenuController.send_dynamic_menu(p, 32003, "H\u1ec7 kh\u00e1c", other_clazz_name, other_clazz_icon);
                break;
            }
            case 2: {
                p.is_show_hat = !p.is_show_hat;
                Service.charWearing(p, p, false);
                Service.update_PK(p, p, false);
                p.update_info_to_all();
                Service.send_box_ThongBao_OK(p, p.is_show_hat ? "\u0110\u00e3 b\u1eadt hi\u1ec3n th\u1ecb n\u00f3n" : "\u0110\u00e3 t\u1eaft hi\u1ec3n th\u1ecb n\u00f3n");
                break;
            }
            case 3: {
                MenuController.send_dynamic_menu(p, 994, "Kh\u00f3a B\u1ea3o V\u1ec7", new String[]{"\u0110\u0103ng k\u00fd kh\u00f3a b\u1ea3o v\u1ec7", "H\u01b0\u1edbng d\u1eabn", "H\u1ee7y m\u00e3 kh\u00f3a"}, new short[]{118, 148, 118});
                break;
            }
            case 4: {
                Service.Send_UI_Shop(p, 119);
            }
        }
    }

    private static void Menu_Change_Zone(Player p) throws IOException {
        Message m = new Message(23);
        m.writer().writeByte(p.map.template.max_zone);
        Map[] map_ = Map.get_map_by_id(p.map.template.id);
        for (int i = 0; i < map_.length; ++i) {
            int s = map_[i].players.size();
            byte max = map_[i].template.max_player;
            m.writer().writeByte(s >= max ? 2 : (s > max / 2 ? 1 : 0));
        }
        p.conn.addmsg(m);
        m.cleanup();
    }

    private static void Show_List_Map_Tele(Player p, int index, int idNPC) throws IOException {
        if (index == 1) {
            p.map_tele = ID_MAP_LANG;
            MenuController.send_dynamic_menu(p, 995, "D\u1ecbch chuy\u1ec3n", p.map_tele);
        } else if (index == 0) {
            switch (idNPC) {
                case -5: {
                    p.map_tele = new int[]{1, 2, 3, 4, 6};
                    break;
                }
                case -12: {
                    p.map_tele = new int[]{9, 10, 11, 12, 14};
                    break;
                }
                case -144: {
                    p.map_tele = new int[]{191, 192, 193, 194, 195, 196, 197};
                    break;
                }
                case -124: {
                    p.map_tele = new int[]{113, 112, 115, 116, 117, 118, 124, 125, 126};
                    break;
                }
                case -107: {
                    p.map_tele = new int[]{93, 94, 95, 96, 97, 98, 99, 100, 101, 103};
                    break;
                }
                case -85: {
                    p.map_tele = new int[]{83, 84, 85, 86, 88};
                    break;
                }
                case -132: 
                case -97: 
                case -82: {
                    return;
                }
                case 0: {
                    p.map_tele = new int[]{69, 70, 71, 72, 74};
                    break;
                }
                case -60: {
                    p.map_tele = new int[]{49, 50, 51, 52, 54};
                    break;
                }
                case -44: {
                    p.map_tele = new int[]{41, 42, 43, 44, 46};
                    break;
                }
                case -36: {
                    p.map_tele = new int[]{33, 34, 35, 36, 38};
                    break;
                }
                case -28: {
                    p.map_tele = new int[]{25, 26, 27, 28, 30};
                    break;
                }
                case -20: {
                    p.map_tele = new int[]{17, 18, 19, 20, 22};
                }
            }
            MenuController.send_dynamic_menu(p, 996, "D\u1ecbch chuy\u1ec3n", p.map_tele);
        }
    }

    public static void send_dynamic_menu(Player p, int id_npc, String name_npc, String[] list_menu, short[] list_icon) throws IOException {
        if (!p.isdie) {
            Message m = new Message(-20);
            if (list_icon == null) {
                m.writer().writeByte(0);
            } else {
                m.writer().writeByte(5);
            }
            m.writer().writeShort(id_npc);
            m.writer().writeByte(0);
            m.writer().writeUTF(name_npc);
            m.writer().writeByte(list_menu.length);
            for (int i = 0; i < list_menu.length; ++i) {
                m.writer().writeUTF(list_menu[i]);
                if (list_icon == null) continue;
                m.writer().writeShort(list_icon[i]);
            }
            p.conn.addmsg(m);
            m.cleanup();
        }
    }

    private static void send_dynamic_menu(Player p, int id_npc, String name_npc, String[] list_menu, byte[] list_icon, int b) throws IOException {
        if (!p.isdie) {
            Message m = new Message(-20);
            m.writer().writeByte(3);
            m.writer().writeShort(id_npc);
            m.writer().writeByte(1);
            m.writer().writeUTF(name_npc);
            m.writer().writeByte(list_menu.length);
            for (int i = 0; i < list_menu.length; ++i) {
                m.writer().writeUTF(list_menu[i]);
                m.writer().writeShort(list_icon[i]);
                m.writer().writeByte(b);
            }
            p.conn.addmsg(m);
            m.cleanup();
        }
    }

    private static void send_dynamic_menu(Player p, int id_npc, String name_npc, List<String> list_menu, List<Integer> list_icon) throws IOException {
        if (!p.isdie) {
            Message m = new Message(-20);
            m.writer().writeByte(4);
            m.writer().writeShort(id_npc);
            m.writer().writeByte(0);
            m.writer().writeUTF(name_npc);
            m.writer().writeByte(list_menu.size());
            for (int i = 0; i < list_menu.size(); ++i) {
                m.writer().writeUTF(list_menu.get(i));
                m.writer().writeShort(list_icon.get(i));
            }
            p.conn.addmsg(m);
            m.cleanup();
        }
    }

    private static void send_dynamic_menu(Player p, int idNPC, String title, String[] name) throws IOException {
        if (!p.isdie) {
            Message m = new Message(-20);
            m.writer().writeByte(2);
            m.writer().writeShort(idNPC);
            m.writer().writeByte(0);
            m.writer().writeUTF(title);
            m.writer().writeByte(name.length);
            for (int i = 0; i < name.length; ++i) {
                m.writer().writeUTF(name[i]);
            }
            p.conn.addmsg(m);
            m.cleanup();
        }
    }

    private static void send_dynamic_menu(Player p, int idNPC, String title, int[] name) throws IOException {
        if (!p.isdie) {
            int idMap = MapCanGoTo.idMap[MapCanGoTo.idMap.length - 1];
            QuestP quest_select = p.list_quest.get(0);
            if (quest_select != null) {
                for (int i = 0; i < MapCanGoTo.idQuest.length; ++i) {
                    if (MapCanGoTo.idQuest[i] <= quest_select.template.id) continue;
                    idMap = MapCanGoTo.idMap[i - 1];
                    break;
                }
            }
            Message m = new Message(-20);
            m.writer().writeByte(1);
            m.writer().writeShort(idNPC);
            m.writer().writeByte(0);
            m.writer().writeUTF(title);
            m.writer().writeByte(name.length);
            for (int i = 0; i < name.length; ++i) {
                Map map = Map.get_map_by_id(name[i])[0];
                m.writer().writeUTF(map.template.name);
                if (name[i] <= idMap) {
                    m.writer().writeByte(map.template.id == p.map.template.id ? 4 : 2);
                } else {
                    m.writer().writeByte(1);
                }
                m.writer().writeByte(7);
            }
            p.conn.addmsg(m);
            m.cleanup();
        }
    }
}
