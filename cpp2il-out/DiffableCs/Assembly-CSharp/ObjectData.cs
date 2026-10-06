//Type is in global namespace

public class ObjectData
{
	public const sbyte T_CHAR_PART = 7; //Field offset: 0x0
	public static mVector vecSaveImage; //Field offset: 0x0
	public const short OTHER_TILE_WATER = 70; //Field offset: 0x0
	public const short OTHER_TILE = 20; //Field offset: 0x0
	public const short OTHER_BIG_BOSS = 0; //Field offset: 0x0
	public const short CHAR_PART_VER2 = 26000; //Field offset: 0x0
	public const short IMAGE_EFF_CLIENT_LOW = 25000; //Field offset: 0x0
	public const short IMAGE_EFF_CLIENT = 24000; //Field offset: 0x0
	public const short IMAGE_OTHER_NEW = 23000; //Field offset: 0x0
	public const short ICON_CLAN_BIG = 22000; //Field offset: 0x0
	public const short SKILL_COMBO = 21000; //Field offset: 0x0
	public const short FASHION = 20000; //Field offset: 0x0
	public const short CHAR_PART = 10000; //Field offset: 0x0
	public const short GHOST = 999; //Field offset: 0x0
	public const short BOAT = 8000; //Field offset: 0x0
	public const short ICON_CLAN = 7000; //Field offset: 0x0
	public const short MATERIAL_POTION = 6500; //Field offset: 0x0
	public const short QUEST_POTION = 6000; //Field offset: 0x0
	public const short NPC = 5000; //Field offset: 0x0
	public const short SKILL_SMALL = 4500; //Field offset: 0x0
	public const short SKILL = 4000; //Field offset: 0x0
	public const short ITEM_OTHER = 9000; //Field offset: 0x0
	public const short ITEM = 3000; //Field offset: 0x0
	public const short POTION = 2000; //Field offset: 0x0
	public const short MONSTER = 1000; //Field offset: 0x0
	public const short ITEMMAP = 0; //Field offset: 0x0
	public static MyHashTable HashImageItemMap; //Field offset: 0x8
	public static MyHashTable HashImageMonster; //Field offset: 0x10
	public static MyHashTable hashImageItem; //Field offset: 0x18
	public static MyHashTable hashImagePotion; //Field offset: 0x20
	public static MyHashTable hashImageSkill; //Field offset: 0x28
	public static MyHashTable hashImageSkillSmall; //Field offset: 0x30
	public static MyHashTable hashImageNPC; //Field offset: 0x38
	public static MyHashTable hashImageQuestPotion; //Field offset: 0x40
	public static MyHashTable hashImageMaterialPotion; //Field offset: 0x48
	public static MyHashTable hashImageIconClan; //Field offset: 0x50
	public static MyHashTable hashImageIconClanBig; //Field offset: 0x58
	public static MyHashTable hashImageBoat; //Field offset: 0x60
	public static MyHashTable hashImageItemOther; //Field offset: 0x68
	public static MyHashTable HashImageCharPart; //Field offset: 0x70
	public static MyHashTable HashImageFashion; //Field offset: 0x78
	public static MyHashTable HashImageOtherNew; //Field offset: 0x80
	public static MyHashTable HashImageEffClient; //Field offset: 0x88
	public static MyHashTable HashImageEffClientLow; //Field offset: 0x90

	private static ObjectData() { }

	public ObjectData() { }

	public static void checkDelHash(MyHashTable hash, int time, bool isTrue) { }

	public static void checkDelHash_Data(MyHashTable hash, int time, bool isTrue) { }

	public static mImage getFromRms(short id, int typeImage, MyHashTable myhash) { }

	public static MainImage getImageAll(short id, MyHashTable hash, short typeImage) { }

	public static MainImage getImageAll(short id, string strId, MyHashTable hash, short typeImage) { }

	public static MainImage getImageOther(short id, short type) { }

	public static mImage getImageServerIOS(mImage img, short id, int typeImage, MyHashTable myhash) { }

	public static void saveImageToRmsAndroid(SByte[] mimg, string name) { }

	public static bool setIdOK(short id) { }

	public static void setToRms(SByte[] mimg, short id) { }

}

