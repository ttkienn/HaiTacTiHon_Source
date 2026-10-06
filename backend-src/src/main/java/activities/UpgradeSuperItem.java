package activities;

import client.Player;
import core.Manager;
import core.Service;
import core.Util;
import io.Message;
import java.io.IOException;
import template.ItemTemplate7;
import template.Item_wear;

public class UpgradeSuperItem {
   public static int[][] MATERIAL = new int[][]{
      {100, 15, 2000000, 30},
      {100, 20, 2500000, 30},
      {100, 25, 3000000, 50},
      {100, 30, 3200000, 50},
      {100, 35, 3500000, 50},
      {100, 40, 4000000, 70},
      {100, 45, 4500000, 70},
      {100, 50, 4500000, 70}
   };

   public static void show_table(Player p) throws IOException {
      Message m = new Message(66);
      m.writer().writeByte(7);
      p.conn.addmsg(m);
      m.cleanup();
      p.data_super_upgrade = new int[]{-1, 0, 0, 0};
   }

   public static void process(Player p, Message m2) throws IOException {
      byte type = m2.reader().readByte();
      short id = m2.reader().readShort();
      byte beri_gem = m2.reader().readByte();
      byte num = m2.reader().readByte();
      if (type == 4 && beri_gem == 0 && num == 0) {
         Item_wear it_select = p.item.bag3[id];
         if (it_select != null) {
            if (!check_it_can_upgrade_super(p, it_select)) {
               return;
            }

            Message m = new Message(66);
            m.writer().writeByte(4);
            m.writer().writeShort(id);
            m.writer().writeShort(it_select.template.color == 3 ? 4 : 3);
            m.writer().writeShort(get_material(1, it_select));
            m.writer().writeShort(1);
            m.writer().writeShort(get_material(0, it_select));
            p.conn.addmsg(m);
            m.cleanup();
            p.data_super_upgrade[0] = id;
         }
      } else if (type == 6 && id == 6 && (beri_gem == 1 || beri_gem == 0)) {
         if (num > 0 && p.item.total_item_bag_by_id(7, 6) < num || num > 5 || num < 0) {
            return;
         }

         Message m = new Message(66);
         m.writer().writeByte(6);
         m.writer().writeByte(num);
         m.writer().writeShort(id);
         m.writer().writeByte(num);
         p.conn.addmsg(m);
         m.cleanup();
         p.data_super_upgrade[1] = num;
      } else if (type == 14 && id == 10 && (beri_gem == 1 || beri_gem == 0) && num == 1) {
         if (beri_gem > 0 && p.item.total_item_bag_by_id(7, 10) < beri_gem) {
            return;
         }

         Message m = new Message(66);
         m.writer().writeByte(14);
         m.writer().writeByte(beri_gem);
         m.writer().writeShort(id);
         p.conn.addmsg(m);
         m.cleanup();
         p.data_super_upgrade[2] = beri_gem;
      } else if (type == 5 && id == 11 && (beri_gem == 1 || beri_gem == 0) && num == 1) {
         if (beri_gem > 0 && p.item.total_item_bag_by_id(7, 11) < beri_gem) {
            return;
         }

         Message m = new Message(66);
         m.writer().writeByte(5);
         m.writer().writeByte(beri_gem);
         m.writer().writeShort(id);
         p.conn.addmsg(m);
         m.cleanup();
         p.data_super_upgrade[3] = beri_gem;
      } else if (type == 1 && beri_gem == 0 && num == 0) {
         Item_wear it_select = p.item.bag3[id];
         if (it_select != null) {
            if (!check_it_can_upgrade_super(p, it_select)) {
               return;
            }

            Message m = new Message(66);
            m.writer().writeByte(1);
            m.writer().writeUTF("Bạn có muốn cường hóa vật phẩm " + it_select.template.name + " lên cấp " + (it_select.levelup + 1));
            m.writer().writeInt(get_material(2, it_select));
            m.writer().writeShort(get_material(3, it_select));
            m.writer().writeShort(id);
            p.conn.addmsg(m);
            m.cleanup();
         }
      } else if (type == 7 && id == 0 && beri_gem == 0 && num == 0) {
         show_table(p);
      } else if (type == 2 && (beri_gem == 1 || beri_gem == 2) && num == 0) {
         Item_wear it_select = p.item.bag3[id];
         if (it_select != null) {
            if (!check_it_can_upgrade_super(p, it_select)) {
               return;
            }

            if (it_select.levelup >= 15) {
               Service.send_box_ThongBao_OK(p, "Trang bị đã Cường hóa cấp tối đa!");
               return;
            }

            if (it_select.template.typeEquip > 7) {
               Service.send_box_ThongBao_OK(p, "Trang bị này không thể nâng cấp!");
               return;
            }

            int material_0 = get_material(0, it_select);
            int material_1 = get_material(1, it_select);
            if (p.item.total_item_bag_by_id(7, 1) < material_0) {
               Service.send_box_ThongBao_OK(p, "Không đủ " + material_0 + " " + ItemTemplate7.get_it_by_id(1).name);
               return;
            }

            int id_matrial_1 = it_select.template.color == 3 ? 4 : 3;
            if (p.item.total_item_bag_by_id(7, id_matrial_1) < material_1) {
               Service.send_box_ThongBao_OK(p, "Không đủ " + material_1 + " " + ItemTemplate7.get_it_by_id(id_matrial_1).name);
               return;
            }

            if (beri_gem == 1) {
               int vang_req = get_material(2, it_select);
               if (p.get_vang() < vang_req) {
                  Service.send_box_ThongBao_OK(p, "Không đủ " + vang_req + " beri");
                  return;
               }

               p.update_vang(-vang_req);
            } else {
               int vang_req = get_material(3, it_select);
               if (p.get_ngoc() < vang_req) {
                  Service.send_box_ThongBao_OK(p, "Không đủ " + vang_req + " ruby");
                  return;
               }

               p.update_ngoc(-vang_req);
            }

            p.update_money();
            p.item.remove_item47(7, 1, material_0);
            p.item.remove_item47(7, id_matrial_1, material_1);
            int percent_decrease_level = 80;
            int percent_suc = 5;
            if (p.data_super_upgrade[1] >= 1 && p.data_super_upgrade[1] <= 5) {
               percent_decrease_level -= p.data_super_upgrade[1] * 15;
               p.item.remove_item47(7, 6, p.data_super_upgrade[1]);
            }

            if (p.data_super_upgrade[2] == 1) {
               percent_decrease_level -= 20;
               p.item.remove_item47(7, 10, p.data_super_upgrade[2]);
            } else if (it_select.levelup == 14 || it_select.levelup == 13) {
               percent_decrease_level = 120;
            }

            if (p.data_super_upgrade[3] == 1) {
               percent_suc += 5;
               p.item.remove_item47(7, 11, p.data_super_upgrade[3]);
            }

            boolean suc = percent_suc > Util.random(120 + it_select.levelup * 2);
            Message m = new Message(66);
            if (suc) {
               it_select.levelup++;
               m.writer().writeByte(2);
               m.writer().writeUTF("Bạn đã cường hóa thành công vật phẩm " + it_select.template.name + " lên cấp " + it_select.levelup);
               Manager.gI().chatKTG(0, p.name + " cường hóa thành công " + it_select.template.name + " lên +" + it_select.levelup + ", thật là may mắn", 5);
            } else if (it_select.levelup > 10 && percent_decrease_level > Util.random(120)) {
               int decrese_random = Util.random(4);
               it_select.levelup = (byte)(it_select.levelup - decrese_random);
               if (it_select.levelup < 10) {
                  it_select.levelup = 10;
               }

               m.writer().writeByte(3);
               m.writer().writeUTF("Cường hóa thất bại, vật phẩm bị giảm cấp cường hóa về " + it_select.levelup);
            } else {
               m.writer().writeByte(3);
               m.writer().writeUTF("Cường hóa thất bại, vật phẩm không bị giảm cấp");
            }

            p.conn.addmsg(m);
            m.cleanup();
            p.item.update_Inventory(-1, false);
            p.data_super_upgrade = new int[]{-1, 0, 0, 0};
         }
      }
   }

