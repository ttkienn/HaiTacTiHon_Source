namespace Mono.Globalization.Unicode;

internal class Contraction
{
	public int Index; //Field offset: 0x10
	public readonly Char[] Source; //Field offset: 0x18
	public readonly string Replacement; //Field offset: 0x20
	public readonly Byte[] SortKey; //Field offset: 0x28

	public Contraction(int index, Char[] source, string replacement, Byte[] sortkey) { }

}

