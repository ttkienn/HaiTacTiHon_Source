namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly ValueTask<TResult> _value; //Field offset: 0x0

	public bool IsCompleted
	{
		 get { } //Length: 54
	}

	internal ValueTaskAwaiter`1(ValueTask<TResult> value) { }

	public bool get_IsCompleted() { }

	[StackTraceHidden]
	public TResult GetResult() { }

	public override void UnsafeOnCompleted(Action continuation) { }

}

