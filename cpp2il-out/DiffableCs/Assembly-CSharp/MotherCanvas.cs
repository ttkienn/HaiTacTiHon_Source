//Type is in global namespace

public class MotherCanvas
{
	public static MotherCanvas instance; //Field offset: 0x0
	public static int w; //Field offset: 0x8
	public static int h; //Field offset: 0xC
	public static int hw; //Field offset: 0x10
	public static int hh; //Field offset: 0x14
	public static int w4; //Field offset: 0x18
	public static int h4; //Field offset: 0x1C
	public GameCanvas tCanvas; //Field offset: 0x10
	public int zoomLevel; //Field offset: 0x18
	public Image imgCache; //Field offset: 0x20
	private Int32[] imgRGBCache; //Field offset: 0x28
	private int newWidth; //Field offset: 0x30
	private int newHeight; //Field offset: 0x34
	private Int32[] output; //Field offset: 0x38
	private int OUTPUTSIZE; //Field offset: 0x40

	public MotherCanvas() { }

	public MotherCanvas(Context context) { }

	public void checkZoomLevel() { }

	public int getHeight() { }

	public int getHeightz() { }

	public int getWidth() { }

	public int getWidthz() { }

	public bool hasPointerEvents() { }

	public override void keyPressed(int keyCode) { }

	public bool keyPressPc(int keycode) { }

	public override void keyReleased(int keyCode) { }

	public bool keyReleasedPc(int keycode) { }

	public override void paint(mGraphics g) { }

	public void pointerDragged(int x, int y) { }

	public void pointerPressed(int x, int y) { }

	public void pointerReleased(int x, int y) { }

	public void setChildCanvas(GameCanvas tCanvas) { }

	public override void update() { }

}

