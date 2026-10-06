namespace System;

public struct ValueTuple : IEquatable<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, TRest>>, IValueTupleInternal, ITuple
{
	public T1 Item1; //Field offset: 0x0
	public T2 Item2; //Field offset: 0x0
	public T3 Item3; //Field offset: 0x0
	public T4 Item4; //Field offset: 0x0
	public T5 Item5; //Field offset: 0x0
	public T6 Item6; //Field offset: 0x0
	public T7 Item7; //Field offset: 0x0
	public TRest Rest; //Field offset: 0x0

	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		private get { } //Length: 145
	}

	public ValueTuple`8(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) { }

	public override int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { }

	public virtual int GetHashCode() { }

	private int GetHashCodeCore(IEqualityComparer comparer) { }

	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	private override int System.IComparable.CompareTo(object other) { }

	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	private override string System.IValueTupleInternal.ToStringEnd() { }

	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	public virtual string ToString() { }

}

