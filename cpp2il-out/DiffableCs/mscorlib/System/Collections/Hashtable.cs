namespace System.Collections;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(HashtableDebugView))]
[DefaultMember("Item")]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable
{
	private struct bucket
	{
		public object key; //Field offset: 0x0
		public object val; //Field offset: 0x8
		public int hash_coll; //Field offset: 0x10

	}

	public class HashtableDebugView
	{

	}

	private class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
	{
		private Hashtable _hashtable; //Field offset: 0x10
		private int _bucket; //Field offset: 0x18
		private int _version; //Field offset: 0x1C
		private bool _current; //Field offset: 0x20
		private int _getObjectRetType; //Field offset: 0x24
		private object _currentKey; //Field offset: 0x28
		private object _currentValue; //Field offset: 0x30

		public override object Current
		{
			 get { } //Length: 249
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 148
		}

		public override object Key
		{
			 get { } //Length: 101
		}

		public override object Value
		{
			 get { } //Length: 101
		}

		internal HashtableEnumerator(Hashtable hashtable, int getObjRetType) { }

		public override object Clone() { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private class KeyCollection : ICollection, IEnumerable
	{
		private Hashtable _hashtable; //Field offset: 0x10

		public override int Count
		{
			 get { } //Length: 26
		}

		public override bool IsSynchronized
		{
			 get { } //Length: 42
		}

		public override object SyncRoot
		{
			 get { } //Length: 42
		}

		internal KeyCollection(Hashtable hashtable) { }

		public override void CopyTo(Array array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsSynchronized() { }

		public override object get_SyncRoot() { }

		public override IEnumerator GetEnumerator() { }

	}

	[DefaultMember("Item")]
	private class SyncHashtable : Hashtable, IEnumerable
	{
		protected Hashtable _table; //Field offset: 0x50

		public virtual int Count
		{
			 get { } //Length: 42
		}

		public virtual bool IsFixedSize
		{
			 get { } //Length: 42
		}

		public virtual bool IsReadOnly
		{
			 get { } //Length: 42
		}

		public virtual bool IsSynchronized
		{
			 get { } //Length: 3
		}

		public virtual object Item
		{
			 get { } //Length: 42
			 set { } //Length: 231
		}

		public virtual ICollection Keys
		{
			 get { } //Length: 224
		}

		public virtual object SyncRoot
		{
			 get { } //Length: 42
		}

		public virtual ICollection Values
		{
			 get { } //Length: 224
		}

		internal SyncHashtable(Hashtable table) { }

		internal SyncHashtable(SerializationInfo info, StreamingContext context) { }

		public virtual void Add(object key, object value) { }

		public virtual void Clear() { }

		public virtual object Clone() { }

		public virtual bool Contains(object key) { }

		public virtual bool ContainsKey(object key) { }

		public virtual void CopyTo(Array array, int arrayIndex) { }

		public virtual int get_Count() { }

		public virtual bool get_IsFixedSize() { }

		public virtual bool get_IsReadOnly() { }

		public virtual bool get_IsSynchronized() { }

		public virtual object get_Item(object key) { }

		public virtual ICollection get_Keys() { }

		public virtual object get_SyncRoot() { }

		public virtual ICollection get_Values() { }

		public virtual IDictionaryEnumerator GetEnumerator() { }

		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

		public virtual void OnDeserialization(object sender) { }

		public virtual void Remove(object key) { }

		public virtual void set_Item(object key, object value) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private class ValueCollection : ICollection, IEnumerable
	{
		private Hashtable _hashtable; //Field offset: 0x10

		public override int Count
		{
			 get { } //Length: 26
		}

		public override bool IsSynchronized
		{
			 get { } //Length: 42
		}

		public override object SyncRoot
		{
			 get { } //Length: 42
		}

		internal ValueCollection(Hashtable hashtable) { }

		public override void CopyTo(Array array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsSynchronized() { }

		public override object get_SyncRoot() { }

		public override IEnumerator GetEnumerator() { }

	}

	internal const int HashPrime = 101; //Field offset: 0x0
	private const string KeyComparerName = "KeyComparer"; //Field offset: 0x0
	private const string ValuesName = "Values"; //Field offset: 0x0
	private const string KeysName = "Keys"; //Field offset: 0x0
	private const string HashSizeName = "HashSize"; //Field offset: 0x0
	private static ConditionalWeakTable<Object, SerializationInfo> s_serializationInfoTable; //Field offset: 0x0
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	private const string VersionName = "Version"; //Field offset: 0x0
	private const string LoadFactorName = "LoadFactor"; //Field offset: 0x0
	private const int InitialSize = 3; //Field offset: 0x0
	private const string HashCodeProviderName = "HashCodeProvider"; //Field offset: 0x0
	private bucket[] _buckets; //Field offset: 0x10
	private int _count; //Field offset: 0x18
	private int _occupancy; //Field offset: 0x1C
	private int _loadsize; //Field offset: 0x20
	private float _loadFactor; //Field offset: 0x24
	private int _version; //Field offset: 0x28
	private bool _isWriterInProgress; //Field offset: 0x2C
	private ICollection _keys; //Field offset: 0x30
	private ICollection _values; //Field offset: 0x38
	private IEqualityComparer _keycomparer; //Field offset: 0x40
	private object _syncRoot; //Field offset: 0x48

	public override int Count
	{
		 get { } //Length: 4
	}

	public override bool IsFixedSize
	{
		 get { } //Length: 3
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public override object Item
	{
		 get { } //Length: 567
		 set { } //Length: 26
	}

	public override ICollection Keys
	{
		 get { } //Length: 121
	}

	private static ConditionalWeakTable<Object, SerializationInfo> SerializationInfoTable
	{
		private get { } //Length: 74
	}

	public override object SyncRoot
	{
		 get { } //Length: 104
	}

	public override ICollection Values
	{
		 get { } //Length: 121
	}

	protected Hashtable(SerializationInfo info, StreamingContext context) { }

	internal Hashtable(bool trash) { }

	public Hashtable() { }

	public Hashtable(int capacity) { }

	public Hashtable(int capacity, float loadFactor) { }

	public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
	public Hashtable(IHashCodeProvider hcp, IComparer comparer) { }

	public Hashtable(IEqualityComparer equalityComparer) { }

	public Hashtable(int capacity, IEqualityComparer equalityComparer) { }

	[Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
	public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	public override void Add(object key, object value) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public override void Clear() { }

	public override object Clone() { }

	public override bool Contains(object key) { }

	public override bool ContainsKey(object key) { }

	private void CopyEntries(Array array, int arrayIndex) { }

	private void CopyKeys(Array array, int arrayIndex) { }

	public override void CopyTo(Array array, int arrayIndex) { }

	private void CopyValues(Array array, int arrayIndex) { }

	private void expand() { }

	public override int get_Count() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(object key) { }

	public override ICollection get_Keys() { }

	private static ConditionalWeakTable<Object, SerializationInfo> get_SerializationInfoTable() { }

	public override object get_SyncRoot() { }

	public override ICollection get_Values() { }

	public override IDictionaryEnumerator GetEnumerator() { }

	protected override int GetHash(object key) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	private void Insert(object key, object nvalue, bool add) { }

	protected override bool KeyEquals(object item, object key) { }

	public override void OnDeserialization(object sender) { }

	private void putEntry(bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	private void rehash() { }

	private void rehash(int newsize) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public override void Remove(object key) { }

	public override void set_Item(object key, object value) { }

	public static Hashtable Synchronized(Hashtable table) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private void UpdateVersion() { }

}

