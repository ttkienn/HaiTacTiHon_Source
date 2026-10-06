namespace UnityEngine.TextCore.Text;

[Extension]
internal static class TextGeneratorUtilities
{
	public static readonly Vector2 largePositiveVector2; //Field offset: 0x0
	public static readonly Vector2 largeNegativeVector2; //Field offset: 0x8

	private static TextGeneratorUtilities() { }

	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) { }

	public static bool Approximately(float a, float b) { }

	public static float ConvertToFloat(Char[] chars, int startIndex, int length) { }

	public static float ConvertToFloat(Char[] chars, int startIndex, int length, out int lastIndex) { }

	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	private static byte GammaToLinear(byte value) { }

	internal static Color32 GammaToLinear(Color32 c) { }

	public static int GetAttributeParameters(Char[] chars, int startIndex, int length, ref Single[] parameters) { }

	public static int GetMarkupTagHashCode(UInt32[] styleDefinition, int readIndex) { }

	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) { }

	public static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	public static int GetStyleHashCode(ref UInt32[] text, int index, out int closeIndex) { }

	public static uint GetUTF16(TextBackingContainer text, int i) { }

	public static uint GetUTF16(UInt32[] text, int i) { }

	public static uint GetUTF32(UInt32[] text, int i) { }

	public static uint GetUTF32(TextBackingContainer text, int i) { }

	public static Color32 HexCharsToColor(Char[] hexChars, int tagCount) { }

	public static Color32 HexCharsToColor(Char[] hexChars, int startIndex, int length) { }

	public static uint HexToInt(char hex) { }

	internal static void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	internal static void InsertClosingTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	internal static void InsertOpeningStyleTag(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	internal static void InsertOpeningTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	private static void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, UInt32[] styleDefinition, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	public static bool IsBaseGlyph(uint c) { }

	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode) { }

	internal static bool IsCJK(uint c) { }

	internal static bool IsHangul(uint c) { }

	public static bool IsValidUTF16(TextBackingContainer text, int index) { }

	public static bool IsValidUTF32(TextBackingContainer text, int index) { }

	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) { }

	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) { }

	[Extension]
	public static Color MinAlpha(Color c1, Color c2) { }

	public static Vector2 PackUV(float x, float y, float scale) { }

	public static void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	private static bool ReplaceOpeningStyleTag(ref UInt32[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	public static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	public static void ResizeInternalArray(ref T[] array, int size) { }

	public static void ResizeInternalArray(ref T[] array) { }

	public static void ResizeLineExtents(int size, TextInfo textInfo) { }

	public static char ToUpperASCIIFast(char c) { }

	public static uint ToUpperASCIIFast(uint c) { }

	public static char ToUpperFast(char c) { }

}

