/*
 * Decompiled with CFR 0.152.
 */
package client;

import client.Clan;
import client.Player;
import event.LucThuc;
import java.util.List;
import template.EffTemplate;
import template.ItemFashion;
import template.ItemFashionP2;
import template.ItemOptionTemplate;
import template.Option;
import template.Skill_info;

public class Body {
    public static String[] NameAttribute = new String[]{"S\u1ee9c m\u1ea1nh", "Ph\u00f2ng th\u1ee7", "Th\u1ec3 l\u1ef1c", "Tinh th\u1ea7n", "Nhanh nh\u1eb9n"};
    public static byte[][] Id = new byte[][]{{1, 13, 10}, {4, 26, 27}, {15, 23}, {16, 11, 14}, {25, 12}};
    public static int[] Point1_Template_atk;
    public static int[] Point1_Template_crit;
    public static int[] Point1_Template_pierce;
    public static int[] Point2_Template_def;
    public static int[] Point2_Template_resist_physical;
    public static int[] Point2_Template_resist_magic;
    public static int[] Point3_Template_hp;
    public static int[] Point3_Template_hp_potion;
    public static int[] Point4_Template_mp;
    public static int[] Point4_Template_dame_crit;
    public static int[] Point5_Template_cooldown;
    public static int[] Point5_Template_miss;
    private final Player p;

    public Body(Player p) {
        this.p = p;
    }

    private int total_param_item(int id, boolean have_eff) {
        int hair;
        int j;
        int i;
        int par = 0;
        if (id == 46 && this.p.item.it_body[0] != null && this.p.item.it_body[0].levelup > 10) {
            par += 50 * (this.p.item.it_body[0].levelup - 10);
        } else if (id == 53 && this.p.item.it_body[2] != null && this.p.item.it_body[2].levelup > 10) {
            par += 30 * (this.p.item.it_body[2].levelup - 10);
        } else if (id == 56) {
            if (this.p.item.it_body[1] != null && this.p.item.it_body[1].levelup > 10) {
                par += 100 * (this.p.item.it_body[1].levelup - 10);
            }
            if (this.p.item.it_body[3] != null && this.p.item.it_body[3].levelup > 10) {
                par += 100 * (this.p.item.it_body[3].levelup - 10);
            }
            if (this.p.item.it_body[5] != null && this.p.item.it_body[5].levelup > 10) {
                par += 100 * (this.p.item.it_body[5].levelup - 10);
            }
        } else if (id == 47 && this.p.item.it_body[4] != null && this.p.item.it_body[4].levelup > 10) {
            par += 20 * (this.p.item.it_body[4].levelup - 10);
        }
        for (int j2 = 0; j2 < this.p.item.it_body.length; ++j2) {
            int i2;
            if (this.p.item.it_body[j2] == null) continue;
            for (i2 = 0; i2 < this.p.item.it_body[j2].option_item.size(); ++i2) {
                if (this.p.item.it_body[j2].option_item.get((int)i2).id != id) continue;
                par += this.p.item.it_body[j2].option_item.get(i2).getParam(this.p.item.it_body[j2].template.typeEquip, this.p.item.it_body[j2].levelup, this.p.item.it_body[j2].isHoanMy);
            }
            for (i2 = 0; i2 < this.p.item.it_body[j2].option_item_2.size(); ++i2) {
                if (this.p.item.it_body[j2].option_item_2.get((int)i2).id != id) continue;
                par += this.p.item.it_body[j2].option_item_2.get(i2).getParam();
            }
        }
        for (i = 0; i < this.p.fashion.size(); ++i) {
            ItemFashion tempF;
            ItemFashionP2 temp = this.p.fashion.get(i);
            if (!temp.is_use || (tempF = ItemFashion.get_item(temp.id)) == null) continue;
            for (j = 0; j < tempF.op.size(); ++j) {
                if (tempF.op.get((int)j).id != id) continue;
                int op_value = tempF.op.get(j).getParam();
                int percent = 0;
                for (int k = 1; k <= temp.level; ++k) {
                    if (k % 3 == 0) {
                        percent += 10;
                        continue;
                    }
                    percent += 3;
                }
                if (ItemOptionTemplate.ENTRYS.get((int)id).percent == 1) {
                    op_value += percent;
                }
                par += op_value;
            }
            break;
        }
        for (i = 0; i < this.p.skill_point.size(); ++i) {
            Skill_info temp = this.p.skill_point.get(i);
            if (temp.temp.Lv_RQ <= 0 || temp.temp.typeSkill != 3) continue;
            for (int j3 = 0; j3 < temp.temp.op.size(); ++j3) {
                if (id == 25 || temp.temp.op.get((int)j3).id != id) continue;
                par += temp.temp.op.get(j3).getParam();
            }
        }
        if (have_eff) {
            EffTemplate temp = this.p.get_eff(id + 100);
            if (temp != null) {
                par += temp.param;
            }
            if (this.p.party != null) {
                List<Option> op_select = this.p.party.get_list_buff_now(this.p);
                for (int i3 = 0; i3 < op_select.size(); ++i3) {
                    if (op_select.get((int)i3).id != id) continue;
                    par += op_select.get(i3).getParam();
                    break;
                }
            }
        }
        if (id == 56 && this.p.item.it_heart != null) {
            for (int i4 = 0; i4 < this.p.item.it_heart.option_item.size(); ++i4) {
                if (this.p.item.it_heart.option_item.get((int)i4).id != id) continue;
                par += this.p.item.it_heart.option_item.get(i4).getParam(this.p.item.it_heart.template.typeEquip, this.p.item.it_heart.levelup, 0);
            }
        }
        if ((hair = this.p.get_hair()) == 772) {
            switch (id) {
                case 17: {
                    par += 50;
                    break;
                }
                case 12: {
                    par += 30;
                    break;
                }
                case 19: {
                    par += 20;
                }
            }
        }
        switch (id) {
            case 67: {
                for (int i5 = 0; i5 < this.p.daHanhTrinh.size(); ++i5) {
                    if (this.p.daHanhTrinh.get((int)i5).quant != 1 || this.p.daHanhTrinh.get((int)i5).id != 493) continue;
                    par += 20;
                }
                break;
            }
            case 68: {
                for (int i6 = 0; i6 < this.p.daHanhTrinh.size(); ++i6) {
                    if (this.p.daHanhTrinh.get((int)i6).quant != 1 || this.p.daHanhTrinh.get((int)i6).id != 494) continue;
                    par += 20;
                }
                break;
            }
            case 56: {
                for (int i7 = 0; i7 < this.p.daHanhTrinh.size(); ++i7) {
                    if (this.p.daHanhTrinh.get((int)i7).quant != 1 || this.p.daHanhTrinh.get((int)i7).id != 495) continue;
                    par += 20;
                }
                break;
            }
            case 18: {
                for (int i8 = 0; i8 < this.p.daHanhTrinh.size(); ++i8) {
                    if (this.p.daHanhTrinh.get((int)i8).quant != 1 || this.p.daHanhTrinh.get((int)i8).id != 496) continue;
                    par += 20;
                }
                break;
            }
            case 23: {
                for (int i9 = 0; i9 < this.p.daHanhTrinh.size(); ++i9) {
                    if (this.p.daHanhTrinh.get((int)i9).quant != 1 || this.p.daHanhTrinh.get((int)i9).id != 497) continue;
                    par += 300;
                }
                break;
            }
            case 24: {
                for (int i10 = 0; i10 < this.p.daHanhTrinh.size(); ++i10) {
                    if (this.p.daHanhTrinh.get((int)i10).quant != 1 || this.p.daHanhTrinh.get((int)i10).id != 498) continue;
                    par += 100;
                }
                break;
            }
            case 69: {
                for (int i11 = 0; i11 < this.p.daHanhTrinh.size(); ++i11) {
                    if (this.p.daHanhTrinh.get((int)i11).quant != 1 || this.p.daHanhTrinh.get((int)i11).id != 499) continue;
                    par += 20;
                }
                break;
            }
            case 49: {
                for (int i12 = 0; i12 < this.p.daHanhTrinh.size(); ++i12) {
                    if (this.p.daHanhTrinh.get((int)i12).quant != 1 || this.p.daHanhTrinh.get((int)i12).id != 500) continue;
                    par += 20;
                }
                break;
            }
            case 51: {
                for (int i13 = 0; i13 < this.p.daHanhTrinh.size(); ++i13) {
                    if (this.p.daHanhTrinh.get((int)i13).quant != 1 || this.p.daHanhTrinh.get((int)i13).id != 501) continue;
                    par += 20;
                }
                break;
            }
            case 50: {
                for (int i14 = 0; i14 < this.p.daHanhTrinh.size(); ++i14) {
                    if (this.p.daHanhTrinh.get((int)i14).quant != 1 || this.p.daHanhTrinh.get((int)i14).id != 502) continue;
                    par += 20;
                }
                break;
            }
            case 52: {
                for (int i15 = 0; i15 < this.p.daHanhTrinh.size(); ++i15) {
                    if (this.p.daHanhTrinh.get((int)i15).quant != 1 || this.p.daHanhTrinh.get((int)i15).id != 503) continue;
                    par += 20;
                }
                break;
            }
            case 63: {
                for (int i16 = 0; i16 < this.p.daHanhTrinh.size(); ++i16) {
                    if (this.p.daHanhTrinh.get((int)i16).quant != 1 || this.p.daHanhTrinh.get((int)i16).id != 504) continue;
                    par += 20;
                }
                break;
            }
            case 80: {
                for (int i17 = 0; i17 < this.p.daHanhTrinh.size(); ++i17) {
                    if (this.p.daHanhTrinh.get((int)i17).quant != 1 || this.p.daHanhTrinh.get((int)i17).id != 505) continue;
                    par += 50;
                }
                break;
            }
            case 71: {
                for (int i18 = 0; i18 < this.p.daHanhTrinh.size(); ++i18) {
                    if (this.p.daHanhTrinh.get((int)i18).quant != 1 || this.p.daHanhTrinh.get((int)i18).id != 506) continue;
                    par += 50;
                }
                break;
            }
            case 70: {
                for (int i19 = 0; i19 < this.p.daHanhTrinh.size(); ++i19) {
                    if (this.p.daHanhTrinh.get((int)i19).quant != 1 || this.p.daHanhTrinh.get((int)i19).id != 507) continue;
                    par += 50;
                }
                break;
            }
            case 5: {
                for (int i20 = 0; i20 < this.p.daHanhTrinh.size(); ++i20) {
                    if (this.p.daHanhTrinh.get((int)i20).quant != 1 || this.p.daHanhTrinh.get((int)i20).id != 508) continue;
                    par += 2;
                }
                break;
            }
            case 6: {
                for (int i21 = 0; i21 < this.p.daHanhTrinh.size(); ++i21) {
                    if (this.p.daHanhTrinh.get((int)i21).quant != 1 || this.p.daHanhTrinh.get((int)i21).id != 509) continue;
                    par += 2;
                }
                break;
            }
            case 7: {
                for (int i22 = 0; i22 < this.p.daHanhTrinh.size(); ++i22) {
                    if (this.p.daHanhTrinh.get((int)i22).quant != 1 || this.p.daHanhTrinh.get((int)i22).id != 510) continue;
                    par += 2;
                }
                break;
            }
            case 8: {
                for (int i23 = 0; i23 < this.p.daHanhTrinh.size(); ++i23) {
                    if (this.p.daHanhTrinh.get((int)i23).quant != 1 || this.p.daHanhTrinh.get((int)i23).id != 511) continue;
                    par += 2;
                }
                break;
            }
            case 9: {
                for (int i24 = 0; i24 < this.p.daHanhTrinh.size(); ++i24) {
                    if (this.p.daHanhTrinh.get((int)i24).quant != 1 || this.p.daHanhTrinh.get((int)i24).id != 512) continue;
                    par += 2;
                }
                break;
            }
            case 72: {
                for (int i25 = 0; i25 < this.p.daHanhTrinh.size(); ++i25) {
                    if (this.p.daHanhTrinh.get((int)i25).quant != 1 || this.p.daHanhTrinh.get((int)i25).id != 513) continue;
                    par += 50;
                }
                break;
            }
            case 48: {
                for (int i26 = 0; i26 < this.p.daHanhTrinh.size(); ++i26) {
                    if (this.p.daHanhTrinh.get((int)i26).quant != 1 || this.p.daHanhTrinh.get((int)i26).id != 514) continue;
                    par += 10;
                }
                break;
            }
            case 40: {
                for (int i27 = 0; i27 < this.p.daHanhTrinh.size(); ++i27) {
                    if (this.p.daHanhTrinh.get((int)i27).quant != 1 || this.p.daHanhTrinh.get((int)i27).id != 515) continue;
                    ++par;
                }
                break;
            }
            case 75: {
                for (int i28 = 0; i28 < this.p.daHanhTrinh.size(); ++i28) {
                    if (this.p.daHanhTrinh.get((int)i28).quant != 1 || this.p.daHanhTrinh.get((int)i28).id != 516) continue;
                    par += 10;
                }
                break;
            }
            case 76: {
                for (int i29 = 0; i29 < this.p.daHanhTrinh.size(); ++i29) {
                    if (this.p.daHanhTrinh.get((int)i29).quant != 1 || this.p.daHanhTrinh.get((int)i29).id != 517) continue;
                    par += 10;
                }
                break;
            }
        }
        EffTemplate effZombie = this.p.get_eff(21);
        if (par > 1 && effZombie != null && effZombie.param == id) {
            par /= 2;
        }
        for (int i30 = 0; i30 < this.p.lucthuc[0]; ++i30) {
            for (j = 0; j < LucThuc.op[i30].length; ++j) {
                if (LucThuc.op[i30][j] != id) continue;
                par += LucThuc.par[i30][j];
            }
        }
        return par;
    }

