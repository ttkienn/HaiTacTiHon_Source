namespace System.Xml.Schema;

internal struct XsdDuration
{
	internal enum DurationType
	{
		Duration = 0,
		YearMonthDuration = 1,
		DayTimeDuration = 2,
	}

	private enum Parts
	{
		HasNone = 0,
		HasYears = 1,
		HasMonths = 2,
		HasDays = 4,
		HasHours = 8,
		HasMinutes = 16,
		HasSeconds = 32,
	}

	private int years; //Field offset: 0x0
	private int months; //Field offset: 0x4
	private int days; //Field offset: 0x8
	private int hours; //Field offset: 0xC
	private int minutes; //Field offset: 0x10
	private int seconds; //Field offset: 0x14
	private uint nanoseconds; //Field offset: 0x18

	public int Days
	{
		 get { } //Length: 4
	}

	public int Hours
	{
		 get { } //Length: 4
	}

	public bool IsNegative
	{
		 get { } //Length: 11
	}

	public int Minutes
	{
		 get { } //Length: 191
	}

	public int Months
	{
		 get { } //Length: 4
	}

	public int Nanoseconds
	{
		 get { } //Length: 8
	}

	public int Seconds
	{
		 get { } //Length: 4
	}

	public int Years
	{
		 get { } //Length: 3
	}

	public XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	public XsdDuration(TimeSpan timeSpan) { }

	public XsdDuration(TimeSpan timeSpan, DurationType durationType) { }

	public XsdDuration(string s) { }

	public XsdDuration(string s, DurationType durationType) { }

	public int get_Days() { }

	public int get_Hours() { }

	public bool get_IsNegative() { }

	public int get_Minutes() { }

	public int get_Months() { }

	public int get_Nanoseconds() { }

	public int get_Seconds() { }

	public int get_Years() { }

	public virtual string ToString() { }

	internal string ToString(DurationType durationType) { }

	public TimeSpan ToTimeSpan() { }

	public TimeSpan ToTimeSpan(DurationType durationType) { }

	internal static Exception TryParse(string s, DurationType durationType, out XsdDuration result) { }

	internal static Exception TryParse(string s, out XsdDuration result) { }

	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }

	internal Exception TryToTimeSpan(out TimeSpan result) { }

	internal Exception TryToTimeSpan(DurationType durationType, out TimeSpan result) { }

}

