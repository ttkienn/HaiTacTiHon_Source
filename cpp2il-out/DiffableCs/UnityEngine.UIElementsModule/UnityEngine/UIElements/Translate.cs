namespace UnityEngine.UIElements;

public struct Translate : IEquatable<Translate>
{
	private Length m_X; //Field offset: 0x0
	private Length m_Y; //Field offset: 0x8
	private float m_Z; //Field offset: 0x10
	private bool m_isNone; //Field offset: 0x14

	public Length x
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Length y
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public float z
	{
		 get { } //Length: 6
	}

	public Translate(Length x, Length y, float z) { }

	public override bool Equals(Translate other) { }

	public virtual bool Equals(object obj) { }

	public Length get_x() { }

	public Length get_y() { }

	public float get_z() { }

	public virtual int GetHashCode() { }

	public static Translate None() { }

	public static bool op_Equality(Translate lhs, Translate rhs) { }

	public static bool op_Inequality(Translate lhs, Translate rhs) { }

	public void set_x(Length value) { }

	public void set_y(Length value) { }

	public virtual string ToString() { }

}

