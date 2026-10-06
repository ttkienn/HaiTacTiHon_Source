//Type is in global namespace

public class GameCanvas : MotherCanvas, IActionListener
{
	public const string VERSION = "1.2.9"; //Field offset: 0x0
	public const sbyte NEW_RIGHT = 41; //Field offset: 0x0
	public const sbyte NEW_LEFT = 40; //Field offset: 0x0
	public const sbyte OLD_RIGHT = 13; //Field offset: 0x0
	public const sbyte OLD_LEFT = 12; //Field offset: 0x0
	public const sbyte ACTION_UNI_EQUIP = 16; //Field offset: 0x0
	public const sbyte ACTION_UNI_FRIEND_LIST = 15; //Field offset: 0x0
	public const sbyte ACTION_UNI_SKILL = 14; //Field offset: 0x0
	public const sbyte ACTION_UNI_INFO = 13; //Field offset: 0x0
	public const sbyte ACTION_UNI_QUEST = 12; //Field offset: 0x0
	public const sbyte NEW_CENTER = 5; //Field offset: 0x0
	public const sbyte ACTION_UNI_INVENTORY = 11; //Field offset: 0x0
	public const sbyte ACTION_UNI_9 = 9; //Field offset: 0x0
	public const sbyte ACTION_UNI_EVENT = 8; //Field offset: 0x0
	public const sbyte ACTION_UNI_7 = 7; //Field offset: 0x0
	public const sbyte ACTION_UNI_CHANGE_SKILL = 6; //Field offset: 0x0
	public const sbyte ACTION_UNI_5 = 5; //Field offset: 0x0
	public const sbyte ACTION_UNI_QUICK_MENU = 4; //Field offset: 0x0
	public const sbyte ACTION_UNI_3 = 3; //Field offset: 0x0
	public const sbyte ACTION_UNI_NEXT_FOCUS = 2; //Field offset: 0x0
	public const sbyte ACTION_UNI_1 = 1; //Field offset: 0x0
	public const sbyte ACTION_UNI_CHAT = 10; //Field offset: 0x0
	public const sbyte ACTION_UNI_TAB_SCREEN = 0; //Field offset: 0x0
	public const int hardcodeSpeedUpFinal = 300; //Field offset: 0x0
	public const string No = "4"; //Field offset: 0x0
	public static int lv; //Field offset: 0x0
	public static sbyte Day_Night; //Field offset: 0x4
	public static sbyte language; //Field offset: 0x5
	public static bool isLocal; //Field offset: 0x6
	public static bool isDebug; //Field offset: 0x7
	public static bool lowGraphic; //Field offset: 0x8
	public static bool isSuperLowGraphic; //Field offset: 0x9
	public static GameCanvas instance; //Field offset: 0x10
	public static Boolean[] keyMyPressed; //Field offset: 0x18
	public static Boolean[] keyMyReleased; //Field offset: 0x20
	public static Boolean[] keyMyHold; //Field offset: 0x28
	public static bool isMoto; //Field offset: 0x30
	public static bool isBB; //Field offset: 0x31
	public static bool isPointerDown; //Field offset: 0x32
	public static bool isPointerRelease; //Field offset: 0x33
	public static bool isPointerSelect; //Field offset: 0x34
	public static bool isPointerMove; //Field offset: 0x35
	public static bool isPointerClick; //Field offset: 0x36
	public static bool isPointerEnd; //Field offset: 0x37
	public static bool isSmallScreen; //Field offset: 0x38
	public static bool isOffBg; //Field offset: 0x39
	public static bool isShortH; //Field offset: 0x3A
	public static bool isTaiTho; //Field offset: 0x3B
	public static bool isTouch; //Field offset: 0x3C
	public static bool isDisConnect; //Field offset: 0x3D
	public static int px; //Field offset: 0x40
	public static int py; //Field offset: 0x44
	public static int pxLast; //Field offset: 0x48
	public static int pyLast; //Field offset: 0x4C
	public static long timeNow; //Field offset: 0x50
	public static long clockServer; //Field offset: 0x58
	public static int hCommand; //Field offset: 0x60
	public static int hText; //Field offset: 0x64
	public static int wCommand; //Field offset: 0x68
	public static int hLoad; //Field offset: 0x6C
	public static int gameTick; //Field offset: 0x70
	public static int gameTickChia4; //Field offset: 0x74
	public static int xPlus12; //Field offset: 0x78
	public static int yPlus12; //Field offset: 0x7C
	public static int tickSelectChar; //Field offset: 0x80
	public static int keyAsciiPress; //Field offset: 0x84
	public static mVector listPoint; //Field offset: 0x88
	public static sbyte DAY; //Field offset: 0x90
	public static sbyte NIGHT; //Field offset: 0x91
	public static MainScreen currentScreen; //Field offset: 0x98
	public static MainDialog currentDialog; //Field offset: 0xA0
	public static MainDialog subDialog; //Field offset: 0xA8
	public static MainDialog DevilDialog; //Field offset: 0xB0
	public static MainDialog showDialog; //Field offset: 0xB8
	public static MsgDialogEvent EventDialog; //Field offset: 0xC0
	public static MsgDialogTrangTri TrangTriDialog; //Field offset: 0xC8
	public static GameScreen gameScr; //Field offset: 0xD0
	public static LoadMap loadmap; //Field offset: 0xD8
	public static ReadMessenge readMess; //Field offset: 0xE0
	public static LoginScreen loginScr; //Field offset: 0xE8
	public static FristLoginScreen fristLoginScr; //Field offset: 0xF0
	public static MapBackGround mapBack; //Field offset: 0xF8
	public static MapBackGround mapLogin; //Field offset: 0x100
	public static SaveImageRMS saveImage; //Field offset: 0x108
	public static LoadMapScreen loadMapScr; //Field offset: 0x110
	public static Menu menuCur; //Field offset: 0x118
	public static Menu menu; //Field offset: 0x120
	public static ListChar_Screen listCharScr; //Field offset: 0x128
	public static TabScreen tabAllScr; //Field offset: 0x130
	public static TabScreen tabShopScr; //Field offset: 0x138
	public static TabScreen tabMarketScr; //Field offset: 0x140
	public static ChatTabScreen chatTabScr; //Field offset: 0x148
	public static MainEvent eventScr; //Field offset: 0x150
	public static SaveRms saveRms; //Field offset: 0x158
	public static TabInventory tabInven; //Field offset: 0x160
	public static TabInventory tabInvenClan; //Field offset: 0x168
	public static TabInventory tabInvenMarket; //Field offset: 0x170
	public static UpdateImageScreen updateImageAndroidScr; //Field offset: 0x178
	public static Clan_Screen ClanScr; //Field offset: 0x180
	public static Sudo_Screen SudoScr; //Field offset: 0x188
	public static mVector vecTest; //Field offset: 0x190
	public static string infoDisConnect; //Field offset: 0x198
	public static String[][] strListServer; //Field offset: 0x1A0
	public static int IndexServer; //Field offset: 0x1A8
	public static int tickAction; //Field offset: 0x1AC
	public static int percent; //Field offset: 0x1B0
	public static int percentTemp; //Field offset: 0x1B4
	public static int hardcodeSpeedUp; //Field offset: 0x1B8
	public static int lvSavedPC; //Field offset: 0x1BC
	public static bool isLoadImage; //Field offset: 0x1C0
	public static string strIP; //Field offset: 0x1C8
	public static int indexdownload; //Field offset: 0x1D0
	public static bool isSendChatpopup; //Field offset: 0x1D4
	public static bool isQuickMenu; //Field offset: 0x1D5
	public static sbyte isSSItem; //Field offset: 0x1D6
	public static sbyte isTypeSpam; //Field offset: 0x1D7
	public mGraphics g; //Field offset: 0x48
	private bool isLoadFont; //Field offset: 0x50
	private ScreenBilak bilak; //Field offset: 0x58

