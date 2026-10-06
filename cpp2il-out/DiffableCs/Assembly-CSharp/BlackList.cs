//Type is in global namespace

public class BlackList : PaintListScreen
{
	public static BlackList instance; //Field offset: 0x0
	private iCommand cmdUpdateBlackList; //Field offset: 0x100
	private sbyte page; //Field offset: 0x108

	public BlackList(sbyte type, mVector vec, string name, sbyte page) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void doMenu() { }

	public virtual void doMenuTouchPlayer() { }

	public virtual void paintInfo(mGraphics g, InfoMemList mem, int xpaint, int ypaint, int i, int wsub) { }

}