   private static int get_material(int type, Item_wear it_select) {
      int result = 0;
      int tier = it_select.levelup - 10;
      int delta = 0;
      int index = it_select.template.level / 10 - 3;
      result = MATERIAL[index][type];
      if (it_select.template.level == 30) {
         delta = result * 3 / 10;
      } else if (it_select.template.level == 40) {
         delta = result * 2 / 10;
      } else {
         delta = result / 10;
      }

      while (tier > 0) {
         result += delta;
         tier--;
      }

      return result;
   }

   private static boolean check_it_can_upgrade_super(Player p, Item_wear it_select) throws IOException {
      if (it_select.template.color != 2 && it_select.template.color != 3) {
         Service.send_box_ThongBao_OK(p, "Phẩm chất trang bị Tím hoặc Cam mới có thể tiến hành Siêu Cường Hóa!");
         return false;
      } else if (it_select.levelup < 10) {
         Service.send_box_ThongBao_OK(p, "Trang bị đã Cường hóa +10 mới có thể tiến hành Siêu Cường Hóa!");
         return false;
      } else if (it_select.template.level >= 30 && it_select.template.level <= 100) {
         return true;
      } else {
         Service.send_box_ThongBao_OK(p, "Cấp trang bị phải từ Level 3x trở lên mới có thể tiến hành Siêu Cường Hóa!");
         return false;
      }
   }
}
