package activities;

import client.Player;
import core.Service;
import core.Util;
import database.SQL;
import io.Message;
import java.io.DataOutputStream;
import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import template.ItemMarket;
import template.ItemTemplate4;
import template.ItemTemplate7;
import template.Item_wear;
import template.PotionMarket;

public class Market {
   private static short INDEX = 0;
   public static List<Market> ENTRY = new ArrayList<>();
   public byte type;
   public List<ItemMarket> item3;
   public List<PotionMarket> item47;

   public static void show_table(Player p) throws IOException {
      Message m = new Message(44);
      m.writer().writeByte(2);
      p.conn.addmsg(m);
      m.cleanup();
      update_at_market_index(p, 3);
   }

   public static void update_at_market_index(Player p, int type) throws IOException {
      if (type != 0 && type != 1 && type != 2 && type != 5 && type != 6 && type != 3) {
         System.err.println("market type not exist!!!!!");
      } else {
         Market get_market = null;
         if (type != 3) {
            Market template = get_list_by_type(type);
            if (template != null) {
               get_market = new Market();
               get_market.type = (byte)type;
               get_market.item3 = new ArrayList<>();
               get_market.item47 = new ArrayList<>();

               for (int j = 0; j < template.item3.size(); j++) {
                  if (template.item3.get(j).time_market > System.currentTimeMillis() && template.item3.get(j).type_market != 2) {
                     get_market.item3.add(template.item3.get(j));
                  } else if (template.item3.get(j).type_market == 1) {
                     template.item3.get(j).type_market = 3;
                  }
               }

               for (int jx = 0; jx < template.item47.size(); jx++) {
                  if (template.item47.get(jx).time_market > System.currentTimeMillis() && template.item47.get(jx).type_market != 2) {
                     get_market.item47.add(template.item47.get(jx));
                  } else if (template.item47.get(jx).type_market == 1) {
                     template.item47.get(jx).type_market = 3;
                  }
               }
            }

            get_market.sort();
         } else {
            get_market = get_list_my_item(p);
            get_market.sort();
         }

         if (get_market != null) {
            Message m = new Message(44);
            m.writer().writeByte(9);
            m.writer().writeByte(type);
            m.writer().writeShort(get_market.item3.size() + get_market.item47.size());

            for (int i = 0; i < get_market.item3.size(); i++) {
               m.writer().writeByte(3);
               readUpdateItem(m.writer(), get_market.item3.get(i));
               m.writer().writeInt(get_market.item3.get(i).price_market);
               int time_remain = (int)((get_market.item3.get(i).time_market - System.currentTimeMillis()) / 1000L);
               m.writer().writeInt(time_remain > 0 ? time_remain : 0);
               m.writer().writeByte(get_market.item3.get(i).type_market);
            }

            for (int i = 0; i < get_market.item47.size(); i++) {
               PotionMarket temp = get_market.item47.get(i);
               m.writer().writeByte(temp.category);
               m.writer().writeShort(temp.index);
               m.writer().writeShort(temp.id);
               m.writer().writeShort(temp.quant);
               m.writer().writeInt(get_market.item47.get(i).price_market);
               int time_remain = (int)((get_market.item47.get(i).time_market - System.currentTimeMillis()) / 1000L);
               m.writer().writeInt(time_remain > 0 ? time_remain : 0);
               m.writer().writeByte(get_market.item47.get(i).type_market);
            }

            p.conn.addmsg(m);
            m.cleanup();
         }
      }
   }

   private void sort() {
      if (this.item3.size() > 1) {
         List<ItemMarket> item_3 = new ArrayList<>();

         while (this.item3.size() > 0) {
            ItemMarket temp_add = null;

            for (int i = 0; i < this.item3.size(); i++) {
               if (temp_add == null) {
                  temp_add = this.item3.get(i);
               } else if (temp_add.time_market < this.item3.get(i).time_market) {
                  temp_add = this.item3.get(i);
               }
            }

            item_3.add(temp_add);
            this.item3.remove(temp_add);
         }

         this.item3.addAll(item_3);
         item_3.clear();
      }

      if (this.item47.size() > 1) {
         List<PotionMarket> item_47 = new ArrayList<>();

         while (this.item47.size() > 0) {
            PotionMarket temp_add = null;

            for (int ix = 0; ix < this.item47.size(); ix++) {
               if (temp_add == null) {
                  temp_add = this.item47.get(ix);
               } else if (temp_add.time_market < this.item47.get(ix).time_market) {
                  temp_add = this.item47.get(ix);
               }
            }

            item_47.add(temp_add);
            this.item47.remove(temp_add);
         }

         this.item47.addAll(item_47);
         item_47.clear();
      }
   }

