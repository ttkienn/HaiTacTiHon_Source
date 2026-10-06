namespace System.Globalization;

internal static class TimeSpanParse
{
	private enum ParseFailureKind
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		Overflow = 4,
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	private struct TimeSpanRawInfo
	{
		internal TTT _lastSeenTTT; //Field offset: 0x0
		internal int _tokenCount; //Field offset: 0x4
		internal int _sepCount; //Field offset: 0x8
		internal int _numCount; //Field offset: 0xC
		private FormatLiterals _posLoc; //Field offset: 0x10
		private FormatLiterals _negLoc; //Field offset: 0x38
		private bool _posLocInit; //Field offset: 0x60
		private bool _negLocInit; //Field offset: 0x61
		private string _fullPosPattern; //Field offset: 0x68
		private string _fullNegPattern; //Field offset: 0x70
		internal TimeSpanToken _numbers0; //Field offset: 0x78
		internal TimeSpanToken _numbers1; //Field offset: 0x98
		internal TimeSpanToken _numbers2; //Field offset: 0xB8
		internal TimeSpanToken _numbers3; //Field offset: 0xD8
		internal TimeSpanToken _numbers4; //Field offset: 0xF8
		internal ReadOnlySpan<Char> _literals0; //Field offset: 0x118
		internal ReadOnlySpan<Char> _literals1; //Field offset: 0x128
		internal ReadOnlySpan<Char> _literals2; //Field offset: 0x138
		internal ReadOnlySpan<Char> _literals3; //Field offset: 0x148
		internal ReadOnlySpan<Char> _literals4; //Field offset: 0x158
		internal ReadOnlySpan<Char> _literals5; //Field offset: 0x168

		internal FormatLiterals NegativeInvariant
		{
			internal get { } //Length: 109
		}

		internal FormatLiterals NegativeLocalized
		{
			internal get { } //Length: 208
		}

		internal FormatLiterals PositiveInvariant
		{
			internal get { } //Length: 108
		}

		internal FormatLiterals PositiveLocalized
		{
			internal get { } //Length: 208
		}

		private bool AddNum(TimeSpanToken num, ref TimeSpanResult result) { }

		private bool AddSep(ReadOnlySpan<Char> sep, ref TimeSpanResult result) { }

		internal bool FullAppCompatMatch(FormatLiterals pattern) { }

		internal bool FullDHMMatch(FormatLiterals pattern) { }

		internal bool FullDHMSMatch(FormatLiterals pattern) { }

		internal bool FullDMatch(FormatLiterals pattern) { }

		internal bool FullHMMatch(FormatLiterals pattern) { }

		internal bool FullHMSFMatch(FormatLiterals pattern) { }

		internal bool FullHMSMatch(FormatLiterals pattern) { }

		internal bool FullMatch(FormatLiterals pattern) { }

		internal FormatLiterals get_NegativeInvariant() { }

		internal FormatLiterals get_NegativeLocalized() { }

		internal FormatLiterals get_PositiveInvariant() { }

		internal FormatLiterals get_PositiveLocalized() { }

		internal void Init(DateTimeFormatInfo dtfi) { }

		internal bool PartialAppCompatMatch(FormatLiterals pattern) { }

		internal bool ProcessToken(ref TimeSpanToken tok, ref TimeSpanResult result) { }

	}

	private struct TimeSpanResult
	{
		internal TimeSpan parsedTimeSpan; //Field offset: 0x0
		private readonly bool _throwOnFailure; //Field offset: 0x8

		internal TimeSpanResult(bool throwOnFailure) { }

		internal bool SetFailure(ParseFailureKind kind, string resourceKey, object messageArgument = null, string argumentName = null) { }

	}

	[Flags]
	private enum TimeSpanStandardStyles
	{
		None = 0,
		Invariant = 1,
		Localized = 2,
		RequireFull = 4,
		Any = 3,
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	private struct TimeSpanToken
	{
		internal TTT _ttt; //Field offset: 0x0
		internal int _num; //Field offset: 0x4
		internal int _zeroes; //Field offset: 0x8
		internal ReadOnlySpan<Char> _sep; //Field offset: 0x10

		public TimeSpanToken(TTT type) { }

		public TimeSpanToken(int number) { }

		public TimeSpanToken(TTT type, int number, int leadingZeroes, ReadOnlySpan<Char> separator) { }

		public bool IsInvalidFraction() { }

	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	private struct TimeSpanTokenizer
	{
		private ReadOnlySpan<Char> _value; //Field offset: 0x0
		private int _pos; //Field offset: 0x10

		internal TimeSpanTokenizer(ReadOnlySpan<Char> input) { }

		internal TimeSpanTokenizer(ReadOnlySpan<Char> input, int startPosition) { }

		internal TimeSpanToken GetNextToken() { }

	}

	private enum TTT
	{
		None = 0,
		End = 1,
		Num = 2,
		Sep = 3,
		NumOverflow = 4,
	}


	internal static TimeSpan Parse(ReadOnlySpan<Char> input, IFormatProvider formatProvider) { }

	internal static long Pow10(int pow) { }

	private static bool ProcessTerminal_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool ProcessTerminal_DHMSF(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool ProcessTerminal_HM(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool ProcessTerminal_HM_S_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool ProcessTerminalState(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool TryParseTimeSpan(ReadOnlySpan<Char> input, TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanResult result) { }

	private static bool TryTimeToTicks(bool positive, TimeSpanToken days, TimeSpanToken hours, TimeSpanToken minutes, TimeSpanToken seconds, TimeSpanToken fraction, out long result) { }

}

