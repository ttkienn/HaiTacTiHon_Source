namespace System;

[IsReadOnly]
public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable
{
	public const long TicksPerMillisecond = 10000; //Field offset: 0x0
	public static readonly TimeSpan Zero; //Field offset: 0x0
	internal const long TicksPerTenthSecond = 1000000; //Field offset: 0x0
	internal const long MinMilliSeconds = -922337203685477; //Field offset: 0x0
	internal const long MaxMilliSeconds = 922337203685477; //Field offset: 0x0
	internal const long MinSeconds = -922337203685; //Field offset: 0x0
	internal const long MaxSeconds = 922337203685; //Field offset: 0x0
	private const int MillisPerDay = 86400000; //Field offset: 0x0
	private const int MillisPerHour = 3600000; //Field offset: 0x0
	private const int MillisPerSecond = 1000; //Field offset: 0x0
	private const int MillisPerMinute = 60000; //Field offset: 0x0
	public const long TicksPerDay = 864000000000; //Field offset: 0x0
	private const double HoursPerTick = 2.7777777777777777E-11; //Field offset: 0x0
	public const long TicksPerHour = 36000000000; //Field offset: 0x0
	private const double MinutesPerTick = 1.6666666666666667E-09; //Field offset: 0x0
	public const long TicksPerMinute = 600000000; //Field offset: 0x0
	private const double SecondsPerTick = 1E-07; //Field offset: 0x0
	public const long TicksPerSecond = 10000000; //Field offset: 0x0
	private const double MillisecondsPerTick = 0.0001; //Field offset: 0x0
	private const double DaysPerTick = 1.1574074074074074E-12; //Field offset: 0x0
	public static readonly TimeSpan MaxValue; //Field offset: 0x8
	public static readonly TimeSpan MinValue; //Field offset: 0x10
	internal readonly long _ticks; //Field offset: 0x0

	public int Days
	{
		 get { } //Length: 19
	}

	public int Hours
	{
		 get { } //Length: 63
	}

	public int Minutes
	{
		 get { } //Length: 71
	}

	public int Seconds
	{
		 get { } //Length: 75
	}

	public long Ticks
	{
		 get { } //Length: 4
	}

	public double TotalDays
	{
		 get { } //Length: 17
	}

	public double TotalHours
	{
		 get { } //Length: 17
	}

	public double TotalMilliseconds
	{
		 get { } //Length: 48
	}

	public double TotalMinutes
	{
		 get { } //Length: 17
	}

	public double TotalSeconds
	{
		 get { } //Length: 17
	}

	private static TimeSpan() { }

	public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) { }

	public TimeSpan(long ticks) { }

	public TimeSpan(int hours, int minutes, int seconds) { }

	public TimeSpan(int days, int hours, int minutes, int seconds) { }

	public TimeSpan Add(TimeSpan ts) { }

	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	public override int CompareTo(TimeSpan value) { }

	public override int CompareTo(object value) { }

	public override bool Equals(TimeSpan obj) { }

	public virtual bool Equals(object value) { }

	public static TimeSpan FromDays(double value) { }

	public static TimeSpan FromHours(double value) { }

	public static TimeSpan FromMilliseconds(double value) { }

	public static TimeSpan FromMinutes(double value) { }

	public static TimeSpan FromSeconds(double value) { }

	public static TimeSpan FromTicks(long value) { }

	public int get_Days() { }

	public int get_Hours() { }

	public int get_Minutes() { }

	public int get_Seconds() { }

	public long get_Ticks() { }

	public double get_TotalDays() { }

	public double get_TotalHours() { }

	public double get_TotalMilliseconds() { }

	public double get_TotalMinutes() { }

	public double get_TotalSeconds() { }

	public virtual int GetHashCode() { }

	private static TimeSpan Interval(double value, int scale) { }

	public TimeSpan Negate() { }

	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	public static TimeSpan op_UnaryNegation(TimeSpan t) { }

	public static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	public static TimeSpan Parse(string s) { }

	public TimeSpan Subtract(TimeSpan ts) { }

	internal static long TimeToTicks(int hour, int minute, int second) { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	public virtual string ToString() { }

	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider formatProvider = null) { }

}

