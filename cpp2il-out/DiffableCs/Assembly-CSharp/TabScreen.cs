//Type is in global namespace

public class TabScreen : MainScreen
{
	public static bool isRefresh; //Field offset: 0x0
	public const sbyte TAB = 0; //Field offset: 0x0
	public const sbyte INFO = 1; //Field offset: 0x0
	public static mVector vecEff; //Field offset: 0x8
	public mVector vecTabs; //Field offset: 0x50
	public MainTab tabCurrent; //Field offset: 0x58
	public iCommand cmdClose; //Field offset: 0x60
	public sbyte typeCurrent; //Field offset: 0x68
	public sbyte typeMarket; //Field offset: 0x69
	public int idSelect; //Field offset: 0x6C
	public bool isShopClan; //Field offset: 0x70
	public bool isFixscreen; //Field offset: 0x71
	public int xbeginPaintTab; //Field offset: 0x74
	private Int32[] mIndexMarket; //Field offset: 0x78

	private static TabScreen() { }

	public TabScreen(int xbegin, sbyte type) { }

	public static void addEffectNumImage(string content, int x, int y, sbyte typeColor, FrameImage fra, int frame) { }

	public void addVecTab(mVector vec) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void endInfoTab() { }

	public virtual bool keyBack() { }

	public virtual void paint(mGraphics g) { }

	public void setTabSelect() { }

	public virtual void setxyPlus12() { }

	public virtual void Show(MainScreen screen) { }

	public virtual void update() { }

	public void updateInfo() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

	public void updateVecDataMarket(sbyte index, mVector vec) { }

}

