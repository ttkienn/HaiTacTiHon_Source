namespace System;

internal static class IriHelper
{

	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) { }

	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) { }

	internal static bool CheckIsReserved(char ch, UriComponents component) { }

	internal static string EscapeUnescapeIri(Char* pInput, int start, int end, UriComponents component) { }

}

