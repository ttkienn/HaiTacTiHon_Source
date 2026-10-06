namespace System.Drawing;

public struct Size : IEquatable<Size>
{
	private int width; //Field offset: 0x0
	private int height; //Field offset: 0x4

	public int Height
	{
		 get { } //Length: 4
	}

	public int Width
	{
		 get { } //Length: 3
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(Size other) { }

	public int get_Height() { }

	public int get_Width() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Size sz1, Size sz2) { }

	public virtual string ToString() { }

}

