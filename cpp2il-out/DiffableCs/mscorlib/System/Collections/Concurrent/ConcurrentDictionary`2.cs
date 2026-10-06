namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
public class ConcurrentDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__35 : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private KeyValuePair<TKey, TValue> <>2__current; //Field offset: 0x0
		public ConcurrentDictionary<TKey, TValue> <>4__this; //Field offset: 0x0
		private Node<TKey, TValue>[] <buckets>5__2; //Field offset: 0x0
		private int <i>5__3; //Field offset: 0x0
		private Node<TKey, TValue> <current>5__4; //Field offset: 0x0

		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 21
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 54
		}

		[DebuggerHidden]
		public <GetEnumerator>d__35(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private IEnumerator<KeyValuePair`2<TKey, TValue>> _enumerator; //Field offset: 0x0

		public override object Current
		{
			 get { } //Length: 334
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 267
		}

		public override object Key
		{
			 get { } //Length: 121
		}

		public override object Value
		{
			 get { } //Length: 92
		}

		internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private sealed class Node
	{
		internal readonly TKey _key; //Field offset: 0x0
		internal TValue _value; //Field offset: 0x0
		internal Node<TKey, TValue> _next; //Field offset: 0x0
		internal readonly int _hashcode; //Field offset: 0x0

		internal Node(TKey key, TValue value, int hashcode, Node<TKey, TValue> next) { }

	}

	private sealed class Tables
	{
		internal readonly Node<TKey, TValue>[] _buckets; //Field offset: 0x0
		internal readonly Object[] _locks; //Field offset: 0x0
		internal Int32[] _countPerLock; //Field offset: 0x0

		internal Tables(Node<TKey, TValue>[] buckets, Object[] locks, Int32[] countPerLock) { }

	}

	private static readonly bool s_isValueWriteAtomic; //Field offset: 0x0
	private Tables<TKey, TValue> _tables; //Field offset: 0x0
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0
	private readonly bool _growLockArray; //Field offset: 0x0
	private int _budget; //Field offset: 0x0
	private KeyValuePair<TKey, TValue>[] _serializationArray; //Field offset: 0x0
	private int _serializationConcurrencyLevel; //Field offset: 0x0
	private int _serializationCapacity; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 208
	}

	private static int DefaultConcurrencyLevel
	{
		private get { } //Length: 64
	}

	public override TValue Item
	{
		 get { } //Length: 192
		 set { } //Length: 328
	}

	public override ICollection<TKey> Keys
	{
		 get { } //Length: 23
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 23
	}

	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 23
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 73
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
		private get { } //Length: 281
		private set { } //Length: 819
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 23
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 23
	}

	public override ICollection<TValue> Values
	{
		 get { } //Length: 23
	}

	private static ConcurrentDictionary`2() { }

	public ConcurrentDictionary`2() { }

	public ConcurrentDictionary`2(IEqualityComparer<TKey> comparer) { }

	internal ConcurrentDictionary`2(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }

	private void AcquireAllLocks(ref int locksAcquired) { }

	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }

	public override void Clear() { }

	public override bool ContainsKey(TKey key) { }

	private void CopyToEntries(DictionaryEntry[] array, int index) { }

	private void CopyToObjects(Object[] array, int index) { }

	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }

	public override int get_Count() { }

	private static int get_DefaultConcurrencyLevel() { }

	public override TValue get_Item(TKey key) { }

	public override ICollection<TKey> get_Keys() { }

	public override ICollection<TValue> get_Values() { }

	private static int GetBucket(int hashcode, int bucketCount) { }

	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }

	private int GetCountInternal() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__35))]
	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	private ReadOnlyCollection<TKey> GetKeys() { }

	public TValue GetOrAdd(TKey key, TValue value) { }

	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }

	private ReadOnlyCollection<TValue> GetValues() { }

	private void GrowTable(Tables<TKey, TValue> tables) { }

	private void InitializeFromCollection(IEnumerable<KeyValuePair`2<TKey, TValue>> collection) { }

	private static bool IsValueWriteAtomic() { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	[OnSerialized]
	private void OnSerialized(StreamingContext context) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext context) { }

	private void ReleaseLocks(int fromInclusive, int toExclusive) { }

	public override void set_Item(TKey key, TValue value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	private override void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	private override bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

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

	private static void ThrowKeyNotFoundException(object key) { }

	private static void ThrowKeyNullException() { }

	public KeyValuePair<TKey, TValue>[] ToArray() { }

	public bool TryAdd(TKey key, TValue value) { }

	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }

	public override bool TryGetValue(TKey key, out TValue value) { }

	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }

	public bool TryRemove(TKey key, out TValue value) { }

	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }

}

