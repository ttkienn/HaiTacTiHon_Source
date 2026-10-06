namespace UnityEngine.UIElements;

public struct StyleBackgroundSize : IStyleValue<BackgroundSize>, IEquatable<StyleBackgroundSize>
{
	private BackgroundSize m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x14

	public override StyleKeyword keyword
	{
		 get { } //Length: 6
	}

	public override BackgroundSize value
	{
		 get { } //Length: 37
	}

	public StyleBackgroundSize(StyleKeyword keyword) { }

	internal StyleBackgroundSize(BackgroundSize v, StyleKeyword keyword) { }

	public override bool Equals(StyleBackgroundSize other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override BackgroundSize get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleBackgroundSize lhs, StyleBackgroundSize rhs) { }

	public static StyleBackgroundSize op_Implicit(StyleKeyword keyword) { }

	public virtual string ToString() { }

}

