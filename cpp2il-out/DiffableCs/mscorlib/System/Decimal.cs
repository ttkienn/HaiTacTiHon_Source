namespace System;

[IsReadOnly]
public struct decimal : IFormattable, IComparable, IConvertible, IComparable<Decimal>, IEquatable<Decimal>, IDeserializationCallback, ISpanFormattable
{
	private struct DecCalc
	{
		private struct Buf12
		{
			public uint U0; //Field offset: 0x0
			private ulong ulo64LE; //Field offset: 0x0
			public uint U1; //Field offset: 0x4
			private ulong uhigh64LE; //Field offset: 0x4
			public uint U2; //Field offset: 0x8

			public ulong High64
			{
				 get { } //Length: 7
				 set { } //Length: 5
			}

			public ulong Low64
			{
				 get { } //Length: 6
				 set { } //Length: 4
			}

			public ulong get_High64() { }

			public ulong get_Low64() { }

			public void set_High64(ulong value) { }

			public void set_Low64(ulong value) { }

		}

		private struct Buf16
		{
			public uint U0; //Field offset: 0x0
			private ulong ulo64LE; //Field offset: 0x0
			public uint U1; //Field offset: 0x4
			public uint U2; //Field offset: 0x8
			private ulong uhigh64LE; //Field offset: 0x8
			public uint U3; //Field offset: 0xC

			public ulong High64
			{
				 get { } //Length: 7
				 set { } //Length: 5
			}

			public ulong Low64
			{
				 get { } //Length: 6
				 set { } //Length: 4
			}

			public ulong get_High64() { }

			public ulong get_Low64() { }

			public void set_High64(ulong value) { }

			public void set_Low64(ulong value) { }

		}

		private struct Buf24
		{
			public uint U0; //Field offset: 0x0
			private ulong ulo64LE; //Field offset: 0x0
			public uint U1; //Field offset: 0x4
			public uint U2; //Field offset: 0x8
			private ulong umid64LE; //Field offset: 0x8
			public uint U3; //Field offset: 0xC
			public uint U4; //Field offset: 0x10
			private ulong uhigh64LE; //Field offset: 0x10
			public uint U5; //Field offset: 0x14

			public ulong High64
			{
				 set { } //Length: 5
			}

			public ulong Low64
			{
				 get { } //Length: 6
				 set { } //Length: 4
			}

			public ulong Mid64
			{
				 set { } //Length: 5
			}

			public ulong get_Low64() { }

			public void set_High64(ulong value) { }

			public void set_Low64(ulong value) { }

			public void set_Mid64(ulong value) { }

		}

		private struct PowerOvfl
		{
			public readonly uint Hi; //Field offset: 0x0
			public readonly ulong MidLo; //Field offset: 0x8

			public PowerOvfl(uint hi, uint mid, uint lo) { }

		}

		public enum RoundingMode
		{
			ToEven = 0,
			AwayFromZero = 1,
			Truncate = 2,
			Floor = 3,
			Ceiling = 4,
		}

		private static readonly UInt32[] s_powers10; //Field offset: 0x0
		private static readonly UInt64[] s_ulongPowers10; //Field offset: 0x8
		private static readonly Double[] s_doublePowers10; //Field offset: 0x10
		private static readonly PowerOvfl[] PowerOvflValues; //Field offset: 0x18
		private uint uflags; //Field offset: 0x0
		private uint uhi; //Field offset: 0x4
		private uint ulo; //Field offset: 0x8
		private ulong ulomidLE; //Field offset: 0x8
		private uint umid; //Field offset: 0xC

		private uint High
		{
			private get { } //Length: 4
			private set { } //Length: 4
		}

		private bool IsNegative
		{
			private get { } //Length: 6
		}

		private uint Low
		{
			private get { } //Length: 4
			private set { } //Length: 4
		}

		private ulong Low64
		{
			private get { } //Length: 7
			private set { } //Length: 5
		}

		private uint Mid
		{
			private get { } //Length: 4
			private set { } //Length: 4
		}

		private static DecCalc() { }

		private static bool Add32To96(ref Buf12 bufNum, uint value) { }

