package core;

import activities.LittleGarden;
import client.Clan;
import client.Player;
import database.SQL;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import map.Boss;
import map.Map;
import map.Mob;
import map.Vgo;
import org.joda.time.LocalTime;
import template.Map_Little_Garden;

public class ServerEventManager {
   private Thread thread_cal_time;
   private Thread thread_save_data;
   private boolean running;
   private final HashMap<String, Boolean> eventEnabled = new HashMap<>();
   private long nextEventConfigReload;

   public ServerEventManager() {
      this.running = false;
   }

   public void close() {
      this.running = false;
      this.thread_save_data.interrupt();
   }

   public void init() {
      this.running = true;
      this.loadEventConfig();
      this.thread_cal_time = new Thread(
         () -> {
            while (this.running) {
               try {
                  LocalTime now = LocalTime.now();
                  int hour = now.getHourOfDay();
                  int min = now.getMinuteOfHour();
                  int sec = now.getSecondOfMinute();
                  int millis = now.getMillisOfSecond();
                  if (System.currentTimeMillis() >= this.nextEventConfigReload) {
                     this.loadEventConfig();
                  }

                  if (this.isEventEnabled("daily_reset") && hour == 0 && min == 0 && sec == 0) {
                     for (Map[] map_all : Map.ENTRYS) {
                        for (Map map : map_all) {
                           for (int i = 0; i < map.players.size(); i++) {
                              map.players.get(i).change_new_date();
                           }
                        }
                     }

                     List<Map> mapplus = Map.get_map_plus();

                     for (int i = 0; i < mapplus.size(); i++) {
                        for (int i12 = 0; i12 < mapplus.get(i).players.size(); i12++) {
                           Player p0 = mapplus.get(i).players.get(i12);
                           p0.change_new_date();
                        }
                     }

                     Clan.reset_day();
                     LittleGarden.LIST.clear();
                  }

                  if (this.isEventEnabled("super_boss") && hour == 18 && min == 0 && sec == 0) {
                     Boss.create_boss();
                  }

                  if (this.isEventEnabled("super_boss") && hour == 19 && min == 0 && sec == 0) {
                     Boss.result_boss();
                  }

                  if (this.isEventEnabled("super_boss") && hour == 22 && min == 0 && sec == 0) {
                     Boss.create_boss();
                  }

                  if (this.isEventEnabled("super_boss") && hour == 23 && min == 0 && sec == 0) {
                     Boss.result_boss();
                  }

                  if (sec % 1 == 0) {
                     for (Map[] mapall : Map.ENTRYS) {
                        for (Map map : mapall) {
                           for (int i = 0; i < map.players.size(); i++) {
                              Player p0 = map.players.get(i);

                              try {
                                 p0.update_eff();
                              } catch (Exception var19) {
                              }
                           }
                        }
                     }

                     List<Map> mapplus = Map.get_map_plus();

                     for (int i = 0; i < mapplus.size(); i++) {
                        for (int i12 = 0; i12 < mapplus.get(i).players.size(); i12++) {
                           Player p0 = mapplus.get(i).players.get(i12);

                           try {
                              p0.update_eff();
                           } catch (Exception var18) {
                           }
                        }
                     }

                     if (this.isEventEnabled("tai_xiu")) {
                        Manager.gI().TaiXiu().upTime();
                     }
                  }

                  if (this.isEventEnabled("little_garden")
                     && sec % 5 == 0
                     && (Util.is_DayofWeek(2) || Util.is_DayofWeek(4) || Util.is_DayofWeek(6))
                     && hour == 21
                     && LittleGarden.LIST.size() > 1) {
                     int index = Util.random(LittleGarden.LIST.size());
                     Clan clan1 = LittleGarden.LIST.get(index);
                     LittleGarden.remove_clan_wait(clan1);
                     index = Util.random(LittleGarden.LIST.size());
                     Clan clan2 = LittleGarden.LIST.get(index);
                     LittleGarden.remove_clan_wait(clan2);
                     Player p1 = null;
                     Player p2 = null;

                     for (int i = 0; i < clan1.members.size(); i++) {
                        if (clan1.members.get(i).levelInclan == 0 || clan1.members.get(i).levelInclan == 1) {
                           Player p0 = Map.get_player_by_name_allmap(clan1.members.get(i).name);
                           if (p0 != null) {
                              p1 = p0;
                              break;
                           }
                        }
                     }

                     for (int ix = 0; ix < clan2.members.size(); ix++) {
                        if (clan2.members.get(ix).levelInclan == 0 || clan2.members.get(ix).levelInclan == 1) {
                           Player p0 = Map.get_player_by_name_allmap(clan2.members.get(ix).name);
                           if (p0 != null) {
                              p2 = p0;
                              break;
                           }
                        }
                     }

                     if (p1 != null && p2 != null && p1.name.equals(p2.name)) {
                        LittleGarden.add_clan_wait(clan1);
                     } else if (p1 != null && p2 != null) {
                        int index_mob = -2;
                        Map mapTemplate = Map.get_map_by_id(81)[0];
                        Map map_dungeon = new Map();
                        map_dungeon.template = mapTemplate.template;
                        map_dungeon.zone_id = 0;
                        map_dungeon.list_mob = new int[0];
                        map_dungeon.map_little_garden = new Map_Little_Garden();
                        map_dungeon.map_little_garden.mobs = new ArrayList<>();
                        map_dungeon.map_little_garden.time = System.currentTimeMillis() + 900000L;
                        map_dungeon.map_little_garden.clan1 = clan1;
                        map_dungeon.map_little_garden.clan2 = clan2;
                        clan1.map_create = map_dungeon;
                        clan2.map_create = map_dungeon;

                        for (int ixx = 0; ixx < mapTemplate.list_mob.length; ixx++) {
                           Mob temp = Mob.ENTRYS.get(mapTemplate.list_mob[ixx]);
                           Mob mob_add = new Mob();
                           mob_add.mob_template = temp.mob_template;
                           mob_add.x = temp.x;
                           mob_add.y = temp.y;
                           mob_add.hp_max = temp.mob_template.hp_max;
                           mob_add.hp = mob_add.hp_max;
                           mob_add.level = 75;
                           mob_add.isdie = false;
                           mob_add.id_target = -1;
                           mob_add.index = index_mob--;
                           mob_add.map = map_dungeon;
                           mob_add.boss_info = null;
                           map_dungeon.map_little_garden.mobs.add(mob_add);
                        }

                        map_dungeon.start_map();
                        Map.add_map_plus(map_dungeon);
                        Vgo vgo = new Vgo();
                        vgo.map_go = new Map[1];
                        vgo.map_go[0] = map_dungeon;
                        vgo.xnew = 350;
                        vgo.ynew = 260;
                        List<Player> list_remove_table_tick = new ArrayList<>();

                        for (int ixx = 0; ixx < p1.tableTickOption.listP.size(); ixx++) {
                           Player p0 = p1.tableTickOption.listP.get(ixx);
                           if (p0 != null && p0.conn != null && p1.tableTickOption.list_check[ixx] == 1) {
                              list_remove_table_tick.add(p0);
                              p0.type_pk = 4;
                              p0.goto_map(vgo);
                           }
                        }

                        for (int ixxx = 0; ixxx < p2.tableTickOption.listP.size(); ixxx++) {
                           Player p0 = p2.tableTickOption.listP.get(ixxx);
                           if (p0 != null && p0.conn != null && p2.tableTickOption.list_check[ixxx] == 1) {
                              list_remove_table_tick.add(p0);
                              p0.type_pk = 5;
                              p0.goto_map(vgo);
                           }
                        }

                        list_remove_table_tick.forEach(l -> l.tableTickOption = null);
                     } else if (p1 != null) {
                        LittleGarden.add_clan_wait(clan1);
                     } else if (p2 != null) {
                        LittleGarden.add_clan_wait(clan2);
                     }
                  }

                  long time_sleep = 1000 - millis;
                  if (time_sleep > 0L) {
                     if (time_sleep < 100L) {
                        System.err.println("server time update process is overloading...");
                     }

                     Thread.sleep(time_sleep);
                  }
               } catch (InterruptedException var20) {
               } catch (Exception var21) {
                  var21.printStackTrace();
                  System.out.println("exception at server update rigth time " + var21.getMessage());
               }
            }
         }
      );
      this.thread_cal_time.start();
      this.thread_save_data = new Thread(() -> {
         while (this.running) {
            try {
               Thread.sleep(50000L);
               SaveData.process();
            } catch (Exception var2) {
               var2.printStackTrace();
               System.err.println("err thread save data");
            }
         }
      });
      this.thread_save_data.start();
   }

