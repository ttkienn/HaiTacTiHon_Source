namespace UnityEngine.TextCore.Text;

internal struct WordWrapState
{
	public int previousWordBreak; //Field offset: 0x0
	public int totalCharacterCount; //Field offset: 0x4
	public int visibleCharacterCount; //Field offset: 0x8
	public int visibleSpaceCount; //Field offset: 0xC
	public int visibleSpriteCount; //Field offset: 0x10
	public int visibleLinkCount; //Field offset: 0x14
	public int firstCharacterIndex; //Field offset: 0x18
	public int firstVisibleCharacterIndex; //Field offset: 0x1C
	public int lastCharacterIndex; //Field offset: 0x20
	public int lastVisibleCharIndex; //Field offset: 0x24
	public int lineNumber; //Field offset: 0x28
	public float maxCapHeight; //Field offset: 0x2C
	public float maxAscender; //Field offset: 0x30
	public float maxDescender; //Field offset: 0x34
	public float maxLineAscender; //Field offset: 0x38
	public float maxLineDescender; //Field offset: 0x3C
	public float startOfLineAscender; //Field offset: 0x40
	public float xAdvance; //Field offset: 0x44
	public float preferredWidth; //Field offset: 0x48
	public float preferredHeight; //Field offset: 0x4C
	public float previousLineScale; //Field offset: 0x50
	public float pageAscender; //Field offset: 0x54
	public int wordCount; //Field offset: 0x58
	public FontStyles fontStyle; //Field offset: 0x5C
	public float fontScale; //Field offset: 0x60
	public float fontScaleMultiplier; //Field offset: 0x64
	public int italicAngle; //Field offset: 0x68
	public float currentFontSize; //Field offset: 0x6C
	public float baselineOffset; //Field offset: 0x70
	public float lineOffset; //Field offset: 0x74
	public TextInfo textInfo; //Field offset: 0x78
	public LineInfo lineInfo; //Field offset: 0x80
	public Color32 vertexColor; //Field offset: 0xE0
	public Color32 underlineColor; //Field offset: 0xE4
	public Color32 strikethroughColor; //Field offset: 0xE8
	public Color32 highlightColor; //Field offset: 0xEC
	public HighlightState highlightState; //Field offset: 0xF0
	public FontStyleStack basicStyleStack; //Field offset: 0x104
	public TextProcessingStack<Int32> italicAngleStack; //Field offset: 0x110
	public TextProcessingStack<Color32> colorStack; //Field offset: 0x130
	public TextProcessingStack<Color32> underlineColorStack; //Field offset: 0x150
	public TextProcessingStack<Color32> strikethroughColorStack; //Field offset: 0x170
	public TextProcessingStack<Color32> highlightColorStack; //Field offset: 0x190
	public TextProcessingStack<HighlightState> highlightStateStack; //Field offset: 0x1B0
	public TextProcessingStack<TextColorGradient> colorGradientStack; //Field offset: 0x1E0
	public TextProcessingStack<Single> sizeStack; //Field offset: 0x208
	public TextProcessingStack<Single> indentStack; //Field offset: 0x228
	public TextProcessingStack<TextFontWeight> fontWeightStack; //Field offset: 0x248
	public TextProcessingStack<Int32> styleStack; //Field offset: 0x268
	public TextProcessingStack<Single> baselineStack; //Field offset: 0x288
	public TextProcessingStack<Int32> actionStack; //Field offset: 0x2A8
	public TextProcessingStack<MaterialReference> materialReferenceStack; //Field offset: 0x2C8
	public TextProcessingStack<TextAlignment> lineJustificationStack; //Field offset: 0x320
	public int lastBaseGlyphIndex; //Field offset: 0x340
	public int spriteAnimationId; //Field offset: 0x344
	public FontAsset currentFontAsset; //Field offset: 0x348
	public SpriteAsset currentSpriteAsset; //Field offset: 0x350
	public Material currentMaterial; //Field offset: 0x358
	public int currentMaterialIndex; //Field offset: 0x360
	public Extents meshExtents; //Field offset: 0x364
	public bool tagNoParsing; //Field offset: 0x374
	public bool isNonBreakingSpace; //Field offset: 0x375
	public bool isDrivenLineSpacing; //Field offset: 0x376
	public Vector3 fxScale; //Field offset: 0x378
	public Quaternion fxRotation; //Field offset: 0x384

}

