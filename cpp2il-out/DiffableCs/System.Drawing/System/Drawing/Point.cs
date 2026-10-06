namespace System.Drawing;

public struct Point : IEquatable<Point>
{
	private int x; //Field offset: 0x0
	private int y; //Field offset: 0x4

	public int X
	{
		 get { } //Length: 3
	}

	public int Y
	{
		 get { } //Length: 4
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(Point other) { }

	public int get_X() { }

	public int get_Y() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Point left, Point right) { }

	public virtual string ToString() { }

}

