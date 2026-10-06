//Type is in global namespace

public class MainObject : AvMain
{
	public const sbyte PK_COLOR = 4; //Field offset: 0x0
	public const sbyte PLAYER_NORMAL = 0; //Field offset: 0x0
	public const sbyte PLAYER_SUPPORT = 1; //Field offset: 0x0
	public const sbyte PLAYER_SHIPER = 2; //Field offset: 0x0
	public const sbyte PLAYER_NPC_EVENT = 3; //Field offset: 0x0
	public const sbyte PK_DOSAT = 0; //Field offset: 0x0
	public const sbyte PK_SATNHAN = 1; //Field offset: 0x0
	public const sbyte PK_DAUTRUONG = 2; //Field offset: 0x0
	public const sbyte CAT_ITEM_PET = 110; //Field offset: 0x0
	public const sbyte PK_CHIENDAU = 3; //Field offset: 0x0
	public const sbyte CLASS_ALL = 0; //Field offset: 0x0
	public const sbyte CLASS_LUFFY = 1; //Field offset: 0x0
	public const sbyte CLASS_ZORO = 2; //Field offset: 0x0
	public const sbyte CLASS_SANJI = 3; //Field offset: 0x0
	public const sbyte CLASS_NAMI = 4; //Field offset: 0x0
	public const sbyte CLASS_USSOP = 5; //Field offset: 0x0
	public const sbyte CLASS_MONSTER = 6; //Field offset: 0x0
	public const sbyte CAT_MONSTER = 1; //Field offset: 0x0
	public const sbyte CAT_ITEM_WANTED = 109; //Field offset: 0x0
	public const sbyte CAT_ITEM_HEAD = 108; //Field offset: 0x0
	public const sbyte CAT_ICON_CLAN = 107; //Field offset: 0x0
	public const sbyte CAT_POTION = 4; //Field offset: 0x0
	public const sbyte CAT_POTION_QUEST = 5; //Field offset: 0x0
	public const sbyte CAT_MONEY = 6; //Field offset: 0x0
	public const sbyte CAT_POTION_MATERIAL = 7; //Field offset: 0x0
	public const sbyte CAT_POTION_CLAN = 8; //Field offset: 0x0
	public const sbyte CAT_EFF_ITEM = 9; //Field offset: 0x0
	public const sbyte CAT_PET = 10; //Field offset: 0x0
	public const sbyte CAT_POTION_EVENT = 11; //Field offset: 0x0
	public const sbyte CAT_DATA_ATTRI_KICH_AN = 96; //Field offset: 0x0
	public const sbyte CAT_DATA_PLASH = 97; //Field offset: 0x0
	public const sbyte CAT_DATA_ITEM_MAP = 98; //Field offset: 0x0
	public const sbyte CAT_XP = 99; //Field offset: 0x0
	public const sbyte CAT_IMAGE_OTHER = 100; //Field offset: 0x0
	public const sbyte CAT_ITEM_BOAT = 102; //Field offset: 0x0
	public const sbyte CAT_ITEM_HAIR = 103; //Field offset: 0x0
	public const sbyte CAT_ITEM_SKILL = 104; //Field offset: 0x0
	public const sbyte CAT_ITEM_FASHION = 105; //Field offset: 0x0
	public const sbyte WEAR_WEAPON = 0; //Field offset: 0x0
	public const sbyte CAT_ITEM = 3; //Field offset: 0x0
	public const sbyte WEAR_HAT = 1; //Field offset: 0x0
	public const sbyte WEAR_BODY = 3; //Field offset: 0x0
	public const sbyte EFASHION_RAU_DEN = 5; //Field offset: 0x0
	public const sbyte CAT_PLAYER = 0; //Field offset: 0x0
	public const sbyte CAT_HAMMER_DIAL = -8; //Field offset: 0x0
	public const int AC_UP_BOAT = 5; //Field offset: 0x0
	public const int AC_DIE = 4; //Field offset: 0x0
	public const int AC_AVA = 3; //Field offset: 0x0
	public const int AC_FIRE = 2; //Field offset: 0x0
	public const sbyte EFASHION_DRAGON = 4; //Field offset: 0x0
	public const int AC_MOVE = 1; //Field offset: 0x0
	public static String[] strHelp; //Field offset: 0x0
	public const int DIR_RIGHT = 2; //Field offset: 0x0
	public const int DIR_LEFT = 0; //Field offset: 0x0
	public const int DIR_DOWN = 3; //Field offset: 0x0
	public const int DIR_UP = 1; //Field offset: 0x0
	private const sbyte MOVE_LEFT = 0; //Field offset: 0x0
	private const sbyte MOVE_RIGHT = 1; //Field offset: 0x0
	public const int AC_STAND = 0; //Field offset: 0x0
	public const sbyte WEAR_DAY = 2; //Field offset: 0x0
	public const sbyte EFASHION_WB_MEN = 3; //Field offset: 0x0
	public const sbyte EFASHION_VALENTINE = 1; //Field offset: 0x0
	public const sbyte WEAR_RING = 4; //Field offset: 0x0
	public const sbyte WEAR_LEG = 5; //Field offset: 0x0
	public const sbyte WEAR_HEAD = 6; //Field offset: 0x0
	public const sbyte WEAR_HAIR = 7; //Field offset: 0x0
	public const sbyte ONE_PART_HAIR = 5; //Field offset: 0x0
	public const sbyte ONE_PART_HEAD = 0; //Field offset: 0x0
	public const sbyte ACTIONBOAT_NORMAL = 0; //Field offset: 0x0
	public const sbyte EFASHION_WB_WOMEN = 2; //Field offset: 0x0
	public const sbyte ACTIONBOAT_UP = 1; //Field offset: 0x0
	public const sbyte ACTIONBOAT_UP_2 = 3; //Field offset: 0x0
	public const sbyte ACTIONBOAT_DOWN_2 = 4; //Field offset: 0x0
	public const sbyte PIRATE_NORMAL = -1; //Field offset: 0x0
	public const sbyte PIRATE_GOLD = 0; //Field offset: 0x0
	public const sbyte PIRATE_WHITE = 1; //Field offset: 0x0
	public const sbyte PIRATE_BLACK = 2; //Field offset: 0x0
	public const sbyte BOSS_SUPER_BOSS = 1; //Field offset: 0x0
	public const sbyte ACTIONBOAT_DOWN = 2; //Field offset: 0x0
	public const sbyte CAT_NPC = 2; //Field offset: 0x0
	public static int StepHelp; //Field offset: 0x8
	public static mImage imgShadow; //Field offset: 0x10
	public static mImage imgShadow2; //Field offset: 0x18
	public static mImage imgShadow3; //Field offset: 0x20
	public static DataHairServer[] dataEffHair; //Field offset: 0x28
	public static DataHairServer[] dataInfoHair; //Field offset: 0x30
	public static Int32[][] mPosMapTrain; //Field offset: 0x38
	public static sbyte testEFF; //Field offset: 0x40
	public static Int32[][][] CharInfo; //Field offset: 0x48
	public static SByte[][] fLechWeaponBigBody; //Field offset: 0x50
	public static FrameImage[] mfraImgFullSet; //Field offset: 0x58
	public static SByte[][] AR_FRAME_PP; //Field offset: 0x60
	public static sbyte EBODY_RANDOM_NORMAL; //Field offset: 0x68
	public static Int16[] idEffBody; //Field offset: 0x70
	public static Int16[] idPlayFrameHead; //Field offset: 0x78
	public static Int16[] idWeaponF; //Field offset: 0x80
	public static Int32[] mSortPaintHead; //Field offset: 0x88
	public static Int16[] ListLechHEAD; //Field offset: 0x90
	public static Int16[] ListKoLechHEAD; //Field offset: 0x98
	public static MyHashTable ALL_DATA_SKILL_EFF; //Field offset: 0xA0
	public string chatNPC; //Field offset: 0x40
	public string name; //Field offset: 0x48
	public string strChatPopup; //Field offset: 0x50
	public string namePlayer; //Field offset: 0x58
	public bool isDrop42; //Field offset: 0x60
	public string nameGiaotiep; //Field offset: 0x68
	public string npcChatMenu; //Field offset: 0x70
	public short ID; //Field offset: 0x78
	public short IdIcon; //Field offset: 0x7A
	public short IDMainShiper; //Field offset: 0x7C
	public short IdEffShow; //Field offset: 0x7E
	public Int32[][] mActionMonSter; //Field offset: 0x80
	public Int32[] mActionStandMonSter; //Field offset: 0x88
	public Int16[] myBoat; //Field offset: 0x90
	public Int32[] mValuePvP; //Field offset: 0x98
	public Item_Drop[] mItemDrop; //Field offset: 0xA0
	public sbyte typeMoveMonster; //Field offset: 0xA8
	public short head; //Field offset: 0xAA
	public short body; //Field offset: 0xAC
	public short leg; //Field offset: 0xAE
	public short weapon; //Field offset: 0xB0
	public short hair; //Field offset: 0xB2
	public short hat; //Field offset: 0xB4
	public short weaponFashion; //Field offset: 0xB6
	public short headMain; //Field offset: 0xB8
	public short bodyMain; //Field offset: 0xBA
	public short legMain; //Field offset: 0xBC
	public short hairMain; //Field offset: 0xBE
	public int x; //Field offset: 0xC0
	public int y; //Field offset: 0xC4
	public int xLast; //Field offset: 0xC8
	public int yLast; //Field offset: 0xCC
	public int dx; //Field offset: 0xD0
	public int dy; //Field offset: 0xD4
	public int dyMain; //Field offset: 0xD8
	public int dyMovePet; //Field offset: 0xDC
	public int dySea; //Field offset: 0xE0
	public int vySea; //Field offset: 0xE4
	public int vx; //Field offset: 0xE8
	public int vy; //Field offset: 0xEC
	public int wOne; //Field offset: 0xF0
	public int hOne; //Field offset: 0xF4
	public int vMax; //Field offset: 0xF8
	public int vMaxYSea; //Field offset: 0xFC
	public int ySort; //Field offset: 0x100
	public int ysai; //Field offset: 0x104
	public int xsai; //Field offset: 0x108
	public int frame; //Field offset: 0x10C
	public int frameOneStep; //Field offset: 0x110
	public int toX; //Field offset: 0x114
	public int toY; //Field offset: 0x118
	public int toXNew; //Field offset: 0x11C
	public int toYNew; //Field offset: 0x120
	public int weapon_frame; //Field offset: 0x124
	public int xStand; //Field offset: 0x128
	public int yStand; //Field offset: 0x12C
	public int xAnchor; //Field offset: 0x130
	public int yAnchor; //Field offset: 0x134
	public int xSeaAnchor; //Field offset: 0x138
	public int ySeaAnchor; //Field offset: 0x13C
	public int nFrame; //Field offset: 0x140
	public int wAvatar; //Field offset: 0x144
	public int hAvatar; //Field offset: 0x148
	public int hIconFocus; //Field offset: 0x14C
	public int vXEffAva; //Field offset: 0x150
	public int xUpBoat; //Field offset: 0x154
	public int yUpBoat; //Field offset: 0x158
	public int wNameFocus; //Field offset: 0x15C
	public int wNameNPC; //Field offset: 0x160
	public int timeBeginUpdateMove; //Field offset: 0x164
	public int tickSoundMove; //Field offset: 0x168
	public int xpArena; //Field offset: 0x16C
	public int timeItemDropEvent; //Field offset: 0x170
	public int checkWW; //Field offset: 0x174
	public int killWW; //Field offset: 0x178
	public int deadWW; //Field offset: 0x17C
	public int dyShadow; //Field offset: 0x180
	public int tickEffHead; //Field offset: 0x184
	public int indexBodySkill; //Field offset: 0x188
	public int tickAfterSkill; //Field offset: 0x18C
	public int xDie; //Field offset: 0x190
	public int yDie; //Field offset: 0x194
	public int dyDie; //Field offset: 0x198
	public int vxDie; //Field offset: 0x19C
	public int vyDie; //Field offset: 0x1A0
	public int Hp; //Field offset: 0x1A4
	public int HpEff; //Field offset: 0x1A8
	public int Mp; //Field offset: 0x1AC
	public int maxHp; //Field offset: 0x1B0
	public int maxMp; //Field offset: 0x1B4
	public int Lv; //Field offset: 0x1B8
	public int pointPk; //Field offset: 0x1BC
	public int percentLv; //Field offset: 0x1C0
	public int wanted; //Field offset: 0x1C4
	public int PointPvP; //Field offset: 0x1C8
	public int LvThongThao; //Field offset: 0x1CC
	public int percentThongThao; //Field offset: 0x1D0
	public int rankWanted; //Field offset: 0x1D4
	public int Action; //Field offset: 0x1D8
	public int Dir; //Field offset: 0x1DC
	public int type_left_right; //Field offset: 0x1E0
	public int DirSpec; //Field offset: 0x1E4
	public int timeFreeMove; //Field offset: 0x1E8
	public int timeRevice; //Field offset: 0x1EC
	public int timeBeFire; //Field offset: 0x1F0
	public int tickMapTrain; //Field offset: 0x1F4
	public int timeFreeFire; //Field offset: 0x1F8
	public int timeEffRemoveChar; //Field offset: 0x1FC
	public int timeDragon; //Field offset: 0x200
	public int timeFullSet; //Field offset: 0x204
	public int timeOutScreen; //Field offset: 0x208
	public int f; //Field offset: 0x20C
	public int dhCharPopup; //Field offset: 0x210
	public int timeInviMove; //Field offset: 0x214
	public int timeSafe; //Field offset: 0x218
	public long timeBeginSafe; //Field offset: 0x220
	public long timeBeginItemDropEvent; //Field offset: 0x228
	public int timeRemove; //Field offset: 0x230
	public int timeLeft; //Field offset: 0x234
	public sbyte state; //Field offset: 0x238
	public MainSkill Skilldefault; //Field offset: 0x240
	public MainObject objMainFocus; //Field offset: 0x248
	public BigBossLittleGraden bossLittle; //Field offset: 0x250
	public MyHashTable hashEquip; //Field offset: 0x258
	public PopupChat chat; //Field offset: 0x260
	public MainSkill skillMonDefault; //Field offset: 0x268
	public Start_Skill skillCurrent; //Field offset: 0x270
	public Plash plashNow; //Field offset: 0x278
	public sbyte downSpeedWater; //Field offset: 0x280
	public sbyte maxEffShip; //Field offset: 0x281
	public sbyte indexShip; //Field offset: 0x282
	public sbyte stepLeg; //Field offset: 0x283
	public sbyte colorXPArena; //Field offset: 0x284
	public sbyte levelPerfect; //Field offset: 0x285
	public sbyte typeShadow; //Field offset: 0x286
	public sbyte countKick; //Field offset: 0x287
	public sbyte countAva; //Field offset: 0x288
	public sbyte lechYHead; //Field offset: 0x289
	public sbyte lvHeart; //Field offset: 0x28A
	public sbyte clazz; //Field offset: 0x28B
	public sbyte typeEffStand; //Field offset: 0x28C
	public sbyte typeObject; //Field offset: 0x28D
	public sbyte typeSpecMonSter; //Field offset: 0x28E
	public sbyte colorName; //Field offset: 0x28F
	public sbyte typePK; //Field offset: 0x290
	public sbyte typePirate; //Field offset: 0x291
	public sbyte DirNew; //Field offset: 0x292
	public sbyte typeQuest; //Field offset: 0x293
	public sbyte typeSpecCharList; //Field offset: 0x294
	public sbyte typePlayer; //Field offset: 0x295
	public sbyte indexTeam; //Field offset: 0x296
	public sbyte indexPaintView; //Field offset: 0x297
	public sbyte typeActionBoat; //Field offset: 0x298
	public sbyte isHumanMonster; //Field offset: 0x299
	public sbyte typeIconNPC; //Field offset: 0x29A
	public sbyte isDonotShowHat; //Field offset: 0x29B
	public sbyte typeBossMonster; //Field offset: 0x29C
	public sbyte typePet; //Field offset: 0x29D
	public sbyte typeColor7; //Field offset: 0x29E
	public sbyte typeNpcEvent; //Field offset: 0x29F
	public sbyte isDonotShowWeaponF; //Field offset: 0x2A0
	public sbyte indexEff_1; //Field offset: 0x2A1
	public sbyte isPokemon; //Field offset: 0x2A2
	public sbyte dxEye; //Field offset: 0x2A3
	public sbyte dyEye; //Field offset: 0x2A4
	public sbyte indexEye; //Field offset: 0x2A5
	public sbyte demDonotPaint; //Field offset: 0x2A6
	public sbyte indexFullSet; //Field offset: 0x2A7
	public sbyte thanhtichPvP; //Field offset: 0x2A8
	public sbyte thanhtichLv; //Field offset: 0x2A9
	public sbyte typeEfffashion; //Field offset: 0x2AA
	public long timeLoadInfo; //Field offset: 0x2B0
	public long timeDie; //Field offset: 0x2B8
	public bool isDirMove; //Field offset: 0x2C0
	public bool isTanHinh; //Field offset: 0x2C1
	public bool isPaintWeapon; //Field offset: 0x2C2
	public bool isPaintSpec; //Field offset: 0x2C3
	public bool isPaintLeg; //Field offset: 0x2C4
	public bool isPlayStand; //Field offset: 0x2C5
	public bool isPet; //Field offset: 0x2C6
	public bool isFlyDie; //Field offset: 0x2C7
	public bool isDragon; //Field offset: 0x2C8
	public bool isDie; //Field offset: 0x2C9
	public bool isRemove; //Field offset: 0x2CA
	public bool isStop; //Field offset: 0x2CB
	public bool isInfo; //Field offset: 0x2CC
	public bool isLoadTemplate; //Field offset: 0x2CD
	public bool isParty; //Field offset: 0x2CE
	public bool isSend; //Field offset: 0x2CF
	public bool isMoveNor; //Field offset: 0x2D0
	public Int16[] posTransRoad; //Field offset: 0x2D8
	public Int16[] mSkillMapTrain; //Field offset: 0x2E0
	public mVector vecSkillFires; //Field offset: 0x2E8
	public mVector vecBuffCur; //Field offset: 0x2F0
	public mVector vecBuffCurNew; //Field offset: 0x2F8
	public mVector vecEffspec; //Field offset: 0x300
	public mVector vecTrade; //Field offset: 0x308
	public mVector vecEffFashion; //Field offset: 0x310
	public sbyte isTrade; //Field offset: 0x318
	public int gem; //Field offset: 0x31C
	public int vnd; //Field offset: 0x320
	public long beli; //Field offset: 0x328
	public int bua; //Field offset: 0x330
	public int diemNap; //Field offset: 0x334
	public MainClan clan; //Field offset: 0x338
	public MainSudo sudo; //Field offset: 0x340
	public Boat boatSea; //Field offset: 0x348
	public mVector vecDataEff; //Field offset: 0x350
	private int lastTick; //Field offset: 0x358
	private int framepaint; //Field offset: 0x35C
	public int left_right_Sea; //Field offset: 0x360
	public int tickJoinSea; //Field offset: 0x364
	public long timeBegin; //Field offset: 0x368
	private int tickEffFashion; //Field offset: 0x370
	public int vDy; //Field offset: 0x374
	public Int32[] feStand; //Field offset: 0x378
	public Int32[] feRun; //Field offset: 0x380
	public Int32[] feAva; //Field offset: 0x388
	public Int32[][] fetest; //Field offset: 0x390
	public int nFrameEffHair; //Field offset: 0x398
	public int ntickFrameOneStep; //Field offset: 0x39C
	public int nFrameEffBody; //Field offset: 0x3A0
	public int indexPlayMBody; //Field offset: 0x3A4
	public int tickPlayframeBody; //Field offset: 0x3A8
	public int nFrameEffHead; //Field offset: 0x3AC
	public int tickPlayframeWeapon; //Field offset: 0x3B0
	public int indexPlayWeapon; //Field offset: 0x3B4
	public int framePlayHead; //Field offset: 0x3B8
	public int nFrameEffLeg; //Field offset: 0x3BC
	public int nFrameEffWeapon; //Field offset: 0x3C0
	private FrameImage fraEffBody; //Field offset: 0x3C8
	private MainImage imgEffHair; //Field offset: 0x3D0
	private MainImage imgEffHead; //Field offset: 0x3D8
	private MainImage imgEffPlayBody; //Field offset: 0x3E0
	private MainImage imgEffPlayLeg; //Field offset: 0x3E8
	private MainImage imgEffPlayWeapon; //Field offset: 0x3F0
	private Int32[][] mPlayframeBody; //Field offset: 0x3F8
	public short idparP; //Field offset: 0x400
	public short FramePP; //Field offset: 0x402
	public short fPP; //Field offset: 0x404
	private int xEffBody; //Field offset: 0x408
	private int yEffBody; //Field offset: 0x40C
	private int frameEffBody; //Field offset: 0x410
	private int typeActionEffBody; //Field offset: 0x414
	private int framePlayEB; //Field offset: 0x418
	public short idHairbay; //Field offset: 0x41C
	public short idBodybay; //Field offset: 0x41E
	public short idLegBay; //Field offset: 0x420
	public short idWeaponBay; //Field offset: 0x422
	public Int32[] mSortPaint; //Field offset: 0x428
	public Int32[] mSortPaintRight; //Field offset: 0x430
	private bool isKoLechHead; //Field offset: 0x438
	private bool isBuffDevil; //Field offset: 0x439
	public bool isTestchoi; //Field offset: 0x43A
	public Int32[] mActionShow; //Field offset: 0x440
	private int demFire; //Field offset: 0x448
	private int tickfire; //Field offset: 0x44C
	public int endEye; //Field offset: 0x450
	public int eye; //Field offset: 0x454
	public int timeEye; //Field offset: 0x458
	public sbyte stepUpboat; //Field offset: 0x45C
	public sbyte tickTypeActionBoat; //Field offset: 0x45D
	public int speedHpEff; //Field offset: 0x460
	public int tickHpEff; //Field offset: 0x464

