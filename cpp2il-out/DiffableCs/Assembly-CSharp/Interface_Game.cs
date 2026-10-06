//Type is in global namespace

public class Interface_Game
{
	public const sbyte KEYPAD = 0; //Field offset: 0x0
	public const sbyte TOUCH = 1; //Field offset: 0x0
	public static mImage[] imgMove; //Field offset: 0x0
	public static mImage[] imgFire; //Field offset: 0x8
	public static mImage[] imgOther; //Field offset: 0x10
	public static mImage[] mImgPvPType; //Field offset: 0x18
	public static mImage[] mImgPvPNew; //Field offset: 0x20
	public static mImage imgInfo; //Field offset: 0x28
	public static mImage imgHoavan; //Field offset: 0x30
	public static mImage imgIconMPHP; //Field offset: 0x38
	public static mImage imgInfoServer; //Field offset: 0x40
	public static mImage imgInfoNew; //Field offset: 0x48
	public static mImage imgIconMPHP2; //Field offset: 0x50
	public static mImage imgbgLoL; //Field offset: 0x58
	public static mImage imgRankSkill; //Field offset: 0x60
	public static mImage imgHoiSinhLoL; //Field offset: 0x68
	public static mImage imgBorderWW; //Field offset: 0x70
	public static mImage imgBorderNoti; //Field offset: 0x78
	public static mImage imgBorderNoti2; //Field offset: 0x80
	public static FrameImage fraBorderNoti; //Field offset: 0x88
	public static FrameImage fraBorderNoti4; //Field offset: 0x90
	public static Int32[][] mPosKillCur; //Field offset: 0x98
	public static Int32[][] mPosKillBuff; //Field offset: 0xA0
	public static Int32[][] mPosKillSub; //Field offset: 0xA8
	public static Int32[][] mPosMove; //Field offset: 0xB0
	public static Int32[][] mPosOther; //Field offset: 0xB8
	public static Int32[][] mSizeImgOther; //Field offset: 0xC0
	public static Int32[][] mVChangTab; //Field offset: 0xC8
	public static Int32[][] mPosEffCurrent; //Field offset: 0xD0
	public static Int32[] mValueHotKey; //Field offset: 0xD8
	public static Int16[][] mValueLoL; //Field offset: 0xE0
	public static int killLeft; //Field offset: 0xE8
	public static int truLeft; //Field offset: 0xEC
	public static int killRight; //Field offset: 0xF0
	public static int truRight; //Field offset: 0xF4
	public static int xPointMove; //Field offset: 0xF8
	public static int yPointMove; //Field offset: 0xFC
	public static int keyPoint; //Field offset: 0x100
	public static int wArrowMove; //Field offset: 0x104
	public static int timePointer; //Field offset: 0x108
	private static int gocBegin; //Field offset: 0x10C
	private static int lSkill; //Field offset: 0x110
	public static int xFocus; //Field offset: 0x114
	public static int xBeginKill; //Field offset: 0x118
	public static int yBeginKill; //Field offset: 0x11C
	public static int wSkill; //Field offset: 0x120
	public static int wMainSkill; //Field offset: 0x124
	public static int yInfoServer; //Field offset: 0x128
	public static int xInfoServer; //Field offset: 0x12C
	public static int hInfoServer; //Field offset: 0x130
	public static int wInfoServer; //Field offset: 0x134
	public static int xBeginCombo; //Field offset: 0x138
	public static int yBeginCombo; //Field offset: 0x13C
	public static int xShowEffPvP; //Field offset: 0x140
	public static int yShowEffPvP; //Field offset: 0x144
	public static int xLoL; //Field offset: 0x148
	public static int yLoL; //Field offset: 0x14C
	public static int yQuickChat; //Field offset: 0x150
	public static bool isPaintInfoFocus; //Field offset: 0x154
	public static sbyte typeTouch; //Field offset: 0x155
	public static sbyte typeShowPvP; //Field offset: 0x156
	public static sbyte tickShowPvP; //Field offset: 0x157
	public static sbyte valueHoiSinhLOL; //Field offset: 0x158
	public static sbyte typeTitleRoomFight; //Field offset: 0x159
	private static bool isMove; //Field offset: 0x15A
	public static mVector vecEffCurrent; //Field offset: 0x160
	public static mVector vecEventShow; //Field offset: 0x168
	public static mVector vecInfoServer; //Field offset: 0x170
	public static mVector vecQuickChatLoL; //Field offset: 0x178
	public static int xMoveTo; //Field offset: 0x180
	public static int yMoveto; //Field offset: 0x184
	public static int timeMoveTo; //Field offset: 0x188
	public static CountDownTicket watchMap; //Field offset: 0x190
	public static CountDownTicket watchRevice; //Field offset: 0x198
	public static bool isSmallInfoServer; //Field offset: 0x1A0
	public static bool isPaintInfoServer; //Field offset: 0x1A1
	public static FrameImage[] fraLol; //Field offset: 0x1A8
	public static Item_Skill_Eff[] mCountKichAn; //Field offset: 0x1B0
	public static Int16[][] mHardcodeSkill; //Field offset: 0x1B8
	public static String[] mCallSkill; //Field offset: 0x1C0
	public static int timePaintIconSkill; //Field offset: 0x1C8
	public static int wComboSkill; //Field offset: 0x1CC
	public static int timeCombo; //Field offset: 0x1D0
	public static int indexEffCombo; //Field offset: 0x1D4
	public static int frameCombo; //Field offset: 0x1D8
	public static int timeEndCombo; //Field offset: 0x1DC
	public static bool isCombo; //Field offset: 0x1E0
	private static bool isEffHP; //Field offset: 0x1E1
	private static bool isEffMP; //Field offset: 0x1E2
	private static Int32[] mcolorEffHp; //Field offset: 0x1E8
	private static Int32[] mcolorEffMp; //Field offset: 0x1F0
	public static sbyte maxWin; //Field offset: 0x1F8
	public static int wMoneyEff; //Field offset: 0x1FC
	public static int mini; //Field offset: 0x200
	public static int tickeffShowMoney; //Field offset: 0x204
	public static int yEffShowMoney; //Field offset: 0x208
	public static int typeShowMoney; //Field offset: 0x20C
	private static int frameIconfocus; //Field offset: 0x210
	private static bool isNextFrame; //Field offset: 0x214
	public static Int32[][] colorHPHeart; //Field offset: 0x218
	public static int vEffHP; //Field offset: 0x220
	public static int vEffMP; //Field offset: 0x224
	public static int indexHardcodeSkill; //Field offset: 0x228
	public static mVector vecfocus; //Field offset: 0x230
	public static int hShowEvent; //Field offset: 0x238
	public static int timeShowEvent; //Field offset: 0x23C
	public static int speedShowEvent; //Field offset: 0x240
	public static int maxTimePaint; //Field offset: 0x244
	public static InfoMemList eventcur; //Field offset: 0x248
	public static InfoShowNotify infoFight; //Field offset: 0x250
	public static InfoShowNotify infoNormal; //Field offset: 0x258
	public static InfoShowNotify infoSpec; //Field offset: 0x260
	public static InfoShowNotify infoPlayer; //Field offset: 0x268
	private static int wShowInfoPlayer; //Field offset: 0x270
	private static int lastTick_2; //Field offset: 0x274
	private static int framepaint_2; //Field offset: 0x278
	private static int yEffInfoPlayer; //Field offset: 0x27C
	public static int xNumMess; //Field offset: 0x280
	public static int yNumMess; //Field offset: 0x284
	public static int xChat; //Field offset: 0x288
	public static int yChat; //Field offset: 0x28C
	public static int xAutoFire; //Field offset: 0x290
	public static int yAutoFire; //Field offset: 0x294
	public static int xClan; //Field offset: 0x298
	public static int yClan; //Field offset: 0x29C
	public static bool isAutoFireInterface; //Field offset: 0x2A0
	public static NumberMess numMess; //Field offset: 0x2A8
	public static NumberMess numClan; //Field offset: 0x2B0
	public static int yShowNameMap; //Field offset: 0x2B8
	public static int speedShowNameMap; //Field offset: 0x2BC
	public static int timeShowNameMap; //Field offset: 0x2C0
	public static int wtable; //Field offset: 0x2C4
	public static int HPMap; //Field offset: 0x2C8
	public static int maxHPMap; //Field offset: 0x2CC
	public static int wtable2; //Field offset: 0x2D0
	public static int hTextWatch; //Field offset: 0x2D4
	public static string nameMap; //Field offset: 0x2D8
	public static int indexPaintTable; //Field offset: 0x2E0
	public static int xShowNear; //Field offset: 0x2E4
	public static int speedShowNear; //Field offset: 0x2E8
	public static int timeShowNear; //Field offset: 0x2EC
	public static mVector vecClanDam; //Field offset: 0x2F0
	public static int demShowEffPvP; //Field offset: 0x2F8
	public Int32[] mKeyMove; //Field offset: 0x10
	private Int32[] mRotateMove; //Field offset: 0x18
	private int timeMove; //Field offset: 0x20
	private int timeChangeTab; //Field offset: 0x24
	private int maxTimeChange; //Field offset: 0x28
	public Int16[] posTam; //Field offset: 0x30
	private int dirTam; //Field offset: 0x38
	private bool isFocusTime; //Field offset: 0x3C
	private int timepointer; //Field offset: 0x40
	private int valueSmallScreen; //Field offset: 0x44
	private int tickCheckPoint; //Field offset: 0x48
	private int xmovetam; //Field offset: 0x4C
	private int ymovetam; //Field offset: 0x50
	private bool isFire; //Field offset: 0x54
	private int indexsetClass; //Field offset: 0x58
	private int indexsetSkill; //Field offset: 0x5C
	private Int16[] msetweapon; //Field offset: 0x60
	private String[] msetSkillDevil; //Field offset: 0x68
	private int minDisFocus; //Field offset: 0x70
	public sbyte xShow; //Field offset: 0x74
	public sbyte speedShow; //Field offset: 0x75
	public bool beginShow; //Field offset: 0x76
	private int lastTick; //Field offset: 0x78
	private int framepaint; //Field offset: 0x7C
	public bool isshowtime; //Field offset: 0x80

