namespace System.Collections.Generic;

[DefaultMember("Item")]
internal class LowLevelDictionary
{
	private sealed class DefaultComparer : IEqualityComparer<T>
	{

		public DefaultComparer`1() { }

		public override bool Equals(T x, T y) { }

		public override int GetHashCode(T obj) { }

	}

	private sealed class Entry
	{
		public TKey _key; //Field offset: 0x0
		public TValue _value; //Field offset: 0x0
		public Entry<TKey, TValue> _next; //Field offset: 0x0

		public Entry() { }

	}

	private Entry<TKey, TValue>[] _buckets; //Field offset: 0x0
	private int _numEntries; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0

	public TKey Item
	{
		 set { } //Length: 548
	}

	public LowLevelDictionary`2() { }

	public LowLevelDictionary`2(int capacity, IEqualityComparer<TKey> comparer) { }

	public void Clear(int capacity = 17) { }

	private void ExpandBuckets() { }

	private Entry<TKey, TValue> Find(TKey key) { }

	private int GetBucket(TKey key, int numBuckets = 0) { }

	public bool Remove(TKey key) { }

	public void set_Item(TKey key, TValue value) { }

	private Entry<TKey, TValue> UncheckedAdd(TKey key, TValue value) { }

}

