//Type is in global namespace

public class QuickMenu : Menu
{
	public static QuickMenu instance; //Field offset: 0x0
	public static FrameImage[] fraQuickMenu; //Field offset: 0x8
	public static mImage imgNenMenu; //Field offset: 0x10
	public static mImage imgTamGiac; //Field offset: 0x18
	public static Int32[][] mValueCmd; //Field offset: 0x20
	private ListNew list; //Field offset: 0x110
	private bool isClose; //Field offset: 0x118
	private int speed; //Field offset: 0x11C
	private int xEff; //Field offset: 0x120
	private Int32[] color; //Field offset: 0x128

	private static QuickMenu() { }

	public QuickMenu() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public string getTextCmd(int index) { }

	public static QuickMenu gI() { }

	public virtual void paintMenu(mGraphics g) { }

	public void startAt() { }

	public virtual void updateMenu() { }

	public virtual void updateMenuKey() { }

	public virtual void updatePointer() { }

}

