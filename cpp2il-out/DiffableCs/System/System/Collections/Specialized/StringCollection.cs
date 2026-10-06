namespace System.Collections.Specialized;

[DefaultMember("Item")]
public class StringCollection : IList, ICollection, IEnumerable
{
	private readonly ArrayList data; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 42
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public string Item
	{
		 get { } //Length: 126
		 set { } //Length: 42
	}

	public override object SyncRoot
	{
		 get { } //Length: 42
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
		private get { } //Length: 126
		private set { } //Length: 138
	}

	public StringCollection() { }

	public int Add(string value) { }

	public override void Clear() { }

	public bool Contains(string value) { }

	public void CopyTo(String[] array, int index) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public string get_Item(int index) { }

	public override object get_SyncRoot() { }

	public int IndexOf(string value) { }

	public void Insert(int index, string value) { }

	public void Remove(string value) { }

	public override void RemoveAt(int index) { }

	public void set_Item(int index, string value) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

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

