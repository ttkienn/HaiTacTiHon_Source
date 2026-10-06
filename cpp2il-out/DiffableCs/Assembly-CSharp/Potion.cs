//Type is in global namespace

public class Potion : MainItem
{
	public static mVector vecPotionDonotData; //Field offset: 0x0
	public const sbyte POTION_DOT_PHAO = 100; //Field offset: 0x0
	public const sbyte POTION_THA_DEN = 84; //Field offset: 0x0
	public const sbyte POTION_POKE = 40; //Field offset: 0x0
	public const sbyte POTION_HP_FOCUS_MAX_LEVEL = 106; //Field offset: 0x0
	public const sbyte POTION_THONG_THAO = 105; //Field offset: 0x0
	public const sbyte POTION_HP_FOCUS_LOW = 104; //Field offset: 0x0
	public const sbyte POTION_ATT_CLAN = 103; //Field offset: 0x0
	public const sbyte POTION_HP_FOCUS = 102; //Field offset: 0x0
	public const sbyte POTION_EFF_HP_MAX = 101; //Field offset: 0x0
	public const sbyte POTION_EFF_HP = 99; //Field offset: 0x0
	public const sbyte POTION_EFF_HP_2 = 100; //Field offset: 0x0
	public const sbyte POTION_MP_PVP_NEW = 97; //Field offset: 0x0
	public const sbyte POTION_HP_MAXLV_PVP_NEW = 96; //Field offset: 0x0
	public const sbyte POTION_DA_KHAM = 12; //Field offset: 0x0
	public const sbyte POTION_RUONG_THAN_BI = 4; //Field offset: 0x0
	public const sbyte POTION_RUONG = 3; //Field offset: 0x0
	public const sbyte POTION_MP = 2; //Field offset: 0x0
	public const sbyte POTION_HP = 1; //Field offset: 0x0
	public const sbyte POTION_OTHER = 0; //Field offset: 0x0
	public const sbyte POTION_HP_PVP_NEW = 98; //Field offset: 0x0
	public static mVector vecPotionDonotInfo; //Field offset: 0x8
	public static MyHashTable hashInfoPotion; //Field offset: 0x10
	public short timeActive; //Field offset: 0xC8
	public bool isUpdateTem; //Field offset: 0xCA

	private static Potion() { }

	public Potion(sbyte typeItem, short ID, short idIcon, string name, sbyte isTrade) { }

	public Potion(short Id, short idImage, string name, string info, short priceRuby) { }

	public Potion(short Id) { }

	public Potion(sbyte cat, short Id, short num, bool isShop) { }

	public bool canSell() { }

	public static void CheckAddDataTemplate() { }

	public static void checkVecNonInfo(short index, string infonew) { }

	public virtual mVector getActionChest() { }

	public virtual mVector getActionInven(sbyte type) { }

	public virtual mVector getActionShop(sbyte typeShop) { }

	public virtual mVector getActionSplit() { }

	public static MainImage getIconClan(short Id) { }

	public static MainImage getIconClanBig(short Id) { }

	public virtual MainImage getImage() { }

	public static Potion getTemplatePotion(short IdP) { }

	public static void LoadDataPotion(DataInputStream iss, bool isSave, sbyte typePotion) { }

	public static void LoadDataPotionTemplate(DataInputStream iss, sbyte typePotion) { }

	public virtual void paint(mGraphics g, int x, int y, int w) { }

	public virtual void paintHotkey(mGraphics g, int x, int y, int w, int ylech) { }

	public void paintIconClan(mGraphics g, int x, int y, int w) { }

	public virtual void paintQuay(mGraphics g, int x, int y, int w) { }

	public static Potion Potion_Tem(sbyte typeItem, short ID, short idIcon, string name, string info, sbyte isTrade, short price, short priceRuby, sbyte Hp_Mp_Other, short timeDelay, short value, short timeactive, string nameUse) { }

	public void setdata(int price, short priceRuby, short value, short timeActive, short timedelay, sbyte hp_mp, string nameUse) { }

	public static Potion Update_Potion_Tem(sbyte typeItem, short ID, short idIcon, string name, string info, sbyte isTrade, int price, short priceRuby, sbyte Hp_Mp_Other, short timeDelay, short value, short timeactive, string nameUse) { }

	public static void UpdateDataPotion(DataInputStream iss, bool isSave, sbyte typePotion) { }

	public virtual void Use_Item() { }

}