	private static GameCanvas() { }

	public GameCanvas(Context context) { }

	public GameCanvas() { }

	public static void addTabStart() { }

	public static void addTest(string str) { }

	public static bool AnyKey() { }

	public void beginGame() { }

	public static void ClearActionUni(int action) { }

	public static void clearAll() { }

	public static void clearAllPointerEvent() { }

	public static void clearKeyHold(int keycode) { }

	public static void clearKeyHold() { }

	public static void ClearkeyMove(int Dir) { }

	public static void clearKeyPressed() { }

	public static void clearKeyPressed(int keycode) { }

	public static void clearKeyReleased() { }

	public static void connect() { }

	public static void connectDownload() { }

	public static void dialogDisconect() { }

	public static void end_Cur_Dialog() { }

	public static void end_Dialog() { }

	public static sbyte get_Day_Night() { }

	public static int getHourTime() { }

	public static MainItem getNumPotionItemShopByID(short idItem) { }

	public static bool getShowCmd() { }

	public static string getTextTime() { }

	public static long getTime() { }

	public static GameCanvas gI() { }

	public void initGame() { }

	public static bool isAndroid() { }

	public static bool isDeviceStore() { }

	public static bool isDialogOrMenuShow() { }

	public static bool isIos() { }

	public static bool isKeyPressed(int index) { }

