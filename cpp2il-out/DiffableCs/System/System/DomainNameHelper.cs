namespace System;

internal class DomainNameHelper
{

	internal static string IdnEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	internal static string IdnEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	private static bool IsIdnAce(string input, int index) { }

	private static bool IsIdnAce(Char* input, int index) { }

	internal static bool IsValid(Char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	internal static bool IsValidByIri(Char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }

	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	internal static string UnicodeEquivalent(string idnHost, Char* hostname, int start, int end) { }

	internal static string UnicodeEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

}

