namespace System.Threading.Tasks;

internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__7_0(object state) { }

	}

	private static readonly SendOrPostCallback s_postCallback; //Field offset: 0x0
	private static ContextCallback s_postActionCallback; //Field offset: 0x8
	private readonly SynchronizationContext m_syncContext; //Field offset: 0x20

	private static SynchronizationContextAwaitTaskContinuation() { }

	internal SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, Action action, bool flowExecutionContext) { }

	private static ContextCallback GetPostActionCallback() { }

	private static void PostAction(object state) { }

	internal virtual void Run(Task ignored, bool canInlineContinuationTask) { }

}

