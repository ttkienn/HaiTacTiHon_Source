namespace System.Collections;

public abstract class CollectionBase : IList, ICollection, IEnumerable
{
	private ArrayList _list; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 42
	}

	protected ArrayList InnerList
	{
		 get { } //Length: 5
	}

	protected IList List
	{
		 get { } //Length: 4
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 42
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 42
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 42
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 42
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 192
		private set { } //Length: 448
	}

	protected CollectionBase() { }

	public override void Clear() { }

	public override int get_Count() { }

	protected ArrayList get_InnerList() { }

	protected IList get_List() { }

	public override IEnumerator GetEnumerator() { }

	protected override void OnClear() { }

	protected override void OnClearComplete() { }

	protected override void OnInsert(int index, object value) { }

	protected override void OnInsertComplete(int index, object value) { }

	protected override void OnRemove(int index, object value) { }

	protected override void OnRemoveComplete(int index, object value) { }

	protected override void OnSet(int index, object oldValue, object newValue) { }

	protected override void OnSetComplete(int index, object oldValue, object newValue) { }

	protected override void OnValidate(object value) { }

	public override void RemoveAt(int index) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

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

