namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView`1))]
[IsReadOnly]
public struct ReadOnlyMemory : IEquatable<ReadOnlyMemory`1<T>>
{
	private readonly object _object; //Field offset: 0x0
	private readonly int _index; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public int Length
	{
		 get { } //Length: 8
	}

	public ReadOnlySpan<T> Span
	{
		 get { } //Length: 1082
	}

	public ReadOnlyMemory`1(T[] array) { }

	public ReadOnlyMemory`1(T[] array, int start, int length) { }

	private static int CombineHashCodes(int left, int right) { }

	private static int CombineHashCodes(int h1, int h2, int h3) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ReadOnlyMemory<T> other) { }

	public int get_Length() { }

	public ReadOnlySpan<T> get_Span() { }

	public virtual int GetHashCode() { }

	internal object GetObjectStartLength(out int start, out int length) { }

	public virtual string ToString() { }

}

