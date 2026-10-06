namespace Mono.Security.Cryptography;

internal sealed class KeyBuilder
{
	private static RandomNumberGenerator rng; //Field offset: 0x0

	private static RandomNumberGenerator Rng
	{
		private get { } //Length: 120
	}

	private static RandomNumberGenerator get_Rng() { }

	public static Byte[] IV(int size) { }

	public static Byte[] Key(int size) { }

}

