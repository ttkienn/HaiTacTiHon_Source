namespace UnityEngine.UIElements;

public struct Rotate : IEquatable<Rotate>
{
	private Angle m_Angle; //Field offset: 0x0
	private Vector3 m_Axis; //Field offset: 0x8
	private bool m_IsNone; //Field offset: 0x14

	public Angle angle
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	internal Vector3 axis
	{
		internal get { } //Length: 19
	}

	public Rotate(Angle angle) { }

	public override bool Equals(Rotate other) { }

	public virtual bool Equals(object obj) { }

	public Angle get_angle() { }

	internal Vector3 get_axis() { }

	public virtual int GetHashCode() { }

	internal static Rotate Initial() { }

	public static Rotate None() { }

	public static bool op_Equality(Rotate lhs, Rotate rhs) { }

	public static bool op_Inequality(Rotate lhs, Rotate rhs) { }

	public void set_angle(Angle value) { }

	internal Quaternion ToQuaternion() { }

	public virtual string ToString() { }

}