	private static MainObject() { }

	public MainObject() { }

	public override void actionStand() { }

	public override void AddBuff(MainBuff buff) { }

	public override void AddBuffNew2(MainBuff buff) { }

	public void addChat(string str, bool isStop) { }

	public void addChatItem(short idIconChat, sbyte cat, short num) { }

	public void addDataEff(short id, int time) { }

	public void addDataEff(short id, int time, sbyte typemove, sbyte loop) { }

	public override void addEffBuff(sbyte typeBuff, short effBuff, short time) { }

	public void addEffFashion() { }

	public void addEffSpec(short type, short time) { }

	public override void addSkillFire(MainSkill skill, mVector vec) { }

	public override void beginDie(MainObject objFire) { }

	public bool checkBoatSea() { }

	public void checkBuffDevil() { }

	private bool checkCF(int fr) { }

	private bool checkCFBody(int fr) { }

	private bool checkCFHead(int fr) { }

	private bool checkCFLeg(int fr) { }

	private bool checkCFWeapon(int fr) { }

	private short checkEffBody() { }

	private short checkEffHair() { }

	private void checkEffWeapon() { }

	private bool checkMapChiemDao() { }

	private short checkPlayFrameBody() { }

	private short checkPlayFrameHead() { }

	private short checkPlayFrameLeg() { }

