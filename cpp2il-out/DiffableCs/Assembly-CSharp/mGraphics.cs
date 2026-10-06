//Type is in global namespace

public class mGraphics
{
	public static int HCENTER; //Field offset: 0x0
	public const int TRANS_ROT90 = 5; //Field offset: 0x0
	public const int TRANS_ROT270 = 6; //Field offset: 0x0
	public const int TRANS_ROT180 = 3; //Field offset: 0x0
	public const int TRANS_NONE = 0; //Field offset: 0x0
	public const int TRANS_MIRROR_ROT90 = 7; //Field offset: 0x0
	public const int TRANS_MIRROR_ROT270 = 4; //Field offset: 0x0
	public const int TRANS_MIRROR_ROT180 = 1; //Field offset: 0x0
	public const int TRANS_MIRROR = 2; //Field offset: 0x0
	public const int DOTTED = 1; //Field offset: 0x0
	public const int BASELINE = 64; //Field offset: 0x0
	public const int SOLID = 0; //Field offset: 0x0
	public static int VCENTER; //Field offset: 0x4
	public static int LEFT; //Field offset: 0x8
	public static int RIGHT; //Field offset: 0xC
	public static int TOP; //Field offset: 0x10
	public static int BOTTOM; //Field offset: 0x14
	public static int zoomLevel; //Field offset: 0x18
	public static Hashtable cachedTextures; //Field offset: 0x20
	public static int addYWhenOpenKeyBoard; //Field offset: 0x28
	public static Color transParentColor; //Field offset: 0x2C
	private float r; //Field offset: 0x10
	private float g; //Field offset: 0x14
	private float b; //Field offset: 0x18
	private float a; //Field offset: 0x1C
	public int clipX; //Field offset: 0x20
	public int clipY; //Field offset: 0x24
	public int clipW; //Field offset: 0x28
	public int clipH; //Field offset: 0x2C
	private bool isClip; //Field offset: 0x30
	private bool isTranslate; //Field offset: 0x31
	private int translateX; //Field offset: 0x34
	private int translateY; //Field offset: 0x38
	private float translateXf; //Field offset: 0x3C
	private float translateYf; //Field offset: 0x40
	private int clipTX; //Field offset: 0x44
	private int clipTY; //Field offset: 0x48
	private int currentBGColor; //Field offset: 0x4C
	private Vector2 pos; //Field offset: 0x50
	private Rect rect; //Field offset: 0x58
	private Matrix4x4 matrixBackup; //Field offset: 0x68
	private Vector2 pivot; //Field offset: 0xA8
	public Vector2 size; //Field offset: 0xB0
	public Vector2 relativePosition; //Field offset: 0xB8
	private Material lineMaterial; //Field offset: 0xC0

	public void __drawRegion(Image image, int x0, int y0, int w, int h, int transform, float x, float y, int anchor) { }

	public void _drawRegion(Image image, float x0, float y0, int w, int h, int transform, int x, int y, int anchor) { }

	private static mGraphics() { }

	public mGraphics() { }

	public static Image blend(Image img0, float level, int rgb) { }

	public static int blendColor(float level, int color, int colorBlend) { }

	private void cache(string key, Texture value) { }

	public void ClipRec(int x, int i, int win, int hcur) { }

	[Obsolete]
	public void CreateLineMaterial() { }

	public void drawArc(int x, int y, int w, int h, int a, int b, bool isA) { }

	public void drawImagaByDrawTexture(Image image, float x, float y) { }

	public void drawImage(mImage image, int x, int y, int anchor) { }

	public void drawImageScale(Image image, int x, int y, int w, int h, int tranform) { }

	public void drawImageSimple(Image image, int x, int y) { }

	public void drawLine(mGraphics g, int x, int y, int xTo, int yTo, int nLine, int color) { }

	public void drawLine(int x1, int y1, int x2, int y2, bool isA) { }

	public void drawLine(int x1, int y1, int x2, int y2) { }

	public void drawlineGL(mVector totalLine) { }

	public void drawRecAlpa(int x, int y, int w, int h, int color) { }

	public void drawRect(int x, int y, int w, int h, bool isA) { }

	public void drawRect(int x, int y, int w, int h) { }

	public void drawRegion(Image arg0, int x0, int y0, int w0, int h0, int arg5, int x, int y, int arg8) { }

	public void drawRegion(mImage arg0, int x0, int y0, int w0, int h0, int arg5, float x, float y, int arg8) { }

	public void drawRegion(Image arg0, int x0, int y0, int w0, int h0, int arg5, int x, int y, int arg8, bool isA) { }

	public void drawRegion2(Image image, float x0, float y0, int w, int h, int transform, int x, int y, int anchor) { }

	public void drawRoundRect(int x, int y, int w, int h, int arcWidth, int arcHeight) { }

	public void drawString(string s, int x, int y, GUIStyle style, int w) { }

	public void drawString(string s, int x, int y, int archor) { }

	public void drawString(string s, int x, int y, GUIStyle style) { }

	public void fillArc(int x, int y, int w, int h, int a, int b, bool isSetClip) { }

	public void fillArg(int i, int j, int k, int l, int m, int n) { }

	public void fillRecAlpla(int x, int y, int w, int h, int color) { }

	public void fillRect(int x, int y, int w, int h, bool isA) { }

	public void fillRect(int x, int y, int w, int h, int color, int alpha) { }

	public void fillRect(int x, int y, int w, int h) { }

	public void fillRoundRect(int x, int y, int width, int height, int arcWidth, int arcHeight) { }

	public void fillTrans(Image imgTrans, int x, int y, int w, int h) { }

	public static int getImageHeight(Image image) { }

	public static int getImageWidth(Image image) { }

	public static int getIntByColor(Color cl) { }

	public static int getRealImageHeight(Image img) { }

	public static int getRealImageWidth(Image img) { }

	public Single[] getRGB(Color cl) { }

	public int getTranslateX() { }

	public int getTranslateY() { }

	public Rect intersectRect(Rect r1, Rect r2) { }

	public static bool isNotTranColor(Color color) { }

	public void reset() { }

	public static void resetTransAndroid(mGraphics g2) { }

	public void restoreCanvas() { }

	public void saveCanvas() { }

	public void setBgColor(int rgb) { }

	public void setClip(int x, int y, int w, int h) { }

	public void setColor(int rgb) { }

	public void setColor(Color color) { }

	public void setColor(int rgb, float alpha) { }

	public Color setColorMiniMap(int rgb) { }

	public static Color setColorObj(int rgb) { }

	public void translate(float x, float y) { }

	public void translate(int tx, int ty) { }

	private void UpdatePos(int anchor) { }

}

