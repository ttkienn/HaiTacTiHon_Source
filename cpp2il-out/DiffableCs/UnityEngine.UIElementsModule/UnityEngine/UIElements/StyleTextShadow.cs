namespace UnityEngine.UIElements;

public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow>
{
	private StyleKeyword m_Keyword; //Field offset: 0x0
	private TextShadow m_Value; //Field offset: 0x4

	public override StyleKeyword keyword
	{
		 get { } //Length: 5
	}

	public override TextShadow value
	{
		 get { } //Length: 75
	}

	public StyleTextShadow(StyleKeyword keyword) { }

	internal StyleTextShadow(TextShadow v, StyleKeyword keyword) { }

	public override bool Equals(StyleTextShadow other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override TextShadow get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleTextShadow lhs, StyleTextShadow rhs) { }

	public static StyleTextShadow op_Implicit(StyleKeyword keyword) { }

	public virtual string ToString() { }

}

