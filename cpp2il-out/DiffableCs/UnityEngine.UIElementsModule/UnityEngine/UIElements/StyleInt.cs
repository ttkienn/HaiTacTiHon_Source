namespace UnityEngine.UIElements;

public struct StyleInt : IStyleValue<Int32>, IEquatable<StyleInt>
{
	private int m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x4

	public override StyleKeyword keyword
	{
		 get { } //Length: 6
	}

	public override int value
	{
		 get { } //Length: 12
	}

	public StyleInt(StyleKeyword keyword) { }

	internal StyleInt(int v, StyleKeyword keyword) { }

	public override bool Equals(StyleInt other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override int get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	public static StyleInt op_Implicit(StyleKeyword keyword) { }

	public virtual string ToString() { }

}

