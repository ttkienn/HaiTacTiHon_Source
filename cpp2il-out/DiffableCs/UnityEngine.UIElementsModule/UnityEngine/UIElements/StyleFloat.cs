namespace UnityEngine.UIElements;

public struct StyleFloat : IStyleValue<Single>, IEquatable<StyleFloat>
{
	private float m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x4

	public override StyleKeyword keyword
	{
		 get { } //Length: 6
	}

	public override float value
	{
		 get { } //Length: 15
	}

	public StyleFloat(float v) { }

	public StyleFloat(StyleKeyword keyword) { }

	internal StyleFloat(float v, StyleKeyword keyword) { }

	public override bool Equals(StyleFloat other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override float get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	public static StyleFloat op_Implicit(StyleKeyword keyword) { }

	public static StyleFloat op_Implicit(float v) { }

	public virtual string ToString() { }

}

