namespace System;

internal interface IValueTupleInternal : ITuple
{

	public int GetHashCode(IEqualityComparer comparer) { }

	public string ToStringEnd() { }

}

