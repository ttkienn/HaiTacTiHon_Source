namespace System;

[IsReadOnly]
public struct float : IComparable, IConvertible, IFormattable, IComparable<Single>, IEquatable<Single>, ISpanFormattable
{
	public const float MinValue = -3.4028235E+38; //Field offset: 0x0
	public const float Epsilon = 1E-45; //Field offset: 0x0
	public const float MaxValue = 3.4028235E+38; //Field offset: 0x0
	public const float PositiveInfinity = ∞; //Field offset: 0x0
	public const float NegativeInfinity = -∞; //Field offset: 0x0
	public const float NaN = NaN; //Field offset: 0x0
	internal const float NegativeZero = -0; //Field offset: 0x0
	private readonly float m_value; //Field offset: 0x0

	public override int CompareTo(float value) { }

	public override int CompareTo(object value) { }

	public override bool Equals(float obj) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public override TypeCode GetTypeCode() { }

	[NonVersionable]
	public static bool IsFinite(float f) { }

	[NonVersionable]
	public static bool IsInfinity(float f) { }

	[NonVersionable]
	public static bool IsNaN(float f) { }

	[NonVersionable]
	public static bool IsNegativeInfinity(float f) { }

	[NonVersionable]
	public static bool IsPositiveInfinity(float f) { }

	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	public static float Parse(string s, IFormatProvider provider) { }

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

	public override string ToString(IFormatProvider provider) { }

	public virtual string ToString() { }

	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out float result) { }

	public static bool TryParse(string s, out float result) { }

}

