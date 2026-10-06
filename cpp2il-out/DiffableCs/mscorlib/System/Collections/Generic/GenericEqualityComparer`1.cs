namespace System.Collections.Generic;

internal class GenericEqualityComparer : EqualityComparer<T>
{

	public GenericEqualityComparer`1() { }

	public virtual bool Equals(T x, T y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode(T obj) { }

	public virtual int GetHashCode() { }

	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }

	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }

}

