/*
 * Decompiled with CFR 0.152.
 */
package template;

import client.Player;
import template.Skill_Template;

public class Skill_info {
    public static long[] EXP = new long[27];
    public static int[] EXP_DEVIL = new int[]{100, 125, 167, 200, 250};
    public long exp;
    public Skill_Template temp;
    public byte lvdevil;
    public byte devilpercent;

    public int get_percent() {
        if (this.exp <= 0L) {
            return 0;
        }
        long exp_total = EXP[this.temp.Lv_RQ - 1];
        if (exp_total == 0L) {
            return 0;
        }
        return (int)(this.exp * 1000L / exp_total);
    }

    public int get_dame(Player p) {
        int result = this.temp.damage;
        if (this.temp.ID >= 2000) {
            result = p.skill_point.get(0).get_dame(p) * this.temp.percentDame / 100;
        }
        if (this.temp.ID == 0 || this.temp.ID == 1 || this.temp.ID == 2) {
            switch (this.lvdevil) {
                case 1: {
                    result = result * 11 / 10;
                    break;
                }
                case 2: {
                    result = result * 125 / 100;
                    break;
                }
                case 3: {
                    result = result * 145 / 100;
                    break;
                }
                case 4: {
                    result = result * 17 / 10;
                    break;
                }
                case 5: {
                    result *= 2;
                }
            }
        } else if (this.temp.ID < 2000 || this.temp.ID < 3000) {
            // empty if block
        }
        return result;
    }

    public void update_exp_devil(int exp_devil) {
        int exp = this.devilpercent * EXP_DEVIL[this.lvdevil] / 100;
        exp += exp_devil;
        while (this.lvdevil < 5 && exp >= EXP_DEVIL[this.lvdevil]) {
            exp -= EXP_DEVIL[this.lvdevil];
            this.lvdevil = (byte)(this.lvdevil + 1);
        }
        this.devilpercent = this.lvdevil == 5 ? (byte)0 : (byte)(exp * 100 / EXP_DEVIL[this.lvdevil]);
    }

    public short get_eff_skill() {
        if (this.temp.ID >= 2000 && this.lvdevil == 5) {
            switch (this.temp.indexSkillInServer) {
                case 658: {
                    return 402;
                }
                case 659: {
                    return 403;
                }
                case 475: {
                    return 228;
                }
                case 476: {
                    return 229;
                }
                case 477: {
                    return 227;
                }
                case 485: {
                    return 232;
                }
                case 486: {
                    return 234;
                }
                case 520: {
                    return 236;
                }
                case 521: {
                    return 235;
                }
                case 522: {
                    return 230;
                }
                case 523: {
                    return 231;
                }
                case 526: {
                    return 237;
                }
                case 527: {
                    return 238;
                }
                case 530: {
                    return 239;
                }
                case 531: {
                    return 240;
                }
                case 535: {
                    return 241;
                }
                case 538: {
                    return 242;
                }
                case 541: {
                    return 244;
                }
                case 542: {
                    return 243;
                }
                case 543: {
                    return 251;
                }
                case 544: {
                    return 252;
                }
                case 546: {
                    return 254;
                }
                case 547: {
                    return 253;
                }
                case 549: {
                    return 255;
                }
            }
        }
        return this.temp.getTypeEffSkill();
    }

    static {
        Skill_info.EXP[0] = 3400L;
        Skill_info.EXP[1] = 10000L;
        Skill_info.EXP[2] = 30000L;
        Skill_info.EXP[3] = 60000L;
        Skill_info.EXP[4] = 120000L;
        for (int i = 5; i < EXP.length; ++i) {
            Skill_info.EXP[i] = EXP[i - 1] * 15L / 10L;
        }
    }
}

