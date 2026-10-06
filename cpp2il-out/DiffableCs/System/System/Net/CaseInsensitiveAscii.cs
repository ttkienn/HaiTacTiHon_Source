namespace System.Net;

internal class CaseInsensitiveAscii : IEqualityComparer, IComparer
{
	internal static readonly CaseInsensitiveAscii StaticInstance; //Field offset: 0x0
	internal static readonly Byte[] AsciiToLower; //Field offset: 0x8

	private static CaseInsensitiveAscii() { }

	public CaseInsensitiveAscii() { }

	public override int Compare(object firstObject, object secondObject) { }

	public override bool Equals(object firstObject, object secondObject) { }

	private int FastGetHashCode(string myString) { }

	public override int GetHashCode(object myObject) { }

}

