package io;

import activities.UpgradeItem;
import client.Clan;
import client.Item;
import client.MessageHandler;
import client.Player;
import core.Manager;
import core.Service;
import database.SQL;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.net.Socket;
import java.net.SocketException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.TimeUnit;
import java.util.regex.Pattern;
import map.Map;
import org.joda.time.DateTime;
import org.json.simple.JSONArray;
import org.json.simple.JSONValue;
import template.DataTemplate;
import template.DataUpgrade;
import template.ItemFashion;
import template.ItemFashionP;
import template.ItemFashionP2;
import template.ItemOptionTemplate;
import template.ItemTemplate3;
import template.ItemTemplate4;
import template.ItemTemplate7;
import template.ItemTemplate8;
import template.Item_wear;
import template.MobTemplate;
import template.Part;

public class Session implements Runnable {
   private static final byte[] KEYS = "truongbk@".getBytes();
   private final Socket socket;
   private DataInputStream dis;
   private DataOutputStream dos;
   private Thread sendd;
   private Thread receiv;
   public boolean connected;
   private final BlockingQueue<Message> list_msg;
   private boolean sendKeyComplete;
   private byte curR;
   private byte curW;
   public String user;
   public String pass;
   private final MessageHandler controller;
   public Player p;
   public List<String> list_char;
   public byte zoomlv;
   public String version;
   public byte lock;
   public byte status;
   public int coin;
   public int vip;
   private boolean getImgAPK = false;

   public Session(Socket socket) {
      this.socket = socket;
      this.list_msg = new LinkedBlockingQueue<>();
      this.sendKeyComplete = false;
      this.connected = false;
      this.controller = new MessageHandler(this);
   }

   public void init() {
      try {
         this.dis = new DataInputStream(this.socket.getInputStream());
         this.dos = new DataOutputStream(this.socket.getOutputStream());
         this.sendd = new Thread(() -> {
            try {
               while (this.connected) {
                  Message m = this.list_msg.poll(10L, TimeUnit.SECONDS);
                  if (m != null) {
                     this.send_msg(m);
                     m.cleanup();
                  }
               }
            } catch (InterruptedException var6) {
               Thread.currentThread().interrupt();
            } catch (IOException var7) {
               if (!this.isNormalDisconnect(var7)) {
                  var7.printStackTrace();
               }
            } finally {
               this.disconnect();
            }
         });
         this.receiv = new Thread(this);
         this.connected = true;
         this.receiv.start();
         this.sendd.start();
      } catch (IOException var2) {
         var2.printStackTrace();
      }
   }

   public void disconnect() {
      SessionManager.client_disconnect(this);
   }

   public void addmsg(Message m) throws IOException {
      if (this.connected) {
         m.writer().flush();
         this.list_msg.add(m);
      }
   }

   @Override
   public void run() {
      try {
         while (this.connected) {
            Message m = this.read_msg();
            if (m != null) {
               if (m.cmd == -27) {
                  this.sendkeys();
               } else if (this.sendKeyComplete) {
                  try {
                     this.controller.process_msg(m);
                  } catch (Exception var7) {
                     var7.printStackTrace();
                     System.err.println("err process_msg: " + var7.getMessage());
                  }
               }

               m.cleanup();
            }
         }
      } catch (IOException var8) {
         if (!this.isNormalDisconnect(var8)) {
            var8.printStackTrace();
         }
      } finally {
         this.disconnect();
      }
   }

   private boolean isNormalDisconnect(IOException e) {
      if (this.connected && !(e instanceof SocketException) && !(e instanceof EOFException)) {
         String msg = e.getMessage();
         return msg != null
            && (
               msg.contains("Connection reset")
                  || msg.contains("Socket closed")
                  || msg.contains("Connection aborted")
                  || msg.contains("An existing connection was forcibly closed")
            );
      } else {
         return true;
      }
   }

   private void send_msg(Message msg) throws IOException {
      byte[] data = msg.getData();
      if (Manager.gI().debug) {
         System.out.println("SEND cmd=" + msg.cmd + " size=" + (data == null ? 0 : data.length));
      }
      if (this.sendKeyComplete) {
         byte b = this.writeKey(msg.cmd);
         this.dos.writeByte(b);
      } else {
         this.dos.writeByte(msg.cmd);
      }

      if (data != null) {
         int size = data.length;
         if (this.sendKeyComplete) {
            if (msg.cmd != -39 && msg.cmd != -101 && msg.cmd != -93 && msg.cmd != 76) {
               int byte1 = this.writeKey((byte)(size >> 8));
               this.dos.writeByte(byte1);
               int byte2 = this.writeKey((byte)size);
               this.dos.writeByte(byte2);
            } else {
               this.dos.writeByte(this.writeKey((byte)(size >> 24)));
               this.dos.writeByte(this.writeKey((byte)(size >> 16)));
               this.dos.writeByte(this.writeKey((byte)(size >> 8)));
               this.dos.writeByte(this.writeKey((byte)size));
            }
         } else if (msg.cmd == -39) {
            this.dos.writeInt(size);
         } else {
            int byte1 = (byte)(size & 0xFF00);
            this.dos.writeByte(byte1);
            int byte2 = (byte)(size & 0xFF);
            this.dos.writeByte(byte2);
         }

         if (this.sendKeyComplete) {
            for (int i = 0; i < data.length; i++) {
               data[i] = this.writeKey(data[i]);
            }
         }

         this.dos.write(data);
      } else {
         this.dos.writeShort(0);
      }

      this.dos.flush();
      msg.cleanup();
   }

