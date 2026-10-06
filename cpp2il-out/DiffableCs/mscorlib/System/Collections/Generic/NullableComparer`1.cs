namespace System.Collections.Generic;

internal class NullableComparer : Comparer<Nullable`1<T>>
{

	public NullableComparer`1() { }

	public virtual int Compare(Nullable<T> x, Nullable<T> y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

