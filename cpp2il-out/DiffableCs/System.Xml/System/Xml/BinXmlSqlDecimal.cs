namespace System.Xml;

internal struct BinXmlSqlDecimal
{
	private static readonly byte NUMERIC_MAX_PRECISION; //Field offset: 0x0
	private static readonly byte MaxPrecision; //Field offset: 0x1
	private static readonly byte MaxScale; //Field offset: 0x2
	private static readonly int x_cNumeMax; //Field offset: 0x4
	private static readonly long x_lInt32Base; //Field offset: 0x8
	private static readonly ulong x_ulInt32Base; //Field offset: 0x10
	private static readonly ulong x_ulInt32BaseForMod; //Field offset: 0x18
	internal static readonly ulong x_llMax; //Field offset: 0x20
	private static readonly double DUINT_BASE; //Field offset: 0x28
	private static readonly double DUINT_BASE2; //Field offset: 0x30
	private static readonly double DUINT_BASE3; //Field offset: 0x38
	private static readonly UInt32[] x_rgulShiftBase; //Field offset: 0x40
	private static readonly Byte[] rgCLenFromPrec; //Field offset: 0x48
	internal byte m_bLen; //Field offset: 0x0
	internal byte m_bPrec; //Field offset: 0x1
	internal byte m_bScale; //Field offset: 0x2
	internal byte m_bSign; //Field offset: 0x3
	internal uint m_data1; //Field offset: 0x4
	internal uint m_data2; //Field offset: 0x8
	internal uint m_data3; //Field offset: 0xC
	internal uint m_data4; //Field offset: 0x10

	public bool IsPositive
	{
		 get { } //Length: 8
	}

	private static BinXmlSqlDecimal() { }

	public BinXmlSqlDecimal(Byte[] data, int offset, bool trim) { }

	private static char ChFromDigit(uint uiDigit) { }

	public bool get_IsPositive() { }

	private static void MpDiv1(UInt32[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	private static void MpNormalize(UInt32[] rgulU, ref int ciulU) { }

	public decimal ToDecimal() { }

	public virtual string ToString() { }

	private void TrimTrailingZeros() { }

	private static uint UIntFromByteArray(Byte[] data, int offset) { }

}

