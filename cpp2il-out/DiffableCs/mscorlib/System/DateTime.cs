namespace System;

[IsReadOnly]
public struct DateTime : IComparable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanFormattable
{
	private const long TicksPerMillisecond = 10000; //Field offset: 0x0
	private const string DateDataField = "dateData"; //Field offset: 0x0
	private const double OADateMinAsDouble = -657435; //Field offset: 0x0
	private const double OADateMaxAsDouble = 2958466; //Field offset: 0x0
	private const int DatePartYear = 0; //Field offset: 0x0
	private const int DatePartDayOfYear = 1; //Field offset: 0x0
	private const int DatePartMonth = 2; //Field offset: 0x0
	private const int DatePartDay = 3; //Field offset: 0x0
	private static readonly Int32[] s_daysToMonth365; //Field offset: 0x0
	private const long DoubleDateOffset = 599264352000000000; //Field offset: 0x0
	private const ulong TicksMask = 4611686018427387903; //Field offset: 0x0
	private const ulong LocalMask = 9223372036854775808; //Field offset: 0x0
	private const long TicksCeiling = 4611686018427387904; //Field offset: 0x0
	private const ulong KindUnspecified = 0; //Field offset: 0x0
	private const ulong KindUtc = 4611686018427387904; //Field offset: 0x0
	private const ulong KindLocal = 9223372036854775808; //Field offset: 0x0
	private const ulong KindLocalAmbiguousDst = 13835058055282163712; //Field offset: 0x0
	private const int KindShift = 62; //Field offset: 0x0
	private const string TicksField = "ticks"; //Field offset: 0x0
	private const ulong FlagsMask = 13835058055282163712; //Field offset: 0x0
	private const long FileTimeOffset = 504911232000000000; //Field offset: 0x0
	private const long OADateMinAsTicks = 31241376000000000; //Field offset: 0x0
	private const long MaxMillis = 315537897600000; //Field offset: 0x0
	private const long TicksPerHour = 36000000000; //Field offset: 0x0
	private const long TicksPerDay = 864000000000; //Field offset: 0x0
	private const int MillisPerSecond = 1000; //Field offset: 0x0
	private const int MillisPerMinute = 60000; //Field offset: 0x0
	private const int MillisPerHour = 3600000; //Field offset: 0x0
	private const int MillisPerDay = 86400000; //Field offset: 0x0
	private const int DaysPerYear = 365; //Field offset: 0x0
	private const int DaysPer4Years = 1461; //Field offset: 0x0
	internal const long UnixEpochTicks = 621355968000000000; //Field offset: 0x0
	private const long TicksPerMinute = 600000000; //Field offset: 0x0
	private const long TicksPerSecond = 10000000; //Field offset: 0x0
	private const int DaysPer100Years = 36524; //Field offset: 0x0
	private const int DaysPer400Years = 146097; //Field offset: 0x0
	private const int DaysTo1601 = 584388; //Field offset: 0x0
	private const int DaysTo1899 = 693593; //Field offset: 0x0
	internal const int DaysTo1970 = 719162; //Field offset: 0x0
	private const int DaysTo10000 = 3652059; //Field offset: 0x0
	internal const long MinTicks = 0; //Field offset: 0x0
	internal const long MaxTicks = 3155378975999999999; //Field offset: 0x0
	private static readonly Int32[] s_daysToMonth366; //Field offset: 0x8
	public static readonly DateTime MinValue; //Field offset: 0x10
	public static readonly DateTime MaxValue; //Field offset: 0x18
	public static readonly DateTime UnixEpoch; //Field offset: 0x20
	private readonly ulong _dateData; //Field offset: 0x0

	public DateTime Date
	{
		 get { } //Length: 120
	}

	public int Day
	{
		 get { } //Length: 79
	}

	public DayOfWeek DayOfWeek
	{
		 get { } //Length: 134
	}

	public int Hour
	{
		 get { } //Length: 139
	}

