namespace System.Globalization;

public class UmAlQuraCalendar : Calendar
{
	public struct DateMapping
	{
		internal int HijriMonthsLengthFlags; //Field offset: 0x0
		internal DateTime GregorianDate; //Field offset: 0x8

		internal DateMapping(int MonthsLengthFlags, int GYear, int GMonth, int GDay) { }

	}

	private static readonly DateMapping[] HijriYearInfo; //Field offset: 0x0
	internal static DateTime minDate; //Field offset: 0x8
	internal static DateTime maxDate; //Field offset: 0x10

	internal virtual int BaseCalendarID
	{
		internal get { } //Length: 6
	}

	public virtual Int32[] Eras
	{
		 get { } //Length: 83
	}

	internal virtual int ID
	{
		internal get { } //Length: 6
	}

	public virtual DateTime MaxSupportedDateTime
	{
		 get { } //Length: 79
	}

	public virtual DateTime MinSupportedDateTime
	{
		 get { } //Length: 79
	}

	public virtual int TwoDigitYearMax
	{
		 get { } //Length: 108
		 set { } //Length: 383
	}

	private static UmAlQuraCalendar() { }

	public UmAlQuraCalendar() { }

	internal static void CheckEraRange(int era) { }

	internal static void CheckTicksRange(long ticks) { }

	internal static void CheckYearMonthRange(int year, int month, int era) { }

	internal static void CheckYearRange(int year, int era) { }

	private static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay) { }

	private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg) { }

	internal virtual int get_BaseCalendarID() { }

	public virtual Int32[] get_Eras() { }

	internal virtual int get_ID() { }

	public virtual DateTime get_MaxSupportedDateTime() { }

	public virtual DateTime get_MinSupportedDateTime() { }

	public virtual int get_TwoDigitYearMax() { }

	private static long GetAbsoluteDateUmAlQura(int year, int month, int day) { }

	internal override int GetDatePart(DateTime time, int part) { }

	public virtual int GetDayOfMonth(DateTime time) { }

	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	public virtual int GetDaysInMonth(int year, int month, int era) { }

	public virtual int GetDaysInYear(int year, int era) { }

	public virtual int GetEra(DateTime time) { }

	public virtual int GetMonth(DateTime time) { }

	public virtual int GetMonthsInYear(int year, int era) { }

	public virtual int GetYear(DateTime time) { }

	private static DateMapping[] InitDateMapping() { }

	public virtual bool IsLeapYear(int year, int era) { }

	internal static int RealGetDaysInYear(int year) { }

	public virtual void set_TwoDigitYearMax(int value) { }

	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	public virtual int ToFourDigitYear(int year) { }

}

