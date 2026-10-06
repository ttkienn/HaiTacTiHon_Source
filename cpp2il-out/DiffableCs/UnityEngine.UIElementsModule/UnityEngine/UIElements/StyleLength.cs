namespace UnityEngine.UIElements;

public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength>
{
	private Length m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x8

	public override StyleKeyword keyword
	{
		 get { } //Length: 6
	}

	public override Length value
	{
		 get { } //Length: 25
	}

	public StyleLength(float v) { }

	public StyleLength(Length v) { }

	public StyleLength(StyleKeyword keyword) { }

	internal StyleLength(Length v, StyleKeyword keyword) { }

	public override bool Equals(StyleLength other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override Length get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	public static StyleLength op_Implicit(StyleKeyword keyword) { }

	public static StyleLength op_Implicit(float v) { }

	public static StyleLength op_Implicit(Length v) { }

	public virtual string ToString() { }

}

