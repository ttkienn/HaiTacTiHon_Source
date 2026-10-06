namespace UnityEngine.UIElements;

public struct Length : IEquatable<Length>
{
	private enum Unit
	{
		Pixel = 0,
		Percent = 1,
		Auto = 2,
		None = 3,
	}

	internal const float k_MaxValue = 8388608; //Field offset: 0x0
	[SerializeField]
	private float m_Value; //Field offset: 0x0
	[SerializeField]
	private Unit m_Unit; //Field offset: 0x4

	public LengthUnit unit
	{
		 get { } //Length: 4
	}

	public float value
	{
		 get { } //Length: 5
		 set { } //Length: 36
	}

	public Length(float value) { }

	public Length(float value, LengthUnit unit) { }

	private Length(float value, Unit unit) { }

	public static Length Auto() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(Length other) { }

	public LengthUnit get_unit() { }

	public float get_value() { }

	public virtual int GetHashCode() { }

	public bool IsAuto() { }

	public bool IsNone() { }

	public static Length None() { }

	public static bool op_Equality(Length lhs, Length rhs) { }

	public static Length op_Implicit(float value) { }

	public static bool op_Inequality(Length lhs, Length rhs) { }

	public static Length Percent(float value) { }

	public void set_value(float value) { }

	public virtual string ToString() { }

}

