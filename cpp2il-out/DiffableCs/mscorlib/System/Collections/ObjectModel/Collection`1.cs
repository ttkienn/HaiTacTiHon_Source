namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[DefaultMember("Item")]
public class Collection : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	private IList<T> items; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 70
	}

	public override T Item
	{
		 get { } //Length: 84
		 set { } //Length: 238
	}

	protected IList<T> Items
	{
		 get { } //Length: 5
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 73
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 92
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 167
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 73
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 84
		private set { } //Length: 441
	}

	public Collection`1() { }

	public Collection`1(IList<T> list) { }

	public override void Add(T item) { }

	public override void Clear() { }

	protected override void ClearItems() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int index) { }

	public override int get_Count() { }

	public override T get_Item(int index) { }

	protected IList<T> get_Items() { }

	public override IEnumerator<T> GetEnumerator() { }

	public override int IndexOf(T item) { }

	public override void Insert(int index, T item) { }

	protected override void InsertItem(int index, T item) { }

	private static bool IsCompatibleObject(object value) { }

	public override bool Remove(T item) { }

	public override void RemoveAt(int index) { }

	protected override void RemoveItem(int index) { }

	public override void set_Item(int index, T value) { }

	protected override void SetItem(int index, T item) { }

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

}

