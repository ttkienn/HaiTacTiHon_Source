namespace System.Net;

internal class IPAddressParser
{

	private static void AppendHex(ushort value, StringBuilder buffer) { }

	private static void AppendSections(UInt16[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	private static uint ExtractIPv4Address(UInt16[] address) { }

	private static void FormatIPv4AddressNumber(int number, Char* addressString, ref int offset) { }

	internal static string IPv4AddressToString(uint address) { }

	internal static void IPv4AddressToString(uint address, StringBuilder destination) { }

	private static int IPv4AddressToStringHelper(uint address, Char* addressString) { }

	public static bool Ipv4StringToAddress(ReadOnlySpan<Char> ipSpan, out long address) { }

	internal static string IPv6AddressToString(UInt16[] address, uint scopeId) { }

	internal static StringBuilder IPv6AddressToStringHelper(UInt16[] address, uint scopeId) { }

	public static bool Ipv6StringToAddress(ReadOnlySpan<Char> ipSpan, UInt16* numbers, int numbersLength, out uint scope) { }

	internal static IPAddress Parse(ReadOnlySpan<Char> ipSpan, bool tryParse) { }

	private static ushort Reverse(ushort number) { }

}

