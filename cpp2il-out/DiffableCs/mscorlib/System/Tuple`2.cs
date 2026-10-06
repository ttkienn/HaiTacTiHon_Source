namespace System;

public class Tuple : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
{
	private readonly T1 m_Item1; //Field offset: 0x0
	private readonly T2 m_Item2; //Field offset: 0x0

	public T1 Item1
	{
		 get { } //Length: 11
	}

	public T2 Item2
	{
		 get { } //Length: 5
	}

	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		private get { } //Length: 6
	}

	public Tuple`2(T1 item1, T2 item2) { }

	public virtual bool Equals(object obj) { }

	public T1 get_Item1() { }

	public T2 get_Item2() { }

	public virtual int GetHashCode() { }

	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	private override int System.IComparable.CompareTo(object obj) { }

	private override string System.ITupleInternal.ToString(StringBuilder sb) { }

	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	public virtual string ToString() { }

}

