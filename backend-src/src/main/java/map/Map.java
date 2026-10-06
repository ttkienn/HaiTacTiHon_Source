package map;

import activities.Dungeon;
import activities.LittleGarden;
import activities.Pvp;
import activities.Trade;
import activities.Wanted;
import client.Buff;
import client.Clan;
import client.MapBossInfo;
import client.MyPet;
import client.Player;
import client.Quest;
import client.Wanted_Chest;
import core.BXH;
import core.Manager;
import core.MenuController;
import core.Service;
import core.Util;
import io.Message;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map.Entry;
import java.util.concurrent.CopyOnWriteArrayList;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.JSONValue;
import template.DataTemplate;
import template.EffTemplate;
import template.FriendTemp;
import template.GiftBox;
import template.ItemFashionP2;
import template.ItemMap;
import template.ItemTemplate3;
import template.ItemTemplate4;
import template.ItemTemplate7;
import template.Item_wear;
import template.Map_Little_Garden;
import template.Map_ThuThachVeThan;
import template.Map_clan_resource;
import template.Map_pvp;
import template.Option_Dame_Msg;
import template.Ship_pet;
import template.Skill_info;
import template.Top_Dame;

public class Map implements Runnable {
   public static List<Map[]> ENTRYS = new ArrayList<>();
   private static List<Map> MAP_PLUS = new ArrayList<>();
   public static byte weather = -1;
   public static byte weather_level = 1;
   public MapTemplate template;
   public Map_ThuThachVeThan map_ThuThachVeThan;
   private boolean running;
   public Thread mythread;
   public List<Player> players = new CopyOnWriteArrayList<>();
   public int[] list_mob;
   public byte zone_id;
   public Map_pvp map_pvp;
   public Dungeon map_dungeon;
   public Map_clan_resource clan_resource;
   public Map_Little_Garden map_little_garden;
   public ItemMap[] list_it_map = new ItemMap[1000];
   public boolean can_PK = true;

   public Map() {
      this.running = false;
      this.mythread = new Thread(this);
   }

   public static boolean is_map_boss(int id) {
      return id == 5
         || id == 13
         || id == 21
         || id == 29
         || id == 37
         || id == 45
         || id == 37
         || id == 45
         || id == 53
         || id == 73
         || id == 87
         || id == 102
         || id == 127
         || id == 198;
   }

   public static boolean is_map_dungeon(int id) {
      return id >= 167 && id <= 176;
   }

   public static void add_map_plus(Map map_boss) {
      synchronized (MAP_PLUS) {
         MAP_PLUS.add(map_boss);
      }
   }

   public static List<Map> get_map_plus() {
      return MAP_PLUS;
   }

   public static boolean isMapLang(int id) {
      for (int i = 0; i < MenuController.ID_MAP_LANG.length; i++) {
         if (id == MenuController.ID_MAP_LANG[i]) {
            return true;
         }
      }

      return false;
   }

   public void start_map() {
      this.mythread.start();
   }

   public void stop_map() {
      this.running = false;
      this.mythread.interrupt();
   }

   @Override
   public void run() {
      this.running = true;
      long time1 = 0L;
      long time2 = 0L;
      long time3 = 0L;

      while (this.running) {
         try {
            time1 = System.currentTimeMillis();
            this.update();
            time2 = System.currentTimeMillis();
            time3 = 1000L - (time2 - time1);
            if (time3 > 0L) {
               Thread.sleep(time3);
            }
         } catch (InterruptedException var8) {
         } catch (IOException var9) {
         } catch (Exception var10) {
            var10.printStackTrace();
            System.out.println("err map " + this.template.name + " " + this.zone_id);
         }
      }
   }

   private void update() throws IOException {
      this.update_mob();
      this.update_player();
      this.update_map_boss_hunt();
      this.update_item_map();
      this.update_map_dungeon();
      this.update_map_pvp();
      this.update_map_little_garden();
      this.update_map_ThuThachVeThan();
      this.update_map_Wanted();
   }

   private void update_map_boss_hunt() throws IOException {
      if (this.players.size() == 1) {
         Player p = this.players.get(0);
         MapBossInfo bossInfo = p.map_boss_info;
         if (bossInfo != null && bossInfo.exitAt > 0L && bossInfo.exitAt <= System.currentTimeMillis()) {
            Vgo vgo = new Vgo();
            vgo.map_go = new Map[]{bossInfo.returnMap};
            vgo.xnew = bossInfo.returnX;
            vgo.ynew = bossInfo.returnY;
            p.goto_map(vgo);
         }
      }
   }

   private void update_map_Wanted() throws IOException {
      if (this.template.id == 119) {
         Player[] p0 = Wanted.get_p_random_waiting();
         if (p0 != null && p0[0] != null && p0[1] != null) {
            p0[0].map.leave_map(p0[0], 2);
            p0[1].map.leave_map(p0[1], 2);
            p0[0].type_pk = -1;
            p0[1].type_pk = -1;
            short[] mapID = new short[]{120, 122, 123};
            Map maptemp = get_map_by_id(mapID[Util.random(mapID.length)])[0];
            Map map_create = new Map();
            map_create.template = maptemp.template;
            map_create.zone_id = 0;
            map_create.list_mob = new int[0];
            p0[0].map = map_create;
            p0[0].x = 320;
            p0[0].y = 240;
            p0[0].xold = p0[0].x;
            p0[0].yold = p0[0].y;
            p0[0].map.goto_map(p0[0]);
            Service.update_PK(p0[0], p0[0], true);
            Service.pet(p0[0], p0[0], true);
            Quest.update_map_have_side_quest(p0[0], true);
            p0[1].map = map_create;
            p0[1].x = 380;
            p0[1].y = 240;
            p0[1].xold = p0[1].x;
            p0[1].yold = p0[1].y;
            p0[1].map.goto_map(p0[1]);
            Service.update_PK(p0[1], p0[1], true);
            Service.pet(p0[1], p0[1], true);
            Quest.update_map_have_side_quest(p0[1], true);
            map_create.map_pvp = new Map_pvp();
            map_create.map_pvp.time_pvp = 5;
            map_create.map_pvp.status_pvp = 0;
            map_create.map_pvp.num_win_p1 = 0;
            map_create.map_pvp.num_win_p2 = 0;
            map_create.map_pvp.type_map = 2;
            map_create.start_map();
            add_map_plus(map_create);
         }
      }
   }

   private void update_map_ThuThachVeThan() throws IOException {
      if (this.map_ThuThachVeThan != null
         && this.map_ThuThachVeThan.time_state < System.currentTimeMillis()
         && (this.map_ThuThachVeThan.isFinish || this.players.size() != 2)) {
         Vgo vgo = new Vgo();
         vgo.map_go = get_map_by_id(189);
         vgo.xnew = 380;
         vgo.ynew = 260;
         List<Player> playerList = new ArrayList<>();

         for (int i = 0; i < this.players.size(); i++) {
            playerList.add(this.players.get(i));
         }

         playerList.forEach(l -> {
            try {
               l.key_red_line.clear();
               if (this.map_ThuThachVeThan.isReceiv) {
                  l.update_skill_exp(5000, 50L);
                  boolean receiv_material = true;
                  if (l.time_ttvt < 50) {
                     l.time_ttvt++;
                     Skill_info sk_select = null;

                     for (int ixx = 0; ixx < l.skill_point.size(); ixx++) {
                        if (l.skill_point.get(ixx).temp.indexSkillInServer >= 661 && l.skill_point.get(ixx).temp.indexSkillInServer <= 666) {
                           sk_select = l.skill_point.get(ixx);
                           break;
                        }
                     }

                     if (sk_select == null) {
                        l.update_key_boss(1);
                        l.update_money();
                        Service.CountDown_Ticket(l);
                        receiv_material = false;
                     }
                  }

                  int num1 = Util.random(20, 50);
                  int num2 = Util.random(20, 50);
                  int num3 = Util.random(2, 7);
                  int ix = 0;

                  while (true) {
                     if (ix < l.skill_point.size()) {
                        if (l.skill_point.get(ix).temp.indexSkillInServer < 661 || l.skill_point.get(ix).temp.indexSkillInServer > 666) {
                           ix++;
                           continue;
                        }

                        int percent = (l.skill_point.get(ix).temp.indexSkillInServer - 661) * 50;
                        num1 = num1 * (100 + percent) / 100;
                        num2 = num2 * (100 + percent) / 100;
                        num3 = num3 * (100 + percent) / 100;
                     }

                     if (receiv_material) {
                        num1 *= 2;
                        num2 *= 2;
                        num3 *= 2;
                        l.item.add_item_bag47(4, 451, num1);
                        l.item.add_item_bag47(4, 454, num2);
                        l.item.add_item_bag47(7, 13, num3);
                        l.item.update_Inventory(-1, false);
                     }
                     break;
                  }
               }

               l.goto_map(vgo);
            } catch (IOException var9) {
               var9.printStackTrace();
            }
         });
         this.running = false;
         this.map_ThuThachVeThan = null;
      }
   }

   private void update_map_little_garden() {
      if (this.map_little_garden != null) {
         for (int i = 0; i < this.map_little_garden.mobs.size(); i++) {
            Mob mob = this.map_little_garden.mobs.get(i);
            if (mob != null && mob.isdie && mob.time_refresh < System.currentTimeMillis()) {
               mob.isdie = false;
               mob.hp = mob.hp_max;
               mob.id_target = -1;

               try {
                  Message m_local = new Message(1);
                  m_local.writer().writeByte(1);
                  m_local.writer().writeShort(mob.index);
                  m_local.writer().writeShort(mob.x);
                  m_local.writer().writeShort(mob.y);
                  this.send_msg_all_p(m_local, null, true);
                  m_local.cleanup();
               } catch (IOException var12) {
                  var12.printStackTrace();
               }
            }
         }

         if (this.map_little_garden.is_finish || this.map_little_garden.time < System.currentTimeMillis()) {
            int xp_receiv1 = 400;
            int xp_receiv2 = 400;
            int rb_receiv1 = 150;
            int rb_receiv2 = 150;
            if (this.map_little_garden.hp_1 <= 0) {
               xp_receiv2 = 1000;
               xp_receiv1 = 300;
               rb_receiv2 = 200;
               rb_receiv1 = 100;
            } else if (this.map_little_garden.hp_2 <= 0) {
               xp_receiv1 = 1000;
               xp_receiv2 = 300;
               rb_receiv1 = 200;
               rb_receiv2 = 100;
            }

            this.map_little_garden.clan1.update_xp(xp_receiv1);
            this.map_little_garden.clan1.update_ruby(rb_receiv1);

            for (int i1 = 0; i1 < this.map_little_garden.clan1.members.size(); i1++) {
               Player p0 = get_player_by_name_allmap(this.map_little_garden.clan1.members.get(i1).name);
               if (p0 != null) {
                  try {
                     Clan.set_data(p0, false);
                     Clan.send_money(p0, false);
                  } catch (IOException var11) {
                     var11.printStackTrace();
                  }
               }
            }

            try {
               this.map_little_garden
                  .clan1
                  .chat_on_board(
                     this.map_little_garden.clan1.members.get(0).id,
                     this.map_little_garden.clan1.members.get(0).name,
                     "Phó bản khổng lồ với: " + this.map_little_garden.clan2.name + ": nhận được " + xp_receiv1 + " xp băng và " + rb_receiv1 + " ruby băng",
                     -3
                  );
            } catch (IOException var10) {
               var10.printStackTrace();
            }

            this.map_little_garden.clan2.update_xp(xp_receiv2);
            this.map_little_garden.clan2.update_ruby(rb_receiv2);

            for (int i1x = 0; i1x < this.map_little_garden.clan2.members.size(); i1x++) {
               Player p0 = get_player_by_name_allmap(this.map_little_garden.clan2.members.get(i1x).name);
               if (p0 != null) {
                  try {
                     Clan.set_data(p0, false);
                     Clan.send_money(p0, false);
                  } catch (IOException var9) {
                     var9.printStackTrace();
                  }
               }
            }

            try {
               this.map_little_garden
                  .clan2
                  .chat_on_board(
                     this.map_little_garden.clan2.members.get(0).id,
                     this.map_little_garden.clan2.members.get(0).name,
                     "Phó bản khổng lồ với: " + this.map_little_garden.clan1.name + ": nhận được " + xp_receiv2 + " xp băng và " + rb_receiv2 + " ruby băng",
                     -3
                  );
            } catch (IOException var8) {
               var8.printStackTrace();
            }

            this.map_little_garden.clan1.map_create = null;
            this.map_little_garden.clan2.map_create = null;
            Vgo vgo = new Vgo();
            vgo.map_go = get_map_by_id(33);
            vgo.xnew = 710;
            vgo.ynew = 320;
            List<Player> playerList = new ArrayList<>();

            for (int ix = 0; ix < this.players.size(); ix++) {
               playerList.add(this.players.get(ix));
            }

            playerList.forEach(l -> {
               try {
                  l.goto_map(vgo);
               } catch (IOException var3x) {
                  var3x.printStackTrace();
               }
            });
            this.running = false;
         }
      }
   }