	private static Interface_Game() { }

	public Interface_Game() { }

	public void addEffCurrent(MainItem itemAdd) { }

	public void addInfo() { }

	public static void addInfoPlayerNormal(string str, mFont font) { }

	public static void addInfoServer(InfoShowNotify info) { }

	public static void addShowEvent(InfoMemList mem) { }

	private void checkChangeMapPoint() { }

	public static bool checkPaintWatch() { }

	public static string ConvertNumToStr(int num) { }

	public static string ConvertTimeToStr(int time) { }

	private void createShowNear() { }

	public bool isPaintIconGiaotiep() { }

	public void load_Image_Pointer() { }

	public void loadImageLOL() { }

	public void loadImagePvP() { }

	public static void loadImgPvPNew() { }

	public void loadPosLoL() { }

	public void moveTypeKeypad() { }

	public void moveTypeTouch() { }

	public static void paintAutoRepeatQuest(mGraphics g) { }

	public static void paintAutoSuperBoss(mGraphics g) { }

	public static void paintBackInfoServer(mGraphics g, int x, int y, int w) { }

	public static void paintBackInfoServerNew(mGraphics g, int x, int y, int type) { }

	private void paintChangTab(mGraphics g) { }

	private void paintComboSkill(mGraphics g) { }

	public static void paintEffShowMoney(mGraphics g, int x, int y, bool isShow, int type) { }

