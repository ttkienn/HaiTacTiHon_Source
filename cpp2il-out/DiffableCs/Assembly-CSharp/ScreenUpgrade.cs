//Type is in global namespace

public class ScreenUpgrade : MainScreen
{
	public const sbyte SHOWITEM_ONLY_DA_KHAM_ITEM = 2; //Field offset: 0x0
	public const sbyte SHOWITEM_ONLY_DA_KHAM = 1; //Field offset: 0x0
	public const sbyte SHOWITEM_ONLY_ITEM = 3; //Field offset: 0x0
	public const sbyte SHOWITEM_ONLY_ITEM_AND_BUA = 4; //Field offset: 0x0
	public const sbyte SHOWITEM_ONLY_ITEM_AND_HAMMER_DIAL = 5; //Field offset: 0x0
	public static MainItem[] mItemUpgrade; //Field offset: 0x0
	public static MainDataUpgrade[] mTemMaterialUpgrade; //Field offset: 0x8
	public static Int16[] mTileUpdate; //Field offset: 0x10
	public static Int16[] mTileGhepĐa; //Field offset: 0x18
	public static Int16[] mTileChuyenHoa; //Field offset: 0x20
	public static sbyte curTypeShop; //Field offset: 0x28
	public static ScreenUpgrade instance; //Field offset: 0x30
	public static MainItem[] mItemUpgradeSaveTemp; //Field offset: 0x38
	public static bool isClickUpgradeSkinToSucess; //Field offset: 0x40
	public static bool isContinueUpgradeSkin; //Field offset: 0x41
	public static bool isNextStepUpgradeSkin; //Field offset: 0x42
	public static bool isClickUpgradeItemToSucess; //Field offset: 0x43
	public static bool isContinueUpgradeItem; //Field offset: 0x44
	public static bool isUpgradeItemSucess; //Field offset: 0x45
	public static sbyte beriOrRuby; //Field offset: 0x46
	public static bool isClickUpgradeSuperItemToSucess; //Field offset: 0x47
	public static bool isContinueUpgradeSuperItem; //Field offset: 0x48
	public static bool isUpgradeSuperItemSucess; //Field offset: 0x49
	public static bool isUpgradeAuto; //Field offset: 0x4A
	public static bool isShowUpgradeAuto; //Field offset: 0x4B
	public static bool isContinueUpgradeAuto; //Field offset: 0x4C
	public static short numUpgradeAuto; //Field offset: 0x4E
	public static short numContinueUpgradeAuto; //Field offset: 0x50
	public static int valueLucky; //Field offset: 0x54
	public static int valueRotCap; //Field offset: 0x58
	public static int valueTile; //Field offset: 0x5C
	public static int valueMonney_1; //Field offset: 0x60
	public static int valueMonney_2; //Field offset: 0x64
	public static int valueMonney_3; //Field offset: 0x68
	public int w; //Field offset: 0x50
	public int h; //Field offset: 0x54
	public int wItem; //Field offset: 0x58
	public int x; //Field offset: 0x5C
	public int y; //Field offset: 0x60
	public int lech; //Field offset: 0x64
	public int IdSelect; //Field offset: 0x68
	public int xInven; //Field offset: 0x6C
	public int yInven; //Field offset: 0x70
	public int wInven; //Field offset: 0x74
	public int hInven; //Field offset: 0x78
	public int maxNumItemW; //Field offset: 0x7C
	public int xInfo; //Field offset: 0x80
	public int yInfo; //Field offset: 0x84
	public int xMid; //Field offset: 0x88
	public int yMid; //Field offset: 0x8C
	public Int32[][] posUp; //Field offset: 0x90
	public bool isShowInfo; //Field offset: 0x98
	public ListNew list; //Field offset: 0xA0
	public mVector vecCmd; //Field offset: 0xA8
	public MainItem itemCur; //Field offset: 0xB0
	public iCommand cmdBovao; //Field offset: 0xB8
	public iCommand cmdLucky; //Field offset: 0xC0
	public iCommand cmdClose; //Field offset: 0xC8
	public iCommand cmdUpgrade; //Field offset: 0xD0
	public iCommand cmdUpgradeAuto; //Field offset: 0xD8
	public iCommand cmdStopAuto; //Field offset: 0xE0
	public iCommand cmdUpgradeOk; //Field offset: 0xE8
	public iCommand cmdBoVaoAll; //Field offset: 0xF0
	public iCommand cmdShop; //Field offset: 0xF8
	public iCommand cmdMenu; //Field offset: 0x100
	public iCommand cmdBovaoDasieucap; //Field offset: 0x108
	public mVector vecEff; //Field offset: 0x110
	public string nameScreen; //Field offset: 0x118
	public string showServer; //Field offset: 0x120
	public int Step; //Field offset: 0x128
	public int tickStep; //Field offset: 0x12C
	public int indexAreaSellect; //Field offset: 0x130
	public int xTiLe; //Field offset: 0x134
	public sbyte typeRebuild; //Field offset: 0x138
	public FrameImage fraEffUpgrade; //Field offset: 0x140
	public sbyte typeShowItem; //Field offset: 0x148
	private InputDialog input; //Field offset: 0x150
	public mVector vecInventory; //Field offset: 0x158
	public int xCheckBoxSkin; //Field offset: 0x160
	public int yCheckBoxSkin; //Field offset: 0x164
	public int wCheckBoxSkin; //Field offset: 0x168
	public int hCheckBoxSkin; //Field offset: 0x16C
	public long timeStartAddItemUpgradeSkin; //Field offset: 0x170
	public string nameItemUpgradeSkinNotEnough; //Field offset: 0x178
	public int xCheckBoxItem; //Field offset: 0x180
	public int yCheckBoxItem; //Field offset: 0x184
	public int wCheckBoxItem; //Field offset: 0x188
	public int hCheckBoxItem; //Field offset: 0x18C
	public long timeStartUpgradeItemAuto; //Field offset: 0x190
	public long timeStartUpgradeSuperItemAuto; //Field offset: 0x198
	public int valueBaoHiem; //Field offset: 0x1A0
	public int valueMayMan; //Field offset: 0x1A4
	public mImage imghoavan; //Field offset: 0x1A8
	public mImage imgtron; //Field offset: 0x1B0
	public int frameEff; //Field offset: 0x1B8
	public int frameEndEff; //Field offset: 0x1BC
	private bool isRunEff; //Field offset: 0x1C0
	public sbyte timeShowInfo; //Field offset: 0x1C1
	public int indexStep; //Field offset: 0x1C4
	public int tickStop; //Field offset: 0x1C8
	public int valueTileRotCap; //Field offset: 0x1CC

