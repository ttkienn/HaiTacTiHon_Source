//Type is in global namespace

public class Image
{
	private const int INTERVAL = 5; //Field offset: 0x0
	private const int MAXTIME = 500; //Field offset: 0x0
	public static Image imgTemp; //Field offset: 0x0
	public static string filenametemp; //Field offset: 0x8
	public static Byte[] datatemp; //Field offset: 0x10
	public static Image imgSrcTemp; //Field offset: 0x18
	public static int xtemp; //Field offset: 0x20
	public static int ytemp; //Field offset: 0x24
	public static int wtemp; //Field offset: 0x28
	public static int htemp; //Field offset: 0x2C
	public static int transformtemp; //Field offset: 0x30
	public static int status; //Field offset: 0x34
	public static int iA; //Field offset: 0x38
	public Texture2D texture; //Field offset: 0x10
	public int w; //Field offset: 0x18
	public int h; //Field offset: 0x1C
	public Color colorBlend; //Field offset: 0x20

	private static Image __createEmptyImage() { }

	public static Image __createImage(int w, int h) { }

	private static Image __createImage(Image src, int x, int y, int w, int h, int transform) { }

	private static Image __createImage(Byte[] imageData) { }

	private static Image __createImage(string filename) { }

	private static Image __createImageX(string filename) { }

	private static Image _createEmptyImage() { }

	private static Image _createImage(int w, int h) { }

	private static Image _createImage(Image src, int x, int y, int w, int h, int transform) { }

	private static Image _createImage(Byte[] imageData) { }

	private static Image _createImage(string filename) { }

	private static Image _createImageX(string filename) { }

	public Image() { }

	public static Byte[] convertArrSbyteToArrByte(SByte[] var) { }

	public static byte convertSbyteToByte(sbyte var) { }

	public static Image createEmptyImage() { }

	public static Image createImage(SByte[] imageData, int offset, int lenght) { }

	public static Image createImage(Image img) { }

	public static Image createImage(int w, int h) { }

	public static Image createImage(string path) { }

	public static Image createImage(Image src, int x, int y, int w, int h, int transform) { }

	public static Image createImage(Byte[] imageData) { }

	public static Image createImageUni(string filename) { }

	public static Image createImageX(string filename) { }

	public static Image createRGBImage(Int32[] rbg, int w, int h, bool bl) { }

	public static string cutPng(string str) { }

	public Color[] getColor() { }

	public static Color getColor(int rgb) { }

	public int getHeight() { }

	public static int getImageHeight(Image image) { }

	public static int getImageWidth(Image image) { }

	public static int getIntByColor(Color cl) { }

	public int getRealImageHeight() { }

	public int getRealImageWidth() { }

	public void getRGB(ref Int32[] data, int x1, int x2, int x, int y, int w, int h) { }

	public int getWidth() { }

	public static Byte[] loadData(string filename) { }

	public static Color setColorFromRBG(int rgb) { }

	private static void setTextureQuality(Image img) { }

	public static void setTextureQuality(Texture2D texture) { }

	public static void update() { }

}

