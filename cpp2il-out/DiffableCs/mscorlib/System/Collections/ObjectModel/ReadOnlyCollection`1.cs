namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[DefaultMember("Item")]
public class ReadOnlyCollection : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	private IList<T> list; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 70
	}

	public override T Item
	{
		 get { } //Length: 205
	}

	protected IList<T> Items
	{
		 get { } //Length: 5
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override T System.Collections.Generic.IList<T>.Item
	{
		private get { } //Length: 205
		private set { } //Length: 12
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 212
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
		private get { } //Length: 229
		private set { } //Length: 12
	}

	public ReadOnlyCollection`1(IList<T> list) { }

	public override bool Contains(T value) { }

	public override void CopyTo(T[] array, int index) { }

	public override int get_Count() { }

	public override T get_Item(int index) { }

	protected IList<T> get_Items() { }

	public override IEnumerator<T> GetEnumerator() { }

	public override int IndexOf(T value) { }

	private static bool IsCompatibleObject(object value) { }

	private override void System.Collections.Generic.ICollection<T>.Add(T value) { }

	private override void System.Collections.Generic.ICollection<T>.Clear() { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<T>.Remove(T value) { }

	private override T System.Collections.Generic.IList<T>.get_Item(int index) { }

	private override void System.Collections.Generic.IList<T>.Insert(int index, T value) { }

	private override void System.Collections.Generic.IList<T>.RemoveAt(int index) { }

	private override void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

}

