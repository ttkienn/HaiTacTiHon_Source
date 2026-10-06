namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal struct DateTimeParser
{
	private const short MaxFractionDigits = 7; //Field offset: 0x0
	private static readonly Int32[] Power10; //Field offset: 0x0
	private static readonly int Lzyyyy; //Field offset: 0x8
	private static readonly int Lzyyyy_; //Field offset: 0xC
	private static readonly int Lzyyyy_MM; //Field offset: 0x10
	private static readonly int Lzyyyy_MM_; //Field offset: 0x14
	private static readonly int Lzyyyy_MM_dd; //Field offset: 0x18
	private static readonly int Lzyyyy_MM_ddT; //Field offset: 0x1C
	private static readonly int LzHH; //Field offset: 0x20
	private static readonly int LzHH_; //Field offset: 0x24
	private static readonly int LzHH_mm; //Field offset: 0x28
	private static readonly int LzHH_mm_; //Field offset: 0x2C
	private static readonly int LzHH_mm_ss; //Field offset: 0x30
	private static readonly int Lz_; //Field offset: 0x34
	private static readonly int Lz_zz; //Field offset: 0x38
	public int Year; //Field offset: 0x0
	public int Month; //Field offset: 0x4
	public int Day; //Field offset: 0x8
	public int Hour; //Field offset: 0xC
	public int Minute; //Field offset: 0x10
	public int Second; //Field offset: 0x14
	public int Fraction; //Field offset: 0x18
	public int ZoneHour; //Field offset: 0x1C
	public int ZoneMinute; //Field offset: 0x20
	public ParserTimeZone Zone; //Field offset: 0x24
	private Char[] _text; //Field offset: 0x28
	private int _end; //Field offset: 0x30

	private static DateTimeParser() { }

	public bool Parse(Char[] text, int startIndex, int length) { }

	private bool Parse2Digit(int start, out int num) { }

	private bool Parse4Digit(int start, out int num) { }

	private bool ParseChar(int start, char ch) { }

	private bool ParseDate(int start) { }

	private bool ParseTime(ref int start) { }

	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	private bool ParseZone(int start) { }

}

