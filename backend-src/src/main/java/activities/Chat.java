/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import io.Message;
import java.io.IOException;

public class Chat {
    public static void process(Player p, Message m2, int type) throws IOException {
        if (type == 0) {
            String tab_name = m2.reader().readUTF();
            String text = m2.reader().readUTF();
            switch (tab_name) {
                case "Nh\u00f3m": {
                    if (p.party != null) {
                        for (int i = 0; i < p.party.list.size(); ++i) {
                            Player p0 = p.party.list.get(i);
                            if (p0.index_map == p.index_map) continue;
                            Chat.send_chat(p0, tab_name, "@" + p.name + " : " + text, false);
                        }
                        break;
                    }
                    Service.send_box_ThongBao_OK(p, "Nh\u00f3m kh\u00f4ng t\u1ed3n t\u1ea1i");
                }
            }
        }
    }

    public static void send_chat(Player p, String tab_name, String text, boolean cache) throws IOException {
        if (p.conn != null) {
            Message m = new Message(18);
            m.writer().writeUTF(tab_name);
            m.writer().writeUTF(text);
            if (cache) {
                p.list_msg_cache.add(m);
            } else {
                p.conn.addmsg(m);
            }
            m.cleanup();
        }
    }
}

