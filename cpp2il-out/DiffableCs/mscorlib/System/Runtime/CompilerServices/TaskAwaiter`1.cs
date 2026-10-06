namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task<TResult> m_task; //Field offset: 0x0

	public bool IsCompleted
	{
		 get { } //Length: 28
	}

	internal TaskAwaiter`1(Task<TResult> task) { }

	public bool get_IsCompleted() { }

	[StackTraceHidden]
	public TResult GetResult() { }

	public override void UnsafeOnCompleted(Action continuation) { }

}

