//Type is in global namespace

public class GameScreen : MainScreen
{
	public static iCommand[] listCmdTest; //Field offset: 0x0
	public const sbyte ADMIN_OFF_NAME = 0; //Field offset: 0x0
	public const sbyte LIGHT = 0; //Field offset: 0x0
	public const sbyte FOOT = 0; //Field offset: 0x0
	public const int option3 = 150; //Field offset: 0x0
	public const int option2 = 125; //Field offset: 0x0
	public const int option1 = 100; //Field offset: 0x0
	public const sbyte VIEW_KHANGIA = 1; //Field offset: 0x0
	public const sbyte VIEW_NORMAL = 0; //Field offset: 0x0
	public const sbyte ADMIN_OFF_INTERFACE = 1; //Field offset: 0x0
	public const sbyte ADMIN_OFF_CHAT = 2; //Field offset: 0x0
	public static Player player; //Field offset: 0x8
	public static MainObject objFocus; //Field offset: 0x10
	public static MainObject objGiaotiep; //Field offset: 0x18
	public static MainObject objPvPNew; //Field offset: 0x20
	public static mVector vecPlayers; //Field offset: 0x28
	public static mVector vecEffTam; //Field offset: 0x30
	public static mVector VecEffect; //Field offset: 0x38
	public static mVector VecNum; //Field offset: 0x40
	public static mVector vecBoat; //Field offset: 0x48
	public static mVector vecObjMove; //Field offset: 0x50
	public static mVector vecObjFire; //Field offset: 0x58
	public static mVector vecHighDataEff; //Field offset: 0x60
	public static MainItemMap tr; //Field offset: 0x68
	public static MainItemMap maxtr; //Field offset: 0x70
	public static Interface_Game interfaceGame; //Field offset: 0x78
	public static iCommand cmdGiaoTiep; //Field offset: 0x80
	public static iCommand cmdVotBanh; //Field offset: 0x88
	public static iCommand cmdCheckServer; //Field offset: 0x90
	public static iCommand cmdReConnect; //Field offset: 0x98
	public static int numMess; //Field offset: 0xA0
	public static bool isMoveCamera; //Field offset: 0xA4
	public static bool isMoveCamEff; //Field offset: 0xA5
	public static bool isPvPNew; //Field offset: 0xA6
	public static int xMoveCam; //Field offset: 0xA8
	public static int yMoveCam; //Field offset: 0xAC
	public static int xCur; //Field offset: 0xB0
	public static int yCur; //Field offset: 0xB4
	public static int timeResetCam; //Field offset: 0xB8
	public static int typeMod; //Field offset: 0xBC
	public static Effect_Map effMap; //Field offset: 0xC0
	public static Effect_Map effSea; //Field offset: 0xC8
	public static sbyte typeViewPlayer; //Field offset: 0xD0
	public static MainObject objView; //Field offset: 0xD8
	public static bool isSetObjdDefault; //Field offset: 0xE0
	public static bool isShowFocusTK; //Field offset: 0xE1
	public static bool isShowSkillBuff; //Field offset: 0xE2
	public static bool isShowSkillPlayer; //Field offset: 0xE3
	public static bool isShowNhanVat; //Field offset: 0xE4
	public static mVector vecHelp; //Field offset: 0xE8
	public static int indexHelp; //Field offset: 0xF0
	public static int indexHDVaoLang; //Field offset: 0xF4
	public static int tickPvP; //Field offset: 0xF8
	public static int h12plus; //Field offset: 0xFC
	public static mVector vecBigBossLittleGraden; //Field offset: 0x100
	public static mVector vecGetItemLittle; //Field offset: 0x108
	public static bool isShowNameSUPER_BOSS; //Field offset: 0x110
	public static bool isShowNameXpArena; //Field offset: 0x111
	public static bool isShowNameSetting; //Field offset: 0x112
	public static bool isShowNameWW; //Field offset: 0x113
	public static bool isPaintInterface; //Field offset: 0x114
	public static bool isShowChat; //Field offset: 0x115
	public static bool isOffAll; //Field offset: 0x116
	public static bool isShowName; //Field offset: 0x117
	public static bool isOnChestAdmin; //Field offset: 0x118
	public static bool isShowIndex; //Field offset: 0x119
	public static bool isIP_Local; //Field offset: 0x11A
	public static bool isShowText; //Field offset: 0x11B
	public static bool isShowTextTab; //Field offset: 0x11C
	public static MainClan ClanDao; //Field offset: 0x120
	public static bool isOpenDao; //Field offset: 0x128
	public static bool isOnRepeatQuest; //Field offset: 0x129
	public static short numDot; //Field offset: 0x12A
	public static bool isOnSuperBoss; //Field offset: 0x12C
	public static mVector vecQuickOpenPotion; //Field offset: 0x130
	public static Int16[] listUpgradeAutoPotion; //Field offset: 0x138
	public static Int16[] listMonsterPokemon; //Field offset: 0x140
	public static bool isOnAutoPB; //Field offset: 0x148
	public static sbyte typePaintGameScreen; //Field offset: 0x149
	public static int dx; //Field offset: 0x14C
	public static int dy; //Field offset: 0x150
	public static mVector vecEffSkillSpec; //Field offset: 0x158
	private static int size; //Field offset: 0x160
	public static int numEff; //Field offset: 0x164
	public static int tickSpam; //Field offset: 0x168
	public static mVector vecEffOnMap; //Field offset: 0x170
	public static sbyte typeSuperEffect; //Field offset: 0x178
	public static int tickSuperEffect; //Field offset: 0x17C
	private int nump; //Field offset: 0x50
	private int numo; //Field offset: 0x54
	private MainObject ob; //Field offset: 0x58
	private MainObject maxob; //Field offset: 0x60
	public iCommand cmdNextFocus; //Field offset: 0x68
	public iCommand cmdHoiSinh; //Field offset: 0x70
	public iCommand cmdGetXpMapTrain; //Field offset: 0x78
	public iCommand cmdThoatFormMapTrain; //Field offset: 0x80
	public iCommand cmdInfoMe; //Field offset: 0x88
	public iCommand cmdSetPk; //Field offset: 0x90
	public iCommand cmdSetDosat; //Field offset: 0x98
	public iCommand cmdParty; //Field offset: 0xA0
	public iCommand cmdInviteParty; //Field offset: 0xA8
	public iCommand cmdLogOut; //Field offset: 0xB0
	public iCommand cmdTrochuyen; //Field offset: 0xB8
	public iCommand cmdChatPlayer; //Field offset: 0xC0
	public iCommand cmdAuto; //Field offset: 0xC8
	public iCommand cmdChatPopup; //Field offset: 0xD0
	public iCommand cmdAddFriend; //Field offset: 0xD8
	public iCommand cmdFriendList; //Field offset: 0xE0
	public iCommand cmdBlackList; //Field offset: 0xE8
	public iCommand cmdEvent; //Field offset: 0xF0
	public iCommand cmdChangeTouch; //Field offset: 0xF8
	public iCommand cmdFight; //Field offset: 0x100
	public iCommand cmdVeLang; //Field offset: 0x108
	public iCommand cmdInfoPlayer; //Field offset: 0x110
	public iCommand cmdSettingView; //Field offset: 0x118
	public iCommand cmdExitView; //Field offset: 0x120
	public iCommand cmdExit; //Field offset: 0x128
	public iCommand cmdWC; //Field offset: 0x130
	public iCommand cmdShowWC; //Field offset: 0x138
	public iCommand cmdInviteTrade; //Field offset: 0x140
	public iCommand cmdBuyGem; //Field offset: 0x148
	public iCommand cmdSendSerial_Mathe; //Field offset: 0x150
	public iCommand cmdHoiExit; //Field offset: 0x158
	public iCommand cmdMenuPk; //Field offset: 0x160
	public iCommand cmdClan; //Field offset: 0x168
	public iCommand cmdXinVaoClan; //Field offset: 0x170
	public iCommand cmdMoiVaoClan; //Field offset: 0x178
	public iCommand cmdShowName; //Field offset: 0x180
	public iCommand cmdMPHP; //Field offset: 0x188
	public iCommand cmdGetItem; //Field offset: 0x190
	public iCommand cmdDonotShowHat; //Field offset: 0x198
	public iCommand cmdDonotShowWeaponF; //Field offset: 0x1A0
	public iCommand cmdInfoDoithu; //Field offset: 0x1A8
	public iCommand cmdUniform; //Field offset: 0x1B0
	public iCommand cmdQuickChat; //Field offset: 0x1B8
	public iCommand cmdGiaotiepServer; //Field offset: 0x1C0
	public iCommand cmdLockChat; //Field offset: 0x1C8
	public iCommand cmdShowSkillBuff; //Field offset: 0x1D0
	public iCommand cmdSpam; //Field offset: 0x1D8
	public iCommand cmdTangRuby; //Field offset: 0x1E0
	public iCommand cmdDauGia; //Field offset: 0x1E8
	public iCommand cmdShowSkillPlayer; //Field offset: 0x1F0
	public iCommand cmdShowNhanVat; //Field offset: 0x1F8
	public iCommand cmdSudo; //Field offset: 0x200
	public iCommand cmdBaisu; //Field offset: 0x208
	public iCommand cmdPet; //Field offset: 0x210
	private InputDialog input; //Field offset: 0x218
	public int xRec; //Field offset: 0x220
	public int yRec; //Field offset: 0x224
	public int wRec; //Field offset: 0x228
	public int hRec; //Field offset: 0x22C
	public int colorRec; //Field offset: 0x230
	public bool isFullScreen; //Field offset: 0x234
	private AutoRepeatQuest autoRepeatQuest; //Field offset: 0x238
	private AutoSuperBoss autoSuperBoss; //Field offset: 0x240
	private int xWT2; //Field offset: 0x248
	private int yWT2; //Field offset: 0x24C
	private long timeBeginAfk; //Field offset: 0x250
	private bool getPointer; //Field offset: 0x258

