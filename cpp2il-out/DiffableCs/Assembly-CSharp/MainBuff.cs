//Type is in global namespace

public class MainBuff
{
	public const short BUFF_ICE = 2032; //Field offset: 0x0
	public const short BUFF_THUNDER_FALL = 2004; //Field offset: 0x0
	public const short BUFF_CAUSU = 2008; //Field offset: 0x0
	public const short BUFF_TUAN_LOC = 2010; //Field offset: 0x0
	public const short BUFF_NEW_LUFFY = 1010; //Field offset: 0x0
	public const short BUFF_NEW_ZORO = 1011; //Field offset: 0x0
	public const short BUFF_NEW_SANJI = 1012; //Field offset: 0x0
	public const short BUFF_NEW_NAMI = 1013; //Field offset: 0x0
	public const short BUFF_NEW_USSOP = 1014; //Field offset: 0x0
	public const short BUFF_DALTON = 2017; //Field offset: 0x0
	public const short BUFF_GLODEN_WEEK_DAM = 2018; //Field offset: 0x0
	public const short BUFF_GLODEN_WEEK_DEF = 2019; //Field offset: 0x0
	public const short BUFF_GLODEN_WEEK_COMBO = 2020; //Field offset: 0x0
	public const short BUFF_LAVA = 2028; //Field offset: 0x0
	public const short BUFF_LAVA_2 = 2042; //Field offset: 0x0
	public const short BUFF_LOL_KILL_BOSS = 2035; //Field offset: 0x0
	public const short BUFF_COMBO_SKILL_GEAR_5 = 1023; //Field offset: 0x0
	public const short BUFF_PELL = 2037; //Field offset: 0x0
	public const short BUFF_COMBO_SKILL_GEAR_4 = 1022; //Field offset: 0x0
	public const short BUFF_COMBO_SKILL_GEAR_2 = 1020; //Field offset: 0x0
	public const short BUFF_BOAHANDCOCK = 2076; //Field offset: 0x0
	public const short BUFF_KIZURA = 2072; //Field offset: 0x0
	public const short BUFF_DOOR = 2070; //Field offset: 0x0
	public const short BUFF_XAPHONG = 2067; //Field offset: 0x0
	public const short BUFF_HUOU = 2064; //Field offset: 0x0
	public const short BUFF_SOI = 2061; //Field offset: 0x0
	public const short BUFF_DECREASE_DAMAGE = 2060; //Field offset: 0x0
	public const short BUFF_FASHION_INCREASE_DAMAGE = 2059; //Field offset: 0x0
	public const short BUFF_FASHION_RAU_DEN_2 = 2057; //Field offset: 0x0
	public const short BUFF_FASHION_RAU_DEN = 2054; //Field offset: 0x0
	public const short BUFF_KILO = 2053; //Field offset: 0x0
	public const short BUFF_0 = 1003; //Field offset: 0x0
	public const short BUFF_1 = 1002; //Field offset: 0x0
	public const short BUFF_2 = 1004; //Field offset: 0x0
	public const short BUFF_COMBO_SKILL_GEAR_1 = 1019; //Field offset: 0x0
	public const short BUFF_COMBO_SKILL_GEAR_3 = 1021; //Field offset: 0x0
	public const short BUFF_LUCCI = 2040; //Field offset: 0x0
	public MainObject obj; //Field offset: 0x10
	public short IdBuff; //Field offset: 0x18
	public short idIcon; //Field offset: 0x1A
	public sbyte levelPaint; //Field offset: 0x1C
	public int timeBuff; //Field offset: 0x20
	public int xlech; //Field offset: 0x24
	public int ylech; //Field offset: 0x28
	public int color; //Field offset: 0x2C
	public int f; //Field offset: 0x30
	public int maxsize; //Field offset: 0x34
	private long timeBegin; //Field offset: 0x38
	private sbyte numNextframe; //Field offset: 0x40
	private FrameImage fraBuff; //Field offset: 0x48
	private FrameImage fraBuff2; //Field offset: 0x50
	private int numFrame; //Field offset: 0x58
	private int numFrame2; //Field offset: 0x5C
	private FrameImage[] mfraBuff; //Field offset: 0x60
	public bool isRemove; //Field offset: 0x68
	public bool isDevil; //Field offset: 0x69
	public mVector vecInfoAtt; //Field offset: 0x70
	public mVector vecEffBuff; //Field offset: 0x78
	public short head; //Field offset: 0x80
	public short body; //Field offset: 0x82
	public short leg; //Field offset: 0x84
	public short hair; //Field offset: 0x86
	public Int32[] mPlayframe; //Field offset: 0x88
	private int fRemove; //Field offset: 0x90
	private int Cx; //Field offset: 0x94
	private int Cy; //Field offset: 0x98
	private int vy; //Field offset: 0x9C

	public MainBuff(short typeBuff) { }

	private void createCharTeleport() { }

	public void createPoint() { }

	public Point createPointNewBuff(Point p) { }

	public void paint(mGraphics g, int x, int y) { }

	public void paintHotKey(mGraphics g) { }

	public void paintLastSpec(mGraphics g, int x, int y, MainObject obj) { }

	public void setData(short idIcon) { }

	public void setDevilBuff(short head, short body, short leg) { }

	public void setObjc(MainObject obj) { }

	public void setTimeBuff(int timebuff) { }

	public void setYlech(MainObject obj) { }

	public void update() { }

}

