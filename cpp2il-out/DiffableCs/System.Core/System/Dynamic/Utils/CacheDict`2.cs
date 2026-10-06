namespace System.Dynamic.Utils;

[DefaultMember("Item")]
internal sealed class CacheDict
{
	private sealed class Entry
	{
		internal readonly int _hash; //Field offset: 0x0
		internal readonly TKey _key; //Field offset: 0x0
		internal readonly TValue _value; //Field offset: 0x0

		internal Entry(int hash, TKey key, TValue value) { }

	}

	private readonly int _mask; //Field offset: 0x0
	private readonly Entry<TKey, TValue>[] _entries; //Field offset: 0x0

	internal TKey Item
	{
		internal set { } //Length: 343
	}

	internal CacheDict`2(int size) { }

	internal void Add(TKey key, TValue value) { }

	private static int AlignSize(int size) { }

	internal void set_Item(TKey key, TValue value) { }

	internal bool TryGetValue(TKey key, out TValue value) { }

}

