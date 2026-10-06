namespace System.Xml;

public class XmlConvert
{
	private static XmlCharType xmlCharType; //Field offset: 0x0
	internal static Char[] crt; //Field offset: 0x8
	private static readonly int c_EncodedCharLength; //Field offset: 0x10
	private static Regex c_EncodeCharPattern; //Field offset: 0x18
	private static Regex c_DecodeCharPattern; //Field offset: 0x20
	private static String[] s_allDateTimeFormats; //Field offset: 0x28
	internal static readonly Char[] WhitespaceChars; //Field offset: 0x30

	private static String[] AllDateTimeFormats
	{
		private get { } //Length: 169
	}

	private static XmlConvert() { }

	private static void CreateAllDateTimeFormats() { }

	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	internal static Exception CreateException(string res, String[] args, ExceptionType exceptionType) { }

	internal static Exception CreateException(string res, String[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	public static string DecodeName(string name) { }

	private static long DoubleToInt64Bits(double value) { }

	public static string EncodeLocalName(string name) { }

	public static string EncodeName(string name) { }

	private static string EncodeName(string name, bool first, bool local) { }

	internal static Byte[] FromBinHexString(string s) { }

	internal static Byte[] FromBinHexString(string s, bool allowOddCount) { }

	private static int FromHex(char digit) { }

	private static String[] get_AllDateTimeFormats() { }

	internal static bool IsNegativeZero(double value) { }

	internal static String[] SplitString(string value) { }

	internal static bool StrEqual(Char[] chars, int strPos1, int strLen1, string str2) { }

	private static DateTime SwitchToLocalTime(DateTime value) { }

	private static DateTime SwitchToUtcTime(DateTime value) { }

	internal static string ToBinHexString(Byte[] inArray) { }

	public static bool ToBoolean(string s) { }

	public static byte ToByte(string s) { }

	public static char ToChar(string s) { }

	public static DateTime ToDateTime(string s, String[] formats) { }

	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	[Obsolete("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
	public static DateTime ToDateTime(string s) { }

	public static DateTimeOffset ToDateTimeOffset(string s) { }

	public static decimal ToDecimal(string s) { }

	public static double ToDouble(string s) { }

	public static Guid ToGuid(string s) { }

	public static short ToInt16(string s) { }

	public static int ToInt32(string s) { }

	public static long ToInt64(string s) { }

	internal static decimal ToInteger(string s) { }

	[CLSCompliant(False)]
	public static sbyte ToSByte(string s) { }

	public static float ToSingle(string s) { }

	public static string ToString(decimal value) { }

	public static string ToString(bool value) { }

	[CLSCompliant(False)]
	public static string ToString(sbyte value) { }

	public static string ToString(char value) { }

	public static string ToString(DateTime value, string format) { }

	public static string ToString(float value) { }

	public static string ToString(double value) { }

	public static string ToString(TimeSpan value) { }

	[CLSCompliant(False)]
	public static string ToString(ushort value) { }

	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	public static string ToString(byte value) { }

	[CLSCompliant(False)]
	public static string ToString(ulong value) { }

	public static string ToString(Guid value) { }

	public static string ToString(DateTimeOffset value) { }

	public static string ToString(int value) { }

	public static string ToString(short value) { }

	public static string ToString(long value) { }

	[CLSCompliant(False)]
	public static string ToString(uint value) { }

	public static TimeSpan ToTimeSpan(string s) { }

	[CLSCompliant(False)]
	public static ushort ToUInt16(string s) { }

	[CLSCompliant(False)]
	public static uint ToUInt32(string s) { }

	[CLSCompliant(False)]
	public static ulong ToUInt64(string s) { }

	internal static Uri ToUri(string s) { }

	internal static double ToXPathDouble(object o) { }

	internal static string TrimString(string value) { }

	internal static string TrimStringEnd(string value) { }

	internal static string TrimStringStart(string value) { }

	internal static Exception TryToBoolean(string s, out bool result) { }

	internal static Exception TryToByte(string s, out byte result) { }

	internal static Exception TryToChar(string s, out char result) { }

	internal static Exception TryToDecimal(string s, out decimal result) { }

	internal static Exception TryToDouble(string s, out double result) { }

	internal static Exception TryToGuid(string s, out Guid result) { }

	internal static Exception TryToInt16(string s, out short result) { }

	internal static Exception TryToInt32(string s, out int result) { }

	internal static Exception TryToInt64(string s, out long result) { }

	internal static Exception TryToInteger(string s, out decimal result) { }

	internal static Exception TryToSByte(string s, out sbyte result) { }

	internal static Exception TryToSingle(string s, out float result) { }

	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	internal static Exception TryToUInt16(string s, out ushort result) { }

	internal static Exception TryToUInt32(string s, out uint result) { }

	internal static Exception TryToUInt64(string s, out ulong result) { }

	internal static Exception TryToUri(string s, out Uri result) { }

	internal static Exception TryVerifyName(string name) { }

	internal static Exception TryVerifyNCName(string name) { }

	internal static Exception TryVerifyNMTOKEN(string name) { }

	internal static Exception TryVerifyNormalizedString(string str) { }

	internal static Exception TryVerifyTOKEN(string token) { }

	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	public static string VerifyName(string name) { }

	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	public static string VerifyNCName(string name) { }

	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	public static string VerifyTOKEN(string token) { }

}

