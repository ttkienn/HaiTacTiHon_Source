namespace System.Collections.Generic;

internal class NullableEqualityComparer : EqualityComparer<Nullable`1<T>>
{

	public NullableEqualityComparer`1() { }

	public virtual bool Equals(Nullable<T> x, Nullable<T> y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode(Nullable<T> obj) { }

	public virtual int GetHashCode() { }

	internal virtual int IndexOf(Nullable<T>[] array, Nullable<T> value, int startIndex, int count) { }

	internal virtual int LastIndexOf(Nullable<T>[] array, Nullable<T> value, int startIndex, int count) { }

}