   private boolean isEventEnabled(String eventKey) {
      Boolean enabled = this.eventEnabled.get(eventKey);
      return enabled == null || enabled;
   }

   private void loadEventConfig() {
      this.nextEventConfigReload = System.currentTimeMillis() + 30000L;
      Connection c = null;
      Statement st = null;
      PreparedStatement ps = null;
      ResultSet rs = null;

      try {
         c = SQL.gI().getCon();
         st = c.createStatement();
         st.executeUpdate(
            "CREATE TABLE IF NOT EXISTS `event_config` (`event_key` VARCHAR(50) NOT NULL,`event_name` VARCHAR(120) NOT NULL,`description` TEXT NULL,`enabled` TINYINT NOT NULL DEFAULT 1,`updated_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,PRIMARY KEY (`event_key`)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci"
         );
         ps = c.prepareStatement("INSERT IGNORE INTO `event_config` (`event_key`, `event_name`, `description`, `enabled`) VALUES (?, ?, ?, 1)");
         this.insertDefaultEvent(ps, "daily_reset", "Reset ngày", "Làm mới lượt ngày, clan và dữ liệu hoạt động lúc 00:00.");
         this.insertDefaultEvent(ps, "super_boss", "Săn siêu trùm", "Tự mở boss lúc 18:00-19:00 và 22:00-23:00.");
         this.insertDefaultEvent(ps, "little_garden", "Little Garden / Clan", "Ghép clan tham gia Little Garden vào 21:00 thứ 2, 4, 6.");
         this.insertDefaultEvent(ps, "tai_xiu", "Tài xỉu", "Cho phép vòng thời gian mini game Tài xỉu hoạt động.");
         rs = st.executeQuery("SELECT `event_key`, `enabled` FROM `event_config`");
         HashMap<String, Boolean> loaded = new HashMap<>();

         while (rs.next()) {
            loaded.put(rs.getString("event_key"), rs.getInt("enabled") == 1);
         }

         synchronized (this.eventEnabled) {
            this.eventEnabled.clear();
            this.eventEnabled.putAll(loaded);
         }
      } catch (Exception var30) {
         System.err.println("[EventConfig] Could not load event config: " + var30.getMessage());
      } finally {
         try {
            if (rs != null) {
               rs.close();
            }
         } catch (Exception var28) {
         }

         try {
            if (ps != null) {
               ps.close();
            }
         } catch (Exception var27) {
         }

         try {
            if (st != null) {
               st.close();
            }
         } catch (Exception var26) {
         }

         try {
            if (c != null) {
               c.close();
            }
         } catch (Exception var25) {
         }
      }
   }

   private void insertDefaultEvent(PreparedStatement ps, String key, String name, String description) throws Exception {
      ps.setString(1, key);
      ps.setString(2, name);
      ps.setString(3, description);
      ps.executeUpdate();
   }
}
