package core;

import activities.Friend;
import activities.Market;
import activities.Trade;
import client.Body;
import client.Item;
import client.MyPet;
import client.Party;
import client.Pet;
import client.Player;
import database.SQL;
import io.Message;
import io.Session;
import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import map.Map;
import map.Mob;
import org.json.simple.JSONArray;
import org.json.simple.JSONValue;
import template.FriendTemp;
import template.ItemMarket;
import template.ItemTemplate3;
import template.Item_wear;
import template.Part;
import template.Ship_pet;
import template.Skill_Template;
import template.Skill_info;

public class Bot extends Player {
   private static final int MAX_FALLBACK_WARNINGS = 3;
   private static final int MIN_X = 35;
   private static final int MAX_X = 1050;
   private static final int DEFAULT_Y = 200;
   private static final int ATTACK_PADDING = 35;
   private static final int AVOID_PLAYER_MOB_RADIUS = 350;
   private static final int AVOID_PLAYER_TARGET_RADIUS = 250;
   private static int fallbackWarnings;
   private static short nextShipCargoIndex = -3000;
   private int targetMobIndex = -1;
   private int displayGearLevel = 1;
   private Bot.AiState aiState = Bot.AiState.ROAM;
   private long nextChatTime;
   private long nextSaveTime;
   private long nextRetargetTime;
   private long nextPointTime;
   private long nextMoveTime;
   private long nextAttackTime;
   private long nextInfoTime;
   private long nextSocialTime;
   private long nextMarketTime;
   private long nextTradeCheckTime;
   private long nextShipTime;
   private long nextPartyInviteTime;
   private int aiErrorCount;
   private String lastChatLine = "";
   private static final String[] FAKE_NAMES = new String[]{
      "LuffyKing",
      "ZoroSword",
      "NamiThief",
      "UsoppGod",
      "SanjiCook",
      "ChopperDr",
      "RobinArc",
      "FrankyShip",
      "BrookSoul",
      "JinbeSea",
      "AceFire",
      "SaboRev",
      "KoalaKid",
      "HancockBoa",
      "ShankRed",
      "HaiTacVN",
      "VuaHaiTac",
      "DaoDangCap",
      "TuanBienCa",
      "ChienSi01",
      "TanThu001",
      "QuaiVatSan",
      "MayMuon99",
      "XuHuong01",
      "AnhHung88"
   };
   private static final String[] CHAT_ROAM = new String[]{
      "Ai train chung khong?",
      "Map nay kha on do",
      "Co ai lam nhiem vu map nay khong?",
      "Di quanh kiem bai train ngon",
      "Khu nay dong vui ghe",
      "Len bai nao ae?",
      "Minh moi qua map nay",
      "Can nguoi di chung cho vui",
      "Khu nao con trong khong ae?",
      "Quai hoi thua, doi bai khong?",
      "Ai biet bai exp ngon chi minh voi",
      "Di xa qua lai quay ve lang mat",
      "Map nay de train ky nang ne",
      "Co ai thay boss mini khong?",
      "Dang tim bai hop level",
      "Qua khu khac thu xem sao",
      "Ai vua qua day vay?",
      "Khu 1 dong qua nhi",
      "Minh dung day doi ban chut",
      "Map nay nhin quen quen",
      "Di mot minh hoi buon",
      "Ai can keo nhiem vu thi bao",
      "Dang test do moi mac",
      "Can mua it binh mp nua"
   };
   private static final String[] CHAT_HUNT = new String[]{
      "Quai gan day hoi trau",
      "Tap trung danh con gan truoc",
      "Dame minh tam on roi",
      "Can pt de clear quai nhanh hon",
      "Dang can them exp ky nang",
      "Quai nay drop gi vay ae?",
      "Danh bai nay exp kha on",
      "De minh keo quai lai gan",
      "Quai sap chet roi",
      "Con nay ne ae",
      "Dung gan qua coi chung mat mau",
      "Ai buff giup minh voi",
      "Skill vua len cap ngon hon han",
      "Quai hoi dong, di cham thoi",
      "Can them dame de clear nhanh",
      "Danh con gan nguoi truoc nha",
      "Bai nay farm beri cung tam",
      "Exp ky nang len cham qua",
      "Quai hoi lech level nhung van danh duoc",
      "Ai tank duoc khong?",
      "Minh danh ben trai nha",
      "De minh lo con nay",
      "Combo dep ghe",
      "Het cooldown roi danh tiep",
      "Can them nguoi gom quai",
      "Quai nay ne, dung bo qua"
   };
   private static final String[] CHAT_REST = new String[]{
      "Doi chut hoi mp",
      "Het mp roi nghi ti",
      "Hp hoi thap, dung lai xi",
      "Can an them binh mau",
      "Nghi 1 chut roi danh tiep",
      "Quai danh dau qua",
      "Cho minh hoi skill xong da",
      "Dang sap het mp",
      "Doi cooldown chut nha",
      "Can mua them thuoc roi",
      "Hp len lai roi danh tiep",
      "Dung xa quai chut",
      "May con kia danh rat dau",
      "Nghi mot nhip thoi",
      "Ai con binh mp khong?",
      "Mp hoi it nen danh cham lai",
      "Mau vua tut nhanh qua",
      "Dung lai tranh chet oan",
      "Ti nua minh vao danh tiep",
      "Khoan keo them quai nha"
   };
   private static final String[] CHAT_SOCIAL = new String[]{
      "Ai lap team train khong?",
      "Cho minh vao nhom voi",
      "Ket ban de lan sau train tiep nha",
      "Party cho co buff nao",
      "Di chung cho nhanh len cap",
      "Ai cung cap thi pt nhe",
      "Team nao thieu nguoi khong?",
      "Them ban train lau dai nao",
      "Pt 2 nguoi clear nhanh hon do",
      "Ai dang lam nhiem vu thi minh theo",
      "Ket ban nhe, lan sau goi nhau train",
      "Can team di map cao hon",
      "Ai cung phai thi party cho du buff",
      "Minh co the keo quai phu",
      "Team nao farm beri khong?",
      "Lap nhom roi chia bai danh nha",
      "Ai moi cho minh vao pt voi",
      "Train lau thi ket ban cho de tim",
      "Co ai online lau khong?",
      "Minh theo team nao cung duoc",
      "Party xong dung tach xa qua nha",
      "Ai can ban train cung khong?",
      "Dung chung bai cho vui",
      "Co buff party danh nhanh hon"
   };
   private static final String[] CHAT_PROGRESS = new String[]{
      "Len cap roi ae",
      "Skill vua len them chut",
      "Sap len level nua roi",
      "Exp hom nay on qua",
      "Do moi mac nhin cung duoc",
      "Dame tang len thay ro",
      "Can nang cap do them",
      "Tiem nang con du de cong diem",
      "Ky nang nay danh da tay",
      "Len cap xong qua map cao hon",
      "Farm them chut nua roi nghi",
      "Hom nay train kha nang suat",
      "Sap du diem nang skill",
      "Can them it exp nua thoi"
   };
   private static final String[] CHAT_LOOT = new String[]{
      "Co ai nhat duoc do ngon chua?",
      "Map nay drop hoi it",
      "Vua roi roi do gi do",
      "Farm beri cung tam on",
      "Can it nguyen lieu nang do",
      "Ai ban do cung he khong?",
      "Do xanh cung tam dung",
      "Tim mai chua ra mon ngon",
      "Drop ra thuoc cung duoc",
      "Ai co vu khi du thi de minh mua",
      "Roi do thi chia nhau nha",
      "Can item nang cap qua"
   };

