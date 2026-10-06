namespace UnityEngine.UIElements;

public struct TimeValue : IEquatable<TimeValue>
{
	private float m_Value; //Field offset: 0x0
	private TimeUnit m_Unit; //Field offset: 0x4

	public TimeUnit unit
	{
		 get { } //Length: 4
	}

	public float value
	{
		 get { } //Length: 5
	}

	public TimeValue(float value) { }

	public TimeValue(float value, TimeUnit unit) { }

	public override bool Equals(TimeValue other) { }

	public virtual bool Equals(object obj) { }

	public TimeUnit get_unit() { }

	public float get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(TimeValue lhs, TimeValue rhs) { }

	public static TimeValue op_Implicit(float value) { }

	public static bool op_Inequality(TimeValue lhs, TimeValue rhs) { }

	public virtual string ToString() { }

}

