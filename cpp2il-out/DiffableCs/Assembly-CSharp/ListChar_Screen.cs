//Type is in global namespace

public class ListChar_Screen : MainScreen
{
	public const sbyte SELECT_SUPPORT = 1; //Field offset: 0x0
	public static mVector vecListChar; //Field offset: 0x0
	public const sbyte SELECT_OK = 2; //Field offset: 0x0
	public const sbyte CHAR_LOCK = 2; //Field offset: 0x0
	public const sbyte CHAR_DEL = 1; //Field offset: 0x0
	public const sbyte SELECT_CHAR = 0; //Field offset: 0x0
	public static sbyte IndexCharSelected; //Field offset: 0x8
	public static short IDChar; //Field offset: 0xA
	public static bool isDelChar; //Field offset: 0xC
	private static int frameIconfocus; //Field offset: 0x10
	private static bool isNextFrame; //Field offset: 0x14
	private int selectChar; //Field offset: 0x50
	public Int32[][] mPosShow; //Field offset: 0x58
	private iCommand cmdSelect; //Field offset: 0x60
	private iCommand cmdExit; //Field offset: 0x68
	private iCommand cmdDelChar; //Field offset: 0x70
	private iCommand cmdStart; //Field offset: 0x78
	private int timeSpec; //Field offset: 0x80
	private mVector vecDelButton; //Field offset: 0x88
	private sbyte typeSelect; //Field offset: 0x90
	private Int32[] mActionFire; //Field offset: 0x98
	private Boat boat; //Field offset: 0xA0
	private int wpl; //Field offset: 0xA8
	private int hpl; //Field offset: 0xAC
	private int vySea; //Field offset: 0xB0
	private int dySea; //Field offset: 0xB4

	private static ListChar_Screen() { }

	public ListChar_Screen() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public static ListChar_Screen gI() { }

	public virtual bool keyBack() { }

	public virtual void paint(mGraphics g) { }

	public void paintFocus(mGraphics g, int x, int y) { }

	public void setCmd() { }

	public virtual void setxyPlus12() { }

	public virtual void Show() { }

	public virtual void update() { }

	private void updateDySea() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

