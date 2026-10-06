//Type is in global namespace

public class Sudo_Info : ChatDetail
{
	public static Sudo_Info instance; //Field offset: 0x0
	private static mFont fontpaint; //Field offset: 0x8
	private static mFont fontInfo; //Field offset: 0x10
	public static mVector vecInfoCanhan; //Field offset: 0x18
	private Int32[] posValueName; //Field offset: 0xC0
	public MainSudo clan; //Field offset: 0xC8
	public String[] strInfo; //Field offset: 0xD0
	public iCommand cmdStatus; //Field offset: 0xD8
	public iCommand cmdAttri; //Field offset: 0xE0
	public iCommand cmdLevelUp; //Field offset: 0xE8
	private int indexFocusAtt; //Field offset: 0xF0
	private InputDialog input; //Field offset: 0xF8
	public short exp; //Field offset: 0x100
	private int hplus; //Field offset: 0x104
	private int lastTick; //Field offset: 0x108
	private int framepaint; //Field offset: 0x10C
	private Int32[] hCam; //Field offset: 0x110

	private static Sudo_Info() { }

	public Sudo_Info(string name, sbyte type, MainSudo clan) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void getmStrInfo(string str, int w) { }

	public virtual void paint(mGraphics g) { }

	public void paintCaNhan(mGraphics g) { }

	private void setCmd() { }

	public void setHplus() { }

	public virtual void setPos(int xBe, int yBe, int wCon, int hCon, int miniItem, int hchat) { }

	private void setXCam() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

