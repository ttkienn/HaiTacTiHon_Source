namespace System.Collections.Generic;

[DefaultMember("Item")]
public interface IList : ICollection<T>, IEnumerable<T>, IEnumerable
{

	public T Item
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public T get_Item(int index) { }

	public int IndexOf(T item) { }

	public void Insert(int index, T item) { }

	public void RemoveAt(int index) { }

	public void set_Item(int index, T value) { }

}

