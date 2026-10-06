namespace System.Globalization;

internal class GregorianCalendarHelper
{
	internal static readonly Int32[] DaysToMonth365; //Field offset: 0x0
	internal static readonly Int32[] DaysToMonth366; //Field offset: 0x8
	[OptionalField(VersionAdded = 1)]
	internal int m_maxYear; //Field offset: 0x10
	[OptionalField(VersionAdded = 1)]
	internal int m_minYear; //Field offset: 0x14
	internal Calendar m_Cal; //Field offset: 0x18
	[OptionalField(VersionAdded = 1)]
	internal EraInfo[] m_EraInfo; //Field offset: 0x20
	[OptionalField(VersionAdded = 1)]
	internal Int32[] m_eras; //Field offset: 0x28
	[OptionalField(VersionAdded = 1)]
	internal DateTime m_minDate; //Field offset: 0x30

	public Int32[] Eras
	{
		 get { } //Length: 309
	}

	internal int MaxYear
	{
		internal get { } //Length: 191
	}

	private static GregorianCalendarHelper() { }

	internal GregorianCalendarHelper(Calendar cal, EraInfo[] eraInfo) { }

	internal void CheckTicksRange(long ticks) { }

	internal static long DateToTicks(int year, int month, int day) { }

	public Int32[] get_Eras() { }

	internal int get_MaxYear() { }

	internal static long GetAbsoluteDate(int year, int month, int day) { }

	internal override int GetDatePart(long ticks, int part) { }

	public int GetDayOfMonth(DateTime time) { }

	public DayOfWeek GetDayOfWeek(DateTime time) { }

	public int GetDaysInMonth(int year, int month, int era) { }

	public int GetDaysInYear(int year, int era) { }

	public int GetEra(DateTime time) { }

	internal int GetGregorianYear(int year, int era) { }

	public int GetMonth(DateTime time) { }

	public int GetMonthsInYear(int year, int era) { }

	public int GetYear(DateTime time) { }

	private int GetYearOffset(int year, int era, bool throwOnError) { }

	public bool IsLeapYear(int year, int era) { }

	internal bool IsValidYear(int year, int era) { }

	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	public int ToFourDigitYear(int year, int twoDigitYearMax) { }

}