   private void update_map_pvp() throws IOException {
      try {
         if (this.template.id == 1000) {
            List<Player> list_pvp_wait = new ArrayList<>();

            for (int i = 0; i < this.players.size(); i++) {
               Player p0 = this.players.get(i);
               if (p0.pvp_target != null && p0.pvp_target.equals(p0)) {
                  list_pvp_wait.add(p0);
               }
            }

            while (list_pvp_wait.size() > 1) {
               Player p_select = list_pvp_wait.get(0);
               Player p_select_2 = null;
               list_pvp_wait.remove(0);
               if (p_select.pvp_target != null) {
                  for (int ix = 0; ix < list_pvp_wait.size(); ix++) {
                     if (list_pvp_wait.get(ix).pvp_target != null && !list_pvp_wait.get(ix).pvp_target.equals(p_select)) {
                        p_select_2 = list_pvp_wait.get(ix);
                        list_pvp_wait.remove(ix);
                        break;
                     }
                  }
               }

               if (p_select_2 != null) {
                  p_select.pvp_target = p_select_2;
                  p_select_2.pvp_target = p_select;
                  if (!p_select.equals(p_select_2)) {
                     Pvp.find_out_other(p_select, p_select_2);
                     Pvp.find_out_other(p_select_2, p_select);
                  }
               }
            }
         }
      } catch (Exception var7) {
         var7.printStackTrace();
         System.err.println("err map wait pvp");
      }

      if (this.map_pvp != null) {
         this.map_pvp.time_pvp--;
         if (this.map_pvp.status_pvp == 0 && this.map_pvp.time_pvp <= 0) {
            for (int ixx = 0; ixx < this.players.size(); ixx++) {
               Pvp.pvp_notice(this.players.get(ixx), 0);
            }

            this.map_pvp.time_pvp = 5;
            this.map_pvp.status_pvp = 1;
         } else if (this.map_pvp.status_pvp == 1 && this.map_pvp.time_pvp <= 0) {
            for (int ixx = 0; ixx < this.players.size(); ixx++) {
               Pvp.pvp_notice(this.players.get(ixx), 1);
               Service.use_potion(this.players.get(ixx), 0, this.players.get(ixx).body.get_hp_max(true));
               Service.use_potion(this.players.get(ixx), 1, this.players.get(ixx).body.get_mp_max(true));
            }

            this.map_pvp.time_pvp = 4;
            this.map_pvp.status_pvp = 2;
         } else if (this.map_pvp.status_pvp == 2 && this.map_pvp.time_pvp <= 0) {
            for (int ixx = 0; ixx < this.players.size(); ixx++) {
               Pvp.pvp_notice(this.players.get(ixx), 2);
               Pvp.show_info(this.players.get(ixx), 180, 0, 0, 3);
               this.change_flag(this.players.get(ixx), ixx == 0 ? 14 : 15);
            }

            this.map_pvp.time_pvp = 180;
            this.map_pvp.status_pvp = 3;
         }

         if (this.map_pvp.status_pvp == 3 && this.players.size() == 2) {
            for (int ixx = 0; ixx < this.players.size(); ixx++) {
               if (this.players.get(ixx).isdie) {
                  this.map_pvp.status_pvp = 91;
                  break;
               }
            }
         } else if (this.map_pvp.status_pvp == 91 && this.players.size() == 2) {
            this.map_pvp.status_pvp = 90;
         } else if (this.map_pvp.status_pvp == 90 && this.players.size() == 2) {
            for (int ixxx = 0; ixxx < this.players.size(); ixxx++) {
               if (this.map_pvp.num_win_p1 == 3 || this.map_pvp.num_win_p2 == 3) {
                  this.change_flag(this.players.get(ixxx), -1);
               }

               this.players.get(ixxx).isdie = false;
               Service.use_potion(this.players.get(ixxx), 0, this.players.get(ixxx).body.get_hp_max(true));
               Service.use_potion(this.players.get(ixxx), 1, this.players.get(ixxx).body.get_mp_max(true));
            }

            this.map_pvp.status_pvp = 3;
         } else if (this.map_pvp.status_pvp == 90) {
            this.map_pvp.status_pvp = 3;
         }

         if (this.map_pvp.status_pvp == 3 && (this.map_pvp.num_win_p1 == 3 || this.map_pvp.num_win_p2 == 3)) {
            this.map_pvp.status_pvp = 4;
            this.map_pvp.time_pvp = 4;

            try {
               if (this.map_pvp.type_map == 0) {
                  if (this.map_pvp.num_win_p1 == 3) {
                     Pvp.pvp_notice(this.players.get(0), 3);
                     Pvp.pvp_notice(this.players.get(1), 4);
                     this.players.get(0).pvp_win++;
                     this.players.get(1).pvp_lose++;
                     int chenhLech = this.players.get(1).get_pvpPoint() - this.players.get(0).get_pvpPoint();
                     if (chenhLech > 15) {
                        chenhLech = 15;
                     } else if (chenhLech < -15) {
                        chenhLech = -15;
                     }

                     chenhLech += 30;
                     this.players.get(0).update_pvpPoint(chenhLech);
                     this.players.get(1).update_pvpPoint(-chenhLech);
                  } else {
                     Pvp.pvp_notice(this.players.get(1), 3);
                     Pvp.pvp_notice(this.players.get(0), 4);
                     this.players.get(1).pvp_win++;
                     this.players.get(0).pvp_lose++;
                     int chenhLech = this.players.get(0).get_pvpPoint() - this.players.get(1).get_pvpPoint();
                     if (chenhLech > 15) {
                        chenhLech = 15;
                     } else if (chenhLech < -15) {
                        chenhLech = -15;
                     }

                     chenhLech += 30;
                     this.players.get(1).update_pvpPoint(chenhLech);
                     this.players.get(0).update_pvpPoint(-chenhLech);
                  }
               } else if (this.map_pvp.type_map == 2) {
                  if (this.map_pvp.num_win_p1 == 3) {
                     Pvp.pvp_notice(this.players.get(0), 3);
                     Pvp.pvp_notice(this.players.get(1), 4);
                     long beri_win = (10000L + this.players.get(1).get_wanted_point()) / 100L;
                     long beri_lose = (5000L + this.players.get(1).get_wanted_point()) / 100L;
                     this.players.get(0).update_wanted_point((int)beri_win);
                     this.players.get(1).update_wanted_point((int)(-beri_lose));
                     Wanted_Chest.receiv_ruong(this.players.get(0));
                  } else {
                     Pvp.pvp_notice(this.players.get(1), 3);
                     Pvp.pvp_notice(this.players.get(0), 4);
                     long beri_win = (10000L + this.players.get(0).get_wanted_point()) / 100L;
                     long beri_lose = (5000L + this.players.get(0).get_wanted_point()) / 100L;
                     this.players.get(1).update_wanted_point((int)beri_win);
                     this.players.get(0).update_wanted_point((int)(-beri_lose));
                     Wanted_Chest.receiv_ruong(this.players.get(1));
                  }
               }
            } catch (IndexOutOfBoundsException var6) {
               this.map_pvp.status_pvp = 3;
            }

            for (int ixxx = 0; ixxx < this.players.size(); ixxx++) {
               this.change_flag(this.players.get(ixxx), -1);
            }
         }

         if (this.map_pvp.status_pvp == 3 && this.players.size() < 2) {
            this.map_pvp.status_pvp = 4;
            this.map_pvp.time_pvp = 4;

            for (int ixxx = 0; ixxx < this.players.size(); ixxx++) {
               Pvp.pvp_notice(this.players.get(ixxx), 3);
               Pvp.show_info(this.players.get(ixxx), 4, 3, 0, 3);
               this.change_flag(this.players.get(ixxx), -1);
               if (this.map_pvp.type_map == 0) {
                  this.players.get(ixxx).update_pvpPoint(20);
               }
            }
         } else if (this.map_pvp.status_pvp == 3 && this.map_pvp.time_pvp <= 0) {
            try {
               if (this.map_pvp.type_map == 0) {
                  Player p1 = this.players.get(0);
                  Player p2 = this.players.get(1);
                  if (p1 != null && p2 != null && !p1.equals(p2)) {
                     if (this.map_pvp.num_win_p1 > this.map_pvp.num_win_p2) {
                        p1.pvp_win++;
                        p1.update_pvpPoint(15);
                        p2.pvp_lose++;
                        p2.update_pvpPoint(-15);
                     } else if (this.map_pvp.num_win_p1 < this.map_pvp.num_win_p2) {
                        p1.pvp_lose++;
                        p1.update_pvpPoint(-15);
                        p2.pvp_win++;
                        p2.update_pvpPoint(15);
                     }
                  }
               }
            } catch (Exception var5) {
            }

            this.map_pvp.status_pvp = 4;
            this.map_pvp.time_pvp = 4;

            for (int ixxxx = 0; ixxxx < this.players.size(); ixxxx++) {
               if (this.map_pvp.type_map == 0) {
                  Service.send_box_ThongBao_OK(this.players.get(ixxxx), "Hết thời gian, kết quả hòa, bạn sẽ được đưa về map chờ");
               } else {
                  Service.send_box_ThongBao_OK(this.players.get(ixxxx), "Đối thủ xứng tầm không thể phân biệt thắng thua");
               }
            }
         } else if (this.map_pvp.status_pvp == 4 && this.map_pvp.time_pvp <= 0) {
            Vgo vgo = new Vgo();
            if (this.map_pvp.type_map == 0) {
               vgo.map_go = get_map_by_id(1000);
            } else if (this.map_pvp.type_map == 2) {
               vgo.map_go = get_map_by_id(119);
            } else {
               vgo.map_go = get_map_by_id(1);
            }

            vgo.xnew = (short)(vgo.map_go[0].template.maxW / 2);
            vgo.ynew = (short)(vgo.map_go[0].template.maxH / 2);
            List<Player> playerList = new ArrayList<>();

            for (int ixxxxx = 0; ixxxxx < this.players.size(); ixxxxx++) {
               playerList.add(this.players.get(ixxxxx));
            }

            playerList.forEach(l -> {
               try {
                  l.targetFight = null;
                  this.change_flag(l, -1);
                  l.goto_map(vgo);
               } catch (IOException var4x) {
                  var4x.printStackTrace();
               }
            });
            this.map_pvp.status_pvp = 99;
         } else if (this.map_pvp.status_pvp == 99) {
            this.running = false;
            this.map_pvp = null;
         }
      }
   }

   private void update_map_dungeon() throws IOException {
      if (is_map_dungeon(this.template.id)) {
         Player p_select = null;
         boolean ok_out_map = false;
         if (this.players.size() > 0) {
            Player p0 = this.players.get(0);
            int num_mob = 0;

            for (int i = 0; i < p0.dungeon.mobs.size(); i++) {
               if (p0.dungeon.mobs.get(i).map.equals(this)) {
                  num_mob++;
               }
            }

            if (num_mob == 0 && p0.dungeon.time > System.currentTimeMillis()) {
               if (this.template.id == 175) {
                  p0.dungeon.time = System.currentTimeMillis() + 10000L;
                  Service.send_time_cool_down(p0, p0.dungeon.time, "Thời gian", 2);
               }

               if (!this.map_dungeon.checkG.contains(this.template.id)) {
                  this.map_dungeon.checkG.add(this.template.id);
                  byte mode_dungeon = p0.dungeon.mode;
                  List<GiftBox> list_gift = new ArrayList<>();
                  int beri_receiv = Util.random(4000, 8000) * (mode_dungeon + 1);
                  if (mode_dungeon == 11 && 25 > Util.random(150)) {
                     GiftBox gb_beri = new GiftBox();
                     ItemTemplate4 it_temp4 = ItemTemplate4.get_it_by_id(0);
                     if (it_temp4 != null) {
                        gb_beri.id = it_temp4.id;
                        gb_beri.type = 4;
                        gb_beri.name = it_temp4.name;
                        gb_beri.icon = it_temp4.icon;
                        gb_beri.num = beri_receiv * 2;
                        gb_beri.color = 0;
                        list_gift.add(gb_beri);
                     }

                     GiftBox gb_beri2 = new GiftBox();
                     it_temp4 = ItemTemplate4.get_it_by_id(366);
                     if (it_temp4 != null) {
                        gb_beri2.id = it_temp4.id;
                        gb_beri2.type = 4;
                        gb_beri2.name = it_temp4.name;
                        gb_beri2.icon = it_temp4.icon;
                        gb_beri2.num = 1;
                        gb_beri2.color = 0;
                        list_gift.add(gb_beri2);
                     }
                  } else {
                     GiftBox gb_berix = new GiftBox();
                     ItemTemplate4 it_temp4x = ItemTemplate4.get_it_by_id(0);
                     if (it_temp4x != null) {
                        gb_berix.id = it_temp4x.id;
                        gb_berix.type = 4;
                        gb_berix.name = it_temp4x.name;
                        gb_berix.icon = it_temp4x.icon;
                        gb_berix.num = beri_receiv;
                        gb_berix.color = 0;
                        list_gift.add(gb_berix);
                     }
                  }

                  GiftBox gb_botvang = new GiftBox();
                  ItemTemplate7 it_temp7 = ItemTemplate7.get_it_by_id(4);
                  if (it_temp7 != null) {
                     gb_botvang.id = it_temp7.id;
                     gb_botvang.type = 7;
                     gb_botvang.name = it_temp7.name;
                     gb_botvang.icon = it_temp7.icon;
                     gb_botvang.num = Util.random(1, mode_dungeon + 2);
                     gb_botvang.color = 0;
                     list_gift.add(gb_botvang);
                  }

                  if (15 > Util.random(300 - mode_dungeon * 10)) {
                     GiftBox gb_ = new GiftBox();
                     ItemTemplate4 var17 = ItemTemplate4.get_it_by_id(45 > Util.random(120) ? (15 > Util.random(120) ? 364 : 363) : 362);
                     if (var17 != null) {
                        gb_.id = var17.id;
                        gb_.type = 4;
                        gb_.name = var17.name;
                        gb_.icon = var17.icon;
                        gb_.num = Util.random(1, 3);
                        gb_.color = 0;
                        list_gift.add(gb_);
                     }
                  }

                  if (80 > Util.random(150 - mode_dungeon * 10)) {
                     GiftBox gb_ = new GiftBox();
                     ItemTemplate4 var18 = ItemTemplate4.get_it_by_id(18 + p0.level / 10);
                     if (var18 != null) {
                        gb_.id = var18.id;
                        gb_.type = 4;
                        gb_.name = var18.name;
                        gb_.icon = var18.icon;
                        int num = Util.random(1, mode_dungeon + 2);
                        gb_.num = num < 2 ? num : num / 2;
                        gb_.color = 0;
                        list_gift.add(gb_);
                     }
                  }

                  Service.send_gift(p0, 1, "Ải đơn cấp độ " + (mode_dungeon + 3), "Phần thưởng", list_gift, true);
               }
            }

            if (p0.dungeon.time < System.currentTimeMillis()) {
               ok_out_map = true;
               p_select = p0;
            }
         }

         if (ok_out_map && p_select != null && p_select.conn != null) {
            Vgo vgo = new Vgo();
            vgo.map_go = get_map_by_id(25);
            vgo.xnew = 390;
            vgo.ynew = 240;
            p_select.goto_map(vgo);
            p_select.dungeon = null;
         }

         if (this.map_dungeon == null || this.players.size() == 0 && this.map_dungeon.time < System.currentTimeMillis()) {
            this.running = false;
         }
      }
   }

   private void update_item_map() throws IOException {
      for (int i = 0; i < this.list_it_map.length; i++) {
         ItemMap it = this.list_it_map[i];
         if (it != null && it.time_exist < System.currentTimeMillis()) {
            this.remove_obj(it.index, it.category);
            this.list_it_map[i] = null;
         }

         if (it != null && it.time_exist - 10000L < System.currentTimeMillis()) {
            it.id_master = -1;
         }
      }
   }

   public void remove_obj(int index, int category) throws IOException {
      Message m = new Message(13);
      m.writer().writeShort(index);
      m.writer().writeByte(category);
      this.send_msg_all_p(m, null, true);
      m.cleanup();
   }

   private synchronized void update_player() throws IOException {
      List<Player> list_remove = new ArrayList<>();

      for (int i = 0; i < this.players.size(); i++) {
         Player p0 = this.players.get(i);
         if (p0.conn == null) {
            list_remove.add(p0);
         } else {
            int hp_buff = 0;
            int mp_buff = 0;
            if (p0.mp < 0) {
               p0.mp = 0;
            }

            EffTemplate eff = p0.get_eff(0);
            if (!p0.isdie && eff != null) {
               hp_buff = eff.param;
               if (p0.clan != null) {
                  int buff_percent = 100;
                  if (p0.clan.check_buff(2)) {
                     buff_percent += 25;
                  }

                  if (p0.clan.check_buff(4)) {
                     buff_percent += 25;
                  }

                  hp_buff = hp_buff * buff_percent / 100;
               }
            }

            eff = p0.get_eff(1);
            if (!p0.isdie && eff != null) {
               mp_buff = eff.param;
               if (p0.clan != null) {
                  int buff_percentx = 100;
                  if (p0.clan.check_buff(2)) {
                     buff_percentx += 25;
                  }

                  if (p0.clan.check_buff(4)) {
                     buff_percentx += 25;
                  }

                  mp_buff = mp_buff * buff_percentx / 100;
               }
            }

            if (p0.time_buff_hp_mp < System.currentTimeMillis()) {
               p0.time_buff_hp_mp = System.currentTimeMillis() + 5000L;
               hp_buff += p0.body.get_hp_auto_buff(true);
               mp_buff += p0.body.get_mp_auto_buff(true);
            }

            int hp_max = p0.body.get_hp_max(true);
            if (!p0.isdie && p0.hp < hp_max && hp_buff > 0 && p0.get_eff(202) == null) {
               Service.use_potion(p0, 0, hp_buff);
            }

            if (!p0.isdie && p0.mp < p0.body.get_mp_max(true) && mp_buff > 0) {
               Service.use_potion(p0, 1, mp_buff);
            }

            if (p0.get_eff(207) != null) {
               int hp_decrease = hp_max / 100;
               if (p0.hp - hp_decrease > 0) {
                  Service.use_potion(p0, 0, -hp_decrease);
               }
            }

            if (p0.ship_pet != null && p0.ship_pet.time_buff_hp < System.currentTimeMillis() && isMapLang(this.template.id)) {
               p0.ship_pet.time_buff_hp = System.currentTimeMillis() + 2000L;
               if (p0.ship_pet.hp < p0.ship_pet.hp_max) {
                  p0.ship_pet.hp += 40;
                  if (p0.ship_pet.hp > p0.ship_pet.hp_max) {
                     p0.ship_pet.hp = p0.ship_pet.hp_max;
                  }

                  Message m = new Message(-83);
                  m.writer().writeShort(p0.ship_pet.index_map);
                  m.writer().writeByte(0);
                  m.writer().writeInt(p0.ship_pet.hp_max);
                  m.writer().writeInt(p0.ship_pet.hp);
                  m.writer().writeInt(50);
                  m.writer().writeInt(p0.ship_pet.hp_max);
                  m.writer().writeInt(0);
                  m.writer().writeInt(0);
                  this.send_msg_all_p(m, null, true);
                  m.cleanup();
               }
            }

            boolean ch = false;
            if (p0.get_ticket() < p0.get_ticket_max() && p0.cd_ticket_next < System.currentTimeMillis()) {
               p0.cd_ticket_next = System.currentTimeMillis() + 600000L;
               p0.update_ticket(1);
               ch = true;
            }

            if (p0.get_pvp_ticket() < p0.get_pvp_ticket_max() && p0.cd_pvp_next < System.currentTimeMillis()) {
               p0.cd_pvp_next = System.currentTimeMillis() + 7200000L;
               p0.update_pvp_ticket(1);
               ch = true;
            }

            if (p0.get_key_boss() < p0.get_key_boss_max() && p0.cd_keyboss_next < System.currentTimeMillis()) {
               p0.cd_keyboss_next = System.currentTimeMillis() + 3600000L;
               p0.update_key_boss(1);
               ch = true;
            }

            if (ch) {
               p0.update_money();
               Service.CountDown_Ticket(p0);
            }

            if (p0.is_combo != null && p0.time_combo < System.currentTimeMillis()) {
               p0.is_combo = null;
               Service.start_combo(p0, 0);
            }

            if (this.template.id == 81 && this.map_little_garden != null && p0.isdie && p0.time_hs_little_garden <= System.currentTimeMillis()) {
               p0.isdie = false;
               Service.use_potion(p0, 0, p0.body.get_hp_max(true));
               Service.use_potion(p0, 1, p0.body.get_mp_max(true));
            }

            if (!isMapLang(this.template.id) && p0.get_eff(14) != null) {
               try {
                  Player p_target = null;

                  while (this.players.size() > 1 && (p_target == null || p_target.equals(p0))) {
                     p_target = this.players.get(Util.random(this.players.size()));
                  }

                  if (p_target != null && !p_target.equals(p0)) {
                     if (p0.typePirate == 0 && p_target.typePirate == 2
                        || p0.typePirate == 2 && p_target.typePirate == 0
                        || p0.typePirate == 1 && p_target.typePirate == 2
                        || p0.typePirate == 2 && p_target.typePirate == 1
                        || p0.type_pk == 14 && p_target.type_pk == 15
                        || p0.type_pk == 15 && p_target.type_pk == 14
                        || p0.typePirate == 2 && p_target.typePirate == 2
                        || p0.type_pk == 0
                        || p_target.type_pk == 1
                        || p0.type_pk == 3 && p_target.type_pk == 3
                        || p_target.type_pk == 0
                        || p0.type_pk == 3 && p_target.type_pk >= 4 && p_target.type_pk <= 8
                        || p_target.type_pk == 3 && p0.type_pk >= 4 && p0.type_pk <= 8
                        || p0.type_pk >= 4 && p0.type_pk <= 8 && p_target.type_pk >= 4 && p_target.type_pk <= 8 && p0.type_pk != p_target.type_pk) {
                        Message m = new Message(-15);
                        m.writer().writeByte(3);
                        m.writer().writeShort(p_target.index_map);
                        m.writer().writeByte(0);
                        m.writer().writeShort(0);
                        this.send_msg_all_p(m, p0, true);
                        m.cleanup();
                        int dame_to_target = p0.body.get_dame(true);
                        dame_to_target = dame_to_target * (100 - Util.random(10)) / 100;
                        if (p_target.hp - dame_to_target > 0) {
                           p_target.hp -= dame_to_target;
                        } else {
                           p_target.hp = 1;
                        }

                        m = new Message(28);
                        m.writer().writeShort(p_target.index_map);
                        m.writer().writeByte(0);
                        m.writer().writeInt(p_target.hp);
                        m.writer().writeInt(p_target.body.get_hp_max(true));
                        m.writer().writeShort(-1);
                        m.writer().writeShort(-1);
                        this.send_msg_all_p(m, p0, true);
                        m.cleanup();
                     }
                  } else {
                     List<Mob> list_random = new ArrayList<>();

                     for (int i11 = 0; i11 < this.list_mob.length; i11++) {
                        Mob mob = Mob.ENTRYS.get(this.list_mob[i11]);
                        if (mob != null && !mob.isdie && Math.abs(p0.x - mob.x) < 200 && Math.abs(p0.y - mob.y) < 200) {
                           list_random.add(mob);
                        }
                     }

                     if (list_random.size() > 0) {
                        Mob mob_select = list_random.get(Util.random(list_random.size()));
                        Message m = new Message(-15);
                        m.writer().writeByte(3);
                        m.writer().writeShort(mob_select.index);
                        m.writer().writeByte(1);
                        m.writer().writeShort(0);
                        this.send_msg_all_p(m, p0, true);
                        m.cleanup();
                        int dame_to_target = p0.body.get_dame(true);
                        dame_to_target = dame_to_target * (100 - Util.random(10)) / 100;
                        if (mob_select.hp - dame_to_target > 0) {
                           mob_select.hp -= dame_to_target;
                        } else {
                           mob_select.hp = 1;
                        }

                        m = new Message(28);
                        m.writer().writeShort(mob_select.index);
                        m.writer().writeByte(1);
                        m.writer().writeInt(mob_select.hp);
                        m.writer().writeInt(mob_select.hp_max);
                        m.writer().writeShort(-1);
                        m.writer().writeShort(-1);
                        this.send_msg_all_p(m, p0, true);
                        m.cleanup();
                     }
                  }
               } catch (Exception var14) {
                  var14.printStackTrace();
               }
            }
         }
      }

      this.players.removeAll(list_remove);

      for (int ix = 0; ix < list_remove.size(); ix++) {
         Player p0 = list_remove.get(ix);
         Message m = new Message(3);
         m.writer().writeShort(p0.index_map);
         m.writer().writeByte(0);
         this.send_msg_all_p(m, null, true);
         m.cleanup();
      }

      list_remove.clear();
   }

