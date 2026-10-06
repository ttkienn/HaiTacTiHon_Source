namespace System.Xml;

internal static class ValidateNames
{
	private static XmlCharType xmlCharType; //Field offset: 0x0

	private static ValidateNames() { }

	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	internal static bool IsNameNoNamespaces(string s) { }

	internal static int ParseNameNoNamespaces(string s, int offset) { }

	internal static int ParseNCName(string s, int offset) { }

	internal static int ParseNCName(string s) { }

	internal static int ParseNmtoken(string s, int offset) { }

	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	internal static void SplitQName(string name, out string prefix, out string lname) { }

	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

}

