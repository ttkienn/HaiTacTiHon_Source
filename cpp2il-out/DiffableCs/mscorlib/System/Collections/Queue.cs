namespace System.Collections;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(QueueDebugView))]
public class Queue : ICollection, IEnumerable, ICloneable
{
	public class QueueDebugView
	{

	}

	private class QueueEnumerator : IEnumerator, ICloneable
	{
		private Queue _q; //Field offset: 0x10
		private int _index; //Field offset: 0x18
		private int _version; //Field offset: 0x1C
		private object _currentElement; //Field offset: 0x20

		public override object Current
		{
			 get { } //Length: 189
		}

		internal QueueEnumerator(Queue q) { }

		public override object Clone() { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private Object[] _array; //Field offset: 0x10
	private int _head; //Field offset: 0x18
	private int _tail; //Field offset: 0x1C
	private int _size; //Field offset: 0x20
	private int _growFactor; //Field offset: 0x24
	private int _version; //Field offset: 0x28
	private object _syncRoot; //Field offset: 0x30

	public override int Count
	{
		 get { } //Length: 4
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public override object SyncRoot
	{
		 get { } //Length: 107
	}

	public Queue() { }

	public Queue(int capacity) { }

	public Queue(int capacity, float growFactor) { }

	public Queue(ICollection col) { }

	public override object Clone() { }

	public override void CopyTo(Array array, int index) { }

	public override object Dequeue() { }

	public override void Enqueue(object obj) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public override object get_SyncRoot() { }

	internal object GetElement(int i) { }

	public override IEnumerator GetEnumerator() { }

	public override object Peek() { }

	private void SetCapacity(int capacity) { }

}

