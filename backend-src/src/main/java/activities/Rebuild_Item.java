package activities;

import client.Player;
import core.Service;
import core.Util;
import io.Message;
import java.io.IOException;
import template.ItemTemplate4;
import template.Item_wear;
import template.Option;

public class Rebuild_Item {
   public static short[] ID_SELL = new short[]{74, 68, 62, 56, 50, 44, 272, 273, 274, 275, 276, 277};
   public static byte[] PERCENT_HOP_NGOC = new byte[]{120, 85, 70, 55, 40, 0};
   public static int[] PRICE_THAO_NGOC = new int[]{2, 6, 18, 54, 162, 300};
   public static short[][] ITEM_NGOC_SIEU_CAP = new short[30][];

   public static void show_table(Player p, int type) throws IOException {
      Message m = new Message(-67);
      m.writer().writeByte(0);
      switch (type) {
         case 1:
            m.writer().writeByte(4);
            break;
         case 2:
            m.writer().writeByte(2);
            break;
         case 3:
            m.writer().writeByte(1);
            break;
         case 4:
            m.writer().writeByte(3);
            break;
         case 5:
            m.writer().writeByte(13);
            break;
         case 6:
            m.writer().writeByte(10);
            break;
         case 7:
            m.writer().writeByte(11);
            break;
         case 8:
            m.writer().writeByte(12);
            break;
         case 9:
            m.writer().writeByte(14);
            break;
         case 10:
            m.writer().writeByte(19);
      }

      p.conn.addmsg(m);
      m.cleanup();
      p.item_to_kham_ngoc = null;
      p.item_to_kham_ngoc_id_ngoc = -1;
      p.data_yesno = null;
   }