   private void ensureBotSession() {
      if (this.conn == null) {
         this.conn = new Bot.DummySession();
      }

      this.conn.status = 1;
      this.conn.user = "bot_" + this.name;
   }

   public static String generateBotName() {
      return FAKE_NAMES[Util.random(0, FAKE_NAMES.length)] + "_" + Util.random(10, 99);
   }

   private void initFallback() {
      this.initAllLists();
      this.item = new Item(this);
      this.item.it_body = new Item_wear[8];
      this.body = new Body(this);
      this.clazz = (byte)(1 + Util.random(0, 5));
      this.head = 0;
      this.hair = 36;
      this.level = (short)(5 + Util.random(0, 40));
      this.point1 = 1;
      this.point2 = 1;
      this.point3 = 1;
      this.point4 = 1;
      this.point5 = 1;
      this.doriki = new int[]{1, 0};
      this.lucthuc = new int[]{0, 0, 0};
      this.sucmanhvatly = 0;
      this.typePirate = 0;
      this.id_ship_packet = -1;
      this.update_vang(2000000L);
      this.update_vnd(100000L);
      this.update_key_boss(20);
      this.hp = 50000;
      this.mp = 50000;
      Skill_info sk = new Skill_info();
      sk.temp = Skill_Template.get_temp(0, this.clazz);
      if (sk.temp == null) {
         sk.temp = Skill_Template.get_temp(0, 1L);
      }

      if (sk.temp != null) {
         sk.exp = 0L;
         this.skill_point.add(sk);
      }
   }

   private void initBot() {
      this.index_map = (short)Util.random(20000, 30000);
      boolean loaded = false;

      try {
         loaded = this.setup();
      } catch (Exception var3) {
         logFallbackWarning(var3);
      }

      if (!loaded) {
         this.index_map = (short)Util.random(20000, 30000);
         this.initFallback();
      } else {
         this.ensureBodyParts();
      }

      this.is_show_hat = true;
      this.ensureRms();
      this.ensurePet();
      this.ensureVisibleBody();
      this.ensureSafeStats();
      this.ensureRuntimeState();
      this.ensureBotSession();
      this.typePirate = 0;
      if (this.get_vang() < 1000000L) {
         this.update_vang(2000000L);
      }

      if (this.get_vnd() < 50000) {
         this.update_vnd(100000L);
      }

      if (this.get_key_boss() < 10) {
         this.update_key_boss(20);
      }
   }

   private void adaptAppearanceToMap() {
      this.displayGearLevel = Math.max(1, this.getMapGearLevel());
      if (this.level < this.displayGearLevel) {
         this.level = (short)Math.min(120, this.displayGearLevel);
      }

      this.ensureVisibleBody();
      this.ensureSafeStats();
   }

   private void ensureBodyParts() {
      if (this.head == 0 && this.hair == 0) {
         Connection c = null;
         PreparedStatement ps = null;
         ResultSet rs = null;

         try {
            c = SQL.gI().getCon();
            ps = c.prepareStatement("SELECT body FROM players WHERE name = ? LIMIT 1");
            ps.setString(1, this.name);
            rs = ps.executeQuery();
            if (rs.next()) {
               JSONArray bodyJson = (JSONArray)JSONValue.parse(rs.getString("body"));
               if (bodyJson != null && bodyJson.size() >= 2) {
                  this.head = Short.parseShort(bodyJson.get(0).toString());
                  this.hair = Short.parseShort(bodyJson.get(1).toString());
               }
            }
         } catch (Exception var21) {
         } finally {
            try {
               if (rs != null) {
                  rs.close();
               }
            } catch (Exception var20) {
            }

            try {
               if (ps != null) {
                  ps.close();
               }
            } catch (Exception var19) {
            }

            try {
               if (c != null) {
                  c.close();
               }
            } catch (Exception var18) {
            }
         }

         if (this.hair == 0) {
            this.hair = 36;
         }
      }
   }

   private int getMapGearLevel() {
      if (this.map != null && this.map.list_mob != null && this.map.list_mob.length != 0) {
         int maxLevel = 1;
         int total = 0;
         int count = 0;

         for (int i = 0; i < this.map.list_mob.length; i++) {
            Mob mob = Mob.ENTRYS.get(this.map.list_mob[i]);
            if (mob != null && mob.level > 0) {
               maxLevel = Math.max(maxLevel, mob.level);
               total += mob.level;
               count++;
            }
         }

         if (count == 0) {
            return Math.max(1, this.level);
         } else {
            int avg = total / count;
            return Math.max(avg, maxLevel - 5);
         }
      } else {
         return Math.max(1, this.level);
      }
   }

   private void ensureVisibleBody() {
      try {
         if (this.item == null) {
            this.item = new Item(this);
         }

         if (this.item.it_body == null || this.item.it_body.length < 8) {
            this.item.it_body = new Item_wear[8];
         }

         this.item.it_body[1] = null;
         this.item.it_body[0] = null;
         this.item.it_body[3] = null;
         this.item.it_body[5] = null;
         this.setDefaultWearSlot(0);
         this.setDefaultWearSlot(3);
         this.setDefaultWearSlot(5);
      } catch (Exception var2) {
         System.err.println("[BotAI] Update error for " + this.name + ": " + var2.getMessage());
      }
   }