	public static bool isLowGraOrWP_PvP() { }

	public static bool isPoint(int x, int y, int w, int h) { }

	public static bool isPointer(int x, int y, int w, int h) { }

	public static bool isPointLast(int x, int y, int w, int h) { }

	public static bool isPointSelect(int x, int y, int w, int h) { }

	public static bool isTouchAndKey() { }

	public static bool isTouchNoOrPC() { }

	public static bool keyActionUni(int action) { }

	public static bool keyMove(int Dir) { }

	public virtual void keyPressed(int keyCode) { }

	public virtual void keyReleased(int keyCode) { }

	public void loadRMSGAME() { }

	public void mapKeyPress(int keyCode) { }

	public void mapKeyRelease(int keyCode) { }

	public void onPointerDragged(int x, int y) { }

	public void onPointerPressed(int x, int y) { }

	public void onPointerReleased(int x, int y) { }

	public virtual void paint(mGraphics gx) { }

	public override void perform(int idAction, object p) { }

	private void randomBilak() { }

	public static void readGraphicsPC() { }

	public static void readLvGraphicPcRMS() { }

	public static void resetTrans(mGraphics g) { }

	public static void ShowMenu(Menu menu) { }

	public static MsgArchiDaily Start_Archi_Dialog(string name, mVector vec) { }

	public static void Start_Current_Dialog(MainDialog dgl) { }

	public static InputDialog Start_Input_Dialog(string info, iCommand cmd, bool isNum, string name) { }

	public static InputDialog Start_Input_Dialog_Server(String[] info, string name, iCommand cmd) { }

	public static InputDialog Start_Input_Dialog_Server(String[] info, string name, short Id) { }

	public static MsgTableMatch Start_Match_Dialog(mVector vec) { }

	public static void Start_Normal_DiaLog(string info, iCommand cmd, bool isCmdClose) { }

	public static void Start_Normal_DiaLog(string info, mVector vecCmd, bool isCmdClose) { }

	public static void Start_Normal_DiaLog_New(string info, mVector vecCmd, bool isCmdClose, string name) { }

	public static void Start_Normal_Only_CmdClose_DiaLog(string info) { }

	public static void Start_ReConect_DiaLog(string info, mVector vecCmd, bool isCmdClose) { }

	public static InputDialog Start_ShopInput_Dialog(string info, iCommand cmd, bool isNum, int defValue, int price, string name, string xuluong) { }

	public static void Start_Sub_Dialog(MainDialog dgl) { }

	public static void Start_Time_DiaLog(string info, bool isCmdClose, int time, mVector vec) { }

	public static void Start_Waiting_Connect_DiaLog(string info, bool isCmdClose) { }

	public static void Start_Waiting_DiaLog(string info, bool isCmdClose) { }

	public virtual void update() { }

	public void updateSpeed() { }

	public static bool UseKey(int value) { }

}

