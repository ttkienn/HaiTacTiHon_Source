namespace System.Collections;

public interface IEnumerator
{

	public object Current
	{
		 get { } //Length: 0
	}

	public object get_Current() { }

	public bool MoveNext() { }

	public void Reset() { }

}

