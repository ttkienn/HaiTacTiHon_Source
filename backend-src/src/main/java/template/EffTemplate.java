/*
 * Decompiled with CFR 0.152.
 */
package template;

public class EffTemplate {
    public int id;
    public int param;
    public long time;

    public EffTemplate(int id, int param, long time) {
        this.id = id;
        this.param = param;
        this.time = time;
    }

    public static boolean check_eff_can_save(int id) {
        return id == 2 || id == 3 || id == 8 || id == 17 || id == 22;
    }

    public static boolean check_eff_remove_when_die(int id) {
        return id == 0 || id == 1 || id >= 201 && id <= 216;
    }
}

