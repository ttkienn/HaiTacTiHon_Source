namespace UnityEngine.UIElements;

public struct StyleCursor : IStyleValue<Cursor>, IEquatable<StyleCursor>
{
	private Cursor m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x18

	public override StyleKeyword keyword
	{
		 get { } //Length: 6
	}

	public override Cursor value
	{
		 get { } //Length: 66
	}

	public StyleCursor(StyleKeyword keyword) { }

	internal StyleCursor(Cursor v, StyleKeyword keyword) { }

	public override bool Equals(StyleCursor other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override Cursor get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleCursor lhs, StyleCursor rhs) { }

	public static StyleCursor op_Implicit(StyleKeyword keyword) { }

	public virtual string ToString() { }

}

