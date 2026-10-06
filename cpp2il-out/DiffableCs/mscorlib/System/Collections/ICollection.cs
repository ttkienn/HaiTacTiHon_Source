namespace System.Collections;

public interface ICollection : IEnumerable
{

	public int Count
	{
		 get { } //Length: 0
	}

	public bool IsSynchronized
	{
		 get { } //Length: 0
	}

	public object SyncRoot
	{
		 get { } //Length: 0
	}

	public void CopyTo(Array array, int index) { }

	public int get_Count() { }

	public bool get_IsSynchronized() { }

	public object get_SyncRoot() { }

}

