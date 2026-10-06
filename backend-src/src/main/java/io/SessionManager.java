/*
 * Decompiled with CFR 0.152.
 */
package io;

import client.Player;
import core.Manager;
import io.Session;
import java.util.List;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.CopyOnWriteArrayList;

public class SessionManager {
    public static final List<Session> CLIENT_ENTRYS = new CopyOnWriteArrayList<Session>();
    public static ConcurrentHashMap<String, Long> time_login = new ConcurrentHashMap();
    public static ConcurrentHashMap<String, Long> CLIENT_LOGIN_TIME = new ConcurrentHashMap();
    public static final long TIME_LOGIN_AGAIN = Manager.gI().server_admin ? 0L : 5000L;

    public static synchronized void client_connect(Session ss) {
        ss.init();
        CLIENT_ENTRYS.add(ss);
        System.out.println("accecpt online: " + CLIENT_ENTRYS.size());
    }

    public static synchronized void client_disconnect(Session ss) {
        if (CLIENT_ENTRYS.contains(ss)) {
            if (ss.user != null) {
                time_login.put(ss.user, System.currentTimeMillis() + 1800000L);
            }
            ss.connected = false;
            try {
                if (ss.p != null && ss.p.map != null) {
                    ss.p.map.leave_map(ss.p, 0);
                    if (ss.p.ship_pet != null && ss.p.ship_pet.map == null) {
                        ss.p.ship_pet.map = ss.p.map;
                    }
                    Player.flush(ss.p, true);
                }
                ss.clear_network(ss);
                ss.update_onl(0);
            }
            catch (Exception exception) {
                // empty catch block
            }
            CLIENT_ENTRYS.remove(ss);
            System.out.println("disconnect session " + (ss.user != null ? ss.user : "unknown") + ": online : " + CLIENT_ENTRYS.size());
            if (ss.user != null) {
                time_login.put(ss.user, System.currentTimeMillis() + TIME_LOGIN_AGAIN);
            }
        }
    }
}

