namespace System;

[IsReadOnly]
public struct short : IComparable, IConvertible, IFormattable, IComparable<Int16>, IEquatable<Int16>, ISpanFormattable
{
	public const short MaxValue = 32767; //Field offset: 0x0
	public const short MinValue = -32768; //Field offset: 0x0
	private readonly short m_value; //Field offset: 0x0

	public override int CompareTo(object value) { }

	public override int CompareTo(short value) { }

	public virtual bool Equals(object obj) { }

	[NonVersionable]
	public override bool Equals(short obj) { }

	public virtual int GetHashCode() { }

	public override TypeCode GetTypeCode() { }

	public static short Parse(string s) { }

	public static short Parse(string s, IFormatProvider provider) { }

	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	private static short Parse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info) { }

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

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider provider) { }

	public override string ToString(IFormatProvider provider) { }

	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out short result) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

}

