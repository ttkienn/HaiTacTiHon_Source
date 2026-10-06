namespace System;

public class Tuple : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
{
	private readonly T1 m_Item1; //Field offset: 0x0
	private readonly T2 m_Item2; //Field offset: 0x0
	private readonly T3 m_Item3; //Field offset: 0x0
	private readonly T4 m_Item4; //Field offset: 0x0

	public T1 Item1
	{
		 get { } //Length: 5
	}

	public T2 Item2
	{
		 get { } //Length: 5
	}

	public T3 Item3
	{
		 get { } //Length: 5
	}

	public T4 Item4
	{
		 get { } //Length: 5
	}

	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		private get { } //Length: 6
	}

	public Tuple`4(T1 item1, T2 item2, T3 item3, T4 item4) { }

	public virtual bool Equals(object obj) { }

	public T1 get_Item1() { }

	public T2 get_Item2() { }

	public T3 get_Item3() { }

	public T4 get_Item4() { }

	public virtual int GetHashCode() { }

	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	private override int System.IComparable.CompareTo(object obj) { }

	private override string System.ITupleInternal.ToString(StringBuilder sb) { }

	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	public virtual string ToString() { }

}

