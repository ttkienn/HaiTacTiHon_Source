namespace System;

[DefaultMember("Item")]
[IsReadOnly]
public struct ArraySegment : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly T[] _array; //Field offset: 0x0
		private readonly int _start; //Field offset: 0x0
		private readonly int _end; //Field offset: 0x0
		private int _current; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 78
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 154
		}

		internal Enumerator(ArraySegment<T> arraySegment) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	[CompilerGenerated]
	private static readonly ArraySegment<T> <Empty>k__BackingField; //Field offset: 0x0
	private readonly T[] _array; //Field offset: 0x0
	private readonly int _offset; //Field offset: 0x0
	private readonly int _count; //Field offset: 0x0

	public T[] Array
	{
		 get { } //Length: 4
	}

	public override int Count
	{
		 get { } //Length: 4
	}

	public static ArraySegment<T> Empty
	{
		[CompilerGenerated]
		 get { } //Length: 158
	}

	public int Offset
	{
		 get { } //Length: 4
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override T System.Collections.Generic.IList<T>.Item
	{
		private get { } //Length: 194
		private set { } //Length: 208
	}

	private override T System.Collections.Generic.IReadOnlyList<T>.Item
	{
		private get { } //Length: 194
	}

	private static ArraySegment`1() { }

	public ArraySegment`1(T[] array) { }

	public ArraySegment`1(T[] array, int offset, int count) { }

	public override void CopyTo(T[] destination, int destinationIndex) { }

	public bool Equals(ArraySegment<T> obj) { }

	public virtual bool Equals(object obj) { }

	public T[] get_Array() { }

	public override int get_Count() { }

	[CompilerGenerated]
	public static ArraySegment<T> get_Empty() { }

	public int get_Offset() { }

	public Enumerator<T> GetEnumerator() { }

	public virtual int GetHashCode() { }

	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	private override void System.Collections.Generic.ICollection<T>.Clear() { }

	private override bool System.Collections.Generic.ICollection<T>.Contains(T item) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<T>.Remove(T item) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override T System.Collections.Generic.IList<T>.get_Item(int index) { }

	private override int System.Collections.Generic.IList<T>.IndexOf(T item) { }

	private override void System.Collections.Generic.IList<T>.Insert(int index, T item) { }

	private override void System.Collections.Generic.IList<T>.RemoveAt(int index) { }

	private override void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }

	private override T System.Collections.Generic.IReadOnlyList<T>.get_Item(int index) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private void ThrowInvalidOperationIfDefault() { }

}

