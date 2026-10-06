namespace System.Drawing;

public struct PointF : IEquatable<PointF>
{
	private float x; //Field offset: 0x0
	private float y; //Field offset: 0x4

	public float X
	{
		 get { } //Length: 5
	}

	public float Y
	{
		 get { } //Length: 6
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(PointF other) { }

	public float get_X() { }

	public float get_Y() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(PointF left, PointF right) { }

	public virtual string ToString() { }

}

