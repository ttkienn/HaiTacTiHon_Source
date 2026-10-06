//Type is in global namespace

public class SmallImage
{
	public static Int32[][] smallImg; //Field offset: 0x0
	public static SmallImage instance; //Field offset: 0x8
	public static mImage[] imgbig; //Field offset: 0x10
	public static mImage imgEmpty; //Field offset: 0x18
	public static SByte[] newSmallVersion; //Field offset: 0x20
	public short id; //Field offset: 0x10
	public short x; //Field offset: 0x12
	public short y; //Field offset: 0x14
	public short w; //Field offset: 0x16
	public short h; //Field offset: 0x18

	public SmallImage(int id, int x, int y, int w, int h) { }

	public SmallImage() { }

	public static void clearHastable() { }

	public static void drawSmallImage(mGraphics g, int id, int x, int y, int transform, int anchor, int index) { }

	public static void freeBig() { }

	public static void init() { }

	public static void loadBigImage() { }

	public static void loadBigRMS() { }

	public void readData(SByte[] data) { }

	public static void readImage(SByte[] data) { }

	public static void update() { }

}

