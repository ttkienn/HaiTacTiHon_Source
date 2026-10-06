//Type is in global namespace

public class MainHelp : AvMain
{
	public const sbyte CHANGE_HOT_KEY = 5; //Field offset: 0x0
	public const sbyte GET_ITEM = 8; //Field offset: 0x0
	public const sbyte NEXT_FOCUS = 4; //Field offset: 0x0
	public const sbyte MOVE = 3; //Field offset: 0x0
	public const sbyte HOT_KEY = 2; //Field offset: 0x0
	public const sbyte MP_HP = 1; //Field offset: 0x0
	public const sbyte HELLO_1 = 0; //Field offset: 0x0
	public const sbyte INVENTORY = 9; //Field offset: 0x0
	public const sbyte NEXT_INVENTORY = 10; //Field offset: 0x0
	public const sbyte EQUIP = 11; //Field offset: 0x0
	public const sbyte INFO = 12; //Field offset: 0x0
	public const sbyte LV_UP = 13; //Field offset: 0x0
	public const sbyte QUEST = 14; //Field offset: 0x0
	public const sbyte SKILL = 15; //Field offset: 0x0
	public const sbyte SETTING = 16; //Field offset: 0x0
	public const sbyte END = 17; //Field offset: 0x0
	public const sbyte BEGINNEW = 18; //Field offset: 0x0
	public const sbyte BUY_SELL = 19; //Field offset: 0x0
	public const sbyte UPGRADE = 20; //Field offset: 0x0
	public const sbyte BOSS = 21; //Field offset: 0x0
	public const sbyte CHAT = 6; //Field offset: 0x0
	public const sbyte EVENT_M = 7; //Field offset: 0x0
	private int x; //Field offset: 0x40
	private int y; //Field offset: 0x44
	private int w; //Field offset: 0x48
	private int h; //Field offset: 0x4C
	private int type; //Field offset: 0x50
	private int typeSub; //Field offset: 0x54
	private int xbegin; //Field offset: 0x58
	private int ybegin; //Field offset: 0x5C
	private int archor; //Field offset: 0x60
	private string str; //Field offset: 0x68
	private String[] strShow; //Field offset: 0x70
	public bool isBreak; //Field offset: 0x78
	public bool isRemove; //Field offset: 0x79
	public bool isInMap; //Field offset: 0x7A
	private iCommand cmd; //Field offset: 0x80
	private mFont fontPaint; //Field offset: 0x88
	private Point_Focus p; //Field offset: 0x90
	private RunWord runText; //Field offset: 0x98

	public MainHelp(int type, int typeSub) { }

	public static bool checkIndexHelp(int typeCheck) { }

	public static void checkRemoveIndexHelp(int typeCheck) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void createPoint(int x, int y, int ar) { }

	public virtual void paint(mGraphics g) { }

	public void setActionHelp() { }

	private void setHotKey() { }

	private void setMove() { }

	public static void setNextHelp(bool isHanhTrang) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

