//Type is in global namespace

public class Scroll
{
	public static int hRectScroll; //Field offset: 0x0
	public static int maxRectScroll; //Field offset: 0x4
	private int x; //Field offset: 0x10
	private int y; //Field offset: 0x14
	private int h; //Field offset: 0x18
	private int color; //Field offset: 0x1C
	private int yScroll; //Field offset: 0x20
	private int hScroll; //Field offset: 0x24
	private int hEffScroll; //Field offset: 0x28

	private static Scroll() { }

	public Scroll() { }

	public void paint(mGraphics g) { }

	public void sethEff() { }

	public void setInfo(int x, int y, int h, int color) { }

	public void setYScrool(int yS, int yMax) { }

}

