namespace UnityEngine.UIElements;

public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor>
{
	private Color m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x10

	public override StyleKeyword keyword
	{
		 get { } //Length: 6
	}

	public override Color value
	{
		 get { } //Length: 26
	}

	public StyleColor(Color v) { }

	internal StyleColor(Color v, StyleKeyword keyword) { }

	public override bool Equals(StyleColor other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override Color get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	public static StyleColor op_Implicit(Color v) { }

	public virtual string ToString() { }

}

