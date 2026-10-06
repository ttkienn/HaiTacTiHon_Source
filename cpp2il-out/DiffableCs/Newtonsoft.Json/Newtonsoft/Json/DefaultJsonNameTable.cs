namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class DefaultJsonNameTable : JsonNameTable
{
	[Nullable(0)]
	private class Entry
	{
		internal readonly string Value; //Field offset: 0x10
		internal readonly int HashCode; //Field offset: 0x18
		internal Entry Next; //Field offset: 0x20

		internal Entry(string value, int hashCode, Entry next) { }

	}

	private static readonly int HashCodeRandomizer; //Field offset: 0x0
	private int _count; //Field offset: 0x10
	private Entry[] _entries; //Field offset: 0x18
	private int _mask; //Field offset: 0x20

	private static DefaultJsonNameTable() { }

	public DefaultJsonNameTable() { }

	public string Add(string key) { }

	private string AddEntry(string str, int hashCode) { }

	public virtual string Get(Char[] key, int start, int length) { }

	private void Grow() { }

	private static bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}

