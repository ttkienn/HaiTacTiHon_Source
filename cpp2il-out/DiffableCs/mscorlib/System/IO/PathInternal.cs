namespace System.IO;

internal static class PathInternal
{
	private static readonly bool s_isCaseSensitive; //Field offset: 0x0

	internal static bool IsCaseSensitive
	{
		internal get { } //Length: 78
	}

	private static PathInternal() { }

	internal static bool EndsInDirectorySeparator(ReadOnlySpan<Char> path) { }

	internal static bool EndsWithPeriodOrSpace(string path) { }

	internal static string EnsureExtendedPrefix(string path) { }

	internal static string EnsureExtendedPrefixIfNeeded(string path) { }

	internal static bool get_IsCaseSensitive() { }

	private static bool GetIsCaseSensitive() { }

	internal static int GetRootLength(ReadOnlySpan<Char> path) { }

	internal static bool IsDevice(ReadOnlySpan<Char> path) { }

	internal static bool IsDeviceUNC(ReadOnlySpan<Char> path) { }

	internal static bool IsDirectorySeparator(char c) { }

	internal static bool IsExtended(ReadOnlySpan<Char> path) { }

	public static bool IsPartiallyQualified(string path) { }

	internal static bool IsRoot(ReadOnlySpan<Char> path) { }

	internal static bool IsValidDriveChar(char value) { }

	internal static bool StartsWithDirectorySeparator(ReadOnlySpan<Char> path) { }

	internal static string TrimEndingDirectorySeparator(string path) { }

	internal static ReadOnlySpan<Char> TrimEndingDirectorySeparator(ReadOnlySpan<Char> path) { }

}

