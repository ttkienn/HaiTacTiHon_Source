namespace UnityEngine.UIElements;

public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont>
{
	private Font m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x8

	public override StyleKeyword keyword
	{
		 get { } //Length: 6
	}

	public override Font value
	{
		 get { } //Length: 13
	}

	public StyleFont(Font v) { }

	internal StyleFont(Font v, StyleKeyword keyword) { }

	public override bool Equals(StyleFont other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override Font get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	public static StyleFont op_Implicit(Font v) { }

	public virtual string ToString() { }

}