	private short checkPlayFrameWeapon() { }

	public bool checPaintByDataEff() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public static MainObject get_Object(int ID, sbyte tem) { }

	public override iCommand getCenterCmd() { }

	public static DataSkillEff getDataSkillEff(int id) { }

	public static int getDistance(int x, int y, int x2, int y2) { }

	public static int getDistance(int x, int y) { }

	public mVector getListQuestNPC() { }

	public static mPart getOnePart(int value) { }

	public mPart getpaint(int index) { }

	public static MainObject getPet(short IDMain) { }

	public void getPosLast() { }

	public void getSpeedforRun(int max) { }

	public override int getTypeMoveMonster() { }

	public override void Giaotiep() { }

	public void GiaotiepNPC() { }

	public void GiaotiepOtherPlayer() { }

	private bool ischeckWeaponF() { }

	public bool isHuman() { }

	public static bool isInScreen(MainObject obj) { }

	public override int isNPC_Area() { }

	public override bool isTru() { }

	public override void loadInfoAgain(CatalogyMonster cata) { }

	public void Move_to_Focus_Person() { }

	public void move_to_XY() { }

	public void move_to_XY_Normal() { }

	public void moveToLastPos() { }

	public void moveX() { }

	public void moveY() { }

	public virtual void paint(mGraphics g) { }