   private void update_mob() {
      if (this.can_PK) {
         for (int i = 0; i < this.list_mob.length; i++) {
            Mob mob = Mob.ENTRYS.get(this.list_mob[i]);
            if (mob != null) {
               if (!mob.isdie) {
                  if (mob.id_target != -1) {
                     try {
                        this.mob_fire(mob, mob.id_target);
                     } catch (IOException var11) {
                        var11.printStackTrace();
                     }
                  }
               } else if (mob.hp == 0 && mob.time_refresh < System.currentTimeMillis()) {
                  mob.isdie = false;
                  mob.hp = mob.hp_max;
                  mob.id_target = -1;

                  try {
                     Message m_local = new Message(1);
                     m_local.writer().writeByte(1);
                     m_local.writer().writeShort(mob.index);
                     m_local.writer().writeShort(mob.x);
                     m_local.writer().writeShort(mob.y);
                     this.send_msg_all_p(m_local, null, true);
                     m_local.cleanup();
                  } catch (IOException var10) {
                     var10.printStackTrace();
                  }
               }
            }
         }
      }

      for (int ix = 0; ix < Boss.ENTRYS.size(); ix++) {
         Boss boss = Boss.ENTRYS.get(ix);
         Mob mob = boss.mob;
         if (mob.map.equals(this) && !mob.isdie && mob.id_target != -1) {
            try {
               this.mob_fire(mob, mob.id_target);
            } catch (IOException var9) {
               var9.printStackTrace();
            }
         }
      }

      if (is_map_boss(this.template.id)) {
         List<Mob> get_list_Mob = MapBossInfo.get_list_mob(this);
         if (get_list_Mob != null) {
            for (int ixx = 0; ixx < get_list_Mob.size(); ixx++) {
               Mob mob = get_list_Mob.get(ixx);
               if (!mob.isdie && mob.id_target != -1) {
                  try {
                     this.mob_fire(mob, mob.id_target);
                  } catch (IOException var8) {
                     var8.printStackTrace();
                  }
               }
            }
         }
      }

      if (is_map_dungeon(this.template.id)) {
         List<Mob> list_remove = new ArrayList<>();
         List<Mob> get_list_Mob = new ArrayList<>();
         if (this.players.size() > 0) {
            for (int ixxx = 0; ixxx < this.players.get(0).dungeon.mobs.size(); ixxx++) {
               if (this.players.get(0).dungeon.mobs.get(ixxx).map.equals(this)) {
                  get_list_Mob.add(this.players.get(0).dungeon.mobs.get(ixxx));
               }
            }
         }

         for (int ixxxx = 0; ixxxx < get_list_Mob.size(); ixxxx++) {
            Mob mob = get_list_Mob.get(ixxxx);
            if (mob.isdie && mob.time_refresh - 3500L < System.currentTimeMillis()) {
               list_remove.add(mob);
            }
         }

         for (int ixxxxx = 0; ixxxxx < list_remove.size(); ixxxxx++) {
            try {
               this.remove_obj(list_remove.get(ixxxxx).index, 1);
            } catch (IOException var7) {
               var7.printStackTrace();
            }
         }

         get_list_Mob.removeAll(list_remove);
         if (this.players.size() > 0) {
            this.players.get(0).dungeon.mobs.removeAll(list_remove);
         }

         for (int ixxxxx = 0; ixxxxx < get_list_Mob.size(); ixxxxx++) {
            Mob mob = get_list_Mob.get(ixxxxx);
            if (!mob.isdie && mob.id_target != -1) {
               try {
                  this.mob_fire(mob, mob.id_target);
               } catch (IOException var6) {
                  var6.printStackTrace();
               }
            }
         }
      }
   }

   private synchronized void mob_fire(Mob mob, int id_target) throws IOException {
      if (!mob.isdie && mob.time_skill < System.currentTimeMillis()) {
         mob.time_skill = System.currentTimeMillis() + 1800L;
         Player p0 = this.get_player_by_id_inmap(id_target);
         if (p0 != null && !mob.isdie && !p0.wait_change_map && !p0.isdie && p0.time_can_mob_atk < System.currentTimeMillis()) {
            int dame = Util.random(mob.level * 2, mob.level * 5);
            if (mob.level > 30 && mob.level <= 50) {
               dame = dame * 15 / 10;
            } else if (mob.level > 50 && mob.level <= 70) {
               dame = dame * 18 / 10;
            } else if (mob.level > 70 && mob.level <= 90) {
               dame = dame * 21 / 10;
            } else if (mob.level > 90 && mob.level <= 600) {
               dame = dame * 25 / 10;
            }

            if (mob.level - p0.level >= 10) {
               dame *= 5;
            }

            if (dame <= 0) {
               dame = Util.random(10, 20);
            }

            if (p0.hp == p0.body.get_hp_max(true) && dame >= p0.hp) {
               p0.hp = 1;
            } else {
               p0.hp -= dame;
            }

            long def = p0.body.get_def(true);
            def = def * (1000L + p0.body.get_def_percent(true)) / 10000L;
            dame = (int)(dame - def);
            int get_miss = p0.body.get_miss(true) - p0.body.get_miss_reduce();
            boolean miss = p0.get_eff(205) != null || get_miss > Util.random(1000);
            if (miss) {
               dame = 0;
            }

            if (p0.hp <= 0) {
               p0.hp = 0;
               p0.isdie = true;
               mob.id_target = -1;
               this.mob_non_focus(mob);
            }

            long dame_mine = 0L;
            if (p0.body.get_dame_react(true) > Util.random(1000)) {
               dame_mine = dame;
            }

            if (dame_mine > 0L) {
               mob.hp = (int)(mob.hp - dame_mine);
               if (mob.hp <= 0) {
                  mob.hp = 1;
               }

               this.update_hp_mp_eff(null, mob, 1, (int)(-dame_mine));
            }

            Message m = new Message(100);
            m.writer().writeShort(mob.index);
            m.writer().writeByte(1);
            m.writer().writeInt(mob.hp);
            m.writer().writeInt(mob.hp);
            m.writer().writeShort(mob.mob_template.skill[Util.random(mob.mob_template.skill.length)]);
            m.writer().writeByte(1);
            m.writer().writeShort(id_target);
            m.writer().writeByte(0);
            m.writer().writeInt(dame);
            m.writer().writeInt(0);
            m.writer().writeInt(p0.hp);
            m.writer().writeByte(0);
            this.send_msg_all_p(m, p0, true);
            m.cleanup();
            if (p0.hp <= 0) {
               this.die_player(p0, p0);
            }

            if (mob.id_target != -1 && (Math.abs(mob.x - p0.x) >= 200 || Math.abs(mob.y - p0.y) >= 200)) {
               mob.id_target = -1;
               this.mob_non_focus(mob);
            }
         }
      }
   }

   private void mob_non_focus(Mob mob) throws IOException {
      Message m2 = new Message(5);
      m2.writer().writeShort(mob.index);
      this.send_msg_all_p(m2, null, true);
      m2.cleanup();
   }

   public void die_player(Player p0, Player p) throws IOException {
      p0.isdie = true;
      p0.update_die();
      Message m = new Message(7);
      m.writer().writeShort(p.index_map);
      m.writer().writeByte(0);
      m.writer().writeShort(p0.index_map);
      m.writer().writeByte(0);
      m.writer().writeShort(p.pointPk);
      this.send_msg_all_p(m, p0, true);
      m.cleanup();
      if (p0.is_combo != null) {
         p0.is_combo = null;
         Service.start_combo(p0, 0);
      }

      if (this.map_pvp != null && !p.equals(p0)) {
         if (this.players.indexOf(p0) == 0) {
            this.map_pvp.num_win_p2++;
            Pvp.show_info(p, this.map_pvp.time_pvp, this.map_pvp.num_win_p1, this.map_pvp.num_win_p2, 3);
            Pvp.show_info(p0, this.map_pvp.time_pvp, this.map_pvp.num_win_p2, this.map_pvp.num_win_p1, 3);
         } else {
            this.map_pvp.num_win_p1++;
            Pvp.show_info(p, this.map_pvp.time_pvp, this.map_pvp.num_win_p2, this.map_pvp.num_win_p1, 3);
            Pvp.show_info(p0, this.map_pvp.time_pvp, this.map_pvp.num_win_p1, this.map_pvp.num_win_p2, 3);
         }
      }
   }

   public void enter_map(Player p) {
      p.ensureRuntimeState();
      synchronized (this) {
         this.players.add(p);
      }
   }

   public void leave_map(Player p, int type) {
      synchronized (this) {
         this.players.remove(p);
      }

      p.is_combo = null;
      p.time_combo = 0L;
      if (p.id_meet_in_map != null) {
         p.id_meet_in_map.clear();
         p.id_meet_in_map.add(p.index_map + "");
      }

      if (p.map_boss_info != null && is_map_boss(this.template.id)) {
         MapBossInfo.remove(p.map_boss_info);
         p.map_boss_info = null;
         if (this.players.size() < 1) {
            this.stop_map();
         }
      }

      try {
         Message m = new Message(3);
         m.writer().writeShort(p.index_map);
         m.writer().writeByte(type);

         for (int i = 0; i < this.players.size(); i++) {
            Player p0 = this.players.get(i);
            if (p0 != null && p0.conn != null) {
               p0.conn.addmsg(m);
            }

            if (p0 != null && p0.id_meet_in_map != null) {
               p0.id_meet_in_map.remove(p.index_map + "");
            }
         }

         m.cleanup();
         if (p.ship_pet != null && p.ship_pet.map == null) {
            m = new Message(3);
            m.writer().writeShort(p.ship_pet.index_map);
            m.writer().writeByte(type);

            for (int i = 0; i < this.players.size(); i++) {
               Player p0x = this.players.get(i);
               if (p0x != null && p0x.conn != null) {
                  p0x.conn.addmsg(m);
               }
            }

            m.cleanup();
         }

         if (p.trade_target != null) {
            Trade.end_trade_by_disconnect(p.trade_target, p, 0, "");
            p.fee_trade = 0;
            p.money_trade = 0L;
            p.is_lock_trade = false;
            p.is_accept_trade = false;
            p.list_item_trade3 = null;
            p.list_item_trade47 = null;
            p.trade_target = null;
         }

         MyPet pet_select = p.get_pet();
         if (pet_select != null) {
            Message m22 = new Message(-80);
            m22.writer().writeByte(1);
            m22.writer().writeShort(-1);
            m22.writer().writeShort(p.index_map);
            this.send_msg_all_p(m22, null, true);
            m22.cleanup();
         }
      } catch (IOException var7) {
         var7.printStackTrace();
      } catch (NullPointerException var8) {
         var8.printStackTrace();
      } catch (Exception var9) {
         var9.printStackTrace();
         System.out.println("err leave map " + this.template.id);
      }
   }

   public static Map[] get_map_by_id(int id) {
      for (int i = 0; i < ENTRYS.size(); i++) {
         if (ENTRYS.get(i)[0].template.id == id) {
            return ENTRYS.get(i);
         }
      }

      return null;
   }

   public static Player get_player_by_name_allmap(String name) {
      try {
         for (int i = 0; i < ENTRYS.size(); i++) {
            for (int j = 0; j < ((Map[])ENTRYS.get(i)).length; j++) {
               Map m = ENTRYS.get(i)[j];

               for (int k = 0; k < m.players.size(); k++) {
                  if (m.players.get(k).name.equals(name)) {
                     return m.players.get(k);
                  }
               }
            }
         }

         for (int i = 0; i < MAP_PLUS.size(); i++) {
            Map map = MAP_PLUS.get(i);

            for (int j = 0; j < map.players.size(); j++) {
               Player p0 = map.players.get(j);
               if (p0.name.equals(name)) {
                  return p0;
               }
            }
         }
      } catch (Exception var5) {
      }

      return null;
   }

