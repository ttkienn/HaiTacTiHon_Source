namespace System.Collections.Generic;

[DefaultMember("Item")]
public interface IReadOnlyDictionary : IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable
{

	public TValue Item
	{
		 get { } //Length: 0
	}

	public IEnumerable<TKey> Keys
	{
		 get { } //Length: 0
	}

	public IEnumerable<TValue> Values
	{
		 get { } //Length: 0
	}

	public bool ContainsKey(TKey key) { }

	public TValue get_Item(TKey key) { }

	public IEnumerable<TKey> get_Keys() { }

	public IEnumerable<TValue> get_Values() { }

	public bool TryGetValue(TKey key, out TValue value) { }

}