   private Message read_msg() throws IOException {
      byte cmd = this.dis.readByte();
      if (this.sendKeyComplete) {
         cmd = this.readKey(cmd);
      }

      int size;
      if (this.sendKeyComplete) {
         byte b1 = this.dis.readByte();
         byte b2 = this.dis.readByte();
         size = (this.readKey(b1) & 255) << 8 | this.readKey(b2) & 255;
      } else {
         size = this.dis.readShort();
      }

      byte[] data = new byte[size];
      int len = 0;
      int byteRead = 0;

      while (len != -1 && byteRead < size) {
         len = this.dis.read(data, byteRead, size - byteRead);
         if (len > 0) {
            byteRead += len;
         }
      }

      if (this.sendKeyComplete) {
         for (int i = 0; i < data.length; i++) {
            data[i] = this.readKey(data[i]);
         }
      }

      if (Manager.gI().debug) {
         System.out.println("RECV cmd=" + cmd + " size=" + size + (cmd == -38 && data.length > 0 ? " zoom=" + data[0] : ""));
      }

      return new Message(cmd, data);
   }

   private byte readKey(byte b) {
      byte curR = this.curR;
      this.curR = (byte)(curR + 1);
      byte i = (byte)(KEYS[curR] & 255 ^ b & 255);
      if (this.curR >= KEYS.length) {
         this.curR = (byte)(this.curR % (byte)KEYS.length);
      }

      return i;
   }

   private byte writeKey(byte b) {
      byte curW = this.curW;
      this.curW = (byte)(curW + 1);
      byte i = (byte)(KEYS[curW] & 255 ^ b & 255);
      if (this.curW >= KEYS.length) {
         this.curW = (byte)(this.curW % (byte)KEYS.length);
      }

      return i;
   }

   public void sendkeys() throws IOException {
      Message msg = new Message(-27);
      msg.writer().writeByte(KEYS.length);
      msg.writer().writeByte(KEYS[0]);

      for (int i = 1; i < KEYS.length; i++) {
         msg.writer().writeByte(KEYS[i] ^ KEYS[i - 1]);
      }

      this.send_msg(msg);
      msg.cleanup();
      this.sendKeyComplete = true;
   }