    public int get_total_point(int type) {
        int param = 0;
        switch (type) {
            case 1: {
                param += this.p.point1 + this.get_point_plus(1);
                break;
            }
            case 2: {
                param += this.p.point2 + this.get_point_plus(2);
                break;
            }
            case 3: {
                param += this.p.point3 + this.get_point_plus(3);
                break;
            }
            case 4: {
                param += this.p.point4 + this.get_point_plus(4);
                break;
            }
            case 5: {
                param += this.p.point5 + this.get_point_plus(5);
            }
        }
        if (type != 3 && param > 10 && this.p.get_eff(21) != null) {
            param = param * 8 / 10;
        }
        return param;
    }

    public int get_dame(boolean have_eff) {
        Skill_info sk_temp = this.p.get_skill_temp(0);
        if (sk_temp == null) {
            return 0;
        }
        int dame = sk_temp.temp.damage;
        int percent = this.get_dame_percent(have_eff);
        dame = dame * percent / 1000;
        return dame += sk_temp.get_dame(this.p);
    }

    public int get_dame_percent(boolean have_eff) {
        int par = this.total_param_item(1, have_eff);
        par += Point1_Template_atk[this.get_total_point(1) - 1];
        par += ((this.p.doriki[0] - 1) * 5 + this.p.doriki[1]) * 100;
        return par += this.p.sucmanhvatly * 20;
    }

    public int get_def(boolean have_eff) {
        int def = this.get_total_point(2);
        def += this.total_param_item(3, have_eff);
        return def += this.p.sucmanhvatly * 20;
    }

    public int get_def_percent(boolean have_eff) {
        int par = this.total_param_item(4, have_eff);
        par += Point2_Template_def[this.get_total_point(2) - 1];
        int percent = this.total_param_item(80, have_eff);
        par += ((this.p.doriki[0] - 1) * 5 + this.p.doriki[1]) * 100;
        par = par * (1000 + percent) / 1000;
        return par;
    }

    public int get_hp_max(boolean have_eff) {
        long hp = Point3_Template_hp[this.get_total_point(3) - 1];
        hp += (long)this.total_param_item(15, have_eff);
        int percent = this.total_param_item(17, have_eff);
        EffTemplate eff = this.p.get_eff(4);
        if (eff != null) {
            percent += eff.param;
        }
        hp = hp * (1000L + (long)(percent += ((this.p.doriki[0] - 1) * 50 + this.p.doriki[1]) * 100)) / 1000L;
        hp = hp * (1000L + (long)this.total_param_item(56, true)) / 1000L;
        if ((hp += (long)(this.p.sucmanhvatly * 2000)) > 2000000000L) {
            hp = 2000000000L;
        }
        return (int)hp;
    }

    public int get_mp_max(boolean have_eff) {
        int mp = Point4_Template_mp[this.get_total_point(4) - 1];
        mp += this.total_param_item(16, have_eff);
        mp += ((this.p.doriki[0] - 1) * 50 + this.p.doriki[1]) * 100;
        mp = mp * (1000 + this.total_param_item(18, have_eff)) / 1000;
        return mp += this.p.sucmanhvatly * 2000;
    }

    public int get_agility(boolean have_eff) {
        int agi = this.total_param_item(25, have_eff);
        if (this.get_total_point(5) > 0) {
            agi += Point5_Template_cooldown[this.get_total_point(5) - 1];
        }
        if (agi > 450) {
            agi = 450;
        }
        if (this.p.get_eff(13) != null) {
            agi = agi * 15 / 10;
        }
        if (have_eff && this.p.party != null) {
            List<Option> op_select = this.p.party.get_list_buff_now(this.p);
            for (int i = 0; i < op_select.size(); ++i) {
                if (op_select.get((int)i).id != 25) continue;
                agi += op_select.get(i).getParam();
                break;
            }
        }
        return agi;
    }

    public int view_in4(int b) {
        switch (b) {
            case 0: {
                return this.get_dame(true);
            }
            case 1: {
                return this.get_dame_percent(false);
            }
            case 2: {
                return this.get_dame_ap();
            }
            case 3: {
                return this.get_def(true);
            }
            case 4: {
                return this.get_def_percent(false);
            }
            case 15: {
                return this.total_param_item(15, false) + Point3_Template_hp[this.get_total_point(3) - 1];
            }
            case 16: {
                return this.total_param_item(16, false) + Point4_Template_mp[this.get_total_point(4) - 1];
            }
            case 25: {
                return this.get_agility(false);
            }
            case 26: {
                return this.get_dame_resist(false);
            }
            case 27: {
                return this.get_dame_resist_ap(false);
            }
            case 17: {
                return this.total_param_item(17, false);
            }
            case 18: {
                return this.total_param_item(18, false);
            }
            case 13: {
                return this.get_pierce(false);
            }
            case 10: {
                return this.get_crit(false);
            }
            case 12: {
                return this.get_miss(false);
            }
            case 14: {
                return this.get_dame_react(false);
            }
            case 23: {
                return this.get_hp_potion_use_percent(false);
            }
            case 24: {
                return this.get_mp_potion_use_percent(false);
            }
            case 19: {
                return this.get_hp_auto_buff(false);
            }
            case 20: {
                return this.get_mp_auto_buff(false);
            }
            case 21: {
                return this.get_hp_atk_absorb(false);
            }
            case 22: {
                return this.get_mp_atk_absorb(false);
            }
            case 11: {
                return this.get_multi_dame_when_crit(false);
            }
            case 53: {
                return this.get_dame_skip(false);
            }
            case 63: {
                return this.get_dame_skip_reduce();
            }
            case 49: {
                return this.get_crit_reduce();
            }
            case 50: {
                return this.get_pierce_reduce();
            }
            case 51: {
                return this.get_miss_reduce();
            }
            case 52: {
                return this.get_dame_react_reduce();
            }
            case 55: {
                return this.get_TuChoiTuThan();
            }
            case 57: {
                return this.get_true_dame();
            }
            case 58: 
            case 59: {
                return this.get_HapThu_Hp();
            }
            case 46: {
                return this.get_percent_final_dame();
            }
            case 67: {
                return this.get_xp_more();
            }
            case 68: {
                return this.get_xp_skill_more();
            }
            case 69: {
                return this.get_multi_dame_decrease();
            }
            case 72: {
                return this.get_percent_beri_train();
            }
        }
        return this.total_param_item(b, false);
    }

    public int get_param_by_id(int id) {
        return this.total_param_item(id, true);
    }

    public int get_multi_dame_decrease() {
        return this.total_param_item(69, false);
    }

    public int get_dame_skip_reduce() {
        return this.total_param_item(63, true);
    }

    public int get_TuChoiTuThan() {
        int result = this.total_param_item(55, true);
        byte index_full_set = this.p.get_index_full_set();
        if (index_full_set > 3) {
            result += 100;
        }
        return result;
    }

    public int get_mp_atk_absorb(boolean have_eff) {
        return this.total_param_item(22, have_eff);
    }

    public int get_hp_atk_absorb(boolean have_eff) {
        return this.total_param_item(21, have_eff);
    }

    public int get_dame_react(boolean have_eff) {
        int par = this.total_param_item(14, have_eff);
        if ((par += Point2_Template_resist_magic[this.get_total_point(4) - 1]) > 750) {
            int save = par - 750;
            par = 750 + save * 2 / 10;
        }
        return par;
    }

    public int get_pierce(boolean have_eff) {
        int par = this.total_param_item(13, have_eff);
        par += Point1_Template_pierce[this.get_total_point(1) - 1];
        if ((par += this.p.sucmanhvatly * 20) > 750) {
            int save = par - 750;
            par = 750 + save * 2 / 10;
        }
        return par;
    }

