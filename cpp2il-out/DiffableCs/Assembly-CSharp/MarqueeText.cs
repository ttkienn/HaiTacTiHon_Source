//Type is in global namespace

public class MarqueeText
{
	public int limit; //Field offset: 0x10
	public int maxW; //Field offset: 0x14
	public int speed; //Field offset: 0x18
	public int xplus; //Field offset: 0x1C
	public int time; //Field offset: 0x20
	public string text; //Field offset: 0x28
	public bool isRun; //Field offset: 0x30
	public mFont fontPaint; //Field offset: 0x38
	public bool isLeftRight; //Field offset: 0x40

	public MarqueeText(int maxW) { }

	public int getxPlus() { }

	public void paint(mGraphics g, int x, int y, int align) { }

	public void setdata(string str, mFont font) { }

	public void update() { }

	public void update2() { }

}

