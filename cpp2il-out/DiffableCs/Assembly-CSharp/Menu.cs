//Type is in global namespace

public class Menu : AvMain
{
	public const sbyte NPC_MENU = 1; //Field offset: 0x0
	public const sbyte NORMAL = 0; //Field offset: 0x0
	public static bool isPaint; //Field offset: 0x0
	public const sbyte QUICK_MENU = 2; //Field offset: 0x0
	public static bool isLoadData; //Field offset: 0x1
	public static sbyte isNPCMenu; //Field offset: 0x2
	public static MainObject objSelect; //Field offset: 0x8
	public static int IdNPCLast; //Field offset: 0x10
	public bool isShowMenu; //Field offset: 0x40
	public mVector menuItems; //Field offset: 0x48
	public int menuSelectedItem; //Field offset: 0x50
	public int SelectFocus; //Field offset: 0x54
	public int menuX; //Field offset: 0x58
	public int menuY; //Field offset: 0x5C
	public int menuW; //Field offset: 0x60
	public int menuH; //Field offset: 0x64
	public int menuTemY; //Field offset: 0x68
	public int hPlus; //Field offset: 0x6C
	public int cmtoX; //Field offset: 0x70
	public int cmx; //Field offset: 0x74
	public int cmdy; //Field offset: 0x78
	public int cmvy; //Field offset: 0x7C
	public int cmxLim; //Field offset: 0x80
	public int xc; //Field offset: 0x84
	public int pos; //Field offset: 0x88
	public int sizeMenu; //Field offset: 0x8C
	private string nameMenu; //Field offset: 0x90
	private String[] mStrTalk; //Field offset: 0x98
	public RunWord runText; //Field offset: 0xA0
	public sbyte timeShowSelect; //Field offset: 0xA8
	public iCommand cmdClose; //Field offset: 0xB0
	public int IdMenu; //Field offset: 0xB8
	public int IdNpc; //Field offset: 0xBC
	private sbyte typeO; //Field offset: 0xC0
	private sbyte timeShow; //Field offset: 0xC1
	private int hShow; //Field offset: 0xC4
	private int maxShow; //Field offset: 0xC8
	private int archorRunText; //Field offset: 0xCC
	private int xBegin; //Field offset: 0xD0
	private int w2cmd; //Field offset: 0xD4
	public int wUni; //Field offset: 0xD8
	private int pointerDownTime; //Field offset: 0xDC
	private int pointerDownFirstX; //Field offset: 0xE0
	private Int32[] pointerDownLastX; //Field offset: 0xE8
	private bool pointerIsDowning; //Field offset: 0xF0
	private bool isDownWhenRunning; //Field offset: 0xF1
	private int waitToPerform; //Field offset: 0xF4
	private int cmRun; //Field offset: 0xF8
	private int valueTime; //Field offset: 0xFC
	private int cmvx; //Field offset: 0x100
	private int cmdx; //Field offset: 0x104
	private int miniItem; //Field offset: 0x108

	private static Menu() { }

	public Menu() { }

	public void beginMenu() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void doCloseMenu() { }

	public void moveCamera() { }

	private void paint_NPC_MENU(mGraphics g) { }

	public void paintLine(mGraphics g, int i) { }

	public override void paintMenu(mGraphics g) { }

	public void perform(iCommand cmd) { }

	public void resetBegin() { }

	public void setinfoDynamic(mVector menulist, int pos, int idmenu, int idnpc, string name) { }

	public void setPos() { }

	public void setPosNPC(int hBut) { }

	public void startAt(mVector menuItems, int pos, string name) { }

	public void startAt_NPC(mVector menuItems, string name, int idNPC, sbyte typeO, bool isHelp, int archor, bool isDynamic) { }

	public void startAt_NPC_Quest(mVector menuItems, string name, int idNPC, sbyte typeO, bool isQuest, int archor) { }

	public void startTabMenu(mVector menuItems) { }

	public void update_Pos_UP_DOWN() { }

	public override void updateMenu() { }

	public void updateMenuGame(mVector vec) { }

	public override void updateMenuKey() { }

	public void updatePos_LEFT_RIGHT() { }

}