   public void request_data_update(Message m) throws IOException {
      byte type = m.reader().readByte();
      if (type == 3 && this.p != null && this.p.conn != null) {
         this.p.send_skill();
      } else {
         Message m2 = new Message(-7);
         switch (type) {
            case 2:
               m2.writer().writeByte(2);
               m2.writer().writeShort(ItemOptionTemplate.ENTRYS.size());

               for (int i = 0; i < ItemOptionTemplate.ENTRYS.size(); i++) {
                  m2.writer().writeUTF(ItemOptionTemplate.ENTRYS.get(i).name);
                  m2.writer().writeByte(ItemOptionTemplate.ENTRYS.get(i).color);
                  m2.writer().writeByte(ItemOptionTemplate.ENTRYS.get(i).percent);
               }

               m2.writer().writeShort(791);
            case 3:
            case 5:
            case 9:
            case 14:
            case 16:
            case 20:
            case 22:
            case 23:
            case 24:
            case 25:
            default:
               break;
            case 4:
               m2.writer().writeByte(4);
               m2.writer().writeByte(DataTemplate.mLockMap.length);
               m2.writer().write(DataTemplate.mLockMap);
               break;
            case 6:
               m2.writer().writeByte(6);
               byte[] ab = null;

               try (FileInputStream fis = new FileInputStream("data/msg/login/request/msg-7_6")) {
                  ab = new byte[fis.available() - 2];
                  fis.read(ab, 0, ab.length);
               } catch (IOException var10) {
                  ab = null;
               }

               if (ab == null) {
                  System.out.println("err data type 6");
                  return;
               }

               m2.writer().write(ab);
               m2.writer().writeShort(369);
               break;
            case 7:
               m2.writer().writeByte(7);
               m2.writer().writeShort(DataTemplate.NamePotionquest.length);

               for (int ix = 0; ix < DataTemplate.NamePotionquest.length; ix++) {
                  m2.writer().writeUTF(DataTemplate.NamePotionquest[ix]);
               }

               m2.writer().writeShort(258);
               break;
            case 8:
               m2.writer().writeByte(8);
               m2.writer().writeShort(DataTemplate.TabInventory_ItemSell[0]);
               m2.writer().writeShort(DataTemplate.TabInventory_ItemSell[1]);
               m2.writer().writeShort(DataTemplate.TabInventory_ItemSell[2]);
               break;
            case 10:
               m2.writer().writeByte(10);
               m2.writer().writeByte(DataTemplate.mMapLang.length);

               for (int i = 0; i < DataTemplate.mMapLang.length; i++) {
                  m2.writer().writeShort(DataTemplate.mMapLang[i]);
               }
               break;
            case 11:
               m2.writer().writeByte(11);
               m2.writer().writeByte(ItemTemplate7.ENTRYS.size());

               for (int i = 0; i < ItemTemplate7.ENTRYS.size(); i++) {
                  ItemTemplate7 temp = ItemTemplate7.ENTRYS.get(i);
                  m2.writer().writeByte(temp.id);
                  m2.writer().writeUTF(temp.name);
                  m2.writer().writeByte(temp.type);
                  m2.writer().writeByte(temp.icon);
                  m2.writer().writeInt(temp.price);
                  m2.writer().writeShort(temp.priceruby);
                  m2.writer().writeByte(temp.istrade);
               }
               break;
            case 12:
               m2.writer().writeByte(12);
               m2.writer().writeByte(UpgradeItem.DATA.size());

               for (int ix = 0; ix < UpgradeItem.DATA.size(); ix++) {
                  DataUpgrade temp = UpgradeItem.DATA.get(ix);
                  m2.writer().writeByte(temp.level);
                  m2.writer().writeShort(temp.per);
                  m2.writer().writeByte(temp.prelevel);
                  m2.writer().writeInt(temp.beri);
                  m2.writer().writeInt(temp.beri_white);
                  m2.writer().writeShort(temp.ruby);
                  m2.writer().writeShort(temp.att);
                  m2.writer().writeByte(temp.material.length);

                  for (int jx = 0; jx < temp.material.length; jx++) {
                     m2.writer().writeByte(temp.material[jx].type);
                     m2.writer().writeByte(temp.material[jx].id);
                     m2.writer().writeShort(temp.material[jx].quant);
                  }
               }

               m2.writer().writeShort(753);
               break;
            case 13:
               m2.writer().writeByte(13);
               m2.writer().writeByte(DataTemplate.mSea.length);

               for (int ix = 0; ix < DataTemplate.mSea.length; ix++) {
                  for (int jx = 0; jx < DataTemplate.mSea[ix].length; jx++) {
                     m2.writer().writeShort(DataTemplate.mSea[ix][jx]);
                  }
               }
               break;
            case 15:
               m2.writer().writeByte(15);
               m2.writer().writeShort(MobTemplate.ENTRYS.size());

               for (int i = 0; i < MobTemplate.ENTRYS.size(); i++) {
                  MobTemplate temp = MobTemplate.ENTRYS.get(i);
                  m2.writer().writeShort(temp.mob_id);
                  m2.writer().writeUTF(temp.name);
                  m2.writer().writeShort(temp.level);
                  m2.writer().writeShort(temp.hOne);
                  m2.writer().writeInt(temp.hp_max);
                  m2.writer().writeByte(temp.typemove);
                  m2.writer().writeByte(temp.ishuman);
                  m2.writer().writeByte(temp.typemonster);
                  if (temp.ishuman == 1) {
                     m2.writer().writeShort(temp.head);
                     m2.writer().writeShort(temp.hair);
                     m2.writer().writeByte(temp.wearing.length);

                     for (int j = 0; j < temp.wearing.length; j++) {
                        if (temp.wearing[j] != -1) {
                           m2.writer().writeByte(1);
                           m2.writer().writeShort(temp.wearing[j]);
                        } else {
                           m2.writer().writeByte(-1);
                        }
                     }
                  } else {
                     m2.writer().writeShort(temp.icon);
                  }
               }

               m2.writer().writeShort(125);
               break;
            case 17:
               m2.writer().writeByte(17);
               m2.writer().writeLong(System.currentTimeMillis());
               break;
            case 18:
            case 29:
               m2.writer().writeByte(18);
               m2.writer().writeShort(ItemTemplate8.ENTRYS.size());

               for (int i = 0; i < ItemTemplate8.ENTRYS.size(); i++) {
                  ItemTemplate8 temp = ItemTemplate8.ENTRYS.get(i);
                  m2.writer().writeShort(temp.id);
                  m2.writer().writeShort(temp.icon);
                  m2.writer().writeUTF(temp.name);
                  m2.writer().writeUTF(temp.info);
                  m2.writer().writeInt(temp.beri);
                  m2.writer().writeShort(temp.ruby);
                  m2.writer().writeByte(temp.istrade);
                  m2.writer().writeByte(temp.type);
                  m2.writer().writeShort(temp.timedelay);
                  m2.writer().writeShort(temp.value);
                  m2.writer().writeShort(temp.timeactive);
                  m2.writer().writeUTF(temp.nameuse);
               }

               m2.writer().writeShort(160);
               break;
            case 19:
               m2.writer().writeByte(19);
               m2.writer().writeByte(DataTemplate.mTileUpdate.length);

               for (int i = 0; i < DataTemplate.mTileUpdate.length; i++) {
                  m2.writer().writeShort(DataTemplate.mTileUpdate[i]);
               }

               m2.writer().writeByte(DataTemplate.mTileGhepĐa.length);

               for (int i = 0; i < DataTemplate.mTileGhepĐa.length; i++) {
                  m2.writer().writeShort(DataTemplate.mTileGhepĐa[i]);
               }
               break;
            case 21:
               m2.writer().writeByte(21);
               m2.writer().writeByte(0);
               break;
            case 26:
               m2.writer().writeByte(26);
               m2.writer().writeByte(DataTemplate.AttriKichAn.length);

               for (int i = 0; i < DataTemplate.AttriKichAn.length; i++) {
                  m2.writer().writeUTF(DataTemplate.AttriKichAn[i]);
               }

               m2.writer().writeShort(-31525);
               break;
            case 27:
               m2.writer().writeByte(27);
               m2.writer().writeByte(0);
               break;
            case 28:
               m2.writer().writeByte(28);
               m2.writer().writeShort(ItemTemplate4.ENTRYS.size());

               for (int i = 0; i < ItemTemplate4.ENTRYS.size(); i++) {
                  ItemTemplate4 temp = ItemTemplate4.ENTRYS.get(i);
                  m2.writer().writeShort(temp.id);
                  m2.writer().writeShort(temp.icon);
                  m2.writer().writeUTF(temp.name);
                  m2.writer().writeShort(temp.indexInfoPotion);
                  m2.writer().writeInt(temp.beri);
                  m2.writer().writeShort(temp.ruby);
                  m2.writer().writeByte(temp.istrade);
                  m2.writer().writeByte(temp.type);
                  m2.writer().writeShort(temp.timedelay);
                  m2.writer().writeShort(temp.value);
                  m2.writer().writeShort(temp.timeactive);
                  m2.writer().writeUTF(temp.nameuse);
               }

               m2.writer().writeShort(314);
               break;
            case 30:
               m2.writer().writeByte(30);
               m2.writer().writeByte(DataTemplate.mEffSpec.length);

               for (int i = 0; i < DataTemplate.mEffSpec.length; i++) {
                  m2.writer().writeUTF(DataTemplate.mEffSpec[i]);
               }

               m2.writer().writeShort(-7547);
         }

         if (m2.writer().size() > 0) {
            this.addmsg(m2);
         }

         m2.cleanup();
      }
   }

