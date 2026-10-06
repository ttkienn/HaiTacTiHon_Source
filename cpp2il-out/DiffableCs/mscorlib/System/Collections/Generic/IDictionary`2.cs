namespace System.Collections.Generic;

[DefaultMember("Item")]
public interface IDictionary : ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable
{

	public TValue Item
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ICollection<TKey> Keys
	{
		 get { } //Length: 0
	}

	public ICollection<TValue> Values
	{
		 get { } //Length: 0
	}

	public void Add(TKey key, TValue value) { }

	public bool ContainsKey(TKey key) { }

	public TValue get_Item(TKey key) { }

	public ICollection<TKey> get_Keys() { }

	public ICollection<TValue> get_Values() { }

	public bool Remove(TKey key) { }

	public void set_Item(TKey key, TValue value) { }

	public bool TryGetValue(TKey key, out TValue value) { }

}

