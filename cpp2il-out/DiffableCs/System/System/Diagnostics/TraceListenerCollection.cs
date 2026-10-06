namespace System.Diagnostics;

[DefaultMember("Item")]
public class TraceListenerCollection : IList, ICollection, IEnumerable
{
	private ArrayList list; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 42
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
		private get { } //Length: 42
		private set { } //Length: 305
	}

	internal TraceListenerCollection() { }

	public int Add(TraceListener listener) { }

	public override void Clear() { }

	public override int get_Count() { }

	public override IEnumerator GetEnumerator() { }

	internal void InitializeListener(TraceListener listener) { }

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

