namespace UnityEngine.TextCore.Text;

internal class TextGenerationSettings : IEquatable<TextGenerationSettings>
{
	public string text; //Field offset: 0x10
	public Rect screenRect; //Field offset: 0x18
	public Vector4 margins; //Field offset: 0x28
	public float scale; //Field offset: 0x38
	public FontAsset fontAsset; //Field offset: 0x40
	public Material material; //Field offset: 0x48
	public SpriteAsset spriteAsset; //Field offset: 0x50
	public TextStyleSheet styleSheet; //Field offset: 0x58
	public FontStyles fontStyle; //Field offset: 0x60
	public TextSettings textSettings; //Field offset: 0x68
	public TextAlignment textAlignment; //Field offset: 0x70
	public TextOverflowMode overflowMode; //Field offset: 0x74
	public bool wordWrap; //Field offset: 0x78
	public float wordWrappingRatio; //Field offset: 0x7C
	public Color color; //Field offset: 0x80
	public TextColorGradient fontColorGradient; //Field offset: 0x90
	public TextColorGradient fontColorGradientPreset; //Field offset: 0x98
	public bool tintSprites; //Field offset: 0xA0
	public bool overrideRichTextColors; //Field offset: 0xA1
	public bool shouldConvertToLinearSpace; //Field offset: 0xA2
	public float fontSize; //Field offset: 0xA4
	public bool autoSize; //Field offset: 0xA8
	public float fontSizeMin; //Field offset: 0xAC
	public float fontSizeMax; //Field offset: 0xB0
	public bool enableKerning; //Field offset: 0xB4
	public bool richText; //Field offset: 0xB5
	public bool isRightToLeft; //Field offset: 0xB6
	public float extraPadding; //Field offset: 0xB8
	public bool parseControlCharacters; //Field offset: 0xBC
	public bool isOrthographic; //Field offset: 0xBD
	public bool tagNoParsing; //Field offset: 0xBE
	public float characterSpacing; //Field offset: 0xC0
	public float wordSpacing; //Field offset: 0xC4
	public float lineSpacing; //Field offset: 0xC8
	public float paragraphSpacing; //Field offset: 0xCC
	public float lineSpacingMax; //Field offset: 0xD0
	public TextWrappingMode textWrappingMode; //Field offset: 0xD4
	public int maxVisibleCharacters; //Field offset: 0xD8
	public int maxVisibleWords; //Field offset: 0xDC
	public int maxVisibleLines; //Field offset: 0xE0
	public int firstVisibleCharacter; //Field offset: 0xE4
	public bool useMaxVisibleDescender; //Field offset: 0xE8
	public TextFontWeight fontWeight; //Field offset: 0xEC
	public int pageToDisplay; //Field offset: 0xF0
	public TextureMapping horizontalMapping; //Field offset: 0xF4
	public TextureMapping verticalMapping; //Field offset: 0xF8
	public float uvLineOffset; //Field offset: 0xFC
	public VertexSortingOrder geometrySortingOrder; //Field offset: 0x100
	public bool inverseYAxis; //Field offset: 0x104
	public float charWidthMaxAdj; //Field offset: 0x108
	internal TextInputSource inputSource; //Field offset: 0x10C

	public TextGenerationSettings() { }

	public override bool Equals(TextGenerationSettings other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(TextGenerationSettings left, TextGenerationSettings right) { }

	public virtual string ToString() { }

}