	public void paintBody(mGraphics g, int x, int y, int fr, int dirr, bool isEye) { }

	public void paintBuffFirst(mGraphics g, int x, int y) { }

	public void paintBuffLast(mGraphics g, int x, int y) { }

	public void paintBuffLastNew(mGraphics g, int x, int y) { }

	public void paintChar(mGraphics g, int x, int y) { }

	public void paintCharAllPart(mGraphics g, int typeSha) { }

	public void paintCharNoPart(mGraphics g, int typeSha) { }

	public void paintCharSelect(mGraphics g, int x, int y, int Dirr, int fr) { }

	public void paintCharShow(mGraphics g, int x, int y, int Dirr, bool isNhip) { }

	public void paintDataEff(mGraphics g, int x, int y, int type) { }

	public void paintEffFashion(mGraphics g, int levelpaint) { }

	public void paintEffFullSet(mGraphics g, int x2, int y2, int typeLeftRight) { }

	public void paintEffFullSet_Last(mGraphics g, int x2, int y2, int typeLeftRight) { }

	public void paintEffSpecFirst(mGraphics g) { }

	public void paintEffSpecLast(mGraphics g) { }

	public override void paintHead(mGraphics g, int x, int y, int trans) { }

	public static void paintHeadEveryWhere(mGraphics g, short head, short hair, short hat, int x, int y, int trans) { }

