namespace System.Threading;

internal sealed class ThreadPoolWorkQueue
{
	public class QueueSegment
	{
		internal readonly IThreadPoolWorkItem[] nodes; //Field offset: 0x10
		private int indexes; //Field offset: 0x18
		public QueueSegment Next; //Field offset: 0x20

		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
		public QueueSegment() { }

		private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

		private void GetIndexes(out int upper, out int lower) { }

		public bool IsUsedUp() { }

		public bool TryDequeue(out IThreadPoolWorkItem node) { }

		public bool TryEnqueue(IThreadPoolWorkItem node) { }

	}

	public class SparseArray
	{
		private T[] m_array; //Field offset: 0x0

		internal T[] Current
		{
			internal get { } //Length: 24
		}

		internal SparseArray`1(int initialSize) { }

		internal int Add(T e) { }

		internal T[] get_Current() { }

		internal void Remove(T e) { }

	}

	public class WorkStealingQueue
	{
		internal IThreadPoolWorkItem[] m_array; //Field offset: 0x10
		private int m_mask; //Field offset: 0x18
		private int m_headIndex; //Field offset: 0x1C
		private int m_tailIndex; //Field offset: 0x20
		private SpinLock m_foreignLock; //Field offset: 0x24

		public WorkStealingQueue() { }

		public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

		public bool LocalPop(out IThreadPoolWorkItem obj) { }

		public void LocalPush(IThreadPoolWorkItem obj) { }

		public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

		private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	}

	internal static SparseArray<WorkStealingQueue> allThreadQueues; //Field offset: 0x0
	internal QueueSegment queueHead; //Field offset: 0x10
	internal QueueSegment queueTail; //Field offset: 0x18
	private int numOutstandingThreadRequests; //Field offset: 0x20

	private static ThreadPoolWorkQueue() { }

	public ThreadPoolWorkQueue() { }

	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	internal static bool Dispatch() { }

	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	internal void EnsureThreadRequested() { }

	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	internal void MarkThreadRequestSatisfied() { }

}

