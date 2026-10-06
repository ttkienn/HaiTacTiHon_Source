/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import io.Message;
import java.io.IOException;
import java.util.List;
import map.Map;

public class TableTickOption {
    public List<Player> listP;
    public byte[] list_check;
    public boolean is_finish = false;
    public short idDialog;

    public static void show_table(Player p, String title) throws IOException {
        if (p.tableTickOption != null) {
            Player p0;
            int i;
            Message m = new Message(-74);
            m.writer().writeByte(0);
            m.writer().writeShort(p.tableTickOption.idDialog);
            m.writer().writeUTF(title);
            m.writer().writeByte(p.tableTickOption.listP.size());
            for (i = 0; i < p.tableTickOption.listP.size(); ++i) {
                p0 = Map.get_player_by_name_allmap(p.tableTickOption.listP.get((int)i).name);
                if (p0 == null) continue;
                m.writer().writeShort(p0.index_map);
                m.writer().writeUTF(p0.name);
                m.writer().writeShort(p0.map.template.id);
            }
            for (i = 0; i < p.tableTickOption.listP.size(); ++i) {
                p0 = Map.get_player_by_name_allmap(p.tableTickOption.listP.get((int)i).name);
                if (p0 == null) continue;
                p0.tableTickOption = p.tableTickOption;
                p0.conn.addmsg(m);
            }
            m.cleanup();
        }
    }

    public static void process(Player p, Message m2) throws IOException {
        if (p.tableTickOption != null && !p.tableTickOption.is_finish) {
            byte type = m2.reader().readByte();
            short idDialog = m2.reader().readShort();
            if (p.tableTickOption.idDialog == idDialog) {
                switch (idDialog) {
                    case 0: {
                        if (type == 1) {
                            if (p.tableTickOption.listP.get((int)0).name.equals(p.name)) {
                                for (int i = 0; i < p.tableTickOption.list_check.length; ++i) {
                                    if (p.tableTickOption.list_check[i] != 0) continue;
                                    Service.send_box_ThongBao_OK(p, p.tableTickOption.listP.get((int)i).name + " ch\u01b0a tick ch\u1ecdn");
                                    return;
                                }
                                Object name_ok = "";
                                for (int i = 0; i < p.tableTickOption.list_check.length; ++i) {
                                    if (p.tableTickOption.list_check[i] != 1) continue;
                                    name_ok = (String)name_ok + p.tableTickOption.listP.get((int)i).name + ", ";
                                }
                                Service.send_box_yesno(p, 51, "Th\u00f4ng b\u00e1o", "X\u00e1c nh\u1eadn tham gia ph\u00f3 b\u1ea3n kh\u1ed5ng l\u1ed3 v\u1edbi th\u00e0nh vi\u00ean sau:\n" + (String)name_ok, new String[]{"\u0110\u1ed3ng \u00fd", "Hu\u1ef7"}, new byte[]{2, 1});
                                break;
                            }
                            Message m = new Message(-74);
                            m.writer().writeByte(1);
                            m.writer().writeShort(0);
                            m.writer().writeShort(p.index_map);
                            for (int i = 0; i < p.tableTickOption.listP.size(); ++i) {
                                Player p0 = Map.get_player_by_name_allmap(p.tableTickOption.listP.get((int)i).name);
                                if (p0 != null) {
                                    p0.conn.addmsg(m);
                                }
                                if (!p.name.equals(p.tableTickOption.listP.get((int)i).name)) continue;
                                p.tableTickOption.list_check[i] = 1;
                            }
                            m.cleanup();
                            break;
                        }
                        if (type != 2) break;
                        Message m = new Message(-74);
                        m.writer().writeByte(3);
                        m.writer().writeShort(0);
                        m.writer().writeShort(p.index_map);
                        for (int i = 0; i < p.tableTickOption.listP.size(); ++i) {
                            Player p0 = Map.get_player_by_name_allmap(p.tableTickOption.listP.get((int)i).name);
                            if (p0 != null) {
                                p0.conn.addmsg(m);
                            }
                            if (!p.name.equals(p.tableTickOption.listP.get((int)i).name)) continue;
                            p.tableTickOption.list_check[i] = -1;
                        }
                        m.cleanup();
                        p.tableTickOption = null;
                        break;
                    }
                }
            }
        }
    }
}