   public static Market get_list_my_item(Player p) {
      Market result = new Market();
      result.type = 3;
      result.item3 = new ArrayList<>();
      result.item47 = new ArrayList<>();

      for (int i = 0; i < ENTRY.size(); i++) {
         Market temp = ENTRY.get(i);

         for (int j = 0; j < temp.item3.size(); j++) {
            if (temp.item3.get(j).seller.equals(p.name)) {
               result.item3.add(temp.item3.get(j));
            }
         }

         for (int jx = 0; jx < temp.item47.size(); jx++) {
            if (temp.item47.get(jx).seller.equals(p.name)) {
               result.item47.add(temp.item47.get(jx));
            }
         }
      }

      return result;
   }

   private static void readUpdateItem(DataOutputStream dos, ItemMarket it) throws IOException {
      dos.writeShort(it.index);
      dos.writeUTF(it.template.name);
      dos.writeByte(it.template.clazz);
      dos.writeByte(it.template.typeEquip);
      dos.writeShort(it.template.icon);
      dos.writeShort(it.template.level);
      dos.writeByte(it.levelup);
      dos.writeByte(it.template.color);
      dos.writeByte(0);
      dos.writeByte(it.typelock);
      dos.writeByte(it.numHoleDaDuc);
      dos.writeInt(it.timeUse);
      dos.writeShort(it.valueChetac);
      dos.writeByte(it.isHoanMy);
      dos.writeByte(it.valueKichAn);
      dos.writeByte(it.option_item.size());

      for (int i = 0; i < it.option_item.size(); i++) {
         dos.writeByte(it.option_item.get(i).id);
         dos.writeShort(it.option_item.get(i).getParam(it.template.typeEquip, it.levelup, it.isHoanMy));
      }

      dos.writeByte(it.option_item_2.size());

      for (int i = 0; i < it.option_item_2.size(); i++) {
         dos.writeByte(it.option_item_2.get(i).id);
         dos.writeShort(it.option_item_2.get(i).getParam());
      }

      dos.writeByte(it.numLoKham);
      dos.writeByte(it.mdakham.length);

      for (int i = 0; i < it.mdakham.length; i++) {
         dos.writeShort(it.mdakham[i]);
      }
   }

   public static Market get_list_by_type(int type) {
      for (int i = 0; i < ENTRY.size(); i++) {
         if (ENTRY.get(i).type == type) {
            return ENTRY.get(i);
         }
      }

      return null;
   }

