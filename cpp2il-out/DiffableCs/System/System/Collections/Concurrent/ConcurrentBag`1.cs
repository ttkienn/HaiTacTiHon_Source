namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView`1))]
public class ConcurrentBag : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	private sealed class Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly T[] _array; //Field offset: 0x0
		private T _current; //Field offset: 0x0
		private int _index; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 149
		}

		public Enumerator(T[] array) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private sealed class WorkStealingQueue
	{
		private int _headIndex; //Field offset: 0x0
		private int _tailIndex; //Field offset: 0x0
		private T[] _array; //Field offset: 0x0
		private int _mask; //Field offset: 0x0
		private int _addTakeCount; //Field offset: 0x0
		private int _stealCount; //Field offset: 0x0
		internal int _currentOp; //Field offset: 0x0
		internal bool _frozen; //Field offset: 0x0
		internal readonly WorkStealingQueue<T> _nextQueue; //Field offset: 0x0
		internal readonly int _ownerThreadId; //Field offset: 0x0

		internal int DangerousCount
		{
			internal get { } //Length: 7
		}

		internal WorkStealingQueue(WorkStealingQueue<T> nextQueue) { }

		internal int DangerousCopyTo(T[] array, int arrayIndex) { }

		internal int get_DangerousCount() { }

		internal void LocalPush(T item, ref long emptyToNonEmptyListTransitionCount) { }

	}

	private readonly ThreadLocal<WorkStealingQueue<T>> _locals; //Field offset: 0x0
	private WorkStealingQueue<T> _workStealingQueues; //Field offset: 0x0
	private long _emptyToNonEmptyListTransitionCount; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 256
	}

	private int DangerousCount
	{
		private get { } //Length: 138
	}

	private object GlobalQueuesLock
	{
		private get { } //Length: 5
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 73
	}

	public ConcurrentBag`1() { }

	public void Add(T item) { }

	private int CopyFromEachQueueToArray(T[] array, int index) { }

	public override void CopyTo(T[] array, int index) { }

	private WorkStealingQueue<T> CreateWorkStealingQueueForCurrentThread() { }

	private void FreezeBag(ref bool lockTaken) { }

	public override int get_Count() { }

	private int get_DangerousCount() { }

	private object get_GlobalQueuesLock() { }

	private WorkStealingQueue<T> GetCurrentThreadWorkStealingQueue(bool forceCreate) { }

	public override IEnumerator<T> GetEnumerator() { }

	private WorkStealingQueue<T> GetUnownedWorkStealingQueue() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override T[] ToArray() { }

	private void UnfreezeBag(bool lockTaken) { }

}

