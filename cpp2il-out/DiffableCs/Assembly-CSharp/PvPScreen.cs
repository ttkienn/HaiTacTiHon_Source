//Type is in global namespace

public class PvPScreen : MainScreen
{
	public const sbyte PVP_OPEN = 0; //Field offset: 0x0
	public const sbyte PVP_ERROR = 6; //Field offset: 0x0
	public const sbyte PVP_CANCLE = 5; //Field offset: 0x0
	public const sbyte PVP_READY = 4; //Field offset: 0x0
	public const sbyte PVP_FIND_OK = 3; //Field offset: 0x0
	public const sbyte PVP_FIND_CANCLE = 2; //Field offset: 0x0
	public const sbyte PVP_FIND = 1; //Field offset: 0x0
	public static PvPScreen instance; //Field offset: 0x0
	public int w; //Field offset: 0x50
	public int h; //Field offset: 0x54
	public int x; //Field offset: 0x58
	public int y; //Field offset: 0x5C
	public int yPaintChar; //Field offset: 0x60
	public int idCommand; //Field offset: 0x64
	public int xMoveEff; //Field offset: 0x68
	public int vxMoveEff; //Field offset: 0x6C
	public MainObject objPvP; //Field offset: 0x70
	public String[] mstrShow; //Field offset: 0x78
	public iCommand cmdFind; //Field offset: 0x80
	public iCommand cmdCancle; //Field offset: 0x88
	public iCommand cmdReady; //Field offset: 0x90
	public iCommand cmdFindCancle; //Field offset: 0x98
	public mVector vecCmd; //Field offset: 0xA0
	public bool isMeReady; //Field offset: 0xA8
	public bool isOtherReady; //Field offset: 0xA9
	public bool isfind; //Field offset: 0xAA
	private long timeBeginReady; //Field offset: 0xB0
	public short timeReady; //Field offset: 0xB8
	public short numPlayerWait; //Field offset: 0xBA

	public PvPScreen() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void setAction(sbyte action) { }

	public void setCharClass(sbyte clazz) { }

	public void setMStr(string str) { }

	public void setObjPvp(MainObject obj) { }

	public void setPosCmd() { }

	public virtual void setxyPlus12() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