   public void send_data_from_server(Message m) throws IOException {
      if (!this.getImgAPK) {
         this.getImgAPK = true;
         this.zoomlv = m.reader().readByte();
         Thread send = new Thread(() -> {
            try {
               String path = "data/datafromsver/x" + this.zoomlv;
               File folder = new File(path);
               File[] files = folder.listFiles();
               if (files == null || files.length == 0) {
                  // ponytail: this Unity client bundles the baseline UI; add update packs here when available.
                  Message done = new Message(-40);
                  this.addmsg(done);
                  done.cleanup();
                  return;
               }
                  Arrays.sort(files, new Comparator<File>() {
                     public int compare(File o1, File o2) {
                        int name1 = this.solve_name(o1.getName());
                        int name2 = this.solve_name(o2.getName());
                        return name1 > name2 ? 1 : -1;
                     }

                     private int solve_name(String name) {
                        String num = "";

                        for (int i = 0; i < name.length() && name.charAt(i) != '_'; i++) {
                           num = num + name.charAt(i);
                        }

                        return Integer.parseInt(num);
                     }
                  });

                  for (int i = 0; i < files.length; i++) {
                     int cmd = Integer.parseInt(files[i].getName().substring(files[i].getName().length() - 3, files[i].getName().length()));
                     Service.send_msg_data(this, cmd, files[i].getAbsolutePath(), false);
                  }
                  Message done = new Message(-40);
                  this.addmsg(done);
                  done.cleanup();
            } catch (IOException var6) {
               var6.printStackTrace();
            }
         });
         send.start();
      }
   }

