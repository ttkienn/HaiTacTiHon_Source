namespace System;

[StackTraceHidden]
internal static class ThrowHelper
{

	private static Exception CreateArgumentException_DestinationTooShort() { }

	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	private static Exception CreateArgumentOutOfRangeException() { }

	private static Exception CreateArrayTypeMismatchException() { }

	private static Exception CreateIndexOutOfRangeException() { }

	private static Exception CreateThrowNotSupportedException() { }

	private static ArgumentException GetAddingDuplicateWithKeyArgumentException(object key) { }

	private static ArgumentException GetArgumentException(ExceptionResource resource) { }

	internal static string GetArgumentName(ExceptionArgument argument) { }

	private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument) { }

	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, string resource) { }

	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	private static Exception GetArraySegmentCtorValidationFailedException(Array array, int offset, int count) { }

	internal static InvalidOperationException GetInvalidOperationException(string str) { }

	private static KeyNotFoundException GetKeyNotFoundException(object key) { }

	internal static string GetResourceName(ExceptionResource resource) { }

	internal static void IfNullAndNullsAreIllegalThenThrow(object value, ExceptionArgument argName) { }

	internal static void ThrowAddingDuplicateWithKeyArgumentException(object key) { }

	internal static void ThrowArgumentException(ExceptionResource resource) { }

	internal static void ThrowArgumentException(ExceptionResource resource, ExceptionArgument argument) { }

	internal static void ThrowArgumentException_Argument_InvalidArrayType() { }

	internal static void ThrowArgumentException_DestinationTooShort() { }

	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	internal static void ThrowArgumentOutOfRange_IndexException() { }

	internal static void ThrowArgumentOutOfRangeException() { }

	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	internal static void ThrowArraySegmentCtorValidationFailedExceptions(Array array, int offset, int count) { }

	internal static void ThrowArrayTypeMismatchException() { }

	internal static void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count() { }

	internal static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException() { }

	internal static void ThrowIndexOutOfRangeException() { }

	internal static void ThrowInvalidOperationException(ExceptionResource resource) { }

	internal static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported() { }

	internal static void ThrowInvalidOperationException_InvalidOperation_EnumEnded() { }

	internal static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion() { }

	internal static void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted() { }

	internal static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen() { }

	internal static void ThrowInvalidOperationException_InvalidOperation_NoValue() { }

	internal static void ThrowInvalidTypeWithPointersNotSupported(Type targetType) { }

	internal static void ThrowKeyNotFoundException(object key) { }

	internal static void ThrowNotSupportedException() { }

	internal static void ThrowNotSupportedException(ExceptionResource resource) { }

	internal static void ThrowSerializationException(ExceptionResource resource) { }

	internal static void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index() { }

	internal static void ThrowWrongKeyTypeArgumentException(object key, Type targetType) { }

	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType) { }

}

