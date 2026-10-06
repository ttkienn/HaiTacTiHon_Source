//Type is in global namespace

public class LoadMapScreen : MainScreen
{
	public static bool isNextMap; //Field offset: 0x0
	public static bool isLoadDataMon; //Field offset: 0x1
	public static bool isPaintBack; //Field offset: 0x2
	public static bool isSuperBoss; //Field offset: 0x3
	public static sbyte IDBack; //Field offset: 0x4
	public static sbyte typeChangeMap; //Field offset: 0x5
	public static short HBack; //Field offset: 0x6
	public static sbyte isMapSky; //Field offset: 0x8
	public static sbyte countLoadMap; //Field offset: 0x9
	private long time; //Field offset: 0x50
	public SByte[] mItemMap; //Field offset: 0x58
	private int tick; //Field offset: 0x60
	private int tickPaintMap; //Field offset: 0x64
	public sbyte area; //Field offset: 0x68

	private static LoadMapScreen() { }

	public LoadMapScreen() { }

	private void checkDelInstance() { }

	private void CheckHuongDanVaoLang() { }

	private bool checkMapDontshow() { }

	private void goToMapSea() { }

	public virtual void paint(mGraphics g) { }

	public static void PlayMusicLang() { }

	private void setMapSea() { }

	public virtual void setxyPlus12() { }

	public virtual void Show() { }

	public virtual void update() { }

}

