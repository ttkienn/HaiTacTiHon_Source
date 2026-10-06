namespace System.Threading.Tasks;

internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Object> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Run>b__2_0(object state) { }

	}

	private readonly TaskScheduler m_scheduler; //Field offset: 0x20

	internal TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, Action action, bool flowExecutionContext) { }

	internal virtual void Run(Task ignored, bool canInlineContinuationTask) { }

}