    public int get_miss(boolean have_eff) {
        int par = this.total_param_item(12, have_eff);
        if (this.get_total_point(5) > 0) {
            par += Point5_Template_miss[this.get_total_point(5) - 1];
        }
        if (par > 750) {
            int save = par - 750;
            par = 750 + save * 2 / 10;
        }
        return par;
    }

    public int get_crit(boolean have_eff) {
        int par = this.total_param_item(10, have_eff);
        par += Point1_Template_crit[this.get_total_point(1) - 1];
        if ((par += this.p.sucmanhvatly * 20) > 750) {
            int save = par - 750;
            par = 750 + save * 2 / 10;
        }
        return par;
    }

    public int get_multi_dame_when_crit(boolean have_eff) {
        int par = this.total_param_item(11, have_eff);
        return par += Point4_Template_dame_crit[this.get_total_point(4) - 1];
    }

    public int get_point_plus(int type) {
        int par = 0;
        switch (type) {
            case 1: {
                par += this.total_param_item(5, true);
                for (int i = 0; i < this.p.list_op_thongthao.size(); ++i) {
                    if (this.p.list_op_thongthao.get((int)i).id != 1) continue;
                    par += this.p.list_op_thongthao.get(i).getParam();
                }
                break;
            }
            case 2: {
                par += this.total_param_item(6, true);
                for (int i = 0; i < this.p.list_op_thongthao.size(); ++i) {
                    if (this.p.list_op_thongthao.get((int)i).id != 4 && this.p.list_op_thongthao.get((int)i).id != 26 && this.p.list_op_thongthao.get((int)i).id != 27) continue;
                    par += this.p.list_op_thongthao.get(i).getParam();
                }
                break;
            }
            case 3: {
                par += this.total_param_item(7, true);
                for (int i = 0; i < this.p.list_op_thongthao.size(); ++i) {
                    if (this.p.list_op_thongthao.get((int)i).id != 15) continue;
                    par += this.p.list_op_thongthao.get(i).getParam();
                }
                break;
            }
            case 4: {
                par += this.total_param_item(8, true);
                for (int i = 0; i < this.p.list_op_thongthao.size(); ++i) {
                    if (this.p.list_op_thongthao.get((int)i).id != 16) continue;
                    par += this.p.list_op_thongthao.get(i).getParam();
                }
                break;
            }
            case 5: {
                par += this.total_param_item(9, true);
            }
        }
        if (this.p.clan != null) {
            par += this.p.clan.opAttri[type - 1] + Clan.get_point_trungsinh_plus(this.p.clan);
        }
        if (par > 60) {
            par = 60;
        }
        return par;
    }

    public int get_dame_skip(boolean have_eff) {
        int par = this.total_param_item(53, have_eff);
        return par;
    }

    public int get_dame_resist(boolean have_eff) {
        int par = this.total_param_item(26, have_eff);
        par += Point2_Template_resist_physical[this.get_total_point(2) - 1];
        if (this.p.get_eff(11) != null) {
            par *= 2;
        }
        return par;
    }

    public int get_dame_resist_ap(boolean have_eff) {
        int par = this.total_param_item(27, have_eff);
        par += Point2_Template_resist_magic[this.get_total_point(2) - 1];
        if (this.p.get_eff(11) != null) {
            par *= 2;
        }
        return par;
    }

    public int get_hp_potion_use_percent(boolean have_eff) {
        int par = this.total_param_item(23, have_eff);
        return par += Point3_Template_hp_potion[this.get_total_point(3) - 1];
    }

    public int get_mp_potion_use_percent(boolean have_eff) {
        int par = this.total_param_item(24, have_eff);
        return par;
    }

    public int get_hp_auto_buff(boolean have_eff) {
        return this.total_param_item(19, have_eff);
    }

    public int get_mp_auto_buff(boolean have_eff) {
        return this.total_param_item(20, have_eff);
    }

    public int get_dame_ap() {
        return this.total_param_item(2, true);
    }

    public int get_dame_percent_hp_target() {
        int result = this.total_param_item(48, true);
        if (result >= 350) {
            result = 350;
        }
        return result;
    }

    public int get_kich_an(int id) {
        int result = 0;
        for (int i = 0; i < this.p.item.it_body.length; ++i) {
            if (this.p.item.it_body[i] == null || this.p.item.it_body[i].valueKichAn != id) continue;
            ++result;
        }
        return result;
    }

    public int get_percent_beri_train() {
        int par = this.total_param_item(72, true);
        for (int i = 0; i < this.p.fashion.size(); ++i) {
            if (this.p.fashion.get((int)i).id != 77 || !this.p.fashion.get((int)i).is_use) continue;
            par += 300;
            break;
        }
        return par;
    }

    public int get_crit_reduce() {
        int par = this.total_param_item(49, true);
        byte index_full_set = this.p.get_index_full_set();
        if (index_full_set == 5) {
            par += 80;
        } else if (index_full_set > 2) {
            par += 50;
        }
        return par;
    }

    public int get_dame_react_reduce() {
        int par = this.total_param_item(52, true);
        byte index_full_set = this.p.get_index_full_set();
        if (index_full_set == 5) {
            par += 80;
        } else if (index_full_set > 1) {
            par += 50;
        }
        return par;
    }

    public int get_pierce_reduce() {
        int par = this.total_param_item(50, true);
        byte index_full_set = this.p.get_index_full_set();
        if (index_full_set == 5) {
            par += 80;
        } else if (index_full_set > 2) {
            par += 50;
        }
        return par;
    }

    public int get_miss_reduce() {
        int par = this.total_param_item(51, true);
        byte index_full_set = this.p.get_index_full_set();
        if (index_full_set == 5) {
            par += 80;
        } else if (index_full_set > 0) {
            par += 50;
        }
        return par;
    }

    public int get_true_dame() {
        int par = this.total_param_item(57, true);
        byte index_full_set = this.p.get_index_full_set();
        if (index_full_set == 5) {
            par += 100;
        }
        return par;
    }

    public byte get_level_perfect() {
        byte result = 0;
        for (int i = 0; i < this.p.item.it_body.length; ++i) {
            if (this.p.item.it_body[i] == null || this.p.item.it_body[i].isHoanMy != 1 || this.p.item.it_body[i].valueKichAn <= -1) continue;
            result = (byte)(result + 1);
        }
        return result;
    }

    public int get_percent_final_dame() {
        return this.total_param_item(46, true);
    }

    public int get_xp_more() {
        return this.total_param_item(67, true);
    }

    public int get_xp_skill_more() {
        return this.total_param_item(68, true);
    }

    public int get_dame_devil_percent() {
        int par = 100;
        Skill_info sk = this.p.skill_point.get(0);
        switch (sk.lvdevil) {
            case 1: {
                par += 10;
                break;
            }
            case 2: {
                par += 25;
                break;
            }
            case 3: {
                par += 45;
                break;
            }
            case 4: {
                par += 70;
                break;
            }
            case 5: {
                par += 100;
            }
        }
        return par;
    }

    public int get_reduce_Eff() {
        return this.total_param_item(47, true);
    }

    public int get_HapThu_Hp() {
        int par = this.total_param_item(59, true);
        ItemFashionP2 itF = this.p.check_fashion(74);
        if (itF != null && itF.is_use) {
            par *= 2;
        }
        return par;
    }

    public long get_def_target_reduce() {
        int par = this.total_param_item(70, true);
        return par;
    }

