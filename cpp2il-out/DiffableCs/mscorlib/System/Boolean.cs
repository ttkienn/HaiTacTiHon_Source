namespace System;

[IsReadOnly]
public struct bool : IComparable, IConvertible, IComparable<Boolean>, IEquatable<Boolean>
{
	internal const int True = 1; //Field offset: 0x0
	internal const int False = 0; //Field offset: 0x0
	internal const string TrueLiteral = "True"; //Field offset: 0x0
	internal const string FalseLiteral = "False"; //Field offset: 0x0
	public static readonly string TrueString; //Field offset: 0x0
	public static readonly string FalseString; //Field offset: 0x8
	private readonly bool m_value; //Field offset: 0x0

	private static Boolean() { }

	public override int CompareTo(bool value) { }

	public override int CompareTo(object obj) { }

	public virtual bool Equals(object obj) { }

	[NonVersionable]
	public override bool Equals(bool obj) { }

	public virtual int GetHashCode() { }

	public override TypeCode GetTypeCode() { }

	public static bool Parse(string value) { }

	public static bool Parse(ReadOnlySpan<Char> value) { }

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

	public override string ToString(IFormatProvider provider) { }

	public virtual string ToString() { }

	private static ReadOnlySpan<Char> TrimWhiteSpaceAndNull(ReadOnlySpan<Char> value) { }

	public static bool TryParse(ReadOnlySpan<Char> value, out bool result) { }

	public static bool TryParse(string value, out bool result) { }

}