	public static void paintHeadListWhere(mGraphics g, short head, short hair, short hat, int x, int y, int trans) { }

	public virtual void paintHideAvatar(mGraphics g) { }

	public void paintHPFocus(mGraphics g) { }

	private void paintIconClan(mGraphics g, int x2, int y2) { }

	public void paintIconNPC(mGraphics g, int x) { }

	private void paintIconPerfect(mGraphics g, int xp, int yp) { }

	public void paintIconPk_ThanhTich(mGraphics g) { }

	public void paintIconQuest(mGraphics g, int x) { }

	private void paintIconWanted(mGraphics g, int x, int y) { }

	public override void paintInfoFocus(mGraphics g, int xp, int yp) { }

	public void paintLV(mGraphics g, sbyte color) { }

	public override void paintName(mGraphics g, sbyte color, int isFocus) { }

	public static void paintOnePart(mGraphics g, int value, int index, int x, int y, int valueDy) { }

	public override void paintOnlyShadown(mGraphics g) { }

	public void paintPhiPhong(mGraphics g) { }

	public override void paintShadow(mGraphics g, int xpaint) { }

	public override void paintShadow(mGraphics g, int xpaint, int ypaint) { }

	public void paintshadowFocus(mGraphics g, int ylech) { }

	public override void paintShadowMonster(mGraphics g, int xpaint, int dyS, int type) { }