   public static void process(Player p, Message m2) throws IOException {
      byte type = m2.reader().readByte();
      byte action = m2.reader().readByte();
      short idItem = m2.reader().readShort();
      byte cat = m2.reader().readByte();
      short num = m2.reader().readShort();
      m2.reader().readShort();
      if (cat == 3 && num == 1 && type == 2 && action == 1) {
         Item_wear it_select = p.item.bag3[idItem];
         if (it_select != null && it_select.template.typeEquip < 6) {
            Message m = new Message(-67);
            m.writer().writeByte(1);
            m.writer().writeShort(idItem);
            m.writer().writeByte(3);
            m.writer().writeShort(1);
            p.conn.addmsg(m);
            m.cleanup();
         }
      } else if (cat == 3 && num == 1 && type == 2 && action == 7) {
         Item_wear it_select = p.item.bag3[idItem];
         if (it_select != null && it_select.numLoKham < 4 && it_select.numHoleDaDuc < 2 && it_select.template.typeEquip < 6) {
            p.data_yesno = new int[]{idItem};
            Service.send_box_yesno(
               p,
               12,
               "Thông báo",
               "Đục lỗ bạn phải mất " + (it_select.numHoleDaDuc == 1 ? 200 : 50) + " Ruby",
               new String[]{"Đồng ý", "Hủy"},
               new byte[]{7, -1}
            );
         } else {
            show_table(p, 2);
            Service.send_box_ThongBao_OK(p, "Không thể đục thêm lỗ với vật phẩm này, hãy sử dụng búa đục lỗ để có thể tiếp tục");
         }
      } else if (cat == 4 && num > 0 && type == 4 && action == 1) {
         if (num < 3) {
            Service.send_box_ThongBao_OK(p, "Số lượng nhập vào của bạn không được nhỏ hơn 3 viên!");
            return;
         }

         if (p.item.total_item_bag_by_id(4, idItem) < num) {
            Service.send_box_ThongBao_OK(p, "Không đủ vật phẩm trong hành trang!");
            return;
         }

         if ((idItem < 44 || idItem > 78 || idItem == 73 || idItem == 67 || idItem == 61 || idItem == 55 || idItem == 49)
            && (idItem < 221 || idItem > 224)
            && (idItem < 362 || idItem > 363)) {
            Service.send_box_ThongBao_OK(p, "Vật phẩm không hợp lệ!");
         } else {
            Message m = new Message(-67);
            m.writer().writeByte(1);
            m.writer().writeShort(idItem);
            m.writer().writeByte(4);
            m.writer().writeShort(num);
            p.conn.addmsg(m);
            m.cleanup();
         }
      } else if (cat == 4 && num > 0 && type == 4 && action == 5) {
         if (idItem >= 44 && idItem <= 78 && idItem != 73 && idItem != 67 && idItem != 61 && idItem != 55 && idItem != 49
            || idItem >= 221 && idItem <= 224
            || idItem >= 362 && idItem <= 363) {
            if (p.item.total_item_bag_by_id(4, idItem) < num) {
               Service.send_box_ThongBao_OK(p, "Không đủ vật phẩm trong hành trang!");
               return;
            }

            int time_success = 0;
            int time_lose = 0;

            for (int percent = PERCENT_HOP_NGOC[get_percent_hop_ngoc(idItem)]; num >= 3; num = (short)(num - 3)) {
               if (percent > Util.random(120)) {
                  time_success++;
               } else {
                  time_lose++;
               }
            }

            p.item.remove_item47(4, idItem, 2 * time_lose + 3 * time_success);
            if (time_success > 0) {
               p.item.add_item_bag47(4, idItem + 1, time_success);
            }

            p.item.update_Inventory(-1, false);
            Message m = new Message(-67);
            m.writer().writeByte(5);
            m.writer()
               .writeUTF(
                  "Sử dụng "
                     + 3 * (time_lose + time_success)
                     + " "
                     + ItemTemplate4.get_item_name(idItem)
                     + " để nâng cấp. Thành công "
                     + time_success
                     + " lần, thất bại "
                     + time_lose
                     + " lần."
               );
            m.writer().writeShort(idItem);
            m.writer().writeShort(idItem + 1);
            m.writer().writeShort(time_success);
            m.writer().writeByte(4);
            p.conn.addmsg(m);
            m.cleanup();
         } else {
            show_table(p, 1);
            Service.send_box_ThongBao_OK(p, "Vật phẩm không hợp lệ!");
         }
      } else if (cat == 3 && num == 1 && type == 1 && action == 1) {
         Item_wear it_select = p.item.bag3[idItem];
         if (it_select != null) {
            Message m = new Message(-67);
            m.writer().writeByte(1);
            m.writer().writeShort(idItem);
            m.writer().writeByte(3);
            m.writer().writeShort(1);
            p.conn.addmsg(m);
            m.cleanup();
            p.item_to_kham_ngoc = it_select;
         }
      } else if (cat == 4 && num == 1 && type == 1 && action == 1) {
         if (p.item.total_item_bag_by_id(4, idItem) < num) {
            Service.send_box_ThongBao_OK(p, "Không đủ vật phẩm trong hành trang!");
            return;
         }

         Message m = new Message(-67);
         m.writer().writeByte(1);
         m.writer().writeShort(idItem);
         m.writer().writeByte(4);
         m.writer().writeShort(1);
         p.conn.addmsg(m);
         m.cleanup();
         p.item_to_kham_ngoc_id_ngoc = idItem;
      } else if (cat == 0 && num == 0 && type == 1 && action == 4) {
         Item_wear it_select = p.item_to_kham_ngoc;
         if (it_select != null && p.item_to_kham_ngoc_id_ngoc != -1) {
            ItemTemplate4 temp4 = ItemTemplate4.get_it_by_id(p.item_to_kham_ngoc_id_ngoc);
            if (it_select.numLoKham <= it_select.mdakham.length && temp4 != null) {
               show_table(p, 3);
               Service.send_box_ThongBao_OK(p, "Vật phẩm này không còn lỗ trống để khảm!");
               return;
            }

            if (p.item_to_kham_ngoc_id_ngoc >= 221 && p.item_to_kham_ngoc_id_ngoc <= 226) {
               show_table(p, 3);
               Service.send_box_ThongBao_OK(p, "Đá Hải Thạch chỉ có thể khảm lên một số trang bị giới hạn!");
               return;
            }

            if (it_select.template.color < 2
               && (
                  p.item_to_kham_ngoc_id_ngoc >= 241 && p.item_to_kham_ngoc_id_ngoc <= 270
                     || p.item_to_kham_ngoc_id_ngoc >= 368 && p.item_to_kham_ngoc_id_ngoc <= 373
                     || p.item_to_kham_ngoc_id_ngoc >= 647 && p.item_to_kham_ngoc_id_ngoc <= 682
                     || get_percent_hop_ngoc(p.item_to_kham_ngoc_id_ngoc) >= 5
               )) {
               show_table(p, 3);
               Service.send_box_ThongBao_OK(p, it_select.template.name + " chỉ có thể khảm ngọc Cấp 5 trở xuống");
               return;
            }

            if (!check_can_kham_len_item(it_select, p.item_to_kham_ngoc_id_ngoc)) {
               show_table(p, 3);
               Service.send_box_ThongBao_OK(p, "Không thể khảm " + temp4.name + " lên loại trang bị này!");
               return;
            }

            if (p.item.total_item_bag_by_id(4, p.item_to_kham_ngoc_id_ngoc) < 1) {
               show_table(p, 3);
               Service.send_box_ThongBao_OK(p, "Không đủ vật phẩm trong hành trang");
               return;
            }

            p.item.remove_item47(4, p.item_to_kham_ngoc_id_ngoc, 1);
            add_op_ngoc_kham_new(it_select, p.item_to_kham_ngoc_id_ngoc);
            p.item.update_Inventory(-1, false);
            Message m = new Message(-67);
            m.writer().writeByte(4);
            m.writer().writeUTF("Bạn khảm thành công " + ItemTemplate4.get_it_by_id(p.item_to_kham_ngoc_id_ngoc).name + " lên " + it_select.template.name);
            p.conn.addmsg(m);
            m.cleanup();
         } else {
            show_table(p, 3);
            Service.send_box_ThongBao_OK(p, "Có lỗi xảy ra, hãy thử lại!");
         }
      } else if (cat == 3 && num == 1 && type == 3 && action == 1) {
         Item_wear it_select = p.item.bag3[idItem];
         if (it_select != null) {
            if (it_select.mdakham.length > 0) {
               Message m = new Message(-67);
               m.writer().writeByte(1);
               m.writer().writeShort(idItem);
               m.writer().writeByte(3);
               m.writer().writeShort(1);
               p.conn.addmsg(m);
               m.cleanup();
               p.item_to_kham_ngoc = it_select;
            } else {
               Service.send_box_ThongBao_OK(p, "Vật phẩm chưa có đá khảm!");
            }
         }
      } else if (cat == 3 && num == 1 && type == 3 && action == 6) {
         if (p.item_to_kham_ngoc != null) {
            int vang_req = 0;

            for (int i = 0; i < p.item_to_kham_ngoc.mdakham.length; i++) {
               if (p.item_to_kham_ngoc.mdakham[i] >= 44 && p.item_to_kham_ngoc.mdakham[i] <= 79) {
                  vang_req += PRICE_THAO_NGOC[get_percent_hop_ngoc(p.item_to_kham_ngoc.mdakham[i])];
               } else if ((p.item_to_kham_ngoc.mdakham[i] < 241 || p.item_to_kham_ngoc.mdakham[i] > 270)
                  && (p.item_to_kham_ngoc.mdakham[i] < 362 || p.item_to_kham_ngoc.mdakham[i] > 373)) {
                  vang_req += 350;
               } else {
                  vang_req += 300;
               }
            }

            if (vang_req > 0) {
               Service.send_box_yesno(
                  p, 1, "Thông báo", "Xác nhận tháo tất cả ngọc khảm với giá " + vang_req + " ruby?", new String[]{"Có", "Không"}, new byte[]{-1, -1}
               );
            }
         }
      } else if (cat != 4 || num != 0 || type != 13 || action != 28 && action != 29) {
         if (idItem == 0 & cat == 0 && num == 0 && type == 13 && action == 26 && p.data_yesno != null && p.data_yesno.length == 2) {
            Service.send_box_yesno(
               p, 13, "Thông báo", "Bạn sẽ mất 1 đá nguyên liệu nếu thất bại. Bạn có muốn tiếp tục nâng cấp?", new String[]{"Có", "Không"}, new byte[]{2, 1}
            );
         } else if (type == 10 && action == 1 && cat == 3 && num == 1) {
            Item_wear it_select = p.item.bag3[idItem];
            if (it_select != null && it_select.template.typeEquip < 6) {
               if (it_select.template.color >= 2 && it_select.valueChetac >= 50) {
                  Message m = new Message(-67);
                  m.writer().writeByte(1);
                  m.writer().writeShort(idItem);
                  m.writer().writeByte(3);
                  m.writer().writeShort(1);
                  p.conn.addmsg(m);
                  m.cleanup();
                  p.item_to_kham_ngoc = it_select;
               } else {
                  Service.send_box_ThongBao_OK(p, "Trang bị đem đi hoàn mỹ phải là trang bị tím hoặc cam và có điểm chế tác > 50");
               }
            }
         } else if ((type == 10 || type == 11) && action == 1 && cat == 4 && idItem >= 221 && idItem <= 226 && num == 1) {
            if (p.item.total_item_bag_by_id(4, idItem) > 0) {
               Message m = new Message(-67);
               m.writer().writeByte(1);
               m.writer().writeShort(idItem);
               m.writer().writeByte(4);
               m.writer().writeShort(num);
               p.conn.addmsg(m);
               m.cleanup();
               p.item_to_kham_ngoc_id_ngoc = idItem;
            } else {
               Service.send_box_ThongBao_OK(p, "Không đủ " + ItemTemplate4.get_item_name(idItem));
            }
         } else if (type == 10 && action == 20 && cat == 0 && idItem == 0 && num == 0) {
            Service.send_box_yesno(p, 30, "Thông báo", "Để hoàn mỹ trang bị này bạn sẽ mất phí 5 ruby.", new String[]{"Đồng ý", "Hủy"}, new byte[]{7, 1});
         } else if (type == 12 && action == 1 && cat == 3 && num == 1) {
            Item_wear it_select = p.item.bag3[idItem];
            if (it_select != null && (it_select.template.typeEquip < 6 || it_select.template.typeEquip == 7)) {
               Message m = new Message(-67);
               m.writer().writeByte(1);
               m.writer().writeShort(idItem);
               m.writer().writeByte(3);
               m.writer().writeShort(1);
               p.conn.addmsg(m);
               m.cleanup();
               p.item_to_kham_ngoc = it_select;
            }
         } else if (type == 12 && action == 24 && cat == 0 && idItem == 0 && num == 0) {
            if (p.item_to_kham_ngoc != null) {
               Service.send_box_yesno(
                  p,
                  31,
                  "Thông báo",
                  "Để tiến hành phục hồi điểm chế tác bạn sẽ tốn: 5 ruby hồi 1 điểm hoặc 100 ruby hồi 10 điểm",
                  new String[]{"5", "100", "Không"},
                  new byte[]{7, 7, 1}
               );
            }
         } else if (type == 11 && action == 1 && cat == 3 && num == 1) {
            Item_wear it_select = p.item.bag3[idItem];
            if (it_select != null && it_select.template.typeEquip < 6) {
               if (it_select.template.color >= 2 && it_select.valueChetac >= 50) {
                  Message m = new Message(-67);
                  m.writer().writeByte(1);
                  m.writer().writeShort(idItem);
                  m.writer().writeByte(3);
                  m.writer().writeShort(1);
                  p.conn.addmsg(m);
                  m.cleanup();
                  p.item_to_kham_ngoc = it_select;
               } else {
                  Service.send_box_ThongBao_OK(p, "Trang bị đem đi kích ẩn phải là trang bị tím hoặc cam và có điểm chế tác > 50");
               }
            }
         } else if (type == 11 && action == 22 && cat == 0 && idItem == 0 && num == 0) {
            Service.send_box_yesno(p, 32, "Thông báo", "Để kích ẩn trang bị này bạn sẽ mất phí 5 ruby.", new String[]{"Đồng ý", "Hủy"}, new byte[]{7, 1});
         } else if (type == 14 && action == 1 && cat == 4 && idItem >= 0 && num == 1) {
            if (p.item.total_item_bag_by_id(cat, idItem) < num) {
               Service.send_box_ThongBao_OK(p, "Không đủ trong hành trang");
               return;
            }

            ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(idItem);
            if (itemTemplate4 != null) {
               if (itemTemplate4.type == 74) {
                  Message m = new Message(-67);
                  m.writer().writeByte(1);
                  m.writer().writeShort(idItem);
                  m.writer().writeByte(4);
                  m.writer().writeShort(1);
                  p.conn.addmsg(m);
                  m.cleanup();
                  p.item_to_kham_ngoc_id_ngoc = idItem;
               } else {
                  Service.send_box_ThongBao_OK(p, "Chỉ có thể bỏ mảnh trang bị vào");
               }
            }
         } else if (type == 14 && action == 31 && cat == 0 && idItem == 0 && num == 0) {
            if (p.item.total_item_bag_by_id(cat, p.item_to_kham_ngoc_id_ngoc) < num) {
               Service.send_box_ThongBao_OK(p, "Không đủ trong hành trang");
               return;
            }

            ItemTemplate4 itemTemplate4 = ItemTemplate4.get_it_by_id(p.item_to_kham_ngoc_id_ngoc);
            if (itemTemplate4 != null) {
               if (itemTemplate4.type == 74) {
                  p.data_yesno = new int[]{itemTemplate4.id};
                  switch (itemTemplate4.id) {
                     case 304:
                     case 305:
                     case 306:
                        Service.send_box_yesno(
                           p,
                           40,
                           "Thông báo",
                           "Bạn có muốn ghép 18 " + itemTemplate4.name + " thành 1 trang bị trắng 9x?",
                           new String[]{"Đồng ý", "Hủy"},
                           new byte[]{2, 1}
                        );
                        break;
                     case 307:
                     case 308:
                     case 309:
                        Service.send_box_yesno(
                           p,
                           40,
                           "Thông báo",
                           "Bạn có muốn ghép 18 " + itemTemplate4.name + " thành 1 trang bị xanh 9x?",
                           new String[]{"Đồng ý", "Hủy"},
                           new byte[]{2, 1}
                        );
                        break;
                     case 310:
                     case 311:
                     case 312:
                        Service.send_box_yesno(
                           p,
                           40,
                           "Thông báo",
                           "Bạn có muốn ghép 18 " + itemTemplate4.name + " thành 1 trang bị tím 9x?",
                           new String[]{"Đồng ý", "Hủy"},
                           new byte[]{2, 1}
                        );
                        break;
                     case 313:
                     case 314:
                     case 315:
                        Service.send_box_yesno(
                           p,
                           40,
                           "Thông báo",
                           "Bạn có muốn ghép 18 " + itemTemplate4.name + " thành 1 trang bị cam 9x?",
                           new String[]{"Đồng ý", "Hủy"},
                           new byte[]{2, 1}
                        );
                        break;
                     case 536:
                     case 537:
                     case 538:
                        Service.send_box_yesno(
                           p,
                           40,
                           "Thông báo",
                           "Bạn có muốn ghép 18 " + itemTemplate4.name + " thành 1 trang bị trắng 10x?",
                           new String[]{"Đồng ý", "Hủy"},
                           new byte[]{2, 1}
                        );
                        break;
                     case 539:
                     case 540:
                     case 541:
                        Service.send_box_yesno(
                           p,
                           40,
                           "Thông báo",
                           "Bạn có muốn ghép 18 " + itemTemplate4.name + " thành 1 trang bị xanh 10x?",
                           new String[]{"Đồng ý", "Hủy"},
                           new byte[]{2, 1}
                        );
                        break;
                     case 542:
                     case 543:
                     case 544:
                        Service.send_box_yesno(
                           p,
                           40,
                           "Thông báo",
                           "Bạn có muốn ghép 18 " + itemTemplate4.name + " thành 1 trang bị tím 10x?",
                           new String[]{"Đồng ý", "Hủy"},
                           new byte[]{2, 1}
                        );
                        break;
                     case 545:
                     case 546:
                     case 547:
                        Service.send_box_yesno(
                           p,
                           40,
                           "Thông báo",
                           "Bạn có muốn ghép 18 " + itemTemplate4.name + " thành 1 trang bị cam 10x?",
                           new String[]{"Đồng ý", "Hủy"},
                           new byte[]{2, 1}
                        );
                        break;
                     default:
                        p.data_yesno = null;
                        Service.send_box_ThongBao_OK(p, "Mảnh trang bị loại này hiện tại chưa ghép được");
                  }
               } else {
                  Service.send_box_ThongBao_OK(p, "Chỉ có thể bỏ mảnh trang bị vào");
               }
            }
         } else if (cat == 3 && num == 1 && type == 2 && action == 34) {
            Item_wear it_select = p.item.bag3[idItem];
            if (it_select != null && it_select.numLoKham >= 4 && it_select.numLoKham < 8) {
               if (it_select.valueChetac < 50) {
                  show_table(p, 2);
                  Service.send_box_ThongBao_OK(p, "Vật phẩm không đủ điểm chế tác để thực hiện, tối thiểu 50!");
                  return;
               }

               if (p.item.total_item_bag_by_id(4, 323) < 1) {
                  show_table(p, 2);
                  Service.send_box_ThongBao_OK(p, "Không đủ 1 búa siêu cấp");
                  return;
               }

               p.data_yesno = new int[]{idItem};
               Service.send_box_yesno(p, 46, "Thông báo", "Đục lỗ bạn phải mất 1 búa sơ cấp", new String[]{"Đồng ý", "Hủy"}, new byte[]{2, -1});
            } else {
               show_table(p, 2);
               Service.send_box_ThongBao_OK(p, "Không thể dùng búa siêu cấp với vật phẩm này");
            }
         } else if (cat == 3 && num == 1 && type == 2 && action == 33) {
            Item_wear it_select = p.item.bag3[idItem];
            if (it_select != null && it_select.numLoKham == 4) {
               if (it_select.valueChetac < 50) {
                  show_table(p, 2);
                  Service.send_box_ThongBao_OK(p, "Vật phẩm không đủ điểm chế tác để thực hiện, tối thiểu 50!");
                  return;
               }

               if (p.item.total_item_bag_by_id(4, 339) < 1) {
                  show_table(p, 2);
                  Service.send_box_ThongBao_OK(p, "Không đủ 1 búa sơ cấp");
                  return;
               }

               p.data_yesno = new int[]{idItem};
               Service.send_box_yesno(p, 45, "Thông báo", "Đục lỗ bạn phải mất 1 búa sơ cấp", new String[]{"Đồng ý", "Hủy"}, new byte[]{2, -1});
            } else {
               show_table(p, 2);
               Service.send_box_ThongBao_OK(p, "Búa sơ cấp chỉ có thể đục lỗ vật phẩm từ 4 lỗ lên 5 lỗ");
            }
         } else if (cat == 3 && num == 1 && type == 19 && action == 1) {
            Item_wear it_select = p.item.bag3[idItem];
            if (it_select != null && it_select.template.typeEquip == 7 && it_select.numLoKham < 5) {
               Message m = new Message(-67);
               m.writer().writeByte(1);
               m.writer().writeShort(idItem);
               m.writer().writeByte(3);
               m.writer().writeShort(1);
               p.conn.addmsg(m);
               m.cleanup();
            }
         } else if (cat == 3 && num == 1 && type == 19 && action == 7) {
            Item_wear it_select = p.item.bag3[idItem];
            if (it_select != null && it_select.template.typeEquip == 7 && it_select.numLoKham < 5) {
               if (p.item.total_item_bag_by_id(4, 457) < 1) {
                  Service.send_box_ThongBao_OK(p, "Không đủ 1 búa đục dial");
                  return;
               }

               int ruby_req = 50 * (it_select.numLoKham + 1);
               p.data_yesno = new int[]{idItem};
               Service.send_box_yesno(
                  p, 57, "Thông báo", "Đục lỗ dial bạn phải mất 1 búa đục dial và " + ruby_req + " ruby", new String[]{"Đồng ý", "Hủy"}, new byte[]{2, -1}
               );
            }
         }
      } else {
         if (!check_it_can_upgrade_da_sieu_cap(idItem)) {
            show_table(p, 5);
            Service.send_box_ThongBao_OK(p, "Vật phẩm không hợp lệ!");
            p.data_yesno = null;
            return;
         }

         if (idItem == 367 && action == 29) {
            show_table(p, 5);
            Service.send_box_ThongBao_OK(p, "Không thể sử dụng hổ phách để làm đá nguyên liệu!");
            p.data_yesno = null;
            return;
         }

         if (p.item.total_item_bag_by_id(4, idItem) < (action == 28 ? 1 : 2)) {
            show_table(p, 5);
            Service.send_box_ThongBao_OK(p, "Không đủ " + (action == 28 ? 1 : 2) + " " + ItemTemplate4.get_item_name(idItem));
            p.data_yesno = null;
            return;
         }

         if (p.data_yesno == null || p.data_yesno.length != 2) {
            p.data_yesno = new int[]{-1, -1};
         }

         if (action == 28) {
            p.data_yesno[0] = idItem;
         } else if (action == 29) {
            p.data_yesno[1] = idItem;
         }

         int num_material = action == 28 ? 1 : 2;
         Message m = new Message(-67);
         m.writer().writeByte(action);
         m.writer().writeShort(idItem);
         m.writer().writeByte(4);
         m.writer().writeShort(num_material);
         m.writer().writeByte(p.percent_da_sieu_cap);
         p.conn.addmsg(m);
         m.cleanup();
      }
   }