	private static GameScreen() { }

	public GameScreen() { }

	public static void addBoatVec_And_mItem(Boat boat, bool isSort) { }

	public static MainItemMap addEffectAuto(string key, string value) { }

	public static void addEffectBuffNew(MainObject obj, short typeBuff, short time) { }

	public static void addEffectEnd(short type, int subtype, int x, int y, int time, sbyte dir, MainObject objEff) { }

	public static void addEffectEnd(short type, int subtype, int x, int y, sbyte dir, MainObject objEff) { }

	public static void addEffectEnd_ObjTo(short type, int subType, int x, int y, short Id, sbyte cat, short idImage, sbyte dir, MainObject objEff) { }

	public static void addEffectEnd_ObjTo(short type, int subType, int x, int y, short Id, sbyte cat, sbyte dir, MainObject objEff) { }

	public static void addEffectEnd_Time(short type, int subType, int x, int y, short Id, sbyte cat, sbyte dir, MainObject objEff, int time) { }

	public static void addEffectEnd_ToX_ToY(short type, int subtype, int x, int y, int xTo, int yTo, sbyte dir, MainObject objEff) { }

	public static void addEffectNum(string content, int x, int y, sbyte typeColor) { }

	public static void addEffectNumBig_NEW_AP(int value, int valueAP, int x, int y, sbyte typeColor) { }

