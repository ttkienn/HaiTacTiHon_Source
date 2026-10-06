//Type is in global namespace

public class PlayerListServer : PaintListScreen
{
	public static PlayerListServer instance; //Field offset: 0x0
	private iCommand cmdNext; //Field offset: 0x100
	private iCommand cmdPre; //Field offset: 0x108
	private iCommand cmdUpdateBlackList; //Field offset: 0x110
	private iCommand cmdPosFightClan; //Field offset: 0x118
	private iCommand cmdSendListMem; //Field offset: 0x120
	private sbyte page; //Field offset: 0x128
	private int lastTick; //Field offset: 0x12C
	private int framepaint; //Field offset: 0x130

	public PlayerListServer(sbyte type, mVector vec, string name, sbyte page) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void doMenu() { }

	public virtual void doMenuTouchPlayer() { }

	private void getMenuSetPos() { }

	public virtual void paintBg(mGraphics g) { }

	private void paintIconTop(mGraphics g, InfoMemList mem, int x, int y) { }

	public virtual void paintInfo(mGraphics g, InfoMemList mem, int xpaint, int ypaint, int i, int wsub) { }

	public virtual void paintSelect(mGraphics g, int xbegin, int ybegin, int wFocus) { }

	public static bool typeClan(sbyte type) { }

}

