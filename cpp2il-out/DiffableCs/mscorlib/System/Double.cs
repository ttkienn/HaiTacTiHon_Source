namespace System;

[IsReadOnly]
public struct double : IComparable, IConvertible, IFormattable, IComparable<Double>, IEquatable<Double>, ISpanFormattable
{
	public const double MinValue = -1.7976931348623157E+308; //Field offset: 0x0
	public const double MaxValue = 1.7976931348623157E+308; //Field offset: 0x0
	public const double Epsilon = 5E-324; //Field offset: 0x0
	public const double NegativeInfinity = -∞; //Field offset: 0x0
	public const double PositiveInfinity = ∞; //Field offset: 0x0
	public const double NaN = NaN; //Field offset: 0x0
	internal const double NegativeZero = -0; //Field offset: 0x0
	private readonly double m_value; //Field offset: 0x0

	public override int CompareTo(object value) { }

	public override int CompareTo(double value) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(double obj) { }

	public virtual int GetHashCode() { }

	public override TypeCode GetTypeCode() { }

	[NonVersionable]
	public static bool IsFinite(double d) { }

	[NonVersionable]
	public static bool IsInfinity(double d) { }

	[NonVersionable]
	public static bool IsNaN(double d) { }

	[NonVersionable]
	public static bool IsNegative(double d) { }

	[NonVersionable]
	public static bool IsNegativeInfinity(double d) { }

	[NonVersionable]
	public static bool IsPositiveInfinity(double d) { }

	public static double Parse(string s, IFormatProvider provider) { }

	public static double Parse(string s) { }

	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

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

	public string ToString(string format) { }

	public override string ToString(IFormatProvider provider) { }

	public override string ToString(string format, IFormatProvider provider) { }

	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out double result) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	public static bool TryParse(string s, out double result) { }

}

