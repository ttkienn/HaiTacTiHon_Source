namespace System.Globalization;

internal class CultureData
{
	public struct NumberFormatEntryManaged
	{
		internal int currency_decimal_digits; //Field offset: 0x0
		internal int currency_decimal_separator; //Field offset: 0x4
		internal int currency_group_separator; //Field offset: 0x8
		internal int currency_group_sizes0; //Field offset: 0xC
		internal int currency_group_sizes1; //Field offset: 0x10
		internal int currency_negative_pattern; //Field offset: 0x14
		internal int currency_positive_pattern; //Field offset: 0x18
		internal int currency_symbol; //Field offset: 0x1C
		internal int nan_symbol; //Field offset: 0x20
		internal int negative_infinity_symbol; //Field offset: 0x24
		internal int negative_sign; //Field offset: 0x28
		internal int number_decimal_digits; //Field offset: 0x2C
		internal int number_decimal_separator; //Field offset: 0x30
		internal int number_group_separator; //Field offset: 0x34
		internal int number_group_sizes0; //Field offset: 0x38
		internal int number_group_sizes1; //Field offset: 0x3C
		internal int number_negative_pattern; //Field offset: 0x40
		internal int per_mille_symbol; //Field offset: 0x44
		internal int percent_negative_pattern; //Field offset: 0x48
		internal int percent_positive_pattern; //Field offset: 0x4C
		internal int percent_symbol; //Field offset: 0x50
		internal int positive_infinity_symbol; //Field offset: 0x54
		internal int positive_sign; //Field offset: 0x58

	}

	private static CultureData s_Invariant; //Field offset: 0x0
	private string sAM1159; //Field offset: 0x10
	private string sPM2359; //Field offset: 0x18
	private string sTimeSeparator; //Field offset: 0x20
	private String[] saLongTimes; //Field offset: 0x28
	private String[] saShortTimes; //Field offset: 0x30
	private int iFirstDayOfWeek; //Field offset: 0x38
	private int iFirstWeekOfYear; //Field offset: 0x3C
	private Int32[] waCalendars; //Field offset: 0x40
	private CalendarData[] calendars; //Field offset: 0x48
	private string sISO639Language; //Field offset: 0x50
	private readonly string sRealName; //Field offset: 0x58
	private bool bUseOverrides; //Field offset: 0x60
	private int calendarId; //Field offset: 0x64
	private int numberIndex; //Field offset: 0x68
	private int iDefaultAnsiCodePage; //Field offset: 0x6C
	private int iDefaultOemCodePage; //Field offset: 0x70
	private int iDefaultMacCodePage; //Field offset: 0x74
	private int iDefaultEbcdicCodePage; //Field offset: 0x78
	private bool isRightToLeft; //Field offset: 0x7C
	private string sListSeparator; //Field offset: 0x80

	internal Int32[] CalendarIds
	{
		internal get { } //Length: 428
	}

	internal string CultureName
	{
		internal get { } //Length: 5
	}

	internal int IFIRSTDAYOFWEEK
	{
		internal get { } //Length: 4
	}

	internal int IFIRSTWEEKOFYEAR
	{
		internal get { } //Length: 4
	}

	public static CultureData Invariant
	{
		 get { } //Length: 1019
	}

	internal bool IsInvariantCulture
	{
		internal get { } //Length: 11
	}

	internal String[] LongTimes
	{
		internal get { } //Length: 24
	}

	internal string SAM1159
	{
		internal get { } //Length: 5
	}

	internal string SCOMPAREINFO
	{
		internal get { } //Length: 44
	}

	internal String[] ShortTimes
	{
		internal get { } //Length: 24
	}

	internal string SISO639LANGNAME
	{
		internal get { } //Length: 5
	}

	internal string SPM2359
	{
		internal get { } //Length: 5
	}

	internal string STEXTINFO
	{
		internal get { } //Length: 5
	}

	internal string TimeSeparator
	{
		internal get { } //Length: 5
	}

	internal bool UseUserOverride
	{
		internal get { } //Length: 5
	}

	private CultureData(string name) { }

	internal String[] AbbrevEraNames(int calendarId) { }

	internal String[] AbbreviatedDayNames(int calendarId) { }

	internal String[] AbbreviatedEnglishEraNames(int calendarId) { }

	internal String[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	internal String[] AbbreviatedMonthNames(int calendarId) { }

	private Int32[] create_group_sizes_array(int gs0, int gs1) { }

	internal string DateSeparator(int calendarId) { }

	internal String[] DayNames(int calendarId) { }

	internal String[] EraNames(int calendarId) { }

	private void fill_culture_data(int datetimeIndex) { }

	private static Byte* fill_number_data(int index, ref NumberFormatEntryManaged nfe) { }

	internal String[] GenitiveMonthNames(int calendarId) { }

	internal Int32[] get_CalendarIds() { }

	internal string get_CultureName() { }

	internal int get_IFIRSTDAYOFWEEK() { }

	internal int get_IFIRSTWEEKOFYEAR() { }

	public static CultureData get_Invariant() { }

	internal bool get_IsInvariantCulture() { }

	internal String[] get_LongTimes() { }

	internal string get_SAM1159() { }

	internal string get_SCOMPAREINFO() { }

	internal String[] get_ShortTimes() { }

	internal string get_SISO639LANGNAME() { }

	internal string get_SPM2359() { }

	internal string get_STEXTINFO() { }

	internal string get_TimeSeparator() { }

	internal bool get_UseUserOverride() { }

	public CalendarData GetCalendar(int calendarId) { }

	internal CalendarId[] GetCalendarIds() { }

	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	private static string GetDateSeparator(string format) { }

	internal void GetNFIValues(NumberFormatInfo nfi) { }

	private static string GetSeparator(string format, string timeParts) { }

	private static string idx2string(Byte* data, int idx) { }

	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	internal String[] LeapYearMonthNames(int calendarId) { }

	internal String[] LongDates(int calendarId) { }

	internal string MonthDay(int calendarId) { }

	internal String[] MonthNames(int calendarId) { }

	internal static string ReescapeWin32String(string str) { }

	internal static String[] ReescapeWin32Strings(String[] array) { }

	internal String[] ShortDates(int calendarId) { }

	private static int strlen(Byte* s) { }

	private static string UnescapeNlsString(string str, int start, int end) { }

	internal String[] YearMonths(int calendarId) { }

}

