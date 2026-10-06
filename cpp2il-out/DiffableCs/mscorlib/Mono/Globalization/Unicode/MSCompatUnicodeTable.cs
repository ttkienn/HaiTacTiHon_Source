namespace Mono.Globalization.Unicode;

internal class MSCompatUnicodeTable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Level2Map> <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b) { }

	}

	public static int MaxExpansionLength; //Field offset: 0x0
	private static readonly Byte* ignorableFlags; //Field offset: 0x8
	private static readonly Byte* categories; //Field offset: 0x10
	private static readonly Byte* level1; //Field offset: 0x18
	private static readonly Byte* level2; //Field offset: 0x20
	private static readonly Byte* level3; //Field offset: 0x28
	private static Byte* cjkCHScategory; //Field offset: 0x30
	private static Byte* cjkCHTcategory; //Field offset: 0x38
	private static Byte* cjkJAcategory; //Field offset: 0x40
	private static Byte* cjkKOcategory; //Field offset: 0x48
	private static Byte* cjkCHSlv1; //Field offset: 0x50
	private static Byte* cjkCHTlv1; //Field offset: 0x58
	private static Byte* cjkJAlv1; //Field offset: 0x60
	private static Byte* cjkKOlv1; //Field offset: 0x68
	private static Byte* cjkKOlv2; //Field offset: 0x70
	private static readonly Char[] tailoringArr; //Field offset: 0x78
	private static readonly TailoringInfo[] tailoringInfos; //Field offset: 0x80
	private static object forLock; //Field offset: 0x88
	public static readonly bool isReady; //Field offset: 0x90

	public static bool IsReady
	{
		 get { } //Length: 82
	}

	private static MSCompatUnicodeTable() { }

	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	public static byte Category(int cp) { }

	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref Byte* lv2Table) { }

	public static bool get_IsReady() { }

	private static IntPtr GetResource(string name) { }

	public static TailoringInfo GetTailoringInfo(int lcid) { }

	public static bool HasSpecialWeight(char c) { }

	public static bool IsHalfWidthKana(char c) { }

	public static bool IsHiragana(char c) { }

	public static bool IsIgnorable(int cp, byte flag) { }

	public static bool IsIgnorableNonSpacing(int cp) { }

	public static bool IsJapaneseSmallLetter(char c) { }

	public static byte Level1(int cp) { }

	public static byte Level2(int cp) { }

	public static byte Level3(int cp) { }

	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	public static int ToKanaTypeInsensitive(int i) { }

	public static int ToWidthCompat(int i) { }

	private static uint UInt32FromBytePtr(Byte* raw, uint idx) { }

}

