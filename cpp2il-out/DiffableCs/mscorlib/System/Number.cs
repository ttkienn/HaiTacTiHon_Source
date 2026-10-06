namespace System;

internal static class Number
{
	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	public struct NumberBuffer
	{
		private struct DigitsAndNullTerminator
		{

		}

		public int precision; //Field offset: 0x0
		public int scale; //Field offset: 0x4
		private int _sign; //Field offset: 0x8
		private DigitsAndNullTerminator _digits; //Field offset: 0xC
		private Char* _allDigits; //Field offset: 0x72

		public Char* digits
		{
			 get { } //Length: 5
		}

		public bool sign
		{
			 get { } //Length: 8
			 set { } //Length: 9
		}

		public Char* get_digits() { }

		public bool get_sign() { }

		public void set_sign(bool value) { }

	}

	private static readonly String[] s_posCurrencyFormats; //Field offset: 0x0
	private static readonly String[] s_negCurrencyFormats; //Field offset: 0x8
	private static readonly String[] s_posPercentFormats; //Field offset: 0x10
	private static readonly String[] s_negPercentFormats; //Field offset: 0x18
	private static readonly String[] s_negNumberFormats; //Field offset: 0x20
	private static readonly Int32[] s_charToHexLookup; //Field offset: 0x28
	private static readonly UInt64[] s_rgval64Power10; //Field offset: 0x30
	private static readonly SByte[] s_rgexp64Power10; //Field offset: 0x38
	private static readonly UInt64[] s_rgval64Power10By16; //Field offset: 0x40
	private static readonly Int16[] s_rgexp64Power10By16; //Field offset: 0x48

	private static Number() { }

	private static int abs(int value) { }

	private static void DecimalToNumber(decimal value, ref NumberBuffer number) { }

	private static uint DigitsToInt(Char* p, int count) { }

	private static void DoubleToNumber(double value, int precision, ref NumberBuffer number) { }

	private static int FindSection(ReadOnlySpan<Char> format, int section) { }

	private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	public static string FormatDecimal(decimal value, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	private static string FormatDouble(ref ValueStringBuilder sb, double value, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Int32[] groupDigits, string sDecimal, string sGroup) { }

	private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	public static string FormatInt32(int value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	public static string FormatInt64(long value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	private static string FormatSingle(ref ValueStringBuilder sb, float value, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	public static string FormatUInt32(uint value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	public static string FormatUInt64(ulong value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	private static uint High32(ulong value) { }

	private static Char* Int32ToHexChars(Char* buffer, uint value, int hexBase, int digits) { }

	private static string Int32ToHexStr(int value, char hexBase, int digits) { }

	private static void Int32ToNumber(int value, ref NumberBuffer number) { }

	private static uint Int64DivMod1E9(ref ulong value) { }

	private static string Int64ToHexStr(long value, char hexBase, int digits) { }

	private static void Int64ToNumber(long input, ref NumberBuffer number) { }

	private static bool IsDigit(int ch) { }

	private static bool IsWhite(int ch) { }

	private static uint Low32(ulong value) { }

	private static Char* MatchChars(Char* p, Char* pEnd, string value) { }

	private static ulong Mul32x32To64(uint a, uint b) { }

	private static ulong Mul64Lossy(ulong a, ulong b, ref int pexp) { }

	private static string NegativeInt32ToDecStr(int value, int digits, string sNegative) { }

	private static string NegativeInt64ToDecStr(long input, int digits, string sNegative) { }

	private static bool NumberBufferToDecimal(ref NumberBuffer number, ref decimal value) { }

	private static bool NumberBufferToDouble(ref NumberBuffer number, ref double value) { }

	private static double NumberToDouble(ref NumberBuffer number) { }

	private static bool NumberToInt32(ref NumberBuffer number, ref int value) { }

	private static bool NumberToInt64(ref NumberBuffer number, ref long value) { }

	internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	private static bool NumberToUInt32(ref NumberBuffer number, ref uint value) { }

	private static bool NumberToUInt64(ref NumberBuffer number, ref ulong value) { }

	internal static decimal ParseDecimal(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	internal static double ParseDouble(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	internal static char ParseFormatSpecifier(ReadOnlySpan<Char> format, out int digits) { }

	internal static int ParseInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	internal static long ParseInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	private static bool ParseNumber(ref Char* str, Char* strEnd, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	internal static float ParseSingle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	internal static uint ParseUInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	internal static ulong ParseUInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	private static void RoundNumber(ref NumberBuffer number, int pos) { }

	private static void StringToNumber(ReadOnlySpan<Char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	private static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey) { }

	private static bool TrailingZeros(ReadOnlySpan<Char> value, int index) { }

	private static bool TryCopyTo(string source, Span<Char> destination, out int charsWritten) { }

	public static bool TryFormatDecimal(decimal value, ReadOnlySpan<Char> format, NumberFormatInfo info, Span<Char> destination, out int charsWritten) { }

	public static bool TryFormatDouble(double value, ReadOnlySpan<Char> format, NumberFormatInfo info, Span<Char> destination, out int charsWritten) { }

	public static bool TryFormatInt32(int value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	public static bool TryFormatInt64(long value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	public static bool TryFormatSingle(float value, ReadOnlySpan<Char> format, NumberFormatInfo info, Span<Char> destination, out int charsWritten) { }

	public static bool TryFormatUInt32(uint value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	public static bool TryFormatUInt64(ulong value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	private static bool TryInt32ToHexStr(int value, char hexBase, int digits, Span<Char> destination, out int charsWritten) { }

	private static bool TryInt64ToHexStr(long value, char hexBase, int digits, Span<Char> destination, out int charsWritten) { }

	private static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, Span<Char> destination, out int charsWritten) { }

	private static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, Span<Char> destination, out int charsWritten) { }

	internal static bool TryParseDecimal(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out decimal result) { }

	internal static bool TryParseDouble(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out double result) { }

	internal static bool TryParseInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out int result) { }

	private static bool TryParseInt32IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out int result, ref bool failureIsOverflow) { }

	internal static bool TryParseInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out long result) { }

	private static bool TryParseInt64IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out long result, ref bool failureIsOverflow) { }

	internal static bool TryParseSingle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out float result) { }

	internal static bool TryParseUInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out uint result) { }

	private static bool TryParseUInt32HexNumberStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) { }

	private static bool TryParseUInt32IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) { }

	internal static bool TryParseUInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out ulong result) { }

	private static bool TryParseUInt64HexNumberStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) { }

	private static bool TryParseUInt64IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) { }

	internal static bool TryStringToNumber(ReadOnlySpan<Char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	private static bool TryUInt32ToDecStr(uint value, int digits, Span<Char> destination, out int charsWritten) { }

	private static bool TryUInt64ToDecStr(ulong value, int digits, Span<Char> destination, out int charsWritten) { }

	internal static Char* UInt32ToDecChars(Char* bufferEnd, uint value, int digits) { }

	private static string UInt32ToDecStr(uint value, int digits) { }

	private static void UInt32ToNumber(uint value, ref NumberBuffer number) { }

	private static string UInt64ToDecStr(ulong value, int digits) { }

	private static void UInt64ToNumber(ulong value, ref NumberBuffer number) { }

}

