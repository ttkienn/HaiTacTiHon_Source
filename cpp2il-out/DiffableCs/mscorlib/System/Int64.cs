namespace System;

[IsReadOnly]
public struct long : IComparable, IConvertible, IFormattable, IComparable<Int64>, IEquatable<Int64>, ISpanFormattable
{
	public const long MaxValue = 9223372036854775807; //Field offset: 0x0
	public const long MinValue = -9223372036854775808; //Field offset: 0x0
	private readonly long m_value; //Field offset: 0x0

	public override int CompareTo(object value) { }

	public override int CompareTo(long value) { }

	public virtual bool Equals(object obj) { }

	[NonVersionable]
	public override bool Equals(long obj) { }

	public virtual int GetHashCode() { }

	public override TypeCode GetTypeCode() { }

	public static long Parse(string s) { }

	public static long Parse(string s, IFormatProvider provider) { }

	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

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

	public override string ToString(string format, IFormatProvider provider) { }

	public string ToString(string format) { }

	public virtual string ToString() { }

	public override string ToString(IFormatProvider provider) { }

	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	public static bool TryParse(string s, out long result) { }

}

