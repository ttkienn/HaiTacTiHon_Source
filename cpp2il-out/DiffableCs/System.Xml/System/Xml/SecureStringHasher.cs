namespace System.Xml;

internal class SecureStringHasher : IEqualityComparer<String>
{
	private sealed class HashCodeOfStringDelegate : MulticastDelegate
	{

		public HashCodeOfStringDelegate(object object, IntPtr method) { }

		public override int Invoke(string s, int sLen, long additionalEntropy) { }

	}

	private static HashCodeOfStringDelegate hashCodeDelegate; //Field offset: 0x0
	private int hashCodeRandomizer; //Field offset: 0x10

	public SecureStringHasher() { }

	public override bool Equals(string x, string y) { }

	public override int GetHashCode(string key) { }

	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

}

