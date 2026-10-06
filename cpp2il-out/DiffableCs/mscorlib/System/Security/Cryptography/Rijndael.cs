namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class Rijndael : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8

	private static Rijndael() { }

	protected Rijndael() { }

}

