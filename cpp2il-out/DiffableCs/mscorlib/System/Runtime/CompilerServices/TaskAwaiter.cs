namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Task task; //Field offset: 0x10
		public Action continuation; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <OutputWaitEtwEvents>b__0() { }

	}

	internal readonly Task m_task; //Field offset: 0x0

	public bool IsCompleted
	{
		 get { } //Length: 28
	}

	internal TaskAwaiter(Task task) { }

	public bool get_IsCompleted() { }

	[StackTraceHidden]
	public void GetResult() { }

	[StackTraceHidden]
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

	private static Action OutputWaitEtwEvents(Task task, Action continuation) { }

	[StackTraceHidden]
	private static void ThrowForNonSuccess(Task task) { }

	public override void UnsafeOnCompleted(Action continuation) { }

	[StackTraceHidden]
	internal static void ValidateEnd(Task task) { }

}

