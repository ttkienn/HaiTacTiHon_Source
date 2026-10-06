namespace System.Security.Cryptography;

[ComVisible(True)]
public class CryptoConfig
{
	private static readonly object lockObject; //Field offset: 0x0
	private static Dictionary<String, Type> algorithms; //Field offset: 0x8

	[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
	public static bool AllowOnlyFipsAlgorithms
	{
		 get { } //Length: 3
	}

	private static CryptoConfig() { }

	public static object CreateFromName(string name) { }

	public static object CreateFromName(string name, Object[] args) { }

	private static Byte[] EncodeLongNumber(long x) { }

	public static Byte[] EncodeOID(string str) { }

	public static bool get_AllowOnlyFipsAlgorithms() { }

	public static string MapNameToOID(string name) { }

}