   private void setDefaultWearSlot(int slot) {
      ItemTemplate3 template = this.findWearTemplate((byte)slot);
      if (template != null) {
         Item_wear wear = new Item_wear();
         wear.setup_template_by_id(template);
         wear.index = (byte)slot;
         this.tuneRareWear(wear, false);
         this.item.it_body[slot] = wear;
      }
   }

   private void tuneRareWear(Item_wear wear, boolean tradeable) {
      if (wear != null && wear.template != null) {
         int gearLevel = Math.max(this.displayGearLevel, this.level);
         int minUp = gearLevel >= 70 ? 7 : (gearLevel >= 45 ? 5 : (gearLevel >= 25 ? 3 : 0));
         int maxUp = gearLevel >= 70 ? 12 : (gearLevel >= 45 ? 9 : (gearLevel >= 25 ? 6 : 3));
         wear.levelup = (byte)Util.random(minUp, maxUp + 1);
         wear.typelock = tradeable ? 0 : wear.typelock;
         wear.timeUse = 0;
         wear.mdakham = new short[0];
         wear.numHoleDaDuc = 0;
         if (tradeable) {
            wear.isHoanMy = gearLevel >= 45 && Util.random(0, 100) < 35 ? 1 : wear.isHoanMy;
         }
      }
   }

   private ItemTemplate3 findWearTemplate(byte typeEquip) {
      List<ItemTemplate3> candidates = new ArrayList<>();
      int targetLevel = Math.max(1, this.displayGearLevel);

      for (int i = 0; i < ItemTemplate3.ENTRYS.size(); i++) {
         ItemTemplate3 it = ItemTemplate3.ENTRYS.get(i);
         if (it != null
            && it.typeEquip == typeEquip
            && it.part >= 0
            && (typeEquip != 1 || this.isSafeHatPart(it))
            && this.matchesBotClass(it)
            && it.level <= targetLevel
            && it.level >= Math.max(1, targetLevel - 15)) {
            candidates.add(it);
         }
      }

      if (!candidates.isEmpty()) {
         return candidates.get(Util.random(0, candidates.size()));
      } else {
         ItemTemplate3 selected = null;
         int bestLevel = -1;

         for (int ix = 0; ix < ItemTemplate3.ENTRYS.size(); ix++) {
            ItemTemplate3 it = ItemTemplate3.ENTRYS.get(ix);
            if (it != null
               && it.typeEquip == typeEquip
               && it.part >= 0
               && (typeEquip != 1 || this.isSafeHatPart(it))
               && this.matchesBotClass(it)
               && it.level <= targetLevel
               && it.level > bestLevel) {
               selected = it;
               bestLevel = it.level;
            }
         }

         if (selected == null) {
            for (int ixx = 0; ixx < ItemTemplate3.ENTRYS.size(); ixx++) {
               ItemTemplate3 it = ItemTemplate3.ENTRYS.get(ixx);
               if (it != null && it.typeEquip == typeEquip && it.part >= 0 && (typeEquip != 1 || this.isSafeHatPart(it)) && this.matchesBotClass(it)) {
                  return it;
               }
            }
         }

         return selected;
      }
   }

   private boolean matchesBotClass(ItemTemplate3 it) {
      return it.clazz == 0 || it.clazz == this.clazz || it.clazz == this.clazz - 1;
   }

   private boolean isSafeHatPart(ItemTemplate3 it) {
      Part part = Part.get_part(it.part);
      return part != null && part.type == 5;
   }

   private void ensureSafeStats() {
      try {
         if (this.body == null) {
            this.body = new Body(this);
         }

         this.hp = Math.max(this.body.get_hp_max(true), 50000);
         this.mp = Math.max(this.body.get_mp_max(true), 50000);
      } catch (Exception var2) {
         this.hp = 50000;
         this.mp = 50000;
      }
   }

   private void ensureRms() {
      if (this.rms == null || this.rms.length < 11) {
         byte[][] fixed = new byte[11][];
         if (this.rms != null) {
            for (int i = 0; i < this.rms.length && i < fixed.length; i++) {
               fixed[i] = this.rms[i];
            }
         }

         this.rms = fixed;
      }

      for (int i = 0; i < this.rms.length; i++) {
         if (this.rms[i] == null) {
            this.rms[i] = new byte[0];
         }
      }
   }

   private void ensurePet() {
      try {
         if (this.my_pet == null) {
            this.my_pet = new ArrayList<>();
         }

         for (int i = 0; i < this.my_pet.size(); i++) {
            MyPet pet = this.my_pet.get(i);
            if (pet != null && pet.template != null) {
               pet.isUse = i == 0 || pet.isUse;
               return;
            }
         }

         if (Pet.ENTRY == null || Pet.ENTRY.isEmpty()) {
            return;
         }

         MyPet pet = new MyPet();
         pet.id = 0;
         pet.template = Pet.ENTRY.get(Util.random(0, Pet.ENTRY.size()));
         pet.isUse = true;
         this.my_pet.add(pet);
      } catch (Exception var3) {
      }
   }

   private static synchronized void logFallbackWarning(Exception e) {
      fallbackWarnings++;
      if (fallbackWarnings <= 3) {
         System.err.println("[Bot] Some DB bot data is invalid, using fallback bot data: " + e.getMessage());
      } else if (fallbackWarnings == 4) {
         System.err.println("[Bot] Further invalid DB bot data warnings are hidden.");
      }
   }

   public Bot(String name, short mapId) {
      super(new Bot.DummySession(), name);
      this.name = name;
      this.initBot();
      Map[] maps = Map.get_map_by_id(mapId);
      if (maps != null && maps.length > 0) {
         this.map = maps[0];
         this.x = (short)Util.random(100, 500);
         this.y = 200;
         this.adaptAppearanceToMap();
      }
   }

   public Bot(String name, Map m) {
      super(new Bot.DummySession(), name);
      this.name = name;
      this.initBot();
      this.map = m;
      this.x = (short)Util.random(100, 500);
      this.y = 200;
      this.adaptAppearanceToMap();
   }

   @Override
   public short get_hat() {
      return -1;
   }

   @Override
   public int get_head() {
      return super.get_head();
   }

   @Override
   public int get_hair() {
      return super.get_hair();
   }