    private static void load_point_1() {
        Point1_Template_atk = new int[200];
        Point1_Template_crit = new int[200];
        Point1_Template_pierce = new int[200];
        Body.Point1_Template_atk[0] = 44;
        Body.Point1_Template_atk[1] = 71;
        Body.Point1_Template_atk[2] = 100;
        Body.Point1_Template_atk[3] = 133;
        Body.Point1_Template_atk[4] = 168;
        Body.Point1_Template_atk[5] = 205;
        Body.Point1_Template_atk[6] = 246;
        Body.Point1_Template_atk[7] = 289;
        Body.Point1_Template_atk[8] = 336;
        Body.Point1_Template_atk[9] = 385;
        Body.Point1_Template_atk[10] = 436;
        Body.Point1_Template_atk[11] = 491;
        Body.Point1_Template_atk[12] = 548;
        Body.Point1_Template_atk[13] = 609;
        Body.Point1_Template_atk[14] = 672;
        Body.Point1_Template_atk[15] = 737;
        Body.Point1_Template_atk[16] = 806;
        Body.Point1_Template_atk[17] = 877;
        Body.Point1_Template_atk[18] = 952;
        Body.Point1_Template_atk[19] = 1029;
        Body.Point1_Template_atk[20] = 1108;
        Body.Point1_Template_atk[21] = 1191;
        Body.Point1_Template_atk[22] = 1276;
        Body.Point1_Template_atk[23] = 1365;
        Body.Point1_Template_atk[24] = 1456;
        Body.Point1_Template_atk[25] = 1549;
        Body.Point1_Template_atk[26] = 1646;
        Body.Point1_Template_atk[27] = 1745;
        Body.Point1_Template_atk[28] = 1848;
        Body.Point1_Template_atk[29] = 1953;
        Body.Point1_Template_atk[30] = 2060;
        Body.Point1_Template_atk[31] = 2171;
        Body.Point1_Template_atk[32] = 2284;
        Body.Point1_Template_atk[33] = 2401;
        Body.Point1_Template_atk[34] = 2520;
        Body.Point1_Template_atk[35] = 2641;
        Body.Point1_Template_atk[36] = 2766;
        Body.Point1_Template_atk[37] = 2893;
        Body.Point1_Template_atk[38] = 3024;
        Body.Point1_Template_atk[39] = 3157;
        Body.Point1_Template_atk[40] = 3292;
        Body.Point1_Template_atk[41] = 3431;
        Body.Point1_Template_atk[42] = 3572;
        Body.Point1_Template_atk[43] = 3717;
        Body.Point1_Template_atk[44] = 3864;
        Body.Point1_Template_atk[45] = 4013;
        Body.Point1_Template_atk[46] = 4166;
        Body.Point1_Template_atk[47] = 4321;
        Body.Point1_Template_atk[48] = 4480;
        Body.Point1_Template_atk[49] = 4641;
        Body.Point1_Template_atk[50] = 4804;
        Body.Point1_Template_atk[51] = 4971;
        Body.Point1_Template_atk[52] = 5140;
        Body.Point1_Template_atk[53] = 5313;
        Body.Point1_Template_atk[54] = 5488;
        Body.Point1_Template_atk[55] = 5665;
        Body.Point1_Template_atk[56] = 5846;
        Body.Point1_Template_atk[57] = 6029;
        Body.Point1_Template_atk[58] = 6216;
        Body.Point1_Template_atk[59] = 6405;
        Body.Point1_Template_atk[60] = 6596;
        Body.Point1_Template_atk[61] = 6791;
        Body.Point1_Template_atk[62] = 6988;
        Body.Point1_Template_atk[63] = 7189;
        Body.Point1_Template_atk[64] = 7392;
        Body.Point1_Template_atk[65] = 7597;
        Body.Point1_Template_atk[66] = 7806;
        Body.Point1_Template_atk[67] = 8017;
        Body.Point1_Template_atk[68] = 8232;
        Body.Point1_Template_atk[69] = 8449;
        Body.Point1_Template_atk[70] = 8668;
        Body.Point1_Template_atk[71] = 8891;
        Body.Point1_Template_atk[72] = 9116;
        Body.Point1_Template_atk[73] = 9345;
        Body.Point1_Template_atk[74] = 9576;
        Body.Point1_Template_atk[75] = 9809;
        Body.Point1_Template_atk[76] = 10046;
        Body.Point1_Template_atk[77] = 10285;
        Body.Point1_Template_atk[78] = 10528;
        Body.Point1_Template_atk[79] = 10773;
        Body.Point1_Template_atk[80] = 11020;
        Body.Point1_Template_crit[0] = 0;
        Body.Point1_Template_crit[1] = 0;
        Body.Point1_Template_crit[2] = 0;
        Body.Point1_Template_crit[3] = 0;
        Body.Point1_Template_crit[4] = 0;
        Body.Point1_Template_crit[5] = 0;
        Body.Point1_Template_crit[6] = 0;
        Body.Point1_Template_crit[7] = 0;
        Body.Point1_Template_crit[8] = 0;
        Body.Point1_Template_crit[9] = 0;
        Body.Point1_Template_crit[10] = 0;
        Body.Point1_Template_crit[11] = 0;
        Body.Point1_Template_crit[12] = 0;
        Body.Point1_Template_crit[13] = 0;
        Body.Point1_Template_crit[14] = 0;
        Body.Point1_Template_crit[15] = 0;
        Body.Point1_Template_crit[16] = 0;
        Body.Point1_Template_crit[17] = 0;
        Body.Point1_Template_crit[18] = 0;
        Body.Point1_Template_crit[19] = 10;
        Body.Point1_Template_crit[20] = 11;
        Body.Point1_Template_crit[21] = 12;
        Body.Point1_Template_crit[22] = 13;
        Body.Point1_Template_crit[23] = 14;
        Body.Point1_Template_crit[24] = 15;
        Body.Point1_Template_crit[25] = 16;
        Body.Point1_Template_crit[26] = 17;
        Body.Point1_Template_crit[27] = 18;
        Body.Point1_Template_crit[28] = 19;
        Body.Point1_Template_crit[29] = 20;
        Body.Point1_Template_crit[30] = 21;
        Body.Point1_Template_crit[31] = 22;
        Body.Point1_Template_crit[32] = 23;
        Body.Point1_Template_crit[33] = 24;
        Body.Point1_Template_crit[34] = 25;
        Body.Point1_Template_crit[35] = 26;
        Body.Point1_Template_crit[36] = 27;
        Body.Point1_Template_crit[37] = 28;
        Body.Point1_Template_crit[38] = 29;
        Body.Point1_Template_crit[39] = 30;
        Body.Point1_Template_crit[40] = 31;
        Body.Point1_Template_crit[41] = 32;
        Body.Point1_Template_crit[42] = 33;
        Body.Point1_Template_crit[43] = 34;
        Body.Point1_Template_crit[44] = 35;
        Body.Point1_Template_crit[45] = 36;
        Body.Point1_Template_crit[46] = 37;
        Body.Point1_Template_crit[47] = 38;
        Body.Point1_Template_crit[48] = 39;
        Body.Point1_Template_crit[49] = 40;
        Body.Point1_Template_crit[50] = 41;
        Body.Point1_Template_crit[51] = 42;
        Body.Point1_Template_crit[52] = 43;
        Body.Point1_Template_crit[53] = 44;
        Body.Point1_Template_crit[54] = 45;
        Body.Point1_Template_crit[55] = 46;
        Body.Point1_Template_crit[56] = 47;
        Body.Point1_Template_crit[57] = 48;
        Body.Point1_Template_crit[58] = 49;
        Body.Point1_Template_crit[59] = 50;
        Body.Point1_Template_crit[60] = 51;
        Body.Point1_Template_crit[61] = 52;
        Body.Point1_Template_crit[62] = 53;
        Body.Point1_Template_crit[63] = 54;
        Body.Point1_Template_crit[64] = 55;
        Body.Point1_Template_crit[65] = 56;
        Body.Point1_Template_crit[66] = 57;
        Body.Point1_Template_crit[67] = 58;
        Body.Point1_Template_crit[68] = 59;
        Body.Point1_Template_crit[69] = 60;
        Body.Point1_Template_crit[70] = 61;
        Body.Point1_Template_crit[71] = 62;
        Body.Point1_Template_crit[72] = 63;
        Body.Point1_Template_crit[73] = 64;
        Body.Point1_Template_crit[74] = 65;
        Body.Point1_Template_crit[75] = 66;
        Body.Point1_Template_crit[76] = 67;
        Body.Point1_Template_crit[77] = 68;
        Body.Point1_Template_crit[78] = 69;
        Body.Point1_Template_crit[79] = 70;
        Body.Point1_Template_crit[80] = 71;
        Body.Point1_Template_pierce[0] = 0;
        Body.Point1_Template_pierce[1] = 0;
        Body.Point1_Template_pierce[2] = 0;
        Body.Point1_Template_pierce[3] = 0;
        Body.Point1_Template_pierce[4] = 0;
        Body.Point1_Template_pierce[5] = 0;
        Body.Point1_Template_pierce[6] = 0;
        Body.Point1_Template_pierce[7] = 0;
        Body.Point1_Template_pierce[8] = 0;
        Body.Point1_Template_pierce[9] = 0;
        Body.Point1_Template_pierce[10] = 0;
        Body.Point1_Template_pierce[11] = 0;
        Body.Point1_Template_pierce[12] = 0;
        Body.Point1_Template_pierce[13] = 0;
        Body.Point1_Template_pierce[14] = 0;
        Body.Point1_Template_pierce[15] = 0;
        Body.Point1_Template_pierce[16] = 0;
        Body.Point1_Template_pierce[17] = 0;
        Body.Point1_Template_pierce[18] = 0;
        Body.Point1_Template_pierce[19] = 10;
        Body.Point1_Template_pierce[20] = 12;
        Body.Point1_Template_pierce[21] = 14;
        Body.Point1_Template_pierce[22] = 16;
        Body.Point1_Template_pierce[23] = 18;
        Body.Point1_Template_pierce[24] = 20;
        Body.Point1_Template_pierce[25] = 22;
        Body.Point1_Template_pierce[26] = 24;
        Body.Point1_Template_pierce[27] = 26;
        Body.Point1_Template_pierce[28] = 28;
        Body.Point1_Template_pierce[29] = 30;
        Body.Point1_Template_pierce[30] = 32;
        Body.Point1_Template_pierce[31] = 34;
        Body.Point1_Template_pierce[32] = 36;
        Body.Point1_Template_pierce[33] = 38;
        Body.Point1_Template_pierce[34] = 40;
        Body.Point1_Template_pierce[35] = 42;
        Body.Point1_Template_pierce[36] = 44;
        Body.Point1_Template_pierce[37] = 46;
        Body.Point1_Template_pierce[38] = 48;
        Body.Point1_Template_pierce[39] = 50;
        Body.Point1_Template_pierce[40] = 52;
        Body.Point1_Template_pierce[41] = 54;
        Body.Point1_Template_pierce[42] = 56;
        Body.Point1_Template_pierce[43] = 58;
        Body.Point1_Template_pierce[44] = 60;
        Body.Point1_Template_pierce[45] = 62;
        Body.Point1_Template_pierce[46] = 64;
        Body.Point1_Template_pierce[47] = 66;
        Body.Point1_Template_pierce[48] = 68;
        Body.Point1_Template_pierce[49] = 70;
        Body.Point1_Template_pierce[50] = 72;
        Body.Point1_Template_pierce[51] = 74;
        Body.Point1_Template_pierce[52] = 76;
        Body.Point1_Template_pierce[53] = 78;
        Body.Point1_Template_pierce[54] = 80;
        Body.Point1_Template_pierce[55] = 82;
        Body.Point1_Template_pierce[56] = 84;
        Body.Point1_Template_pierce[57] = 86;
        Body.Point1_Template_pierce[58] = 88;
        Body.Point1_Template_pierce[59] = 90;
        Body.Point1_Template_pierce[60] = 92;
        Body.Point1_Template_pierce[61] = 94;
        Body.Point1_Template_pierce[62] = 96;
        Body.Point1_Template_pierce[63] = 98;
        Body.Point1_Template_pierce[64] = 100;
        Body.Point1_Template_pierce[65] = 102;
        Body.Point1_Template_pierce[66] = 104;
        Body.Point1_Template_pierce[67] = 106;
        Body.Point1_Template_pierce[68] = 108;
        Body.Point1_Template_pierce[69] = 110;
        Body.Point1_Template_pierce[70] = 112;
        Body.Point1_Template_pierce[71] = 114;
        Body.Point1_Template_pierce[72] = 116;
        Body.Point1_Template_pierce[73] = 118;
        Body.Point1_Template_pierce[74] = 120;
        Body.Point1_Template_pierce[75] = 122;
        Body.Point1_Template_pierce[76] = 124;
        Body.Point1_Template_pierce[77] = 126;
        Body.Point1_Template_pierce[78] = 128;
        Body.Point1_Template_pierce[79] = 130;
        Body.Point1_Template_pierce[80] = 132;
        for (int i = 80; i < 200; ++i) {
            Body.Point1_Template_atk[i] = Point1_Template_atk[i - 1] + (Point1_Template_atk[i - 1] - Point1_Template_atk[i - 2]);
            Body.Point1_Template_crit[i] = Point1_Template_crit[i - 1] + (Point1_Template_crit[i - 1] - Point1_Template_crit[i - 2]);
            Body.Point1_Template_pierce[i] = Point1_Template_pierce[i - 1] + (Point1_Template_pierce[i - 1] - Point1_Template_pierce[i - 2]);
        }
    }