	private void paintHotKey(mGraphics g, Hotkey hot, int x, int y, int w, bool isPaintGiaotiep) { }

	public static void paintHP_Thong_Thao(mGraphics g, int x, int y, int maxpaint, int hpEff, int max, bool isFocus) { }

	public static void PaintHPMP(mGraphics g, sbyte type, int cur, int max, int x, int y, int plusHFont, int hrect, int wRect, int isNum, bool isflip, int hpEff, bool isUpdateEff, int LvHeart) { }

	public static void paintIconFocus(mGraphics g) { }

	public void paintInfoClanDam(mGraphics g) { }

	public void paintInfoFocus(mGraphics g) { }

	public void paintInfoLoL(mGraphics g) { }

	public static void paintInfoPlayer(mGraphics g, int x, int y, bool isborder, mFont fontLv) { }

	public static void paintInfoPlayer_Short(mGraphics g, int x, int y, bool isborder, mFont fontLv) { }

	public static void paintInfoServer(mGraphics g) { }

	public void paintInGame(mGraphics g) { }

	public static void PaintLoadData(mGraphics g, int curupdate, int maxupdate, int xp, int yp, int wUpdate, int hUpdate, int hNum) { }

	public static void paintMoveTo(mGraphics g) { }

	public void paintMoveTouch(mGraphics g, int i) { }

	private void paintNameMap(mGraphics g) { }

	public static void paintNumMess(mGraphics g, int xlech, int ylech) { }

	public static void paintPvPNew(mGraphics g, MainObject objLeft, MainObject objRight) { }

	private void paintQuickChatLoL(mGraphics g) { }

	public static void paintShowEvent(mGraphics g) { }

	public static void paintShowHelp(mGraphics g, bool isInmap) { }

	public void paintShowNameMap(mGraphics g) { }

	public static void paintShowNear(mGraphics g) { }

	public void paintShowtime(mGraphics g) { }

	private void paintShowtypePvP(mGraphics g, int x, int y) { }

	private void paintTableScoreLienTiep(mGraphics g) { }

	private void paintTableScoreNormal(mGraphics g) { }

	public void paintVecBuffCurrent(mGraphics g) { }

	public void paintVecEffKickAn(mGraphics g) { }

	public void paintViewGame(mGraphics g) { }

	public static void paintWaitingForMonster(mGraphics g) { }

	private void paintWatchMap(mGraphics g) { }

	private void paintWatchRevice(mGraphics g) { }

	public void selectPointer(int select) { }

	public static void setMoveTo(int x, int y) { }

	public MainObject setObjectNear(int x, int y) { }

	public void setPosMenu_TaiTho() { }

	public void setPosSkill() { }

	public static void setPosTouch() { }

	private void setskillClass() { }

	private void setSkillDevil() { }

	public static void setTypePvP(sbyte type) { }

	public static InfoShowNotify setUpdateInfoServer(InfoShowNotify infoInput, sbyte type) { }

	public static void setYTouch() { }

	public static void startQuickMenu() { }

	public void TouchMoveIngame() { }

	public static void updateEffShowMoney() { }

	public static void updateInfoServer() { }

	public void updateInGame() { }

	public void updateMoveCamera() { }

	public static void updateMoveTo() { }

	public static void updateNumMess() { }

	public static void updateShowEvent() { }

	public static void UpdateShowHelp(mGraphics g) { }

	public void updateShowNameMap() { }

	public static void updateShowNear() { }

	public void updateShowTime() { }

	public void updateTouchVecNear() { }

	public static void updateTypePvP() { }

	public void updateViewKhanGia() { }

}

