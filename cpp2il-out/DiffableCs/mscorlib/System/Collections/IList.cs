namespace System.Collections;

[DefaultMember("Item")]
public interface IList : ICollection, IEnumerable
{

	public bool IsFixedSize
	{
		 get { } //Length: 0
	}

	public bool IsReadOnly
	{
		 get { } //Length: 0
	}

	public object Item
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int Add(object value) { }

	public void Clear() { }

	public bool Contains(object value) { }

	public bool get_IsFixedSize() { }

	public bool get_IsReadOnly() { }

	public object get_Item(int index) { }

	public int IndexOf(object value) { }

	public void Insert(int index, object value) { }

	public void Remove(object value) { }

	public void RemoveAt(int index) { }

	public void set_Item(int index, object value) { }

}

