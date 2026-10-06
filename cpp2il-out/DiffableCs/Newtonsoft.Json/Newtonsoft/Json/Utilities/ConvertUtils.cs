namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal static class ConvertUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2, 2}])]
		public MethodCall<Object, Object> call; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		[NullableContext(2)]
		internal object <CreateCastConverter>b__0(object o) { }

	}

	[NullableContext(0)]
	public enum ConvertResult
	{
		Success = 0,
		CannotConvertNull = 1,
		NotInstantiableType = 2,
		NoValidConversion = 3,
	}

	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; //Field offset: 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; //Field offset: 0x8
	[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 1, 1, 2, 2, 2}])]
	private static readonly ThreadSafeStore<StructMultiKey`2<Type, Type>, Func`2<Object, Object>> CastConverters; //Field offset: 0x10

	private static ConvertUtils() { }

	public static object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	[NullableContext(2)]
	private static Func<Object, Object> CreateCastConverter(StructMultiKey<Type, Type> t) { }

	public static ParseResult DecimalTryParse(Char[] chars, int start, int length, out decimal value) { }

	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	public static object FromBigInteger(BigInteger i, Type targetType) { }

	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	public static ParseResult Int32TryParse(Char[] chars, int start, int length, out int value) { }

	public static ParseResult Int64TryParse(Char[] chars, int start, int length, out long value) { }

	public static bool IsConvertible(Type t) { }

	public static bool IsInteger(object value) { }

	public static TimeSpan ParseTimeSpan(string input) { }

	internal static BigInteger ToBigInteger(object value) { }

	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	public static bool TryConvertGuid(string s, out Guid g) { }

	private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	public static bool TryHexTextToInt(Char[] text, int start, int end, out int value) { }

	public static bool VersionTryParse(string input, out Version result) { }

}