   public void login(Message m) throws IOException {
      byte type = m.reader().readByte();
      String user_ = m.reader().readUTF().replace(" ", "");
      String pass_ = m.reader().readUTF().replace(" ", "");
      long time_can_login_again = 0L;
      if (SessionManager.CLIENT_LOGIN_TIME.containsKey(user_)) {
         long time_can_login = SessionManager.CLIENT_LOGIN_TIME.get(user_);
         if (time_can_login > System.currentTimeMillis()) {
            SessionManager.CLIENT_LOGIN_TIME.replace(user_, time_can_login, time_can_login);
            time_can_login_again = (time_can_login - System.currentTimeMillis()) / 1000L;
         } else {
            SessionManager.CLIENT_LOGIN_TIME.remove(user_);
         }
      }

      this.lock = 0;
      this.coin = 0;
      this.coin = 0;
      this.status = 0;
      this.list_char = new ArrayList<>();
      if (type == 0) {
         Pattern p = Pattern.compile("^[a-zA-Z0-9@.]{1,30}$");
         if (!p.matcher(user_).matches() || !p.matcher(pass_).matches()) {
            this.login_notice("Ký tự không hợp lệ");
            return;
         }

         if (Manager.gI().server_admin) {
            SessionManager.time_login.clear();
         }

         if (SessionManager.time_login.containsKey(user_) && !user_.equals("admin")) {
            long time_login = SessionManager.time_login.get(user_);
            if (time_login > System.currentTimeMillis()) {
               long time_login_after = (time_login - System.currentTimeMillis()) / 1000L;
               if (time_login_after < 120L) {
                  this.login_after_time(time_login_after);
               }

               return;
            }
         }

         Connection conn = null;
         PreparedStatement ps = null;
         ResultSet rs = null;

         try {
            conn = SQL.gI().getCon();
            ps = conn.prepareStatement("SELECT * FROM `accounts` WHERE BINARY `user` = ? AND BINARY `pass` = ? LIMIT 1;");
            ps.setString(1, user_);
            ps.setString(2, pass_);
            rs = ps.executeQuery();
            if (!rs.next()) {
               this.login_notice("Tài khoản mật khẩu không chính xác" + (time_can_login_again > 0L ? ".\nThử lại sau " + time_can_login_again + "s" : ""));
               if (!SessionManager.CLIENT_LOGIN_TIME.containsKey(user_)) {
                  SessionManager.CLIENT_LOGIN_TIME.put(user_, System.currentTimeMillis() + 1000L);
               }

               return;
            }

            this.vip = rs.getInt("vip");
            this.coin = rs.getInt("coin");
            this.status = rs.getByte("status");
            this.lock = rs.getByte("lock");
            if (this.lock != 0) {
               this.login_notice("Tài khoản bị khóa để kiểm tra, liên hệ admin để biết chi tiết, đừng spam tin nhắn kẻo bị t tắt thông báo!");
               return;
            }

            JSONArray js = (JSONArray)JSONValue.parse(rs.getString("char"));

            for (int i = 0; i < js.size(); i++) {
               this.list_char.add(js.get(i).toString());
            }
         } catch (SQLException var45) {
            var45.printStackTrace();
            return;
         } finally {
            try {
               if (rs != null) {
                  rs.close();
               }

               if (ps != null) {
                  ps.close();
               }

               if (conn != null) {
                  conn.close();
               }
            } catch (SQLException var42) {
               var42.printStackTrace();
            }
         }
      } else {
         if (user_.equals("") && pass_.equals("")) {
            this.login_notice("Truy cập hanhtrinhhaitac.com để đăng ký");
            return;
         }

         pass_ = "1";
         Connection conn = null;
         PreparedStatement ps = null;
         ResultSet rs = null;

         try {
            conn = SQL.gI().getCon();
            ps = conn.prepareStatement("SELECT * FROM `accounts` WHERE BINARY `user` = ? AND BINARY `pass` = ? LIMIT 1;");
            ps.setString(1, user_);
            ps.setString(2, pass_);
            rs = ps.executeQuery();
            if (!rs.next()) {
               this.login_notice("Tài khoản mật khẩu không chính xác");
               return;
            }

            this.lock = rs.getByte("lock");
            if (this.lock != 0) {
               this.login_notice("Tài khoản bị khóa, liên hệ admin để biết thêm chi tiết");
               return;
            }

            JSONArray js = (JSONArray)JSONValue.parse(rs.getString("char"));

            for (int i = 0; i < js.size(); i++) {
               this.list_char.add(js.get(i).toString());
            }
         } catch (SQLException var43) {
            var43.printStackTrace();
            return;
         } finally {
            try {
               if (rs != null) {
                  rs.close();
               }

               if (ps != null) {
                  ps.close();
               }

               if (conn != null) {
                  conn.close();
               }
            } catch (SQLException var41) {
               var41.printStackTrace();
            }
         }
      }

      this.zoomlv = m.reader().readByte();
      this.version = m.reader().readUTF();
      m.reader().readByte();
      byte IndexCharSelected = m.reader().readByte();
      this.user = user_;
      this.pass = pass_;
      if (!this.check_onl()) {
         this.update_onl(1);
      } else {
         for (int i = SessionManager.CLIENT_ENTRYS.size() - 1; i >= 0; i--) {
            Session ss = SessionManager.CLIENT_ENTRYS.get(i);
            if (ss != this && ss.user != null && ss.user.equals(this.user)) {
               ss.disconnect();
            }
         }

         this.update_onl(1);
      }

      for (int ix = 0; ix < this.list_char.size(); ix++) {
         Player p0 = Map.get_player_by_name_allmap(this.list_char.get(ix));
         if (p0 != null) {
            if (p0.conn != null) {
               p0.conn.disconnect();
            }

            if (p0.map != null) {
               p0.map.leave_map(p0, 0);
            }
         }
      }

      Service.send_msg_data(this, 72, "data/msg/login/x2msg_72_638026480839986666", false);
      Service.send_msg_data(this, 72, "data/msg/login/x2msg_72_638026480840482549", false);
      Service.send_msg_data(this, 72, "data/msg/login/x2msg_72_638026480840808702", false);
      if (this.zoomlv < 2) {
         Message m22 = new Message(-7);
         m22.writer().writeByte(15);
         m22.writer().writeShort(MobTemplate.ENTRYS.size());

         for (int ixx = 0; ixx < MobTemplate.ENTRYS.size(); ixx++) {
            MobTemplate temp = MobTemplate.ENTRYS.get(ixx);
            m22.writer().writeShort(temp.mob_id);
            m22.writer().writeUTF(temp.name);
            m22.writer().writeShort(temp.level);
            m22.writer().writeShort(temp.hOne);
            m22.writer().writeInt(temp.hp_max);
            m22.writer().writeByte(temp.typemove);
            m22.writer().writeByte(temp.ishuman);
            m22.writer().writeByte(temp.typemonster);
            if (temp.ishuman == 1) {
               m22.writer().writeShort(temp.head);
               m22.writer().writeShort(temp.hair);
               m22.writer().writeByte(temp.wearing.length);

               for (int j = 0; j < temp.wearing.length; j++) {
                  if (temp.wearing[j] != -1) {
                     m22.writer().writeByte(1);
                     m22.writer().writeShort(temp.wearing[j]);
                  } else {
                     m22.writer().writeByte(-1);
                  }
               }
            } else {
               m22.writer().writeShort(temp.icon);
            }
         }

         m22.writer().writeShort(125);
         this.addmsg(m22);
         m22.cleanup();
      }

      if (this.user.startsWith("htth_truongbk_")) {
         Message m2 = new Message(-57);
         m2.writer().writeUTF(user_);
         this.addmsg(m2);
         m2.cleanup();
      }

      this.send_list_char();
      Message m2 = new Message(-2);
      this.addmsg(m2);
      m2.cleanup();
      if (IndexCharSelected != -1) {
         this.controller.login_into_char_select(IndexCharSelected);
      }
   }

   private void login_after_time(long l) throws IOException {
      Message m = new Message(-69);
      m.writer().writeUTF("Mời bạn đăng nhập lại sau thời gian");
      m.writer().writeShort((int)l);
      this.addmsg(m);
      m.cleanup();
   }