   public void send_move(Player p, Message m) throws IOException {
      p.ensureRuntimeState();
      if (!p.isdie) {
         p.x = m.reader().readShort();
         p.y = m.reader().readShort();
         if (p.map.map_pvp != null) {
            if (p.x < 5) {
               p.x = 5;
            } else if (p.x > 1070) {
               p.x = 1070;
            }

            if (p.y > 330) {
               p.y = 330;
            } else if (p.y < 170) {
               p.y = 170;
            }
         }

         if (!is_map_dont_show_other_info(this.template.id)) {
            Message mmove = new Message(1);
            mmove.writer().writeByte(0);
            mmove.writer().writeShort(p.index_map);
            mmove.writer().writeShort(p.x);
            mmove.writer().writeShort(p.y);
            this.send_msg_all_p(mmove, p, false);
            mmove.cleanup();
            if (p.ship_pet != null && p.ship_pet.map != null && p.ship_pet.map.equals(p.map)) {
               if (p.ship_pet.time < System.currentTimeMillis()) {
                  p.ship_pet.time = System.currentTimeMillis() + 1800L;
                  p.ship_pet.x = p.x;
                  p.ship_pet.y = p.y;
               }

               mmove = new Message(1);
               mmove.writer().writeByte(0);
               mmove.writer().writeShort(p.ship_pet.index_map);
               mmove.writer().writeShort(p.ship_pet.x);
               mmove.writer().writeShort(p.ship_pet.y);
               p.conn.addmsg(mmove);
               mmove.cleanup();
            }
         }

         for (int i = 0; i < this.list_mob.length; i++) {
            Mob mob = Mob.ENTRYS.get(this.list_mob[i]);
            if (mob != null && !mob.isdie && Math.abs(mob.x - p.x) < 70 && Math.abs(mob.y - p.y) < 70 && mob.id_target == -1) {
               mob.id_target = p.index_map;
            }
         }

         if (is_map_dungeon(this.template.id) && p.dungeon != null) {
            for (int ix = 0; ix < p.dungeon.mobs.size(); ix++) {
               Mob mob = p.dungeon.mobs.get(ix);
               if (mob != null && !mob.isdie && mob.map.equals(this) && Math.abs(mob.x - p.x) < 70 && Math.abs(mob.y - p.y) < 70 && mob.id_target == -1) {
                  mob.id_target = p.index_map;
               }
            }
         }

         for (int ixx = 0; ixx < Boss.ENTRYS.size(); ixx++) {
            Boss temp = Boss.ENTRYS.get(ixx);
            if (!temp.mob.isdie && Math.abs(temp.mob.x - p.x) < 70 && Math.abs(temp.mob.y - p.y) < 70 && temp.mob.id_target == -1) {
               temp.mob.id_target = p.index_map;
            }
         }

         if (p.ischangemap) {
            if (is_map_dungeon(this.template.id) && p.dungeon != null) {
               int num_mob = 0;

               for (int ixxx = 0; ixxx < p.dungeon.mobs.size(); ixxx++) {
                  Mob mob_dungeon = p.dungeon.mobs.get(ixxx);
                  if (mob_dungeon.map.equals(this)) {
                     num_mob++;
                     Message mmove = new Message(1);
                     mmove.writer().writeByte(1);
                     mmove.writer().writeShort(mob_dungeon.index);
                     mmove.writer().writeShort(mob_dungeon.x);
                     mmove.writer().writeShort(mob_dungeon.y);
                     this.send_msg_all_p(mmove, p, true);
                     mmove.cleanup();
                  }
               }

               if (num_mob > 0) {
                  return;
               }
            }

            for (Vgo vgo : this.template.vgos) {
               if (Math.abs(vgo.xold - p.x) < 60 && Math.abs(vgo.yold - p.y) < 60) {
                  p.time_change_map = System.currentTimeMillis() + 5000L;

                  try {
                     Thread.sleep(250L);
                  } catch (InterruptedException var7) {
                  }

                  p.goto_map(vgo);
                  break;
               }
            }
         } else if (p.time_change_map < System.currentTimeMillis()) {
            p.ischangemap = true;
         }
      }
   }

   private static boolean is_map_dont_show_other_info(int id) {
      return id == 64;
   }

   public void update_num_player_in_map(Player p) throws IOException {
      Message m = new Message(-70);
      m.writer().writeByte((byte)p.map.players.size());
      m.writer().writeByte(15);
      p.conn.addmsg(m);
      m.cleanup();
   }

   public synchronized void use_skill(Player p, Message m2) throws IOException {
      p.ensureRuntimeState();
      short idSkill = m2.reader().readShort();
      byte CatBeFire = m2.reader().readByte();
      byte size_target = m2.reader().readByte();
      if (!p.isdie && size_target > 0) {
         Skill_info sk_temp = p.get_skill_temp(idSkill);
         if (sk_temp == null || sk_temp.temp.typeSkill != 1 && sk_temp.temp.typeSkill != 4) {
            return;
         }

         if (p.time_sk[sk_temp.temp.ID] > System.currentTimeMillis()) {
            return;
         }

         p.time_sk[sk_temp.temp.ID] = System.currentTimeMillis() + sk_temp.temp.timeDelay - sk_temp.temp.timeDelay * p.body.get_agility(true) / 1000;
         if (p.mp - sk_temp.temp.manaLost < 0) {
            Service.send_box_ThongBao_OK(p, "MP không đủ!");
            return;
         }

         int hp_ = p.body.get_hp_atk_absorb(true);
         int mp_ = p.body.get_mp_atk_absorb(true);
         Service.use_potion(p, 0, hp_);
         Service.use_potion(p, 1, mp_);
         p.mp = p.mp - sk_temp.temp.manaLost;
         long dame = p.body.get_dame(true);
         dame = dame * p.body.get_dame_devil_percent() / 100L;
         EffTemplate eff = p.get_eff(5);
         if (eff != null) {
            dame *= 2L;
         }

         eff = p.get_eff(18);
         if (eff != null) {
            dame = dame * eff.param / 100L;
         }

         if (dame > 2L && p.get_eff(21) != null) {
            dame /= 2L;
         }

         if (sk_temp.temp.ID == 2057 || sk_temp.temp.ID == 2058) {
            dame = dame * 12L / 10L;
         }

         if (p.map.template.specMap == 4 && sk_temp.temp.ID != 3 || p.map.template.specMap != 4 && sk_temp.temp.ID == 3) {
            dame = 0L;
         }

         if (p.get_eff(407) == null && p.body.get_kich_an(7) > 0) {
            p.danhLaChoang++;
         }

         if (p.get_eff(408) == null && p.body.get_kich_an(8) > 0) {
            p.thanhLoc++;
         }

         if (sk_temp.temp.nTarget > 0 && sk_temp.temp.nTarget < size_target) {
            size_target = sk_temp.temp.nTarget;
         }

         Player[] p_target = new Player[size_target];
         Mob[] mob_target = new Mob[size_target];
         Ship_pet spet = null;

         for (int i = 0; i < size_target; i++) {
            int id_target = m2.reader().readShort();
            switch (CatBeFire) {
               case 0:
                  p_target[i] = this.get_player_by_id_inmap(id_target);
                  if (i == 0 && p_target[i] == null) {
                     spet = Ship_pet.get_pet(id_target);
                  }
                  break;
               case 1:
                  mob_target[i] = Mob.ENTRYS.get(id_target);
                  if (mob_target[i] == null && is_map_boss(this.template.id) && p.map_boss_info != null) {
                     mob_target[i] = MapBossInfo.get_mob(p, id_target);
                  }

                  if (mob_target[i] == null && is_map_dungeon(this.template.id) && p.dungeon != null && this.map_dungeon != null) {
                     mob_target[i] = p.dungeon.get_mob(p, id_target);
                  }

                  if (mob_target[i] == null && this.template.id == 81 && this.map_little_garden != null) {
                     mob_target[i] = this.get_mobs(id_target, 0);
                  }

                  if (mob_target[i] == null && is_map_dungeon(this.template.id) && p.dungeon != null && this.map_dungeon != null) {
                     this.remove_obj(id_target, 1);
                  }
            }
         }

         long[] exp_up = null;
         switch (CatBeFire) {
            case 0:
               eff = p.get_eff(12);
               if (eff != null && p_target[0] != null) {
                  Service.send_eff_sword_splash(p_target[0].index_map, p);
               }

               if (p_target.length > 0 && p_target[0] == null && spet != null) {
                  this.atk_ship_pet(spet, p, idSkill);
                  break;
               }

               this.Fire_Player(p_target, p, idSkill, dame);
               break;
            case 1:
               if (mob_target[0] != null) {
                  eff = p.get_eff(12);
                  if (eff != null) {
                     Service.send_eff_sword_splash(mob_target[0].index, p);
                  }
               }

               exp_up = this.Fire_Monster(mob_target, p, idSkill, dame);
         }

         if (exp_up != null) {
            if (exp_up[0] > 0L) {
               p.update_exp(exp_up[0], true);
            }

            if (exp_up[1] > 0L) {
               p.update_skill_exp(idSkill, exp_up[1]);
            }
         }
      }
   }

   private void atk_ship_pet(Ship_pet spet, Player p, short idSkill) throws IOException {
      if (!isMapLang(this.template.id)
         && spet.main_ship.index_map != p.index_map
         && (p.typePirate == 0 || p.typePirate == 2)
         && (p.typePirate != 0 || spet.main_ship.typePirate != 0)) {
         Skill_info sk_temp = p.get_skill_temp(idSkill);
         if (sk_temp != null) {
            Message m = new Message(100);
            m.writer().writeShort(p.index_map);
            m.writer().writeByte(0);
            m.writer().writeInt(p.hp);
            m.writer().writeInt(p.mp);
            m.writer().writeShort(sk_temp.get_eff_skill());
            m.writer().writeByte(1);
            m.writer().writeShort(spet.index_map);
            m.writer().writeByte(0);
            int dame_ship_pet = 50;
            if (spet.main_ship.typePirate == 2) {
               dame_ship_pet = 100;
            }

            m.writer().writeInt(dame_ship_pet);
            spet.hp -= dame_ship_pet;
            if (spet.hp <= 0) {
               spet.hp = 0;
               spet.main_ship.ship_pet = null;
               Ship_pet.remv(spet);

               try {
                  this.remove_obj(spet.index_map, 0);
               } catch (Exception var11) {
               }

               p.ship_pet = new Ship_pet();
               short index_map_new = -2;
               p.ship_pet.index_map = index_map_new;
               p.id_ship_packet = spet.main_ship.id_ship_packet;
               p.ship_pet.main_ship = p;
               p.ship_pet.map = p.map;
               p.ship_pet.name = "Hàng " + p.name;
               p.ship_pet.x = spet.x;
               p.ship_pet.y = spet.y;
               p.ship_pet.hp_max = 2000;
               p.ship_pet.hp = p.ship_pet.hp_max;
               p.ship_pet.time_start = spet.time_start;
               p.ship_pet.mainBaoVe = "";
               Ship_pet.add(p.ship_pet);
               Message m_local = new Message(1);
               m_local.writer().writeByte(0);
               m_local.writer().writeShort(p.ship_pet.index_map);
               m_local.writer().writeShort(p.ship_pet.x);
               m_local.writer().writeShort(p.ship_pet.y);

               for (int j = 0; j < p.map.players.size(); j++) {
                  Player p0 = p.map.players.get(j);
                  if (p0 != null && p0.conn != null) {
                     p0.conn.addmsg(m_local);
                  }
               }

               m_local.cleanup();
            }

            m.writer().writeInt(0);
            m.writer().writeInt(spet.hp);
            m.writer().writeByte(0);
            this.send_msg_all_p(m, p, true);
            m.cleanup();
         }
      }
   }