		internal static void DecAddSub(ref DecCalc d1, ref DecCalc d2, bool sign) { }

		internal static uint DecDivMod1E9(ref DecCalc value) { }

		private static uint Div128By96(ref Buf16 bufNum, ref Buf12 bufDen) { }

		private static uint Div96By32(ref Buf12 bufNum, uint den) { }

		private static uint Div96By64(ref Buf12 bufNum, ulong den) { }

		private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow) { }

		private static uint DivByConst(UInt32* result, uint hiRes, out uint quotient, out uint remainder, uint power) { }

		private uint get_High() { }

		private bool get_IsNegative() { }

		private uint get_Low() { }

		private ulong get_Low64() { }

		private uint get_Mid() { }

		private static uint GetExponent(double d) { }

		private static uint GetExponent(float f) { }

		internal static int GetHashCode(in decimal d) { }

		private static uint IncreaseScale(ref Buf12 bufNum, uint power) { }

		private static void IncreaseScale64(ref Buf12 bufNum, uint power) { }

		internal static void InternalRound(ref DecCalc d, uint scale, RoundingMode mode) { }

		private static int LeadingZeroCount(uint value) { }

		private static int OverflowUnscale(ref Buf12 bufQuo, int scale, bool sticky) { }

		private static int ScaleResult(Buf24* bufRes, uint hiRes, int scale) { }

		private static int SearchScale(ref Buf12 bufQuo, int scale) { }

		private void set_High(uint value) { }

		private void set_Low(uint value) { }

		private void set_Low64(ulong value) { }

		private void set_Mid(uint value) { }

		private static ulong UInt32x32To64(uint a, uint b) { }

		private static void UInt64x64To128(ulong a, ulong b, ref DecCalc result) { }

		private static void Unscale(ref uint low, ref ulong high64, ref int scale) { }

		internal static int VarDecCmp(in decimal d1, in decimal d2) { }

		private static int VarDecCmpSub(in decimal d1, in decimal d2) { }

		internal static void VarDecDiv(ref DecCalc d1, ref DecCalc d2) { }

		internal static void VarDecFromR4(float input, out DecCalc result) { }

		internal static void VarDecFromR8(double input, out DecCalc result) { }

		internal static void VarDecMul(ref DecCalc d1, ref DecCalc d2) { }

		internal static float VarR4FromDec(in decimal value) { }

