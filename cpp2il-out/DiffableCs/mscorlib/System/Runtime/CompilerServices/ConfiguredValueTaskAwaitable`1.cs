namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct ConfiguredValueTaskAwaitable
{
	[IsReadOnly]
	internal struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly ValueTask<TResult> _value; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 54
		}

		internal ConfiguredValueTaskAwaiter(ValueTask<TResult> value) { }

		public bool get_IsCompleted() { }

		[StackTraceHidden]
		public TResult GetResult() { }

		public override void UnsafeOnCompleted(Action continuation) { }

	}

	private readonly ValueTask<TResult> _value; //Field offset: 0x0

	internal ConfiguredValueTaskAwaitable`1(ValueTask<TResult> value) { }

	public ConfiguredValueTaskAwaiter<TResult> GetAwaiter() { }

}