	public void paintThanhTich(mGraphics g, int yBegin, int xBegin) { }

	public void paintWhenBoatOther(mGraphics g, int x, int y) { }

	public mPart partLow(int index) { }

	public void removeDataEff(short id) { }

	public override void resetAction() { }

	public void resetBeginFire() { }

	public void resetPart() { }

	public void resetXY() { }

	public bool returnAction() { }

	public override void Reveive() { }

	public override void setActionSea(sbyte type, int xSea, int ySea) { }

	public void setbody() { }

	public void setBodyBay(short id) { }

	public void setBodySkill() { }

	public override void setDataBeginSkill(MainSkill skill, mVector vec) { }

	public override void setDataPet(short ID, short idImage, sbyte type) { }

	public void setDirNew(sbyte typeEff) { }

	public void setEffDie() { }

	private void setEye() { }

	public override void setFireObject(int value) { }

	public void sethair(short hairset) { }

	public void setHairBay(short id) { }

	public void sethead(short headset) { }

	public void setHeadBigBody() { }

	public void setHpEff() { }

	public override void setImgMonSterforOtherPlayer(sbyte typeMove) { }

	public void setInfoMapTrain() { }

	public bool setIsInScreen(int x, int y, int wOne, int hOne) { }

	public void setLeg() { }