   private void send_list_char() throws IOException {
      Message m2 = new Message(-4);
      m2.writer().writeByte(this.list_char.size());

      for (int i = 0; i < this.list_char.size(); i++) {
         String name = this.list_char.get(i);
         Connection connection = null;
         PreparedStatement ps = null;
         ResultSet rs = null;

         try {
            connection = SQL.gI().getCon();
            ps = connection.prepareStatement(
               "SELECT `clazz`, `level`, `body`, `it_body`, `fashion`, `site` FROM `players` WHERE `name` = '" + name + "' LIMIT 1;"
            );
            rs = ps.executeQuery();

            while (rs.next()) {
               List<ItemFashionP2> fashion = new ArrayList<>();
               List<ItemFashionP> itfashionP = new ArrayList<>();
               JSONArray js0 = (JSONArray)JSONValue.parse(rs.getString("fashion"));
               JSONArray js_temp_2 = (JSONArray)JSONValue.parse(js0.get(0).toString());

               for (int i0 = 0; i0 < js_temp_2.size(); i0++) {
                  JSONArray js_temp = (JSONArray)JSONValue.parse(js_temp_2.get(i0).toString());
                  ItemFashionP tempf = new ItemFashionP();
                  tempf.category = Byte.parseByte(js_temp.get(0).toString());
                  tempf.id = Short.parseShort(js_temp.get(1).toString());
                  tempf.icon = Short.parseShort(js_temp.get(2).toString());
                  tempf.is_use = Byte.parseByte(js_temp.get(3).toString()) == 1;
                  itfashionP.add(tempf);
               }

               js_temp_2.clear();
               js_temp_2 = (JSONArray)JSONValue.parse(js0.get(1).toString());

               for (int i0 = 0; i0 < js_temp_2.size(); i0++) {
                  JSONArray js_temp = (JSONArray)JSONValue.parse(js_temp_2.get(i0).toString());
                  ItemFashionP2 tempf = new ItemFashionP2();
                  tempf.id = Short.parseShort(js_temp.get(0).toString());
                  tempf.is_use = Byte.parseByte(js_temp.get(1).toString()) == 1;
                  fashion.add(tempf);
               }

               js0.clear();
               short hair_ = -1;
               short head_ = -1;
               short[] fashion_ = null;

               for (int i0 = 0; i0 < fashion.size(); i0++) {
                  if (fashion.get(i0).is_use) {
                     ItemFashion temp = ItemFashion.get_item(fashion.get(i0).id);
                     if (temp != null) {
                        fashion_ = temp.mWearing;
                        break;
                     }
                  }
               }

               if (fashion_ != null && fashion_[6] != -1) {
                  hair_ = fashion_[7];
                  head_ = fashion_[6];
               } else {
                  for (int i0x = 0; i0x < itfashionP.size(); i0x++) {
                     if (itfashionP.get(i0x).category == 103 && itfashionP.get(i0x).is_use) {
                        hair_ = itfashionP.get(i0x).icon;
                     }
                  }

                  for (int i0xx = 0; i0xx < itfashionP.size(); i0xx++) {
                     if (itfashionP.get(i0xx).category == 108 && itfashionP.get(i0xx).is_use) {
                        head_ = itfashionP.get(i0xx).icon;
                     }
                  }
               }

               m2.writer().writeShort(i);
               m2.writer().writeUTF(name);
               m2.writer().writeByte(rs.getByte("clazz"));
               JSONArray js_level = (JSONArray)JSONValue.parse(rs.getString("level"));
               m2.writer().writeShort(Short.parseShort(js_level.get(0).toString()));
               JSONArray js = (JSONArray)JSONValue.parse(rs.getString("body"));
               m2.writer().writeShort(head_ != -1 ? head_ : Short.parseShort(js.get(0).toString()));
               m2.writer().writeShort(hair_ != -1 ? hair_ : Short.parseShort(js.get(1).toString()));
               js.clear();
               m2.writer().writeShort(Clan.get_icon_clan(name));
               m2.writer().writeByte(6);
               Item_wear[] it = new Item_wear[8];
               js = (JSONArray)JSONValue.parse(rs.getString("it_body"));

               for (int i1 = 0; i1 < js.size(); i1++) {
                  JSONArray js2 = (JSONArray)JSONValue.parse(js.get(i1).toString());
                  Item_wear temp = new Item_wear();
                  Item.readUpdateItem(js2.toString(), temp);
                  it[temp.index] = temp;
               }

               js.clear();
               js = (JSONArray)JSONValue.parse(rs.getString("site"));
               boolean is_show_hat = Byte.parseByte(js.get(6).toString()) == 1;
               js.clear();

               for (int j = 0; j < 6; j++) {
                  if (it[j] == null) {
                     m2.writer().writeByte(0);
                  } else {
                     m2.writer().writeByte(1);
                     if (j == 1 && !is_show_hat) {
                        m2.writer().writeShort(-1);
                     } else if (fashion_ != null && fashion_[j] != -1) {
                        m2.writer().writeShort(fashion_[j]);
                     } else {
                        m2.writer().writeShort(ItemTemplate3.get_it_by_id(it[j].template.id).part);
                     }
                  }
               }

               m2.writer().writeByte(0);
            }
         } catch (SQLException var28) {
            var28.printStackTrace();
         } finally {
            try {
               if (rs != null) {
                  rs.close();
               }

               if (ps != null) {
                  ps.close();
               }

               if (connection != null) {
                  connection.close();
               }
            } catch (SQLException var27) {
               var27.printStackTrace();
            }
         }
      }

      this.addmsg(m2);
      m2.cleanup();
   }

   private void login_notice(String s) throws IOException {
      Message m = new Message(-11);
      m.writer().writeShort(0);
      m.writer().writeByte(0);
      m.writer().writeUTF("Thông báo");
      m.writer().writeUTF(s);
      m.writer().writeByte(0);
      this.addmsg(m);
      m.cleanup();
   }

   public void ReadPartNew(Message m2) throws IOException {
      short index = m2.reader().readShort();
      Part part = Part.get_part(index);
      if (part != null) {
         Message m = new Message(-82);
         m.writer().writeShort(index);
         m.writer().writeByte(part.type);

         for (int i = 0; i < part.pi.length; i++) {
            m.writer().writeShort(part.pi[i].id);
            m.writer().writeByte(part.pi[i].dx);
            m.writer().writeByte(part.pi[i].dy);
         }

         this.addmsg(m);
         m.cleanup();
      }
   }

