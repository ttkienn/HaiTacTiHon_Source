namespace System.Security.Cryptography;

internal class DerSequenceReader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Encoding> <>9__45_0; //Field offset: 0x8
		public static Func<Encoding> <>9__45_1; //Field offset: 0x10
		public static Func<DateTimeFormatInfo> <>9__51_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal Encoding <ReadT61String>b__45_0() { }

		internal Encoding <ReadT61String>b__45_1() { }

		internal DateTimeFormatInfo <ReadTime>b__51_0() { }

	}

	public enum DerTag
	{
		Boolean = 1,
		Integer = 2,
		BitString = 3,
		OctetString = 4,
		Null = 5,
		ObjectIdentifier = 6,
		UTF8String = 12,
		Sequence = 16,
		Set = 17,
		PrintableString = 19,
		T61String = 20,
		IA5String = 22,
		UTCTime = 23,
		GeneralizedTime = 24,
		BMPString = 30,
	}

	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo; //Field offset: 0x0
	private static Encoding s_utf8EncodingWithExceptionFallback; //Field offset: 0x8
	private static Encoding s_latin1Encoding; //Field offset: 0x10
	private readonly Byte[] _data; //Field offset: 0x10
	private readonly int _end; //Field offset: 0x18
	private int _position; //Field offset: 0x1C
	[CompilerGenerated]
	private int <ContentLength>k__BackingField; //Field offset: 0x20

	private int ContentLength
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal bool HasData
	{
		internal get { } //Length: 10
	}

	internal DerSequenceReader(Byte[] data) { }

	internal DerSequenceReader(Byte[] data, int offset, int length) { }

	private DerSequenceReader(DerTag tagToEat, Byte[] data, int offset, int length) { }

	private static void CheckTag(DerTag expected, Byte[] data, int position) { }

	private int EatLength() { }

	private void EatTag(DerTag expected) { }

	internal bool get_HasData() { }

	internal byte PeekTag() { }

	internal Byte[] ReadBitString() { }

	internal string ReadBMPString() { }

	internal bool ReadBoolean() { }

	private DerSequenceReader ReadCollectionWithTag(DerTag expected) { }

	private Byte[] ReadContentAsBytes() { }

	internal DateTime ReadGeneralizedTime() { }

	internal string ReadIA5String() { }

	internal int ReadInteger() { }

	internal Byte[] ReadIntegerBytes() { }

	internal Byte[] ReadNextEncodedValue() { }

	internal Byte[] ReadOctetString() { }

	internal string ReadOidAsString() { }

	internal string ReadPrintableString() { }

	internal DerSequenceReader ReadSequence() { }

	internal DerSequenceReader ReadSet() { }

	internal string ReadT61String() { }

	private DateTime ReadTime(DerTag timeTag, string formatString) { }

	internal DateTime ReadUtcTime() { }

	internal string ReadUtf8String() { }

	internal DateTime ReadX509Date() { }

	private static int ScanContentLength(Byte[] data, int offset, int end, out int bytesConsumed) { }

	[CompilerGenerated]
	private void set_ContentLength(int value) { }

	internal void SkipValue() { }

	private static string TrimTrailingNulls(string value) { }

}

