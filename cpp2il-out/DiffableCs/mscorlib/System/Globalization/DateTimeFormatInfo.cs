namespace System.Globalization;

public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable
{
	public class TokenHashValue
	{
		internal string tokenString; //Field offset: 0x10
		internal TokenType tokenType; //Field offset: 0x18
		internal int tokenValue; //Field offset: 0x1C

		internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue) { }

	}

	private static DateTimeFormatInfo s_invariantInfo; //Field offset: 0x0
	internal const string KoreanYearSuff = "년"; //Field offset: 0x0
	internal const string CJKDaySuff = "日"; //Field offset: 0x0
	internal const string CJKMonthSuff = "月"; //Field offset: 0x0
	internal const string CJKYearSuff = "年"; //Field offset: 0x0
	internal const string IgnorableComma = ","; //Field offset: 0x0
	internal const string IgnorablePeriod = "."; //Field offset: 0x0
	internal const string KoreanMonthSuff = "월"; //Field offset: 0x0
	private const string invariantTimeSeparator = ":"; //Field offset: 0x0
	private const string dateSeparatorOrTimeZoneOffset = "-"; //Field offset: 0x0
	private const int SECOND_PRIME = 197; //Field offset: 0x0
	private const int TOKEN_HASH_SIZE = 199; //Field offset: 0x0
	internal const DateTimeStyles InvalidDateTimeStyles = -256; //Field offset: 0x0
	internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz"; //Field offset: 0x0
	internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"; //Field offset: 0x0
	private const string invariantDateSeparator = "/"; //Field offset: 0x0
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132; //Field offset: 0x0
	internal const string KoreanDaySuff = "일"; //Field offset: 0x0
	private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'"; //Field offset: 0x0
	internal const string EnglishLangName = "en"; //Field offset: 0x0
	internal const string JapaneseLangName = "ja"; //Field offset: 0x0
	internal const string KoreanLangName = "ko"; //Field offset: 0x0
	internal const string ZuluName = "Z"; //Field offset: 0x0
	internal const string GMTName = "GMT"; //Field offset: 0x0
	internal const string LocalTimeMark = "T"; //Field offset: 0x0
	internal const string KoreanHourSuff = "시"; //Field offset: 0x0
	internal const string JapaneseEraStart = "元"; //Field offset: 0x0
	internal const string CJKMinuteSuff = "分"; //Field offset: 0x0
	internal const string ChineseHourSuff = "时"; //Field offset: 0x0
	internal const string CJKHourSuff = "時"; //Field offset: 0x0
	internal const string KoreanSecondSuff = "초"; //Field offset: 0x0
	internal const string KoreanMinuteSuff = "분"; //Field offset: 0x0
	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"; //Field offset: 0x0
	private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss"; //Field offset: 0x0
	internal const string CJKSecondSuff = "秒"; //Field offset: 0x0
	private static readonly Char[] s_monthSpaces; //Field offset: 0x8
	private static DateTimeFormatInfo s_jajpDTFI; //Field offset: 0x10
	private static DateTimeFormatInfo s_zhtwDTFI; //Field offset: 0x18
	private CultureData _cultureData; //Field offset: 0x10
	private string _name; //Field offset: 0x18
	private string _langName; //Field offset: 0x20
	private CompareInfo _compareInfo; //Field offset: 0x28
	private CultureInfo _cultureInfo; //Field offset: 0x30
	private string amDesignator; //Field offset: 0x38
	private string pmDesignator; //Field offset: 0x40
	private string dateSeparator; //Field offset: 0x48
	private string generalShortTimePattern; //Field offset: 0x50
	private string generalLongTimePattern; //Field offset: 0x58
	private string timeSeparator; //Field offset: 0x60
	private string monthDayPattern; //Field offset: 0x68
	private string dateTimeOffsetPattern; //Field offset: 0x70
	private Calendar calendar; //Field offset: 0x78
	private int firstDayOfWeek; //Field offset: 0x80
	private int calendarWeekRule; //Field offset: 0x84
	private string fullDateTimePattern; //Field offset: 0x88
	private String[] abbreviatedDayNames; //Field offset: 0x90
	private String[] m_superShortDayNames; //Field offset: 0x98
	private String[] dayNames; //Field offset: 0xA0
	private String[] abbreviatedMonthNames; //Field offset: 0xA8
	private String[] monthNames; //Field offset: 0xB0
	private String[] genitiveMonthNames; //Field offset: 0xB8
	private String[] m_genitiveAbbreviatedMonthNames; //Field offset: 0xC0
	private String[] leapYearMonthNames; //Field offset: 0xC8
	private string longDatePattern; //Field offset: 0xD0
	private string shortDatePattern; //Field offset: 0xD8
	private string yearMonthPattern; //Field offset: 0xE0
	private string longTimePattern; //Field offset: 0xE8
	private string shortTimePattern; //Field offset: 0xF0
	private String[] allYearMonthPatterns; //Field offset: 0xF8
	private String[] allShortDatePatterns; //Field offset: 0x100
	private String[] allLongDatePatterns; //Field offset: 0x108
	private String[] allShortTimePatterns; //Field offset: 0x110
	private String[] allLongTimePatterns; //Field offset: 0x118
	private String[] m_eraNames; //Field offset: 0x120
	private String[] m_abbrevEraNames; //Field offset: 0x128
	private String[] m_abbrevEnglishEraNames; //Field offset: 0x130
	private CalendarId[] optionalCalendars; //Field offset: 0x138
	internal bool _isReadOnly; //Field offset: 0x140
	private DateTimeFormatFlags formatFlags; //Field offset: 0x144
	private string _fullTimeSpanPositivePattern; //Field offset: 0x148
	private string _fullTimeSpanNegativePattern; //Field offset: 0x150
	private TokenHashValue[] _dtfiTokenHash; //Field offset: 0x158

	public String[] AbbreviatedDayNames
	{
		 get { } //Length: 140
	}

	internal String[] AbbreviatedEnglishEraNames
	{
		internal get { } //Length: 118
	}

	internal String[] AbbreviatedEraNames
	{
		internal get { } //Length: 118
	}

	public String[] AbbreviatedMonthNames
	{
		 get { } //Length: 140
	}

	private String[] AllLongDatePatterns
	{
		private get { } //Length: 171
	}

	private String[] AllLongTimePatterns
	{
		private get { } //Length: 160
	}

	private String[] AllShortDatePatterns
	{
		private get { } //Length: 171
	}

	private String[] AllShortTimePatterns
	{
		private get { } //Length: 160
	}

	private String[] AllYearMonthPatterns
	{
		private get { } //Length: 171
	}

	public string AMDesignator
	{
		 get { } //Length: 57
	}

	public Calendar Calendar
	{
		 get { } //Length: 5
		 set { } //Length: 1745
	}

	internal CompareInfo CompareInfo
	{
		internal get { } //Length: 298
	}

	private CultureInfo Culture
	{
		private get { } //Length: 153
	}

	private string CultureName
	{
		private get { } //Length: 57
	}

	public static DateTimeFormatInfo CurrentInfo
	{
		 get { } //Length: 269
	}

	public string DateSeparator
	{
		 get { } //Length: 106
	}

	internal string DateTimeOffsetPattern
	{
		internal get { } //Length: 600
	}

	public String[] DayNames
	{
		 get { } //Length: 140
	}

	internal String[] EraNames
	{
		internal get { } //Length: 118
	}

	internal DateTimeFormatFlags FormatFlags
	{
		internal get { } //Length: 23
	}

	public string FullDateTimePattern
	{
		 get { } //Length: 195
	}

	internal string FullTimeSpanNegativePattern
	{
		internal get { } //Length: 320
	}

	internal string FullTimeSpanPositivePattern
	{
		internal get { } //Length: 234
	}

	internal string GeneralLongTimePattern
	{
		internal get { } //Length: 183
	}

	internal string GeneralShortTimePattern
	{
		internal get { } //Length: 183
	}

	internal bool HasForceTwoDigitYears
	{
		internal get { } //Length: 54
	}

	internal bool HasSpacesInDayNames
	{
		internal get { } //Length: 46
	}

	internal bool HasSpacesInMonthNames
	{
		internal get { } //Length: 46
	}

	internal bool HasYearMonthAdjustment
	{
		internal get { } //Length: 46
	}

	public static DateTimeFormatInfo InvariantInfo
	{
		 get { } //Length: 268
	}

	public bool IsReadOnly
	{
		 get { } //Length: 141
	}

	private string LanguageName
	{
		private get { } //Length: 57
	}

	public string LongDatePattern
	{
		 get { } //Length: 84
	}

	public string LongTimePattern
	{
		 get { } //Length: 132
	}

	public string MonthDayPattern
	{
		 get { } //Length: 106
	}

	public String[] MonthGenitiveNames
	{
		 get { } //Length: 204
	}

	public String[] MonthNames
	{
		 get { } //Length: 140
	}

	private CalendarId[] OptionalCalendars
	{
		private get { } //Length: 75
	}

	public string PMDesignator
	{
		 get { } //Length: 57
	}

	public string RFC1123Pattern
	{
		 get { } //Length: 44
	}

	public string ShortDatePattern
	{
		 get { } //Length: 84
	}

	public string ShortTimePattern
	{
		 get { } //Length: 132
	}

	public string SortableDateTimePattern
	{
		 get { } //Length: 44
	}

	public string TimeSeparator
	{
		 get { } //Length: 57
	}

	private String[] UnclonedLongDatePatterns
	{
		private get { } //Length: 118
	}

	private String[] UnclonedLongTimePatterns
	{
		private get { } //Length: 75
	}

	private String[] UnclonedShortDatePatterns
	{
		private get { } //Length: 118
	}

	private String[] UnclonedShortTimePatterns
	{
		private get { } //Length: 75
	}

	private String[] UnclonedYearMonthPatterns
	{
		private get { } //Length: 118
	}

	public string UniversalSortableDateTimePattern
	{
		 get { } //Length: 44
	}

	public string YearMonthPattern
	{
		 get { } //Length: 84
	}

	private static DateTimeFormatInfo() { }

	public DateTimeFormatInfo() { }

	internal DateTimeFormatInfo(CultureData cultureData, Calendar cal) { }

	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	private void ClearTokenHashTable() { }

	public override object Clone() { }

	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	internal TokenHashValue[] CreateTokenHashTable() { }

	public String[] get_AbbreviatedDayNames() { }

	internal String[] get_AbbreviatedEnglishEraNames() { }

	internal String[] get_AbbreviatedEraNames() { }

	public String[] get_AbbreviatedMonthNames() { }

	private String[] get_AllLongDatePatterns() { }

	private String[] get_AllLongTimePatterns() { }

	private String[] get_AllShortDatePatterns() { }

	private String[] get_AllShortTimePatterns() { }

	private String[] get_AllYearMonthPatterns() { }

	public string get_AMDesignator() { }

	public Calendar get_Calendar() { }

	internal CompareInfo get_CompareInfo() { }

	private CultureInfo get_Culture() { }

	private string get_CultureName() { }

	public static DateTimeFormatInfo get_CurrentInfo() { }

	public string get_DateSeparator() { }

	internal string get_DateTimeOffsetPattern() { }

	public String[] get_DayNames() { }

	internal String[] get_EraNames() { }

	internal DateTimeFormatFlags get_FormatFlags() { }

	public string get_FullDateTimePattern() { }

	internal string get_FullTimeSpanNegativePattern() { }

	internal string get_FullTimeSpanPositivePattern() { }

	internal string get_GeneralLongTimePattern() { }

	internal string get_GeneralShortTimePattern() { }

	internal bool get_HasForceTwoDigitYears() { }

	internal bool get_HasSpacesInDayNames() { }

	internal bool get_HasSpacesInMonthNames() { }

	internal bool get_HasYearMonthAdjustment() { }

	public static DateTimeFormatInfo get_InvariantInfo() { }

	public bool get_IsReadOnly() { }

	private string get_LanguageName() { }

	public string get_LongDatePattern() { }

	public string get_LongTimePattern() { }

	public string get_MonthDayPattern() { }

	public String[] get_MonthGenitiveNames() { }

	public String[] get_MonthNames() { }

	private CalendarId[] get_OptionalCalendars() { }

	public string get_PMDesignator() { }

	public string get_RFC1123Pattern() { }

	public string get_ShortDatePattern() { }

	public string get_ShortTimePattern() { }

	public string get_SortableDateTimePattern() { }

	public string get_TimeSeparator() { }

	private String[] get_UnclonedLongDatePatterns() { }

	private String[] get_UnclonedLongTimePatterns() { }

	private String[] get_UnclonedShortDatePatterns() { }

	private String[] get_UnclonedShortTimePatterns() { }

	private String[] get_UnclonedYearMonthPatterns() { }

	public string get_UniversalSortableDateTimePattern() { }

	public string get_YearMonthPattern() { }

	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	public string GetAbbreviatedEraName(int era) { }

	public string GetAbbreviatedMonthName(int month) { }

	public String[] GetAllDateTimePatterns(char format) { }

	private static String[] GetCombinedPatterns(String[] patterns1, String[] patterns2, string connectString) { }

	public string GetDayName(DayOfWeek dayofweek) { }

	public string GetEraName(int era) { }

	public override object GetFormat(Type formatType) { }

	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	private static String[] GetMergedPatterns(String[] patterns, string defaultPattern) { }

	public string GetMonthName(int month) { }

	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	private DateTimeFormatFlags InitializeFormatFlags() { }

	private void InitializeOverridableProperties(CultureData cultureData, int calendarId) { }

	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	private String[] internalGetAbbreviatedDayOfWeekNames() { }

	private String[] internalGetAbbreviatedDayOfWeekNamesCore() { }

	private String[] internalGetAbbreviatedMonthNames() { }

	private String[] internalGetAbbreviatedMonthNamesCore() { }

	private String[] internalGetDayOfWeekNames() { }

	private String[] internalGetDayOfWeekNamesCore() { }

	private String[] internalGetGenitiveMonthNames(bool abbreviated) { }

	internal String[] internalGetLeapYearMonthNames() { }

	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	private String[] internalGetMonthNames() { }

	private String[] internalGetMonthNamesCore() { }

	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh) { }

	private static bool IsHebrewChar(char ch) { }

	private static bool IsJapaneseCalendar(Calendar calendar) { }

	private void PopulateSpecialTokenHashTable(TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol) { }

	public void set_Calendar(Calendar value) { }

	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

}

