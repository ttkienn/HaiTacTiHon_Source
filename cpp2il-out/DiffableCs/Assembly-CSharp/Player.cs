//Type is in global namespace

public class Player : MainPlayer
{
	public static bool isSendMove; //Field offset: 0x0
	public const int HARDCODE_INDEX_EFF_SPEC = 1500; //Field offset: 0x0
	public const sbyte AUTO_RE_CHECK_AUTO_OK = 5; //Field offset: 0x0
	public const sbyte RED_LINE_FREE = 0; //Field offset: 0x0
	public const sbyte RED_LINE_DIE = 1; //Field offset: 0x0
	public const sbyte RED_LINE_FINISH = 2; //Field offset: 0x0
	public const sbyte GOTO_SKY_BEGIN = 0; //Field offset: 0x0
	public const int HARDCODE_INDEXPASSIVE = 1000; //Field offset: 0x0
	public const sbyte GOTO_CAPCHAR = 1; //Field offset: 0x0
	public const sbyte GOTO_FINISH = 3; //Field offset: 0x0
	public const sbyte AUTO_RE_CHECK_MAP_LANG = 0; //Field offset: 0x0
	public const sbyte AUTO_RE_SET_MOVE_CHECK_POINT = 1; //Field offset: 0x0
	public const sbyte AUTO_RE_MOVE_TO_CHECK_POINT = 2; //Field offset: 0x0
	public const sbyte AUTO_RE_DISCONECT = 3; //Field offset: 0x0
	public const sbyte AUTO_RE_WAIT = 4; //Field offset: 0x0
	public const sbyte GOTO_DIE = 2; //Field offset: 0x0
	public const int HARDCODE_INDEXPOTION = 500; //Field offset: 0x0
	public const sbyte AUTO_RE_DONOT_AUTO = 6; //Field offset: 0x0
	public static bool isGhost; //Field offset: 0x1
	public static bool isBlock; //Field offset: 0x2
	public static sbyte AutoFireCur; //Field offset: 0x3
	public static sbyte currentTab; //Field offset: 0x4
	public static sbyte typeAutoBuff; //Field offset: 0x5
	public static sbyte typeAutoFireMain; //Field offset: 0x6
	public static sbyte AutoRevice; //Field offset: 0x7
	public static sbyte isGetDataClan; //Field offset: 0x8
	public static int wFocus; //Field offset: 0xC
	public static int LvMinPk; //Field offset: 0x10
	public static int pointSkill; //Field offset: 0x14
	public static int pointAttribute; //Field offset: 0x18
	public static int pointMaxLevelAttri; //Field offset: 0x1C
	public static mVector vecInventory; //Field offset: 0x20
	public static mVector vecChest; //Field offset: 0x28
	public static mVector vecInvenClan; //Field offset: 0x30
	public static mVector vecMaxLevelAttri; //Field offset: 0x38
	public static Int16[] mSatnhan; //Field offset: 0x40
	public static Int16[] msattam; //Field offset: 0x48
	public static SByte[] mLvSkill; //Field offset: 0x50
	public static SByte[] mLvSkillPlus; //Field offset: 0x58
	public static Hotkey[][] hotkeyPlayer; //Field offset: 0x60
	public static Hotkey[] hotkeyBuffPlayer; //Field offset: 0x68
	public static MyHashTable delaySkill; //Field offset: 0x70
	public static Main_Attribute[] mAttribute; //Field offset: 0x78
	public static Int16[] mComboSkill; //Field offset: 0x80
	public static mVector vecListSkill; //Field offset: 0x88
	public static mVector vecQuest; //Field offset: 0x90
	public static mVector vecGhostInput; //Field offset: 0x98
	public static mVector vecUniform; //Field offset: 0xA0
	public static sbyte indexGhostServer; //Field offset: 0xA8
	public static sbyte numPassive; //Field offset: 0xA9
	public static sbyte ChucInCLan; //Field offset: 0xAA
	public static sbyte ChucInSudo; //Field offset: 0xAB
	public static sbyte isAutoMaterial; //Field offset: 0xAC
	public static string strTimeChange; //Field offset: 0xB0
	public static string strHethong; //Field offset: 0xB8
	public static bool isSkillready; //Field offset: 0xC0
	public static bool isAFK; //Field offset: 0xC1
	public static short idNPCQuestCur; //Field offset: 0xC2
	public static short idFashion; //Field offset: 0xC4
	public static MainQuest questMainNew; //Field offset: 0xC8
	public static Item[] mChestWanted; //Field offset: 0xD0
	public static int indexPosMapTrain; //Field offset: 0xD8
	public static int maxInventory; //Field offset: 0xDC
	public static int maxChest; //Field offset: 0xE0
	public static int indexCombo; //Field offset: 0xE4
	public static int indexAudition; //Field offset: 0xE8
	public static int Chestgem; //Field offset: 0xEC
	public static long Chestbeli; //Field offset: 0xF0
	public static short ticket; //Field offset: 0xF8
	public static short keyBoss; //Field offset: 0xFA
	public static short PvPticket; //Field offset: 0xFC
	public static short maxTicket; //Field offset: 0xFE
	public static short maxKeyboss; //Field offset: 0x100
	public static short maxPvPticket; //Field offset: 0x102
	public static MainQuest curQuest; //Field offset: 0x108
	public static mVector vecParty; //Field offset: 0x110
	public static mVector vecFriendList; //Field offset: 0x118
	public static mVector vecEvent; //Field offset: 0x120
	public static bool isFocusNPC; //Field offset: 0x128
	public static int timeFocusNPC; //Field offset: 0x12C
	public static Int32[][] hardCodeShortInfo; //Field offset: 0x130
	public static String[] InfoShortEquip; //Field offset: 0x138
	public static bool isMPHP; //Field offset: 0x140
	public static bool isGetItem; //Field offset: 0x141
	public static int xBeginAuto; //Field offset: 0x144
	public static int yBeginAuto; //Field offset: 0x148
	public static bool isBack; //Field offset: 0x14C
	public static int maxRangeAuto; //Field offset: 0x150
	public static short giamCountDownAtt; //Field offset: 0x154
	public static short giamCountDownParty; //Field offset: 0x156
	public static short GiamCountDownCur; //Field offset: 0x158
	public static short tickAutoRevice; //Field offset: 0x15A
	public static short TangManaUseSkill; //Field offset: 0x15C
	public static Boat boatKeyParty; //Field offset: 0x160
	public static Int32[] mframeghost; //Field offset: 0x168
	public static bool isChangeLine; //Field offset: 0x170
	public static int isShowDie; //Field offset: 0x174
	public static bool isFullInven; //Field offset: 0x178
	public static int IndexFire; //Field offset: 0x17C
	public static MainObject objAutoFrist; //Field offset: 0x180
	public static int distest; //Field offset: 0x188
	public static long beliTest; //Field offset: 0x190
	public static long valueTestBeli; //Field offset: 0x198
	public static long timeTestBeli; //Field offset: 0x1A0
	public static bool isUpdateMonney; //Field offset: 0x1A8
	public static sbyte StepAutoRe; //Field offset: 0x1A9
	public static int tickAutoRe; //Field offset: 0x1AC
	public int demUnFire; //Field offset: 0x498
	public long timeLastSkill; //Field offset: 0x4A0
	public int tickNauBanh; //Field offset: 0x4A8
	public bool isNauBanh; //Field offset: 0x4AC
	public int lineShowRedLineNext; //Field offset: 0x4B0
	public int lineShowRedLineCur; //Field offset: 0x4B4
	public int tickmove; //Field offset: 0x4B8
	public int tickChangeLine; //Field offset: 0x4BC
	public int tickFinish; //Field offset: 0x4C0
	public int typeMoveMapRedLine; //Field offset: 0x4C4
	public int typeMoveGotoSky; //Field offset: 0x4C8
	public MainItem hpPoi; //Field offset: 0x4D0
	public MainItem mpPoi; //Field offset: 0x4D8
	private int tickdemHP; //Field offset: 0x4E0
	private int tickdemMp; //Field offset: 0x4E4
	public bool isBeginTrain; //Field offset: 0x4E8
	private int indexkey; //Field offset: 0x4EC
	private Int32[] mindexkey; //Field offset: 0x4F0
	private int indexFocus; //Field offset: 0x4F8
	private long timeFristSkill; //Field offset: 0x500
	public int tickMaxBack; //Field offset: 0x508

