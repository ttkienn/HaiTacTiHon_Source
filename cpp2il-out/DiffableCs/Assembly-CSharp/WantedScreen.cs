//Type is in global namespace

public class WantedScreen : MainScreen
{
	public static WantedScreen instance; //Field offset: 0x0
	private sbyte page; //Field offset: 0x50
	private sbyte maxpage; //Field offset: 0x51
	private iCommand cmdClose; //Field offset: 0x58
	private int x; //Field offset: 0x60
	private int y; //Field offset: 0x64
	private int w; //Field offset: 0x68
	private int h; //Field offset: 0x6C
	private int idSelect; //Field offset: 0x70
	private mVector vecList; //Field offset: 0x78

	public WantedScreen() { }

	public WantedScreen(mVector vec, sbyte page, sbyte maxpage) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void paintBg(mGraphics g, int xpaint, int ypaint) { }

	public static void paintInfo(mGraphics g, InfoMemList mem, int xpaint, int ypaint, int wpaint, int hpaint) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

