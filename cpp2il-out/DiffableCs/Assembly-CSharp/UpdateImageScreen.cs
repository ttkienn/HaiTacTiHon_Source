//Type is in global namespace

public class UpdateImageScreen : MainScreen
{
	public static int maxNum; //Field offset: 0x0
	public const sbyte LOADING = 2; //Field offset: 0x0
	public const sbyte FAIL = 1; //Field offset: 0x0
	public const sbyte CONNECT = 0; //Field offset: 0x0
	public const sbyte LOADING_OK = 3; //Field offset: 0x0
	public static int curNum; //Field offset: 0x4
	public static sbyte statusUpdate; //Field offset: 0x8
	public static string strPaint; //Field offset: 0x10
	private int wpaint; //Field offset: 0x50
	private int maxwPaint; //Field offset: 0x54
	private int x; //Field offset: 0x58
	private int y; //Field offset: 0x5C
	private int hpaint; //Field offset: 0x60
	private long timeBegin; //Field offset: 0x68
	private mImage imglogo; //Field offset: 0x70
	private mImage imgsea; //Field offset: 0x78
	private mImage imgsky; //Field offset: 0x80
	private mImage imgloading1; //Field offset: 0x88
	private mImage imgloading2; //Field offset: 0x90
	private mImage imgloading3; //Field offset: 0x98
	private int wSky; //Field offset: 0xA0
	private int wSea; //Field offset: 0xA4
	private int hSky; //Field offset: 0xA8
	private int hSea; //Field offset: 0xAC
	private bool isCheckIOSZoom; //Field offset: 0xB0

	private static UpdateImageScreen() { }

	public UpdateImageScreen() { }

	public void beginLoadImage() { }

	public void loadImage() { }

	public virtual void paint(mGraphics g) { }

	public void saveVer() { }

	public static void setmNamePaint(string str) { }

	public static void setValueUpdate(int cur, int max) { }

	public virtual void update() { }

	public virtual void updatePointer() { }

}