	public void setLegBay(short id) { }

	public void setMove(int MonWater, int t) { }

	public override void setNextSea() { }

	public override void setPetActionFire() { }

	public override void setPosEvent() { }

	public void setResetWearing() { }

	public void setSpeed(int vM, int vySeaM) { }

	public override void setTouchPoint() { }

	public void setTypeQuest() { }

	public void setWeapon() { }

	public void setWeaponBay(short id) { }

	public override void setWearing(Int16[] mWear) { }

	public void setWearingIsNull(Int16[] mWear) { }

	public override void setWearingMon(Int16[] mWear) { }

	public void setWName() { }

	public void SetXlechEffectBongToi() { }

	public void setXYPet(int x, int y) { }

	public virtual void update() { }

	public override void updateActionDown() { }

	public override void updateActionDown_2() { }

	public override void updateActionFire() { }

	public void updateActionMonSter(bool isPet) { }

	public void updateActionPerLogin() { }

	public void updateActionPerson() { }

	public override void updateActionUp() { }

	public override void updateActionUp_2() { }

	public override void updateActionUpBoat() { }

	public override void updateAva() { }

	public void updateBuff() { }

	public void updateChatPopup(int dh) { }

	public void updateDataEff() { }

	public void updateDirPaint() { }

	public void updateDy() { }

	public override void updateDySea() { }

	private void updateEffFashion() { }

	public void updateEffSpec() { }

	public void updateEye() { }

	public void updateLoginShow() { }

	public void updatePP() { }

	public override void updateTimeSafe() { }

	public void updatevXEffAva() { }

}

