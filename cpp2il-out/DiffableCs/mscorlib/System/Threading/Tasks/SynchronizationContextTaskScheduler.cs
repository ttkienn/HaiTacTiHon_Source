namespace System.Threading.Tasks;

internal sealed class SynchronizationContextTaskScheduler : TaskScheduler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__8_0(object s) { }

	}

	private static readonly SendOrPostCallback s_postCallback; //Field offset: 0x0
	private SynchronizationContext m_synchronizationContext; //Field offset: 0x18

	private static SynchronizationContextTaskScheduler() { }

	internal SynchronizationContextTaskScheduler() { }

	protected private virtual void QueueTask(Task task) { }

	protected virtual bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

}

