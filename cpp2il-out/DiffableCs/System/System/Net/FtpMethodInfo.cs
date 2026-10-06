namespace System.Net;

internal class FtpMethodInfo
{
	private static readonly FtpMethodInfo[] s_knownMethodInfo; //Field offset: 0x0
	internal string Method; //Field offset: 0x10
	internal FtpOperation Operation; //Field offset: 0x18
	internal FtpMethodFlags Flags; //Field offset: 0x1C
	internal string HttpCommand; //Field offset: 0x20

	internal bool IsCommandOnly
	{
		internal get { } //Length: 8
	}

	internal bool IsDownload
	{
		internal get { } //Length: 8
	}

	internal bool IsUpload
	{
		internal get { } //Length: 8
	}

	internal bool ShouldParseForResponseUri
	{
		internal get { } //Length: 8
	}

	private static FtpMethodInfo() { }

	internal FtpMethodInfo(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	internal bool get_IsCommandOnly() { }

	internal bool get_IsDownload() { }

	internal bool get_IsUpload() { }

	internal bool get_ShouldParseForResponseUri() { }

	internal static FtpMethodInfo GetMethodInfo(string method) { }

	internal bool HasFlag(FtpMethodFlags flags) { }

}

