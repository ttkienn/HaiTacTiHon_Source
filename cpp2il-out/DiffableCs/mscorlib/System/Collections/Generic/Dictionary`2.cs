namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
public class Dictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>, ISerializable, IDeserializationCallback
{
	private struct Entry
	{
		public int hashCode; //Field offset: 0x0
		public int next; //Field offset: 0x0
		public TKey key; //Field offset: 0x0
		public TValue value; //Field offset: 0x0

	}

	internal struct Enumerator : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private KeyValuePair<TKey, TValue> _current; //Field offset: 0x0
		private int _getEnumeratorRetType; //Field offset: 0x0

		public override KeyValuePair<TKey, TValue> Current
		{
			 get { } //Length: 21
		}

		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			private get { } //Length: 207
		}

		private override object System.Collections.IDictionaryEnumerator.Key
		{
			private get { } //Length: 132
		}

		private override object System.Collections.IDictionaryEnumerator.Value
		{
			private get { } //Length: 85
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 478
		}

		internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }

		public override void Dispose() { }

		public override KeyValuePair<TKey, TValue> get_Current() { }

		public override bool MoveNext() { }

		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView`2))]
	internal sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		internal struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
			private int _index; //Field offset: 0x0
			private int _version; //Field offset: 0x0
			private TKey _currentKey; //Field offset: 0x0

			public override TKey Current
			{
				 get { } //Length: 11
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 114
			}

			internal Enumerator(Dictionary<TKey, TValue> dictionary) { }

			public override void Dispose() { }

			public override TKey get_Current() { }

			public override bool MoveNext() { }

			private override object System.Collections.IEnumerator.get_Current() { }

			private override void System.Collections.IEnumerator.Reset() { }

		}

		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 42
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
			private get { } //Length: 73
		}

		public KeyCollection(Dictionary<TKey, TValue> dictionary) { }

		public override void CopyTo(TKey[] array, int index) { }

		public override int get_Count() { }

		public Enumerator<TKey, TValue> GetEnumerator() { }

		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		private override IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView`2))]
	internal sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		internal struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
			private int _index; //Field offset: 0x0
			private int _version; //Field offset: 0x0
			private TValue _currentValue; //Field offset: 0x0

			public override TValue Current
			{
				 get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 55
			}

			internal Enumerator(Dictionary<TKey, TValue> dictionary) { }

			public override void Dispose() { }

			public override TValue get_Current() { }

			public override bool MoveNext() { }

			private override object System.Collections.IEnumerator.get_Current() { }

			private override void System.Collections.IEnumerator.Reset() { }

		}

		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 42
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
			private get { } //Length: 73
		}

		public ValueCollection(Dictionary<TKey, TValue> dictionary) { }

		public override void CopyTo(TValue[] array, int index) { }

		public override int get_Count() { }

		public Enumerator<TKey, TValue> GetEnumerator() { }

		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private const string VersionName = "Version"; //Field offset: 0x0
	private const string HashSizeName = "HashSize"; //Field offset: 0x0
	private const string KeyValuePairsName = "KeyValuePairs"; //Field offset: 0x0
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	private Int32[] _buckets; //Field offset: 0x0
	private Entry<TKey, TValue>[] _entries; //Field offset: 0x0
	private int _count; //Field offset: 0x0
	private int _freeList; //Field offset: 0x0
	private int _freeCount; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0
	private KeyCollection<TKey, TValue> _keys; //Field offset: 0x0
	private ValueCollection<TKey, TValue> _values; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 7
	}

	public override TValue Item
	{
		 get { } //Length: 177
		 set { } //Length: 53
	}

	public KeyCollection<TKey, TValue> Keys
	{
		 get { } //Length: 154
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 154
	}

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 154
	}

	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 154
	}

	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 154
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 104
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
		private get { } //Length: 290
		private set { } //Length: 495
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 169
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 169
	}

	public ValueCollection<TKey, TValue> Values
	{
		 get { } //Length: 154
	}

	public Dictionary`2() { }

	public Dictionary`2(int capacity) { }

	public Dictionary`2(IEqualityComparer<TKey> comparer) { }

	public Dictionary`2(int capacity, IEqualityComparer<TKey> comparer) { }

	public Dictionary`2(IDictionary<TKey, TValue> dictionary) { }

	public Dictionary`2(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) { }

	protected Dictionary`2(SerializationInfo info, StreamingContext context) { }

	public override void Add(TKey key, TValue value) { }

	public override void Clear() { }

	public override bool ContainsKey(TKey key) { }

	public bool ContainsValue(TValue value) { }

	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	private int FindEntry(TKey key) { }

	public override int get_Count() { }

	public override TValue get_Item(TKey key) { }

	public KeyCollection<TKey, TValue> get_Keys() { }

	public ValueCollection<TKey, TValue> get_Values() { }

	public Enumerator<TKey, TValue> GetEnumerator() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private int Initialize(int capacity) { }

	private static bool IsCompatibleKey(object key) { }

	public override void OnDeserialization(object sender) { }

	public override bool Remove(TKey key) { }

	private void Resize(int newSize, bool forceNewHashCodes) { }

	private void Resize() { }

	public override void set_Item(TKey key, TValue value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override void System.Collections.IDictionary.Add(object key, object value) { }

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

	public bool TryAdd(TKey key, TValue value) { }

	public override bool TryGetValue(TKey key, out TValue value) { }

	private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior) { }

}

