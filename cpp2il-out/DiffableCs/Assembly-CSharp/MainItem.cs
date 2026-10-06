//Type is in global namespace

public class MainItem
{
	public const sbyte MARKET_NORMAL = 0; //Field offset: 0x0
	public const sbyte MARKET_SELLING = 1; //Field offset: 0x0
	public const sbyte MARKET_SELLED = 2; //Field offset: 0x0
	public const sbyte MARKET_SELL_END = 3; //Field offset: 0x0
	public static MainInfoItem[] mNameAttributes; //Field offset: 0x0
	public const sbyte SPEC_HEART = 1; //Field offset: 0x0
	public const sbyte MARKET_BUY_COMPLETE = 4; //Field offset: 0x0
	public static MyHashTable hashPotionTem; //Field offset: 0x8
	public static MyHashTable hashMaterialTem; //Field offset: 0x10
	public static MyHashTable hashPotionClan; //Field offset: 0x18
	public static MyHashTable hashAttriKichAn; //Field offset: 0x20
	public static mImage imgColorItem; //Field offset: 0x28
	public static Effect_UpLv_Item eff_UpLv; //Field offset: 0x30
	public static Effect_UpLv_Item eff_UpLv_Clan; //Field offset: 0x38
	public static Effect_UpLv_Item eff_UpLv_Sub; //Field offset: 0x40
	public static Int16[] ID_POTION_CAN_SELL; //Field offset: 0x48
	public static Int16[] ID_MATERIAL_CAN_SELL; //Field offset: 0x50
	public static Int32[] mValueUpgrade; //Field offset: 0x58
	public int numInt; //Field offset: 0x10
	public int x; //Field offset: 0x14
	public int y; //Field offset: 0x18
	public int timeUse; //Field offset: 0x1C
	public int price; //Field offset: 0x20
	public int priceVND; //Field offset: 0x24
	public short ID; //Field offset: 0x28
	public short idIcon; //Field offset: 0x2A
	public short priceRuby; //Field offset: 0x2C
	public short Lv_RQ; //Field offset: 0x2E
	public short numPotion; //Field offset: 0x30
	public short indexHotKey; //Field offset: 0x32
	public short idPart; //Field offset: 0x34
	public short maxTimeUse; //Field offset: 0x36
	public short indexInfoPotion; //Field offset: 0x38
	public short valueCheTac; //Field offset: 0x3A
	public short IDMarket; //Field offset: 0x3C
	public short numPotionNeed; //Field offset: 0x3E
	public sbyte indexSort; //Field offset: 0x40
	public sbyte typeMaterial; //Field offset: 0x41
	public sbyte LvUpgrade; //Field offset: 0x42
	public sbyte typeBoat; //Field offset: 0x43
	public sbyte numLoKham; //Field offset: 0x44
	public sbyte typelock; //Field offset: 0x45
	public sbyte numHoleDaDuc; //Field offset: 0x46
	public sbyte LvDevilSkill; //Field offset: 0x47
	public sbyte phanTramDevilSkill; //Field offset: 0x48
	public sbyte indexUniform; //Field offset: 0x49
	public sbyte isHoanMy; //Field offset: 0x4A
	public sbyte valueKickAn; //Field offset: 0x4B
	public sbyte typeSpec; //Field offset: 0x4C
	public sbyte perSuc; //Field offset: 0x4D
	public Int16[] mDaKham; //Field offset: 0x50
	public Int16[] mWearing; //Field offset: 0x58
	public string name; //Field offset: 0x60
	public string namepaint; //Field offset: 0x68
	public string info; //Field offset: 0x70
	public string nameUse; //Field offset: 0x78
	public mVector vecInfo; //Field offset: 0x80
	public sbyte isTrade; //Field offset: 0x88
	public sbyte charClass; //Field offset: 0x89
	public sbyte Hp_Mp_Other; //Field offset: 0x8A
	public sbyte typeEquip; //Field offset: 0x8B
	public int wInfo; //Field offset: 0x8C
	public int hInfo; //Field offset: 0x90
	public short timeDelayPotion; //Field offset: 0x94
	public short value; //Field offset: 0x96
	public sbyte colorName; //Field offset: 0x98
	public sbyte typeObject; //Field offset: 0x99
	public sbyte typeMarket; //Field offset: 0x9A
	public bool isRemove; //Field offset: 0x9B
	public bool isIconClan; //Field offset: 0x9C
	public bool isShop; //Field offset: 0x9D
	public bool isPaint; //Field offset: 0x9E
	public bool isRemoveVecEff; //Field offset: 0x9F
	public FrameImage fraImgVip; //Field offset: 0xA0
	public bool isloadfra; //Field offset: 0xA8
	public CountDownTicket marketTime; //Field offset: 0xB0
	public bool isQuickOpen; //Field offset: 0xB8
	public bool isKham; //Field offset: 0xB9
	public int hRunInfo; //Field offset: 0xBC
	private int lastTick; //Field offset: 0xC0
	private int framepaint; //Field offset: 0xC4

