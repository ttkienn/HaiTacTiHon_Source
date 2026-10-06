namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct ConfiguredValueTaskAwaitable
{
	[IsReadOnly]
	internal struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly ValueTask _value; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 73
		}

		internal ConfiguredValueTaskAwaiter(ValueTask value) { }

		public bool get_IsCompleted() { }

		[StackTraceHidden]
		public void GetResult() { }

		public override void UnsafeOnCompleted(Action continuation) { }

	}

	private readonly ValueTask _value; //Field offset: 0x0

	internal ConfiguredValueTaskAwaitable(ValueTask value) { }

	public ConfiguredValueTaskAwaiter GetAwaiter() { }

}