    private static void load_point_2() {
        Point2_Template_def = new int[200];
        Point2_Template_resist_magic = new int[200];
        Point2_Template_resist_physical = new int[200];
        Body.Point2_Template_def[0] = 140;
        Body.Point2_Template_def[1] = 148;
        Body.Point2_Template_def[2] = 165;
        Body.Point2_Template_def[3] = 182;
        Body.Point2_Template_def[4] = 199;
        Body.Point2_Template_def[5] = 225;
        Body.Point2_Template_def[6] = 251;
        Body.Point2_Template_def[7] = 277;
        Body.Point2_Template_def[8] = 312;
        Body.Point2_Template_def[9] = 347;
        Body.Point2_Template_def[10] = 382;
        Body.Point2_Template_def[11] = 417;
        Body.Point2_Template_def[12] = 461;
        Body.Point2_Template_def[13] = 505;
        Body.Point2_Template_def[14] = 558;
        Body.Point2_Template_def[15] = 611;
        Body.Point2_Template_def[16] = 664;
        Body.Point2_Template_def[17] = 726;
        Body.Point2_Template_def[18] = 788;
        Body.Point2_Template_def[19] = 850;
        Body.Point2_Template_def[20] = 921;
        Body.Point2_Template_def[21] = 992;
        Body.Point2_Template_def[22] = 1072;
        Body.Point2_Template_def[23] = 1161;
        Body.Point2_Template_def[24] = 1250;
        Body.Point2_Template_def[25] = 1339;
        Body.Point2_Template_def[26] = 1436;
        Body.Point2_Template_def[27] = 1533;
        Body.Point2_Template_def[28] = 1630;
        Body.Point2_Template_def[29] = 1736;
        Body.Point2_Template_def[30] = 1842;
        Body.Point2_Template_def[31] = 1948;
        Body.Point2_Template_def[32] = 2063;
        Body.Point2_Template_def[33] = 2178;
        Body.Point2_Template_def[34] = 2293;
        Body.Point2_Template_def[35] = 2417;
        Body.Point2_Template_def[36] = 2541;
        Body.Point2_Template_def[37] = 2665;
        Body.Point2_Template_def[38] = 2798;
        Body.Point2_Template_def[39] = 2931;
        Body.Point2_Template_def[40] = 3064;
        Body.Point2_Template_def[41] = 3197;
        Body.Point2_Template_def[42] = 3339;
        Body.Point2_Template_def[43] = 3481;
        Body.Point2_Template_def[44] = 3632;
        Body.Point2_Template_def[45] = 3783;
        Body.Point2_Template_def[46] = 3934;
        Body.Point2_Template_def[47] = 4094;
        Body.Point2_Template_def[48] = 4254;
        Body.Point2_Template_def[49] = 4414;
        Body.Point2_Template_def[50] = 4583;
        Body.Point2_Template_def[51] = 4752;
        Body.Point2_Template_def[52] = 4930;
        Body.Point2_Template_def[53] = 5116;
        Body.Point2_Template_def[54] = 5302;
        Body.Point2_Template_def[55] = 5488;
        Body.Point2_Template_def[56] = 5683;
        Body.Point2_Template_def[57] = 5878;
        Body.Point2_Template_def[58] = 6073;
        Body.Point2_Template_def[59] = 6277;
        Body.Point2_Template_def[60] = 6481;
        Body.Point2_Template_def[61] = 6685;
        Body.Point2_Template_def[62] = 6898;
        Body.Point2_Template_def[63] = 7111;
        Body.Point2_Template_def[64] = 7324;
        Body.Point2_Template_def[65] = 7546;
        Body.Point2_Template_def[66] = 7768;
        Body.Point2_Template_def[67] = 7990;
        Body.Point2_Template_def[68] = 8221;
        Body.Point2_Template_def[69] = 8452;
        Body.Point2_Template_def[70] = 8683;
        Body.Point2_Template_def[71] = 8914;
        Body.Point2_Template_def[72] = 9154;
        Body.Point2_Template_def[73] = 9394;
        Body.Point2_Template_def[74] = 9643;
        Body.Point2_Template_def[75] = 9892;
        Body.Point2_Template_def[76] = 10141;
        Body.Point2_Template_def[77] = 10399;
        Body.Point2_Template_def[78] = 10657;
        Body.Point2_Template_def[79] = 10915;
        Body.Point2_Template_def[80] = 11182;
        Body.Point2_Template_resist_magic[0] = 0;
        Body.Point2_Template_resist_magic[1] = 0;
        Body.Point2_Template_resist_magic[2] = 0;
        Body.Point2_Template_resist_magic[3] = 0;
        Body.Point2_Template_resist_magic[4] = 0;
        Body.Point2_Template_resist_magic[5] = 0;
        Body.Point2_Template_resist_magic[6] = 0;
        Body.Point2_Template_resist_magic[7] = 0;
        Body.Point2_Template_resist_magic[8] = 0;
        Body.Point2_Template_resist_magic[9] = 0;
        Body.Point2_Template_resist_magic[10] = 0;
        Body.Point2_Template_resist_magic[11] = 0;
        Body.Point2_Template_resist_magic[12] = 0;
        Body.Point2_Template_resist_magic[13] = 0;
        Body.Point2_Template_resist_magic[14] = 0;
        Body.Point2_Template_resist_magic[15] = 0;
        Body.Point2_Template_resist_magic[16] = 0;
        Body.Point2_Template_resist_magic[17] = 0;
        Body.Point2_Template_resist_magic[18] = 0;
        Body.Point2_Template_resist_magic[19] = 10;
        Body.Point2_Template_resist_magic[20] = 15;
        Body.Point2_Template_resist_magic[21] = 20;
        Body.Point2_Template_resist_magic[22] = 25;
        Body.Point2_Template_resist_magic[23] = 30;
        Body.Point2_Template_resist_magic[24] = 35;
        Body.Point2_Template_resist_magic[25] = 40;
        Body.Point2_Template_resist_magic[26] = 45;
        Body.Point2_Template_resist_magic[27] = 50;
        Body.Point2_Template_resist_magic[28] = 55;
        Body.Point2_Template_resist_magic[29] = 60;
        Body.Point2_Template_resist_magic[30] = 65;
        Body.Point2_Template_resist_magic[31] = 70;
        Body.Point2_Template_resist_magic[32] = 75;
        Body.Point2_Template_resist_magic[33] = 80;
        Body.Point2_Template_resist_magic[34] = 85;
        Body.Point2_Template_resist_magic[35] = 90;
        Body.Point2_Template_resist_magic[36] = 95;
        Body.Point2_Template_resist_magic[37] = 100;
        Body.Point2_Template_resist_magic[38] = 105;
        Body.Point2_Template_resist_magic[39] = 110;
        Body.Point2_Template_resist_magic[40] = 115;
        Body.Point2_Template_resist_magic[41] = 120;
        Body.Point2_Template_resist_magic[42] = 125;
        Body.Point2_Template_resist_magic[43] = 130;
        Body.Point2_Template_resist_magic[44] = 135;
        Body.Point2_Template_resist_magic[45] = 140;
        Body.Point2_Template_resist_magic[46] = 145;
        Body.Point2_Template_resist_magic[47] = 150;
        Body.Point2_Template_resist_magic[48] = 155;
        Body.Point2_Template_resist_magic[49] = 160;
        Body.Point2_Template_resist_magic[50] = 165;
        Body.Point2_Template_resist_magic[51] = 170;
        Body.Point2_Template_resist_magic[52] = 175;
        Body.Point2_Template_resist_magic[53] = 180;
        Body.Point2_Template_resist_magic[54] = 185;
        Body.Point2_Template_resist_magic[55] = 190;
        Body.Point2_Template_resist_magic[56] = 195;
        Body.Point2_Template_resist_magic[57] = 200;
        Body.Point2_Template_resist_magic[58] = 205;
        Body.Point2_Template_resist_magic[59] = 210;
        Body.Point2_Template_resist_magic[60] = 215;
        Body.Point2_Template_resist_magic[61] = 220;
        Body.Point2_Template_resist_magic[62] = 225;
        Body.Point2_Template_resist_magic[63] = 230;
        Body.Point2_Template_resist_magic[64] = 235;
        Body.Point2_Template_resist_magic[65] = 240;
        Body.Point2_Template_resist_magic[66] = 245;
        Body.Point2_Template_resist_magic[67] = 250;
        Body.Point2_Template_resist_magic[68] = 255;
        Body.Point2_Template_resist_magic[69] = 260;
        Body.Point2_Template_resist_magic[70] = 265;
        Body.Point2_Template_resist_magic[71] = 270;
        Body.Point2_Template_resist_magic[72] = 275;
        Body.Point2_Template_resist_magic[73] = 280;
        Body.Point2_Template_resist_magic[74] = 285;
        Body.Point2_Template_resist_magic[75] = 290;
        Body.Point2_Template_resist_magic[76] = 295;
        Body.Point2_Template_resist_magic[77] = 300;
        Body.Point2_Template_resist_magic[78] = 305;
        Body.Point2_Template_resist_magic[79] = 310;
        Body.Point2_Template_resist_magic[80] = 315;
        Body.Point2_Template_resist_physical[0] = 0;
        Body.Point2_Template_resist_physical[1] = 0;
        Body.Point2_Template_resist_physical[2] = 0;
        Body.Point2_Template_resist_physical[3] = 0;
        Body.Point2_Template_resist_physical[4] = 0;
        Body.Point2_Template_resist_physical[5] = 0;
        Body.Point2_Template_resist_physical[6] = 0;
        Body.Point2_Template_resist_physical[7] = 0;
        Body.Point2_Template_resist_physical[8] = 0;
        Body.Point2_Template_resist_physical[9] = 0;
        Body.Point2_Template_resist_physical[10] = 0;
        Body.Point2_Template_resist_physical[11] = 0;
        Body.Point2_Template_resist_physical[12] = 0;
        Body.Point2_Template_resist_physical[13] = 0;
        Body.Point2_Template_resist_physical[14] = 0;
        Body.Point2_Template_resist_physical[15] = 0;
        Body.Point2_Template_resist_physical[16] = 0;
        Body.Point2_Template_resist_physical[17] = 0;
        Body.Point2_Template_resist_physical[18] = 0;
        Body.Point2_Template_resist_physical[19] = 10;
        Body.Point2_Template_resist_physical[20] = 15;
        Body.Point2_Template_resist_physical[21] = 20;
        Body.Point2_Template_resist_physical[22] = 25;
        Body.Point2_Template_resist_physical[23] = 30;
        Body.Point2_Template_resist_physical[24] = 35;
        Body.Point2_Template_resist_physical[25] = 40;
        Body.Point2_Template_resist_physical[26] = 45;
        Body.Point2_Template_resist_physical[27] = 50;
        Body.Point2_Template_resist_physical[28] = 55;
        Body.Point2_Template_resist_physical[29] = 60;
        Body.Point2_Template_resist_physical[30] = 65;
        Body.Point2_Template_resist_physical[31] = 70;
        Body.Point2_Template_resist_physical[32] = 75;
        Body.Point2_Template_resist_physical[33] = 80;
        Body.Point2_Template_resist_physical[34] = 85;
        Body.Point2_Template_resist_physical[35] = 90;
        Body.Point2_Template_resist_physical[36] = 95;
        Body.Point2_Template_resist_physical[37] = 100;
        Body.Point2_Template_resist_physical[38] = 105;
        Body.Point2_Template_resist_physical[39] = 110;
        Body.Point2_Template_resist_physical[40] = 115;
        Body.Point2_Template_resist_physical[41] = 120;
        Body.Point2_Template_resist_physical[42] = 125;
        Body.Point2_Template_resist_physical[43] = 130;
        Body.Point2_Template_resist_physical[44] = 135;
        Body.Point2_Template_resist_physical[45] = 140;
        Body.Point2_Template_resist_physical[46] = 145;
        Body.Point2_Template_resist_physical[47] = 150;
        Body.Point2_Template_resist_physical[48] = 155;
        Body.Point2_Template_resist_physical[49] = 160;
        Body.Point2_Template_resist_physical[50] = 165;
        Body.Point2_Template_resist_physical[51] = 170;
        Body.Point2_Template_resist_physical[52] = 175;
        Body.Point2_Template_resist_physical[53] = 180;
        Body.Point2_Template_resist_physical[54] = 185;
        Body.Point2_Template_resist_physical[55] = 190;
        Body.Point2_Template_resist_physical[56] = 195;
        Body.Point2_Template_resist_physical[57] = 200;
        Body.Point2_Template_resist_physical[58] = 205;
        Body.Point2_Template_resist_physical[59] = 210;
        Body.Point2_Template_resist_physical[60] = 215;
        Body.Point2_Template_resist_physical[61] = 220;
        Body.Point2_Template_resist_physical[62] = 225;
        Body.Point2_Template_resist_physical[63] = 230;
        Body.Point2_Template_resist_physical[64] = 235;
        Body.Point2_Template_resist_physical[65] = 240;
        Body.Point2_Template_resist_physical[66] = 245;
        Body.Point2_Template_resist_physical[67] = 250;
        Body.Point2_Template_resist_physical[68] = 255;
        Body.Point2_Template_resist_physical[69] = 260;
        Body.Point2_Template_resist_physical[70] = 265;
        Body.Point2_Template_resist_physical[71] = 270;
        Body.Point2_Template_resist_physical[72] = 275;
        Body.Point2_Template_resist_physical[73] = 280;
        Body.Point2_Template_resist_physical[74] = 285;
        Body.Point2_Template_resist_physical[75] = 290;
        Body.Point2_Template_resist_physical[76] = 295;
        Body.Point2_Template_resist_physical[77] = 300;
        Body.Point2_Template_resist_physical[78] = 305;
        Body.Point2_Template_resist_physical[79] = 310;
        Body.Point2_Template_resist_physical[80] = 315;
        for (int i = 80; i < 200; ++i) {
            Body.Point2_Template_def[i] = Point2_Template_def[i - 1] + (Point2_Template_def[i - 1] - Point2_Template_def[i - 2]);
            Body.Point2_Template_resist_magic[i] = Point2_Template_resist_magic[i - 1] + (Point2_Template_resist_magic[i - 1] - Point2_Template_resist_magic[i - 2]);
            Body.Point2_Template_resist_physical[i] = Point2_Template_resist_physical[i - 1] + (Point2_Template_resist_physical[i - 1] - Point2_Template_resist_physical[i - 2]);
        }
    }

