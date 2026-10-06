namespace System.Collections.Generic;

public interface ICollection : IEnumerable<T>, IEnumerable
{

	public int Count
	{
		 get { } //Length: 0
	}

	public bool IsReadOnly
	{
		 get { } //Length: 0
	}

	public void Add(T item) { }

	public void Clear() { }

	public bool Contains(T item) { }

	public void CopyTo(T[] array, int arrayIndex) { }

	public int get_Count() { }

	public bool get_IsReadOnly() { }

	public bool Remove(T item) { }

}

