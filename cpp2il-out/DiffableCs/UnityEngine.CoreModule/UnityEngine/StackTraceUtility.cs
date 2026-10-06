namespace UnityEngine;

public static class StackTraceUtility
{
	private static string projectFolder; //Field offset: 0x0

	private static StackTraceUtility() { }

	internal static string ExtractFormattedStackTrace(StackTrace stackTrace) { }

	[RequiredByNativeCode]
	public static string ExtractStackTrace() { }

	[RequiredByNativeCode]
	internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) { }

	[RequiredByNativeCode]
	internal static void SetProjectFolder(string folder) { }

}