   public void create_char(Message m2) throws IOException {
      if (this.list_char.size() >= 1) {
         this.login_notice("Chỉ có thể tạo tối đa 1 nhân vật!");
      } else {
         String name = m2.reader().readUTF().replace(" ", "");
         name = name.toLowerCase();
         Pattern p = Pattern.compile("^[a-zA-Z0-9]{6,10}$");
         if (!p.matcher(name).matches()) {
            this.login_notice("Tên không hợp lệ, nhập lại đi!!");
         } else {
            byte clazz = m2.reader().readByte();
            int head = m2.reader().readShort();
            int hair = m2.reader().readShort();
            Connection connection = null;
            Statement st = null;

            label96: {
               try {
                  connection = SQL.gI().getCon();
                  st = connection.createStatement();
                  String query = "INSERT INTO `players` (`name`, `body`, `level`, `clazz`, `point_inven`, `site`, `bag3`, `it_body`, `potential`, `bag47`, `rms`, `skill`, `friend`, `enemy`, `fashion`, `eff`, `box3`, `box47`, `quest`, `date`, `pvppoint`, `save_it3`, `save_it47`, `hanhtrinh`, `wanted_point`, `wanted_chest`, `mypet`, `lucthuc`) VALUES ('%s', '%s', '%s', %s, '%s', '%s', '%s','%s','%s','%s','%s','%s','%s','%s','%s','%s','%s','%s','%s','%s', %s, '%s', '%s', '%s', %s, '%s', '%s','%s')";
                  String body_wear = "";
                  String skill_by_clazz = "";
                  String fashion_ = "";
                  switch (clazz) {
                     case 1:
                        body_wear = "[[0,0,1,-1,0,0,0,-1,[[1,61],[4,7]],[],0,[],0],[40,0,1,-1,0,0,0,-1,[[3,4],[15,1]],[],0,[],3],[80,0,1,-1,0,0,0,-1,[[3,3],[15,3]],[],0,[],5]]";
                        skill_by_clazz = "[[0,0,0,0],[20,-1,0,0],[40,-1,0,0],[375,-1,0,0],[487,-1,0,0],[300,-1,0,0],[305,-1,0,0],[310,-1,0,0],[315,-1,0,0],[320,-1,0,0],[325,-1,0,0],[552,-1,0,0],[557,-1,0,0]]";
                        fashion_ = "[[[103,5,1,1],[108,0,0,1]],[],[[1,1],[5,1],[3,1],[7,1]]]";
                        break;
                     case 2:
                        body_wear = "[[8,0,1,-1,0,1,0,-1,[[1,72]],[],0,[],0],[48,0,1,-1,0,1,0,-1,[[3,2],[15,3]],[],0,[],3],[88,0,1,-1,0,1,0,-1,[[3,1],[15,5]],[],0,[],5]]";
                        skill_by_clazz = "[[60,0,0,0],[80,-1,0,0],[100,-1,0,0],[395,-1,0,0],[492,-1,0,0],[300,-1,0,0],[305,-1,0,0],[310,-1,0,0],[315,-1,0,0],[320,-1,0,0],[325,-1,0,0],[552,-1,0,0],[557,-1,0,0]]";
                        fashion_ = "[[[103,1,24,1],[108,0,0,1]],[],[[1,1],[5,1],[3,1],[7,1]]]";
                        break;
                     case 3:
                        body_wear = "[[16,0,1,-1,0,1,0,-1,[[1,73]],[],0,[],0],[56,0,1,-1,0,0,0,-1,[[3,3],[15,2]],[],0,[],3],[96,0,1,-1,0,0,0,-1,[[3,3],[15,4]],[],0,[],5]]";
                        skill_by_clazz = "[[120,0,0,0],[140,-1,0,0],[160,-1,0,0],[415,-1,0,0],[497,-1,0,0],[300,-1,0,0],[305,-1,0,0],[310,-1,0,0],[315,-1,0,0],[320,-1,0,0],[325,-1,0,0],[552,-1,0,0],[557,-1,0,0]]";
                        fashion_ = "[[[103,2,28,1],[108,0,0,1]],[],[[1,1],[5,1],[3,1],[7,1]]]";
                        break;
                     case 4:
                        body_wear = "[[24,0,1,-1,0,1,0,-1,[[1,55],[23,18]],[],0,[],0],[64,0,1,-1,0,0,0,-1,[[3,2],[15,3]],[],0,[],3],[104,0,1,-1,0,1,0,-1,[[3,1],[15,5]],[],0,[],5]]";
                        skill_by_clazz = "[[180,0,0,0],[200,-1,0,0],[220,-1,0,0],[435,-1,0,0],[502,-1,0,0],[300,-1,0,0],[305,-1,0,0],[310,-1,0,0],[315,-1,0,0],[320,-1,0,0],[325,-1,0,0],[552,-1,0,0],[557,-1,0,0]]";
                        fashion_ = "[[[103,3,32,1],[108,0,0,1]],[],[[1,1],[5,1],[3,1],[7,1]]]";
                        break;
                     case 5:
                        body_wear = "[[32,0,1,-1,0,1,0,-1,[[1,66],[16,1]],[],0,[],0],[72,0,1,-1,0,0,0,-1,[[3,3],[15,2]],[],0,[],3],[112,0,1,-1,0,0,0,-1,[[3,2],[15,4]],[],0,[],5]]";
                        skill_by_clazz = "[[240,0,0,0],[260,-1,0,0],[280,-1,0,0],[455,-1,0,0],[507,-1,0,0],[300,-1,0,0],[305,-1,0,0],[310,-1,0,0],[315,-1,0,0],[320,-1,0,0],[325,-1,0,0],[552,-1,0,0],[557,-1,0,0]]";
                        fashion_ = "[[[103,4,36,1],[108,0,0,1]],[],[[1,1],[5,1],[3,1],[7,1]]]";
                  }

                  query = String.format(
                     query,
                     name,
                     "[" + head + "," + hair + "]",
                     "[1,0,0]",
                     clazz,
                     "[1000000,500,0,0,0,0,0,0,7,0,0,0]",
                     "[0,0,-1,-1,300,300,1,0,20,0,3,0,3,0]",
                     "[]",
                     body_wear,
                     "[5,1,1,1,1,1,0,[]]",
                     "[]",
                     "[[],[],[],[],[0,18],[],[],[],[],[],[]]",
                     skill_by_clazz,
                     "[]",
                     "[]",
                     fashion_,
                     "[]",
                     "[]",
                     "[]",
                     "[[0,[]]]",
                     DateTime.now(),
                     0,
                     "[]",
                     "[]",
                     "[]",
                     0,
                     "[]",
                     "[[0,1,1]]",
                     "[0,1,1,1,1,0]"
                  );
                  st.execute(query);
                  break label96;
               } catch (SQLException var21) {
                  var21.printStackTrace();
                  this.login_notice("tên đã được sử dụng!");
               } finally {
                  try {
                     if (st != null) {
                        st.close();
                     }

                     if (connection != null) {
                        connection.close();
                     }
                  } catch (SQLException var20) {
                     var20.printStackTrace();
                  }
               }

               return;
            }

            this.list_char.add(name);
            this.flush();
            this.send_list_char();
         }
      }
   }

