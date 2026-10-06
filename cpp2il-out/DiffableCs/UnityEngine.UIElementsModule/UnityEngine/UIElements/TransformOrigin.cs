namespace UnityEngine.UIElements;

public struct TransformOrigin : IEquatable<TransformOrigin>
{
	private Length m_X; //Field offset: 0x0
	private Length m_Y; //Field offset: 0x8
	private float m_Z; //Field offset: 0x10

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

	public TransformOrigin(Length x, Length y, float z) { }

	public override bool Equals(TransformOrigin other) { }

	public virtual bool Equals(object obj) { }

	public Length get_x() { }

	public Length get_y() { }

	public float get_z() { }

	public virtual int GetHashCode() { }

	public static TransformOrigin Initial() { }

	public static bool op_Equality(TransformOrigin lhs, TransformOrigin rhs) { }

	public static bool op_Inequality(TransformOrigin lhs, TransformOrigin rhs) { }

	public void set_x(Length value) { }

	public void set_y(Length value) { }

	public virtual string ToString() { }

}