	private static ScreenUpgrade() { }

	public ScreenUpgrade() { }

	public ScreenUpgrade(sbyte typeRebuild, int size) { }

	public Int32[] checkExistArrMaterialByIdAndNum() { }

	public bool checkExistMaterialByIdAndNum(short id, int num) { }

	public bool checkFullItemUpgrade() { }

	public bool checkItemIsCmdUpgradeAuto(short IdItem) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void createEff(short type, int subtype, int x, int y, int time) { }

	public void createEff(short type, int subtype, int x, int y, int xto, int yto) { }

	public override iCommand getCmdShopMore() { }

	public override void getItemCurNew() { }

	public override mVector getMenuActionItem() { }

	public void getMenushop() { }

	public string getNameMaterialLost(Int32[] arrCheck) { }

	public override bool isGetItemUpgrade(short Id, sbyte cat) { }

	public virtual bool keyBack() { }

	private void loadImg() { }

	public virtual void paint(mGraphics g) { }

	public override void paintBackGr(mGraphics g) { }

	public override void paintChat(mGraphics g) { }

	public void paintEff(mGraphics g, int level) { }

	public override void paintIconUpgrade(mGraphics g, int x, int y, MainItem item) { }

	public override void paintInven(mGraphics g) { }

	public override void paintlockShow(mGraphics g, MainItem item, int x, int y) { }

	public override void paintlockTrade(mGraphics g, MainItem item, int x, int y) { }

	public override void paintPosItem(mGraphics g) { }

	public override void paintRectPlus(mGraphics g) { }

	public void paintSuper(mGraphics g) { }

	public override void paintTiLe(mGraphics g) { }

	public override void paintTrade(mGraphics g) { }

	public override void setDataUpgrade() { }

	public void setInfo(MainItem[] listItem) { }

	public void setInfo_money(int valueTile, int valueMonney_1, int valueMonney_2, int valueMonney_3) { }

	public override void setPosCmd(mVector vec) { }

	public void setPosInfo(MainItem item, int xbe, int ybe) { }

	public override void setPosInfo() { }

	private void setRotCap() { }

	public override void setStart(sbyte typeRebuild, int size) { }

	public override void setStep() { }

	public virtual void setxyPlus12() { }

	public void startUpgradeItemAuto() { }

	public void startUpgradeSuperItemAuto() { }

	public static void stopUpgradeItemAuto() { }

	public static void stopUpgradeSuperItemAuto() { }

	public virtual void update() { }

	public void updateEff() { }

	public virtual void updatekey() { }

	public void updatekeySuper() { }

	public void updateKHAM() { }

	public override void updateNewUpgrade() { }

	public virtual void updatePointer() { }

	public void updatePointerCheckBoxUpgradeItem() { }

	public void updatePointerCheckBoxUpgradeSuperItem() { }

	public void updatePointerCmdUpgradeAuto() { }

	public void updatePointerSuper() { }

	public void updateShowInfo() { }

}