   private static boolean check_it_can_upgrade_da_sieu_cap(short idItem) {
      return get_percent_hop_ngoc(idItem) == 5;
   }

   public static int get_percent_hop_ngoc(short idItem) {
      if (idItem == 221) {
         return 0;
      } else if (idItem == 222) {
         return 1;
      } else if (idItem == 223) {
         return 2;
      } else if (idItem == 224 || idItem == 362) {
         return 3;
      } else if (idItem == 225 || idItem == 363) {
         return 4;
      } else if (idItem == 226) {
         return 6;
      } else {
         int index = idItem - 44;

         while (index >= 6) {
            index -= 6;
         }

         return index;
      }
   }

   private static void add_op_ngoc_kham_new(Item_wear it_select, short id) {
      if (it_select.mdakham.length > 0) {
         short[] temp = new short[it_select.mdakham.length + 1];

         for (int i = 0; i < it_select.mdakham.length; i++) {
            temp[i] = it_select.mdakham[i];
         }

         temp[temp.length - 1] = id;
         it_select.mdakham = temp;
      } else {
         it_select.mdakham = new short[]{id};
      }

      byte[] id_add = null;
      int[] par_add = null;
      switch (id) {
         case 44:
            id_add = new byte[]{4};
            par_add = new int[]{20};
            break;
         case 45:
            id_add = new byte[]{4};
            par_add = new int[]{30};
            break;
         case 46:
            id_add = new byte[]{4};
            par_add = new int[]{40};
            break;
         case 47:
            id_add = new byte[]{4};
            par_add = new int[]{60};
            break;
         case 48:
            id_add = new byte[]{4};
            par_add = new int[]{90};
            break;
         case 49:
            id_add = new byte[]{4};
            par_add = new int[]{140};
            break;
         case 50:
            id_add = new byte[]{1};
            par_add = new int[]{50};
            break;
         case 51:
            id_add = new byte[]{1};
            par_add = new int[]{70};
            break;
         case 52:
            id_add = new byte[]{1};
            par_add = new int[]{90};
            break;
         case 53:
            id_add = new byte[]{1};
            par_add = new int[]{120};
            break;
         case 54:
            id_add = new byte[]{1};
            par_add = new int[]{160};
            break;
         case 55:
            id_add = new byte[]{1};
            par_add = new int[]{220};
            break;
         case 56:
            id_add = new byte[]{10};
            par_add = new int[]{10};
            break;
         case 57:
            id_add = new byte[]{10};
            par_add = new int[]{20};
            break;
         case 58:
            id_add = new byte[]{10};
            par_add = new int[]{30};
            break;
         case 59:
            id_add = new byte[]{10};
            par_add = new int[]{40};
            break;
         case 60:
            id_add = new byte[]{10};
            par_add = new int[]{50};
            break;
         case 61:
            id_add = new byte[]{10};
            par_add = new int[]{60};
            break;
         case 62:
            id_add = new byte[]{13};
            par_add = new int[]{10};
            break;
         case 63:
            id_add = new byte[]{13};
            par_add = new int[]{20};
            break;
         case 64:
            id_add = new byte[]{13};
            par_add = new int[]{30};
            break;
         case 65:
            id_add = new byte[]{13};
            par_add = new int[]{40};
            break;
         case 66:
            id_add = new byte[]{13};
            par_add = new int[]{60};
            break;
         case 67:
            id_add = new byte[]{13};
            par_add = new int[]{90};
            break;
         case 68:
            id_add = new byte[]{26, 27};
            par_add = new int[]{10, 10};
            break;
         case 69:
            id_add = new byte[]{26, 27};
            par_add = new int[]{20, 20};
            break;
         case 70:
            id_add = new byte[]{26, 27};
            par_add = new int[]{30, 30};
            break;
         case 71:
            id_add = new byte[]{26, 27};
            par_add = new int[]{40, 40};
            break;
         case 72:
            id_add = new byte[]{26, 27};
            par_add = new int[]{60, 60};
            break;
         case 73:
            id_add = new byte[]{26, 27};
            par_add = new int[]{90, 90};
            break;
         case 74:
            id_add = new byte[]{14};
            par_add = new int[]{10};
            break;
         case 75:
            id_add = new byte[]{14};
            par_add = new int[]{20};
            break;
         case 76:
            id_add = new byte[]{14};
            par_add = new int[]{30};
            break;
         case 77:
            id_add = new byte[]{14};
            par_add = new int[]{40};
            break;
         case 78:
            id_add = new byte[]{14};
            par_add = new int[]{60};
            break;
         case 79:
            id_add = new byte[]{14};
            par_add = new int[]{90};
            break;
         case 241:
            id_add = new byte[]{4, 48};
            par_add = new int[]{140, 20};
            break;
         case 242:
            id_add = new byte[]{4, 49};
            par_add = new int[]{140, 40};
            break;
         case 243:
            id_add = new byte[]{4, 50};
            par_add = new int[]{140, 40};
            break;
         case 244:
            id_add = new byte[]{4, 51};
            par_add = new int[]{140, 40};
            break;
         case 245:
            id_add = new byte[]{4, 52};
            par_add = new int[]{140, 40};
            break;
         case 246:
            id_add = new byte[]{1, 47};
            par_add = new int[]{220, 40};
            break;
         case 247:
            id_add = new byte[]{1, 49};
            par_add = new int[]{220, 40};
            break;
         case 248:
            id_add = new byte[]{1, 50};
            par_add = new int[]{220, 40};
            break;
         case 249:
            id_add = new byte[]{1, 51};
            par_add = new int[]{220, 40};
            break;
         case 250:
            id_add = new byte[]{1, 52};
            par_add = new int[]{220, 40};
            break;
         case 251:
            id_add = new byte[]{10, 47};
            par_add = new int[]{60, 40};
            break;
         case 252:
            id_add = new byte[]{10, 48};
            par_add = new int[]{60, 20};
            break;
         case 253:
            id_add = new byte[]{10, 50};
            par_add = new int[]{60, 40};
            break;
         case 254:
            id_add = new byte[]{10, 51};
            par_add = new int[]{60, 40};
            break;
         case 255:
            id_add = new byte[]{10, 52};
            par_add = new int[]{60, 40};
            break;
         case 256:
            id_add = new byte[]{13, 47};
            par_add = new int[]{90, 40};
            break;
         case 257:
            id_add = new byte[]{13, 48};
            par_add = new int[]{90, 20};
            break;
         case 258:
            id_add = new byte[]{13, 49};
            par_add = new int[]{90, 40};
            break;
         case 259:
            id_add = new byte[]{13, 51};
            par_add = new int[]{90, 40};
            break;
         case 260:
            id_add = new byte[]{13, 52};
            par_add = new int[]{90, 40};
            break;
         case 261:
            id_add = new byte[]{26, 27, 47};
            par_add = new int[]{90, 90, 40};
            break;
         case 262:
            id_add = new byte[]{26, 27, 48};
            par_add = new int[]{90, 90, 20};
            break;
         case 263:
            id_add = new byte[]{26, 27, 49};
            par_add = new int[]{90, 90, 40};
            break;
         case 264:
            id_add = new byte[]{26, 27, 50};
            par_add = new int[]{90, 90, 40};
            break;
         case 265:
            id_add = new byte[]{26, 27, 52};
            par_add = new int[]{90, 90, 40};
            break;
         case 266:
            id_add = new byte[]{14, 47};
            par_add = new int[]{90, 40};
            break;
         case 267:
            id_add = new byte[]{14, 48};
            par_add = new int[]{90, 20};
            break;
         case 268:
            id_add = new byte[]{14, 49};
            par_add = new int[]{90, 40};
            break;
         case 269:
            id_add = new byte[]{14, 50};
            par_add = new int[]{90, 40};
            break;
         case 270:
            id_add = new byte[]{14, 51};
            par_add = new int[]{90, 40};
            break;
         case 324:
            id_add = new byte[]{1, 4, 10, 13, 14, 26, 27};
            par_add = new int[]{70, 110, 30, 50, 50, 50, 50};
            break;
         case 325:
            id_add = new byte[]{49, 50, 52, 51, 47, 48};
            par_add = new int[]{40, 40, 40, 40, 40, 20};
            break;
         case 326:
            id_add = new byte[]{1, 4, 10, 13, 14, 26, 27};
            par_add = new int[]{140, 220, 60, 90, 90, 90, 90};
            break;
         case 362:
            id_add = new byte[]{12};
            par_add = new int[]{10};
            break;
         case 363:
            id_add = new byte[]{12};
            par_add = new int[]{20};
            break;
         case 364:
            id_add = new byte[]{12};
            par_add = new int[]{30};
            break;
         case 365:
            id_add = new byte[]{12};
            par_add = new int[]{40};
            break;
         case 366:
            id_add = new byte[]{12};
            par_add = new int[]{50};
            break;
         case 367:
            id_add = new byte[]{12};
            par_add = new int[]{60};
            break;
         case 368:
            id_add = new byte[]{12, 47};
            par_add = new int[]{60, 40};
            break;
         case 369:
            id_add = new byte[]{12, 48};
            par_add = new int[]{60, 20};
            break;
         case 370:
            id_add = new byte[]{12, 49};
            par_add = new int[]{60, 40};
            break;
         case 371:
            id_add = new byte[]{12, 50};
            par_add = new int[]{60, 40};
            break;
         case 372:
            id_add = new byte[]{12, 51};
            par_add = new int[]{60, 40};
            break;
         case 373:
            id_add = new byte[]{12, 52};
            par_add = new int[]{60, 40};
            break;
         case 647:
            id_add = new byte[]{4, 48};
            par_add = new int[]{250, 30};
            break;
         case 648:
            id_add = new byte[]{4, 49};
            par_add = new int[]{250, 60};
            break;
         case 649:
            id_add = new byte[]{4, 50};
            par_add = new int[]{250, 60};
            break;
         case 650:
            id_add = new byte[]{4, 51};
            par_add = new int[]{250, 60};
            break;
         case 651:
            id_add = new byte[]{4, 52};
            par_add = new int[]{250, 60};
            break;
         case 652:
            id_add = new byte[]{1, 47};
            par_add = new int[]{320, 60};
            break;
         case 653:
            id_add = new byte[]{1, 49};
            par_add = new int[]{320, 60};
            break;
         case 654:
            id_add = new byte[]{1, 50};
            par_add = new int[]{320, 60};
            break;
         case 655:
            id_add = new byte[]{1, 51};
            par_add = new int[]{320, 60};
            break;
         case 656:
            id_add = new byte[]{1, 52};
            par_add = new int[]{320, 60};
            break;
         case 657:
            id_add = new byte[]{10, 47};
            par_add = new int[]{100, 60};
            break;
         case 658:
            id_add = new byte[]{10, 48};
            par_add = new int[]{100, 30};
            break;
         case 659:
            id_add = new byte[]{10, 50};
            par_add = new int[]{100, 60};
            break;
         case 660:
            id_add = new byte[]{10, 51};
            par_add = new int[]{100, 60};
            break;
         case 661:
            id_add = new byte[]{10, 52};
            par_add = new int[]{100, 60};
            break;
         case 662:
            id_add = new byte[]{13, 47};
            par_add = new int[]{150, 60};
            break;
         case 663:
            id_add = new byte[]{13, 48};
            par_add = new int[]{150, 30};
            break;
         case 664:
            id_add = new byte[]{13, 49};
            par_add = new int[]{150, 60};
            break;
         case 665:
            id_add = new byte[]{13, 51};
            par_add = new int[]{150, 60};
            break;
         case 666:
            id_add = new byte[]{13, 52};
            par_add = new int[]{150, 60};
            break;
         case 667:
            id_add = new byte[]{26, 27, 47};
            par_add = new int[]{150, 150, 60};
            break;
         case 668:
            id_add = new byte[]{26, 27, 48};
            par_add = new int[]{150, 150, 30};
            break;
         case 669:
            id_add = new byte[]{26, 27, 49};
            par_add = new int[]{150, 150, 60};
            break;
         case 670:
            id_add = new byte[]{26, 27, 50};
            par_add = new int[]{150, 150, 60};
            break;
         case 671:
            id_add = new byte[]{26, 27, 52};
            par_add = new int[]{150, 150, 60};
            break;
         case 672:
            id_add = new byte[]{14, 47};
            par_add = new int[]{150, 60};
            break;
         case 673:
            id_add = new byte[]{14, 48};
            par_add = new int[]{150, 30};
            break;
         case 674:
            id_add = new byte[]{14, 49};
            par_add = new int[]{150, 60};
            break;
         case 675:
            id_add = new byte[]{14, 50};
            par_add = new int[]{150, 60};
            break;
         case 676:
            id_add = new byte[]{14, 51};
            par_add = new int[]{150, 60};
            break;
         case 677:
            id_add = new byte[]{12, 47};
            par_add = new int[]{90, 60};
            break;
         case 678:
            id_add = new byte[]{12, 48};
            par_add = new int[]{90, 30};
            break;
         case 679:
            id_add = new byte[]{12, 49};
            par_add = new int[]{90, 60};
            break;
         case 680:
            id_add = new byte[]{12, 50};
            par_add = new int[]{90, 60};
            break;
         case 681:
            id_add = new byte[]{12, 51};
            par_add = new int[]{90, 60};
            break;
         case 682:
            id_add = new byte[]{12, 52};
            par_add = new int[]{90, 60};
      }

      if (id_add != null && par_add != null) {
         for (int i = 0; i < id_add.length; i++) {
            Option op_new = null;

            for (int j = 0; j < it_select.option_item_2.size(); j++) {
               if (it_select.option_item_2.get(j).id == id_add[i]) {
                  op_new = it_select.option_item_2.get(j);
                  break;
               }
            }

            if (op_new != null) {
               int par_old = op_new.getParam();
               op_new.setParam(par_old + par_add[i]);
            } else {
               op_new = new Option(id_add[i], par_add[i]);
               it_select.option_item_2.add(op_new);
            }
         }
      }
   }

