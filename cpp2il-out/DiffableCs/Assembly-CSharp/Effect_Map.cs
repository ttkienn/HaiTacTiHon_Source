//Type is in global namespace

public class Effect_Map
{
	public const sbyte SNOW = 1; //Field offset: 0x0
	public static SByte[][] frameLeaf; //Field offset: 0x0
	public const sbyte DARK = 9; //Field offset: 0x0
	public const sbyte RAIN_THUNDER = 8; //Field offset: 0x0
	public const sbyte DAO = 7; //Field offset: 0x0
	public const sbyte PHAO = 6; //Field offset: 0x0
	public const sbyte MAI = 5; //Field offset: 0x0
	public const sbyte SEA = 4; //Field offset: 0x0
	public const sbyte RAIN = 3; //Field offset: 0x0
	public const sbyte FLOWER = 2; //Field offset: 0x0
	public const sbyte GREEN_LEAF = 0; //Field offset: 0x0
	private mVector vecEff; //Field offset: 0x10
	private mVector vecEffSub; //Field offset: 0x18
	public sbyte type; //Field offset: 0x20
	public sbyte level; //Field offset: 0x21
	public sbyte hRain; //Field offset: 0x22
	private int swingXSpeed; //Field offset: 0x24
	private int YSpped; //Field offset: 0x28
	private int timeSpeed; //Field offset: 0x2C
	private int time; //Field offset: 0x30
	private int numNextFrame; //Field offset: 0x34
	private FrameImage fraImg; //Field offset: 0x38
	private FrameImage fraImgSub; //Field offset: 0x40
	private int Plus; //Field offset: 0x48

	private static Effect_Map() { }

	public Effect_Map(sbyte type, sbyte level) { }

	public void createSea(int x, int y) { }

	public void paintLast(mGraphics g) { }

	public void paintSea(mGraphics g) { }

	public void randomSpeed() { }

	public Point resetPos(Point p) { }

	public Point setCreate(Point p) { }

	public void setPos() { }

	public void update() { }

	public void updateSea() { }

}