   public void update() {
      if (this.map != null) {
         try {
            if (!this.hasRealPlayerInMap()) {
               return;
            }

            this.ensureBotSession();
            this.ensureRuntimeState();
            this.ensureRms();
            this.ensureSafeStats();
            if (this.isdie) {
               this.reviveHere();
               return;
            }

            long now = System.currentTimeMillis();
            this.autoSpendPoints(now);
            this.autoLearnAvailableSkills();
            this.autoPotion();
            this.maybeHandleTradeRequest(now);
            this.maybePostRareMarketItem(now);
            Player anchor = this.findAnchorPlayer();
            if (anchor == null) {
               this.setState(Bot.AiState.ROAM);
               this.roam(null, now);
               return;
            }

            this.maybeSocialActions(anchor, now);
            if (this.shouldRest()) {
               this.setState(Bot.AiState.REST);
               this.autoPotion();
               this.roam(anchor, now);
               this.maybeChat(now);
               this.maybeSave(now);
               return;
            }

            Mob target = this.getCurrentTarget();
            if (target != null && this.shouldYieldMob(target)) {
               this.targetMobIndex = -1;
               target = null;
               this.nextRetargetTime = 0L;
            }

            if (target == null || now >= this.nextRetargetTime) {
               target = this.findBestMob(anchor);
               this.targetMobIndex = target != null ? target.index : -1;
               this.nextRetargetTime = now + Util.random(1200, 2600);
            }

            if (target == null) {
               this.setState(Bot.AiState.ROAM);
               this.roam(anchor, now);
               this.maybeChat(now);
               this.maybeSave(now);
               return;
            }

            Skill_info skill = this.ensureAttackSkill();
            if (skill == null || skill.temp == null) {
               this.setState(Bot.AiState.ROAM);
               this.roam(anchor, now);
               this.maybeChat(now);
               this.maybeSave(now);
               return;
            }

            int range = Math.max(70, skill.temp.range + 35);
            if (this.distance(this.x, this.y, target.x, target.y) > range) {
               this.setState(Bot.AiState.HUNT);
               this.moveToward(target.x, target.y, Math.min(170, Math.max(90, range - 20)));
            } else if (now >= this.nextAttackTime) {
               this.setState(Bot.AiState.ATTACK);
               this.faceAndAttack(target, skill);
               long delay = Math.max(650L, (long)skill.temp.timeDelay);
               this.nextAttackTime = now + delay + Util.random(100, 450);
               this.maybeBroadcastInfo(now);
            }

            this.maybeChat(now);
            this.maybeSave(now);
         } catch (Exception var9) {
            if (this.aiErrorCount++ < 20) {
               System.err.println("[BotAI] " + this.name + " " + this.aiState + " error: " + var9.getMessage());
            }
         }
      }
   }

   private void setState(Bot.AiState state) {
      this.aiState = state;
   }

   private boolean shouldRest() {
      try {
         int hpMax = this.body != null ? this.body.get_hp_max(true) : 1;
         int mpMax = this.body != null ? this.body.get_mp_max(true) : 1;
         return this.hp < hpMax * 25 / 100 || this.mp < mpMax * 12 / 100;
      } catch (Exception var3) {
         return false;
      }
   }

   private boolean hasRealPlayerInMap() {
      synchronized (this.map.players) {
         for (int i = 0; i < this.map.players.size(); i++) {
            Player p = this.map.players.get(i);
            if (p != null && !(p instanceof Bot) && p.conn != null && !p.isdie) {
               return true;
            }
         }

         return false;
      }
   }

   private Player findAnchorPlayer() {
      if (this.party != null) {
         for (int i = 0; i < this.party.list.size(); i++) {
            Player mate = this.party.list.get(i);
            if (mate != null && mate != this && !(mate instanceof Bot) && mate.map == this.map && mate.conn != null && !mate.isdie) {
               return mate;
            }
         }
      }

      List<Player> realPlayers = new ArrayList<>();
      synchronized (this.map.players) {
         for (int ix = 0; ix < this.map.players.size(); ix++) {
            Player p = this.map.players.get(ix);
            if (p != null && !(p instanceof Bot) && p.conn != null && !p.isdie) {
               realPlayers.add(p);
            }
         }
      }

      if (realPlayers.isEmpty()) {
         return null;
      } else {
         Player nearest = realPlayers.get(0);
         int best = this.distance(this.x, this.y, nearest.x, nearest.y);

         for (int ixx = 1; ixx < realPlayers.size(); ixx++) {
            Player p = realPlayers.get(ixx);
            int d = this.distance(this.x, this.y, p.x, p.y);
            if (d < best) {
               best = d;
               nearest = p;
            }
         }

         return nearest;
      }
   }

   private Mob getCurrentTarget() {
      if (this.targetMobIndex < 0) {
         return null;
      } else {
         Mob mob = Mob.ENTRYS.get(this.targetMobIndex);
         if (mob != null && mob.map == this.map && !mob.isdie && mob.hp > 0 && !this.shouldYieldMob(mob)) {
            return mob;
         } else {
            this.targetMobIndex = -1;
            return null;
         }
      }
   }

   private Mob findBestMob(Player anchor) {
      if (this.map != null && this.map.list_mob != null) {
         Mob best = null;
         int bestScore = Integer.MAX_VALUE;

         for (int i = 0; i < this.map.list_mob.length; i++) {
            Mob mob = Mob.ENTRYS.get(this.map.list_mob[i]);
            if (mob != null && mob.map == this.map && !mob.isdie && mob.hp > 0 && !this.shouldYieldMob(mob)) {
               int anchorDistance = this.distance(anchor.x, anchor.y, mob.x, mob.y);
               int selfDistance = this.distance(this.x, this.y, mob.x, mob.y);
               int levelGap = Math.abs(this.level - mob.level);
               int score = anchorDistance + selfDistance / 2 + levelGap * 18;
               if (this.party != null) {
                  for (int j = 0; j < this.party.list.size(); j++) {
                     Player mate = this.party.list.get(j);
                     if (mate != null && mate != this && !(mate instanceof Bot) && mate.map == this.map) {
                        if (mate.index_map == mob.id_target) {
                           score -= 600;
                           break;
                        }

                        int mateToMob = this.distance(mate.x, mate.y, mob.x, mob.y);
                        if (mateToMob < 200) {
                           score -= 350;
                           break;
                        }
                     }
                  }
               }

               if (score < bestScore) {
                  bestScore = score;
                  best = mob;
               }
            }
         }

         return best;
      } else {
         return null;
      }
   }

