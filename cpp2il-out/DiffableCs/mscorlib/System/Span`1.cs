namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView`1))]
[DefaultMember("Item")]
[IsByRefLike]
[IsReadOnly]
[NonVersionable]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct Span
{
	internal readonly ByReference<T> _pointer; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public T Item
	{
		[Intrinsic]
		[NonVersionable]
		 get { } //Length: 45
	}

	public int Length
	{
		[NonVersionable]
		 get { } //Length: 4
	}

	public Span`1(T[] array) { }

	public Span`1(T[] array, int start, int length) { }

	[CLSCompliant(False)]
	public Span`1(Void* pointer, int length) { }

	internal Span`1(ref T ptr, int length) { }

	public void Clear() { }

	public void CopyTo(Span<T> destination) { }

	[Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
	public virtual bool Equals(object obj) { }

	public void Fill(T value) { }

	[Intrinsic]
	[NonVersionable]
	public T get_Item(int index) { }

	[NonVersionable]
	public int get_Length() { }

	[Obsolete("GetHashCode() on Span will always throw an exception.")]
	public virtual int GetHashCode() { }

	public T GetPinnableReference() { }

	public static Span<T> op_Implicit(T[] array) { }

	public static ReadOnlySpan<T> op_Implicit(Span<T> span) { }

	public Span<T> Slice(int start, int length) { }

	public Span<T> Slice(int start) { }

	public T[] ToArray() { }

	public virtual string ToString() { }

	public bool TryCopyTo(Span<T> destination) { }

}

