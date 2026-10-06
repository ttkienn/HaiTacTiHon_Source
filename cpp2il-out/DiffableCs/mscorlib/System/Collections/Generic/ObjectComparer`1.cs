namespace System.Collections.Generic;

internal class ObjectComparer : Comparer<T>
{

	public ObjectComparer`1() { }

	public virtual int Compare(T x, T y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

