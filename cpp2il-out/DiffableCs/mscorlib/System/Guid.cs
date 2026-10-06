namespace System;

[NonVersionable]
public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>, ISpanFormattable
{
	private enum GuidParseThrowStyle
	{
		None = 0,
		All = 1,
		AllButOverflow = 2,
	}

	private struct GuidResult
	{
		internal Guid _parsedGuid; //Field offset: 0x0
		internal GuidParseThrowStyle _throwStyle; //Field offset: 0x10
		private ParseFailureKind _failure; //Field offset: 0x14
		private string _failureMessageID; //Field offset: 0x18
		private object _failureMessageFormatArgument; //Field offset: 0x20
		private string _failureArgumentName; //Field offset: 0x28
		private Exception _innerException; //Field offset: 0x30

		internal Exception GetGuidParseException() { }

		internal void Init(GuidParseThrowStyle canThrow) { }

		internal void SetFailure(Exception nativeException) { }

		internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	}

	[Flags]
	private enum GuidStyles
	{
		None = 0,
		AllowParenthesis = 1,
		AllowBraces = 2,
		AllowDashes = 4,
		AllowHexPrefix = 8,
		RequireParenthesis = 16,
		RequireBraces = 32,
		RequireDashes = 64,
		RequireHexPrefix = 128,
		HexFormat = 160,
		NumberFormat = 0,
		DigitFormat = 64,
		BraceFormat = 96,
		ParenthesisFormat = 80,
		Any = 15,
	}

	private enum ParseFailureKind
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		NativeException = 4,
		FormatWithInnerException = 5,
	}

	public static readonly Guid Empty; //Field offset: 0x0
	private int _a; //Field offset: 0x0
	private short _b; //Field offset: 0x4
	private short _c; //Field offset: 0x6
	private byte _d; //Field offset: 0x8
	private byte _e; //Field offset: 0x9
	private byte _f; //Field offset: 0xA
	private byte _g; //Field offset: 0xB
	private byte _h; //Field offset: 0xC
	private byte _i; //Field offset: 0xD
	private byte _j; //Field offset: 0xE
	private byte _k; //Field offset: 0xF

	public Guid(Byte[] b) { }

	public Guid(ReadOnlySpan<Byte> b) { }

	public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	public Guid(string g) { }

	public override int CompareTo(Guid value) { }

	public override int CompareTo(object value) { }

	private static ReadOnlySpan<Char> EatAllWhitespace(ReadOnlySpan<Char> str) { }

	public virtual bool Equals(object o) { }

	public override bool Equals(Guid g) { }

	public virtual int GetHashCode() { }

	private int GetResult(uint me, uint them) { }

	private static int HexsToChars(Char* guidChars, int a, int b) { }

	private static int HexsToCharsHexOutput(Char* guidChars, int a, int b) { }

	private static char HexToChar(int a) { }

	private static bool IsHexPrefix(ReadOnlySpan<Char> str, int i) { }

	public static Guid NewGuid() { }

	public static bool op_Equality(Guid a, Guid b) { }

	public static Guid Parse(string input) { }

	public static Guid Parse(ReadOnlySpan<Char> input) { }

	private static bool StringToInt(ReadOnlySpan<Char> str, int requiredLength, int flags, out int result, ref GuidResult parseResult) { }

	private static bool StringToInt(ReadOnlySpan<Char> str, ref int parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult) { }

	private static bool StringToLong(ReadOnlySpan<Char> str, ref int parsePos, int flags, out long result, ref GuidResult parseResult) { }

	private static bool StringToShort(ReadOnlySpan<Char> str, ref int parsePos, int requiredLength, int flags, out short result, ref GuidResult parseResult) { }

	private static bool StringToShort(ReadOnlySpan<Char> str, int requiredLength, int flags, out short result, ref GuidResult parseResult) { }

	private override bool System.ISpanFormattable.TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	public Byte[] ToByteArray() { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider provider) { }

	public string ToString(string format) { }

	public bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null) { }

	public static bool TryParse(string input, out Guid result) { }

	public static bool TryParse(ReadOnlySpan<Char> input, out Guid result) { }

	public static bool TryParseExact(ReadOnlySpan<Char> input, ReadOnlySpan<Char> format, out Guid result) { }

	public static bool TryParseExact(string input, string format, out Guid result) { }

	private static bool TryParseGuid(ReadOnlySpan<Char> guidString, GuidStyles flags, ref GuidResult result) { }

	private static bool TryParseGuidWithDashes(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	private static bool TryParseGuidWithHexPrefix(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	private static bool TryParseGuidWithNoStyle(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	private void WriteByteHelper(Span<Byte> destination) { }

}