   public static void process(Player p, Message m2) throws IOException {
      byte type = m2.reader().readByte();
      byte index_market = m2.reader().readByte();
      short id = m2.reader().readShort();
      byte cat = m2.reader().readByte();
      short value = m2.reader().readShort();
      if (type == 9 && id == 0 && cat == 0 && value == 1) {
         update_at_market_index(p, index_market);
      } else if (type == 10 && index_market == -1 && cat == 3 && value == 1) {
         Item_wear it_select = p.item.bag3[id];
         if (it_select != null) {
            if (p.conn.status != 1) {
               Service.send_box_ThongBao_OK(p, "Chưa Kích hoạt không thể đăng bán vật phẩm");
               return;
            }

            if (p.get_vnd() < 2000) {
               Service.send_box_ThongBao_OK(p, "Bạn không đủ 2000 extol để đăng bán vật phẩm");
               return;
            }

            if (it_select.template.typeEquip != 7 && it_select.template.typeEquip > 5) {
               Service.send_box_ThongBao_OK(p, "Chỉ có thể đăng bán Nón, Vũ khí, Áo, Quần, Dây chuyền, Nhẫn");
               return;
            }

            if (it_select.typelock == 1) {
               Service.send_box_ThongBao_OK(p, "Các trang bị sau khi mặc lên người sẽ bị Khoá, và bạn không thể đăng bán trang bị khoá");
               return;
            }

            if (it_select.mdakham.length > 0) {
               Service.send_box_ThongBao_OK(p, "Các trang bị đã được Khảm đá thì không thể đăng bán");
               return;
            }

            Market get_market = get_list_my_item(p);
            if (get_market == null || get_market.item3.size() + get_market.item47.size() >= 5) {
               Service.send_box_ThongBao_OK(p, "Bạn không đủ chỗ trống trên chợ mua bán, tối đa bán 5 item");
               return;
            }

            p.data_yesno = new int[]{id};
            Service.input_text(p, 5, "Đăng bán", new String[]{"Giá bán"});
         }
      } else if (type == 10 && index_market == -1 && id == 0 && cat == 4 && value > 0 && value < 32000) {
         long beri_add = 1000000L * value;
         if (p.conn.status != 1) {
            Service.send_box_ThongBao_OK(p, "Chưa Kích hoạt không thể đăng bán vật phẩm");
            return;
         }

         if (p.get_vnd() < 2000) {
            Service.send_box_ThongBao_OK(p, "Bạn không đủ 2000 extol để đăng bán");
            return;
         }

         if (p.get_vang() < beri_add) {
            Service.send_box_ThongBao_OK(p, "Bạn không đủ " + Util.number_format(beri_add) + " beri để đăng bán");
            return;
         }

         Market get_market = get_list_my_item(p);
         if (get_market == null || get_market.item3.size() + get_market.item47.size() >= 5) {
            Service.send_box_ThongBao_OK(p, "Bạn không đủ chỗ trống trên chợ mua bán, tối đa bán 5 item");
            return;
         }

         p.data_yesno = new int[]{value};
         Service.input_text(p, 6, "Đăng bán", new String[]{"Giá bán"});
      } else if (type == 10 && index_market == -1 && (cat == 4 || cat == 7) && value > 0 && value < 32000) {
         if (p.conn.status != 1) {
            Service.send_box_ThongBao_OK(p, "Chưa Kích hoạt không thể đăng bán vật phẩm");
            return;
         }

         if (p.get_vnd() < 2000) {
            Service.send_box_ThongBao_OK(p, "Bạn không đủ 2000 extol để đăng bán");
            return;
         }

         if (cat == 4) {
            if (p.item.total_item_bag_by_id(4, id) < value) {
               Service.send_box_ThongBao_OK(p, "Bạn không đủ " + value + " " + ItemTemplate4.get_item_name(id) + " để đăng bán");
               return;
            }

            if (check_it_47_cant_sell(4, id)) {
               Service.send_box_ThongBao_OK(p, "Không thể đăng bán vật phẩm này");
               return;
            }
         } else {
            if (p.item.total_item_bag_by_id(7, id) < value) {
               Service.send_box_ThongBao_OK(p, "Bạn không đủ " + value + " " + ItemTemplate7.get_item_name(id) + " để đăng bán");
               return;
            }

            if (check_it_47_cant_sell(7, id)) {
               Service.send_box_ThongBao_OK(p, "Không thể đăng bán vật phẩm này");
               return;
            }
         }

         Market get_market = get_list_my_item(p);
         if (get_market == null || get_market.item3.size() + get_market.item47.size() >= 5) {
            Service.send_box_ThongBao_OK(p, "Bạn không đủ chỗ trống trên chợ mua bán, tối đa bán 5 item");
            return;
         }

         p.data_yesno = new int[]{cat, id, value};
         Service.input_text(p, 7, "Đăng bán", new String[]{"Giá bán"});
      } else if (type == 5 && index_market == 3 && cat == 3 && value == 1) {
         Market index_sell = null;
         ItemMarket it_receive = null;

         for (int i = 0; i < ENTRY.size(); i++) {
            Market market = ENTRY.get(i);

            for (int j = 0; j < market.item3.size(); j++) {
               if (market.item3.get(j).index == id) {
                  it_receive = market.item3.get(j);
                  index_sell = market;
                  break;
               }
            }

            if (it_receive != null && index_sell != null) {
               break;
            }
         }

         if (it_receive != null && it_receive.time_market < System.currentTimeMillis() && index_sell != null) {
            p.data_yesno = new int[]{index_sell.type, it_receive.index};
            if (it_receive.type_market == 2) {
               int price_receive = (int)(it_receive.price_market * 90L / 100L);
               Service.send_box_yesno(
                  p,
                  19,
                  "Thông báo",
                  "Bạn có muốn nhận về tiền bán vật phẩm là " + price_receive + " extol không?",
                  new String[]{"Đồng ý", "Hủy"},
                  new byte[]{-1, -1}
               );
            } else {
               Service.send_box_yesno(
                  p,
                  19,
                  "Thông báo",
                  "Bạn có muốn nhận về hành trang trang bị " + it_receive.template.name + " không",
                  new String[]{"Đồng ý", "Hủy"},
                  new byte[]{-1, -1}
               );
            }
         }
      } else if (type == 11 && index_market == 3 && cat == 3 && value == 1) {
         Market index_sell = null;
         ItemMarket it_receive = null;

         for (int i = 0; i < ENTRY.size(); i++) {
            Market market = ENTRY.get(i);

            for (int jx = 0; jx < market.item3.size(); jx++) {
               if (market.item3.get(jx).index == id) {
                  it_receive = market.item3.get(jx);
                  index_sell = market;
                  break;
               }
            }

            if (it_receive != null && index_sell != null) {
               break;
            }
         }

         if (it_receive != null && it_receive.type_market == 3 && it_receive.time_market < System.currentTimeMillis() && index_sell != null) {
            p.data_yesno = new int[]{index_sell.type, it_receive.index};
            Service.send_box_yesno(
               p, 23, "Thông báo", "Bạn có muốn gia hạn thêm thời gian bán với giá 1.500 extol không?", new String[]{"Đồng ý", "Hủy"}, new byte[]{-1, -1}
            );
         }
      } else if (type == 5 && index_market == 3 && (cat == 4 || cat == 7) && value == 1) {
         Market index_sell = null;
         PotionMarket it_receive = null;

         for (int i = 0; i < ENTRY.size(); i++) {
            Market market = ENTRY.get(i);

            for (int jxx = 0; jxx < market.item47.size(); jxx++) {
               if (market.item47.get(jxx).index == id) {
                  it_receive = market.item47.get(jxx);
                  index_sell = market;
                  break;
               }
            }

            if (it_receive != null && index_sell != null) {
               break;
            }
         }

         if (it_receive != null && it_receive.time_market < System.currentTimeMillis() && index_sell != null) {
            p.data_yesno = new int[]{index_sell.type, it_receive.index};
            if (it_receive.type_market == 2) {
               int price_receive = (int)(it_receive.price_market * 90L / 100L);
               Service.send_box_yesno(
                  p,
                  21,
                  "Thông báo",
                  "Bạn có muốn nhận về tiền bán vật phẩm là " + price_receive + " extol không?",
                  new String[]{"Đồng ý", "Hủy"},
                  new byte[]{-1, -1}
               );
            } else if (it_receive.category == 4) {
               Service.send_box_yesno(
                  p,
                  21,
                  "Thông báo",
                  "Bạn có muốn nhận " + it_receive.quant + " " + ItemTemplate4.get_item_name(it_receive.id) + " về hành trang không",
                  new String[]{"Đồng ý", "Hủy"},
                  new byte[]{-1, -1}
               );
            } else if (it_receive.category == 7) {
               Service.send_box_yesno(
                  p,
                  21,
                  "Thông báo",
                  "Bạn có muốn nhận " + it_receive.quant + " " + ItemTemplate7.get_item_name(it_receive.id) + " về hành trang không",
                  new String[]{"Đồng ý", "Hủy"},
                  new byte[]{-1, -1}
               );
            }
         }
      } else if (type == 6 && index_market == 3 && cat == 3 && value == 1) {
         Market index_sell = null;
         ItemMarket it_receive = null;

         for (int i = 0; i < ENTRY.size(); i++) {
            Market market = ENTRY.get(i);

            for (int jxxx = 0; jxxx < market.item3.size(); jxxx++) {
               if (market.item3.get(jxxx).index == id) {
                  it_receive = market.item3.get(jxxx);
                  index_sell = market;
                  break;
               }
            }

            if (it_receive != null && index_sell != null) {
               break;
            }
         }

         if (it_receive != null && it_receive.time_market > System.currentTimeMillis() && index_sell != null) {
            p.data_yesno = new int[]{index_sell.type, it_receive.index};
            Service.send_box_yesno(
               p, 20, "Thông báo", "Bạn có muốn dừng bán " + it_receive.template.name + " không?", new String[]{"Đồng ý", "Hủy"}, new byte[]{-1, -1}
            );
         }
      } else if (type == 6 && index_market == 3 && (cat == 4 || cat == 7) && value == 1) {
         Market index_sell = null;
         PotionMarket it_receive = null;

         for (int i = 0; i < ENTRY.size(); i++) {
            Market market = ENTRY.get(i);

            for (int jxxxx = 0; jxxxx < market.item47.size(); jxxxx++) {
               if (market.item47.get(jxxxx).index == id) {
                  it_receive = market.item47.get(jxxxx);
                  index_sell = market;
                  break;
               }
            }

            if (it_receive != null && index_sell != null) {
               break;
            }
         }

         if (it_receive != null && it_receive.time_market > System.currentTimeMillis() && index_sell != null) {
            p.data_yesno = new int[]{index_sell.type, it_receive.index};
            if (it_receive.category == 4) {
               if (it_receive.id == 0) {
                  Service.send_box_yesno(
                     p, 24, "Thông báo", "Bạn có muốn dừng bán " + it_receive.quant + " triệu beri không?", new String[]{"Đồng ý", "Hủy"}, new byte[]{-1, -1}
                  );
               } else {
                  Service.send_box_yesno(
                     p,
                     24,
                     "Thông báo",
                     "Bạn có muốn dừng bán " + it_receive.quant + " " + ItemTemplate4.get_item_name(it_receive.id) + " không?",
                     new String[]{"Đồng ý", "Hủy"},
                     new byte[]{-1, -1}
                  );
               }
            } else {
               Service.send_box_yesno(
                  p,
                  24,
                  "Thông báo",
                  "Bạn có muốn dừng bán " + it_receive.quant + " " + ItemTemplate7.get_item_name(it_receive.id) + " không?",
                  new String[]{"Đồng ý", "Hủy"},
                  new byte[]{-1, -1}
               );
            }
         }
      } else if (type == 0 && cat == 3 && value == 1) {
         Market index_sell = null;
         ItemMarket it_receive = null;

         for (int i = 0; i < ENTRY.size(); i++) {
            Market market = ENTRY.get(i);

            for (int jxxxxx = 0; jxxxxx < market.item3.size(); jxxxxx++) {
               if (market.item3.get(jxxxxx).index == id) {
                  it_receive = market.item3.get(jxxxxx);
                  index_sell = market;
                  break;
               }
            }

            if (it_receive != null && index_sell != null) {
               break;
            }
         }

         if (it_receive != null && index_sell != null) {
            if (p.conn.status != 1) {
               Service.send_box_ThongBao_OK(p, "Chưa Kích hoạt không thể mua vật phẩm");
               return;
            }

            if (it_receive.time_market > System.currentTimeMillis()) {
               p.data_yesno = new int[]{index_sell.type, it_receive.index};
               Service.send_box_yesno(
                  p,
                  25,
                  "Thông báo",
                  "Bạn có muốn mua " + it_receive.template.name + " với giá " + it_receive.price_market + " extol không?",
                  new String[]{"Đồng ý", "Hủy"},
                  new byte[]{-1, -1}
               );
            } else {
               Service.send_box_ThongBao_OK(p, "Vật phẩm đã hết thời gian rao bán");
            }
         }
      } else if (type == 0 && (cat == 4 && index_market == 6 || cat == 7 && index_market == 5) && value == 1) {
         Market index_sell = null;
         PotionMarket it_receive = null;

         for (int i = 0; i < ENTRY.size(); i++) {
            Market market = ENTRY.get(i);

            for (int jxxxxxx = 0; jxxxxxx < market.item47.size(); jxxxxxx++) {
               if (market.item47.get(jxxxxxx).index == id) {
                  it_receive = market.item47.get(jxxxxxx);
                  index_sell = market;
                  break;
               }
            }

            if (it_receive != null && index_sell != null) {
               break;
            }
         }

         if (it_receive != null && index_sell != null) {
            if (it_receive.time_market > System.currentTimeMillis()) {
               if (p.conn.status != 1) {
                  Service.send_box_ThongBao_OK(p, "Chưa Kích hoạt không thể mua vật phẩm");
                  return;
               }

               p.data_yesno = new int[]{index_sell.type, it_receive.index};
               if (cat == 4) {
                  if (it_receive.id == 0) {
                     Service.send_box_yesno(
                        p,
                        26,
                        "Thông báo",
                        "Bạn có muốn mua " + it_receive.quant + " triệu beri với giá " + it_receive.price_market + " extol không?",
                        new String[]{"Đồng ý", "Hủy"},
                        new byte[]{-1, -1}
                     );
                  } else {
                     Service.send_box_yesno(
                        p,
                        26,
                        "Thông báo",
                        "Bạn có muốn mua "
                           + it_receive.quant
                           + " "
                           + ItemTemplate4.get_item_name(it_receive.id)
                           + " với giá "
                           + it_receive.price_market
                           + " extol không?",
                        new String[]{"Đồng ý", "Hủy"},
                        new byte[]{-1, -1}
                     );
                  }
               } else {
                  Service.send_box_yesno(
                     p,
                     26,
                     "Thông báo",
                     "Bạn có muốn mua "
                        + it_receive.quant
                        + " "
                        + ItemTemplate7.get_item_name(it_receive.id)
                        + " với giá "
                        + it_receive.price_market
                        + " extol không?",
                     new String[]{"Đồng ý", "Hủy"},
                     new byte[]{-1, -1}
                  );
               }
            } else {
               Service.send_box_ThongBao_OK(p, "Vật phẩm đã hết thời gian rao bán");
            }
         }
      } else if (type == 8 && id == 0 && cat == 0 && value == 1) {
         Message m = new Message(44);
         m.writer().writeByte(8);
         m.writer().writeByte(1);
         p.conn.addmsg(m);
         m.cleanup();
      } else if (type == 1 && id == 0 && cat == 0 && value == 1) {
         update_at_market_index(p, index_market);
      }
   }

