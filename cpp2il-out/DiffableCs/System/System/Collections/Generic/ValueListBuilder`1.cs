namespace System.Collections.Generic;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct ValueListBuilder
{
	private Span<T> _span; //Field offset: 0x0
	private T[] _arrayFromPool; //Field offset: 0x0
	private int _pos; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 29
	}

	public int Length
	{
		 get { } //Length: 4
	}

	public ValueListBuilder`1(Span<T> initialSpan) { }

	public void Append(T item) { }

	public ReadOnlySpan<T> AsSpan() { }

	public void Dispose() { }

	public T get_Item(int index) { }

	public int get_Length() { }

	private void Grow() { }

	public T Pop() { }

}

