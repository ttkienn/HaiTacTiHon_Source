namespace System.Net;

internal static class TimerThread
{
	public sealed class Callback : MulticastDelegate
	{

		public Callback(object object, IntPtr method) { }

		public override void Invoke(Timer timer, int timeNoticed, object context) { }

	}

	private class InfiniteTimer : Timer
	{
		private int cancelled; //Field offset: 0x18

		internal virtual bool HasExpired
		{
			internal get { } //Length: 3
		}

		internal InfiniteTimer() { }

		internal virtual bool Cancel() { }

		internal virtual bool get_HasExpired() { }

	}

	private class InfiniteTimerQueue : Queue
	{

		internal InfiniteTimerQueue() { }

		internal virtual Timer CreateTimer(Callback callback, object context) { }

	}

	public abstract class Queue
	{
		private readonly int m_DurationMilliseconds; //Field offset: 0x10

		internal int Duration
		{
			internal get { } //Length: 191
		}

		internal Queue(int durationMilliseconds) { }

		internal abstract Timer CreateTimer(Callback callback, object context) { }

		internal int get_Duration() { }

	}

	public abstract class Timer : IDisposable
	{
		private readonly int m_StartTimeMilliseconds; //Field offset: 0x10
		private readonly int m_DurationMilliseconds; //Field offset: 0x14

		internal int Expiration
		{
			internal get { } //Length: 7
		}

		internal abstract bool HasExpired
		{
			internal get { } //Length: 0
		}

		internal int StartTime
		{
			internal get { } //Length: 191
		}

		internal Timer(int durationMilliseconds) { }

		internal abstract bool Cancel() { }

		public override void Dispose() { }

		internal int get_Expiration() { }

		internal abstract bool get_HasExpired() { }

		internal int get_StartTime() { }

	}

	private class TimerNode : Timer
	{
		private enum TimerState
		{
			Ready = 0,
			Fired = 1,
			Cancelled = 2,
			Sentinel = 3,
		}

		private TimerState m_TimerState; //Field offset: 0x18
		private Callback m_Callback; //Field offset: 0x20
		private object m_Context; //Field offset: 0x28
		private object m_QueueLock; //Field offset: 0x30
		private TimerNode next; //Field offset: 0x38
		private TimerNode prev; //Field offset: 0x40

		internal virtual bool HasExpired
		{
			internal get { } //Length: 8
		}

		internal TimerNode Next
		{
			internal get { } //Length: 5
			internal set { } //Length: 13
		}

		internal TimerNode Prev
		{
			internal get { } //Length: 5
			internal set { } //Length: 13
		}

		internal TimerNode(Callback callback, object context, int durationMilliseconds, object queueLock) { }

		internal TimerNode() { }

		internal virtual bool Cancel() { }

		internal bool Fire() { }

		internal virtual bool get_HasExpired() { }

		internal TimerNode get_Next() { }

		internal TimerNode get_Prev() { }

		internal void set_Next(TimerNode value) { }

		internal void set_Prev(TimerNode value) { }

	}

	private class TimerQueue : Queue
	{
		private IntPtr m_ThisHandle; //Field offset: 0x18
		private readonly TimerNode m_Timers; //Field offset: 0x20

		internal TimerQueue(int durationMilliseconds) { }

		internal virtual Timer CreateTimer(Callback callback, object context) { }

		internal bool Fire(out int nextExpiration) { }

	}

	private static LinkedList<WeakReference> s_Queues; //Field offset: 0x0
	private static LinkedList<WeakReference> s_NewQueues; //Field offset: 0x8
	private static int s_ThreadState; //Field offset: 0x10
	private static AutoResetEvent s_ThreadReadyEvent; //Field offset: 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; //Field offset: 0x20
	private static WaitHandle[] s_ThreadEvents; //Field offset: 0x28
	private static int s_CacheScanIteration; //Field offset: 0x30
	private static Hashtable s_QueuesCache; //Field offset: 0x38

	private static TimerThread() { }

	internal static Queue CreateQueue(int durationMilliseconds) { }

	internal static Queue GetOrCreateQueue(int durationMilliseconds) { }

	private static bool IsTickBetween(int start, int end, int comparand) { }

	private static void OnDomainUnload(object sender, EventArgs e) { }

	private static void Prod() { }

	private static void StopTimerThread() { }

	private static void ThreadProc() { }

}