	public static void addEffectNumImage(string content, int x, int y, sbyte typeColor, FrameImage fra, int frame) { }

	public static void addEffectSkill(MainSkill skill, MainObject objkill, mVector vecObjsBeFire) { }

	public static void addEffectSkill(MainSkill skill, MainObject objkill) { }

	public static void addEffectSkill2(short typeEffSkill, MainObject objkill, Object_Effect_Skill objbekill, int x, int y) { }

	public static void addEffectSkillSpec(MainSkill skill, MainObject objkill) { }

	public static void addHelp(int type, int typeSub) { }

	public static void addHightDataeff(short type, int x, int y) { }

	public static void addHightDataeff(short type, int x, int y, bool changeFlip) { }

	public static void addLazer(sbyte type, int x, int y, int xto, int yto) { }

	public static void addPlayer(MainObject obj) { }

	public static void beginPaintSpec() { }

	public static bool checkAddEff() { }

	public static void checkObjRemoveInVecMove(short id, sbyte cat) { }

	public bool checkPaintLow(MainObject obj) { }

	public bool checkPaintOB(MainObject obj) { }

	public static short checkPokemon() { }

	public static void checkRemoveImage(int type, bool isTrue) { }

	public virtual void commandMenu(int index, int subIndex) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public static MainEffect CreateEffectEnd(short type, int subtype, int x, int y, sbyte dir, MainObject objEff) { }

