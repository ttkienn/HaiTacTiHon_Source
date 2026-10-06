namespace System.Collections.Generic;

internal class GenericComparer : Comparer<T>
{

	public GenericComparer`1() { }

	public virtual int Compare(T x, T y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

