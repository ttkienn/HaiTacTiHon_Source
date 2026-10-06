namespace System.Resources;

internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<String>, IEqualityComparer<String>
{
	internal static readonly FastResourceComparer Default; //Field offset: 0x0

	private static FastResourceComparer() { }

	public FastResourceComparer() { }

	public override int Compare(object a, object b) { }

	public override int Compare(string a, string b) { }

	public static int CompareOrdinal(string a, Byte[] bytes, int bCharLength) { }

	public static int CompareOrdinal(Byte[] bytes, int aCharLength, string b) { }

	internal static int CompareOrdinal(Byte* a, int byteLen, string b) { }

	public override bool Equals(string a, string b) { }

	public override bool Equals(object a, object b) { }

	public override int GetHashCode(object key) { }

	public override int GetHashCode(string key) { }

	internal static int HashFunction(string key) { }

}