   public static boolean check_it_47_cant_sell(int i, int id) {
      if (i == 4) {
         ItemTemplate4 temp4 = ItemTemplate4.get_it_by_id(id);
         if (temp4 != null) {
            if (temp4.type != 74 && temp4.id != 339 && temp4.id != 519 && temp4.id != 455) {
               return temp4.istrade == 1;
            }

            return false;
         }
      } else {
         ItemTemplate7 temp7 = ItemTemplate7.get_it_by_id(id);
         if (temp7 != null) {
            if (temp7.id != 4 && temp7.id != 10) {
               return temp7.istrade == 1;
            }

            return false;
         }
      }

      return true;
   }

   public static void update() {
      Connection connection = null;
      PreparedStatement ps = null;

      try {
         connection = SQL.gI().getCon();
         ps = connection.prepareStatement("UPDATE `market` SET `data` = ? WHERE `id` = ?");

         for (int i = 0; i < ENTRY.size(); i++) {
            Market market = ENTRY.get(i);
            JSONObject jsob = new JSONObject();
            jsob.put("item3", market.get_json_item3(market.item3));
            jsob.put("item47", market.get_json_item47(market.item47));
            ps.clearParameters();
            ps.setNString(1, jsob.toJSONString());
            ps.setInt(2, market.type);
            ps.executeUpdate();
         }
      } catch (SQLException var13) {
         var13.printStackTrace();
      } finally {
         try {
            if (ps != null) {
               ps.close();
            }

            if (connection != null) {
               connection.close();
            }
         } catch (SQLException var12) {
            var12.printStackTrace();
         }
      }
   }

