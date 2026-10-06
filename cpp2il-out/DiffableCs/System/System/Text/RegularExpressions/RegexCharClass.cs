namespace System.Text.RegularExpressions;

internal sealed class RegexCharClass
{
	[IsReadOnly]
	private struct LowerCaseMapping
	{
		public readonly char ChMin; //Field offset: 0x0
		public readonly char ChMax; //Field offset: 0x2
		public readonly int LcOp; //Field offset: 0x4
		public readonly int Data; //Field offset: 0x8

		internal LowerCaseMapping(char chMin, char chMax, int lcOp, int data) { }

	}

	[IsReadOnly]
	private struct SingleRange
	{
		public readonly char First; //Field offset: 0x0
		public readonly char Last; //Field offset: 0x2

		internal SingleRange(char first, char last) { }

	}

	private sealed class SingleRangeComparer : IComparer<SingleRange>
	{
		public static readonly SingleRangeComparer Instance; //Field offset: 0x0

		private static SingleRangeComparer() { }

		private SingleRangeComparer() { }

		public override int Compare(SingleRange x, SingleRange y) { }

	}

	private static readonly string s_internalRegexIgnoreCase; //Field offset: 0x0
	private static readonly string s_space; //Field offset: 0x8
	private static readonly string s_notSpace; //Field offset: 0x10
	private static readonly string s_word; //Field offset: 0x18
	private static readonly string s_notWord; //Field offset: 0x20
	public static readonly string SpaceClass; //Field offset: 0x28
	public static readonly string NotSpaceClass; //Field offset: 0x30
	public static readonly string WordClass; //Field offset: 0x38
	public static readonly string NotWordClass; //Field offset: 0x40
	public static readonly string DigitClass; //Field offset: 0x48
	public static readonly string NotDigitClass; //Field offset: 0x50
	private static readonly Dictionary<String, String> s_definedCategories; //Field offset: 0x58
	private static readonly String[][] s_propTable; //Field offset: 0x60
	private static readonly LowerCaseMapping[] s_lcTable; //Field offset: 0x68
	private List<SingleRange> _rangelist; //Field offset: 0x10
	private StringBuilder _categories; //Field offset: 0x18
	private bool _canonical; //Field offset: 0x20
	private bool _negate; //Field offset: 0x21
	private RegexCharClass _subtractor; //Field offset: 0x28

	public bool CanMerge
	{
		 get { } //Length: 18
	}

	public bool Negate
	{
		 set { } //Length: 4
	}

	private static RegexCharClass() { }

	public RegexCharClass() { }

	private RegexCharClass(bool negate, List<SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	private void AddCategory(string category) { }

	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	public void AddChar(char c) { }

	public void AddCharClass(RegexCharClass cc) { }

	public void AddDigit(bool ecma, bool negate, string pattern) { }

	public void AddLowercase(CultureInfo culture) { }

	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	public void AddRange(char first, char last) { }

	private void AddSet(string set) { }

	public void AddSpace(bool ecma, bool negate) { }

	public void AddSubtraction(RegexCharClass sub) { }

	public void AddWord(bool ecma, bool negate) { }

	private void Canonicalize() { }

	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	public static bool CharInClass(char ch, string set) { }

	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	private static bool CharInClassRecursive(char ch, string set, int start) { }

	public bool get_CanMerge() { }

	private SingleRange GetRangeAt(int i) { }

	public static bool IsECMAWordChar(char ch) { }

	public static bool IsEmpty(string charClass) { }

	public static bool IsMergeable(string charClass) { }

	private static bool IsNegated(string set) { }

	public static bool IsSingleton(string set) { }

	public static bool IsSingletonInverse(string set) { }

	private static bool IsSubtraction(string charClass) { }

	public static bool IsWordChar(char ch) { }

	private static string NegateCategory(string category) { }

	public static RegexCharClass Parse(string charClass) { }

	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	private int RangeCount() { }

	public void set_Negate(bool value) { }

	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	public static char SingletonChar(string set) { }

	public string ToStringClass() { }

}

