//Type is in global namespace

public class Point_Focus
{
	public bool isSpeedUp; //Field offset: 0x10
	public sbyte Dir; //Field offset: 0x11
	public int x; //Field offset: 0x14
	public int y; //Field offset: 0x18
	public int dis; //Field offset: 0x1C
	public int fRe; //Field offset: 0x20
	public int f; //Field offset: 0x24
	public int frame; //Field offset: 0x28
	public int vx; //Field offset: 0x2C
	public int vy; //Field offset: 0x30
	public int toX; //Field offset: 0x34
	public int toY; //Field offset: 0x38
	public int maxdis; //Field offset: 0x3C
	public int vxMax; //Field offset: 0x40
	public int vyMax; //Field offset: 0x44
	public int goc; //Field offset: 0x48
	public int typeSpec; //Field offset: 0x4C
	public MainObject objMain; //Field offset: 0x50

	public Point_Focus(int x, int y, int toX, int toY, int maxdis) { }

	public Point_Focus(int x, int y) { }

	public Point_Focus() { }

	public void createNormal() { }

	public bool update() { }

	public void update_Vx_Vy() { }

}

