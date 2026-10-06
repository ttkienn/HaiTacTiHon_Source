//Type is in global namespace

public class MainEvent : PaintListScreen
{
	public static iCommand cmdFight; //Field offset: 0x0
	public static FrameImage fraEvent; //Field offset: 0x8
	public static mImage imgNew; //Field offset: 0x10
	public static int wShort; //Field offset: 0x18
	public static int hShort; //Field offset: 0x1C
	public iCommand cmdSetEvent; //Field offset: 0x100
	public iCommand cmdAddfriend; //Field offset: 0x108
	public iCommand cmdAddParty; //Field offset: 0x110
	public iCommand cmdDelEvent; //Field offset: 0x118
	public iCommand cmdTrade; //Field offset: 0x120
	public iCommand cmdAcceptAddParty; //Field offset: 0x128
	public iCommand cmdInfoEnemy; //Field offset: 0x130
	public iCommand cmdTroChuyen; //Field offset: 0x138
	public iCommand cmdAcceptClan; //Field offset: 0x140
	public iCommand cmdAcceptFightClan; //Field offset: 0x148
	public iCommand cmdCancelFightClan; //Field offset: 0x150
	public iCommand cmdAcceptSudo; //Field offset: 0x158

	private static MainEvent() { }

	public MainEvent(sbyte type, mVector vec) { }

	public virtual void beginShow() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void delMem(InfoMemList mem) { }

	public virtual void doMenu() { }

	public virtual void doMenuTouchPlayer() { }

	public virtual void paintInfo(mGraphics g, InfoMemList mem, int xpaint, int ypaint, int i, int wsub) { }

	public void paintLine(mGraphics g, int xpaint, int ypaint, int wsub) { }

	public static void paintShort(mGraphics g, int x, int y, InfoMemList mem) { }

	public void setMemCur(InfoMemList mem) { }

}

