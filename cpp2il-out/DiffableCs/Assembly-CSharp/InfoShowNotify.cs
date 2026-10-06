//Type is in global namespace

public class InfoShowNotify
{
	public const sbyte INFO_NOR = 0; //Field offset: 0x0
	public const sbyte INFO_IMP = 1; //Field offset: 0x0
	public const sbyte INFO_SPE = 2; //Field offset: 0x0
	public const sbyte INFO_LOL_MEM = 3; //Field offset: 0x0
	public const sbyte INFO_LOL_CAPTION = 4; //Field offset: 0x0
	public const sbyte INFO_FIGHT = 5; //Field offset: 0x0
	public const sbyte INFO_PLAYER = 10; //Field offset: 0x0
	public string strShow; //Field offset: 0x10
	public bool isRemove; //Field offset: 0x18
	public bool isPaint; //Field offset: 0x19
	public short iconClan; //Field offset: 0x1A
	public mFont fontpaint; //Field offset: 0x20
	public int time; //Field offset: 0x28
	public int x; //Field offset: 0x2C
	public int y; //Field offset: 0x30
	public int w; //Field offset: 0x34
	public int speed; //Field offset: 0x38
	public int maxtime; //Field offset: 0x3C
	public sbyte type; //Field offset: 0x40

	public InfoShowNotify(string str, sbyte type) { }

	public void paintQuickChat(mGraphics g, int x, int y) { }

	public void setFont(mFont f) { }

	public void setValue(mFont f) { }

	public void update() { }

}

