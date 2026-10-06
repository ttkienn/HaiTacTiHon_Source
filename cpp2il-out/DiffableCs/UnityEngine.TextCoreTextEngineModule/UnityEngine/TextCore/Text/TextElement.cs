namespace UnityEngine.TextCore.Text;

public abstract class TextElement
{
	[SerializeField]
	protected TextElementType m_ElementType; //Field offset: 0x10
	[SerializeField]
	internal uint m_Unicode; //Field offset: 0x14
	internal TextAsset m_TextAsset; //Field offset: 0x18
	internal Glyph m_Glyph; //Field offset: 0x20
	[SerializeField]
	internal uint m_GlyphIndex; //Field offset: 0x28
	[SerializeField]
	internal float m_Scale; //Field offset: 0x2C

	public TextElementType elementType
	{
		 get { } //Length: 7
	}

	public Glyph glyph
	{
		 get { } //Length: 7
		 set { } //Length: 13
	}

	public uint glyphIndex
	{
		 get { } //Length: 1817
		 set { } //Length: 4
	}

	public float scale
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public TextAsset textAsset
	{
		 get { } //Length: 7
		 set { } //Length: 13
	}

	public uint unicode
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	protected TextElement() { }

	public TextElementType get_elementType() { }

	public Glyph get_glyph() { }

	public uint get_glyphIndex() { }

	public float get_scale() { }

	public TextAsset get_textAsset() { }

	public uint get_unicode() { }

	public void set_glyph(Glyph value) { }

	public void set_glyphIndex(uint value) { }

	public void set_scale(float value) { }

	public void set_textAsset(TextAsset value) { }

	public void set_unicode(uint value) { }

}

