//Type is in global namespace

public class TabEquip : MainTab
{
	public static int maxEquip; //Field offset: 0x0
	public static Int32[][] mposEquip; //Field offset: 0x8
	private int hCur3; //Field offset: 0x88
	private int wCur5; //Field offset: 0x8C
	private int maxInfo; //Field offset: 0x90
	private int maxNumItem; //Field offset: 0x94
	private int maxCol; //Field offset: 0x98
	private int yE; //Field offset: 0x9C
	private int xE; //Field offset: 0xA0
	private int xIn; //Field offset: 0xA4
	private int yIn; //Field offset: 0xA8
	private int hTextCur; //Field offset: 0xAC
	private int yplus; //Field offset: 0xB0
	private MainItem itemCur; //Field offset: 0xB8
	private iCommand cmdChangeWear; //Field offset: 0xC0
	private iCommand cmdSetUniform; //Field offset: 0xC8
	private iCommand cmdDelUniform; //Field offset: 0xD0
	private int hTextTicket; //Field offset: 0xD8
	private int hsaiso; //Field offset: 0xDC
	public SByte[] valueEquip; //Field offset: 0xE0

	private static TabEquip() { }

	public TabEquip(string name) { }

	public virtual void beginFocus() { }

	public virtual void commandPointer(int index, int subIndex) { }

	private mVector getListItem() { }

	public virtual void paint(mGraphics g) { }

	public virtual void setPosInfo() { }

	public virtual void update() { }

	public virtual void updateInfo() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

