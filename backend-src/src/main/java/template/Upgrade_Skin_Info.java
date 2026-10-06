/*
 * Decompiled with CFR 0.152.
 */
package template;

import template.ItemFashionP2;

public class Upgrade_Skin_Info {
    public ItemFashionP2 skin;
    public short[] upgrade_skin_data;

    public static String get_op_level(byte level) {
        int percent = 0;
        for (int k = 1; k <= level; ++k) {
            if (k % 3 == 0) {
                percent += 10;
                continue;
            }
            percent += 3;
        }
        return String.format("%.1f", Float.valueOf((float)percent / 10.0f));
    }
}

