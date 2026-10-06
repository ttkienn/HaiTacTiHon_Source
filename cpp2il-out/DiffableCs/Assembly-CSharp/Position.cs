//Type is in global namespace

public class Position
{
	public int x; //Field offset: 0x10
	public int y; //Field offset: 0x14
	public int anchor; //Field offset: 0x18
	public sbyte depth; //Field offset: 0x1C
	public short index; //Field offset: 0x1E

	public Position() { }

	public Position(int x, int y) { }

	public Position(int x, int y, int anchor) { }

	public bool setDetectX(int xx, int num) { }

	public bool setDetectY(int yy, int num) { }

}

