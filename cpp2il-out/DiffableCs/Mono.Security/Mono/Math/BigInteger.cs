namespace Mono.Math;

public class BigInteger
{
	private sealed class Kernel
	{

		public static Sign Compare(BigInteger bi1, BigInteger bi2) { }

		public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

		public static uint DwordMod(BigInteger n, uint d) { }

		public static BigInteger LeftShift(BigInteger bi, int n) { }

		public static void MinusEq(BigInteger big, BigInteger small) { }

		public static uint modInverse(BigInteger bi, uint modulus) { }

		public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

		public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

		public static void Multiply(UInt32[] x, uint xOffset, uint xLen, UInt32[] y, uint yOffset, uint yLen, UInt32[] d, uint dOffset) { }

		public static void MultiplyMod2p32pmod(UInt32[] x, int xOffset, int xLen, UInt32[] y, int yOffest, int yLen, UInt32[] d, int dOffset, int mod) { }

		public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

		public static BigInteger RightShift(BigInteger bi, int n) { }

		public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

		public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	}

	internal sealed class ModulusRing
	{
		private BigInteger mod; //Field offset: 0x10
		private BigInteger constant; //Field offset: 0x18

		public ModulusRing(BigInteger modulus) { }

		public void BarrettReduction(BigInteger x) { }

		public BigInteger Difference(BigInteger a, BigInteger b) { }

		public BigInteger Multiply(BigInteger a, BigInteger b) { }

		public BigInteger Pow(BigInteger a, BigInteger k) { }

		[CLSCompliant(False)]
		public BigInteger Pow(uint b, BigInteger exp) { }

	}

	internal enum Sign
	{
		Negative = -1,
		Zero = 0,
		Positive = 1,
	}

	internal static readonly UInt32[] smallPrimes; //Field offset: 0x0
	private static RandomNumberGenerator rng; //Field offset: 0x8
	private uint length; //Field offset: 0x10
	private UInt32[] data; //Field offset: 0x18

	private static RandomNumberGenerator Rng
	{
		private get { } //Length: 219
	}

	private static BigInteger() { }

	[CLSCompliant(False)]
	public BigInteger(uint ui) { }

	public BigInteger(Byte[] inData) { }

	[CLSCompliant(False)]
	public BigInteger(Sign sign, uint len) { }

	public BigInteger(BigInteger bi) { }

	[CLSCompliant(False)]
	public BigInteger(BigInteger bi, uint len) { }

	public int BitCount() { }

	public void Clear() { }

	public virtual bool Equals(object o) { }

	public static BigInteger GeneratePseudoPrime(int bits) { }

	public static BigInteger GenerateRandom(int bits) { }

	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	private static RandomNumberGenerator get_Rng() { }

	public Byte[] GetBytes() { }

	public virtual int GetHashCode() { }

	public void Incr2() { }

	public int LowestSetBit() { }

	public BigInteger ModInverse(BigInteger modulus) { }

	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	private void Normalize() { }

	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	public static BigInteger op_Implicit(uint value) { }

	public static BigInteger op_Implicit(int value) { }

	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	public void SetBit(uint bitNum) { }

	[CLSCompliant(False)]
	public void SetBit(uint bitNum, bool value) { }

	public bool TestBit(int bitNum) { }

	[CLSCompliant(False)]
	public string ToString(uint radix) { }

	public virtual string ToString() { }

	[CLSCompliant(False)]
	public string ToString(uint radix, string characterSet) { }

}