   private void Fire_Player(Player[] list_target, Player p, int idSkill, long dame) throws IOException {
      Skill_info sk_temp = p.get_skill_temp(idSkill);
      if (this.can_PK
         && sk_temp != null
         && (this.map_pvp == null || this.map_pvp.num_win_p1 != 3 && this.map_pvp.num_win_p2 != 3 && this.map_pvp.status_pvp == 3)) {
         int dame_plus_percent = 0;
         int dame_magic_plus_percent = p.body.get_dame_ap();
         int crit_skill = p.body.get_crit(true);
         int multi_dame_skill = p.body.get_multi_dame_when_crit(true);
         boolean crit = false;
         List<Dame_Msg> list = new ArrayList<>();
         long dame_mine_all = 0L;
         long damebefore = dame;

         for (int i = 0; i < list_target.length; i++) {
            Player p_target = list_target[i];
            if (p_target != null
               && p_target.index_map != p.index_map
               && !p_target.isdie
               && !p.isdie
               && p_target.time_can_mob_atk - 1000L < System.currentTimeMillis()
               && (
                  p.typePirate == 0 && p_target.typePirate == 2
                     || p.typePirate == 2 && p_target.typePirate == 0
                     || p.typePirate == 1 && p_target.typePirate == 2
                     || p.typePirate == 2 && p_target.typePirate == 1
                     || p.type_pk == 14 && p_target.type_pk == 15
                     || p.type_pk == 15 && p_target.type_pk == 14
                     || p.typePirate == 2 && p_target.typePirate == 2
                     || p.type_pk == 0
                     || p_target.type_pk == 1
                     || p.type_pk == 3 && p_target.type_pk == 3
                     || p_target.type_pk == 0
                     || p.type_pk == 3 && p_target.type_pk >= 4 && p_target.type_pk <= 8
                     || p_target.type_pk == 3 && p.type_pk >= 4 && p.type_pk <= 8
                     || p.type_pk >= 4 && p.type_pk <= 8 && p_target.type_pk >= 4 && p_target.type_pk <= 8 && p.type_pk != p_target.type_pk
               )) {
               ItemFashionP2 checkF = p.check_fashion(120);
               if (checkF != null && checkF.is_use && i == 0 && p_target.get_eff(21) == null && 5 > Util.random(120)) {
                  p_target.add_new_eff(21, Util.random(28), 5000L);
                  p_target.update_info_to_all();

                  for (int j = 0; j < this.players.size(); j++) {
                     Service.charWearing(p_target, this.players.get(j), false);
                  }
               }

               long dame2 = damebefore * (1000L + dame_plus_percent) / 1000L;
               dame2 = dame2 * sk_temp.get_dame(p) / p.skill_point.get(0).get_dame(p);
               long def = p_target.body.get_def(true);
               def = def * (1000L + p_target.body.get_def_percent(true)) / 1000L;
               dame2 -= def;
               crit = crit_skill > Util.random(1000);
               long dame_mine = 0L;
               Dame_Msg dame_inf = new Dame_Msg();
               dame_inf.data = new ArrayList<>();
               dame_inf.targetP = p_target;
               if (dame2 > 0L && idSkill != 0) {
                  dame_inf.dameM = p.get_skill_temp(idSkill).get_dame(p) * dame_magic_plus_percent / 1000;
               }

               if (dame_inf.dameM < 0L) {
                  dame_inf.dameM = 0L;
               }

               if (dame2 > 0L && idSkill == 2038 || idSkill == 2041) {
                  if (p.get_eff(6) != null) {
                     dame2 = dame2 * 115L / 100L;
                  }

                  for (int i12 = 0; i12 < p.fashion.size(); i12++) {
                     if ((p.fashion.get(i12).id == 33 || p.fashion.get(i12).id == 34) && p.fashion.get(i12).is_use) {
                        dame2 = dame2 * 115L / 100L;
                        break;
                     }
                  }
               }

               int react_dame_ = p_target.body.get_dame_react(true) - p.body.get_dame_react_reduce();
               int MienThuong = p_target.body.get_dame_skip(true) - p.body.get_dame_skip_reduce();
               if (MienThuong < 0) {
                  MienThuong = 0;
               }

               if (MienThuong > 900) {
                  MienThuong = 900;
               }

               int get_miss = p_target.body.get_miss(true) - p.body.get_miss_reduce();
               boolean miss = p.get_eff(205) != null || get_miss > Util.random(1000);
               if (miss) {
                  dame2 = 0L;
               }

               if (dame2 > 0L && react_dame_ > Util.random(1000)) {
                  dame_mine = dame2 * 8L / 10L;
               }

               if (dame2 > 0L) {
                  int kich_an = p_target.body.get_kich_an(0);
                  if (kich_an > 0) {
                     EffTemplate eff = p_target.get_eff(300);
                     if (eff != null) {
                        dame2 = 0L;
                        dame_inf.dameM = 0L;
                     } else {
                        eff = p_target.get_eff(400);
                        if (eff == null) {
                           int per = kich_an == 3 ? 10 : (kich_an == 2 ? 8 : 5);
                           per = per * 1000 / 1000;
                           if (per > Util.random(120)) {
                              dame2 = 0L;
                              dame_inf.dameM = 0L;
                              int time_eff = 5;
                              time_eff = time_eff * 1000 / 1000;
                              p_target.add_new_eff(300, 1, time_eff * 1000);
                              Service.send_kich_an(p, p_target, time_eff, 0, 0, 0);
                              int var108 = 60000;
                              var108 = var108 * 1000 / 1000;
                              p_target.add_new_eff(400, 1, var108);
                           }
                        }
                     }
                  }

                  kich_an = p_target.body.get_kich_an(1);
                  if (kich_an > 0) {
                     EffTemplate eff = p_target.get_eff(401);
                     if (eff == null) {
                        int per = kich_an == 3 ? 10 : (kich_an == 2 ? 8 : 5);
                        per = per * 1000 / 1000;
                        if (per > Util.random(120)) {
                           p_target.hp = (int)(p_target.hp + dame2 / 5L);
                           int time_eff = 60000;
                           time_eff = time_eff * 1000 / 1000;
                           p_target.add_new_eff(401, 1, time_eff);
                           Service.send_kich_an(p, p_target, 1, 1, 0, (int)(dame2 / 5L));
                           dame2 = 0L;
                           dame_inf.dameM = 0L;
                        }
                     }
                  }

                  kich_an = p_target.body.get_kich_an(2);
                  if (kich_an > 0) {
                     EffTemplate eff = p_target.get_eff(402);
                     if (eff == null) {
                        int per = kich_an == 3 ? 10 : (kich_an == 2 ? 8 : 5);
                        per = per * 1000 / 1000;
                        if (per > Util.random(120)) {
                           int time_eff = 60000;
                           time_eff = time_eff * 1000 / 1000;
                           p_target.add_new_eff(402, 1, time_eff);
                           Service.send_kich_an(p, p_target, 1, 2, 5, 50);
                           int var114 = 5000;
                           var114 = var114 * 1000 / 1000;
                           eff = p.get_eff(205);
                           if (eff == null) {
                              p.add_new_eff(205, 1, var114);
                           } else {
                              eff.time = System.currentTimeMillis() + var114;
                           }

                           Buff.send_choang(p_target, p, var114);
                           dame2 = 0L;
                           dame_inf.dameM = 0L;
                        }
                     }
                  }

                  kich_an = p_target.body.get_kich_an(3);
                  if (kich_an > 0) {
                     EffTemplate eff = p_target.get_eff(403);
                     if (eff == null) {
                        int per = kich_an == 3 ? 10 : (kich_an == 2 ? 8 : 5);
                        per = per * 1000 / 1000;
                        if (per > Util.random(120)) {
                           int time_eff = 60000;
                           time_eff = time_eff * 1000 / 1000;
                           p_target.add_new_eff(403, 1, time_eff);
                           Service.send_kich_an(p, p_target, 5, 3, 0, p.mp);
                           p.mp = 0;
                           dame2 = 0L;
                           dame_inf.dameM = 0L;
                        }
                     }
                  }

                  kich_an = p.body.get_kich_an(4);
                  if (kich_an > 0) {
                     EffTemplate eff = p.get_eff(404);
                     if (eff == null) {
                        int per = kich_an == 3 ? 10 : (kich_an == 2 ? 8 : 5);
                        per = per * 1000 / 1000;
                        if (per > Util.random(120)) {
                           int time_eff = 60000;
                           time_eff = time_eff * 1000 / 1000;
                           p.add_new_eff(404, 1, time_eff);
                           Service.send_kich_an(p_target, p, 1, 4, 0, (int)(dame2 * 2L));
                           dame2 *= 2L;
                           dame_inf.dameM *= 2L;
                        }
                     }
                  }

                  kich_an = p.body.get_kich_an(5);
                  if (kich_an > 0) {
                     EffTemplate eff = p.get_eff(305);
                     if (eff != null) {
                        crit = true;
                     } else {
                        eff = p.get_eff(405);
                        if (eff == null) {
                           int per = kich_an == 3 ? 10 : (kich_an == 2 ? 8 : 5);
                           per = per * 1000 / 1000;
                           if (per > Util.random(120)) {
                              int time_eff = 10;
                              time_eff = time_eff * 1000 / 1000;
                              p.add_new_eff(305, 1, time_eff * 1000);
                              Service.send_kich_an(p_target, p, time_eff, 5, 0, 0);
                              int var122 = 60000;
                              var122 = var122 * 1000 / 1000;
                              p.add_new_eff(405, 1, var122);
                              crit = true;
                           }
                        }
                     }
                  }

                  kich_an = p.body.get_kich_an(6);
                  if (kich_an > 0) {
                     EffTemplate eff = p.get_eff(406);
                     if (eff == null) {
                        int per = kich_an == 3 ? 10 : (kich_an == 2 ? 8 : 5);
                        per = per * 1000 / 1000;
                        if (per > Util.random(120)) {
                           int time_eff = 60000;
                           time_eff = time_eff * 1000 / 1000;
                           p.add_new_eff(406, 1, time_eff);
                           Service.send_kich_an(p_target, p, 1, 6, 0, (int)(dame2 / 5L));
                           p.hp = (int)(p.hp + dame2 / 5L);
                        }
                     }
                  }

                  kich_an = p.body.get_kich_an(7);
                  if (kich_an > 0) {
                     EffTemplate eff = p.get_eff(407);
                     if (eff == null) {
                        int per = kich_an == 3 ? 10 : (kich_an == 2 ? 15 : 20);
                        per = per * 1000 / 1000;
                        if (per == p.danhLaChoang) {
                           p.danhLaChoang = 0;
                           int time_eff = 60000;
                           time_eff = time_eff * 1000 / 1000;
                           p.add_new_eff(407, 1, time_eff);
                           Service.send_kich_an(p_target, p, 1, 7, 5, 50);
                           int var128 = 5000;
                           var128 = var128 * 1000 / 1000;
                           eff = p_target.get_eff(205);
                           if (eff == null) {
                              p_target.add_new_eff(205, 1, var128);
                           } else {
                              eff.time = System.currentTimeMillis() + var128;
                           }

                           Buff.send_choang(p, p_target, var128);
                        }
                     }
                  }

                  kich_an = p.body.get_kich_an(8);
                  if (kich_an > 0) {
                     EffTemplate eff = p.get_eff(408);
                     if (eff == null) {
                        int per = kich_an == 3 ? 10 : (kich_an == 2 ? 15 : 20);
                        per = per * 1000 / 1000;
                        if (per == p.thanhLoc) {
                           p.thanhLoc = 0;
                           int time_eff = 60000;
                           time_eff = time_eff * 1000 / 1000;
                           p.add_new_eff(408, 1, time_eff);
                           Service.send_kich_an(p_target, p, 1, 8, 0, 0);
                        }
                     }
                  }

                  kich_an = p_target.body.get_kich_an(9);
                  if (kich_an > 0) {
                     EffTemplate eff = p_target.get_eff(409);
                     if (eff == null) {
                        p_target.nenDau++;
                        int per = kich_an == 3 ? 10 : (kich_an == 2 ? 15 : 20);
                        per = per * 1000 / 1000;
                        if (per == p_target.nenDau) {
                           p_target.nenDau = 0;
                           int time_eff = 60000;
                           time_eff = time_eff * 1000 / 1000;
                           p_target.add_new_eff(409, 1, time_eff);
                           Service.send_kich_an(p, p_target, 1, 9, 0, 0);
                        }
                     }
                  }

                  kich_an = p_target.body.get_kich_an(10);
                  if (kich_an > 0) {
                     EffTemplate eff = p_target.get_eff(410);
                     if (eff == null) {
                        p_target.giaiPhongNangLuong++;
                        int per = kich_an == 3 ? 10 : (kich_an == 2 ? 15 : 20);
                        per = per * 1000 / 1000;
                        if (per == p_target.giaiPhongNangLuong) {
                           p_target.giaiPhongNangLuong = 0;
                           int time_eff = 60000;
                           time_eff = time_eff * 1000 / 1000;
                           p_target.add_new_eff(410, 1, time_eff);
                           Service.send_kich_an(p, p_target, 1, 10, 5, 50);
                           int var136 = 5000;
                           var136 = var136 * 1000 / 1000;
                           eff = p.get_eff(205);
                           if (eff == null) {
                              p.add_new_eff(205, 1, var136);
                           } else {
                              eff.time = System.currentTimeMillis() + var136;
                           }

                           Buff.send_choang(p_target, p, var136);
                        }
                     }
                  }

                  if (dame2 > 0L) {
                     dame2 = dame2 * (1000L + p.body.get_percent_final_dame()) / 1000L;
                     if (dame2 > 1L && crit) {
                        dame2 = dame2 * (1000L + multi_dame_skill) / 1000L;
                        int dame_crit_decrease = p_target.body.get_multi_dame_decrease();
                        dame2 = dame2 * (1000L - dame_crit_decrease) / 1000L;
                        if (dame2 < 1L) {
                           dame2 = 1L;
                        }
                     }

                     int percent_hp_target = p.body.get_dame_percent_hp_target();
                     if (damebefore > 0L && percent_hp_target > 0) {
                        long hp_target = p_target.hp;
                        hp_target = hp_target * percent_hp_target / 1000L;
                        hp_target = hp_target * (1000 - MienThuong * 3 / 5) / 1000L;
                        dame2 += hp_target;
                     }

                     dame2 = dame2 * (1000 - MienThuong) / 1000L;
                  }
               }

               int kich_anx = p.body.get_kich_an(11);
               if (kich_anx > 0 && p.get_eff(202) == null) {
                  int hp_max = p.body.get_hp_max(true);
                  int per = kich_anx == 3 ? 20 : (kich_anx == 2 ? 15 : 10);
                  per = per * 1000 / 1000;
                  int hp_absorb_kichan = hp_max / 1000 * per;
                  if (hp_absorb_kichan > 0) {
                     Service.send_kich_an(p_target, p, hp_absorb_kichan / 10, 11, 0, 0);
                     p.hp += hp_absorb_kichan;
                     if (p.hp > hp_max) {
                        p.hp = hp_max;
                     }
                  }
               }

               if (p_target.get_eff(7) != null && p_target.type_pk == -1 || p_target.get_eff(9) != null || damebefore == 0L) {
                  dame2 = 0L;
                  dame_inf.dameM = 0L;
                  dame_mine = 0L;
               }

               dame_inf.dameP = dame2;
               long dame_to_target = dame2 + dame_inf.dameM;
               p_target.hp = (int)(p_target.hp - dame_to_target);
               long HapThuHP = 0L;
               long percent_HapThu = p_target.body.get_HapThu_Hp();
               if (dame2 > 1L && percent_HapThu > Util.random(1000) && p.get_eff(202) == null && p_target.hp > 0) {
                  HapThuHP = dame2 * percent_HapThu / 1000L;
                  int hp_max_target = p_target.body.get_hp_max(true);
                  if (HapThuHP > hp_max_target / 2) {
                     HapThuHP = hp_max_target / 2;
                  }

                  Service.use_potion(p_target, 0, (int)HapThuHP);
               }

               if (p_target.hp <= 0 && p_target.get_eff(10) == null && p_target.body.get_TuChoiTuThan() > 0) {
                  int time_eff = 5;
                  time_eff = time_eff * 1000 / 1000;
                  p_target.add_new_eff(9, 1, time_eff * 1000);
                  time_eff = 150000;
                  time_eff = time_eff * 1000 / 1000;
                  p_target.add_new_eff(10, 1, time_eff);
                  Service.send_eff(p_target, 21, 50);
                  p_target.hp = p_target.body.get_hp_max(true) / 10;
               }

               if (p_target.hp <= 0) {
                  p_target.hp = 0;
                  p_target.isdie = true;
                  if (p.type_pk == 0 && p_target.type_pk != 0) {
                     int delta = p.level / 10 - p_target.level / 10;
                     int plus = p.pointPk > 0 ? p.pointPk / 5 : 0;
                     if (delta > 0) {
                        p.update_point_pk(100 + delta * 100 + plus);
                     } else {
                        p.update_point_pk(100 + plus);
                     }

                     if (p_target.type_pk == -1 && p_target.typePirate == -1) {
                        while (p_target.enemy_list.size() > 50) {
                           p_target.enemy_list.remove(0);
                        }

                        FriendTemp enemy_add = null;

                        for (int j = 0; j < p_target.enemy_list.size(); j++) {
                           if (p_target.enemy_list.get(j).name.equals(p.name)) {
                              enemy_add = p_target.enemy_list.get(j);
                              break;
                           }
                        }

                        if (enemy_add != null) {
                           int save_index = p_target.enemy_list.indexOf(enemy_add);
                           FriendTemp save = p_target.enemy_list.get(0);
                           p_target.enemy_list.set(0, enemy_add);
                           p_target.enemy_list.set(save_index, save);
                        } else {
                           enemy_add = new FriendTemp(p);
                           p_target.enemy_list.add(enemy_add);
                           if (p_target.enemy_list.size() >= 2) {
                              enemy_add.id = p_target.enemy_list.get(p_target.enemy_list.size() - 2).id + 1;
                           } else {
                              enemy_add.id = 0;
                           }
                        }
                     }
                  }

                  if (this.template.id == 81 && this.map_little_garden != null) {
                     p_target.time_hs_little_garden = System.currentTimeMillis() + 10000L;
                     Service.send_time_cool_down(p_target, p_target.time_hs_little_garden, "Hồi sinh", 3);
                  }
               }

               if (dame_inf.dameP > 0L && sk_temp.temp.idEffSpec > 0 && sk_temp.temp.idEffSpec < 17) {
                  EffTemplate eff = p_target.get_eff(200 + sk_temp.temp.idEffSpec);
                  if (eff == null) {
                     int reduce_Eff = p_target.body.get_reduce_Eff();
                     int percent = sk_temp.temp.perEffSpec;
                     percent = percent * (1000 - reduce_Eff) / 1000;
                     if (percent > Util.random(1000)) {
                        int time = sk_temp.temp.timeEffSpec;
                        time = time * (1000 - reduce_Eff) / 1000;
                        p_target.add_new_eff(200 + sk_temp.temp.idEffSpec, 1, time * 100);
                        dame_inf.data.add(new Option_Dame_Msg(sk_temp.temp.idEffSpec, 1, time));
                        if (sk_temp.temp.idEffSpec == 16) {
                           Message m = new Message(74);
                           m.writer().writeByte(1);
                           m.writer().writeShort(p_target.index_map);
                           m.writer().writeShort(5);
                           m.writer().writeInt(time * 100);
                           m.writer().writeByte(1);
                           m.writer().writeByte(10);
                           this.send_msg_all_p(m, null, true);
                           m.cleanup();
                        }
                     }
                  }
               }

               if (crit) {
                  dame_inf.data.add(new Option_Dame_Msg(1010, (int)dame_inf.dameP, 0));
               }

               if (HapThuHP > 0L) {
                  dame_inf.data.add(new Option_Dame_Msg(1058, (int)HapThuHP, 0));
               }

               if (dame_mine > 0L) {
                  dame_inf.data.add(new Option_Dame_Msg(1014, (int)dame_mine, 0));
                  dame_mine_all += dame_mine;
               }

               list.add(dame_inf);
            }
         }

         if (dame_mine_all > 0L) {
            p.hp = (int)(p.hp - dame_mine_all);
            if (p.hp <= 0) {
               p.hp = 0;
            }

            this.update_hp_mp_eff(p, null, 1, (int)(-dame_mine_all));
         }

         if (list.size() > 0) {
            this.send_dame_msg(p, sk_temp.get_eff_skill(), list);
         }

         if (p.hp <= 0) {
            p.hp = 0;
            p.isdie = true;
            if (this.map_pvp != null) {
               try {
                  Player p_in_pvp = null;

                  for (int ix = 0; ix < this.players.size(); ix++) {
                     p_in_pvp = this.players.get(ix);
                     if (!p_in_pvp.equals(p)) {
                        break;
                     }
                  }

                  if (p_in_pvp != null && !p_in_pvp.equals(p)) {
                     this.die_player(p, p_in_pvp);
                  }
               } catch (Exception var44) {
               }
            } else {
               this.die_player(p, p);
            }
         }
      }
   }

   private void update_hp_mp_eff(Player p, Mob mob, int type, int dame) throws IOException {
      Message m = new Message(55);
      if (mob != null) {
         m.writer().writeShort(mob.index);
         m.writer().writeByte(1);
         m.writer().writeByte(type);
         m.writer().writeInt(mob.hp_max);
         m.writer().writeInt(mob.hp);
         m.writer().writeInt(dame);
         m.writer().writeInt(mob.hp_max);
         m.writer().writeInt(mob.hp);
         m.writer().writeInt(0);
      } else if (p != null) {
         m.writer().writeShort(p.index_map);
         m.writer().writeByte(0);
         m.writer().writeByte(1);
         m.writer().writeInt(p.body.get_hp_max(true));
         m.writer().writeInt(p.hp);
         m.writer().writeInt(dame);
         m.writer().writeInt(p.body.get_mp_max(true));
         m.writer().writeInt(p.mp);
         m.writer().writeInt(0);
      }

      this.send_msg_all_p(m, p, true);
      m.cleanup();
   }