    private static void load_point_3() {
        Point3_Template_hp = new int[200];
        Point3_Template_hp_potion = new int[200];
        Body.Point3_Template_hp[0] = 1001;
        Body.Point3_Template_hp[1] = 1016;
        Body.Point3_Template_hp[2] = 1041;
        Body.Point3_Template_hp[3] = 1076;
        Body.Point3_Template_hp[4] = 1121;
        Body.Point3_Template_hp[5] = 1176;
        Body.Point3_Template_hp[6] = 1241;
        Body.Point3_Template_hp[7] = 1316;
        Body.Point3_Template_hp[8] = 1401;
        Body.Point3_Template_hp[9] = 1496;
        Body.Point3_Template_hp[10] = 1601;
        Body.Point3_Template_hp[11] = 1716;
        Body.Point3_Template_hp[12] = 1841;
        Body.Point3_Template_hp[13] = 1976;
        Body.Point3_Template_hp[14] = 2121;
        Body.Point3_Template_hp[15] = 2276;
        Body.Point3_Template_hp[16] = 2441;
        Body.Point3_Template_hp[17] = 2616;
        Body.Point3_Template_hp[18] = 2801;
        Body.Point3_Template_hp[19] = 2996;
        Body.Point3_Template_hp[20] = 3201;
        Body.Point3_Template_hp[21] = 3416;
        Body.Point3_Template_hp[22] = 3641;
        Body.Point3_Template_hp[23] = 3876;
        Body.Point3_Template_hp[24] = 4121;
        Body.Point3_Template_hp[25] = 4376;
        Body.Point3_Template_hp[26] = 4641;
        Body.Point3_Template_hp[27] = 4916;
        Body.Point3_Template_hp[28] = 5201;
        Body.Point3_Template_hp[29] = 5496;
        Body.Point3_Template_hp[30] = 5801;
        Body.Point3_Template_hp[31] = 6116;
        Body.Point3_Template_hp[32] = 6441;
        Body.Point3_Template_hp[33] = 6776;
        Body.Point3_Template_hp[34] = 7121;
        Body.Point3_Template_hp[35] = 7476;
        Body.Point3_Template_hp[36] = 7841;
        Body.Point3_Template_hp[37] = 8216;
        Body.Point3_Template_hp[38] = 8601;
        Body.Point3_Template_hp[39] = 8996;
        Body.Point3_Template_hp[40] = 9401;
        Body.Point3_Template_hp[41] = 9816;
        Body.Point3_Template_hp[42] = 10241;
        Body.Point3_Template_hp[43] = 10676;
        Body.Point3_Template_hp[44] = 11121;
        Body.Point3_Template_hp[45] = 11576;
        Body.Point3_Template_hp[46] = 12041;
        Body.Point3_Template_hp[47] = 12516;
        Body.Point3_Template_hp[48] = 13001;
        Body.Point3_Template_hp[49] = 13496;
        Body.Point3_Template_hp[50] = 14001;
        Body.Point3_Template_hp[51] = 14516;
        Body.Point3_Template_hp[52] = 15041;
        Body.Point3_Template_hp[53] = 15576;
        Body.Point3_Template_hp[54] = 16121;
        Body.Point3_Template_hp[55] = 16676;
        Body.Point3_Template_hp[56] = 17241;
        Body.Point3_Template_hp[57] = 17816;
        Body.Point3_Template_hp[58] = 18401;
        Body.Point3_Template_hp[59] = 18996;
        Body.Point3_Template_hp[60] = 19601;
        Body.Point3_Template_hp[61] = 20216;
        Body.Point3_Template_hp[62] = 20841;
        Body.Point3_Template_hp[63] = 21476;
        Body.Point3_Template_hp[64] = 22121;
        Body.Point3_Template_hp[65] = 22776;
        Body.Point3_Template_hp[66] = 23441;
        Body.Point3_Template_hp[67] = 24116;
        Body.Point3_Template_hp[68] = 24801;
        Body.Point3_Template_hp[69] = 25496;
        Body.Point3_Template_hp[70] = 26201;
        Body.Point3_Template_hp[71] = 26916;
        Body.Point3_Template_hp[72] = 27641;
        Body.Point3_Template_hp[73] = 28376;
        Body.Point3_Template_hp[74] = 29121;
        Body.Point3_Template_hp[75] = 29876;
        Body.Point3_Template_hp[76] = 30641;
        Body.Point3_Template_hp[77] = 31416;
        Body.Point3_Template_hp[78] = 32201;
        Body.Point3_Template_hp[79] = 32996;
        Body.Point3_Template_hp[80] = 33801;
        Body.Point3_Template_hp_potion[0] = 0;
        Body.Point3_Template_hp_potion[1] = 0;
        Body.Point3_Template_hp_potion[2] = 0;
        Body.Point3_Template_hp_potion[3] = 0;
        Body.Point3_Template_hp_potion[4] = 0;
        Body.Point3_Template_hp_potion[5] = 0;
        Body.Point3_Template_hp_potion[6] = 0;
        Body.Point3_Template_hp_potion[7] = 0;
        Body.Point3_Template_hp_potion[8] = 0;
        Body.Point3_Template_hp_potion[9] = 0;
        Body.Point3_Template_hp_potion[10] = 0;
        Body.Point3_Template_hp_potion[11] = 0;
        Body.Point3_Template_hp_potion[12] = 0;
        Body.Point3_Template_hp_potion[13] = 0;
        Body.Point3_Template_hp_potion[14] = 0;
        Body.Point3_Template_hp_potion[15] = 0;
        Body.Point3_Template_hp_potion[16] = 0;
        Body.Point3_Template_hp_potion[17] = 0;
        Body.Point3_Template_hp_potion[18] = 0;
        Body.Point3_Template_hp_potion[19] = 12;
        Body.Point3_Template_hp_potion[20] = 24;
        Body.Point3_Template_hp_potion[21] = 36;
        Body.Point3_Template_hp_potion[22] = 48;
        Body.Point3_Template_hp_potion[23] = 60;
        Body.Point3_Template_hp_potion[24] = 72;
        Body.Point3_Template_hp_potion[25] = 84;
        Body.Point3_Template_hp_potion[26] = 96;
        Body.Point3_Template_hp_potion[27] = 108;
        Body.Point3_Template_hp_potion[28] = 120;
        Body.Point3_Template_hp_potion[29] = 132;
        Body.Point3_Template_hp_potion[30] = 144;
        Body.Point3_Template_hp_potion[31] = 156;
        Body.Point3_Template_hp_potion[32] = 168;
        Body.Point3_Template_hp_potion[33] = 180;
        Body.Point3_Template_hp_potion[34] = 192;
        Body.Point3_Template_hp_potion[35] = 204;
        Body.Point3_Template_hp_potion[36] = 216;
        Body.Point3_Template_hp_potion[37] = 228;
        Body.Point3_Template_hp_potion[38] = 240;
        Body.Point3_Template_hp_potion[39] = 252;
        Body.Point3_Template_hp_potion[40] = 264;
        Body.Point3_Template_hp_potion[41] = 276;
        Body.Point3_Template_hp_potion[42] = 288;
        Body.Point3_Template_hp_potion[43] = 300;
        Body.Point3_Template_hp_potion[44] = 312;
        Body.Point3_Template_hp_potion[45] = 324;
        Body.Point3_Template_hp_potion[46] = 336;
        Body.Point3_Template_hp_potion[47] = 348;
        Body.Point3_Template_hp_potion[48] = 360;
        Body.Point3_Template_hp_potion[49] = 372;
        Body.Point3_Template_hp_potion[50] = 384;
        Body.Point3_Template_hp_potion[51] = 396;
        Body.Point3_Template_hp_potion[52] = 408;
        Body.Point3_Template_hp_potion[53] = 420;
        Body.Point3_Template_hp_potion[54] = 432;
        Body.Point3_Template_hp_potion[55] = 444;
        Body.Point3_Template_hp_potion[56] = 456;
        Body.Point3_Template_hp_potion[57] = 468;
        Body.Point3_Template_hp_potion[58] = 480;
        Body.Point3_Template_hp_potion[59] = 492;
        Body.Point3_Template_hp_potion[60] = 504;
        Body.Point3_Template_hp_potion[61] = 516;
        Body.Point3_Template_hp_potion[62] = 528;
        Body.Point3_Template_hp_potion[63] = 540;
        Body.Point3_Template_hp_potion[64] = 552;
        Body.Point3_Template_hp_potion[65] = 564;
        Body.Point3_Template_hp_potion[66] = 576;
        Body.Point3_Template_hp_potion[67] = 588;
        Body.Point3_Template_hp_potion[68] = 600;
        Body.Point3_Template_hp_potion[69] = 612;
        Body.Point3_Template_hp_potion[70] = 624;
        Body.Point3_Template_hp_potion[71] = 636;
        Body.Point3_Template_hp_potion[72] = 648;
        Body.Point3_Template_hp_potion[73] = 660;
        Body.Point3_Template_hp_potion[74] = 672;
        Body.Point3_Template_hp_potion[75] = 684;
        Body.Point3_Template_hp_potion[76] = 696;
        Body.Point3_Template_hp_potion[77] = 708;
        Body.Point3_Template_hp_potion[78] = 720;
        Body.Point3_Template_hp_potion[79] = 732;
        Body.Point3_Template_hp_potion[80] = 744;
        for (int i = 80; i < 200; ++i) {
            Body.Point3_Template_hp[i] = Point3_Template_hp[i - 1] + (Point3_Template_hp[i - 1] - Point3_Template_hp[i - 2]);
            Body.Point3_Template_hp_potion[i] = Point3_Template_hp_potion[i - 1] + (Point3_Template_hp_potion[i - 1] - Point3_Template_hp_potion[i - 2]);
        }
    }

