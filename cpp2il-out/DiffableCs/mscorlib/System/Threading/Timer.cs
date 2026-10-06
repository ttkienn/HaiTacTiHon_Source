namespace System.Threading;

[ComVisible(True)]
public sealed class Timer : MarshalByRefObject, IDisposable
{
	private sealed class Scheduler
	{
		private static readonly Scheduler instance; //Field offset: 0x0
		private bool needReSort; //Field offset: 0x10
		private List<Timer> list; //Field offset: 0x18
		private long current_next_run; //Field offset: 0x20
		private ManualResetEvent changed; //Field offset: 0x28

		public static Scheduler Instance
		{
			 get { } //Length: 78
		}

		private static Scheduler() { }

		private Scheduler() { }

		private void Add(Timer timer) { }

		public void Change(Timer timer, long new_next_run) { }

		private void FireTimer(Timer timer) { }

		public static Scheduler get_Instance() { }

		private void InitScheduler() { }

		private void InternalRemove(Timer timer) { }

		public void Remove(Timer timer) { }

		private int RunSchedulerLoop() { }

		private void SchedulerThread() { }

		private static void TimerCB(object o) { }

		private void WakeupScheduler() { }

	}

	private struct TimerComparer : IComparer, IComparer<Timer>
	{

		public override int Compare(Timer tx, Timer ty) { }

		private override int System.Collections.IComparer.Compare(object x, object y) { }

	}

	private const long MaxValue = 4294967294; //Field offset: 0x0
	private TimerCallback callback; //Field offset: 0x18
	private object state; //Field offset: 0x20
	private long due_time_ms; //Field offset: 0x28
	private long period_ms; //Field offset: 0x30
	private long next_run; //Field offset: 0x38
	private bool disposed; //Field offset: 0x40
	private bool is_dead; //Field offset: 0x41
	private bool is_added; //Field offset: 0x42

	private static Scheduler scheduler
	{
		private get { } //Length: 137
	}

	public Timer(TimerCallback callback, object state, int dueTime, int period) { }

	public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	public bool Change(int dueTime, int period) { }

	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	private bool Change(long dueTime, long period, bool first) { }

	public override void Dispose() { }

	private static Scheduler get_scheduler() { }

	private static long GetTimeMonotonic() { }

	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	internal void KeepRootedWhileScheduled() { }

}