   private long[] Fire_Monster(Mob[] list_target, Player p, int idSkill, long dame) throws IOException {
      long[] exp_up = new long[]{0L, 0L};
      Skill_info sk_temp = p.get_skill_temp(idSkill);
      if (sk_temp == null) {
         return exp_up;
      } else {
         int dame_plus_percent = 0;
         int dame_magic_plus_percent = p.body.get_dame_ap();
         int crit_skill = p.body.get_crit(true);
         int multi_dame_skill = p.body.get_multi_dame_when_crit(true);
         boolean crit = crit_skill > Util.random(1000);
         List<Dame_Msg> list = new ArrayList<>();
         HashMap<Integer, Integer> id_mob_die = new HashMap<>();
         long damebefore = dame;

         for (int i = 0; i < list_target.length; i++) {
            Mob mob_target = list_target[i];
            if (mob_target != null && !mob_target.isdie && !p.isdie) {
               long dame2 = damebefore * (1000L + dame_plus_percent) / 1000L;
               crit = crit_skill > Util.random(1000);
               if (dame2 > 1L && crit) {
                  dame2 = dame2 * (1000L + multi_dame_skill) / 1000L;
               }

               dame2 = dame2 * sk_temp.get_dame(p) / p.skill_point.get(0).get_dame(p);
               Dame_Msg dame_inf = new Dame_Msg();
               dame_inf.data = new ArrayList<>();
               dame_inf.targetM = mob_target;
               if (dame2 > 0L && idSkill != 0) {
                  dame_inf.dameM = p.get_skill_temp(idSkill).get_dame(p) * dame_magic_plus_percent / 1000;
               }

               dame2 = dame2 * (1000L + p.body.get_percent_final_dame()) / 1000L;
               if (idSkill == 2038 || idSkill == 2041) {
                  if (p.get_eff(6) != null) {
                     dame2 = dame2 * 115L / 100L;
                  }

                  for (int i12 = 0; i12 < p.fashion.size(); i12++) {
                     if ((p.fashion.get(i12).id == 33 || p.fashion.get(i12).id == 34) && p.fashion.get(i12).is_use) {
                        dame2 = dame2 * 115L / 100L;
                        break;
                     }
                  }
               }

               boolean miss = 5 + mob_target.level / 10 > Util.random(1000);
               if (miss) {
                  dame2 = 0L;
               }

               if (dame2 > 0L) {
                  dame2 -= dame2 * Util.random(10) / 100L;
               }

               long dame_to_target = dame2 + dame_inf.dameM;
               if (mob_target.boss_info != null && dame_to_target > 0L) {
                  Top_Dame topdame = null;

                  for (int j = 0; j < mob_target.boss_info.TopDame.size(); j++) {
                     if (mob_target.boss_info.TopDame.get(j).name.equals(p.name)) {
                        topdame = mob_target.boss_info.TopDame.get(j);
                        break;
                     }
                  }

                  if (topdame != null) {
                     topdame.dame += dame_to_target;
                  } else {
                     topdame = new Top_Dame();
                     topdame.name = p.name;
                     topdame.dame = dame_to_target;
                     mob_target.boss_info.TopDame.add(topdame);
                  }
               }

               if (mob_target.hp == mob_target.hp_max && dame_to_target >= mob_target.hp) {
                  mob_target.hp = 1;
               } else {
                  int value1 = 0;
                  int value2 = 0;
                  int percent = 0;
                  if (mob_target.boss_info != null) {
                     int max_hp = mob_target.hp_max;
                     percent = max_hp / 10;
                     value1 = (mob_target.hp - 1) / percent;
                  }

                  if (this.clan_resource != null) {
                     this.clan_resource.dame += dame_to_target;
                  } else {
                     mob_target.hp = (int)(mob_target.hp - dame_to_target);
                  }

                  if (mob_target.boss_info != null && percent > 0) {
                     value2 = (mob_target.hp - 1) / percent;
                  }

                  boolean ch = false;
                  List<GiftBox> list_gift = new ArrayList<>();

                  for (int jx = value1 - 1; jx >= value2; jx--) {
                     try {
                        boolean has_custom_rewards = false;
                        if (mob_target.boss_info.rewards != null && !mob_target.boss_info.rewards.isEmpty() && !mob_target.boss_info.rewards.equals("[]")) {
                           has_custom_rewards = true;
                        }

                        if (!has_custom_rewards) {
                           int beri_receiv = (mob_target.mob_template.mob_id - 130) * 1000;
                           beri_receiv = beri_receiv / 100 * (100 + mob_target.boss_info.levelBoss * 10);
                           GiftBox gb_beri = new GiftBox();
                           ItemTemplate4 it_temp4 = ItemTemplate4.get_it_by_id(0);
                           if (it_temp4 != null) {
                              gb_beri.id = it_temp4.id;
                              gb_beri.type = 4;
                              gb_beri.name = it_temp4.name;
                              gb_beri.icon = it_temp4.icon;
                              gb_beri.num = beri_receiv;
                              gb_beri.color = 0;
                              list_gift.add(gb_beri);
                           }

                           if (15 > Util.random(120)) {
                              GiftBox gb_rcam = new GiftBox();
                              ItemTemplate4 it_temp4_in = ItemTemplate4.get_it_by_id((p.level < 11 ? 11 : p.level) / 10 + 111);
                              if (it_temp4_in != null) {
                                 gb_rcam.id = it_temp4_in.id;
                                 gb_rcam.type = 4;
                                 gb_rcam.name = it_temp4_in.name;
                                 gb_rcam.icon = it_temp4_in.icon;
                                 gb_rcam.num = 1;
                                 gb_rcam.color = 0;
                                 list_gift.add(gb_rcam);
                              }
                           }
                        } else {
                           JSONArray js_rewards = (JSONArray)JSONValue.parse(mob_target.boss_info.rewards);
                           if (js_rewards != null) {
                              for (int r = 0; r < js_rewards.size(); r++) {
                                 JSONObject reward_obj = (JSONObject)js_rewards.get(r);
                                 int type = Integer.parseInt(reward_obj.get("type").toString());
                                 int id = Integer.parseInt(reward_obj.get("id").toString());
                                 int quant = Integer.parseInt(reward_obj.get("quant").toString());
                                 int rate = Integer.parseInt(reward_obj.get("rate").toString());
                                 if (rate > Util.random(120)) {
                                    if (type == 4 || type == 7) {
                                       GiftBox gb_reward = new GiftBox();
                                       ItemTemplate4 it_temp4_in = ItemTemplate4.get_it_by_id(id);
                                       if (it_temp4_in != null) {
                                          gb_reward.id = it_temp4_in.id;
                                          gb_reward.type = (byte)type;
                                          gb_reward.name = it_temp4_in.name;
                                          gb_reward.icon = it_temp4_in.icon;
                                          gb_reward.num = quant;
                                          gb_reward.color = 0;
                                          list_gift.add(gb_reward);
                                       }
                                    } else if (type == 3) {
                                       GiftBox gb_reward = new GiftBox();
                                       ItemTemplate3 it_temp3_in = ItemTemplate3.get_it_by_id(id);
                                       if (it_temp3_in != null) {
                                          gb_reward.id = it_temp3_in.id;
                                          gb_reward.type = (byte)type;
                                          gb_reward.name = it_temp3_in.name;
                                          gb_reward.icon = it_temp3_in.icon;
                                          gb_reward.num = quant;
                                          gb_reward.color = it_temp3_in.color;
                                          list_gift.add(gb_reward);
                                       }
                                    }
                                 }
                              }
                           }
                        }
                     } catch (Exception var44) {
                        var44.printStackTrace();
                     }

                     ch = true;
                  }

                  if (ch && list_gift.size() > 0) {
                     Service.send_gift(p, 1, "Hoạt động săn trùm", "Gây sát thương 10% Hp", list_gift, false);

                     try {
                        List<GiftBox> list_gift_other = new ArrayList<>();
                        int beri_receiv_other = Util.random(6000, 15000);
                        GiftBox gb_beri_other = new GiftBox();
                        ItemTemplate4 it_temp4x = ItemTemplate4.get_it_by_id(0);
                        if (it_temp4x != null) {
                           gb_beri_other.id = it_temp4x.id;
                           gb_beri_other.type = 4;
                           gb_beri_other.name = it_temp4x.name;
                           gb_beri_other.icon = it_temp4x.icon;
                           gb_beri_other.num = beri_receiv_other;
                           gb_beri_other.color = 0;
                           list_gift_other.add(gb_beri_other);
                        }

                        if (30 > Util.random(120)) {
                           GiftBox gb_RHB = new GiftBox();
                           it_temp4x = ItemTemplate4.get_it_by_id(18 + p.level / 10);
                           if (it_temp4x != null) {
                              gb_RHB.id = it_temp4x.id;
                              gb_RHB.type = 4;
                              gb_RHB.name = it_temp4x.name;
                              gb_RHB.icon = it_temp4x.icon;
                              gb_RHB.num = Util.random(1, 3);
                              gb_RHB.color = 0;
                              list_gift_other.add(gb_RHB);
                           }
                        }

                        for (int jx = 0; jx < this.players.size(); jx++) {
                           Player p0 = this.players.get(jx);
                           if (p0.conn != null && !p0.equals(p) && !p0.isdie) {
                              Service.send_gift(p0, 1, "Hoạt động săn trùm", "Tham gia hoạt động săn trùm", list_gift_other, false);
                           }
                        }
                     } catch (Exception var43) {
                     }
                  }

                  if (value1 > 4 && value2 <= 4) {
                     list_gift.clear();
                     if (20 > Util.random(120)) {
                        GiftBox gb_rcam = new GiftBox();
                        ItemTemplate4 it_temp4_in = ItemTemplate4.get_it_by_id((p.level < 11 ? 11 : p.level) / 10 + 111);
                        if (it_temp4_in != null) {
                           gb_rcam.id = it_temp4_in.id;
                           gb_rcam.type = 4;
                           gb_rcam.name = it_temp4_in.name;
                           gb_rcam.icon = it_temp4_in.icon;
                           gb_rcam.num = 1;
                           gb_rcam.color = 0;
                           list_gift.add(gb_rcam);
                        }
                     }

                     int beri_receivx = 0;
                     switch (mob_target.mob_template.mob_id) {
                        case 135:
                           beri_receivx = 10000;
                           break;
                        case 136:
                           beri_receivx = 15000;
                           break;
                        case 137:
                           beri_receivx = 20000;
                           break;
                        case 138:
                           beri_receivx = 30000;
                           break;
                        case 139:
                           beri_receivx = 50000;
                           break;
                        case 140:
                           beri_receivx = 70000;
                     }

                     beri_receivx = beri_receivx / 100 * (100 + mob_target.boss_info.levelBoss * 10);
                     GiftBox gb_berix = new GiftBox();
                     ItemTemplate4 it_temp4xx = ItemTemplate4.get_it_by_id(0);
                     if (it_temp4xx != null) {
                        gb_berix.id = it_temp4xx.id;
                        gb_berix.type = 4;
                        gb_berix.name = it_temp4xx.name;
                        gb_berix.icon = it_temp4xx.icon;
                        gb_berix.num = beri_receivx;
                        gb_berix.color = 0;
                        list_gift.add(gb_berix);
                     }

                     if (mob_target.mob_template.mob_id >= 137 && mob_target.mob_template.mob_id <= 140) {
                        if (15 > Util.random(120)) {
                           int id_add = 70 > Util.random(120) ? 310 : (70 > Util.random(120) ? 311 : 312);
                           GiftBox gb_manh = new GiftBox();
                           ItemTemplate4 it_temp4_in = ItemTemplate4.get_it_by_id(id_add);
                           if (it_temp4_in != null) {
                              gb_manh.id = it_temp4_in.id;
                              gb_manh.type = 4;
                              gb_manh.name = it_temp4_in.name;
                              gb_manh.icon = it_temp4_in.icon;
                              gb_manh.num = 1;
                              gb_manh.color = 0;
                              list_gift.add(gb_manh);
                           }
                        }

                        if (10 > Util.random(120)) {
                           int id_add = 70 > Util.random(120) ? 313 : (70 > Util.random(120) ? 314 : 315);
                           GiftBox gb_manh = new GiftBox();
                           ItemTemplate4 it_temp4_in = ItemTemplate4.get_it_by_id(id_add);
                           if (it_temp4_in != null) {
                              gb_manh.id = it_temp4_in.id;
                              gb_manh.type = 4;
                              gb_manh.name = it_temp4_in.name;
                              gb_manh.icon = it_temp4_in.icon;
                              gb_manh.num = 1;
                              gb_manh.color = 0;
                              list_gift.add(gb_manh);
                           }
                        }
                     }

                     if (list_gift.size() > 0) {
                        Service.send_gift(p, 1, "Hoạt động săn trùm", "Gây sát thương 50% Hp", list_gift, false);
                     }
                  }

                  p.item.update_Inventory(-1, false);
                  p.update_money();
               }

               dame_inf.dameP = dame2;
               mob_target.id_target = p.index_map;
               if (mob_target.hp <= 0 && !mob_target.isdie) {
                  mob_target.hp = 0;
                  mob_target.isdie = true;
                  mob_target.time_refresh = System.currentTimeMillis() + 3500L;
                  exp_up[1] += mob_target.level * 2;
                  if (!is_map_dungeon(this.template.id) || p.dungeon == null) {
                     if (Math.abs(p.level - mob_target.level) <= 10) {
                        if (15 > Util.random(120)) {
                           LeaveItemMap.leave_item4(this, mob_target, p);
                        } else if (5 <= Util.random(120) && 15 > Util.random(120)) {
                           LeaveItemMap.leave_item7(this, mob_target, p);
                        }
                     }

                     LeaveItemMap.leave_item_quest(this, mob_target, p);
                  }

                  if (!id_mob_die.containsKey(Integer.valueOf(mob_target.mob_template.mob_id))) {
                     id_mob_die.put(Integer.valueOf(mob_target.mob_template.mob_id), 1);
                  } else {
                     int oldvalue = id_mob_die.get(Integer.valueOf(mob_target.mob_template.mob_id));
                     id_mob_die.replace(Integer.valueOf(mob_target.mob_template.mob_id), oldvalue, oldvalue + 1);
                  }

                  if (this.map_little_garden != null && !this.map_little_garden.is_finish && (p.type_pk == 4 || p.type_pk == 5)) {
                     LeaveItemMap.leave_item4_little_garden(this, mob_target, p);
                  }

                  if (mob_target.boss_info != null) {
                     String notice = "Tiêu diệt siêu trùm nhận: ";
                     this.remove_obj(mob_target.index, 1);
                     Manager.gI().chatKTG(0, p.name + " đã tiêu diệt " + mob_target.mob_template.name + " bậc " + mob_target.boss_info.levelBoss, 5);
                     List<GiftBox> list_gift = new ArrayList<>();
                     if (50 > Util.random(120)) {
                        GiftBox gb_rcam = new GiftBox();
                        ItemTemplate4 it_temp4_in = ItemTemplate4.get_it_by_id((p.level < 11 ? 11 : p.level) / 10 + 111);
                        if (it_temp4_in != null) {
                           gb_rcam.id = it_temp4_in.id;
                           gb_rcam.type = 4;
                           gb_rcam.name = it_temp4_in.name;
                           gb_rcam.icon = it_temp4_in.icon;
                           gb_rcam.num = 1;
                           gb_rcam.color = 0;
                           list_gift.add(gb_rcam);
                        }

                        notice = notice + "x1 rương cam cùng cấp, ";
                     }

                     if (30 > Util.random(120)) {
                        GiftBox gb_rcam = new GiftBox();
                        ItemTemplate7 it_temp7_in = ItemTemplate7.get_it_by_id(10);
                        if (it_temp7_in != null) {
                           gb_rcam.id = it_temp7_in.id;
                           gb_rcam.type = 7;
                           gb_rcam.name = it_temp7_in.name;
                           gb_rcam.icon = it_temp7_in.icon;
                           gb_rcam.num = 1;
                           gb_rcam.color = 0;
                           list_gift.add(gb_rcam);
                        }

                        notice = notice + "x1 khiên, ";
                     }

                     int beri_receivx = 0;
                     switch (mob_target.mob_template.mob_id) {
                        case 135:
                           beri_receivx = 30000;
                           break;
                        case 136:
                           beri_receivx = 50000;
                           break;
                        case 137:
                           beri_receivx = 70000;
                           break;
                        case 138:
                           beri_receivx = 100000;
                           break;
                        case 139:
                           beri_receivx = 150000;
                           break;
                        case 140:
                           beri_receivx = 200000;
                     }

                     if (mob_target.boss_info.levelBoss < 10) {
                        beri_receivx = beri_receivx / 100 * (100 + mob_target.boss_info.levelBoss * 20);
                     }

                     GiftBox gb_berixx = new GiftBox();
                     ItemTemplate4 it_temp4xxx = ItemTemplate4.get_it_by_id(0);
                     if (it_temp4xxx != null) {
                        gb_berixx.id = it_temp4xxx.id;
                        gb_berixx.type = 4;
                        gb_berixx.name = it_temp4xxx.name;
                        gb_berixx.icon = it_temp4xxx.icon;
                        gb_berixx.num = beri_receivx;
                        gb_berixx.color = 0;
                        list_gift.add(gb_berixx);
                     }

                     notice = notice + beri_receivx + " beri, ";
                     if (mob_target.mob_template.mob_id >= 137 && mob_target.mob_template.mob_id <= 140) {
                        if (30 > Util.random(120)) {
                           int id_add = 70 > Util.random(120) ? 310 : (70 > Util.random(120) ? 311 : 312);
                           GiftBox gb_manh = new GiftBox();
                           ItemTemplate4 it_temp4_in = ItemTemplate4.get_it_by_id(id_add);
                           if (it_temp4_in != null) {
                              gb_manh.id = it_temp4_in.id;
                              gb_manh.type = 4;
                              gb_manh.name = it_temp4_in.name;
                              gb_manh.icon = it_temp4_in.icon;
                              gb_manh.num = 1;
                              gb_manh.color = 0;
                              list_gift.add(gb_manh);
                           }

                           notice = notice + "x1 mảnh đồ tím 9x, ";
                        }

                        if (30 > Util.random(120)) {
                           int id_add = 70 > Util.random(120) ? 313 : (70 > Util.random(120) ? 314 : 315);
                           GiftBox gb_manh = new GiftBox();
                           ItemTemplate4 it_temp4_in = ItemTemplate4.get_it_by_id(id_add);
                           if (it_temp4_in != null) {
                              gb_manh.id = it_temp4_in.id;
                              gb_manh.type = 4;
                              gb_manh.name = it_temp4_in.name;
                              gb_manh.icon = it_temp4_in.icon;
                              gb_manh.num = 1;
                              gb_manh.color = 0;
                              list_gift.add(gb_manh);
                           }

                           notice = notice + "x1 mảnh đồ cam 9x, ";
                        }
                     }

                     p.update_money();
                     if (list_gift.size() > 0) {
                        Service.send_gift(p, 1, "Hoạt động săn trùm", "Tiêu diệt siêu trùm bậc " + mob_target.boss_info.levelBoss, list_gift, false);
                     }

                     Manager.gI().chatKTG(0, notice.substring(0, notice.length() - 1), 5);
                     if (mob_target.boss_info.levelBoss < 10) {
                        mob_target.hp = mob_target.hp_max;
                        mob_target.isdie = false;
                        mob_target.boss_info.levelBoss++;
                        mob_target.index++;
                        Message m_local = new Message(1);
                        m_local.writer().writeByte(1);
                        m_local.writer().writeShort(mob_target.index);
                        m_local.writer().writeShort(mob_target.x);
                        m_local.writer().writeShort(mob_target.y);

                        for (int jxx = 0; jxx < this.players.size(); jxx++) {
                           Player p0 = this.players.get(jxx);
                           if (p0 != null && p0.conn != null) {
                              p0.conn.addmsg(m_local);
                           }
                        }

                        m_local.cleanup();
                        Manager.gI().chatKTG(0, mob_target.mob_template.name + " bậc " + mob_target.boss_info.levelBoss + " xuất hiện", 5);
                     }
                  }

                  if (is_map_boss(this.template.id) && p.map_boss_info != null && p.map_boss_info.mob.contains(mob_target)) {
                     MapBossInfo bossInfo = p.map_boss_info;
                     this.remove_obj(mob_target.index, 1);
                     List<GiftBox> listGift = new ArrayList<>();
                     ItemTemplate4 chest = ItemTemplate4.get_it_by_id(bossInfo.rewardId);
                     if (chest != null) {
                        GiftBox gift = new GiftBox();
                        gift.id = chest.id;
                        gift.type = 4;
                        gift.name = chest.name;
                        gift.icon = chest.icon;
                        gift.num = 1;
                        gift.color = 0;
                        listGift.add(gift);
                     }
                     Service.send_gift(p, 0, "Phần thưởng Săn Trùm", "Phần thưởng", listGift, true);
                     bossInfo.mob.clear();
                     bossInfo.exitAt = System.currentTimeMillis() + 5000L;
                     Service.send_time_cool_down(p, bossInfo.exitAt, "Rời map", 2);
                  }
               }

               long exp_up_add = 1L;
               long a = p.level / 20;
               a = a == 0L ? 1L : a;
               long b = dame * a;
               long c = (mob_target.level - p.level) * a;
               exp_up_add = b / 2L + b * c / 100L;
               if (Math.abs(p.level - mob_target.level) >= 10) {
                  exp_up_add = 0L;
               }

               if (mob_target.mob_template.mob_id == 4
                  || mob_target.mob_template.mob_id == 10
                  || mob_target.mob_template.mob_id == 16
                  || mob_target.mob_template.mob_id == 23
                  || mob_target.mob_template.mob_id == 29
                  || mob_target.mob_template.mob_id == 36
                  || mob_target.mob_template.mob_id == 43
                  || mob_target.mob_template.mob_id == 68
                  || mob_target.mob_template.mob_id == 78
                  || mob_target.mob_template.mob_id == 92
                  || mob_target.mob_template.mob_id == 112
                  || mob_target.mob_template.mob_id == 163) {
                  exp_up_add = 0L;
               }

               exp_up[0] += exp_up_add;
               if (crit) {
                  dame_inf.data.add(new Option_Dame_Msg(1010, (int)dame_inf.dameP, 0));
               }

               list.add(dame_inf);
            }
         }

         if (list.size() > 0) {
            this.send_dame_msg(p, sk_temp.get_eff_skill(), list);
         }

         for (int ix = 0; ix < list.size(); ix++) {
            if (list.get(ix).targetM.isdie) {
               this.die_mob(list.get(ix).targetM);
            }
         }

         EffTemplate eff = p.get_eff(2);
         if (eff != null) {
            exp_up[0] *= 2L;
         }

         eff = p.get_eff(17);
         if (eff != null) {
            exp_up[0] *= 2L;
         }

         if (id_mob_die.size() > 0) {
            for (Entry<Integer, Integer> en : id_mob_die.entrySet()) {
               int id_mob = en.getKey();
               p.update_num_item_quest(1, id_mob, en.getValue());
            }
         }

         return exp_up;
      }
   }

