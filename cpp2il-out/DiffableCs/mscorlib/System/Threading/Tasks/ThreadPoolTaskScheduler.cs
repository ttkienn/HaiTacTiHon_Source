namespace System.Threading.Tasks;

internal sealed class ThreadPoolTaskScheduler : TaskScheduler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__10_0(object s) { }

	}

	private static readonly ParameterizedThreadStart s_longRunningThreadWork; //Field offset: 0x0

	internal virtual bool RequiresAtomicStartTransition
	{
		internal get { } //Length: 3
	}

	private static ThreadPoolTaskScheduler() { }

	internal ThreadPoolTaskScheduler() { }

	internal virtual bool get_RequiresAtomicStartTransition() { }

	internal virtual void NotifyWorkItemProgress() { }

	protected private virtual void QueueTask(Task task) { }

	protected private virtual bool TryDequeue(Task task) { }

	protected virtual bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

}

