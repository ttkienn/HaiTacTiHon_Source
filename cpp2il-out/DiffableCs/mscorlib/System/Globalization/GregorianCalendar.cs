namespace System.Globalization;

[ComVisible(True)]
public class GregorianCalendar : Calendar
{
	internal static readonly Int32[] DaysToMonth365; //Field offset: 0x0
	internal static readonly Int32[] DaysToMonth366; //Field offset: 0x8
	private static Calendar s_defaultInstance; //Field offset: 0x10
	internal GregorianCalendarTypes m_type; //Field offset: 0x20

	public virtual Int32[] Eras
	{
		 get { } //Length: 83
	}

	internal virtual int ID
	{
		internal get { } //Length: 4
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

	private static GregorianCalendar() { }

	public GregorianCalendar() { }

	public GregorianCalendar(GregorianCalendarTypes type) { }

	public virtual Int32[] get_Eras() { }

	internal virtual int get_ID() { }

	public virtual DateTime get_MaxSupportedDateTime() { }

	public virtual DateTime get_MinSupportedDateTime() { }

	public virtual int get_TwoDigitYearMax() { }

	internal static long GetAbsoluteDate(int year, int month, int day) { }

	internal override int GetDatePart(long ticks, int part) { }

	public virtual int GetDayOfMonth(DateTime time) { }

	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	public virtual int GetDaysInMonth(int year, int month, int era) { }

	public virtual int GetDaysInYear(int year, int era) { }

	internal static Calendar GetDefaultInstance() { }

	public virtual int GetEra(DateTime time) { }

	public virtual int GetMonth(DateTime time) { }

	public virtual int GetMonthsInYear(int year, int era) { }

	public virtual int GetYear(DateTime time) { }

	public virtual bool IsLeapYear(int year, int era) { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	public virtual void set_TwoDigitYearMax(int value) { }

	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	public virtual int ToFourDigitYear(int year) { }

	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

}

