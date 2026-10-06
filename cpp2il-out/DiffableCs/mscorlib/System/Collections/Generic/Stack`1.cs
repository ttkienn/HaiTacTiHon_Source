namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(StackDebugView`1))]
[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
public class Stack : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly Stack<T> _stack; //Field offset: 0x0
		private readonly int _version; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private T _currentElement; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 61
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 151
		}

		internal Enumerator(Stack<T> stack) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

		private void ThrowEnumerationNotStartedOrEnded() { }

	}

	private const int DefaultCapacity = 4; //Field offset: 0x0
	private T[] _array; //Field offset: 0x0
	private int _size; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 4
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 104
	}

	public Stack`1() { }

	public Stack`1(int capacity) { }

	public void Clear() { }

	public bool Contains(T item) { }

	public override int get_Count() { }

	public Enumerator<T> GetEnumerator() { }

	public T Peek() { }

	public T Pop() { }

	public void Push(T item) { }

	private void PushWithResize(T item) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private void ThrowForEmptyStack() { }

}