   private boolean shouldYieldMob(Mob mob) {
      if (mob != null && this.map != null) {
         Player targetOwner = this.getRealPlayerByMapIndex(mob.id_target);
         if (targetOwner != null) {
            return this.party == null || this.party != targetOwner.party;
         } else {
            synchronized (this.map.players) {
               for (int i = 0; i < this.map.players.size(); i++) {
                  Player p = this.map.players.get(i);
                  if (p != null && !(p instanceof Bot) && p.conn != null && !p.isdie && (this.party == null || this.party != p.party)) {
                     int d = this.distance(p.x, p.y, mob.x, mob.y);
                     if (d <= 250) {
                        return true;
                     }

                     if (d <= 350 && mob.hp < mob.hp_max) {
                        return true;
                     }
                  }
               }

               return false;
            }
         }
      } else {
         return true;
      }
   }

   private Player getRealPlayerByMapIndex(int indexMap) {
      if (indexMap >= 0 && this.map != null) {
         synchronized (this.map.players) {
            for (int i = 0; i < this.map.players.size(); i++) {
               Player p = this.map.players.get(i);
               if (p != null && !(p instanceof Bot) && p.index_map == indexMap && p.conn != null && !p.isdie) {
                  return p;
               }
            }

            return null;
         }
      } else {
         return null;
      }
   }

   private Skill_info ensureAttackSkill() {
      Skill_info skill = this.getAttackSkill();
      if (skill != null) {
         return skill;
      } else {
         Skill_Template temp = Skill_Template.get_temp(0, this.clazz);
         if (temp == null) {
            temp = Skill_Template.get_temp(0, 1L);
         }

         if (temp == null) {
            return null;
         } else {
            Skill_info base = this.get_skill_temp(temp.ID);
            if (base == null) {
               base = new Skill_info();
               base.temp = temp;
               base.exp = 0L;
               this.skill_point.add(base);
            } else if (base.exp < 0L) {
               base.exp = 0L;
            }

            return base;
         }
      }
   }

   private Skill_info getAttackSkill() {
      Skill_info selected = null;

      for (int i = 0; i < this.skill_point.size(); i++) {
         Skill_info sk = this.skill_point.get(i);
         if (sk != null
            && sk.temp != null
            && sk.exp >= 0L
            && (sk.temp.typeSkill == 1 || sk.temp.typeSkill == 4)
            && this.mp >= sk.temp.manaLost
            && (this.time_sk == null || sk.temp.ID < 0 || sk.temp.ID >= this.time_sk.length || this.time_sk[sk.temp.ID] <= System.currentTimeMillis())
            && (selected == null || sk.get_dame(this) > selected.get_dame(this))) {
            selected = sk;
         }
      }

      return selected;
   }

   private void faceAndAttack(Mob target, Skill_info skill) throws IOException {
      if (target != null && skill != null && skill.temp != null && !this.shouldYieldMob(target)) {
         this.y = target.y;
         this.moveTo((short)Math.max(35, Math.min(1050, target.x + Util.random(-35, 35))), target.y);
         Message mTmp = new Message(2);
         mTmp.writer().writeShort(skill.temp.ID);
         mTmp.writer().writeByte(1);
         mTmp.writer().writeByte(1);
         mTmp.writer().writeShort(target.index);
         byte[] data = mTmp.getData();
         Message mAct = new Message((byte)2, data);
         this.map.use_skill(this, mAct);
         mTmp.cleanup();
         mAct.cleanup();
      } else {
         this.targetMobIndex = -1;
      }
   }

   private void moveToward(short targetX, short targetY, int stopDistance) throws IOException {
      long now = System.currentTimeMillis();
      if (now >= this.nextMoveTime) {
         this.nextMoveTime = now + Util.random(900, 1800);
         int dx = targetX - this.x;
         int dy = targetY - this.y;
         int dist = Math.max(1, this.distance(this.x, this.y, targetX, targetY));
         int travel = Math.max(35, Math.min(180, dist - stopDistance));
         short nx = (short)(this.x + dx * travel / dist);
         short ny = (short)(this.y + dy * travel / dist);
         this.moveTo(nx, ny);
      }
   }

   private void roam(Player anchor, long now) throws IOException {
      if (anchor != null && Util.random(0, 100) < 35) {
         short rx = (short)(anchor.x + Util.random(-180, 181));
         short ry = (short)(anchor.y + Util.random(-45, 46));
         this.moveToThrottled(rx, ry, now, Util.random(1600, 3600));
      } else {
         this.idleWalk(anchor, now);
      }
   }

   private void idleWalk(Player anchor, long now) throws IOException {
      if (now >= this.nextMoveTime) {
         this.nextMoveTime = now + Util.random(1800, 4200);
         short nx;
         short ny;
         if (anchor != null && this.distance(this.x, this.y, anchor.x, anchor.y) > 340) {
            nx = (short)(anchor.x + Util.random(-110, 111));
            ny = (short)(anchor.y + Util.random(-30, 31));
         } else {
            nx = (short)(this.x + Util.random(-150, 151));
            ny = (short)(this.y + Util.random(-30, 31));
         }

         this.moveTo(nx, ny);
      }
   }

   private void moveToThrottled(short nx, short ny, long now, int delay) throws IOException {
      if (now >= this.nextMoveTime) {
         this.nextMoveTime = now + delay;
         this.moveTo(nx, ny);
      }
   }

   private void moveTo(short nx, short ny) throws IOException {
      if (nx < 35) {
         nx = 35;
      } else if (nx > 1050) {
         nx = 1050;
      }

      if (ny < 80) {
         ny = 80;
      } else if (ny > 420) {
         ny = 420;
      }

      Message mTmp = new Message(1);
      mTmp.writer().writeShort(nx);
      mTmp.writer().writeShort(ny);
      byte[] data = mTmp.getData();
      Message mMove = new Message((byte)1, data);
      this.map.send_move(this, mMove);
      mTmp.cleanup();
      mMove.cleanup();
   }

   private void maybeBroadcastInfo(long now) throws IOException {
      if (now >= this.nextInfoTime) {
         this.nextInfoTime = now + 5000L;
         this.update_info_to_all();
      }
   }

