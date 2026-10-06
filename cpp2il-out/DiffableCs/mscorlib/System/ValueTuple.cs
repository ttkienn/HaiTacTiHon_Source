namespace System;

public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple
{

	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		private get { } //Length: 3
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8) { }

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6) { }

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5) { }

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }

	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	internal static int CombineHashCodes(int h1, int h2) { }

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7) { }

	public override int CompareTo(ValueTuple other) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ValueTuple other) { }

	public virtual int GetHashCode() { }

	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	private override int System.IComparable.CompareTo(object other) { }

	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	private override string System.IValueTupleInternal.ToStringEnd() { }

	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	public virtual string ToString() { }

}

