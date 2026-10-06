namespace System.Drawing;

public struct Rectangle : IEquatable<Rectangle>
{
	private int x; //Field offset: 0x0
	private int y; //Field offset: 0x4
	private int width; //Field offset: 0x8
	private int height; //Field offset: 0xC

	public int Height
	{
		 get { } //Length: 4
	}

	public int Width
	{
		 get { } //Length: 4
	}

	public int X
	{
		 get { } //Length: 3
	}

	public int Y
	{
		 get { } //Length: 4
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(Rectangle other) { }

	public int get_Height() { }

	public int get_Width() { }

	public int get_X() { }

	public int get_Y() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Rectangle left, Rectangle right) { }

	public virtual string ToString() { }

}