   private static boolean check_can_kham_len_item(Item_wear it_select, int id) {
      if (it_select.template.typeEquip != 7 && (id < 324 || id > 326)) {
         boolean result = false;
         switch (it_select.template.typeEquip) {
            case 0:
               if (id >= 50 && id <= 55 || id >= 246 && id <= 250 || id >= 652 && id <= 656) {
                  result = true;
               }
               break;
            case 1:
            case 3:
            case 5:
               if (id >= 68 && id <= 73
                  || id >= 44 && id <= 49
                  || id >= 241 && id <= 245
                  || id >= 261 && id <= 265
                  || id >= 362 && id <= 373
                  || id >= 647 && id <= 651
                  || id >= 667 && id <= 671
                  || id >= 677 && id <= 682) {
                  result = true;
               }
               break;
            case 2:
            case 4:
               if (id >= 74 && id <= 79
                  || id >= 56 && id <= 67
                  || id >= 266 && id <= 270
                  || id >= 251 && id <= 260
                  || id >= 672 && id <= 676
                  || id >= 657 && id <= 666) {
                  result = true;
               }
         }

         return result;
      } else {
         return true;
      }
   }

   public static short get_id_ngoc_sieu_cap(int id1, int id2) {
      for (int i = 0; i < ITEM_NGOC_SIEU_CAP.length; i++) {
         if (ITEM_NGOC_SIEU_CAP[i][1] == id1 && ITEM_NGOC_SIEU_CAP[i][2] == id2) {
            return ITEM_NGOC_SIEU_CAP[i][0];
         }
      }

      return 2;
   }

   static {
      short[] id_ = new short[]{49, 55, 61, 67, 73, 79};
      short a = 0;
      short b = 1;

      for (int i = 241; i < 271; i++) {
         ITEM_NGOC_SIEU_CAP[i - 241] = new short[]{(short)i, id_[a], id_[b]};
         if (b < id_.length - 1) {
            b++;
            if (b == a && b < id_.length - 1) {
               b++;
            }
         } else if (a < id_.length - 1) {
            a++;
            b = 0;
         }
      }
   }
}
