//Type is in global namespace

public class LoadMap
{
	public const int T_MAP_NULL = -1; //Field offset: 0x0
	public static mVector vecPointChange; //Field offset: 0x0
	public const int IDMAP_DAU_CHIEM_DAO_3 = 161; //Field offset: 0x0
	public const int IDMAP_DAU_CHIEM_DAO_1 = 157; //Field offset: 0x0
	public const int IDMAP_CHO_CHIEM_DAO_3 = 162; //Field offset: 0x0
	public const int IDMAP_CHO_CHIEM_DAO_2 = 160; //Field offset: 0x0
	public const int IDMAP_CHO_CHIEM_DAO_1 = 158; //Field offset: 0x0
	public const int IDMAP_FIGHT_CLAN_MAP_FIGHT = 985; //Field offset: 0x0
	public const int IDMAP_FIGHT_CLAN_ROOM_NGOAI = 987; //Field offset: 0x0
	public const int IDMAP_FIGHT_CLAN_ROOM_TRONG = 986; //Field offset: 0x0
	public const int IDMAP_PVP_CLAN = 996; //Field offset: 0x0
	public const int IDMAP_ROOM_PVP_CLAN = 997; //Field offset: 0x0
	public const int IDMAP_PVP = 995; //Field offset: 0x0
	public const int MAP_GOTO_GOD = 12; //Field offset: 0x0
	public const int MAP_CHIEM_DAO = 11; //Field offset: 0x0
	public const int IDMAP_DAU_CHIEM_DAO_2 = 159; //Field offset: 0x0
	public const int MAP_SAN_BOSS = 9; //Field offset: 0x0
	public const int T_MAP_NORMAL = 0; //Field offset: 0x0
	public const int T_MAP_STAND = 1; //Field offset: 0x0
	public const int MAP_LOL = 10; //Field offset: 0x0
	public const int T_MAP_SLOW = 2; //Field offset: 0x0
	public const int MAP_THACH_DAU = 1; //Field offset: 0x0
	public const int MAP_PHO_BANG = 2; //Field offset: 0x0
	public const int MAP_NORMAL = 0; //Field offset: 0x0
	public const int MAP_SEA = 4; //Field offset: 0x0
	public const int MAP_RED_LINE = 5; //Field offset: 0x0
	public const int MAP_PHO_BANG_VUON_CAM = 6; //Field offset: 0x0
	public const int MAP_PHO_BANG_LITTLE_GARDEN = 7; //Field offset: 0x0
	public const int MAP_GOTO_SKY = 8; //Field offset: 0x0
	public const int MAP_TRAIN = 3; //Field offset: 0x0
	public static MyHashTable hashMapItem; //Field offset: 0x8
	public static mVector[] mItemMap; //Field offset: 0x10
	public static mVector mItemMapNonData; //Field offset: 0x18
	public static SByte[] mLockMap; //Field offset: 0x20
	public static Int16[] mMapLang; //Field offset: 0x28
	public static Int16[][] mSea; //Field offset: 0x30
	public static Int32[] mTranPointChangeMap; //Field offset: 0x38
	public static int idTile; //Field offset: 0x40
	public static int wTile; //Field offset: 0x44
	public static Int32[] mStatusArea; //Field offset: 0x48
	public static MainImage imgTile; //Field offset: 0x50
	public static MainImage imgTileWater; //Field offset: 0x58
	public static mImage imgTileSmall; //Field offset: 0x60
	public static int timeVibrateScreen; //Field offset: 0x68
	public static int currentXp; //Field offset: 0x6C
	public static int maxXp; //Field offset: 0x70
	public static sbyte Area; //Field offset: 0x74
	public static sbyte MaxArea; //Field offset: 0x75
	public static sbyte specMap; //Field offset: 0x76
	public static sbyte numPlayerMap; //Field offset: 0x77
	public static sbyte maxnumPlayerMap; //Field offset: 0x78
	public static String[] mNameMap; //Field offset: 0x80
	public static String[] mStrNameMapNPC; //Field offset: 0x88
	public static bool isOnlineMap; //Field offset: 0x90
	public static int demSendTem; //Field offset: 0x94
	public int idMap; //Field offset: 0x10
	public int idMapMini; //Field offset: 0x14
	public int mapW; //Field offset: 0x18
	public int mapH; //Field offset: 0x1C
	public int limitW; //Field offset: 0x20
	public int limitH; //Field offset: 0x24
	public int limitMap; //Field offset: 0x28
	public int maxX; //Field offset: 0x2C
	public int maxY; //Field offset: 0x30
	public int maxWMap; //Field offset: 0x34
	public int maxHMap; //Field offset: 0x38
	public int idLastMap; //Field offset: 0x3C
	public string nameMap; //Field offset: 0x40
	public Int32[] mapPaint; //Field offset: 0x48
	public Int32[] mapType; //Field offset: 0x50
	public SByte[][] mapFind; //Field offset: 0x58
	private int fStand; //Field offset: 0x60
	private int fWater; //Field offset: 0x64
	private int xStart; //Field offset: 0x68
	private int yStart; //Field offset: 0x6C
	private int cmxMini; //Field offset: 0x70
	private int cmyMini; //Field offset: 0x74

	private static LoadMap() { }

	public LoadMap() { }

	public void Block_TileMap_Item(int indexW, int indexH, Int32[][] mb) { }

	public void checkSetItemMap() { }

	public MainItemMap get_Item(short id) { }

	public static sbyte getAreaPaint() { }

	public int getIndex(int xset, int yset) { }

	public static string getNameMap(int index) { }

	public static sbyte getShowArea(sbyte area) { }

	public int getTile(int xset, int yset) { }

	public void load_ItemMap(SByte[] msbyte) { }

	public void load_Table_Map(DataInputStream iss) { }

	public static void load_Table_Map(DataInputStream iss, bool isSave) { }

	public void loadmap(SByte[] msbyte) { }

	public static void LoadNameMap(DataInputStream iss, bool isSave) { }

	public bool mapLang() { }

	public void paint(mGraphics g) { }

	public void setBlockNPC(int x, int y, int w, int h) { }

	public void setBlockPlayer(int x, int y, int w, int h) { }

	private bool setContinue(int i, int j, SByte[][] mapFind) { }

	public static bool Tile_Stand(int type) { }

	public void update() { }

	public Int16[] updateFindRoad(int xF, int yF, int xTo, int yTo, int maxSize, MainObject objMain, int numindex) { }

	public Int16[] updateFindRoad(int xF, int yF, int xTo, int yTo, int maxSize, MainObject objMain) { }

}

