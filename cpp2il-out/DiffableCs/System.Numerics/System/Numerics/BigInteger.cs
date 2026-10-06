namespace System.Numerics;

[IsReadOnly]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
{
	private enum GetBytesMode
	{
		AllocateArray = 0,
		Count = 1,
		Span = 2,
	}

	private static readonly BigInteger s_bnMinInt; //Field offset: 0x0
	private static readonly BigInteger s_bnOneInt; //Field offset: 0x10
	private static readonly BigInteger s_bnZeroInt; //Field offset: 0x20
	private static readonly BigInteger s_bnMinusOneInt; //Field offset: 0x30
	private static readonly Byte[] s_success; //Field offset: 0x40
	internal readonly int _sign; //Field offset: 0x0
	internal readonly UInt32[] _bits; //Field offset: 0x8

	public bool IsZero
	{
		 get { } //Length: 7
	}

	public static BigInteger MinusOne
	{
		 get { } //Length: 91
	}

	public static BigInteger Zero
	{
		 get { } //Length: 91
	}

	private static BigInteger() { }

	internal BigInteger(UInt32[] value, bool negative) { }

	internal BigInteger(int n, UInt32[] rgu) { }

	public BigInteger(ReadOnlySpan<Byte> value, bool isUnsigned = false, bool isBigEndian = false) { }

	[CLSCompliant(False)]
	public BigInteger(Byte[] value) { }

	public BigInteger(decimal value) { }

	public BigInteger(int value) { }

	public BigInteger(float value) { }

	[CLSCompliant(False)]
	public BigInteger(ulong value) { }

	public BigInteger(long value) { }

	[CLSCompliant(False)]
	public BigInteger(uint value) { }

	public BigInteger(double value) { }

	private static BigInteger Add(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	public int CompareTo(long other) { }

	public override int CompareTo(BigInteger other) { }

	public override int CompareTo(object obj) { }

	public virtual bool Equals(object obj) { }

	public bool Equals(long other) { }

	public override bool Equals(BigInteger other) { }

	public bool get_IsZero() { }

	public static BigInteger get_MinusOne() { }

	public static BigInteger get_Zero() { }

	internal static int GetDiffLength(UInt32[] rgu1, UInt32[] rgu2, int cu) { }

	public virtual int GetHashCode() { }

	private static bool GetPartsForBitManipulation(ref BigInteger x, out UInt32[] xd, out int xl) { }

	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	public static bool op_Equality(BigInteger left, long right) { }

	public static float op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	public static ulong op_Explicit(BigInteger value) { }

	public static long op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	public static uint op_Explicit(BigInteger value) { }

	public static decimal op_Explicit(BigInteger value) { }

	public static int op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	public static ushort op_Explicit(BigInteger value) { }

	public static short op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	public static sbyte op_Explicit(BigInteger value) { }

	public static byte op_Explicit(BigInteger value) { }

	public static double op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	public static BigInteger op_Implicit(ulong value) { }

	public static BigInteger op_Implicit(int value) { }

	[CLSCompliant(False)]
	public static BigInteger op_Implicit(uint value) { }

	public static BigInteger op_Implicit(long value) { }

	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliant(False)]
	public static BigInteger op_Implicit(sbyte value) { }

	[CLSCompliant(False)]
	public static BigInteger op_Implicit(ushort value) { }

	public static BigInteger op_Implicit(short value) { }

	public static bool op_Inequality(BigInteger left, long right) { }

	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	public static bool op_LessThan(long left, BigInteger right) { }

	public static bool op_LessThan(BigInteger left, long right) { }

	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	public static BigInteger op_Modulus(BigInteger dividend, BigInteger divisor) { }

	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	public static BigInteger op_UnaryNegation(BigInteger value) { }

	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	public static BigInteger Parse(string value, IFormatProvider provider) { }

	private static BigInteger Subtract(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	public Byte[] ToByteArray(bool isUnsigned = false, bool isBigEndian = false) { }

	public Byte[] ToByteArray() { }

	public virtual string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public override string ToString(string format, IFormatProvider provider) { }

	private Byte[] TryGetBytes(GetBytesMode mode, Span<Byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	public bool TryWriteBytes(Span<Byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false) { }

	internal bool TryWriteOrCountBytes(Span<Byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false) { }

}