   private void autoPotion() {
      try {
         int hpMax = this.body.get_hp_max(true);
         int mpMax = this.body.get_mp_max(true);
         if (this.hp < hpMax * 55 / 100) {
            Service.use_potion(this, 0, hpMax - this.hp);
         }

         if (this.mp < mpMax * 35 / 100) {
            Service.use_potion(this, 1, mpMax - this.mp);
         }
      } catch (Exception var3) {
      }
   }

   private void reviveHere() throws IOException {
      int fullHp = this.body != null ? this.body.get_hp_max(true) : '썐';
      int fullMp = this.body != null ? this.body.get_mp_max(true) : '썐';
      this.hp = Math.max(fullHp, 1);
      this.mp = Math.max(fullMp, 1);
      this.isdie = false;
      Message m = new Message(8);
      m.writer().writeShort(this.index_map);
      m.writer().writeInt(this.hp);
      m.writer().writeShort(this.x);
      m.writer().writeShort(this.y);
      this.map.send_msg_all_p(m, this, true);
      m.cleanup();
   }

   private void autoSpendPoints(long now) throws IOException {
      if (now >= this.nextPointTime && this.pointAttribute > 0) {
         this.nextPointTime = now + 5000L;
         int guard = 0;

         while (
            this.pointAttribute > 0
               && guard++ < 20
               && (this.tryAddPoint(3) || this.tryAddPoint(1) || this.tryAddPoint(2) || this.tryAddPoint(4) || this.tryAddPoint(5))
         ) {
         }

         this.update_info_to_all();
      }
   }

   private boolean tryAddPoint(int pointType) {
      if (this.pointAttribute <= 0) {
         return false;
      } else {
         switch (pointType) {
            case 1:
               if (this.point1 < 80) {
                  this.point1++;
                  this.pointAttribute--;
                  return true;
               }
               break;
            case 2:
               if (this.point2 < 80) {
                  this.point2++;
                  this.pointAttribute--;
                  return true;
               }
               break;
            case 3:
               if (this.point3 < 80) {
                  this.point3++;
                  this.pointAttribute--;
                  return true;
               }
               break;
            case 4:
               if (this.point4 < 80) {
                  this.point4++;
                  this.pointAttribute--;
                  return true;
               }
               break;
            case 5:
               if (this.point5 < 80) {
                  this.point5++;
                  this.pointAttribute--;
                  return true;
               }
         }

         return false;
      }
   }

   private void autoLearnAvailableSkills() throws IOException {
      boolean changed = false;

      for (int i = 0; i < this.skill_point.size(); i++) {
         Skill_info sk = this.skill_point.get(i);
         if (sk != null && sk.temp != null && sk.exp < 0L && sk.temp.Lv_RQ <= this.level && Skill_Template.learn_skill(sk)) {
            changed = true;
         }
      }

      if (changed) {
         this.send_skill();
         this.update_info_to_all();
      }
   }

   private void maybeSocialActions(Player anchor, long now) throws IOException {
      if (anchor != null && now >= this.nextSocialTime) {
         this.nextSocialTime = now + Util.random(45000, 120000);
         this.maybeAddFriend(anchor);
         this.maybeJoinParty(anchor);
         this.maybePrepareDungeon(anchor);
         this.maybeHandleShipping(anchor, now);
      }
   }

   private void maybeAddFriend(Player anchor) throws IOException {
      if (BotManager.AI_FRIEND_ENABLED) {
         if (anchor != null && !(anchor instanceof Bot) && this.distance(this.x, this.y, anchor.x, anchor.y) <= 260) {
            if (!this.hasFriend(this, anchor.name) && !this.hasFriend(anchor, this.name)) {
               if (this.friend_list.size() < 100 && anchor.friend_list.size() < 100) {
                  FriendTemp botFriend = new FriendTemp(anchor);
                  botFriend.id = this.friend_list.size();
                  this.friend_list.add(botFriend);
                  FriendTemp playerFriend = new FriendTemp(this);
                  playerFriend.id = anchor.friend_list.size();
                  anchor.friend_list.add(playerFriend);
                  Message m = new Message(-29);
                  m.writer().writeByte(3);
                  Friend.ReadInfoMemList(m.writer(), playerFriend);
                  anchor.conn.addmsg(m);
                  m.cleanup();
                  Service.send_box_ThongBao_OK(anchor, this.name + " da ket ban voi ban");
                  this.sendMapChat("Ket ban roi, lan sau train tiep nha");
               }
            }
         }
      }
   }

   private boolean hasFriend(Player p, String name) {
      if (p != null && p.friend_list != null && name != null) {
         for (int i = 0; i < p.friend_list.size(); i++) {
            if (p.friend_list.get(i).name.equals(name)) {
               return true;
            }
         }

         return false;
      } else {
         return false;
      }
   }

   private void maybeJoinParty(Player anchor) throws IOException {
      if (BotManager.AI_PARTY_ENABLED) {
         if (anchor != null && !(anchor instanceof Bot) && this.distance(this.x, this.y, anchor.x, anchor.y) <= 320) {
            if (this.party == null) {
               long now = System.currentTimeMillis();
               if (anchor.party != null) {
                  if (anchor.party.try_add_bot_mem(this)) {
                     this.moveTo(anchor.x, anchor.y);
                     this.sendMapChat("Minh vao nhom ho tro danh quai nha");
                  }
               } else if (now >= this.nextPartyInviteTime) {
                  this.nextPartyInviteTime = now + Util.random(60000, 120000);
                  if (this.party == null) {
                     this.party = new Party(this);
                  }

                  Message m = new Message(-25);
                  m.writer().writeByte(0);
                  m.writer().writeShort(this.index_map);
                  m.writer().writeUTF(this.name);
                  anchor.conn.addmsg(m);
                  m.cleanup();
                  this.sendMapChat("Ai muon party train chung khong? Minh moi vao nhom nhe!");
               }
            }
         }
      }
   }

   private void maybePrepareDungeon(Player anchor) throws IOException {
      if (BotManager.AI_DUNGEON_HELP_ENABLED) {
         if (anchor != null && this.party != null && this.party == anchor.party) {
            if (this.get_key_boss() < 5) {
               this.update_key_boss(20);
            }

            if (this.distance(this.x, this.y, anchor.x, anchor.y) > 80) {
               this.moveTo(anchor.x, anchor.y);
            }
         }
      }
   }