    private static void load_point_4() {
        Point4_Template_mp = new int[200];
        Point4_Template_dame_crit = new int[200];
        Body.Point4_Template_mp[0] = 20;
        Body.Point4_Template_mp[1] = 21;
        Body.Point4_Template_mp[2] = 24;
        Body.Point4_Template_mp[3] = 27;
        Body.Point4_Template_mp[4] = 32;
        Body.Point4_Template_mp[5] = 37;
        Body.Point4_Template_mp[6] = 44;
        Body.Point4_Template_mp[7] = 51;
        Body.Point4_Template_mp[8] = 60;
        Body.Point4_Template_mp[9] = 69;
        Body.Point4_Template_mp[10] = 80;
        Body.Point4_Template_mp[11] = 91;
        Body.Point4_Template_mp[12] = 104;
        Body.Point4_Template_mp[13] = 117;
        Body.Point4_Template_mp[14] = 132;
        Body.Point4_Template_mp[15] = 147;
        Body.Point4_Template_mp[16] = 164;
        Body.Point4_Template_mp[17] = 181;
        Body.Point4_Template_mp[18] = 200;
        Body.Point4_Template_mp[19] = 219;
        Body.Point4_Template_mp[20] = 240;
        Body.Point4_Template_mp[21] = 261;
        Body.Point4_Template_mp[22] = 284;
        Body.Point4_Template_mp[23] = 307;
        Body.Point4_Template_mp[24] = 332;
        Body.Point4_Template_mp[25] = 357;
        Body.Point4_Template_mp[26] = 384;
        Body.Point4_Template_mp[27] = 411;
        Body.Point4_Template_mp[28] = 440;
        Body.Point4_Template_mp[29] = 469;
        Body.Point4_Template_mp[30] = 500;
        Body.Point4_Template_mp[31] = 531;
        Body.Point4_Template_mp[32] = 564;
        Body.Point4_Template_mp[33] = 597;
        Body.Point4_Template_mp[34] = 632;
        Body.Point4_Template_mp[35] = 667;
        Body.Point4_Template_mp[36] = 704;
        Body.Point4_Template_mp[37] = 741;
        Body.Point4_Template_mp[38] = 780;
        Body.Point4_Template_mp[39] = 819;
        Body.Point4_Template_mp[40] = 860;
        Body.Point4_Template_mp[41] = 901;
        Body.Point4_Template_mp[42] = 944;
        Body.Point4_Template_mp[43] = 987;
        Body.Point4_Template_mp[44] = 1032;
        Body.Point4_Template_mp[45] = 1077;
        Body.Point4_Template_mp[46] = 1124;
        Body.Point4_Template_mp[47] = 1171;
        Body.Point4_Template_mp[48] = 1220;
        Body.Point4_Template_mp[49] = 1269;
        Body.Point4_Template_mp[50] = 1320;
        Body.Point4_Template_mp[51] = 1371;
        Body.Point4_Template_mp[52] = 1424;
        Body.Point4_Template_mp[53] = 1477;
        Body.Point4_Template_mp[54] = 1532;
        Body.Point4_Template_mp[55] = 1587;
        Body.Point4_Template_mp[56] = 1644;
        Body.Point4_Template_mp[57] = 1701;
        Body.Point4_Template_mp[58] = 1760;
        Body.Point4_Template_mp[59] = 1819;
        Body.Point4_Template_mp[60] = 1880;
        Body.Point4_Template_mp[61] = 1941;
        Body.Point4_Template_mp[62] = 2004;
        Body.Point4_Template_mp[63] = 2067;
        Body.Point4_Template_mp[64] = 2132;
        Body.Point4_Template_mp[65] = 2197;
        Body.Point4_Template_mp[66] = 2264;
        Body.Point4_Template_mp[67] = 2331;
        Body.Point4_Template_mp[68] = 2400;
        Body.Point4_Template_mp[69] = 2469;
        Body.Point4_Template_mp[70] = 2540;
        Body.Point4_Template_mp[71] = 2611;
        Body.Point4_Template_mp[72] = 2684;
        Body.Point4_Template_mp[73] = 2757;
        Body.Point4_Template_mp[74] = 2832;
        Body.Point4_Template_mp[75] = 2907;
        Body.Point4_Template_mp[76] = 2984;
        Body.Point4_Template_mp[77] = 3061;
        Body.Point4_Template_mp[78] = 3140;
        Body.Point4_Template_mp[79] = 3219;
        Body.Point4_Template_mp[80] = 3300;
        Body.Point4_Template_dame_crit[0] = 0;
        Body.Point4_Template_dame_crit[1] = 0;
        Body.Point4_Template_dame_crit[2] = 0;
        Body.Point4_Template_dame_crit[3] = 0;
        Body.Point4_Template_dame_crit[4] = 0;
        Body.Point4_Template_dame_crit[5] = 0;
        Body.Point4_Template_dame_crit[6] = 0;
        Body.Point4_Template_dame_crit[7] = 0;
        Body.Point4_Template_dame_crit[8] = 0;
        Body.Point4_Template_dame_crit[9] = 0;
        Body.Point4_Template_dame_crit[10] = 0;
        Body.Point4_Template_dame_crit[11] = 0;
        Body.Point4_Template_dame_crit[12] = 0;
        Body.Point4_Template_dame_crit[13] = 0;
        Body.Point4_Template_dame_crit[14] = 0;
        Body.Point4_Template_dame_crit[15] = 0;
        Body.Point4_Template_dame_crit[16] = 0;
        Body.Point4_Template_dame_crit[17] = 0;
        Body.Point4_Template_dame_crit[18] = 0;
        Body.Point4_Template_dame_crit[19] = 50;
        Body.Point4_Template_dame_crit[20] = 100;
        Body.Point4_Template_dame_crit[21] = 150;
        Body.Point4_Template_dame_crit[22] = 200;
        Body.Point4_Template_dame_crit[23] = 250;
        Body.Point4_Template_dame_crit[24] = 300;
        Body.Point4_Template_dame_crit[25] = 350;
        Body.Point4_Template_dame_crit[26] = 400;
        Body.Point4_Template_dame_crit[27] = 450;
        Body.Point4_Template_dame_crit[28] = 500;
        Body.Point4_Template_dame_crit[29] = 550;
        Body.Point4_Template_dame_crit[30] = 600;
        Body.Point4_Template_dame_crit[31] = 650;
        Body.Point4_Template_dame_crit[32] = 700;
        Body.Point4_Template_dame_crit[33] = 750;
        Body.Point4_Template_dame_crit[34] = 800;
        Body.Point4_Template_dame_crit[35] = 850;
        Body.Point4_Template_dame_crit[36] = 900;
        Body.Point4_Template_dame_crit[37] = 950;
        Body.Point4_Template_dame_crit[38] = 1000;
        Body.Point4_Template_dame_crit[39] = 1050;
        Body.Point4_Template_dame_crit[40] = 1100;
        Body.Point4_Template_dame_crit[41] = 1150;
        Body.Point4_Template_dame_crit[42] = 1200;
        Body.Point4_Template_dame_crit[43] = 1250;
        Body.Point4_Template_dame_crit[44] = 1300;
        Body.Point4_Template_dame_crit[45] = 1350;
        Body.Point4_Template_dame_crit[46] = 1400;
        Body.Point4_Template_dame_crit[47] = 1450;
        Body.Point4_Template_dame_crit[48] = 1500;
        Body.Point4_Template_dame_crit[49] = 1550;
        Body.Point4_Template_dame_crit[50] = 1600;
        Body.Point4_Template_dame_crit[51] = 1650;
        Body.Point4_Template_dame_crit[52] = 1700;
        Body.Point4_Template_dame_crit[53] = 1750;
        Body.Point4_Template_dame_crit[54] = 1800;
        Body.Point4_Template_dame_crit[55] = 1850;
        Body.Point4_Template_dame_crit[56] = 1900;
        Body.Point4_Template_dame_crit[57] = 1950;
        Body.Point4_Template_dame_crit[58] = 2000;
        Body.Point4_Template_dame_crit[59] = 2050;
        Body.Point4_Template_dame_crit[60] = 2100;
        Body.Point4_Template_dame_crit[61] = 2150;
        Body.Point4_Template_dame_crit[62] = 2200;
        Body.Point4_Template_dame_crit[63] = 2250;
        Body.Point4_Template_dame_crit[64] = 2300;
        Body.Point4_Template_dame_crit[65] = 2350;
        Body.Point4_Template_dame_crit[66] = 2400;
        Body.Point4_Template_dame_crit[67] = 2450;
        Body.Point4_Template_dame_crit[68] = 2500;
        Body.Point4_Template_dame_crit[69] = 2550;
        Body.Point4_Template_dame_crit[70] = 2600;
        Body.Point4_Template_dame_crit[71] = 2650;
        Body.Point4_Template_dame_crit[72] = 2700;
        Body.Point4_Template_dame_crit[73] = 2750;
        Body.Point4_Template_dame_crit[74] = 2800;
        Body.Point4_Template_dame_crit[75] = 2850;
        Body.Point4_Template_dame_crit[76] = 2900;
        Body.Point4_Template_dame_crit[77] = 2950;
        Body.Point4_Template_dame_crit[78] = 3000;
        Body.Point4_Template_dame_crit[79] = 3050;
        Body.Point4_Template_dame_crit[80] = 3100;
        for (int i = 80; i < 200; ++i) {
            Body.Point4_Template_mp[i] = Point4_Template_mp[i - 1] + (Point4_Template_mp[i - 1] - Point4_Template_mp[i - 2]);
            Body.Point4_Template_dame_crit[i] = Point4_Template_dame_crit[i - 1] + (Point4_Template_dame_crit[i - 1] - Point4_Template_dame_crit[i - 2]);
        }
    }

