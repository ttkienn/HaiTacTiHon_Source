namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class StringUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1}])]
		public Func<TSource, String> valueSelector; //Field offset: 0x0
		[Nullable(0)]
		public string testValue; //Field offset: 0x0

		public <>c__DisplayClass14_0`1() { }

		[NullableContext(0)]
		internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }

		[NullableContext(0)]
		internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }

	}

	[NullableContext(0)]
	private enum SeparatedCaseState
	{
		Start = 0,
		Lower = 1,
		Upper = 2,
		NewWord = 3,
	}

	public const string CarriageReturnLineFeed = "
"; //Field offset: 0x0
	public const string Empty = ""; //Field offset: 0x0
	public const char CarriageReturn = '\uD'; //Field offset: 0x0
	public const char LineFeed = '\uA'; //Field offset: 0x0
	public const char Tab = '\u9'; //Field offset: 0x0

	public static StringWriter CreateStringWriter(int capacity) { }

	[Extension]
	public static bool EndsWith(string source, char value) { }

	[Extension]
	public static TSource ForgivingCaseSensitiveFind(IEnumerable<TSource> source, Func<TSource, String> valueSelector, string testValue) { }

	[Extension]
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[Extension]
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[Extension]
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[Extension]
	[NullableContext(2)]
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[Extension]
	private static string FormatWith(string format, IFormatProvider provider, Object[] args) { }

	public static int IndexOf(string s, char c) { }

	public static bool IsHighSurrogate(char c) { }

	public static bool IsLowSurrogate(char c) { }

	[NullableContext(2)]
	public static bool IsNullOrEmpty(string value) { }

	public static bool IsWhiteSpace(string s) { }

	public static string Replace(string s, string oldValue, string newValue) { }

	[Extension]
	public static bool StartsWith(string source, char value) { }

	public static string ToCamelCase(string s) { }

	public static void ToCharAsUnicode(char c, Char[] buffer) { }

	public static string ToKebabCase(string s) { }

	private static char ToLower(char c) { }

	private static string ToSeparatedCase(string s, char separator) { }

	public static string ToSnakeCase(string s) { }

	[Extension]
	public static string Trim(string s, int start, int length) { }

}

