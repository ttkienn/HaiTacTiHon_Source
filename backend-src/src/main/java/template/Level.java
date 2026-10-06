/*
 * Decompiled with CFR 0.152.
 */
package template;

public class Level {
    public static Level[] ENTRYS;
    public static long[] LEVEL_THONGTHAO;
    public long exp;
    public int tiemnang;

    public Level() {
    }

    public Level(long a, int tn) {
        this.exp = a;
        this.tiemnang = tn;
    }

    public static int get_total_point_by_level(int level) {
        int par = 2;
        for (int i = 0; i < level; ++i) {
            par += 2;
        }
        return par;
    }

    static {
        int i;
        ENTRYS = new Level[250];
        Level.ENTRYS[0] = new Level(10150L, 2);
        Level.ENTRYS[1] = new Level(20860L, 2);
        Level.ENTRYS[2] = new Level(30570L, 2);
        Level.ENTRYS[3] = new Level(40780L, 2);
        Level.ENTRYS[4] = new Level(60760L, 2);
        Level.ENTRYS[5] = new Level(100130L, 2);
        Level.ENTRYS[6] = new Level(106040L, 2);
        Level.ENTRYS[7] = new Level(208000L, 2);
        Level.ENTRYS[8] = new Level(409000L, 2);
        Level.ENTRYS[9] = new Level(606400L, 2);
        Level.ENTRYS[10] = new Level(709450L, 2);
        Level.ENTRYS[11] = new Level(1002170L, 2);
        Level.ENTRYS[12] = new Level(1025400L, 2);
        Level.ENTRYS[13] = new Level(1038000L, 2);
        Level.ENTRYS[14] = new Level(1050220L, 2);
        for (i = 15; i < 250; ++i) {
            Level temp = ENTRYS[i - 1];
            long value = temp.exp;
            if (i < 200) {
                value += value * (long)(i - 1 + 2) / 712L;
            }
            Level.ENTRYS[i] = new Level(value, 2);
        }
        LEVEL_THONGTHAO = new long[150];
        Level.LEVEL_THONGTHAO[0] = Level.ENTRYS[98].exp;
        for (i = 1; i < LEVEL_THONGTHAO.length; ++i) {
            Level.LEVEL_THONGTHAO[i] = LEVEL_THONGTHAO[i - 1] * 11L / 10L;
        }
    }
}

