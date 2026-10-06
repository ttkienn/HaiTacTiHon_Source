namespace UnityEngine.TextCore.Text;

internal struct Offset
{
	private static readonly Offset k_ZeroOffset; //Field offset: 0x0
	private float m_Left; //Field offset: 0x0
	private float m_Right; //Field offset: 0x4
	private float m_Top; //Field offset: 0x8
	private float m_Bottom; //Field offset: 0xC

	public float bottom
	{
		 get { } //Length: 8
	}

	public float left
	{
		 get { } //Length: 7
	}

	public float right
	{
		 get { } //Length: 8
	}

	public float top
	{
		 get { } //Length: 8
	}

	public static Offset zero
	{
		 get { } //Length: 96
	}

	private static Offset() { }

	public Offset(float left, float right, float top, float bottom) { }

	public virtual bool Equals(object obj) { }

	public float get_bottom() { }

	public float get_left() { }

	public float get_right() { }

	public float get_top() { }

	public static Offset get_zero() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Offset lhs, Offset rhs) { }

	public static Offset op_Multiply(Offset a, float b) { }

}

