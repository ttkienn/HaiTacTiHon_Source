namespace Mono.Security.Cryptography;

internal sealed class PKCS1
{
	private static Byte[] emptySHA1; //Field offset: 0x0
	private static Byte[] emptySHA256; //Field offset: 0x8
	private static Byte[] emptySHA384; //Field offset: 0x10
	private static Byte[] emptySHA512; //Field offset: 0x18

	private static PKCS1() { }

	private static bool Compare(Byte[] array1, Byte[] array2) { }

	internal static HashAlgorithm CreateFromName(string name) { }

	public static Byte[] Encode_v15(HashAlgorithm hash, Byte[] hashValue, int emLength) { }

	public static Byte[] I2OSP(Byte[] x, int size) { }

	public static Byte[] OS2IP(Byte[] x) { }

	public static Byte[] RSAVP1(RSA rsa, Byte[] s) { }

	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature) { }

	internal static bool Verify_v15(RSA rsa, string hashName, Byte[] hashValue, Byte[] signature) { }

	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature, bool tryNonStandardEncoding) { }

}

