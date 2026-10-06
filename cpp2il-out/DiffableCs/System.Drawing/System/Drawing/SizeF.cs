namespace System.Drawing;

public struct SizeF : IEquatable<SizeF>
{
	private float width; //Field offset: 0x0
	private float height; //Field offset: 0x4

	public float Height
	{
		 get { } //Length: 6
	}

	public float Width
	{
		 get { } //Length: 5
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(SizeF other) { }

	public float get_Height() { }

	public float get_Width() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SizeF sz1, SizeF sz2) { }

	public virtual string ToString() { }

}

