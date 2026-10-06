namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView`1))]
[IsReadOnly]
public struct Memory : IEquatable<Memory`1<T>>
{
	private readonly object _object; //Field offset: 0x0
	private readonly int _index; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public int Length
	{
		 get { } //Length: 8
	}

	public Span<T> Span
	{
		 get { } //Length: 1017
	}

	public Memory`1(T[] array) { }

	public Memory`1(T[] array, int start, int length) { }

	internal Memory`1(object obj, int start, int length) { }

	private static int CombineHashCodes(int left, int right) { }

	private static int CombineHashCodes(int h1, int h2, int h3) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(Memory<T> other) { }

	public int get_Length() { }

	public Span<T> get_Span() { }

	public virtual int GetHashCode() { }

	public static Memory<T> op_Implicit(T[] array) { }

	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }

	public MemoryHandle Pin() { }

	public Memory<T> Slice(int start, int length) { }

	public T[] ToArray() { }

	public virtual string ToString() { }

}

