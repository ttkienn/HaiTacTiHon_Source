namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
public class HashSet : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	public struct ElementCount
	{
		internal int uniqueCount; //Field offset: 0x0
		internal int unfoundCount; //Field offset: 0x0

	}

	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private HashSet<T> _set; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private T _current; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 191
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 188
		}

		internal Enumerator(HashSet<T> set) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	public struct Slot
	{
		internal int hashCode; //Field offset: 0x0
		internal int next; //Field offset: 0x0
		internal T value; //Field offset: 0x0

	}

	private const int Lower31BitMask = 2147483647; //Field offset: 0x0
	private const int StackAllocThreshold = 100; //Field offset: 0x0
	private const int ShrinkThreshold = 3; //Field offset: 0x0
	private const string CapacityName = "Capacity"; //Field offset: 0x0
	private const string ElementsName = "Elements"; //Field offset: 0x0
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	private const string VersionName = "Version"; //Field offset: 0x0
	private Int32[] _buckets; //Field offset: 0x0
	private Slot<T>[] _slots; //Field offset: 0x0
	private int _count; //Field offset: 0x0
	private int _lastIndex; //Field offset: 0x0
	private int _freeList; //Field offset: 0x0
	private IEqualityComparer<T> _comparer; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private SerializationInfo _siInfo; //Field offset: 0x0

	public IEqualityComparer<T> Comparer
	{
		 get { } //Length: 5
	}

	public override int Count
	{
		 get { } //Length: 4
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 3
	}

	public HashSet`1() { }

	public HashSet`1(IEqualityComparer<T> comparer) { }

	public HashSet`1(int capacity) { }

	public HashSet`1(IEnumerable<T> collection) { }

	public HashSet`1(IEnumerable<T> collection, IEqualityComparer<T> comparer) { }

	protected HashSet`1(SerializationInfo info, StreamingContext context) { }

	public HashSet`1(int capacity, IEqualityComparer<T> comparer) { }

	public override bool Add(T item) { }

	private bool AddIfNotPresent(T value) { }

	private void AddValue(int index, int hashCode, T value) { }

	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2) { }

	private ElementCount<T> CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	private bool ContainsAllElements(IEnumerable<T> other) { }

	private void CopyFrom(HashSet<T> source) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	public void CopyTo(T[] array, int arrayIndex, int count) { }

	public void CopyTo(T[] array) { }

	public IEqualityComparer<T> get_Comparer() { }

	public override int get_Count() { }

	public Enumerator<T> GetEnumerator() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void IncreaseCapacity() { }

	private int Initialize(int capacity) { }

	private int InternalGetHashCode(T item) { }

	private int InternalIndexOf(T item) { }

	public override void OnDeserialization(object sender) { }

	public override bool Remove(T item) { }

	public int RemoveWhere(Predicate<T> match) { }

	private void SetCapacity(int newSize) { }

	public override bool SetEquals(IEnumerable<T> other) { }

	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void TrimExcess() { }

	public override void UnionWith(IEnumerable<T> other) { }

}

