namespace System.Net;

internal class HeaderInfo
{
	internal readonly bool IsRequestRestricted; //Field offset: 0x10
	internal readonly bool IsResponseRestricted; //Field offset: 0x11
	internal readonly HeaderParser Parser; //Field offset: 0x18
	internal readonly string HeaderName; //Field offset: 0x20
	internal readonly bool AllowMultiValues; //Field offset: 0x28

	internal HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }

}

