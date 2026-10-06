//Type is in global namespace

public class Line
{
	public int x0; //Field offset: 0x10
	public int y0; //Field offset: 0x14
	public int x1; //Field offset: 0x18
	public int y1; //Field offset: 0x1C
	public int vx; //Field offset: 0x20
	public int vy; //Field offset: 0x24
	public int f; //Field offset: 0x28
	public int fRe; //Field offset: 0x2C
	public int idColor; //Field offset: 0x30
	public int type; //Field offset: 0x34
	public bool is2Line; //Field offset: 0x38

	public Line() { }

	public void setLine(int x0, int y0, int x1, int y1, int vx, int vy, bool is2Line) { }

	public void update() { }

}

