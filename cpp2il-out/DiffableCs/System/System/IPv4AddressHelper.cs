namespace System;

internal static class IPv4AddressHelper
{

	internal static bool IsValid(Char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	internal static bool IsValidCanonical(Char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	private static bool Parse(string name, Byte* numbers, int start, int end) { }

	private static bool ParseCanonical(ReadOnlySpan<Char> name, Byte* numbers, int start, int end) { }

	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	internal static int ParseHostNumber(ReadOnlySpan<Char> str, int start, int end) { }

	internal static long ParseNonCanonical(Char* name, int start, ref int end, bool notImplicitFile) { }

}

