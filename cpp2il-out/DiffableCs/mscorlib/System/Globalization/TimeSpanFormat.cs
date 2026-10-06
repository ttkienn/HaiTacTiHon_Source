namespace System.Globalization;

internal static class TimeSpanFormat
{
	public struct FormatLiterals
	{
		internal string AppCompatLiteral; //Field offset: 0x0
		internal int dd; //Field offset: 0x8
		internal int hh; //Field offset: 0xC
		internal int mm; //Field offset: 0x10
		internal int ss; //Field offset: 0x14
		internal int ff; //Field offset: 0x18
		private String[] _literals; //Field offset: 0x20

		internal string DayHourSep
		{
			internal get { } //Length: 39
		}

		internal string End
		{
			internal get { } //Length: 39
		}

		internal string HourMinuteSep
		{
			internal get { } //Length: 39
		}

		internal string MinuteSecondSep
		{
			internal get { } //Length: 39
		}

		internal string SecondFractionSep
		{
			internal get { } //Length: 39
		}

		internal string Start
		{
			internal get { } //Length: 39
		}

		internal string get_DayHourSep() { }

		internal string get_End() { }

		internal string get_HourMinuteSep() { }

		internal string get_MinuteSecondSep() { }

		internal string get_SecondFractionSep() { }

		internal string get_Start() { }

		internal void Init(ReadOnlySpan<Char> format, bool useInvariantFieldLengths) { }

		internal static FormatLiterals InitInvariant(bool isNegative) { }

	}

	public enum Pattern
	{
		None = 0,
		Minimum = 1,
		Full = 2,
	}

	internal static readonly FormatLiterals PositiveInvariantFormatLiterals; //Field offset: 0x0
	internal static readonly FormatLiterals NegativeInvariantFormatLiterals; //Field offset: 0x28

	private static TimeSpanFormat() { }

	private static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits) { }

	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	private static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, StringBuilder result) { }

	private static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<Char> format, Pattern pattern) { }

	private static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<Char> format, IFormatProvider formatProvider) { }

	internal static bool TryFormat(TimeSpan value, Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider formatProvider) { }

}

