namespace System.Security.Cryptography;

internal class RC2Transform : SymmetricTransform
{
	private static readonly Byte[] pitable; //Field offset: 0x0
	private ushort R0; //Field offset: 0x58
	private ushort R1; //Field offset: 0x5A
	private ushort R2; //Field offset: 0x5C
	private ushort R3; //Field offset: 0x5E
	private UInt16[] K; //Field offset: 0x60
	private int j; //Field offset: 0x68

	private static RC2Transform() { }

	public RC2Transform(RC2 rc2Algo, bool encryption, Byte[] key, Byte[] iv) { }

	protected virtual void ECB(Byte[] input, Byte[] output) { }

}

