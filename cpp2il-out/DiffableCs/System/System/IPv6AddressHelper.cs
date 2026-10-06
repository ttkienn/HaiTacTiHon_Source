namespace System;

internal static class IPv6AddressHelper
{

	internal static ValueTuple<Int32, Int32> FindCompressionRange(ReadOnlySpan<UInt16> numbers) { }

	private static bool InternalIsValid(Char* name, int start, ref int end, bool validateStrictAddress) { }

	private static bool IsLoopback(ReadOnlySpan<UInt16> numbers) { }

	internal static bool IsValid(Char* name, int start, ref int end) { }

	internal static bool IsValidStrict(Char* name, int start, ref int end) { }

	internal static void Parse(ReadOnlySpan<Char> address, UInt16* numbers, int start, ref string scopeId) { }

	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan<UInt16> numbers) { }

}

