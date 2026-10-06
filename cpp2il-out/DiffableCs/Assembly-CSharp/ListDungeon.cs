//Type is in global namespace

public class ListDungeon : PaintListScreen
{
	public static mVector vecDungeon; //Field offset: 0x0
	public static bool isKey; //Field offset: 0x8
	public static ListDungeon instance; //Field offset: 0x10
	private iCommand cmdReady; //Field offset: 0x100
	private iCommand cmdCancle; //Field offset: 0x108

	private static ListDungeon() { }

	public ListDungeon(sbyte type, mVector vec, string name) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paintInfo(mGraphics g, InfoMemList mem, int xpaint, int ypaint, int i, int wsub) { }

}

