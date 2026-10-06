/*
 * Decompiled with CFR 0.152.
 */
package core;

import core.AdminCommandPoller;
import core.BotManager;
import core.Manager;
import core.SaveData;
import core.ServerEventManager;
import io.Session;
import io.SessionManager;
import java.io.IOException;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.Socket;

public class ServerManager
implements Runnable {
    private static ServerManager instance;
    private final Thread mythread;
    private ServerEventManager serverEventManager;
    private AdminCommandPoller adminCommandPoller;
    private boolean running;
    private ServerSocket server;
    private final long time = System.currentTimeMillis();

    public ServerManager() {
        this.mythread = new Thread(this);
    }

    public static ServerManager gI() {
        if (instance == null) {
            instance = new ServerManager();
        }
        return instance;
    }

    public void init() {
        Manager.gI().init();
        this.running = true;
        this.mythread.start();
        SaveData.process();
        this.serverEventManager = new ServerEventManager();
        this.serverEventManager.init();
        this.adminCommandPoller = new AdminCommandPoller();
        this.adminCommandPoller.start();
        BotManager.gI().start();
    }

    @Override
    public void run() {
        try {
            this.server = new ServerSocket(Manager.gI().server_port, 50, InetAddress.getByName(Manager.gI().server_host));
        }
        catch (IOException e) {
            System.out.println(e);
            System.exit(0);
        }
        System.out.println("Started in " + (System.currentTimeMillis() - this.time) + "ms");
        System.out.println();
        System.out.println("LISTEN " + Manager.gI().server_host + ":" + Manager.gI().server_port + "...");
        while (this.running) {
            try {
                Socket client = this.server.accept();
                Session ss = new Session(client);
                SessionManager.client_connect(ss);
            }
            catch (Exception e) {
                e.printStackTrace();
                System.err.println("err accept socket");
            }
        }
    }

    public void close() throws IOException {
        this.serverEventManager.close();
        if (this.adminCommandPoller != null) {
            this.adminCommandPoller.stopPoller();
        }
        this.running = false;
        this.server.close();
        instance = null;
    }

    public ServerSocket get_server() {
        return this.server;
    }
}

