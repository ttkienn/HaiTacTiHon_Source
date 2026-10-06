namespace UnityEngine.UIElements.StyleSheets;

internal struct Dimension : IEquatable<Dimension>
{
	internal enum Unit
	{
		Unitless = 0,
		Pixel = 1,
		Percent = 2,
		Second = 3,
		Millisecond = 4,
		Degree = 5,
		Gradian = 6,
		Radian = 7,
		Turn = 8,
	}

	public Unit unit; //Field offset: 0x0
	public float value; //Field offset: 0x4

	public Dimension(float value, Unit unit) { }

	public override bool Equals(Dimension other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Dimension lhs, Dimension rhs) { }

	public Angle ToAngle() { }

	public Length ToLength() { }

	public virtual string ToString() { }

	public TimeValue ToTime() { }

}

