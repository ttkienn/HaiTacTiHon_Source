namespace System.Data.Common;

internal static class ADP
{
	private static readonly Type s_stackOverflowType; //Field offset: 0x0
	private static readonly Type s_outOfMemoryType; //Field offset: 0x8
	private static readonly Type s_threadAbortType; //Field offset: 0x10
	private static readonly Type s_nullReferenceType; //Field offset: 0x18
	private static readonly Type s_accessViolationType; //Field offset: 0x20
	private static readonly Type s_securityType; //Field offset: 0x28
	internal static readonly string StrEmpty; //Field offset: 0x30
	internal static readonly String[] AzureSqlServerEndpoints; //Field offset: 0x38
	internal static readonly IntPtr PtrZero; //Field offset: 0x40
	internal static readonly int PtrSize; //Field offset: 0x48

	private static ADP() { }

	internal static ArgumentException Argument(string error) { }

	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	internal static InvalidOperationException InvalidOperation(string error) { }

	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	internal static Exception InvalidSeekOrigin(string parameterName) { }

	internal static bool IsCatchableExceptionType(Exception e) { }

	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	internal static NotSupportedException NotSupported(string error) { }

	private static void TraceException(string trace, Exception e) { }

	internal static void TraceExceptionAsReturnValue(Exception e) { }

	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	internal static Exception WrongType(Type got, Type expected) { }

}

