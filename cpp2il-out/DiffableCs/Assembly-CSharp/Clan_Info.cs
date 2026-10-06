//Type is in global namespace

public class Clan_Info : ChatDetail
{
	private static mFont fontpaint; //Field offset: 0x0
	private static mFont fontInfo; //Field offset: 0x8
	private Int32[] posValueName; //Field offset: 0xC0
	public MainClan clan; //Field offset: 0xC8
	public String[] strInfo; //Field offset: 0xD0
	public iCommand cmdStatus; //Field offset: 0xD8
	public iCommand cmdAttri; //Field offset: 0xE0
	public iCommand cmdLevelUp; //Field offset: 0xE8
	private int indexFocusAtt; //Field offset: 0xF0
	private InputDialog input; //Field offset: 0xF8
	private int hplus; //Field offset: 0x100
	private int lastTick; //Field offset: 0x104
	private int framepaint; //Field offset: 0x108
	private Int32[] hCam; //Field offset: 0x110

	public Clan_Info(string name, sbyte type, MainClan clan) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void getmStrInfo(string str, int w) { }

	public virtual void paint(mGraphics g) { }

	private void setCmd() { }

	public virtual void setPos(int xBe, int yBe, int wCon, int hCon, int miniItem, int hchat) { }

	private void setXCam() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

