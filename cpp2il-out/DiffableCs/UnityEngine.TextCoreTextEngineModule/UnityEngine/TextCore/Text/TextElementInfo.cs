namespace UnityEngine.TextCore.Text;

internal struct TextElementInfo
{
	public char character; //Field offset: 0x0
	public int index; //Field offset: 0x4
	public TextElementType elementType; //Field offset: 0x8
	public int stringLength; //Field offset: 0xC
	public TextElement textElement; //Field offset: 0x10
	public Glyph alternativeGlyph; //Field offset: 0x18
	public FontAsset fontAsset; //Field offset: 0x20
	public SpriteAsset spriteAsset; //Field offset: 0x28
	public int spriteIndex; //Field offset: 0x30
	public Material material; //Field offset: 0x38
	public int materialReferenceIndex; //Field offset: 0x40
	public bool isUsingAlternateTypeface; //Field offset: 0x44
	public float pointSize; //Field offset: 0x48
	public int lineNumber; //Field offset: 0x4C
	public int pageNumber; //Field offset: 0x50
	public int vertexIndex; //Field offset: 0x54
	public TextVertex vertexTopLeft; //Field offset: 0x58
	public TextVertex vertexBottomLeft; //Field offset: 0x80
	public TextVertex vertexTopRight; //Field offset: 0xA8
	public TextVertex vertexBottomRight; //Field offset: 0xD0
	public Vector3 topLeft; //Field offset: 0xF8
	public Vector3 bottomLeft; //Field offset: 0x104
	public Vector3 topRight; //Field offset: 0x110
	public Vector3 bottomRight; //Field offset: 0x11C
	public float origin; //Field offset: 0x128
	public float ascender; //Field offset: 0x12C
	public float baseLine; //Field offset: 0x130
	public float descender; //Field offset: 0x134
	internal float adjustedAscender; //Field offset: 0x138
	internal float adjustedDescender; //Field offset: 0x13C
	internal float adjustedHorizontalAdvance; //Field offset: 0x140
	public float xAdvance; //Field offset: 0x144
	public float aspectRatio; //Field offset: 0x148
	public float scale; //Field offset: 0x14C
	public Color32 color; //Field offset: 0x150
	public Color32 underlineColor; //Field offset: 0x154
	public int underlineVertexIndex; //Field offset: 0x158
	public Color32 strikethroughColor; //Field offset: 0x15C
	public int strikethroughVertexIndex; //Field offset: 0x160
	public Color32 highlightColor; //Field offset: 0x164
	public HighlightState highlightState; //Field offset: 0x168
	public FontStyles style; //Field offset: 0x17C
	public bool isVisible; //Field offset: 0x180

	public virtual string ToString() { }

}