	private static MainItem() { }

	public MainItem(sbyte typeItem, short ID, short idIcon, short num, sbyte color, sbyte lvUp) { }

	public MainItem(sbyte typeItem, short ID, short idIcon, string name, sbyte isTrade) { }

	public MainItem() { }

	public MainItem(sbyte type, short idIcon, short id, int num) { }

	public MainItem(sbyte type, short IdIcon, short ID) { }

	public override void addInfo(string str, sbyte color, sbyte colorMain) { }

	public void addInfo(short id, int value, sbyte colorMain) { }

	public void addInfo(short id, int value, sbyte colorMain, sbyte percent) { }

	public override void addInfo(string str, sbyte color) { }

	public void addInfoFrist(string str, sbyte color) { }

	public void addInfoSell(short id, int value) { }

	public void CheckTimeSell() { }

	public override mVector getActionChest() { }

	public override mVector getActionInven(sbyte type) { }

	public override mVector getActionShop(sbyte typeShop) { }

	public override mVector getActionSplit() { }

	public mVector getActionTrade() { }

	public override mVector getActionUpgrade() { }

	public static string getDataKichAn(Item item) { }

	public short getIdMarket() { }

	public override MainImage getImage() { }

	public MainImage getImageAll() { }

	public static string getInfoAttriSS(short id, int value, int valueLvUp, int valueLvCur) { }

	public static string getInfoEveryWhere(MainInfoItem info) { }

	public bool getInfoPotion(short index) { }

	public static string GetInfoPotion(short index) { }

	public static mVector getInfoSS(MainItem itemSet) { }

	public static mVector getInfoSS(MainItem itemSet, int Plus) { }

	public static MainItem getItemVec(sbyte type, short id, mVector vec) { }

	public override bool getStar() { }

	public static string getTimeDelay(int value) { }

	public static void LoadNameAttribute(DataInputStream iss, bool isSave) { }

	public override void paint(mGraphics g, int x, int y, int w) { }

	public void paint(mGraphics g, int x, int y, int w, int lech) { }

	public void paintAllItem(mGraphics g, int x, int y, int w, int lech, sbyte color, short numpaint, bool typePaintNum) { }

	public void paintAllItem(mGraphics g, int x, int y, int w, int lech, sbyte color) { }

	public void paintAllItem_Num1(mGraphics g, int x, int y, int w, int lech, sbyte color, short numPaint) { }

	public void paintColor(mGraphics g, int x, int y, int w) { }

	public void paintEff_LvUp(mGraphics g, int x, int y, int w, int lech) { }

	public void paintEffSub(mGraphics g, int x, int y, int w, int lech) { }

	public override void paintHotkey(mGraphics g, int x, int y, int w, int yLech) { }

	public void paintImgItem(mGraphics g, MainImage img, int x, int y) { }

	public override void paintNumPotion(mGraphics g, int x, int y, int w, short num) { }

	public override void paintNumPotionQuay(mGraphics g, int x, int y, int w, short num) { }

	public override void paintPotion(mGraphics g, int x, int y, int w) { }

	public override void paintQuay(mGraphics g, int x, int y, int w) { }

	public static void removeUpdateItemVec(sbyte type, mVector vec) { }

	private void setFraImageVip(MainImage img) { }

	public override void setInfoItem(MainInfoItem[] mInfoItem) { }

	public void setInfoPotion(string info) { }

	public override void setTimeMarket(int time) { }

	public static mVector SortVecItem(mVector vec) { }

	public static string strGetPercent(int value, sbyte isPer) { }

	private static void swapItem(mVector actors, int dex1, int dex2) { }

	public void updateHInfo() { }

	public override void Use_Item() { }

	public static int valueSameUpgrade(int value, int cur, int up) { }

}

