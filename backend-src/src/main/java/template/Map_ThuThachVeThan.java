/*
 * Decompiled with CFR 0.152.
 */
package template;

import client.Player;

public class Map_ThuThachVeThan {
    public long time_state;
    public boolean isFinish = false;
    public boolean isReceiv = false;
    private byte[] listcheck = new byte[]{0, 0};

    public boolean okP(Player p) {
        if (this.listcheck[0] == 0) {
            this.listcheck[0] = 1;
        } else {
            this.listcheck[1] = 1;
        }
        return this.listcheck[0] == 1 && this.listcheck[1] == 1;
    }

    public void update_okP() {
        this.listcheck = new byte[]{0, 0};
    }
}

