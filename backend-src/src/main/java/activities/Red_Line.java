package activities;

import client.Player;
import core.Util;
import io.Message;
import java.io.File;
import java.io.IOException;
import java.util.Arrays;
import java.util.Comparator;
import map.Map;
import map.Vgo;
import template.EffTemplate;

public class Red_Line {
   public static byte[][] KEY0;
   public static byte[][] KEY2;
   public static byte[][] KEY3;
   public static byte[][] KEY4;

   public static void process(Player p, Message m2) throws IOException {
      byte type = m2.reader().readByte();
      byte key = m2.reader().readByte();
      if (p.map.template.id == 64 && type == 0) {
         switch (key) {
            case 0:
            case 1:
            case 2:
            case 3:
               try {
                  if (p.key_red_line.size() > 0 && p.key_red_line.take() != key) {
                     end(p, 1);
                  }
               } catch (InterruptedException var5) {
                  var5.printStackTrace();
               }

               if (p.time_key_red_line != -1 && p.key_red_line.size() == 0) {
                  p.time_key_red_line--;
                  if (p.time_key_red_line == -1) {
                     end(p, 2);
                  } else {
                     init_key(p);
                  }
               }
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            default:
               break;
            case 10:
               if (p.time_key_red_line == -1) {
                  p.time_key_red_line = Util.random(4, 7);
                  init_key(p);
               } else if (p.key_red_line.size() == 0) {
                  init_key(p);
               } else {
                  end(p, 1);
               }
         }
      }
   }

   private static void end(Player p, int status) throws IOException {
      Message m = new Message(-72);
      m.writer().writeByte(status);
      p.conn.addmsg(m);
      m.cleanup();
      Vgo vgo = new Vgo();
      if (status == 2) {
         Map[] map_go = Map.get_map_by_id(65);
         vgo.map_go = map_go;
         vgo.xnew = 136;
         vgo.ynew = 230;
      } else {
         Map[] map_go = Map.get_map_by_id(63);
         vgo.map_go = map_go;
         vgo.xnew = 1515;
         vgo.ynew = 285;
      }

      p.key_red_line.clear();
      p.time_key_red_line = -1;

      try {
         Thread.sleep(2500L);
      } catch (InterruptedException var5) {
         throw new RuntimeException(var5);
      }

      p.goto_map(vgo);
   }

   private static void init_key(Player p) throws IOException {
      if (p.key_red_line.size() > 0) {
         p.key_red_line.clear();
      }

      int key_size = Util.random(3, 7);
      Message m = new Message(-72);
      m.writer().writeByte(0);
      m.writer().writeByte(key_size);

      for (int i = 0; i < key_size; i++) {
         int index = Util.random(KEY2.length);
         p.key_red_line.add(index % 4);
         switch (p.conn.zoomlv) {
            case 2:
               m.writer().writeInt(KEY2[index].length);
               m.writer().write(KEY2[index]);
               break;
            case 3:
               m.writer().writeInt(KEY3[index].length);
               m.writer().write(KEY3[index]);
               break;
            case 4:
               m.writer().writeInt(KEY4[index].length);
               m.writer().write(KEY4[index]);
               break;
            default:
               m.writer().writeInt(KEY0[index].length);
               m.writer().write(KEY0[index]);
         }
      }

      m.writer().writeInt(2000 * key_size);
      p.conn.addmsg(m);
      m.cleanup();
   }

   public static void init_key_TTVT(Player p) throws IOException {
      if (p.key_red_line.size() > 0) {
         p.key_red_line.clear();
      }

      int key_size = Util.random(3, 8);
      Message m = new Message(-72);
      m.writer().writeByte(3);
      m.writer().writeByte(key_size);

      for (int i = 0; i < key_size; i++) {
         int index = Util.random(KEY2.length);
         p.key_red_line.add(index % 4);
         switch (p.conn.zoomlv) {
            case 2:
               m.writer().writeInt(KEY2[index].length);
               m.writer().write(KEY2[index]);
               break;
            case 3:
               m.writer().writeInt(KEY3[index].length);
               m.writer().write(KEY3[index]);
               break;
            case 4:
               m.writer().writeInt(KEY4[index].length);
               m.writer().write(KEY4[index]);
               break;
            default:
               m.writer().writeInt(KEY0[index].length);
               m.writer().write(KEY0[index]);
         }
      }

      m.writer().writeInt(1800 * key_size);
      p.conn.addmsg(m);
      m.cleanup();
      EffTemplate eff = p.get_eff(20);
      if (eff != null) {
         eff.time = System.currentTimeMillis() + 1800 * key_size + 1000L;
      } else {
         p.add_new_eff(20, 1, 1800 * key_size + 1000L);
      }
   }

