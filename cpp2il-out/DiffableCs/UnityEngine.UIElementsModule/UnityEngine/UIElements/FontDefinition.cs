namespace UnityEngine.UIElements;

public struct FontDefinition : IEquatable<FontDefinition>
{
	private Font m_Font; //Field offset: 0x0
	private FontAsset m_FontAsset; //Field offset: 0x8

	public Font font
	{
		 get { } //Length: 6
	}

	public FontAsset fontAsset
	{
		 get { } //Length: 7
	}

	public override bool Equals(FontDefinition other) { }

	public virtual bool Equals(object obj) { }

	public static FontDefinition FromFont(Font f) { }

	internal static FontDefinition FromObject(object obj) { }

	public static FontDefinition FromSDFFont(FontAsset f) { }

	public Font get_font() { }

	public FontAsset get_fontAsset() { }

	public virtual int GetHashCode() { }

	internal bool IsEmpty() { }

	public static bool op_Equality(FontDefinition left, FontDefinition right) { }

	public static bool op_Inequality(FontDefinition left, FontDefinition right) { }

	public virtual string ToString() { }

}

