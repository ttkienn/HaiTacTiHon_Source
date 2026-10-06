namespace System.IO;

internal static class Error
{

	internal static Exception GetEndOfFile() { }

	internal static Exception GetReadNotSupported() { }

	internal static Exception GetStreamIsClosed() { }

	internal static Exception GetWriteNotSupported() { }

}

