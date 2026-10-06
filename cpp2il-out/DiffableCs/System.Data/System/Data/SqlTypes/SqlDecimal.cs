namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlDecimal : INullable, IComparable, IXmlSerializable
{
	private static readonly byte s_NUMERIC_MAX_PRECISION; //Field offset: 0x0
	public static readonly byte MaxPrecision; //Field offset: 0x1
	public static readonly byte MaxScale; //Field offset: 0x2
	private static readonly byte s_bNullMask; //Field offset: 0x3
	private static readonly byte s_bIsNull; //Field offset: 0x4
	private static readonly byte s_bNotNull; //Field offset: 0x5
	private static readonly byte s_bReverseNullMask; //Field offset: 0x6
	private static readonly byte s_bSignMask; //Field offset: 0x7
	private static readonly byte s_bPositive; //Field offset: 0x8
	private static readonly byte s_bNegative; //Field offset: 0x9
	private static readonly byte s_bReverseSignMask; //Field offset: 0xA
	private static readonly uint s_uiZero; //Field offset: 0xC
	private static readonly int s_cNumeMax; //Field offset: 0x10
	private static readonly long s_lInt32Base; //Field offset: 0x18
	private static readonly ulong s_ulInt32Base; //Field offset: 0x20
	private static readonly ulong s_ulInt32BaseForMod; //Field offset: 0x28
	internal static readonly ulong s_llMax; //Field offset: 0x30
	private static readonly uint s_ulBase10; //Field offset: 0x38
	private static readonly double s_DUINT_BASE; //Field offset: 0x40
	private static readonly double s_DUINT_BASE2; //Field offset: 0x48
	private static readonly double s_DUINT_BASE3; //Field offset: 0x50
	private static readonly double s_DMAX_NUME; //Field offset: 0x58
	private static readonly uint s_DBL_DIG; //Field offset: 0x60
	private static readonly byte s_cNumeDivScaleMin; //Field offset: 0x64
	private static readonly UInt32[] s_rgulShiftBase; //Field offset: 0x68
	private static readonly UInt32[] s_decimalHelpersLo; //Field offset: 0x70
	private static readonly UInt32[] s_decimalHelpersMid; //Field offset: 0x78
	private static readonly UInt32[] s_decimalHelpersHi; //Field offset: 0x80
	private static readonly UInt32[] s_decimalHelpersHiHi; //Field offset: 0x88
	private static readonly Byte[] s_rgCLenFromPrec; //Field offset: 0x90
	private static readonly uint s_ulT1; //Field offset: 0x98
	private static readonly uint s_ulT2; //Field offset: 0x9C
	private static readonly uint s_ulT3; //Field offset: 0xA0
	private static readonly uint s_ulT4; //Field offset: 0xA4
	private static readonly uint s_ulT5; //Field offset: 0xA8
	private static readonly uint s_ulT6; //Field offset: 0xAC
	private static readonly uint s_ulT7; //Field offset: 0xB0
	private static readonly uint s_ulT8; //Field offset: 0xB4
	private static readonly uint s_ulT9; //Field offset: 0xB8
	private static readonly ulong s_dwlT10; //Field offset: 0xC0
	private static readonly ulong s_dwlT11; //Field offset: 0xC8
	private static readonly ulong s_dwlT12; //Field offset: 0xD0
	private static readonly ulong s_dwlT13; //Field offset: 0xD8
	private static readonly ulong s_dwlT14; //Field offset: 0xE0
	private static readonly ulong s_dwlT15; //Field offset: 0xE8
	private static readonly ulong s_dwlT16; //Field offset: 0xF0
	private static readonly ulong s_dwlT17; //Field offset: 0xF8
	private static readonly ulong s_dwlT18; //Field offset: 0x100
	private static readonly ulong s_dwlT19; //Field offset: 0x108
	public static readonly SqlDecimal Null; //Field offset: 0x110
	public static readonly SqlDecimal MinValue; //Field offset: 0x124
	public static readonly SqlDecimal MaxValue; //Field offset: 0x138
	internal byte _bStatus; //Field offset: 0x0
	internal byte _bLen; //Field offset: 0x1
	internal byte _bPrec; //Field offset: 0x2
	internal byte _bScale; //Field offset: 0x3
	internal uint _data1; //Field offset: 0x4
	internal uint _data2; //Field offset: 0x8
	internal uint _data3; //Field offset: 0xC
	internal uint _data4; //Field offset: 0x10

	public Int32[] Data
	{
		 get { } //Length: 314
	}

	public override bool IsNull
	{
		 get { } //Length: 96
	}

	public bool IsPositive
	{
		 get { } //Length: 269
	}

	public byte Scale
	{
		 get { } //Length: 224
	}

	public decimal Value
	{
		 get { } //Length: 101
	}

	private static SqlDecimal() { }

	private SqlDecimal(bool fNull) { }

	public SqlDecimal(decimal value) { }

	public SqlDecimal(int value) { }

	public SqlDecimal(long value) { }

	private SqlDecimal(UInt32[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	private void AddULong(uint ulAdd) { }

	internal void AdjustScale(int digits, bool fRound) { }

	private static byte BGetPrecUI4(uint value) { }

	private static byte BGetPrecUI8(ulong dwlVal) { }

	private byte CalculatePrecision() { }

	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	private static char ChFromDigit(uint uiDigit) { }

	private EComparison CompareNm(SqlDecimal snumOp) { }

	public int CompareTo(SqlDecimal value) { }

	public override int CompareTo(object value) { }

	private uint DivByULong(uint iDivisor) { }

	internal static ulong DWL(uint lo, uint hi) { }

	public virtual bool Equals(object value) { }

	private bool FGt10_38() { }

	private bool FGt10_38(UInt32[] rglData) { }

	private bool FZero() { }

	public Int32[] get_Data() { }

	public override bool get_IsNull() { }

	public bool get_IsPositive() { }

	public byte get_Scale() { }

	public decimal get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	private static uint HI(ulong x) { }

	private int LAbsCmp(SqlDecimal snumOp) { }

	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	private static uint LO(ulong x) { }

	private static void MpDiv(UInt32[] rgulU, int ciulU, UInt32[] rgulD, int ciulD, UInt32[] rgulQ, out int ciulQ, UInt32[] rgulR, out int ciulR) { }

	private static void MpDiv1(UInt32[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	private static void MpMove(UInt32[] rgulS, int ciulS, UInt32[] rgulD, out int ciulD) { }

	private static void MpMul1(UInt32[] piulD, ref int ciulD, uint iulX) { }

	private static void MpNormalize(UInt32[] rgulU, ref int ciulU) { }

	private static void MpSet(UInt32[] rgulD, out int ciulD, uint iulN) { }

	private void MultByULong(uint uiMultiplier) { }

	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	public static SqlDecimal op_Implicit(SqlMoney x) { }

	public static SqlDecimal op_Implicit(decimal x) { }

	public static SqlDecimal op_Implicit(long x) { }

	public static SqlDecimal op_Implicit(SqlByte x) { }

	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	public static SqlDecimal Parse(string s) { }

	private void SetPositive() { }

	private void SetSignBit(bool fPositive) { }

	private void SetToZero() { }

	private void StoreFromWorkingArray(UInt32[] rguiData) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	private decimal ToDecimal() { }

	public double ToDouble() { }

	public SqlDouble ToSqlDouble() { }

	public SqlInt64 ToSqlInt64() { }

	public SqlMoney ToSqlMoney() { }

	public virtual string ToString() { }

	private bool VerifyPrecision(byte precision) { }

	private static void ZeroToMaxLen(UInt32[] rgulData, int cUI4sCur) { }

}

