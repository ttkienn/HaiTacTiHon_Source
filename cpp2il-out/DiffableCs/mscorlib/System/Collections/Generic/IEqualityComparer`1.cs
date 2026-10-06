namespace System.Collections.Generic;

public interface IEqualityComparer
{

	public bool Equals(T x, T y) { }

	public int GetHashCode(T obj) { }

}

