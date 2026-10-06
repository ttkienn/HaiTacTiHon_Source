namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(DictionaryDebugView`2))]
[DefaultMember("Item")]
public class ReadOnlyDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	private struct DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private readonly IDictionary<TKey, TValue> _dictionary; //Field offset: 0x0
		private IEnumerator<KeyValuePair`2<TKey, TValue>> _enumerator; //Field offset: 0x0

		public override object Current
		{
			 get { } //Length: 167
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 846
		}

		public override object Key
		{
			 get { } //Length: 476
		}

		public override object Value
		{
			 get { } //Length: 476
		}

		public DictionaryEnumerator(IDictionary<TKey, TValue> dictionary) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
	internal sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		private readonly ICollection<TKey> _collection; //Field offset: 0x0
		private object _syncRoot; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 177
		}

		private override bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
		{
			private get { } //Length: 3
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 212
		}

		internal KeyCollection(ICollection<TKey> collection) { }

		internal KeyCollection() { }

		public override void CopyTo(TKey[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override IEnumerator<TKey> GetEnumerator() { }

		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
	internal sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		private readonly ICollection<TValue> _collection; //Field offset: 0x0
		private object _syncRoot; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 177
		}

		private override bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
		{
			private get { } //Length: 3
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 212
		}

		internal ValueCollection(ICollection<TValue> collection) { }

		internal ValueCollection() { }

		public override void CopyTo(TValue[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override IEnumerator<TValue> GetEnumerator() { }

		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private readonly IDictionary<TKey, TValue> m_dictionary; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0
	private KeyCollection<TKey, TValue> _keys; //Field offset: 0x0
	private ValueCollection<TKey, TValue> _values; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 73
	}

	public override TValue Item
	{
		 get { } //Length: 328
	}

	public KeyCollection<TKey, TValue> Keys
	{
		 get { } //Length: 217
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item
	{
		private get { } //Length: 328
		private set { } //Length: 73
	}

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 36
	}

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 36
	}

	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 36
	}

	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 36
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 212
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IDictionary.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IDictionary.Item
	{
		private get { } //Length: 378
		private set { } //Length: 73
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 36
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 36
	}

	public ValueCollection<TKey, TValue> Values
	{
		 get { } //Length: 217
	}

	public override bool ContainsKey(TKey key) { }

	public override int get_Count() { }

	public override TValue get_Item(TKey key) { }

	public KeyCollection<TKey, TValue> get_Keys() { }

	public ValueCollection<TKey, TValue> get_Values() { }

	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	private static bool IsCompatibleKey(object key) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }

	private override void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	private override TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	private override bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	private override void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }

	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override void System.Collections.IDictionary.Add(object key, object value) { }

	private override void System.Collections.IDictionary.Clear() { }

	private override bool System.Collections.IDictionary.Contains(object key) { }

	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	private override object System.Collections.IDictionary.get_Item(object key) { }

	private override ICollection System.Collections.IDictionary.get_Keys() { }

	private override ICollection System.Collections.IDictionary.get_Values() { }

	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private override void System.Collections.IDictionary.Remove(object key) { }

	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryGetValue(TKey key, out TValue value) { }

}

