/*
 * Decompiled with CFR 0.152.
 */
package event;

import client.Player;
import core.Service;
import core.Util;
import event.EventSpecial;
import java.io.IOException;
import java.util.HashMap;
import java.util.Map;
import template.TaiXiuInfo;

public class TaiXiu
implements Runnable {
    public static final int TIME_ROUND = 180999;
    private boolean running;
    private Thread myth;
    private long time = 180999L;
    private HashMap<String, TaiXiuInfo> list_player;
    private HashMap<String, TaiXiuInfo> list_result;
    private int XiuTotal = 0;
    private int TaiTotal = 0;
    private byte[] dice = new byte[3];

    public TaiXiu() {
        for (int i = 0; i < 3; ++i) {
            this.dice[i] = (byte)Util.random(1, 7);
        }
        this.list_player = new HashMap();
        this.list_result = new HashMap();
        this.myth = new Thread(this);
        this.myth.start();
    }

    @Override
    public void run() {
        this.running = true;
        while (this.running) {
            try {
                this.update();
                Thread.sleep(1000L);
            }
            catch (InterruptedException interruptedException) {
            }
            catch (Exception e) {
                e.printStackTrace();
                System.err.println("err update taixiu");
            }
        }
    }

    private synchronized void update() {
        if (this.time < 0L) {
            for (int i = 0; i < 3; ++i) {
                this.dice[i] = (byte)Util.random(1, 7);
            }
            int xucxacResult = this.dice[0] + this.dice[1] + this.dice[2];
            while (xucxacResult == 3 || xucxacResult == 18) {
                for (int i = 0; i < 3; ++i) {
                    this.dice[i] = (byte)Util.random(1, 7);
                }
                xucxacResult = this.dice[0] + this.dice[1] + this.dice[2];
            }
            for (Map.Entry<String, TaiXiuInfo> en : this.list_player.entrySet()) {
                TaiXiuInfo infoJoin_old;
                String nameP;
                TaiXiuInfo infoJoin = en.getValue();
                if (xucxacResult >= 11 && xucxacResult <= 17) {
                    if (en.getValue().TaiorXiu != 1) continue;
                    infoJoin.money *= 2;
                    nameP = en.getKey();
                    if (!this.list_result.containsKey(nameP)) {
                        this.list_result.put(nameP, infoJoin);
                        continue;
                    }
                    infoJoin_old = this.list_result.get(nameP);
                    infoJoin_old.money += infoJoin.money;
                    continue;
                }
                if (en.getValue().TaiorXiu != 0) continue;
                infoJoin.money *= 2;
                nameP = en.getKey();
                if (!this.list_result.containsKey(nameP)) {
                    this.list_result.put(nameP, infoJoin);
                    continue;
                }
                infoJoin_old = this.list_result.get(nameP);
                infoJoin_old.money += infoJoin.money;
            }
            this.time = 180999L;
            this.TaiTotal = 0;
            this.XiuTotal = 0;
            this.list_player.clear();
        }
    }

    public void close() {
        this.running = false;
        this.myth.interrupt();
    }

    public long get_time() {
        return this.time;
    }

    public int MoneyTotal(int i) {
        if (i == 0) {
            return this.XiuTotal;
        }
        return this.TaiTotal;
    }

    public synchronized TaiXiuInfo get_my_info(Player p) {
        return this.list_player.get(p.name);
    }

    public synchronized TaiXiuInfo get_my_result(Player p) {
        return this.list_result.get(p.name);
    }

    public byte[] get_dice_now() {
        return this.dice;
    }

    public synchronized void register(Player p, int money, byte taiorXiu) throws IOException {
        if (this.time <= 0L) {
            Service.send_box_ThongBao_OK(p, "Kh\u00f4ng trong th\u1eddi gian \u0111\u1eb7t c\u01b0\u1ee3c!");
            return;
        }
        if (taiorXiu == 0) {
            if ((long)this.XiuTotal + (long)money > 2000000000L) {
                money = 2000000000 - this.XiuTotal;
                this.XiuTotal = 2000000000;
            }
            this.XiuTotal += money;
        } else {
            if ((long)this.TaiTotal + (long)money > 2000000000L) {
                money = 2000000000 - this.TaiTotal;
                this.TaiTotal = 2000000000;
            }
            this.TaiTotal += money;
        }
        p.update_vang(-money);
        p.update_money();
        TaiXiuInfo t = this.list_player.get(p.name);
        if (t != null) {
            if (t.TaiorXiu == taiorXiu) {
                t.money += money;
                EventSpecial.update_info_tx(p);
            }
        } else {
            t = new TaiXiuInfo();
            t.money = money;
            t.TaiorXiu = taiorXiu;
            t.isReceive = 0;
            this.list_player.put(p.name, t);
            EventSpecial.update_info_tx(p);
        }
    }

    public synchronized void remove_result(Player p) {
        this.list_result.remove(p.name);
    }

    public void upTime() {
        this.time -= 1000L;
    }
}

