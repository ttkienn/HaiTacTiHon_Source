namespace System.Globalization;

public class CompareInfo : IDeserializationCallback
{
	private const CompareOptions ValidIndexMaskOffFlags = -32; //Field offset: 0x0
	private const CompareOptions ValidCompareMaskOffFlags = -536870944; //Field offset: 0x0
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32; //Field offset: 0x0
	private const CompareOptions ValidSortkeyCtorMaskOffFlags = -536870944; //Field offset: 0x0
	internal static readonly CompareInfo Invariant; //Field offset: 0x0
	private static Dictionary<String, ISimpleCollator> collators; //Field offset: 0x8
	private static bool managedCollation; //Field offset: 0x10
	private static bool managedCollationChecked; //Field offset: 0x11
	[OptionalField(VersionAdded = 2)]
	private string m_name; //Field offset: 0x10
	private string _sortName; //Field offset: 0x18
	[OptionalField(VersionAdded = 3)]
	private SortVersion m_SortVersion; //Field offset: 0x20
	private int culture; //Field offset: 0x28
	private ISimpleCollator collator; //Field offset: 0x30

	public override string Name
	{
		 get { } //Length: 115
	}

	private static bool UseManagedCollation
	{
		private get { } //Length: 378
	}

	private static CompareInfo() { }

	internal CompareInfo() { }

	internal CompareInfo(CultureInfo culture) { }

	public override int Compare(string string1, string string2, CompareOptions options) { }

	public override int Compare(string string1, string string2) { }

	public override int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	internal int Compare(ReadOnlySpan<Char> string1, string string2, CompareOptions options) { }

	internal int CompareOptionIgnoreCase(ReadOnlySpan<Char> string1, ReadOnlySpan<Char> string2) { }

	internal static int CompareOrdinalIgnoreCase(ReadOnlySpan<Char> strA, ReadOnlySpan<Char> strB) { }

	internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB) { }

	private int CompareString(ReadOnlySpan<Char> string1, ReadOnlySpan<Char> string2, CompareOptions options) { }

	private int CompareString(ReadOnlySpan<Char> string1, string string2, CompareOptions options) { }

	private static int CompareStringOrdinalIgnoreCase(Char* pString1, int length1, Char* pString2, int length2) { }

	private SortKey CreateSortKey(string source, CompareOptions options) { }

	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	private bool EndsWith(string source, string suffix, CompareOptions options) { }

	private bool EndsWith(ReadOnlySpan<Char> source, ReadOnlySpan<Char> suffix, CompareOptions options) { }

	public virtual bool Equals(object value) { }

	public override string get_Name() { }

	private static bool get_UseManagedCollation() { }

	private ISimpleCollator GetCollator() { }

	public static CompareInfo GetCompareInfo(string name) { }

	public override int GetHashCode(string source, CompareOptions options) { }

	public virtual int GetHashCode() { }

	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	internal int GetHashCodeOfStringCore(string source, CompareOptions options) { }

	internal static int GetIgnoreCaseHash(string source) { }

	public override SortKey GetSortKey(string source, CompareOptions options) { }

	public override int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	public override int IndexOf(string source, string value, CompareOptions options) { }

	private int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, Int32* matchLengthPtr) { }

	internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	private void InitSort(CultureInfo culture) { }

	private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	private static int internal_compare_icall(Char* str1, int length1, Char* str2, int length2, CompareOptions options) { }

	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	private static int internal_index(string source, int sindex, int count, string value, bool first) { }

	private static int internal_index_icall(Char* source, int sindex, int count, Char* value, int value_length, bool first) { }

	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	private SortKey InvariantCreateSortKey(string source, CompareOptions options) { }

	private static int InvariantFindString(Char* source, int sourceCount, Char* value, int valueCount, bool ignoreCase, bool start) { }

	internal static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	internal static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	private static char InvariantToUpper(char c) { }

	public override bool IsPrefix(string source, string prefix, CompareOptions options) { }

	internal bool IsSuffix(ReadOnlySpan<Char> source, ReadOnlySpan<Char> suffix, CompareOptions options) { }

	public override bool IsSuffix(string source, string suffix, CompareOptions options) { }

	public override int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options) { }

	internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	private void OnDeserialized() { }

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx) { }

	private bool StartsWith(string source, string prefix, CompareOptions options) { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	public virtual string ToString() { }

}

