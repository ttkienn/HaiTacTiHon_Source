//Type is in global namespace

public class EffectNum : MainEffect
{
	public const sbyte COLOR_NORMAL = 0; //Field offset: 0x0
	public const sbyte COLOR_HAP_THU = 25; //Field offset: 0x0
	public const sbyte COLOR_XP_SKILL = 24; //Field offset: 0x0
	public const sbyte COLOR_SUPER_BIG_CRI = 23; //Field offset: 0x0
	public const sbyte COLOR_BIG_NUMBER_SMALL_EFF_B = 22; //Field offset: 0x0
	public const sbyte COLOR_BIG_NUMBER_SMALL_EFF_R = 21; //Field offset: 0x0
	public const sbyte COLOR_BIG_NUMBER_SMALL_V = 19; //Field offset: 0x0
	public const sbyte COLOR_WANTED = 18; //Field offset: 0x0
	public const sbyte COLOR_BIG_MISS = 17; //Field offset: 0x0
	public const sbyte COLOR_BIG_CRI = 16; //Field offset: 0x0
	public const sbyte COLOR_BIG_NUMBER_SMALL_W = 15; //Field offset: 0x0
	public const sbyte COLOR_BIG_NUMBER_SMALL_R = 14; //Field offset: 0x0
	public const sbyte COLOR_BIG_NUMBER_SMALL_G = 20; //Field offset: 0x0
	public const sbyte COLOR_FIRE_RED = 11; //Field offset: 0x0
	public const sbyte COLOR_BIG_NUMBER_SMALL_Y = 13; //Field offset: 0x0
	public const sbyte COLOR_XP = 1; //Field offset: 0x0
	public const sbyte COLOR_FIRE = 2; //Field offset: 0x0
	public const sbyte COLOR_PLUS_HP = 3; //Field offset: 0x0
	public const sbyte COLOR_PLUS_MP = 4; //Field offset: 0x0
	public const sbyte COLOR_PUT_ITEM = 5; //Field offset: 0x0
	public static int numPaintDam; //Field offset: 0x0
	public const sbyte COLOR_FIRE_PERSON = 6; //Field offset: 0x0
	public const sbyte COLOR_EFF_CRI = 7; //Field offset: 0x0
	public const sbyte COLOR_OPTION = 8; //Field offset: 0x0
	public const sbyte COLOR_EFF_MON_FIRE = 9; //Field offset: 0x0
	public const sbyte COLOR_EFF_BELI = 10; //Field offset: 0x0
	private string strContent; //Field offset: 0x160
	private int typeNum; //Field offset: 0x168
	private int tick; //Field offset: 0x16C
	private int valueNum; //Field offset: 0x170
	private int valueAP; //Field offset: 0x174
	private int timeStop; //Field offset: 0x178
	private int tickStop; //Field offset: 0x17C
	private int xlechAP; //Field offset: 0x180
	private int valuePaintDam; //Field offset: 0x184
	private int tickSuperDam; //Field offset: 0x188
	private int stepSuperDam; //Field offset: 0x18C
	private mFont fontPaint; //Field offset: 0x190
	private bool isGravity; //Field offset: 0x198
	private bool isTrieuDam; //Field offset: 0x199

	public EffectNum(string strContent, int x, int y, int typeColor) { }

	public EffectNum(string strContent, int x, int y, int typeColor, FrameImage fra, int frame) { }

	public EffectNum(int value, int valueAP, int x, int y, int typeColor) { }

	public void createEffNum(int value, int valueAP, int x, int y, int typeColor) { }

	public void createEffNum(string strContent, int x, int y, int typeColor) { }

	public virtual void paint(mGraphics g) { }

	public virtual void update() { }

}

