//Type is in global namespace

public class Point
{
	public static FrameImage[] FraEffInMap; //Field offset: 0x0
	public int x; //Field offset: 0x10
	public int y; //Field offset: 0x14
	public int g; //Field offset: 0x18
	public int v; //Field offset: 0x1C
	public int w; //Field offset: 0x20
	public int h; //Field offset: 0x24
	public int color; //Field offset: 0x28
	public int limitY; //Field offset: 0x2C
	public int vx; //Field offset: 0x30
	public int vy; //Field offset: 0x34
	public int x2; //Field offset: 0x38
	public int y2; //Field offset: 0x3C
	public int x0; //Field offset: 0x40
	public int y0; //Field offset: 0x44
	public int dir; //Field offset: 0x48
	public int dis; //Field offset: 0x4C
	public int f; //Field offset: 0x50
	public int fRe; //Field offset: 0x54
	public int frame; //Field offset: 0x58
	public int maxframe; //Field offset: 0x5C
	public int fSmall; //Field offset: 0x60
	public int levelPaint; //Field offset: 0x64
	public int subType; //Field offset: 0x68
	public mVector vecEffPoint; //Field offset: 0x70
	public string name; //Field offset: 0x78
	public bool isRemove; //Field offset: 0x80
	public bool isSmall; //Field offset: 0x81
	public FrameImage fraImgEff; //Field offset: 0x88
	public MainObject obj; //Field offset: 0x90

	public Point() { }

	public Point(int x, int y) { }

	public void paint(mGraphics g) { }

	public void update() { }

	public void updateInMap() { }

	public void updateObj() { }

}

