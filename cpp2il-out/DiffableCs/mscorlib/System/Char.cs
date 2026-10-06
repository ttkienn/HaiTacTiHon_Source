namespace System;

[IsReadOnly]
public struct char : IComparable, IComparable<Char>, IEquatable<Char>, IConvertible
{
	public const char MaxValue = '\uFFFF'; //Field offset: 0x0
	public const char MinValue = '\u0'; //Field offset: 0x0
	private static readonly Byte[] s_categoryForLatin1; //Field offset: 0x0
	internal const int UNICODE_PLANE00_END = 65535; //Field offset: 0x0
	internal const int UNICODE_PLANE01_START = 65536; //Field offset: 0x0
	internal const int UNICODE_PLANE16_END = 1114111; //Field offset: 0x0
	internal const int HIGH_SURROGATE_START = 55296; //Field offset: 0x0
	internal const int LOW_SURROGATE_END = 57343; //Field offset: 0x0
	private readonly char m_value; //Field offset: 0x0

	private static Char() { }

	internal static bool CheckLetter(UnicodeCategory uc) { }

	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	internal static bool CheckNumber(UnicodeCategory uc) { }

	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	internal static bool CheckSeparator(UnicodeCategory uc) { }

	public override int CompareTo(object value) { }

	public override int CompareTo(char value) { }

	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	[NonVersionable]
	public override bool Equals(char obj) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	public override TypeCode GetTypeCode() { }

	public static UnicodeCategory GetUnicodeCategory(char c) { }

	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	private static bool IsAscii(char ch) { }

	public static bool IsControl(char c) { }

	public static bool IsDigit(char c) { }

	public static bool IsHighSurrogate(string s, int index) { }

	public static bool IsHighSurrogate(char c) { }

	private static bool IsLatin1(char ch) { }

	public static bool IsLetter(char c) { }

	public static bool IsLetterOrDigit(char c) { }

	public static bool IsLower(char c) { }

	public static bool IsLowSurrogate(char c) { }

	public static bool IsNumber(char c) { }

	public static bool IsNumber(string s, int index) { }

	public static bool IsPunctuation(char c) { }

	public static bool IsSeparator(char c) { }

	private static bool IsSeparatorLatin1(char c) { }

	public static bool IsSurrogate(char c) { }

	public static bool IsSurrogate(string s, int index) { }

	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	public static bool IsUpper(char c) { }

	public static bool IsWhiteSpace(char c) { }

	public static bool IsWhiteSpace(string s, int index) { }

	private static bool IsWhiteSpaceLatin1(char c) { }

	public static char Parse(string s) { }

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

	public static char ToLower(char c) { }

	public static char ToLower(char c, CultureInfo culture) { }

	public static char ToLowerInvariant(char c) { }

	public static string ToString(char c) { }

	public override string ToString(IFormatProvider provider) { }

	public virtual string ToString() { }

	public static char ToUpper(char c) { }

	public static char ToUpper(char c, CultureInfo culture) { }

	public static char ToUpperInvariant(char c) { }

	public static bool TryParse(string s, out char result) { }

}

