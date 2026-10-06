namespace System.Numerics;

internal static class BigNumber
{
	private struct BigNumberBuffer
	{
		public StringBuilder digits; //Field offset: 0x0
		public int precision; //Field offset: 0x8
		public int scale; //Field offset: 0xC
		public bool sign; //Field offset: 0x10

		public static BigNumberBuffer Create() { }

	}


	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<Char> formatSpan, NumberFormatInfo info, Span<Char> destination, out int charsWritten, out bool spanSuccess) { }

	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<Char> destination, out int charsWritten, out bool spanSuccess) { }

	private static bool HexNumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) { }

	private static bool NumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) { }

	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	internal static BigInteger ParseBigInteger(ReadOnlySpan<Char> value, NumberStyles style, NumberFormatInfo info) { }

	internal static char ParseFormatSpecifier(ReadOnlySpan<Char> format, out int digits) { }

	internal static bool TryParseBigInteger(ReadOnlySpan<Char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

}

