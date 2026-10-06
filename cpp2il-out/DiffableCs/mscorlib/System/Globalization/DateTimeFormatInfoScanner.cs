namespace System.Globalization;

internal class DateTimeFormatInfoScanner
{
	private enum FoundDatePattern
	{
		None = 0,
		FoundYearPatternFlag = 1,
		FoundMonthPatternFlag = 2,
		FoundDayPatternFlag = 4,
		FoundYMDPatternFlag = 7,
	}

	private static Dictionary<String, String> s_knownWords; //Field offset: 0x0
	internal List<String> m_dateWords; //Field offset: 0x10
	private FoundDatePattern _ymdFlags; //Field offset: 0x18

	private static Dictionary<String, String> KnownWords
	{
		private get { } //Length: 1052
	}

	public DateTimeFormatInfoScanner() { }

	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	internal void AddIgnorableSymbols(string text) { }

	private static bool ArrayElementsBeginWithDigit(String[] array) { }

	private static bool ArrayElementsHaveSpace(String[] array) { }

	private static bool EqualStringArrays(String[] array1, String[] array2) { }

	private static Dictionary<String, String> get_KnownWords() { }

	internal String[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(String[] monthNames, String[] genitveMonthNames, String[] abbrevMonthNames, String[] genetiveAbbrevMonthNames) { }

	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(String[] dayNames, String[] abbrevDayNames) { }

	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(String[] monthNames, String[] genitveMonthNames, String[] abbrevMonthNames, String[] genetiveAbbrevMonthNames) { }

	internal void ScanDateWord(string pattern) { }

	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

}