   private void die_mob(Mob targetM) throws IOException {
      Message m = new Message(7);
      m.writer().writeShort(targetM.index);
      m.writer().writeByte(1);
      m.writer().writeShort(targetM.index);
      m.writer().writeByte(1);
      m.writer().writeShort(0);
      this.send_msg_all_p(m, null, true);
      m.cleanup();
   }

   private void send_dame_msg(Player p, short typeEffSkill, List<Dame_Msg> list) throws IOException {
      Message m = new Message(100);
      m.writer().writeShort(p.index_map);
      m.writer().writeByte(0);
      m.writer().writeInt(p.hp);
      m.writer().writeInt(p.mp);
      m.writer().writeShort(typeEffSkill);
      m.writer().writeByte(list.size());

      for (int j = 0; j < list.size(); j++) {
         Dame_Msg temp = list.get(j);
         if (temp.targetM != null) {
            m.writer().writeShort(temp.targetM.index);
            m.writer().writeByte(1);
            m.writer().writeInt((int)temp.dameP);
            m.writer().writeInt((int)temp.dameM);
            m.writer().writeInt(temp.targetM.hp);
            m.writer().writeByte(temp.data.size());

            for (int i = 0; i < temp.data.size(); i++) {
               m.writer().writeShort(temp.data.get(i).type);
               m.writer().writeShort(temp.data.get(i).hp);
               m.writer().writeShort(temp.data.get(i).time);
            }
         } else {
            m.writer().writeShort(temp.targetP.index_map);
            m.writer().writeByte(0);
            m.writer().writeInt((int)temp.dameP);
            m.writer().writeInt((int)temp.dameM);
            m.writer().writeInt(temp.targetP.hp);
            m.writer().writeByte(temp.data.size());

            for (int i = 0; i < temp.data.size(); i++) {
               m.writer().writeShort(temp.data.get(i).type);
               m.writer().writeShort(temp.data.get(i).hp);
               m.writer().writeShort(temp.data.get(i).time);
            }
         }
      }

      this.send_msg_all_p(m, p, true);
      m.cleanup();
   }

   public void send_msg_all_p(Message m, Player p, boolean all) throws IOException {
      for (int i = 0; i < this.players.size(); i++) {
         Player p0 = this.players.get(i);
         if (p0.conn == null) {
            synchronized (this) {
               this.players.remove(p0);
            }
         } else if (all || p != null && p0.index_map != p.index_map) {
            p0.conn.addmsg(m);
         }
      }
   }

   public void send_chat(Player p, Message m2) throws IOException {
      String s = m2.reader().readUTF();
      if (p.conn.user.equals("admin") && s.equals("admin")) {
         MenuController.send_dynamic_menu(
            p, 9999, "Menu Admin", new String[]{"Bảo trì", "1t Beri + 1t Ruby", "Uplevel", "setXP", "get item", "save data", "updateTB"}, null
         );
      } else {
         this.send_chat_popup(0, p.index_map, s);
      }
   }

   private void send_chat_popup(int type, int id_p, String s) throws IOException {
      Message m = new Message(17);
      switch (type) {
         case 0:
            m.writer().writeShort(id_p);
            m.writer().writeByte(0);
            m.writer().writeUTF(s);
            Player p0 = this.get_player_by_id_inmap(id_p);
            this.send_msg_all_p(m, p0, false);
         default:
            m.cleanup();
      }
   }

   public void send_in4_obj_inmap(Player p) throws IOException {
      if (this.template.npcs.size() > 0) {
         Message mnpc = new Message(16);
         mnpc.writer().writeByte(this.template.npcs.size());

         for (int i = 0; i < this.template.npcs.size(); i++) {
            Npc npc = this.template.npcs.get(i);
            mnpc.writer().writeShort(npc.iditem);
            mnpc.writer().writeUTF(npc.name);
            mnpc.writer().writeUTF(npc.namegt);
            mnpc.writer().writeUTF(npc.chat);
            mnpc.writer().writeShort(npc.x);
            mnpc.writer().writeShort(npc.y);
            mnpc.writer().writeByte(npc.isPerson);
            mnpc.writer().writeByte(npc.typeIcon);
            mnpc.writer().writeByte(npc.wBlock);
            mnpc.writer().writeByte(npc.hBlock);
            mnpc.writer().writeByte(npc.b3);
            if (npc.b3 == 0) {
               mnpc.writer().writeByte(npc.dataFrame[0]);
               mnpc.writer().writeByte(npc.dataFrame[1]);
            } else {
               mnpc.writer().writeShort(npc.head);
               mnpc.writer().writeShort(npc.hair);
               mnpc.writer().writeByte(npc.wearing.length);

               for (int j = 0; j < npc.wearing.length; j++) {
                  if (npc.wearing[j] == -1) {
                     mnpc.writer().writeByte(-1);
                  } else {
                     mnpc.writer().writeByte(1);
                     mnpc.writer().writeShort(npc.wearing[j]);
                  }
               }
            }
         }

         p.conn.addmsg(mnpc);
         mnpc.cleanup();
      }

      if (p.map_boss_info != null && is_map_boss(this.template.id)) {
         for (int ix = 0; ix < p.map_boss_info.mob.size(); ix++) {
            Mob mob = p.map_boss_info.mob.get(ix);
            if (mob != null && !mob.isdie) {
               Message m_local = new Message(1);
               m_local.writer().writeByte(1);
               m_local.writer().writeShort(mob.index);
               m_local.writer().writeShort(mob.x);
               m_local.writer().writeShort(mob.y);
               p.conn.addmsg(m_local);
               m_local.cleanup();
            }
         }
      }

      if (p.dungeon != null && is_map_dungeon(this.template.id)) {
         for (int ixx = 0; ixx < p.dungeon.mobs.size(); ixx++) {
            Mob mob = p.dungeon.mobs.get(ixx);
            if (mob != null && !mob.isdie && mob.map.equals(this)) {
               Message m_local = new Message(1);
               m_local.writer().writeByte(1);
               m_local.writer().writeShort(mob.index);
               m_local.writer().writeShort(mob.x);
               m_local.writer().writeShort(mob.y);
               p.conn.addmsg(m_local);
               m_local.cleanup();
            }
         }
      }

      if (this.template.id == 81 && this.map_little_garden != null) {
         for (int ixxx = 0; ixxx < this.map_little_garden.mobs.size(); ixxx++) {
            Mob mob = this.map_little_garden.mobs.get(ixxx);
            if (mob != null && mob.map.equals(this)) {
               Message m_local = new Message(1);
               m_local.writer().writeByte(1);
               m_local.writer().writeShort(mob.index);
               m_local.writer().writeShort(mob.x);
               m_local.writer().writeShort(mob.y);
               p.conn.addmsg(m_local);
               m_local.cleanup();
            }
         }
      }

      boolean haveBoss = false;

      for (int ixxxx = 0; ixxxx < Boss.ENTRYS.size(); ixxxx++) {
         if (!Boss.ENTRYS.get(ixxxx).mob.isdie && Boss.ENTRYS.get(ixxxx).mob.map.equals(p.map)) {
            Message m_local = new Message(1);
            m_local.writer().writeByte(1);
            m_local.writer().writeShort(Boss.ENTRYS.get(ixxxx).mob.index);
            m_local.writer().writeShort(Boss.ENTRYS.get(ixxxx).mob.x);
            m_local.writer().writeShort(Boss.ENTRYS.get(ixxxx).mob.y);
            p.conn.addmsg(m_local);
            m_local.cleanup();
            haveBoss = true;
            break;
         }
      }

      if (!haveBoss) {
         for (int ixxxxx = 0; ixxxxx < this.list_mob.length; ixxxxx++) {
            Mob mob = Mob.ENTRYS.get(this.list_mob[ixxxxx]);
            if (mob != null && !mob.isdie) {
               Message m_local = new Message(1);
               m_local.writer().writeByte(1);
               m_local.writer().writeShort(this.list_mob[ixxxxx]);
               m_local.writer().writeShort(mob.x);
               m_local.writer().writeShort(mob.y);
               p.conn.addmsg(m_local);
               m_local.cleanup();
            }
         }
      }

      p.ensureRuntimeState();
      if (!is_map_dont_show_other_info(this.template.id)) {
         for (int ixxxxxx = 0; ixxxxxx < this.players.size(); ixxxxxx++) {
            if (p.index_map != this.players.get(ixxxxxx).index_map) {
               Message m_local = new Message(1);
               m_local.writer().writeByte(0);
               m_local.writer().writeShort(this.players.get(ixxxxxx).index_map);
               m_local.writer().writeShort(this.players.get(ixxxxxx).x);
               m_local.writer().writeShort(this.players.get(ixxxxxx).y);
               p.conn.addmsg(m_local);
               m_local.cleanup();
               p.id_meet_in_map.add(this.players.get(ixxxxxx).index_map + "");
               if (this.players.get(ixxxxxx).ship_pet != null
                  && this.players.get(ixxxxxx).ship_pet.map != null
                  && this.players.get(ixxxxxx).ship_pet.map.equals(p.map)) {
                  m_local = new Message(1);
                  m_local.writer().writeByte(0);
                  m_local.writer().writeShort(this.players.get(ixxxxxx).ship_pet.index_map);
                  m_local.writer().writeShort(this.players.get(ixxxxxx).ship_pet.x);
                  m_local.writer().writeShort(this.players.get(ixxxxxx).ship_pet.y);
                  p.conn.addmsg(m_local);
                  m_local.cleanup();
               }
            }
         }

         boolean check = true;

         for (int ixxxxxxx = 0; ixxxxxxx < DataTemplate.mSea.length; ixxxxxxx++) {
            if (DataTemplate.mSea[ixxxxxxx][0] == this.template.id) {
               check = false;
               break;
            }
         }

         Message m_to_other = new Message(1);
         m_to_other.writer().writeByte(0);
         m_to_other.writer().writeShort(p.index_map);
         m_to_other.writer().writeShort(p.x);
         m_to_other.writer().writeShort(p.y);
         this.send_msg_all_p(m_to_other, p, check);
         m_to_other.cleanup();
      }

      if (p.party != null) {
         p.party.send_info();
      }

      p.change_new_date();
      p.update_info_to_all();
   }

   public void send_char_in4_inmap(Player p, short id) throws IOException {
      p.ensureRuntimeState();
      Player p0 = this.get_player_by_id_inmap(id);
      if (p0 != null) {
         p0.ensureRuntimeState();
         if (!p0.map.equals(p.map)) {
            return;
         }

         boolean new_enter = false;
         if (!p.id_meet_in_map.contains(p0.index_map + "")) {
            p.id_meet_in_map.add(p0.index_map + "");
            new_enter = true;
         }

         int dir_ = 1;
         Message m = new Message(-5);
         m.writer().writeShort(p0.index_map);
         m.writer().writeByte(0);
         m.writer().writeByte(0);
         m.writer().writeByte(p0.typePirate);
         m.writer().writeByte(p0.type_pk);
         m.writer().writeByte(new_enter ? dir_ : 0);
         m.writer().writeByte(-1);
         m.writer().writeUTF(p0.name);
         m.writer().writeShort(p0.level);
         m.writer().writeInt(p0.body.get_hp_max(true));
         m.writer().writeInt(p0.hp);
         m.writer().writeShort(p0.thongthao);
         m.writer().writeInt(BXH.get_rank_wanted(p0.name));
         m.writer().writeByte(p0.body.get_level_perfect());
         m.writer().writeByte(p0.clazz);
         m.writer().writeByte(-1);
         m.writer().writeByte(p0.item.it_heart != null ? p0.item.it_heart.levelup : 0);
         m.writer().writeShort(-1);
         m.writer().writeShort(-1);
         m.writer().writeShort(-1);
         p.conn.addmsg(m);
         m.cleanup();
         Service.pet(p0, p, false);
         Service.update_PK(p0, p, false);
         Service.update_PK(p, p0, false);
         Service.Weapon_fashion(p0, p, false);
         Service.getThanhTich(p0, p);
         Service.charWearing(p0, p, false);
         this.update_boat(p0, p, false);
         this.update_boat(p, p0, false);
         EffTemplate eff = p0.get_eff(7);
         if (eff != null) {
            Message m2 = new Message(-71);
            m2.writer().writeByte(1);
            m2.writer().writeShort(p0.index_map);
            m2.writer().writeByte(0);
            m2.writer().writeInt((int)((eff.time - System.currentTimeMillis()) / 1000L));
            p.conn.addmsg(m2);
            m2.cleanup();
         }

         if (p0.clan != null) {
            Clan.send_me_to_other(p0, p, false);
         }
      } else {
         Ship_pet spet = Ship_pet.get_pet(id);
         if (spet == null) {
            spet = p.ship_pet;
         }

         if (spet != null && spet.map != null && spet.map.equals(p.map)) {
            Message mx = new Message(-5);
            mx.writer().writeShort(spet.index_map);
            mx.writer().writeByte(0);
            mx.writer().writeByte(2);
            mx.writer().writeByte(spet.main_ship.typePirate);
            mx.writer().writeByte(-1);
            mx.writer().writeByte(1);
            mx.writer().writeByte(-1);
            mx.writer().writeUTF(spet.name);
            mx.writer().writeShort(1);
            mx.writer().writeInt(spet.hp_max);
            mx.writer().writeInt(spet.hp);
            mx.writer().writeShort(0);
            mx.writer().writeInt(-1);
            mx.writer().writeByte(0);
            mx.writer().writeShort(999);
            mx.writer().writeByte(1);
            mx.writer().writeShort(spet.main_ship.index_map);
            mx.writer().writeByte(spet.main_ship.typePirate);
            mx.writer().writeShort(-1);
            mx.writer().writeShort(-1);
            mx.writer().writeShort(-1);
            p.conn.addmsg(mx);
            mx.cleanup();
         }
      }
   }

   public Player get_player_by_id_inmap(int id) {
      Player p0 = null;

      for (int i = 0; i < this.players.size(); i++) {
         Player p01 = this.players.get(i);
         if (p01 != null && p01.index_map == id) {
            p0 = p01;
            break;
         }
      }

      return p0;
   }

