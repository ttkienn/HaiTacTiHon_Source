namespace System.Xml;

public class NameTable : XmlNameTable
{
	private class Entry
	{
		internal string str; //Field offset: 0x10
		internal int hashCode; //Field offset: 0x18
		internal Entry next; //Field offset: 0x20

		internal Entry(string str, int hashCode, Entry next) { }

	}

	private Entry[] entries; //Field offset: 0x10
	private int count; //Field offset: 0x18
	private int mask; //Field offset: 0x1C
	private int hashCodeRandomizer; //Field offset: 0x20

	public NameTable() { }

	public virtual string Add(string key) { }

	public virtual string Add(Char[] key, int start, int len) { }

	private string AddEntry(string str, int hashCode) { }

	public virtual string Get(string value) { }

	private void Grow() { }

	private static bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}

