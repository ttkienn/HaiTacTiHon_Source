namespace System.Security.Cryptography;

internal static class Utils
{
	private static RNGCryptoServiceProvider _rng; //Field offset: 0x0

	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator
	{
		internal get { } //Length: 249
	}

	internal static bool _ProduceLegacyHmacValues() { }

	internal static int ConvertByteArrayToInt(Byte[] input) { }

	internal static Byte[] ConvertIntToByteArray(int dwInput) { }

	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	internal static void DWORDFromBigEndian(UInt32* x, int digits, Byte* block) { }

	internal static void DWORDFromLittleEndian(UInt32* x, int digits, Byte* block) { }

	internal static void DWORDToBigEndian(Byte[] block, UInt32[] x, int digits) { }

	internal static void DWORDToLittleEndian(Byte[] block, UInt32[] x, int digits) { }

	internal static Byte[] FixupKeyParity(Byte[] key) { }

	internal static Byte[] GenerateRandom(int keySize) { }

	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	internal static void QuadWordFromBigEndian(UInt64* x, int digits, Byte* block) { }

	internal static void QuadWordToBigEndian(Byte[] block, UInt64[] x, int digits) { }

}

