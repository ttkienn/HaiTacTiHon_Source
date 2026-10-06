namespace System.Drawing;

public struct RectangleF : IEquatable<RectangleF>
{
	private float x; //Field offset: 0x0
	private float y; //Field offset: 0x4
	private float width; //Field offset: 0x8
	private float height; //Field offset: 0xC

	public float Height
	{
		 get { } //Length: 6
	}

	public float Width
	{
		 get { } //Length: 6
	}

	public float X
	{
		 get { } //Length: 5
	}

	public float Y
	{
		 get { } //Length: 6
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(RectangleF other) { }

	public float get_Height() { }

	public float get_Width() { }

	public float get_X() { }

	public float get_Y() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(RectangleF left, RectangleF right) { }

	public virtual string ToString() { }

}

