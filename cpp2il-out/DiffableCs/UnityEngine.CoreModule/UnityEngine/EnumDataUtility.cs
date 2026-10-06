namespace UnityEngine;

internal static class EnumDataUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FieldInfo, Int32> <>9__2_5; //Field offset: 0x8
		public static Func<FieldInfo, String> <>9__2_1; //Field offset: 0x10
		public static Func<FieldInfo, Enum> <>9__2_2; //Field offset: 0x18
		public static Func<Enum, Int32> <>9__2_3; //Field offset: 0x20
		public static Func<Enum, Int32> <>9__2_4; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <GetCachedEnumData>b__2_1(FieldInfo f) { }

		internal Enum <GetCachedEnumData>b__2_2(FieldInfo f) { }

		internal int <GetCachedEnumData>b__2_3(Enum v) { }

		internal int <GetCachedEnumData>b__2_4(Enum v) { }

		internal int <GetCachedEnumData>b__2_5(FieldInfo f) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Func<String, String> nicifyName; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal string <GetCachedEnumData>b__0(FieldInfo f) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass8_0
	{
		public Func<String, String> nicifyName; //Field offset: 0x0
		public FieldInfo field; //Field offset: 0x8

	}

	internal enum CachedType
	{
		ExcludeObsolete = 0,
		IncludeObsoleteExceptErrors = 1,
		IncludeAllObsolete = 2,
	}

	private static readonly Dictionary<ValueTuple`2<CachedType, Type>, EnumData> s_EnumData; //Field offset: 0x0

	private static EnumDataUtility() { }

	[CompilerGenerated]
	internal static string <EnumNameFromEnumField>g__NicifyName|8_0(ref <>c__DisplayClass8_0 unnamed_param_0) { }

	private static bool CheckObsoleteAddition(FieldInfo field, CachedType cachedType) { }

	private static string EnumNameFromEnumField(FieldInfo field, Func<String, String> nicifyName) { }

	private static string EnumTooltipFromEnumField(FieldInfo field) { }

	public static EnumData GetCachedEnumData(Type enumType, CachedType cachedType = 1, Func<String, String> nicifyName = null) { }

	internal static void HandleInspectorOrderAttribute(Type enumType, ref EnumData enumData) { }

}

