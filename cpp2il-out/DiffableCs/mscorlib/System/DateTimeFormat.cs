namespace System;

internal static class DateTimeFormat
{
	internal static readonly TimeSpan NullOffset; //Field offset: 0x0
	internal static Char[] allStandardFormats; //Field offset: 0x8
	internal static readonly DateTimeFormatInfo InvariantFormatInfo; //Field offset: 0x10
	internal static readonly String[] InvariantAbbreviatedMonthNames; //Field offset: 0x18
	internal static readonly String[] InvariantAbbreviatedDayNames; //Field offset: 0x20
	internal static String[] fixedNumberFormats; //Field offset: 0x28

	private static DateTimeFormat() { }

	private static void Append2DigitNumber(StringBuilder result, int val) { }

	private static string ExpandPredefinedFormat(ReadOnlySpan<Char> format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

	internal static string Format(DateTime dateTime, string format, IFormatProvider provider, TimeSpan offset) { }

	internal static string Format(DateTime dateTime, string format, IFormatProvider provider) { }

	private static StringBuilder FormatCustomized(DateTime dateTime, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, TimeSpan offset, StringBuilder result) { }

	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, ReadOnlySpan<Char> format, int tokenLen, bool timeOnly, StringBuilder result) { }

	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	private static StringBuilder FormatStringBuilder(DateTime dateTime, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	internal static string GetRealFormat(ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi) { }

	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

	internal static void InvalidFormatForLocal(ReadOnlySpan<Char> format, DateTime dateTime) { }

	private static bool IsUseGenitiveForm(ReadOnlySpan<Char> format, int index, int tokenLen, char patternToMatch) { }

	internal static int ParseNextChar(ReadOnlySpan<Char> format, int pos) { }

	internal static int ParseQuoteString(ReadOnlySpan<Char> format, int pos, StringBuilder result) { }

	internal static int ParseRepeatPattern(ReadOnlySpan<Char> format, int pos, char patternChar) { }

	internal static bool TryFormat(DateTime dateTime, Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	internal static bool TryFormat(DateTime dateTime, Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider, TimeSpan offset) { }

	private static bool TryFormatO(DateTime dateTime, TimeSpan offset, Span<Char> destination, out int charsWritten) { }

	private static bool TryFormatR(DateTime dateTime, TimeSpan offset, Span<Char> destination, out int charsWritten) { }

	private static void WriteDigits(ulong value, Span<Char> buffer) { }

	private static void WriteFourDecimalDigits(uint value, Span<Char> buffer, int startingIndex = 0) { }

	private static void WriteTwoDecimalDigits(uint value, Span<Char> destination, int offset) { }

}

