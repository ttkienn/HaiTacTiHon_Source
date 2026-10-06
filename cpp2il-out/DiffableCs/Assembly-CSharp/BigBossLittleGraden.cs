//Type is in global namespace

public class BigBossLittleGraden
{
	public const sbyte ACTION_BIG_BOSS_DIE = 3; //Field offset: 0x0
	public const sbyte ACTION_BIG_BOSS_AVA = 2; //Field offset: 0x0
	public const sbyte ACTION_BIG_BOSS_FIRE = 1; //Field offset: 0x0
	public const sbyte ACTION_BIG_BOSS_STAND = 0; //Field offset: 0x0
	public int type; //Field offset: 0x10
	public int x; //Field offset: 0x14
	public int y; //Field offset: 0x18
	public int yEff; //Field offset: 0x1C
	public int indexAction; //Field offset: 0x20
	public int vyEff; //Field offset: 0x24
	public int vxFire; //Field offset: 0x28
	public int vxAva; //Field offset: 0x2C
	public int f; //Field offset: 0x30
	public int wNameFocus; //Field offset: 0x34
	public int yInfo; //Field offset: 0x38
	public int vyDie; //Field offset: 0x3C
	public int yDie; //Field offset: 0x40
	public int action; //Field offset: 0x44
	public int hp; //Field offset: 0x48
	public int MaxHP; //Field offset: 0x4C
	public int mp; //Field offset: 0x50
	public int MaxMP; //Field offset: 0x54
	public int dam; //Field offset: 0x58
	public string name; //Field offset: 0x60
	private mVector vecEff; //Field offset: 0x68
	private Int32[][][] mPlayFrame; //Field offset: 0x70

	public BigBossLittleGraden(sbyte type) { }

	public void addEffFire(BigBossLittleGraden obj) { }

	public void paint(mGraphics g, int xCam) { }

	public void paintINFO(mGraphics g) { }

	public void setActionBigBoss(sbyte action) { }

	public void update() { }

}