	private static Player() { }

	public Player() { }

	public void actionPC(sbyte type) { }

	public virtual void actionStand() { }

	public virtual void AddBuff(MainBuff buff) { }

	public virtual void AddBuffNew2(MainBuff buff) { }

	public virtual void addEffBuff(sbyte typeBuff, short effBuff, short time) { }

	public virtual void addSkillFire(MainSkill skill, mVector vec) { }

	private void autoGetItem() { }

	public void beginPlayerFire(int index, Hotkey hot) { }

	public bool beginPlayerFire(Skill_Info skill_info) { }

	public void beginPlayerFire(int index) { }

	public void beginPlayerFirePoint() { }

	public bool check_Fire_EffSpec() { }

	public bool check_Move_EffSpec() { }

	private void checkAutoRevice() { }

	public void CheckBuffinEffCur(short idbuff) { }

	private bool checkCungClan(MainObject objset) { }

	public bool checkEffSpec(short typeEff) { }

	public bool checkShowHoiSinh() { }

	private bool CheckSkipFocus(MainObject obj) { }

	public MainSkill createSkill(Skill_Info info) { }

	public int getManaNeedUse(int mana) { }

	public MainItem getPotionAuto(sbyte mphp) { }

	public static bool isClazz(sbyte type) { }

	private bool isUseMPHP(sbyte type) { }

