//Type is in global namespace

public class Boat : MainItemMap
{
	public const sbyte EFF_VET_NUOC_MANG_THUYEN_STAND = 2; //Field offset: 0x0
	public const sbyte EFF_SONG_MANG_THUYEN_STAND = 1; //Field offset: 0x0
	public const sbyte EFF_SONG_MANG_THUYEN_MOVE = 0; //Field offset: 0x0
	public const sbyte EFF_SONG_DAU_THUYEN_MOVE = -1; //Field offset: 0x0
	public static int hlech; //Field offset: 0x0
	public static mImage imgShip; //Field offset: 0x8
	public static mImage imgEffSea; //Field offset: 0x10
	public static mImage imgEffSea2; //Field offset: 0x18
	public static mImage imgEffSea3; //Field offset: 0x20
	public static Int32[][] sizeImgBoat; //Field offset: 0x28
	public static FrameImage fraEffSea; //Field offset: 0x30
	public static FrameImage fraEffSea2; //Field offset: 0x38
	public static FrameImage fraEffSea3; //Field offset: 0x40
	public static FrameImage fraPirateUnity; //Field offset: 0x48
	public static FrameImage fraEffSea4; //Field offset: 0x50
	public short idIconClan; //Field offset: 0x488
	public bool isSetLevelPaint; //Field offset: 0x48A
	public bool isPaint; //Field offset: 0x48B
	public bool loadDataOk; //Field offset: 0x48C
	public int wlech; //Field offset: 0x490
	public int numNextFrame; //Field offset: 0x494
	public sbyte levelPaintBoat; //Field offset: 0x498
	public sbyte pirate; //Field offset: 0x499
	public mVector vecEff; //Field offset: 0x4A0
	public int xset; //Field offset: 0x4A8
	public int yset; //Field offset: 0x4AC
	public int wset; //Field offset: 0x4B0
	public int hset; //Field offset: 0x4B4
	public Int16[] mPartImage; //Field offset: 0x4B8
	public int tickDonotMove; //Field offset: 0x4C0
	private int lastTick; //Field offset: 0x4C4
	private int framepaint; //Field offset: 0x4C8

	private static Boat() { }

	public Boat(short ID, int x, int y, int dy, sbyte Dir) { }

	public void addEffSea(int x, int y, int type, sbyte dis, int vx) { }

	public void boatSetTouch() { }

	public void boatSetVaCham(int vx, int vy) { }

	public virtual bool isInScreen() { }

	public virtual void paint(mGraphics g) { }

	public void paintBuom(mGraphics g) { }

	public void paintBuom(mGraphics g, short iconClan) { }

	public void paintEff(mGraphics g, sbyte day_night) { }

	public void paintFrist(mGraphics g) { }

	public void paintHang(mGraphics g) { }

	public void paintLast(mGraphics g, sbyte day_night) { }

	public void paintLastInMap(mGraphics g) { }

	public void resetY() { }

	public void setIconClan() { }

	public void setLevelPaint() { }

	public void setPartImage(Int16[] mp, sbyte pirate) { }

	public virtual void update() { }

	public void updateBoat() { }

	public virtual void updateDySea() { }

	public void updateXY(int x, int y, int dy, sbyte Dir) { }

}

