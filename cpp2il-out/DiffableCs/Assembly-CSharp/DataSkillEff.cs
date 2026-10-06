//Type is in global namespace

public class DataSkillEff
{
	public const sbyte NO_REMOVE = 3; //Field offset: 0x0
	public const sbyte REMOVE_BY_FRAME = 1; //Field offset: 0x0
	public const sbyte NORMAL = 0; //Field offset: 0x0
	public const sbyte CHOANG = 1; //Field offset: 0x0
	public static MyHashTable ALL_EFF_DATA; //Field offset: 0x0
	public const sbyte BIENHINH = 2; //Field offset: 0x0
	public const sbyte REMOVE_BY_TIME = 2; //Field offset: 0x0
	public static MyHashTable ALL_IMAGE_EFF_DATA; //Field offset: 0x8
	public sbyte Frame; //Field offset: 0x10
	public sbyte f; //Field offset: 0x11
	public long timeremove; //Field offset: 0x18
	public long timeGetBack; //Field offset: 0x20
	public mVector listFrame; //Field offset: 0x28
	public mVector listAnima; //Field offset: 0x30
	public SmallImage[] smallImage; //Field offset: 0x38
	public SByte[][] frameChar; //Field offset: 0x40
	public SByte[] sequence; //Field offset: 0x48
	public int fw; //Field offset: 0x50
	public int fh; //Field offset: 0x54
	public SByte[] indexSplash; //Field offset: 0x58
	private int loop; //Field offset: 0x60
	public sbyte waitLoop; //Field offset: 0x64
	public bool isLoadData; //Field offset: 0x65
	public short idEff; //Field offset: 0x66
	public bool canremove; //Field offset: 0x68
	public sbyte typeupdate; //Field offset: 0x69
	public int x; //Field offset: 0x6C
	public int y; //Field offset: 0x70
	public sbyte typeMove; //Field offset: 0x74
	public bool isbuff; //Field offset: 0x75
	private int min; //Field offset: 0x78
	public bool wantDestroy; //Field offset: 0x7C
	private long lasttime; //Field offset: 0x80
	private long timelive; //Field offset: 0x88

	private static DataSkillEff() { }

	public DataSkillEff(SByte[] array, bool changeFlip) { }

	public DataSkillEff(SByte[] array) { }

	public DataSkillEff(short ideff, int x, int y, bool changeFlip) { }

	public DataSkillEff(short ideff, int x, int y) { }

	public DataSkillEff(short idEff, SByte[] data) { }

	public DataSkillEff(short idEff, int time, sbyte typemove, sbyte loop) { }

	public DataSkillEff(short idEff, int time, sbyte typemove, sbyte loop, bool changeFlip) { }

	public DataSkillEff(short idEff, int time, bool changeFlip) { }

	public DataSkillEff(short idEff, int time) { }

	public mImage getImage() { }

	public bool isHavedata() { }

	public void load() { }

	public void load(bool changeFlip) { }

	public void loadData(SByte[] array, bool changeFlip) { }

	public void loadData(SByte[] array) { }

	public void paint(mGraphics g) { }

	public void paintBottomEff(mGraphics g, int x, int y, int hOne) { }

	public void paintBottomEff(mGraphics g) { }

	public void paintTopEff(mGraphics g, int x, int y, int hOne) { }

	public void paintTopEff(mGraphics g) { }

	public static EffectData readData(SByte[] dataeff, bool isSave) { }

	public static void saveDataSkillEff(SByte[] dataSave, short id) { }

	public void setFrame(int fr) { }

	public void setLoop(int loop) { }

	public void update() { }

}

