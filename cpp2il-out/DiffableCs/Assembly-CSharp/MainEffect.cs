//Type is in global namespace

public class MainEffect
{
	public const sbyte EFFECT_SKILL = 0; //Field offset: 0x0
	public const sbyte EFFECT_OUT = 2; //Field offset: 0x0
	public const sbyte EFFECT_NUM = 1; //Field offset: 0x0
	public int typeEffect; //Field offset: 0x10
	public int valueEffect; //Field offset: 0x14
	public int fRemove; //Field offset: 0x18
	public int x; //Field offset: 0x1C
	public int y; //Field offset: 0x20
	public int toX; //Field offset: 0x24
	public int toY; //Field offset: 0x28
	public int f; //Field offset: 0x2C
	public int frame; //Field offset: 0x30
	public int ysai; //Field offset: 0x34
	public int vMax; //Field offset: 0x38
	public int vx; //Field offset: 0x3C
	public int vy; //Field offset: 0x40
	public int hOne; //Field offset: 0x44
	public int timeAddNum; //Field offset: 0x48
	public int x1000; //Field offset: 0x4C
	public int y1000; //Field offset: 0x50
	public int step; //Field offset: 0x54
	public int am_duong; //Field offset: 0x58
	public int CFrame; //Field offset: 0x5C
	public int fImg; //Field offset: 0x60
	public int fSub; //Field offset: 0x64
	public int fSub2; //Field offset: 0x68
	public int fSub3; //Field offset: 0x6C
	public int indexImg; //Field offset: 0x70
	public int indexSub; //Field offset: 0x74
	public int indexSub2; //Field offset: 0x78
	public int indexSub3; //Field offset: 0x7C
	public sbyte frameSuper; //Field offset: 0x80
	public int xplus; //Field offset: 0x84
	public int yplus; //Field offset: 0x88
	public short timeEnd; //Field offset: 0x8C
	public sbyte Dir; //Field offset: 0x8E
	public int levelPaint; //Field offset: 0x90
	public int indexEff_1; //Field offset: 0x94
	public long timeBegin; //Field offset: 0x98
	public Int32[] mframe; //Field offset: 0xA0
	public Int32[] mframeSub; //Field offset: 0xA8
	public bool isRemove; //Field offset: 0xB0
	public bool isStop; //Field offset: 0xB1
	public bool isAddHP; //Field offset: 0xB2
	public FrameImage fraImgEff; //Field offset: 0xB8
	public FrameImage fraImgSubEff; //Field offset: 0xC0
	public FrameImage fraImgSub2Eff; //Field offset: 0xC8
	public FrameImage fraImgSub3Eff; //Field offset: 0xD0
	public FrameImage fraImgSub4Eff; //Field offset: 0xD8
	public bool isPauseImgEff; //Field offset: 0xE0
	public bool isPauseSubEff; //Field offset: 0xE1
	public bool isPauseSub2Eff; //Field offset: 0xE2
	public bool isPauseSub3Eff; //Field offset: 0xE3
	public long timeStartPauseImgEff; //Field offset: 0xE8
	public long timeStartPauseSubEff; //Field offset: 0xF0
	public long timeStartPauseSub2Eff; //Field offset: 0xF8
	public long timeStartPauseSub3Eff; //Field offset: 0x100
	public MainObject objFireMain; //Field offset: 0x108
	public MainObject objMainEff; //Field offset: 0x110
	public bool isEff; //Field offset: 0x118
	public sbyte numNextFrame; //Field offset: 0x119
	public Point PointSpeed; //Field offset: 0x120
	public mVector vecObjsBeFire; //Field offset: 0x128
	public int life; //Field offset: 0x130
	public int goc_Arc; //Field offset: 0x134
	public int vx1000; //Field offset: 0x138
	public int vy1000; //Field offset: 0x13C
	public int va; //Field offset: 0x140
	private Int32[] mImageBullet; //Field offset: 0x148
	private Int32[] mXoayBullet; //Field offset: 0x150
	private Int32[] mpaintone_Bullet; //Field offset: 0x158

	public MainEffect() { }

	public Point_Focus create_Speed(int xdich, int ydich, Point_Focus p, int x, int y, int toX, int toY) { }

	public Point_Focus create_Speed(int xdich, int ydich, Point_Focus p) { }

	public override bool CreateEffectSkill() { }

	public static bool isInScreen(int x, int y, int w, int h) { }

	public override void paint(mGraphics g) { }

	public override void paint(mGraphics g, int x, int y) { }

	public void paint_Bullet(mGraphics g, FrameImage frm, int index, int x, int y, bool isMore, int fbegin) { }

	public override void removeEff() { }

	public override void replaceHP(mVector vec) { }

	public void setAngle() { }

	public void setAva(int level, MainObject obj) { }

	public void setDy(int value, MainObject obj) { }

	public int setFrameAngle(int goc) { }

	public void setInfoNormal(MainObject objset) { }

	public void setInfoNormalPhaoHoa(MainObject objset) { }

	public void setPosition(int x, int y, int xto, int yto) { }

	public override void stopUpdateNormal() { }

	public override void update() { }

	public bool updateAngleNormal(MainObject objset, int hPlus) { }

}

