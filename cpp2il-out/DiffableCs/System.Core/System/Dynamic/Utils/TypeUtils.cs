namespace System.Dynamic.Utils;

[Extension]
internal static class TypeUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <.cctor>b__44_0(Type i) { }

		internal Type <.cctor>b__44_1(Type i) { }

	}

	private static readonly Type[] s_arrayAssignableInterfaces; //Field offset: 0x0

	private static TypeUtils() { }

	public static bool AreEquivalent(Type t1, Type t2) { }

	public static bool AreReferenceAssignable(Type dest, Type src) { }

	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	public static Type FindGenericType(Type definition, Type type) { }

	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[Extension]
	public static MethodInfo GetInvokeMethod(Type delegateType) { }

	[Extension]
	public static Type GetNonNullableType(Type type) { }

	[Extension]
	public static Type GetNonRefType(Type type) { }

	[Extension]
	public static Type GetNullableType(Type type) { }

	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	private static bool HasArrayToInterfaceConversion(Type source, Type dest) { }

	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[Extension]
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	private static bool HasInterfaceToArrayConversion(Type source, Type dest) { }

	[Extension]
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	public static bool HasReferenceEquality(Type left, Type right) { }

	[Extension]
	public static bool IsArithmetic(Type type) { }

	[Extension]
	public static bool IsBool(Type type) { }

	private static bool IsContravariant(Type t) { }

	[Extension]
	public static bool IsConvertible(Type type) { }

	private static bool IsCovariant(Type t) { }

	private static bool IsDelegate(Type t) { }

	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	[Extension]
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	[Extension]
	public static bool IsInteger(Type type) { }

	[Extension]
	public static bool IsIntegerOrBool(Type type) { }

	private static bool IsInvariant(Type t) { }

	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[Extension]
	public static bool IsNullableOrReferenceType(Type type) { }

	[Extension]
	public static bool IsNullableType(Type type) { }

	[Extension]
	public static bool IsNumeric(Type type) { }

	[Extension]
	public static bool IsNumericOrBool(Type type) { }

	public static bool IsSameOrSubclass(Type type, Type subType) { }

	[Extension]
	public static bool IsUnsignedInt(Type type) { }

	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[Extension]
	private static bool StrictHasReferenceConversionTo(Type source, Type dest, bool skipNonArray) { }

	public static void ValidateType(Type type, string paramName) { }

	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	public static bool ValidateType(Type type, string paramName, int index) { }

}

