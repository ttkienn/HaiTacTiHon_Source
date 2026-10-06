namespace System.Collections.Generic;

public interface IEnumerable : IEnumerable
{

	public IEnumerator<T> GetEnumerator() { }

}

