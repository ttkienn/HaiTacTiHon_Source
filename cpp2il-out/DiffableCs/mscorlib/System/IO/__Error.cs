namespace System.IO;

internal static class __Error
{

	internal static void EndOfFile() { }

	internal static void FileNotOpen() { }

	internal static string GetDisplayablePath(string path, bool isInvalidPath) { }

	internal static void ReaderClosed() { }

	internal static void WinIOError(int errorCode, string maybeFullPath) { }

	internal static void WriterClosed() { }

}