   public void flush() {
      JSONArray js = new JSONArray();

      for (int i = 0; i < this.list_char.size(); i++) {
         js.add(this.list_char.get(i));
      }

      Connection conn = null;
      Statement st = null;

      try {
         conn = SQL.gI().getCon();
         st = conn.createStatement();
         st.executeUpdate(
            "UPDATE `accounts` SET `char` = '" + js.toJSONString() + "' WHERE BINARY `user` = '" + this.user + "' AND BINARY `pass` = '" + this.pass + "';"
         );
      } catch (SQLException var13) {
         var13.printStackTrace();
      } finally {
         try {
            if (st != null) {
               st.close();
            }

            if (conn != null) {
               conn.close();
            }
         } catch (SQLException var12) {
            var12.printStackTrace();
         }
      }
   }

   public void update_onl(int type) {
      if (Manager.gI().server_admin) {
         type = 0;
      }

      Connection connection = null;
      Statement st = null;

      try {
         connection = SQL.gI().getCon();
         st = connection.createStatement();
         if (type == 0 && this.p != null) {
            st.executeUpdate(
               "UPDATE `accounts` SET `onl` = " + type + " WHERE BINARY `user` = '" + this.user + "' AND BINARY `pass` = '" + this.pass + "' LIMIT 1;"
            );
         } else {
            st.executeUpdate(
               "UPDATE `accounts` SET `onl` = " + type + " WHERE BINARY `user` = '" + this.user + "' AND BINARY `pass` = '" + this.pass + "' LIMIT 1;"
            );
         }
      } catch (SQLException var13) {
         var13.printStackTrace();
      } finally {
         try {
            if (st != null) {
               st.close();
            }

            if (connection != null) {
               connection.close();
            }
         } catch (SQLException var12) {
            var12.printStackTrace();
         }
      }
   }

   public boolean check_onl() {
      Connection connection = null;
      PreparedStatement ps = null;
      ResultSet rs = null;

      try {
         connection = SQL.gI().getCon();
         ps = connection.prepareStatement("SELECT `onl` FROM `accounts` WHERE BINARY `user` = ? AND BINARY `pass` = ? LIMIT 1;");
         ps.setString(1, this.user);
         ps.setString(2, this.pass);
         rs = ps.executeQuery();
         if (!rs.next()) {
            return false;
         }

         if (rs.getBoolean("onl")) {
            return true;
         }
      } catch (SQLException var17) {
         var17.printStackTrace();
         return false;
      } finally {
         try {
            if (rs != null) {
               rs.close();
            }

            if (ps != null) {
               ps.close();
            }

            if (connection != null) {
               connection.close();
            }
         } catch (SQLException var16) {
            var16.printStackTrace();
         }
      }

      return false;
   }

   public void clear_network(Session ss) {
      if (ss.sendd != null) {
         ss.sendd.interrupt();
         ss.sendd = null;
      }

      if (ss.receiv != null) {
         ss.receiv.interrupt();
         ss.receiv = null;
      }

      try {
         if (!ss.socket.isClosed()) {
            ss.socket.close();
         }
      } catch (IOException var3) {
         var3.printStackTrace();
      }
   }

   public void Check_Data_Ver() throws IOException {
      Message m = new Message(-6);
      m.writer().writeShort(125);
      m.writer().writeShort(314);
      m.writer().writeShort(791);
      m.writer().writeShort(-1);
      m.writer().writeShort(369);
      m.writer().writeShort(258);
      m.writer().writeShort(-1);
      m.writer().writeShort(148);
      m.writer().writeShort(753);
      m.writer().writeShort(160);
      m.writer().writeShort(-1);
      this.addmsg(m);
      m.cleanup();
      m = new Message(-7);
      m.writer().writeByte(11);
      m.writer().writeByte(ItemTemplate7.ENTRYS.size());

      for (int i = 0; i < ItemTemplate7.ENTRYS.size(); i++) {
         ItemTemplate7 temp = ItemTemplate7.ENTRYS.get(i);
         m.writer().writeByte(temp.id);
         m.writer().writeUTF(temp.name);
         m.writer().writeByte(temp.type);
         m.writer().writeByte(temp.icon);
         m.writer().writeInt(temp.price);
         m.writer().writeShort(temp.priceruby);
         m.writer().writeByte(temp.istrade);
      }

      this.addmsg(m);
      m.cleanup();
   }
}
