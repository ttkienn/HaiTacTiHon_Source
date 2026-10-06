//Type is in global namespace

public class TabInfo : MainTab
{
	public const int LEVEL_TIEMNANG = 1; //Field offset: 0x0
	public const int LEVEL_THONGTIN = 0; //Field offset: 0x0
	public static bool isshow; //Field offset: 0x0
	private iCommand cmdSetPoint; //Field offset: 0x88
	private InputDialog input; //Field offset: 0x90
	private ListNew listInfo; //Field offset: 0x98
	private ListNew listAttri; //Field offset: 0xA0
	private int lastCam; //Field offset: 0xA8
	private int xBeginInfo; //Field offset: 0xAC
	private Scroll scrInfo; //Field offset: 0xB0
	private Scroll scrAttri; //Field offset: 0xB8
	private int xto; //Field offset: 0xC0
	private int xcur; //Field offset: 0xC4
	private int speed; //Field offset: 0xC8
	private int hItem; //Field offset: 0xCC
	private int timefocus; //Field offset: 0xD0
	private Int32[] mNumAttri; //Field offset: 0xD8

	private static TabInfo() { }

	public TabInfo(string name) { }

	public virtual void beginFocus() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void initCmd() { }

	public virtual void paint(mGraphics g) { }

	public void paintAttPlusBuff(mGraphics g, string text, int id, int y) { }

	public void paintSelect(mGraphics g) { }

	public void paintThongTin(mGraphics g) { }

	public void paintTiemNang(mGraphics g) { }

	public virtual void update() { }

	public virtual void updateChangeTabInfo() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

	public static void updateTabAttri(Main_Attribute[] att) { }

}

