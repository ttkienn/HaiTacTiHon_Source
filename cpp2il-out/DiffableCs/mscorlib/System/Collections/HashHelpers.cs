namespace System.Collections;

internal static class HashHelpers
{
	public static readonly Int32[] primes; //Field offset: 0x0
	private static ConditionalWeakTable<Object, SerializationInfo> s_serializationInfoTable; //Field offset: 0x8

	internal static ConditionalWeakTable<Object, SerializationInfo> SerializationInfoTable
	{
		internal get { } //Length: 241
	}

	private static HashHelpers() { }

	public static int ExpandPrime(int oldSize) { }

	internal static ConditionalWeakTable<Object, SerializationInfo> get_SerializationInfoTable() { }

	public static int GetPrime(int min) { }

	public static bool IsPrime(int candidate) { }

}

