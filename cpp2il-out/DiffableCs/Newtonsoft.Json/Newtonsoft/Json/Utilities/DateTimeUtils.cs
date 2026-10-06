namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class DateTimeUtils
{
	internal static readonly long InitialJavaScriptDateTicks; //Field offset: 0x0
	private const string IsoDateFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFFK"; //Field offset: 0x0
	private const int DaysPer100Years = 36524; //Field offset: 0x0
	private const int DaysPer400Years = 146097; //Field offset: 0x0
	private const int DaysPer4Years = 1461; //Field offset: 0x0
	private const int DaysPerYear = 365; //Field offset: 0x0
	private const long TicksPerDay = 864000000000; //Field offset: 0x0
	private static readonly Int32[] DaysToMonth365; //Field offset: 0x8
	private static readonly Int32[] DaysToMonth366; //Field offset: 0x10

	private static DateTimeUtils() { }

	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	private static void CopyIntToCharArray(Char[] chars, int start, int value, int digits) { }

	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }

	[Extension]
	public static TimeSpan GetUtcOffset(DateTime d) { }

	private static DateTime SwitchToLocalTime(DateTime value) { }

	private static DateTime SwitchToUtcTime(DateTime value) { }

	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	private static long ToUniversalTicks(DateTime dateTime) { }

	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	private static long UniversalTicksToJavaScriptTicks(long universalTicks) { }

	internal static int WriteDateTimeOffset(Char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	internal static int WriteDateTimeString(Char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	internal static int WriteDefaultIsoDate(Char[] chars, int start, DateTime dt) { }

}

