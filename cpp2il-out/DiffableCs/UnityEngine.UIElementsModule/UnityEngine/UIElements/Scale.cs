namespace UnityEngine.UIElements;

public struct Scale : IEquatable<Scale>
{
	private Vector3 m_Scale; //Field offset: 0x0
	private bool m_IsNone; //Field offset: 0xC

	public Vector3 value
	{
		 get { } //Length: 18
	}

	public Scale(Vector3 scale) { }

	public override bool Equals(Scale other) { }

	public virtual bool Equals(object obj) { }

	public Vector3 get_value() { }

	public virtual int GetHashCode() { }

	internal static Scale Initial() { }

	public static Scale None() { }

	public static bool op_Equality(Scale lhs, Scale rhs) { }

	public static bool op_Inequality(Scale lhs, Scale rhs) { }

	public virtual string ToString() { }

}

