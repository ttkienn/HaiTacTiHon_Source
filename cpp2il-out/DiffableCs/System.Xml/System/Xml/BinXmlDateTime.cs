namespace System.Xml;

internal abstract class BinXmlDateTime
{
	internal static Int32[] KatmaiTimeScaleMultiplicator; //Field offset: 0x0
	private static readonly double SQLTicksPerMillisecond; //Field offset: 0x8
	public static readonly int SQLTicksPerSecond; //Field offset: 0x10
	public static readonly int SQLTicksPerMinute; //Field offset: 0x14
	public static readonly int SQLTicksPerHour; //Field offset: 0x18
	private static readonly int SQLTicksPerDay; //Field offset: 0x1C

	private static BinXmlDateTime() { }

	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	private static int GetFractions(DateTime dt) { }

	private static int GetFractions(DateTimeOffset dt) { }

	private static long GetKatmaiDateTicks(Byte[] data, ref int pos) { }

	private static long GetKatmaiTimeTicks(Byte[] data, ref int pos) { }

	private static long GetKatmaiTimeZoneTicks(Byte[] data, int pos) { }

	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	private static void Write2Dig(StringBuilder sb, int val) { }

	private static void Write3Dec(StringBuilder sb, int val) { }

	private static void Write4DigNeg(StringBuilder sb, int val) { }

	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	public static string XsdDateTimeToString(long val) { }

	public static string XsdDateToString(long val) { }

	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(Byte[] data, int offset) { }

	public static string XsdKatmaiDateOffsetToString(Byte[] data, int offset) { }

	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	public static string XsdKatmaiDateTimeOffsetToString(Byte[] data, int offset) { }

	public static DateTime XsdKatmaiDateTimeToDateTime(Byte[] data, int offset) { }

	public static string XsdKatmaiDateTimeToString(Byte[] data, int offset) { }

	public static DateTime XsdKatmaiDateToDateTime(Byte[] data, int offset) { }

	public static string XsdKatmaiDateToString(Byte[] data, int offset) { }

	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	public static string XsdKatmaiTimeOffsetToString(Byte[] data, int offset) { }

	public static DateTime XsdKatmaiTimeToDateTime(Byte[] data, int offset) { }

	public static string XsdKatmaiTimeToString(Byte[] data, int offset) { }

	public static string XsdTimeToString(long val) { }

}

