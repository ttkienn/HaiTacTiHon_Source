namespace System.Xml.Schema;

internal struct XsdDateTime
{
	private enum DateTimeTypeCode
	{
		DateTime = 0,
		Time = 1,
		Date = 2,
		GYearMonth = 3,
		GYear = 4,
		GMonthDay = 5,
		GDay = 6,
		GMonth = 7,
		XdrDateTime = 8,
	}

	private struct Parser
	{
		private static Int32[] Power10; //Field offset: 0x0
		public DateTimeTypeCode typeCode; //Field offset: 0x0
		public int year; //Field offset: 0x4
		public int month; //Field offset: 0x8
		public int day; //Field offset: 0xC
		public int hour; //Field offset: 0x10
		public int minute; //Field offset: 0x14
		public int second; //Field offset: 0x18
		public int fraction; //Field offset: 0x1C
		public XsdDateTimeKind kind; //Field offset: 0x20
		public int zoneHour; //Field offset: 0x24
		public int zoneMinute; //Field offset: 0x28
		private string text; //Field offset: 0x30
		private int length; //Field offset: 0x38

		private static Parser() { }

		public bool Parse(string text, XsdDateTimeFlags kinds) { }

		private bool Parse2Dig(int start, ref int num) { }

		private bool Parse4Dig(int start, ref int num) { }

		private bool ParseChar(int start, char ch) { }

		private bool ParseDate(int start) { }

		private bool ParseTime(ref int start) { }

		private bool ParseTimeAndWhitespace(int start) { }

		private bool ParseTimeAndZoneAndWhitespace(int start) { }

		private bool ParseZoneAndWhitespace(int start) { }

		private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	}

	private enum XsdDateTimeKind
	{
		Unspecified = 0,
		Zulu = 1,
		LocalWestOfZulu = 2,
		LocalEastOfZulu = 3,
	}

	private static readonly int Lzyyyy; //Field offset: 0x0
	private static readonly int Lzyyyy_; //Field offset: 0x4
	private static readonly int Lzyyyy_MM; //Field offset: 0x8
	private static readonly int Lzyyyy_MM_; //Field offset: 0xC
	private static readonly int Lzyyyy_MM_dd; //Field offset: 0x10
	private static readonly int Lzyyyy_MM_ddT; //Field offset: 0x14
	private static readonly int LzHH; //Field offset: 0x18
	private static readonly int LzHH_; //Field offset: 0x1C
	private static readonly int LzHH_mm; //Field offset: 0x20
	private static readonly int LzHH_mm_; //Field offset: 0x24
	private static readonly int LzHH_mm_ss; //Field offset: 0x28
	private static readonly int Lz_; //Field offset: 0x2C
	private static readonly int Lz_zz; //Field offset: 0x30
	private static readonly int Lz_zz_; //Field offset: 0x34
	private static readonly int Lz_zz_zz; //Field offset: 0x38
	private static readonly int Lz__; //Field offset: 0x3C
	private static readonly int Lz__mm; //Field offset: 0x40
	private static readonly int Lz__mm_; //Field offset: 0x44
	private static readonly int Lz__mm__; //Field offset: 0x48
	private static readonly int Lz__mm_dd; //Field offset: 0x4C
	private static readonly int Lz___; //Field offset: 0x50
	private static readonly int Lz___dd; //Field offset: 0x54
	private static readonly XmlTypeCode[] typeCodes; //Field offset: 0x58
	private DateTime dt; //Field offset: 0x0
	private uint extra; //Field offset: 0x8

	public int Day
	{
		 get { } //Length: 73
	}

	public int Fraction
	{
		 get { } //Length: 261
	}

	public int Hour
	{
		 get { } //Length: 73
	}

	private XsdDateTimeKind InternalKind
	{
		private get { } //Length: 5
	}

	private DateTimeTypeCode InternalTypeCode
	{
		private get { } //Length: 5
	}

	public int Minute
	{
		 get { } //Length: 73
	}

	public int Month
	{
		 get { } //Length: 73
	}

	public int Second
	{
		 get { } //Length: 73
	}

	public int Year
	{
		 get { } //Length: 73
	}

	public int ZoneHour
	{
		 get { } //Length: 5
	}

	public int ZoneMinute
	{
		 get { } //Length: 5
	}

	private static XsdDateTime() { }

	public XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	public XsdDateTime(DateTimeOffset dateTimeOffset) { }

	public XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds) { }

	public XsdDateTime(string text, XsdDateTimeFlags kinds) { }

	private XsdDateTime(Parser parser) { }

	public int get_Day() { }

	public int get_Fraction() { }

	public int get_Hour() { }

	private XsdDateTimeKind get_InternalKind() { }

	private DateTimeTypeCode get_InternalTypeCode() { }

	public int get_Minute() { }

	public int get_Month() { }

	public int get_Second() { }

	public int get_Year() { }

	public int get_ZoneHour() { }

	public int get_ZoneMinute() { }

	private void InitiateXsdDateTime(Parser parser) { }

	private void IntToCharArray(Char[] text, int start, int value, int digits) { }

	public static DateTime op_Implicit(XsdDateTime xdt) { }

	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	private void PrintDate(StringBuilder sb) { }

	private void PrintTime(StringBuilder sb) { }

	private void PrintZone(StringBuilder sb) { }

	private void ShortToCharArray(Char[] text, int start, int value) { }

	public virtual string ToString() { }

	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

}