   public static boolean map_cant_save_site(int id) {
      boolean check = false;

      for (int i = 0; i < DataTemplate.mSea.length; i++) {
         if (DataTemplate.mSea[i][1] == id) {
            check = true;
            break;
         }
      }

      return check
         || id == 64
         || id == 984
         || id == 1000
         || id == 9998
         || id == 9999
         || id == 115
         || id == 81
         || id == 120
         || id == 122
         || id == 123
         || id == 119
         || id == 58
         || is_map_boss(id)
         || is_map_dungeon(id);
   }

   public static boolean is_map_sea(int id) {
      return id == 7;
   }

   public void change_flag(Player p, int type) throws IOException {
      if (this.map_pvp == null && this.template.id != 1000) {
         if (p.type_pk == 1 && type == -1) {
            return;
         }

         if (p.pointPk >= 400 && type == -1) {
            type = 1;
         }
      } else if (type == 1) {
         type = -1;
      }

      if (p.clan != null && p.map.map_little_garden != null) {
         if (p.clan.equals(p.map.map_little_garden.clan1)) {
            type = 4;
         } else {
            type = 5;
         }
      }

      p.type_pk = (byte)type;

      for (int i = 0; i < this.players.size(); i++) {
         Player p0 = this.players.get(i);
         Service.update_PK(p, p0, false);
      }
   }

   public synchronized void pick_item(Player p, Message m2) throws IOException {
      if (!p.isdie && p.rms.length > 2 && p.rms[2].length > 0 && p.rms[2][0] == 0) {
      }

      short id = m2.reader().readShort();
      byte cat = m2.reader().readByte();
      byte code_response = -1;
      switch (cat) {
         case 3:
            for (int ixxx = 0; ixxx < this.list_it_map.length; ixxx++) {
               if (this.list_it_map[ixxx] != null && this.list_it_map[ixxx].category == cat && this.list_it_map[ixxx].index == id) {
                  if (this.list_it_map[ixxx].id_master == -1 || this.list_it_map[ixxx].id_master != -1 && this.list_it_map[ixxx].id_master == p.index_map) {
                     ItemTemplate3 temp3 = ItemTemplate3.get_it_by_id(this.list_it_map[ixxx].id);
                     if (temp3 != null && p.rms.length > 2 && p.rms[2].length > 3) {
                        if (p.rms[2][1] == 1 && temp3.color < 2) {
                        }

                        if (p.rms[2][1] == 2 && temp3.color < 3) {
                        }
                     }

                     if (temp3 != null) {
                        Item_wear it_add = new Item_wear();
                        it_add.setup_template_by_id(temp3);
                        if (it_add.template != null) {
                           if (!p.item.add_item_bag3(it_add)) {
                              return;
                           }

                           p.item.update_Inventory(-1, false);
                        }
                     }

                     this.list_it_map[ixxx] = null;
                     code_response = 0;
                  } else {
                     code_response = 1;
                  }
                  break;
               }
            }
            break;
         case 4:
            label300:
            for (int ix = 0; ix < this.list_it_map.length; ix++) {
               if (this.list_it_map[ix] != null && this.list_it_map[ix].category == cat && this.list_it_map[ix].index == id) {
                  if (this.template.id == 81 && this.map_little_garden != null) {
                     if (this.list_it_map[ix].id_master == -1 || this.list_it_map[ix].id_master != -1 && this.list_it_map[ix].id_master == p.index_map) {
                        switch (this.list_it_map[ix].id) {
                           case 94:
                              if (p.type_pk == 4) {
                                 for (int jx = 0; jx < this.players.size(); jx++) {
                                    Player p0 = this.players.get(jx);
                                    if (p0 != null && p0.conn != null && p0.type_pk == 5 && !p0.isdie) {
                                       this.die_player(p0, p);
                                       p0.time_hs_little_garden = System.currentTimeMillis() + 10000L;
                                       Service.send_time_cool_down(p0, p0.time_hs_little_garden, "Hồi sinh", 3);
                                    }
                                 }
                              } else {
                                 for (int jxx = 0; jxx < this.players.size(); jxx++) {
                                    Player p0 = this.players.get(jxx);
                                    if (p0 != null && p0.conn != null && p0.type_pk == 4 && !p0.isdie) {
                                       this.die_player(p0, p);
                                       p0.time_hs_little_garden = System.currentTimeMillis() + 10000L;
                                       Service.send_time_cool_down(p0, p0.time_hs_little_garden, "Hồi sinh", 3);
                                    }
                                 }
                              }
                              break;
                           case 95:
                              for (int j = 0; j < this.players.size(); j++) {
                                 Player p0 = this.players.get(j);
                                 if (p0 != null && p0.conn != null && p0.type_pk == p.type_pk && p0.isdie) {
                                    p0.time_hs_little_garden = 0L;
                                 }
                              }
                              break;
                           case 96:
                              LittleGarden.update_mp(this, p.type_pk, 0);
                              break;
                           case 97:
                              LittleGarden.update_mp(this, p.type_pk, 2);
                              break;
                           case 98:
                              LittleGarden.update_hp(this, p.type_pk, 2);
                              break;
                           case 99:
                              LittleGarden.update_mp(this, p.type_pk, 1);
                              break;
                           case 100:
                              LittleGarden.update_hp(this, p.type_pk, 1);
                        }

                        this.list_it_map[ix] = null;
                        code_response = 2;
                     } else {
                        code_response = 1;
                     }
                  } else {
                     for (int i2 = 0; i2 < LeaveItemMap.ITEM_POTION.length; i2++) {
                        if (LeaveItemMap.ITEM_POTION[i2] == this.list_it_map[ix].id || this.list_it_map[ix].id >= 7 && this.list_it_map[ix].id <= 17) {
                           if (this.list_it_map[ix].id_master == -1 || this.list_it_map[ix].id_master != -1 && this.list_it_map[ix].id_master == p.index_map) {
                              if (this.list_it_map[ix].id == 0) {
                                 if (p.rms.length > 2 && p.rms[2].length > 3 && p.rms[2][3] == 1) {
                                    return;
                                 }

                                 p.update_vang(this.list_it_map[ix].quant);
                                 p.update_money();
                              } else if (this.list_it_map[ix].id == 1) {
                                 if (p.rms.length > 2 && p.rms[2].length > 3 && p.rms[2][3] == 1) {
                                    return;
                                 }
                              } else {
                                 if (p.rms.length > 2 && p.rms[2].length > 3) {
                                    ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(this.list_it_map[ix].id);
                                    if (p.rms[2][2] == 1 && itemTemplate4.type != 1) {
                                       return;
                                    }

                                    if (p.rms[2][2] == 2 && itemTemplate4.type != 2) {
                                       return;
                                    }
                                 }

                                 if (!p.item.add_item_bag47(4, this.list_it_map[ix].id, this.list_it_map[ix].quant)) {
                                    return;
                                 }

                                 p.item.update_Inventory(-1, false);
                              }

                              this.list_it_map[ix] = null;
                              code_response = 0;
                           } else {
                              code_response = 1;
                           }
                           break label300;
                        }
                     }
                  }
                  break;
               }
            }
            break;
         case 5:
            for (int ixx = 0; ixx < this.list_it_map.length; ixx++) {
               if (this.list_it_map[ixx] != null && this.list_it_map[ixx].category == cat && this.list_it_map[ixx].index == id) {
                  if (this.list_it_map[ixx].id < DataTemplate.NamePotionquest.length) {
                     if (this.list_it_map[ixx].id_master == -1 || this.list_it_map[ixx].id_master != -1 && this.list_it_map[ixx].id_master == p.index_map) {
                        if (!p.item.add_item_bag47(5, this.list_it_map[ixx].id, this.list_it_map[ixx].quant)) {
                           return;
                        }

                        p.item.update_Inventory(-1, false);
                        p.update_num_item_quest(2, this.list_it_map[ixx].id, this.list_it_map[ixx].quant);
                        this.list_it_map[ixx] = null;
                        code_response = 0;
                     } else {
                        code_response = 1;
                     }
                  }
                  break;
               }
            }
         case 6:
         default:
            break;
         case 7:
            for (int i = 0; i < this.list_it_map.length; i++) {
               if (this.list_it_map[i] != null && this.list_it_map[i].category == cat && this.list_it_map[i].index == id) {
                  if (this.list_it_map[i].id_master == -1 || this.list_it_map[i].id_master != -1 && this.list_it_map[i].id_master == p.index_map) {
                     if (!p.item.add_item_bag47(7, this.list_it_map[i].id, this.list_it_map[i].quant)) {
                        return;
                     }

                     p.item.update_Inventory(-1, false);
                     this.list_it_map[i] = null;
                     code_response = 0;
                  } else {
                     code_response = 1;
                  }
                  break;
               }
            }
      }

      switch (code_response) {
         case -1:
            this.remove_obj(id, cat);
            break;
         case 0:
            Message m = new Message(12);
            m.writer().writeShort(id);
            m.writer().writeByte(cat);
            m.writer().writeShort(p.index_map);
            p.conn.addmsg(m);
            m.cleanup();
            this.remove_obj(id, cat);
            break;
         case 1:
            if (p.time_pick_item_other < System.currentTimeMillis()) {
               p.time_pick_item_other = System.currentTimeMillis() + 7000L;
               Message mnext = new Message(-31);
               mnext.writer().writeByte(0);
               mnext.writer().writeUTF("Vật phẩm của người khác");
               mnext.writer().writeByte(0);
               mnext.writer().writeShort(-1);
               p.conn.addmsg(mnext);
               mnext.cleanup();
            }
            break;
         case 2:
            if (this.map_little_garden != null && !this.map_little_garden.is_finish && (p.type_pk == 4 || p.type_pk == 5)) {
               Message mx = new Message(33);
               mx.writer().writeShort(id);
               mx.writer().writeByte(cat);
               mx.writer().writeByte(p.type_pk == 4 ? 0 : 1);
               p.conn.addmsg(mx);
               mx.cleanup();
            }
      }
   }

   public void send_data(Player p) throws IOException {
      Message m = new Message(0);
      m.writer().writeShort(this.template.id);
      m.writer().writeByte(this.zone_id);
      m.writer().writeByte(this.template.type_view_p);
      m.writer().writeShort(p.x);
      m.writer().writeShort(p.y);
      m.writer().writeInt(p.body.get_hp_max(true));
      m.writer().writeInt(p.hp);
      m.writer().writeInt(p.body.get_mp_max(true));
      m.writer().writeInt(p.mp);
      m.writer().writeByte(this.template.b);
      m.writer().writeByte(this.template.specMap);
      if (this.template.b == 1) {
         m.writer().writeInt(this.template.data[0].length);
         m.writer().write(this.template.data[0]);
         m.writer().writeInt(this.template.data[1].length);
         m.writer().write(this.template.data[1]);
         m.writer().writeByte(this.template.vgos.size());

         for (int i = 0; i < this.template.vgos.size(); i++) {
            m.writer().writeUTF(this.template.vgos.get(i).map_go[0].template.name);
            m.writer().writeShort(this.template.vgos.get(i).xold);
            m.writer().writeShort(this.template.vgos.get(i).yold);
         }
      }

      m.writer().writeByte(this.template.IDBack);
      m.writer().writeShort(this.template.HBack);
      m.writer().writeByte(this.template.id_eff_map);
      m.writer().writeByte(this.template.level);
      m.writer().writeByte(this.template.typeChangeMap);
      if (this.template.specMap == 3) {
         m.writer().writeByte(this.template.mPosMapTrain.length);

         for (int i = 0; i < this.template.mPosMapTrain.length; i++) {
            for (int j = 0; j < this.template.mPosMapTrain[i].length; j++) {
               m.writer().writeByte(this.template.mPosMapTrain[i][j]);
            }
         }

         m.writer().writeUTF(this.template.strTimeChange);
      }

      m.writer().writeUTF(this.template.name);
      p.conn.addmsg(m);
      m.cleanup();
   }

   public void goto_map(Player p) throws IOException {
      if (p.conn != null) {
         this.enter_map(p);
         this.send_data(p);
         boolean send_move = true;

         for (int i = 0; i < DataTemplate.mSea.length; i++) {
            if (DataTemplate.mSea[i][0] == this.template.id) {
               send_move = false;
               break;
            }
         }

         if (send_move) {
            Message mmove = new Message(1);
            mmove.writer().writeByte(0);
            mmove.writer().writeShort(p.index_map);
            mmove.writer().writeShort(p.x);
            mmove.writer().writeShort(p.y);
            p.list_msg_cache.add(mmove);
            mmove.cleanup();
         }

         if (is_map_save_revival(this.template.id)) {
            p.id_map_save = this.template.id;
            p.time_can_hs = 7;
         }
      }
   }

   private static boolean is_map_save_revival(int id) {
      for (int i = 0; i < MenuController.ID_MAP_LANG.length; i++) {
         if (id == MenuController.ID_MAP_LANG[i] && id != 113 && id != 79 && id != 191) {
            return true;
         }
      }

      return false;
   }

   public void send_boat(Player p, boolean is_have_my_boat) throws IOException {
      for (int i = 0; i < DataTemplate.mSea.length; i++) {
         if (DataTemplate.mSea[i][0] == this.template.id) {
            Message m = new Message(-56);
            int size = is_have_my_boat ? this.template.list_boat.size() : this.template.list_boat.size() - 1;
            m.writer().writeByte(size);
            if (is_have_my_boat) {
               m.writer().writeShort(p.index_map);
               m.writer().writeShort(this.template.list_boat.get(0).x);
               m.writer().writeShort(this.template.list_boat.get(0).y);
               m.writer().writeByte(4);
               m.writer().writeShort(0);
               m.writer().writeShort(1);
               m.writer().writeShort(2);
               m.writer().writeShort(3);
            }

            for (int j = 1; j < this.template.list_boat.size(); j++) {
               m.writer().writeShort(-1);
               m.writer().writeShort(this.template.list_boat.get(j).x);
               m.writer().writeShort(this.template.list_boat.get(j).y);
               m.writer().writeByte(0);
            }

            p.list_msg_cache.add(m);
            m.cleanup();
            break;
         }
      }
   }

   public void enter_zone(Player p) throws IOException {
      p.ischangemap = false;
      p.xold = p.x;
      p.yold = p.y;
      Message m = new Message(21);
      m.writer().writeByte(this.zone_id);
      m.writer().writeByte(0);
      m.writer().writeShort(p.x);
      m.writer().writeShort(p.y);
      m.writer().writeInt(p.body.get_hp_max(true));
      m.writer().writeInt(p.hp);
      m.writer().writeInt(p.body.get_mp_max(true));
      m.writer().writeInt(p.mp);
      m.writer().writeByte(p.map.template.IDBack);
      m.writer().writeShort(p.map.template.HBack);
      p.conn.addmsg(m);
      m.cleanup();
      Service.update_PK(p, p, true);
      Service.pet(p, p, true);
      this.send_boat(p, true);
      this.update_boat(p, p, true);
   }

   public void update_boat(Player p0, Player p, boolean cache) throws IOException {
      boolean check = false;

      for (int i = 0; i < DataTemplate.mSea.length; i++) {
         if (DataTemplate.mSea[i][1] == this.template.id) {
            check = true;
            break;
         }
      }

      if (!check && p0.map.template.id != 984) {
         Message m = new Message(-33);
         m.writer().writeByte(0);
         byte[] rmsData = new byte[0];
         if (p.rms != null && p.rms.length > 0 && p.rms[0] != null) {
            rmsData = p.rms[0];
         }

         m.writer().writeShort(rmsData.length);
         if (rmsData.length > 0) {
            m.writer().write(rmsData);
         }

         if (cache) {
            p.list_msg_cache.add(m);
         } else {
            p.conn.addmsg(m);
         }

         m.cleanup();
      } else {
         Message mx = new Message(-62);
         mx.writer().writeShort(p0.index_map);
         mx.writer().writeByte(0);
         mx.writer().writeByte(4);
         short[] part_boat = p0.get_part_boat();
         mx.writer().writeShort(part_boat[0]);
         mx.writer().writeShort(part_boat[1]);
         mx.writer().writeShort(part_boat[2]);
         mx.writer().writeShort(part_boat[3]);
         if (cache) {
            p.list_msg_cache.add(mx);
         } else {
            p.conn.addmsg(mx);
         }

         mx.cleanup();
      }
   }

   public int get_index_item_map() {
      for (int i = 0; i < this.list_it_map.length; i++) {
         if (this.list_it_map[i] == null) {
            return i;
         }
      }

      return -1;
   }

   public void send_weather(Player p) throws IOException {
      if (p.map.template.id_eff_map == -1) {
         Message m = new Message(-47);
         m.writer().writeByte(weather);
         m.writer().writeByte(weather_level);
         p.conn.addmsg(m);
         m.cleanup();
      }
   }

   public Mob get_mobs(int id, int type) {
      switch (type) {
         case 0:
            if (this.map_little_garden != null) {
               for (int i = 0; i < this.map_little_garden.mobs.size(); i++) {
                  if (this.map_little_garden.mobs.get(i).index == id) {
                     return this.map_little_garden.mobs.get(i);
                  }
               }
            }
         default:
            return null;
      }
   }
}
