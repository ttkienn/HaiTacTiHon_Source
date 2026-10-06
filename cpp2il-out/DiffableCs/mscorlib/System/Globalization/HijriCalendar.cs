namespace System.Globalization;

[ComVisible(True)]
public class HijriCalendar : Calendar
{
	public static readonly int HijriEra; //Field offset: 0x0
	internal static readonly Int32[] HijriMonthDays; //Field offset: 0x8
	internal static readonly DateTime calendarMinValue; //Field offset: 0x10
	internal static readonly DateTime calendarMaxValue; //Field offset: 0x18
	private int m_HijriAdvance; //Field offset: 0x20

	public virtual Int32[] Eras
	{
		 get { } //Length: 137
	}

	public int HijriAdjustment
	{
		 get { } //Length: 83
	}

	internal virtual int ID
	{
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	public virtual DateTime MaxSupportedDateTime
	{
		 get { } //Length: 79
	}

	[ComVisible(False)]
	public virtual DateTime MinSupportedDateTime
	{
		 get { } //Length: 79
	}

	public virtual int TwoDigitYearMax
	{
		 get { } //Length: 108
		 set { } //Length: 284
	}

	private static HijriCalendar() { }

	public HijriCalendar() { }

	internal static void CheckEraRange(int era) { }

	internal static void CheckTicksRange(long ticks) { }

	internal static void CheckYearMonthRange(int year, int month, int era) { }

	internal static void CheckYearRange(int year, int era) { }

	private long DaysUpToHijriYear(int HijriYear) { }

	public virtual Int32[] get_Eras() { }

	public int get_HijriAdjustment() { }

	internal virtual int get_ID() { }

	public virtual DateTime get_MaxSupportedDateTime() { }

	public virtual DateTime get_MinSupportedDateTime() { }

	public virtual int get_TwoDigitYearMax() { }

	private long GetAbsoluteDateHijri(int y, int m, int d) { }

	private static int GetAdvanceHijriDate() { }

	internal override int GetDatePart(long ticks, int part) { }

	public virtual int GetDayOfMonth(DateTime time) { }

	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	public virtual int GetDaysInMonth(int year, int month, int era) { }

	public virtual int GetDaysInYear(int year, int era) { }

	public virtual int GetEra(DateTime time) { }

	public virtual int GetMonth(DateTime time) { }

	public virtual int GetMonthsInYear(int year, int era) { }

	public virtual int GetYear(DateTime time) { }

	public virtual bool IsLeapYear(int year, int era) { }

	public virtual void set_TwoDigitYearMax(int value) { }

	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	public virtual int ToFourDigitYear(int year) { }

}

