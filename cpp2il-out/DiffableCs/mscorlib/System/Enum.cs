namespace System;

[ComVisible(True)]
public abstract class Enum : IComparable, IFormattable, IConvertible
{
	private struct EnumResult
	{
		internal object parsedEnum; //Field offset: 0x0
		internal bool canThrow; //Field offset: 0x8
		internal ParseFailureKind m_failure; //Field offset: 0xC
		internal string m_failureMessageID; //Field offset: 0x10
		internal string m_failureParameter; //Field offset: 0x18
		internal object m_failureMessageFormatArgument; //Field offset: 0x20
		internal Exception m_innerException; //Field offset: 0x28

		internal Exception GetEnumParseException() { }

		internal void Init(bool canMethodThrow) { }

		internal void SetFailure(Exception unhandledException) { }

		internal void SetFailure(ParseFailureKind failure, string failureParameter) { }

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	}

	private enum ParseFailureKind
	{
		None = 0,
		Argument = 1,
		ArgumentNull = 2,
		ArgumentWithParameter = 3,
		UnhandledException = 4,
	}

	private class ValuesAndNames
	{
		public UInt64[] Values; //Field offset: 0x10
		public String[] Names; //Field offset: 0x18

		public ValuesAndNames(UInt64[] values, String[] names) { }

	}

	private static readonly Char[] enumSeperatorCharArray; //Field offset: 0x0
	private const string enumSeperator = ", "; //Field offset: 0x0

	private static Enum() { }

	protected Enum() { }

	public override int CompareTo(object target) { }

	public virtual bool Equals(object obj) { }

	[ComVisible(True)]
	public static string Format(Type enumType, object value, string format) { }

	private int get_hashcode() { }

	private object get_value() { }

	private static ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) { }

	private static bool GetEnumValuesAndNames(RuntimeType enumType, out UInt64[] values, out String[] names) { }

	public virtual int GetHashCode() { }

	[ComVisible(True)]
	public static string GetName(Type enumType, object value) { }

	[ComVisible(True)]
	public static String[] GetNames(Type enumType) { }

	public override TypeCode GetTypeCode() { }

	[ComVisible(True)]
	public static Type GetUnderlyingType(Type enumType) { }

	internal object GetValue() { }

	[ComVisible(True)]
	public static Array GetValues(Type enumType) { }

	public bool HasFlag(Enum flag) { }

	private static object InternalBoxEnum(RuntimeType enumType, long value) { }

	private static int InternalCompareTo(object o1, object o2) { }

	private static string InternalFlagsFormat(RuntimeType eT, object value) { }

	private static string InternalFormat(RuntimeType eT, object value) { }

	private static string InternalFormattedHexString(object value) { }

	internal static String[] InternalGetNames(RuntimeType enumType) { }

	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) { }

	internal static UInt64[] InternalGetValues(RuntimeType enumType) { }

	private bool InternalHasFlag(Enum flags) { }

	[ComVisible(True)]
	public static bool IsDefined(Type enumType, object value) { }

	[ComVisible(True)]
	public static object Parse(Type enumType, string value, bool ignoreCase) { }

	[ComVisible(True)]
	public static object Parse(Type enumType, string value) { }

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

	[ComVisible(True)]
	public static object ToObject(Type enumType, byte value) { }

	[CLSCompliant(False)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, uint value) { }

	[ComVisible(True)]
	public static object ToObject(Type enumType, long value) { }

	[CLSCompliant(False)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, ulong value) { }

	private static object ToObject(Type enumType, char value) { }

	private static object ToObject(Type enumType, bool value) { }

	[CLSCompliant(False)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, ushort value) { }

	[ComVisible(True)]
	public static object ToObject(Type enumType, int value) { }

	[ComVisible(True)]
	public static object ToObject(Type enumType, object value) { }

	[CLSCompliant(False)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, sbyte value) { }

	[ComVisible(True)]
	public static object ToObject(Type enumType, short value) { }

	public string ToString(string format) { }

	[Obsolete("The provider argument is not used. Please use ToString(String).")]
	public override string ToString(string format, IFormatProvider provider) { }

	public virtual string ToString() { }

	[Obsolete("The provider argument is not used. Please use ToString().")]
	public override string ToString(IFormatProvider provider) { }

	internal static ulong ToUInt64(object value) { }

	public static bool TryParse(string value, out TEnum result) { }

	public static bool TryParse(string value, bool ignoreCase, out TEnum result) { }

	public static bool TryParse(Type enumType, string value, bool ignoreCase, out object result) { }

	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref EnumResult parseResult) { }

}

