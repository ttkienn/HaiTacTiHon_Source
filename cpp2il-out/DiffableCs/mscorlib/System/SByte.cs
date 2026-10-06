namespace System;

[CLSCompliant(False)]
[IsReadOnly]
public struct sbyte : IComparable, IConvertible, IFormattable, IComparable<SByte>, IEquatable<SByte>, ISpanFormattable
{
	public const sbyte MaxValue = 127; //Field offset: 0x0
	public const sbyte MinValue = -128; //Field offset: 0x0
	private readonly sbyte m_value; //Field offset: 0x0

	public override int CompareTo(object obj) { }

	public override int CompareTo(sbyte value) { }

	public virtual bool Equals(object obj) { }

	[NonVersionable]
	public override bool Equals(sbyte obj) { }

	public virtual int GetHashCode() { }

	public override TypeCode GetTypeCode() { }

	[CLSCompliant(False)]
	public static sbyte Parse(string s, IFormatProvider provider) { }

	[CLSCompliant(False)]
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	private static sbyte Parse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info) { }

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

	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out sbyte result) { }

	[CLSCompliant(False)]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result) { }

}

