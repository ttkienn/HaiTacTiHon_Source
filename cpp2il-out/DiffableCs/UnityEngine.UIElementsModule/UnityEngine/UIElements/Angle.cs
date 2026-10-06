namespace UnityEngine.UIElements;

public struct Angle : IEquatable<Angle>
{
	private enum Unit
	{
		Degree = 0,
		Gradian = 1,
		Radian = 2,
		Turn = 3,
		None = 4,
	}

	private float m_Value; //Field offset: 0x0
	private Unit m_Unit; //Field offset: 0x4

	public float value
	{
		 get { } //Length: 5
	}

	public Angle(float value, AngleUnit unit) { }

	private Angle(float value, Unit unit) { }

	public override bool Equals(Angle other) { }

	public virtual bool Equals(object obj) { }

	public float get_value() { }

	public virtual int GetHashCode() { }

	internal static Angle None() { }

	public static bool op_Equality(Angle lhs, Angle rhs) { }

	public static Angle op_Implicit(float value) { }

	public float ToDegrees() { }

	public virtual string ToString() { }

}

