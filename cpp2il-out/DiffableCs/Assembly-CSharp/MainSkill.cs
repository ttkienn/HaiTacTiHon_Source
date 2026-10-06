//Type is in global namespace

public class MainSkill
{
	public const sbyte BUFF_NULL = 0; //Field offset: 0x0
	public const sbyte BUFF_PLASH = 4; //Field offset: 0x0
	public const sbyte BUFF_SHOW = 3; //Field offset: 0x0
	public static Int16[] mRangeSkill; //Field offset: 0x0
	public const sbyte BUFF_NOR = 1; //Field offset: 0x0
	public const sbyte BUFF_SPEC = 2; //Field offset: 0x0
	public short typeEffSkill; //Field offset: 0x10
	public short indexHotKey; //Field offset: 0x12
	public short idIcon; //Field offset: 0x14
	public short ID; //Field offset: 0x16
	public short typeEffBuff; //Field offset: 0x18
	public short timebuff; //Field offset: 0x1A
	public short typeDevil; //Field offset: 0x1C
	public int timeDelay; //Field offset: 0x20
	public int x; //Field offset: 0x24
	public int y; //Field offset: 0x28
	public long timeBegin; //Field offset: 0x30
	public mVector vecPos; //Field offset: 0x38
	public sbyte typeSub; //Field offset: 0x40
	public sbyte typeBuff; //Field offset: 0x41
	public sbyte Dirbuff; //Field offset: 0x42
	public sbyte lvDevil; //Field offset: 0x43
	public bool isBuff; //Field offset: 0x44
	public bool isBuffSpecNew; //Field offset: 0x45
	public int range; //Field offset: 0x48
	public int mana; //Field offset: 0x4C

	private static MainSkill() { }

	public MainSkill(short ID, short typeEff) { }

	public void getData() { }

	public void paint(mGraphics g, int x, int y, sbyte lvDevil) { }

	public void setPos(int x, int y, mVector vec, sbyte dir) { }

	public void setTypeBuff(sbyte isBuff, short buff, short timebuff) { }

}