   private void maybeHandleShipping(Player anchor, long now) throws IOException {
      if (BotManager.AI_SHIPPING_ENABLED) {
         if (now >= this.nextShipTime) {
            this.nextShipTime = now + Util.random(120000, 300000);
            if (anchor != null
               && anchor.ship_pet != null
               && anchor.ship_pet.map == this.map
               && (anchor.ship_pet.mainBaoVe == null || anchor.ship_pet.mainBaoVe.isEmpty())
               && this.distance(this.x, this.y, anchor.x, anchor.y) < 360) {
               anchor.ship_pet.mainBaoVe = this.name;
               this.name_ThoSanHaiTac = new String[]{anchor.name};
               this.sendMapChat("Minh bao ve hang cho " + anchor.name + " nhe");
            } else {
               if (this.ship_pet == null
                  && this.map != null
                  && this.map.template != null
                  && this.map.template.id == 1
                  && this.typePirate == 0
                  && Util.random(0, 100) < 35) {
                  this.startBotShipping();
               }
            }
         }
      }
   }

   private void startBotShipping() throws IOException {
      this.id_ship_packet = (short)Util.random(36, 40);
      this.ship_pet = new Ship_pet();
      this.ship_pet.index_map = nextShipCargoIndex();
      this.ship_pet.main_ship = this;
      this.ship_pet.map = this.map;
      this.ship_pet.name = "Hang " + this.name;
      this.ship_pet.x = this.x;
      this.ship_pet.y = this.y;
      this.ship_pet.hp_max = 2000 + Math.max(0, this.level - 15) * 25;
      this.ship_pet.hp = this.ship_pet.hp_max;
      this.ship_pet.time_start = System.currentTimeMillis();
      this.ship_pet.id_map_save = this.map.template.id;
      Ship_pet.add(this.ship_pet);
      Message m = new Message(1);
      m.writer().writeByte(0);
      m.writer().writeShort(this.ship_pet.index_map);
      m.writer().writeShort(this.ship_pet.x);
      m.writer().writeShort(this.ship_pet.y);
      synchronized (this.map.players) {
         for (int i = 0; i < this.map.players.size(); i++) {
            Player p0 = this.map.players.get(i);
            if (p0 != null && p0.conn != null) {
               p0.conn.addmsg(m);
            }
         }
      }

      m.cleanup();
      this.sendMapChat("Minh bat dau van chuyen hang, ai bao ve chung khong?");
   }

   private static synchronized short nextShipCargoIndex() {
      if (nextShipCargoIndex > -100) {
         nextShipCargoIndex = -3000;
      }

      return nextShipCargoIndex++;
   }

   private void maybePostRareMarketItem(long now) {
      if (BotManager.AI_MARKET_ENABLED) {
         if (now >= this.nextMarketTime && Market.ENTRY != null && !Market.ENTRY.isEmpty()) {
            this.nextMarketTime = now + Util.random(180000, 420000);

            try {
               Market myMarket = Market.get_list_my_item(this);
               if (myMarket != null && myMarket.item3.size() + myMarket.item47.size() >= 4) {
                  return;
               }

               Item_wear rare = this.createRareWearForEconomy(true);
               if (rare == null || rare.template == null) {
                  return;
               }

               int typeMarket = this.marketTypeFor(rare.template.typeEquip);
               Market market = Market.get_list_by_type(typeMarket);
               if (market == null) {
                  return;
               }

               ItemMarket listing = new ItemMarket();
               listing.clone_from_item_wear(rare);
               if (listing.index == -1) {
                  return;
               }

               listing.time_market = now + 86400000L;
               listing.price_market = this.rareMarketPrice(rare);
               listing.seller = this.name;
               listing.type_market = 1;
               market.item3.add(listing);
               if (Util.random(0, 100) < 45) {
                  this.sendMapChat("Minh vua dang ban do ngon tren cho, ai can thi xem nha");
               }
            } catch (Exception var8) {
               if (this.aiErrorCount++ < 20) {
                  System.err.println("[BotAI] " + this.name + " market error: " + var8.getMessage());
               }
            }
         }
      }
   }

   private void maybeHandleTradeRequest(long now) throws IOException {
      if (BotManager.AI_TRADE_ENABLED) {
         if (now >= this.nextTradeCheckTime) {
            this.nextTradeCheckTime = now + Util.random(1800, 3500);
            Player buyer = this.trade_target;
            if (buyer != null && !(buyer instanceof Bot) && buyer.conn != null && buyer.map == this.map) {
               if (buyer.trade_target != this) {
                  this.trade_target = null;
               } else if (this.list_item_trade3 == null || !this.is_lock_trade) {
                  this.ensureInventory();
                  Item_wear offer = this.createRareWearForEconomy(true);
                  if (offer != null && this.item.add_item_bag3(offer)) {
                     Trade.show_table(this, buyer.name);
                     Trade.show_table(buyer, this.name);
                     this.addTradeWearForBuyer(buyer, offer);
                     this.sendTradePopup(buyer, this.nextTradeLine(offer));
                     this.lockTradeForBuyer(buyer);
                     this.acceptTradeForBuyer(buyer);
                     if (Util.random(0, 100) < 60) {
                        this.sendMapChat("Ai can do hiem thi giao dich minh nha");
                     }
                  } else {
                     Trade.end_trade_by_disconnect(buyer, this, 0, "");
                     Trade.end_trade_by_disconnect(this, buyer, 0, "");
                  }
               }
            }
         }
      }
   }

   private void addTradeWearForBuyer(Player buyer, Item_wear offer) throws IOException {
      this.list_item_trade3.add(offer);
      Message m = new Message(-49);
      m.writer().writeByte(1);
      m.writer().writeByte(1);
      m.writer().writeByte(3);
      m.writer().writeByte(1);
      Item.readUpdateItem(m.writer(), offer, this);
      buyer.conn.addmsg(m);
      m.cleanup();
   }

   private void sendTradePopup(Player buyer, String text) throws IOException {
      Message m = new Message(-49);
      m.writer().writeByte(2);
      m.writer().writeByte(1);
      m.writer().writeUTF(text);
      buyer.conn.addmsg(m);
      m.cleanup();
   }