   private String get_json_item47(List<PotionMarket> list) {
      JSONArray js = new JSONArray();

      for (int i = 0; i < list.size(); i++) {
         PotionMarket it = list.get(i);
         JSONArray js2 = new JSONArray();
         js2.add(it.id);
         js2.add(it.category);
         js2.add(it.quant);
         js2.add(it.time_market - System.currentTimeMillis());
         js2.add(it.price_market);
         js2.add(it.seller);
         js2.add(it.type_market);
         js.add(js2);
      }

      return js.toJSONString();
   }

   public String get_json_item3(List<ItemMarket> list) {
      JSONArray js = new JSONArray();

      for (int i = 0; i < list.size(); i++) {
         ItemMarket it = list.get(i);
         JSONArray js2 = new JSONArray();
         js2.add(it.template.id);
         js2.add(it.levelup);
         js2.add(it.typelock);
         js2.add(it.numHoleDaDuc);
         js2.add(it.timeUse);
         js2.add(it.valueChetac);
         js2.add(it.isHoanMy);
         js2.add(it.valueKichAn);
         JSONArray js3 = new JSONArray();

         for (int j = 0; j < it.option_item.size(); j++) {
            JSONArray js4 = new JSONArray();
            js4.add(it.option_item.get(j).id);
            js4.add(it.option_item.get(j).getParam());
            js3.add(js4);
         }

         js2.add(js3);
         JSONArray js5 = new JSONArray();
         js2.add(js5);
         js2.add(it.numLoKham);
         JSONArray js6 = new JSONArray();

         for (int j = 0; j < it.mdakham.length; j++) {
            js6.add(it.mdakham[j]);
         }

         js2.add(js6);
         js2.add(it.time_market - System.currentTimeMillis());
         js2.add(it.price_market);
         js2.add(it.seller);
         js2.add(it.type_market);
         js.add(js2);
      }

      return js.toJSONString();
   }

   public static short get_index() {
      return INDEX++;
   }
}
