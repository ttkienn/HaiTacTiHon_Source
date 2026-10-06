namespace System.Globalization;

[ComVisible(True)]
public abstract class Calendar : ICloneable
{
	internal const long TicksPerMillisecond = 10000; //Field offset: 0x0
	internal const int CAL_HEBREW = 8; //Field offset: 0x0
	internal const int CAL_GREGORIAN_ME_FRENCH = 9; //Field offset: 0x0
	internal const int CAL_GREGORIAN_ARABIC = 10; //Field offset: 0x0
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11; //Field offset: 0x0
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12; //Field offset: 0x0
	internal const int CAL_JULIAN = 13; //Field offset: 0x0
	internal const int CAL_JAPANESELUNISOLAR = 14; //Field offset: 0x0
	internal const int CAL_THAI = 7; //Field offset: 0x0
	internal const int CAL_CHINESELUNISOLAR = 15; //Field offset: 0x0
	internal const int CAL_LUNAR_ETO_CHN = 17; //Field offset: 0x0
	internal const int CAL_LUNAR_ETO_KOR = 18; //Field offset: 0x0
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19; //Field offset: 0x0
	internal const int CAL_KOREANLUNISOLAR = 20; //Field offset: 0x0
	internal const int CAL_TAIWANLUNISOLAR = 21; //Field offset: 0x0
	internal const int CAL_PERSIAN = 22; //Field offset: 0x0
	internal const int CAL_UMALQURA = 23; //Field offset: 0x0
	internal const int CAL_SAKA = 16; //Field offset: 0x0
	public const int CurrentEra = 0; //Field offset: 0x0
	internal const int CAL_HIJRI = 6; //Field offset: 0x0
	internal const int CAL_TAIWAN = 4; //Field offset: 0x0
	internal const long TicksPerSecond = 10000000; //Field offset: 0x0
	internal const long TicksPerMinute = 600000000; //Field offset: 0x0
	internal const long TicksPerHour = 36000000000; //Field offset: 0x0
	internal const long TicksPerDay = 864000000000; //Field offset: 0x0
	internal const int MillisPerSecond = 1000; //Field offset: 0x0
	internal const int MillisPerMinute = 60000; //Field offset: 0x0
	internal const int MillisPerHour = 3600000; //Field offset: 0x0
	internal const int CAL_KOREA = 5; //Field offset: 0x0
	internal const int MillisPerDay = 86400000; //Field offset: 0x0
	internal const int DaysPer4Years = 1461; //Field offset: 0x0
	internal const int DaysPer100Years = 36524; //Field offset: 0x0
	internal const int DaysPer400Years = 146097; //Field offset: 0x0
	internal const int DaysTo10000 = 3652059; //Field offset: 0x0
	internal const long MaxMillis = 315537897600000; //Field offset: 0x0
	internal const int CAL_GREGORIAN = 1; //Field offset: 0x0
	internal const int CAL_GREGORIAN_US = 2; //Field offset: 0x0
	internal const int CAL_JAPAN = 3; //Field offset: 0x0
	internal const int DaysPerYear = 365; //Field offset: 0x0
	internal int m_currentEraValue; //Field offset: 0x10
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; //Field offset: 0x14
	internal int twoDigitYearMax; //Field offset: 0x18

	internal override int BaseCalendarID
	{
		internal get { } //Length: 20
	}

	internal override int CurrentEraValue
	{
		internal get { } //Length: 516
	}

	public abstract Int32[] Eras
	{
		 get { } //Length: 0
	}

	internal override int ID
	{
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime
	{
		 get { } //Length: 79
	}

	[ComVisible(False)]
	public override DateTime MinSupportedDateTime
	{
		 get { } //Length: 79
	}

	public override int TwoDigitYearMax
	{
		 get { } //Length: 4
		 set { } //Length: 36
	}

	protected Calendar() { }

	[ComVisible(False)]
	public override object Clone() { }

	internal override int get_BaseCalendarID() { }

	internal override int get_CurrentEraValue() { }

	public abstract Int32[] get_Eras() { }

	internal override int get_ID() { }

	public override DateTime get_MaxSupportedDateTime() { }

	public override DateTime get_MinSupportedDateTime() { }

	public override int get_TwoDigitYearMax() { }

	public abstract int GetDayOfMonth(DateTime time) { }

	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	public abstract int GetDaysInMonth(int year, int month, int era) { }

	public abstract int GetDaysInYear(int year, int era) { }

	public abstract int GetEra(DateTime time) { }

	public abstract int GetMonth(DateTime time) { }

	public abstract int GetMonthsInYear(int year, int era) { }

	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }

	public abstract int GetYear(DateTime time) { }

	public override bool IsLeapYear(int year) { }

	public abstract bool IsLeapYear(int year, int era) { }

	internal override bool IsValidDay(int year, int month, int day, int era) { }

	internal override bool IsValidMonth(int year, int month, int era) { }

	internal override bool IsValidYear(int year, int era) { }

	public override void set_TwoDigitYearMax(int value) { }

	internal void SetReadOnlyState(bool readOnly) { }

	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	public override int ToFourDigitYear(int year) { }

	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	internal void VerifyWritable() { }

}

