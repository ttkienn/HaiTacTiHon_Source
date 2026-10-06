namespace System.Collections.Specialized;

[DefaultMember("Item")]
internal sealed class ReadOnlyList : IList, ICollection, IEnumerable
{
	private readonly IList _list; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 73
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
		 get { } //Length: 73
	}

	public override object Item
	{
		 get { } //Length: 84
		 set { } //Length: 78
	}

	public override object SyncRoot
	{
		 get { } //Length: 73
	}

	internal ReadOnlyList(IList list) { }

	public override int Add(object value) { }

	public override void Clear() { }

	public override bool Contains(object value) { }

	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(int index) { }

	public override object get_SyncRoot() { }

	public override IEnumerator GetEnumerator() { }

	public override int IndexOf(object value) { }

	public override void Insert(int index, object value) { }

	public override void Remove(object value) { }

	public override void RemoveAt(int index) { }

	public override void set_Item(int index, object value) { }

}

