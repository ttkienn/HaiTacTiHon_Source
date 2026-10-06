namespace System.IO;

public static class Directory
{

	public static DirectoryInfo CreateDirectory(string path) { }

	public static void Delete(string path, bool recursive) { }

	public static bool Exists(string path) { }

	public static string GetCurrentDirectory() { }

	public static String[] GetFiles(string path, string searchPattern) { }

	public static String[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	internal static string InsecureGetCurrentDirectory() { }

	internal static IEnumerable<String> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

	internal static string InternalGetDirectoryRoot(string path) { }

}