	public void nextFocus() { }

	public void nextMonster() { }

	public virtual void paint(mGraphics g) { }

	public static void paintGhost(mGraphics g, int x, int y) { }

	public void paintGotoSky(mGraphics g) { }

	public virtual void resetAction() { }

	public void setActionHotKey(int index) { }

	public void setActionHotKeyBuff(int index) { }

	public void setAutoFire(bool isAutoNew) { }

	public void setAutoPlayer() { }

	public void setCmdGame() { }

	public static void setDelaySkill(int index, int time, bool isNotCooldown, sbyte isSkill) { }

	public static void SetDiamondToChest() { }

	public static void SetDiamondToInven() { }

	private void setDisAuto() { }

	public bool setFightPk(MainObject objset) { }

	public void setFocus(bool allFocus) { }

	private bool setGetItem(MainObject obj) { }

	public static void SetGiamCountDown() { }

	public static void setHotKey(int index, MainSkill skill, MainItem item) { }

	public static void setHotKeyBuff() { }

	private void setKeyMoveNew() { }

	private void setKeyMoveNew(int valuemax) { }

	public static void SetMaterialToChest(sbyte type) { }

	public static void SetMaterialToInven(sbyte type) { }

	private void setMoveBoatOther() { }

	public virtual void setNextSea() { }

	public virtual void setPosDownBoat() { }

	public virtual void setPosUpBoat() { }

	private bool setSkillBuff(int index, Hotkey hot) { }

	public mVector setSkillLan(Skill_Info skill) { }

	public static void setStart_EndAutoFire(bool isAu) { }

	private int setTypeFocus(int typeObj) { }

	public void setUseMana(int manause) { }

	public virtual void setXtoYto(int xto, int yto) { }

	public void StepAutoReconnect() { }

	public void TestSkill(short typeEffSkill) { }

	public virtual void update() { }

	public void updateAutoBuff() { }

	private void updateDelay() { }

	public void updateKey() { }

	public void updateMapGotoGod(sbyte finalMove) { }

	public void updateMapGotoSky() { }

	public void updateMapRedLine() { }

	public virtual void updateMapTrain() { }

	public void updateMoney() { }

	public void updatePlayer() { }

	private void updatePosTrans() { }

	public void updateRedLineFinish() { }

	public virtual void updateTimeSafe() { }

}