   public static void process_TTVT(Player p, Message m2) throws IOException {
      byte type = m2.reader().readByte();
      byte key = m2.reader().readByte();
      if (p.map.map_ThuThachVeThan != null && !p.map.map_ThuThachVeThan.isFinish && type == 3) {
         switch (key) {
            case 0:
            case 1:
            case 2:
            case 3:
               boolean isPressOK = false;

               try {
                  if (p.key_red_line.size() > 0) {
                     if (p.key_red_line.take() != key) {
                        end_TTVT(p, 4);
                     } else {
                        isPressOK = true;
                     }
                  }
               } catch (InterruptedException var6) {
                  var6.printStackTrace();
               }

               if (isPressOK && p.time_key_red_line != -1 && p.key_red_line.size() == 0) {
                  p.time_key_red_line--;
                  if (p.time_key_red_line == -1) {
                     end_TTVT(p, 5);
                  } else if (p.map.map_ThuThachVeThan.okP(p)) {
                     for (int i = 0; i < p.map.players.size(); i++) {
                        init_key_TTVT(p.map.players.get(i));
                     }

                     p.map.map_ThuThachVeThan.update_okP();
                  }
               }
         }
      }
   }

   private static void end_TTVT(Player p, int status) throws IOException {
      Message m = new Message(-72);
      m.writer().writeByte(status);

      for (int i = 0; i < p.map.players.size(); i++) {
         p.map.players.get(i).conn.addmsg(m);
      }

      m.cleanup();
      p.map.map_ThuThachVeThan.time_state = System.currentTimeMillis() + 3000L;
      p.map.map_ThuThachVeThan.isFinish = true;
      if (status == 5) {
         p.map.map_ThuThachVeThan.isReceiv = true;
      }
   }

   static {
      File folder = new File("data/red_line/x2");
      if (folder.isDirectory()) {
         File[] files = folder.listFiles();
         Arrays.sort(files, new Comparator<File>() {
            public int compare(File o1, File o2) {
               int a1 = Integer.parseInt(o1.getName().split("\\.")[0]);
               int a2 = Integer.parseInt(o2.getName().split("\\.")[0]);
               return a1 > a2 ? 1 : -1;
            }
         });
         KEY2 = new byte[files.length][];

         try {
            for (int i = 0; i < KEY2.length; i++) {
               File f = files[i];
               KEY2[i] = Util.loadfile(f.getAbsolutePath());
            }
         } catch (IOException var7) {
            var7.printStackTrace();
            System.exit(0);
         }
      }

      folder = new File("data/red_line/x0");
      if (folder.isDirectory()) {
         File[] files = folder.listFiles();
         Arrays.sort(files, new Comparator<File>() {
            public int compare(File o1, File o2) {
               int a1 = Integer.parseInt(o1.getName().split("\\.")[0]);
               int a2 = Integer.parseInt(o2.getName().split("\\.")[0]);
               return a1 > a2 ? 1 : -1;
            }
         });
         KEY0 = new byte[files.length][];

         try {
            for (int i = 0; i < KEY0.length; i++) {
               File f = files[i];
               KEY0[i] = Util.loadfile(f.getAbsolutePath());
            }
         } catch (IOException var6) {
            var6.printStackTrace();
            System.exit(0);
         }
      }

      folder = new File("data/red_line/x3");
      if (folder.isDirectory()) {
         File[] files = folder.listFiles();
         Arrays.sort(files, new Comparator<File>() {
            public int compare(File o1, File o2) {
               int a1 = Integer.parseInt(o1.getName().split("\\.")[0]);
               int a2 = Integer.parseInt(o2.getName().split("\\.")[0]);
               return a1 > a2 ? 1 : -1;
            }
         });
         KEY3 = new byte[files.length][];

         try {
            for (int i = 0; i < KEY3.length; i++) {
               File f = files[i];
               KEY3[i] = Util.loadfile(f.getAbsolutePath());
            }
         } catch (IOException var5) {
            var5.printStackTrace();
            System.exit(0);
         }
      }

      folder = new File("data/red_line/x2");
      if (folder.isDirectory()) {
         File[] files = folder.listFiles();
         Arrays.sort(files, new Comparator<File>() {
            public int compare(File o1, File o2) {
               int a1 = Integer.parseInt(o1.getName().split("\\.")[0]);
               int a2 = Integer.parseInt(o2.getName().split("\\.")[0]);
               return a1 > a2 ? 1 : -1;
            }
         });
         KEY4 = new byte[files.length][];

         try {
            for (int i = 0; i < KEY4.length; i++) {
               File f = files[i];
               KEY4[i] = Util.loadfile(f.getAbsolutePath());
            }
         } catch (IOException var4) {
            var4.printStackTrace();
            System.exit(0);
         }
      }
   }
}
