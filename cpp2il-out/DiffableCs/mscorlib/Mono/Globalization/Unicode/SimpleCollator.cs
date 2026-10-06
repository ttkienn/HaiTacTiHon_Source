namespace Mono.Globalization.Unicode;

internal class SimpleCollator : ISimpleCollator
{
	public struct Context
	{
		public readonly CompareOptions Option; //Field offset: 0x0
		public readonly Byte* NeverMatchFlags; //Field offset: 0x8
		public readonly Byte* AlwaysMatchFlags; //Field offset: 0x10
		public Byte* Buffer1; //Field offset: 0x18
		public Byte* Buffer2; //Field offset: 0x20
		public int PrevCode; //Field offset: 0x28
		public Byte* PrevSortKey; //Field offset: 0x30

		public Context(CompareOptions opt, Byte* alwaysMatchFlags, Byte* neverMatchFlags, Byte* buffer1, Byte* buffer2, Byte* prev1) { }

	}

	private struct Escape
	{
		public string Source; //Field offset: 0x0
		public int Index; //Field offset: 0x8
		public int Start; //Field offset: 0xC
		public int End; //Field offset: 0x10
		public int Optional; //Field offset: 0x14

	}

	private enum ExtenderType
	{
		None = 0,
		Simple = 1,
		Voiced = 2,
		Conditional = 3,
		Buggy = 4,
	}

	private struct PreviousInfo
	{
		public int Code; //Field offset: 0x0
		public Byte* SortKey; //Field offset: 0x8

		public PreviousInfo(bool dummy) { }

	}

	private static SimpleCollator invariant; //Field offset: 0x0
	private readonly TextInfo textInfo; //Field offset: 0x10
	private readonly CodePointIndexer cjkIndexer; //Field offset: 0x18
	private readonly Contraction[] contractions; //Field offset: 0x20
	private readonly Level2Map[] level2Maps; //Field offset: 0x28
	private readonly Byte[] unsafeFlags; //Field offset: 0x30
	private readonly Byte* cjkCatTable; //Field offset: 0x38
	private readonly Byte* cjkLv1Table; //Field offset: 0x40
	private readonly Byte* cjkLv2Table; //Field offset: 0x48
	private readonly CodePointIndexer cjkLv2Indexer; //Field offset: 0x50
	private readonly int lcid; //Field offset: 0x58
	private readonly bool frenchSort; //Field offset: 0x5C

	private static SimpleCollator() { }

	public SimpleCollator(CultureInfo culture) { }

	private byte Category(int cp) { }

	private void ClearBuffer(Byte* buffer, int size) { }

	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	private int CompareFlagPair(bool b1, bool b2) { }

	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref Context ctx) { }

	private void FillSortKeyRaw(int i, ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	private int FilterExtender(int i, ExtenderType ext, CompareOptions opt) { }

	private int FilterOptions(int i, CompareOptions opt) { }

	private Contraction GetContraction(string s, int start, int end) { }

	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	private ExtenderType GetExtenderType(int i) { }

	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	public override SortKey GetSortKey(string s, CompareOptions options) { }

	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	private Contraction GetTailContraction(string s, int start, int end) { }

	private int IndexOf(string s, string target, int start, int length, Byte* targetSortKey, ref Context ctx) { }

	public override int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	private int IndexOfSortKey(string s, int start, int length, Byte* sortkey, char target, int ti, bool noLv4, ref Context ctx) { }

	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	private static bool IsIgnorable(int i, CompareOptions opt) { }

	public override bool IsPrefix(string src, string target, CompareOptions opt) { }

	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref Context ctx) { }

	private bool IsSafe(int i) { }

	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	public override bool IsSuffix(string src, string target, CompareOptions opt) { }

	public override int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	private int LastIndexOf(string s, string target, int start, int length, Byte* targetSortKey, ref Context ctx) { }

	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, Byte* sortkey, int ti, bool noLv4, ref Context ctx) { }

	private byte Level1(int cp) { }

	private byte Level2(int cp, ExtenderType ext) { }

	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, Byte* sortkey, bool noLv4, ref Context ctx) { }

	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, Byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx) { }

	private bool MatchesForward(string s, ref int idx, int end, int ti, Byte* sortkey, bool noLv4, ref Context ctx) { }

	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, Byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx) { }

	private bool MatchesPrimitive(CompareOptions opt, Byte* source, int si, ExtenderType ext, Byte* target, int ti, bool noLv4) { }

	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	private override int System.Globalization.ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	private static byte ToDashTypeValue(ExtenderType ext, CompareOptions opt) { }

}

