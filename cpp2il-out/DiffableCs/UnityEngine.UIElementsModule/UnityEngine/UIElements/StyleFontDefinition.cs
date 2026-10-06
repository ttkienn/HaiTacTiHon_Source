namespace UnityEngine.UIElements;

public struct StyleFontDefinition : IStyleValue<FontDefinition>, IEquatable<StyleFontDefinition>
{
	private StyleKeyword m_Keyword; //Field offset: 0x0
	private FontDefinition m_Value; //Field offset: 0x8

	public override StyleKeyword keyword
	{
		 get { } //Length: 5
	}

	public override FontDefinition value
	{
		 get { } //Length: 26
	}

	public StyleFontDefinition(FontDefinition f) { }

	internal StyleFontDefinition(FontDefinition f, StyleKeyword keyword) { }

	public override bool Equals(StyleFontDefinition other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override FontDefinition get_value() { }

	public virtual int GetHashCode() { }

	public static StyleFontDefinition op_Implicit(FontDefinition f) { }

}

