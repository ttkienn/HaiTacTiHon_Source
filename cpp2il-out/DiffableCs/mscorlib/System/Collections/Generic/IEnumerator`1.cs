namespace System.Collections.Generic;

public interface IEnumerator : IDisposable, IEnumerator
{

	public T Current
	{
		 get { } //Length: 0
	}

	public T get_Current() { }

}

