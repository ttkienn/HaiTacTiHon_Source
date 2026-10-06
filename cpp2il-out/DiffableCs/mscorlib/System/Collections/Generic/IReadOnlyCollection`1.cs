namespace System.Collections.Generic;

public interface IReadOnlyCollection : IEnumerable<T>, IEnumerable
{

	public int Count
	{
		 get { } //Length: 0
	}

	public int get_Count() { }

}