		internal static double VarR8FromDec(in decimal value) { }

	}

	[DecimalConstant(0, 0, 0, 0, 0)]
	public static readonly decimal Zero; //Field offset: 0x0
	[DecimalConstant(0, 0, 0, 0, 1)]
	public static readonly decimal One; //Field offset: 0x10
	[DecimalConstant(0, 128, 0, 0, 1)]
	public static readonly decimal MinusOne; //Field offset: 0x20
	[DecimalConstant(0, 0, 4294967295, 4294967295, 4294967295)]
	public static readonly decimal MaxValue; //Field offset: 0x30
	[DecimalConstant(0, 128, 4294967295, 4294967295, 4294967295)]
	public static readonly decimal MinValue; //Field offset: 0x40
	private readonly int flags; //Field offset: 0x0
	private readonly int hi; //Field offset: 0x4
	private readonly int lo; //Field offset: 0x8
	private readonly ulong ulomidLE; //Field offset: 0x8
	private readonly int mid; //Field offset: 0xC

	internal uint High
	{
		internal get { } //Length: 4
	}

	internal bool IsNegative
	{
		internal get { } //Length: 6
	}

	internal uint Low
	{
		internal get { } //Length: 4
	}

	private ulong Low64
	{
		private get { } //Length: 57
	}

	internal uint Mid
	{
		internal get { } //Length: 4
	}

	internal int Scale
	{
		internal get { } //Length: 5
	}

	private static Decimal() { }

	public Decimal(int lo, int mid, int hi, bool isNegative, byte scale) { }

	public Decimal(Int32[] bits) { }

	public Decimal(double value) { }

	public Decimal(float value) { }

	[CLSCompliant(False)]
	public Decimal(ulong value) { }

	public Decimal(long value) { }

	private Decimal(in decimal d, int flags) { }

	[CLSCompliant(False)]
	public Decimal(uint value) { }

	public Decimal(int value) { }

	internal static decimal Abs(ref decimal d) { }

	public static decimal Add(decimal d1, decimal d2) { }

	private static DecCalc AsMutable(ref decimal d) { }

	public static int Compare(decimal d1, decimal d2) { }

	public override int CompareTo(object value) { }

	public override int CompareTo(decimal value) { }

	internal static uint DecDivMod1E9(ref decimal value) { }

	public static decimal Divide(decimal d1, decimal d2) { }

	public virtual bool Equals(object value) { }

	public override bool Equals(decimal value) { }

	internal uint get_High() { }

	internal bool get_IsNegative() { }

	internal uint get_Low() { }

	private ulong get_Low64() { }

	internal uint get_Mid() { }

	internal int get_Scale() { }

	public static Int32[] GetBits(decimal d) { }

	public virtual int GetHashCode() { }

	public override TypeCode GetTypeCode() { }

	private static bool IsValid(int flags) { }

	internal static decimal Max(ref decimal d1, ref decimal d2) { }

	internal static decimal Min(ref decimal d1, ref decimal d2) { }

	public static decimal Multiply(decimal d1, decimal d2) { }

	public static decimal Negate(decimal d) { }

	public static decimal op_Addition(decimal d1, decimal d2) { }

	public static decimal op_Division(decimal d1, decimal d2) { }

	public static bool op_Equality(decimal d1, decimal d2) { }

	public static decimal op_Explicit(float value) { }

	public static decimal op_Explicit(double value) { }

	public static int op_Explicit(decimal value) { }

	[CLSCompliant(False)]
	public static ulong op_Explicit(decimal value) { }

	public static long op_Explicit(decimal value) { }

	public static double op_Explicit(decimal value) { }

	public static float op_Explicit(decimal value) { }

	public static bool op_GreaterThan(decimal d1, decimal d2) { }

	public static bool op_GreaterThanOrEqual(decimal d1, decimal d2) { }

	[CLSCompliant(False)]
	public static decimal op_Implicit(sbyte value) { }

	[CLSCompliant(False)]
	public static decimal op_Implicit(ulong value) { }

	public static decimal op_Implicit(long value) { }

	[CLSCompliant(False)]
	public static decimal op_Implicit(uint value) { }

	public static decimal op_Implicit(char value) { }

	[CLSCompliant(False)]
	public static decimal op_Implicit(ushort value) { }

	public static decimal op_Implicit(short value) { }

	public static decimal op_Implicit(byte value) { }

	public static decimal op_Implicit(int value) { }

	public static decimal op_Increment(decimal d) { }

	public static bool op_Inequality(decimal d1, decimal d2) { }

	public static bool op_LessThan(decimal d1, decimal d2) { }

	public static bool op_LessThanOrEqual(decimal d1, decimal d2) { }

	public static decimal op_Multiply(decimal d1, decimal d2) { }

	public static decimal op_Subtraction(decimal d1, decimal d2) { }

	public static decimal op_UnaryNegation(decimal d) { }

	public static decimal Parse(string s, IFormatProvider provider) { }

	public static decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	private static decimal Round(ref decimal d, int decimals, MidpointRounding mode) { }

	public static decimal Round(decimal d, int decimals) { }

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

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	public static byte ToByte(decimal value) { }

	public static double ToDouble(decimal d) { }

	public static short ToInt16(decimal value) { }

	public static int ToInt32(decimal d) { }

	public static long ToInt64(decimal d) { }

	[CLSCompliant(False)]
	public static sbyte ToSByte(decimal value) { }

	public static float ToSingle(decimal d) { }

	public virtual string ToString() { }

	public override string ToString(IFormatProvider provider) { }

	public override string ToString(string format, IFormatProvider provider) { }

	[CLSCompliant(False)]
	public static ushort ToUInt16(decimal value) { }

	[CLSCompliant(False)]
	public static uint ToUInt32(decimal d) { }

	[CLSCompliant(False)]
	public static ulong ToUInt64(decimal d) { }

	public static decimal Truncate(decimal d) { }

	private static void Truncate(ref decimal d) { }

	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result) { }

}

