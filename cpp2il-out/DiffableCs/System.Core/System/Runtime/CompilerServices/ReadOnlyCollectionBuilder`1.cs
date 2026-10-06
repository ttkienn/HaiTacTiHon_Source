namespace System.Runtime.CompilerServices;

[DefaultMember("Item")]
public sealed class ReadOnlyCollectionBuilder : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection
{
	private class Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly ReadOnlyCollectionBuilder<T> _builder; //Field offset: 0x0
		private readonly int _version; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private T _current; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 66
		}

		internal Enumerator(ReadOnlyCollectionBuilder<T> builder) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	private T[] _items; //Field offset: 0x0
	private int _size; //Field offset: 0x0
	private int _version; //Field offset: 0x0

	public int Capacity
	{
		 set { } //Length: 257
	}

	public override int Count
	{
		 get { } //Length: 4
	}

	public override T Item
	{
		 get { } //Length: 123
		 set { } //Length: 145
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 4
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 138
		private set { } //Length: 399
	}

	public ReadOnlyCollectionBuilder`1() { }

	public ReadOnlyCollectionBuilder`1(int capacity) { }

	public override void Add(T item) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	private void EnsureCapacity(int min) { }

	public override int get_Count() { }

	public override T get_Item(int index) { }

	public override IEnumerator<T> GetEnumerator() { }

	public override int IndexOf(T item) { }

	public override void Insert(int index, T item) { }

	private static bool IsCompatibleObject(object value) { }

	public override bool Remove(T item) { }

	public override void RemoveAt(int index) { }

	public void set_Capacity(int value) { }

	public override void set_Item(int index, T value) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

	public T[] ToArray() { }

	public ReadOnlyCollection<T> ToReadOnlyCollection() { }

	private static void ValidateNullValue(object value, string argument) { }

}

