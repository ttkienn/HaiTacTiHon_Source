//Type is in global namespace

public class MsgArea : MsgDialog
{
	public const sbyte TYPE_AREA = 0; //Field offset: 0x0
	public const sbyte TYPE_PAGE_MARKET = 1; //Field offset: 0x0
	private SByte[] mStatus; //Field offset: 0x138
	private int maxItemW; //Field offset: 0x140
	private int hItem; //Field offset: 0x144
	private int sizeButton; //Field offset: 0x148
	private int sizeBanner; //Field offset: 0x14C
	private iCommand cmdSelect; //Field offset: 0x150
	private sbyte typePaintArea; //Field offset: 0x158
	public int timePaintfocus; //Field offset: 0x15C

	public MsgArea() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void setinfoChangeArea(SByte[] mstatus, sbyte type) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

