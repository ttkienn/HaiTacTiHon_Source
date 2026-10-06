namespace UnityEngine.UIElements;

public struct StyleEnum : IStyleValue<T>, IEquatable<StyleEnum`1<T>>
{
	private T m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x0

	public override StyleKeyword keyword
	{
		 get { } //Length: 6
	}

	public override T value
	{
		 get { } //Length: 12
	}

	public StyleEnum`1(T v) { }

	public StyleEnum`1(StyleKeyword keyword) { }

	internal StyleEnum`1(T v, StyleKeyword keyword) { }

	public override bool Equals(StyleEnum<T> other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override T get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }

	public static StyleEnum<T> op_Implicit(StyleKeyword keyword) { }

	public static StyleEnum<T> op_Implicit(T v) { }

	public static bool op_Inequality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }

	public virtual string ToString() { }

}

