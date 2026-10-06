namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal static class EnumUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<EnumMemberAttribute, String> <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal string <InitializeValuesAndNames>b__3_0(EnumMemberAttribute a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__4
	{
		[Nullable(0)]
		public static readonly <>c__4<T> <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<UInt64, Boolean> <>9__4_0; //Field offset: 0x0

		private static <>c__4`1() { }

		public <>c__4`1() { }

		internal bool <GetFlagsValues>b__4_0(ulong v) { }

	}

	private const char EnumSeparatorChar = '\u2C'; //Field offset: 0x0
	private const string EnumSeparatorString = ", "; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 1, 2, 1}])]
	private static readonly ThreadSafeStore<StructMultiKey`2<Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum; //Field offset: 0x0
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; //Field offset: 0x8

	private static EnumUtils() { }

	private static Nullable<Int32> FindIndexByName(String[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	public static EnumInfo GetEnumValuesAndNames(Type enumType) { }

	[NullableContext(0)]
	public static IList<T> GetFlagsValues(T value) { }

	private static EnumInfo InitializeValuesAndNames(StructMultiKey<Type, NamingStrategy> key) { }

	private static string InternalFlagsFormat(EnumInfo entry, ulong result) { }

	private static Nullable<Int32> MatchName(string value, String[] enumNames, String[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	private static ulong ToUInt64(object value) { }

	public static bool TryToString(Type enumType, object value, bool camelCase, out string name) { }

	public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, out string name) { }

}