    private static void load_point_5() {
        Point5_Template_cooldown = new int[200];
        Point5_Template_miss = new int[200];
        Body.Point5_Template_cooldown[0] = 13;
        Body.Point5_Template_cooldown[1] = 16;
        Body.Point5_Template_cooldown[2] = 19;
        Body.Point5_Template_cooldown[3] = 22;
        Body.Point5_Template_cooldown[4] = 25;
        Body.Point5_Template_cooldown[5] = 28;
        Body.Point5_Template_cooldown[6] = 31;
        Body.Point5_Template_cooldown[7] = 34;
        Body.Point5_Template_cooldown[8] = 37;
        Body.Point5_Template_cooldown[9] = 40;
        Body.Point5_Template_cooldown[10] = 43;
        Body.Point5_Template_cooldown[11] = 46;
        Body.Point5_Template_cooldown[12] = 49;
        Body.Point5_Template_cooldown[13] = 52;
        Body.Point5_Template_cooldown[14] = 55;
        Body.Point5_Template_cooldown[15] = 58;
        Body.Point5_Template_cooldown[16] = 61;
        Body.Point5_Template_cooldown[17] = 64;
        Body.Point5_Template_cooldown[18] = 67;
        Body.Point5_Template_cooldown[19] = 70;
        Body.Point5_Template_cooldown[20] = 73;
        Body.Point5_Template_cooldown[21] = 76;
        Body.Point5_Template_cooldown[22] = 79;
        Body.Point5_Template_cooldown[23] = 82;
        Body.Point5_Template_cooldown[24] = 85;
        Body.Point5_Template_cooldown[25] = 88;
        Body.Point5_Template_cooldown[26] = 91;
        Body.Point5_Template_cooldown[27] = 94;
        Body.Point5_Template_cooldown[28] = 97;
        Body.Point5_Template_cooldown[29] = 100;
        Body.Point5_Template_cooldown[30] = 103;
        Body.Point5_Template_cooldown[31] = 106;
        Body.Point5_Template_cooldown[32] = 109;
        Body.Point5_Template_cooldown[33] = 112;
        Body.Point5_Template_cooldown[34] = 115;
        Body.Point5_Template_cooldown[35] = 118;
        Body.Point5_Template_cooldown[36] = 121;
        Body.Point5_Template_cooldown[37] = 124;
        Body.Point5_Template_cooldown[38] = 127;
        Body.Point5_Template_cooldown[39] = 130;
        Body.Point5_Template_cooldown[40] = 133;
        Body.Point5_Template_cooldown[41] = 136;
        Body.Point5_Template_cooldown[42] = 139;
        Body.Point5_Template_cooldown[43] = 142;
        Body.Point5_Template_cooldown[44] = 145;
        Body.Point5_Template_cooldown[45] = 148;
        Body.Point5_Template_cooldown[46] = 151;
        Body.Point5_Template_cooldown[47] = 154;
        Body.Point5_Template_cooldown[48] = 157;
        Body.Point5_Template_cooldown[49] = 160;
        Body.Point5_Template_cooldown[50] = 163;
        Body.Point5_Template_cooldown[51] = 166;
        Body.Point5_Template_cooldown[52] = 169;
        Body.Point5_Template_cooldown[53] = 172;
        Body.Point5_Template_cooldown[54] = 175;
        Body.Point5_Template_cooldown[55] = 178;
        Body.Point5_Template_cooldown[56] = 181;
        Body.Point5_Template_cooldown[57] = 184;
        Body.Point5_Template_cooldown[58] = 187;
        Body.Point5_Template_cooldown[59] = 190;
        Body.Point5_Template_cooldown[60] = 193;
        Body.Point5_Template_cooldown[61] = 196;
        Body.Point5_Template_cooldown[62] = 199;
        Body.Point5_Template_cooldown[63] = 202;
        Body.Point5_Template_cooldown[64] = 205;
        Body.Point5_Template_cooldown[65] = 208;
        Body.Point5_Template_cooldown[66] = 211;
        Body.Point5_Template_cooldown[67] = 214;
        Body.Point5_Template_cooldown[68] = 217;
        Body.Point5_Template_cooldown[69] = 220;
        Body.Point5_Template_cooldown[70] = 223;
        Body.Point5_Template_cooldown[71] = 226;
        Body.Point5_Template_cooldown[72] = 229;
        Body.Point5_Template_cooldown[73] = 232;
        Body.Point5_Template_cooldown[74] = 235;
        Body.Point5_Template_cooldown[75] = 238;
        Body.Point5_Template_cooldown[76] = 241;
        Body.Point5_Template_cooldown[77] = 244;
        Body.Point5_Template_cooldown[78] = 247;
        Body.Point5_Template_cooldown[79] = 250;
        Body.Point5_Template_cooldown[80] = 253;
        Body.Point5_Template_miss[0] = 0;
        Body.Point5_Template_miss[1] = 0;
        Body.Point5_Template_miss[2] = 0;
        Body.Point5_Template_miss[3] = 0;
        Body.Point5_Template_miss[4] = 0;
        Body.Point5_Template_miss[5] = 0;
        Body.Point5_Template_miss[6] = 0;
        Body.Point5_Template_miss[7] = 0;
        Body.Point5_Template_miss[8] = 0;
        Body.Point5_Template_miss[9] = 0;
        Body.Point5_Template_miss[10] = 0;
        Body.Point5_Template_miss[11] = 0;
        Body.Point5_Template_miss[12] = 0;
        Body.Point5_Template_miss[13] = 0;
        Body.Point5_Template_miss[14] = 0;
        Body.Point5_Template_miss[15] = 0;
        Body.Point5_Template_miss[16] = 0;
        Body.Point5_Template_miss[17] = 0;
        Body.Point5_Template_miss[18] = 0;
        Body.Point5_Template_miss[19] = 10;
        Body.Point5_Template_miss[20] = 12;
        Body.Point5_Template_miss[21] = 14;
        Body.Point5_Template_miss[22] = 16;
        Body.Point5_Template_miss[23] = 18;
        Body.Point5_Template_miss[24] = 20;
        Body.Point5_Template_miss[25] = 22;
        Body.Point5_Template_miss[26] = 24;
        Body.Point5_Template_miss[27] = 26;
        Body.Point5_Template_miss[28] = 28;
        Body.Point5_Template_miss[29] = 30;
        Body.Point5_Template_miss[30] = 32;
        Body.Point5_Template_miss[31] = 34;
        Body.Point5_Template_miss[32] = 36;
        Body.Point5_Template_miss[33] = 38;
        Body.Point5_Template_miss[34] = 40;
        Body.Point5_Template_miss[35] = 42;
        Body.Point5_Template_miss[36] = 44;
        Body.Point5_Template_miss[37] = 46;
        Body.Point5_Template_miss[38] = 48;
        Body.Point5_Template_miss[39] = 50;
        Body.Point5_Template_miss[40] = 52;
        Body.Point5_Template_miss[41] = 54;
        Body.Point5_Template_miss[42] = 56;
        Body.Point5_Template_miss[43] = 58;
        Body.Point5_Template_miss[44] = 60;
        Body.Point5_Template_miss[45] = 62;
        Body.Point5_Template_miss[46] = 64;
        Body.Point5_Template_miss[47] = 66;
        Body.Point5_Template_miss[48] = 68;
        Body.Point5_Template_miss[49] = 70;
        Body.Point5_Template_miss[50] = 72;
        Body.Point5_Template_miss[51] = 74;
        Body.Point5_Template_miss[52] = 76;
        Body.Point5_Template_miss[53] = 78;
        Body.Point5_Template_miss[54] = 80;
        Body.Point5_Template_miss[55] = 82;
        Body.Point5_Template_miss[56] = 84;
        Body.Point5_Template_miss[57] = 86;
        Body.Point5_Template_miss[58] = 88;
        Body.Point5_Template_miss[59] = 90;
        Body.Point5_Template_miss[60] = 92;
        Body.Point5_Template_miss[61] = 94;
        Body.Point5_Template_miss[62] = 96;
        Body.Point5_Template_miss[63] = 98;
        Body.Point5_Template_miss[64] = 100;
        Body.Point5_Template_miss[65] = 102;
        Body.Point5_Template_miss[66] = 104;
        Body.Point5_Template_miss[67] = 106;
        Body.Point5_Template_miss[68] = 108;
        Body.Point5_Template_miss[69] = 110;
        Body.Point5_Template_miss[70] = 112;
        Body.Point5_Template_miss[71] = 114;
        Body.Point5_Template_miss[72] = 116;
        Body.Point5_Template_miss[73] = 118;
        Body.Point5_Template_miss[74] = 120;
        Body.Point5_Template_miss[75] = 122;
        Body.Point5_Template_miss[76] = 124;
        Body.Point5_Template_miss[77] = 126;
        Body.Point5_Template_miss[78] = 128;
        Body.Point5_Template_miss[79] = 130;
        Body.Point5_Template_miss[80] = 132;
        for (int i = 80; i < 200; ++i) {
            Body.Point5_Template_cooldown[i] = Point5_Template_cooldown[i - 1] + (Point5_Template_cooldown[i - 1] - Point5_Template_cooldown[i - 2]);
            Body.Point5_Template_miss[i] = Point5_Template_miss[i - 1] + (Point5_Template_miss[i - 1] - Point5_Template_miss[i - 2]);
        }
    }

    static {
        Body.load_point_1();
        Body.load_point_2();
        Body.load_point_3();
        Body.load_point_4();
        Body.load_point_5();
    }
}

