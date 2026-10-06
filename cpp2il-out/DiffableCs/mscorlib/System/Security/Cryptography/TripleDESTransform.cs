namespace System.Security.Cryptography;

internal class TripleDESTransform : SymmetricTransform
{
	private DESTransform E1; //Field offset: 0x58
	private DESTransform D2; //Field offset: 0x60
	private DESTransform E3; //Field offset: 0x68
	private DESTransform D1; //Field offset: 0x70
	private DESTransform E2; //Field offset: 0x78
	private DESTransform D3; //Field offset: 0x80

	public TripleDESTransform(TripleDES algo, bool encryption, Byte[] key, Byte[] iv) { }

	protected virtual void ECB(Byte[] input, Byte[] output) { }

	internal static Byte[] GetStrongKey() { }

}