	public static MainEffect createEffectEnd_ObjTo(short type, int subType, int x, int y, short Id, sbyte cat, sbyte dir, MainObject objEff) { }

	public static MainEffect createEffectEndTime(short type, int subtype, int x, int y, int time, sbyte dir, MainObject objEff) { }

	public static MainEffect createEffEnd(short type, int subtype, int x, int y, int xto, int yto) { }

	public static void CreateEffOnMap(sbyte type, int x, int y, int dir, sbyte subtype) { }

	public static void CreateEffOnMapFullset(short type, int x, int y, int dir, sbyte subtype) { }

	public static Point createPoint(Point p) { }

	public bool disLowPaintOnlyShadow(MainObject obj) { }

	private void doMenuSettingView() { }

	public static int find_Index_Stop(mVector vec) { }

	public static MainObject findObjByID(short id) { }

	public static bool getIsOffAdmin(sbyte type) { }

	public mVector getMenu() { }

	private mVector getMenuGameNew() { }

	public static ObjMove getObjMove(short id, sbyte cat) { }

	private mVector getVecQuickChatGame() { }

	private mVector getVecQuickChatLOL() { }

	public static void isPaintNormal() { }

	public static bool isRoom() { }

	public virtual bool keyBack() { }

	public void Open_Dialog_Nap() { }

	public void Open_Nap_Store() { }

	public virtual void paint(mGraphics g) { }

	public static void paintMapOffLine(mGraphics g) { }

	public void paintNormal(mGraphics g) { }

	public void paintRectSpec(mGraphics g) { }

	private void paintSpec(mGraphics g) { }

	public void paintTree(mGraphics g, int index) { }

	public void readVecFire() { }

	public static void RemoveAllNPC() { }

	public static void removeBoatVec_And_mItem(Boat boat) { }

	public static void RemoveLoadMap() { }

	public void resetRecAlpha() { }

	public void saveSpeedUpRMS(int percent) { }

	private void setCaptionCmdAutoGetItem() { }

	public static void setIsMoveEff(bool ismove) { }

	public void setNauBanh(bool isNauBanh) { }

	private void setNewEventCLan() { }

	public static void setNumMess() { }

	public void setRevice() { }

	public static void setSuperEffect(sbyte type, sbyte tick) { }

	public void setTypeViewPlayer(sbyte type) { }

	public virtual void setxyPlus12() { }

	public virtual void Show() { }

	public void ShowChatTab(string name) { }

	public void ShowInfoOtherPlayer(string name) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	private void updateKeyView() { }

	private void updateMoveObj(ObjMove obj) { }

	public void updateOfflineMap() { }

	public virtual void updatePointer() { }

	private void updatePointerMapOffLine() { }

}

