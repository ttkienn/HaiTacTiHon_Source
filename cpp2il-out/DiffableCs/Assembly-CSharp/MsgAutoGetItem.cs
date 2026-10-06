//Type is in global namespace

public class MsgAutoGetItem : MsgDialog
{
	public static Int32[] mValue; //Field offset: 0x0
	private Int32[][] mAuto; //Field offset: 0x138
	private int hItem; //Field offset: 0x140

	private static MsgAutoGetItem() { }

	public MsgAutoGetItem() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void paintSelect(mGraphics g, int xbegin, int ybegin, int wFocus) { }

	public void setinfoAuto_Get_Item() { }

	public void setSelect(int value) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

