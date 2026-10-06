namespace System.Globalization;

[ComVisible(True)]
public class ThaiBuddhistCalendar : Calendar
{
	internal static EraInfo[] thaiBuddhistEraInfo; //Field offset: 0x0
	internal GregorianCalendarHelper helper; //Field offset: 0x20

	public virtual Int32[] Eras
	{
		 get { } //Length: 29
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
		 set { } //Length: 323
	}

	private static ThaiBuddhistCalendar() { }

	public ThaiBuddhistCalendar() { }

	public virtual Int32[] get_Eras() { }

	internal virtual int get_ID() { }

	public virtual DateTime get_MaxSupportedDateTime() { }

	public virtual DateTime get_MinSupportedDateTime() { }

	public virtual int get_TwoDigitYearMax() { }

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

