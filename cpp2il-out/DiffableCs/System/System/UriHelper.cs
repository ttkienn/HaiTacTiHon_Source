namespace System;

internal static class UriHelper
{
	private static readonly Char[] HexUpperChars; //Field offset: 0x0

	private static UriHelper() { }

	private static Char[] EnsureDestinationSize(Char* pStr, Char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	internal static void EscapeAsciiChar(char ch, Char[] to, ref int pos) { }

	internal static char EscapedAscii(char digit, char next) { }

	internal static Char[] EscapeString(string input, int start, int end, Char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	internal static bool Is3986Unreserved(char c) { }

	internal static bool IsNotSafeForUnescape(char ch) { }

	private static bool IsReservedUnreservedOrHash(char c) { }

	internal static bool IsUnreserved(char c) { }

	internal static void MatchUTF8Sequence(Char* pDest, Char[] dest, ref int destOffset, Char[] unescapedChars, int charCount, Byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	internal static bool TestForSubPath(Char* pMe, ushort meLength, Char* pShe, ushort sheLength, bool ignoreCase) { }

	internal static Char[] UnescapeString(string input, int start, int end, Char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	internal static Char[] UnescapeString(Char* pStr, int start, int end, Char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

}

