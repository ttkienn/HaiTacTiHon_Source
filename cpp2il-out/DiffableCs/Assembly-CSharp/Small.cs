//Type is in global namespace

public class Small
{
	public mImage img; //Field offset: 0x10
	public int id; //Field offset: 0x18
	public int wimg; //Field offset: 0x1C
	public int himg; //Field offset: 0x20
	public int timePaint; //Field offset: 0x24
	public int timeUpdate; //Field offset: 0x28

	public Small(mImage img, int id) { }

	public void paint(mGraphics g, int transform, int x, int y, int anchor) { }

	public void update() { }

}

