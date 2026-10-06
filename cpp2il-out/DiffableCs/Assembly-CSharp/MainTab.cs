//Type is in global namespace

public class MainTab : AvMain
{
	public const sbyte PAPER_MARKET = 1; //Field offset: 0x0
	public const sbyte PAPER_NORMAL = 0; //Field offset: 0x0
	public static int wItem; //Field offset: 0x0
	public static int xTab; //Field offset: 0x4
	public static int wTab; //Field offset: 0x8
	public static int hTab; //Field offset: 0xC
	public static int yTab; //Field offset: 0x10
	public static int hItemTab; //Field offset: 0x14
	public static int bigInfo; //Field offset: 0x18
	public static int maxTypeTab; //Field offset: 0x1C
	public static sbyte limitTimeShow; //Field offset: 0x20
	public static int xMoney; //Field offset: 0x24
	public static int yMoney; //Field offset: 0x28
	public static mImage[] mImgTab; //Field offset: 0x30
	public static FrameImage fraCloseTab; //Field offset: 0x38
	public static FrameImage fraCloseTab2; //Field offset: 0x40
	public static FrameImage fraCmdMo; //Field offset: 0x48
	public static FrameImage fraCloseTab3; //Field offset: 0x50
	public static CountDownTicket CDTicket; //Field offset: 0x58
	public static CountDownTicket CDPvP; //Field offset: 0x60
	public static CountDownTicket CDKeyBoss; //Field offset: 0x68
	public static CountDownTicket CDx2XP; //Field offset: 0x70
	public static CountDownTicket CDDonateClan; //Field offset: 0x78
	public static int xRun; //Field offset: 0x80
	public static int timeRun; //Field offset: 0x84
	public static int COLOR_BORDER; //Field offset: 0x88
	public static int COLOR_NEN; //Field offset: 0x8C
	public static int timenhapnhay; //Field offset: 0x90
	public static int valuephantram; //Field offset: 0x94
	public string nameTab; //Field offset: 0x40
	public int IdSelect; //Field offset: 0x48
	public sbyte indexIconTab; //Field offset: 0x4C
	public int maxSize; //Field offset: 0x50
	public int wInfo; //Field offset: 0x54
	public int hInfo; //Field offset: 0x58
	public int xInfo; //Field offset: 0x5C
	public int yInfo; //Field offset: 0x60
	public int wItemCur; //Field offset: 0x64
	public int xCurBegin; //Field offset: 0x68
	public int yCurBegin; //Field offset: 0x6C
	public int wCur; //Field offset: 0x70
	public int hCur; //Field offset: 0x74
	public int miniItem; //Field offset: 0x78
	public int levelTab; //Field offset: 0x7C
	public sbyte indexMarket; //Field offset: 0x80
	public bool isShowInfo; //Field offset: 0x81
	public bool isBigScreen; //Field offset: 0x82
	public sbyte timeShowInfo; //Field offset: 0x83

	private static MainTab() { }

	public MainTab() { }

	public override void beginFocus() { }

	public void createValue() { }

	public void endFocusInfo() { }

	public override void paint(mGraphics g, int xbegin) { }

	public virtual void paint(mGraphics g) { }

	public static void paintBgTab(mGraphics g, int xpaint, bool isClan, sbyte typePaper) { }

	private static void paintInfo_Money_Player(mGraphics g, bool isClan) { }

	public static void paintInfoEveryWhere(mGraphics g, MainItem itemCur, mVector infoSS, sbyte typeborder, int x, int y, int w, int h, bool isLv, MainObject obj, int lvUpPlus) { }

	public static void paintListTab(mGraphics g, int xpaint, mVector vec, int idSelect) { }

	public static void paintMoney(mGraphics g, int x, int y) { }

	public static void paintMoney(mGraphics g, int x, int y, bool isClan) { }

	public static void paintPaperTab(mGraphics g, int x, int y, int w, int h) { }

	public override void resize(int max) { }

	public override iCommand setCmdEndInfo() { }

	public override void setData(mVector vec) { }

	public override void setPosInfo() { }

	public override void setPosInfo(MainItem item, int xbe, int ybe) { }

	public void setWHin() { }

	public void ShowInfo(mGraphics g, MainItem itemCur, mVector infoSS, sbyte typeborder, int x, int y, bool isLv, MainObject obj, int lvUpPlus) { }

	public virtual void update() { }

	public override void updateBuyItem(short id, sbyte type) { }

	public override void updateChangeTabInfo() { }

	public override void updateInfo() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

	public override void updateShowInfo() { }

	public static void updateTimeCountDownTicket() { }

	public override void updateTrangBi() { }

}