	private ulong InternalKind
	{
		private get { } //Length: 17
	}

	internal long InternalTicks
	{
		internal get { } //Length: 17
	}

	public DateTimeKind Kind
	{
		 get { } //Length: 110
	}

	public int Millisecond
	{
		 get { } //Length: 140
	}

	public int Minute
	{
		 get { } //Length: 140
	}

	public int Month
	{
		 get { } //Length: 79
	}

	public static DateTime Now
	{
		 get { } //Length: 497
	}

	public int Second
	{
		 get { } //Length: 140
	}

	public long Ticks
	{
		 get { } //Length: 80
	}

	public TimeSpan TimeOfDay
	{
		 get { } //Length: 98
	}

	public static DateTime UtcNow
	{
		 get { } //Length: 89
	}

	public int Year
	{
		 get { } //Length: 76
	}

	private static DateTime() { }

	private DateTime(SerializationInfo info, StreamingContext context) { }

	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar) { }

	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) { }

	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	public DateTime(long ticks) { }

	public DateTime(int year, int month, int day) { }

	internal DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	public DateTime(long ticks, DateTimeKind kind) { }

	private DateTime(ulong dateData) { }

	public DateTime(int year, int month, int day, int hour, int minute, int second) { }

	public DateTime Add(TimeSpan value) { }

	private DateTime Add(double value, int scale) { }

	public DateTime AddDays(double value) { }

	public DateTime AddMilliseconds(double value) { }

	public DateTime AddMonths(int months) { }

	public DateTime AddSeconds(double value) { }

	public DateTime AddTicks(long value) { }

	public DateTime AddYears(int value) { }

	public static int Compare(DateTime t1, DateTime t2) { }

	public override int CompareTo(DateTime value) { }

	public override int CompareTo(object value) { }

	private static long DateToTicks(int year, int month, int day) { }

	public static int DaysInMonth(int year, int month) { }

	public virtual bool Equals(object value) { }

	public override bool Equals(DateTime value) { }

	public static DateTime FromBinary(long dateData) { }

	internal static DateTime FromBinaryRaw(long dateData) { }

	public static DateTime FromFileTime(long fileTime) { }

	public static DateTime FromFileTimeUtc(long fileTime) { }

	public DateTime get_Date() { }

	public int get_Day() { }

	public DayOfWeek get_DayOfWeek() { }

	public int get_Hour() { }

	private ulong get_InternalKind() { }

	internal long get_InternalTicks() { }

	public DateTimeKind get_Kind() { }

	public int get_Millisecond() { }

	public int get_Minute() { }

	public int get_Month() { }

	public static DateTime get_Now() { }

	public int get_Second() { }

	public long get_Ticks() { }

	public TimeSpan get_TimeOfDay() { }

	public static DateTime get_UtcNow() { }

	public int get_Year() { }

	internal void GetDatePart(out int year, out int month, out int day) { }

	private int GetDatePart(int part) { }

	public virtual int GetHashCode() { }

	internal static long GetSystemTimeAsFileTime() { }

	public override TypeCode GetTypeCode() { }

	internal bool IsAmbiguousDaylightSavingTime() { }

	public static bool IsLeapYear(int year) { }

	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	public static bool op_Equality(DateTime d1, DateTime d2) { }

	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) { }

	public static DateTime Parse(string s, IFormatProvider provider) { }

	public static DateTime ParseExact(string s, String[] formats, IFormatProvider provider, DateTimeStyles style) { }

	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	public TimeSpan Subtract(DateTime value) { }

	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	private static long TimeToTicks(int hour, int minute, int second) { }

	internal long ToBinaryRaw() { }

	public DateTime ToLocalTime() { }

	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	public virtual string ToString() { }

	public override string ToString(IFormatProvider provider) { }

	public override string ToString(string format, IFormatProvider provider) { }

	public DateTime ToUniversalTime() { }

	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

}