   private void lockTradeForBuyer(Player buyer) throws IOException {
      Message m = new Message(-49);
      m.writer().writeByte(3);
      m.writer().writeByte(1);
      buyer.conn.addmsg(m);
      m.cleanup();
      this.is_lock_trade = true;
      this.fee_trade = 0;

      for (int i = 0; i < this.list_item_trade3.size(); i++) {
         Item_wear it = this.list_item_trade3.get(i);
         if (it != null && it.template != null) {
            this.fee_trade = this.fee_trade + it.template.color * 50;
            this.fee_trade = this.fee_trade + 5000 * it.levelup;
            this.fee_trade = this.fee_trade + 10000 * it.isHoanMy;
         }
      }
   }

   private void acceptTradeForBuyer(Player buyer) throws IOException {
      Message m = new Message(-49);
      m.writer().writeByte(4);
      m.writer().writeByte(1);
      buyer.conn.addmsg(m);
      m.cleanup();
      this.is_accept_trade = true;
   }

   private String nextTradeLine(Item_wear offer) {
      String itemName = offer != null && offer.template != null ? offer.template.name : "do hiem";
      String[] lines = new String[]{
         "Minh de mon " + itemName + " len truoc nha",
         "Do nay farm map cao moi co do",
         "Neu hop class thi lay dung tam rat on",
         "Mon nay khong khoa, ban co the dung hoac ban lai",
         "Can mon khac thi lat nua minh doi do"
      };
      return lines[Util.random(0, lines.length)];
   }

   private Item_wear createRareWearForEconomy(boolean tradeable) {
      byte[] slots = new byte[]{0, 1, 3, 4, 5, 7};
      ItemTemplate3 template = null;

      for (int tries = 0; tries < slots.length && template == null; tries++) {
         template = this.findEconomyTemplate(slots[Util.random(0, slots.length)]);
      }

      if (template == null) {
         return null;
      } else {
         Item_wear wear = new Item_wear();
         wear.setup_template_by_id(template);
         this.tuneRareWear(wear, tradeable);
         if (tradeable) {
            wear.typelock = 0;
            wear.mdakham = new short[0];
            wear.numLoKham = 0;
         }

         return wear;
      }
   }

   private ItemTemplate3 findEconomyTemplate(byte typeEquip) {
      List<ItemTemplate3> candidates = new ArrayList<>();
      int targetLevel = Math.max(20, Math.max(this.displayGearLevel, this.level));
      int minLevel = Math.max(1, targetLevel - 20);

      for (int i = 0; i < ItemTemplate3.ENTRYS.size(); i++) {
         ItemTemplate3 it = ItemTemplate3.ENTRYS.get(i);
         if (it != null
            && it.typeEquip == typeEquip
            && it.level >= minLevel
            && it.level <= targetLevel + 8
            && this.matchesBotClass(it)
            && it.typelock != 1
            && (it.color >= 3 || it.level >= targetLevel - 5)) {
            candidates.add(it);
         }
      }

      return !candidates.isEmpty() ? candidates.get(Util.random(0, candidates.size())) : this.findWearTemplate(typeEquip);
   }

   private int marketTypeFor(int typeEquip) {
      if (typeEquip == 0 || typeEquip == 1 || typeEquip == 7) {
         return 0;
      } else {
         return typeEquip != 3 && typeEquip != 5 ? 2 : 1;
      }
   }

   private int rareMarketPrice(Item_wear wear) {
      int color = wear.template != null ? wear.template.color : 1;
      int level = wear.template != null ? wear.template.level : Math.max(1, this.level);
      long price = 25000L + level * 3500L + wear.levelup * 18000L + color * 60000L;
      if (wear.isHoanMy > 0) {
         price += 180000L;
      }

      return (int)Math.min(2000000000L, Math.max(50000L, price));
   }

   private void ensureInventory() {
      if (this.item == null) {
         this.item = new Item(this);
      }

      if (this.item.bag3 == null || this.item.bag3.length == 0) {
         this.item.bag3 = new Item_wear[127];
      }

      if (this.item.bag47 == null) {
         this.item.bag47 = new ArrayList<>();
      }

      if (this.item.save_item_wear == null) {
         this.item.save_item_wear = new ArrayList<>();
      }
   }

   private void sendMapChat(String text) throws IOException {
      if (BotManager.AI_CHAT_ENABLED) {
         if (this.map != null && text != null && !text.isEmpty()) {
            Message m = new Message(17);
            m.writer().writeShort(this.index_map);
            m.writer().writeByte(0);
            m.writer().writeUTF(text);
            this.map.send_msg_all_p(m, this, true);
            m.cleanup();
         }
      }
   }

   private void maybeChat(long now) throws IOException {
      if (BotManager.AI_CHAT_ENABLED) {
         if (now >= this.nextChatTime && Util.random(0, 100) <= 22) {
            this.nextChatTime = now + Util.random(12000, 30000);
            Message m = new Message(17);
            m.writer().writeShort(this.index_map);
            m.writer().writeByte(0);
            m.writer().writeUTF(this.nextChatLine());
            this.map.send_msg_all_p(m, this, true);
            m.cleanup();
         }
      }
   }

   private String nextChatLine() {
      int roll = Util.random(0, 100);
      String[] lines;
      if (roll < 12) {
         lines = CHAT_SOCIAL;
      } else if (roll < 22) {
         lines = CHAT_PROGRESS;
      } else if (roll < 32) {
         lines = CHAT_LOOT;
      } else if (this.aiState == Bot.AiState.ATTACK || this.aiState == Bot.AiState.HUNT) {
         lines = CHAT_HUNT;
      } else if (this.aiState == Bot.AiState.REST) {
         lines = CHAT_REST;
      } else {
         lines = CHAT_ROAM;
      }

      String text = lines[Util.random(0, lines.length)];
      if (lines.length > 1) {
         int guard = 0;

         while (text.equals(this.lastChatLine) && guard++ < 5) {
            text = lines[Util.random(0, lines.length)];
         }
      }

      this.lastChatLine = text;
      return text;
   }

   private void maybeSave(long now) {
      if (now >= this.nextSaveTime) {
         this.nextSaveTime = now + 60000L;

         try {
            Player.flush(this, false);
         } catch (Exception var4) {
         }
      }
   }

   private int distance(int x1, int y1, int x2, int y2) {
      int dx = x1 - x2;
      int dy = y1 - y2;
      return (int)Math.sqrt((double)dx * dx + (double)dy * dy);
   }

   private static enum AiState {
      ROAM,
      HUNT,
      ATTACK,
      REST;
   }

   private static class DummySession extends Session {
      public DummySession() {
         super(null);
      }

      @Override
      public void addmsg(Message m) {
      }
   }
}
