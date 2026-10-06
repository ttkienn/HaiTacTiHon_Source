//Type is in global namespace

public class MsgListItem : MsgDialog
{
	private mVector listItem; //Field offset: 0x138
	private MainItem itemCur; //Field offset: 0x140
	private mVector vecInfoSS; //Field offset: 0x148
	private int xInfo; //Field offset: 0x150
	private int yInfo; //Field offset: 0x154
	private int wInfo; //Field offset: 0x158
	private int hInfo; //Field offset: 0x15C
	private int dir; //Field offset: 0x160

	public MsgListItem() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void setinfoListItem(mVector vec, int x, int y, int wItem, int dir) { }

	public void setPosInfo() { }

	public void setPosInfo(MainItem item, int xbe, int ybe) { }

	public virtual void update() { }

	public void updateInfo() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

