namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__9_0(object state) { }

	}

	internal static readonly Action<Object> s_invokeActionDelegate; //Field offset: 0x0
	private readonly ValueTask _value; //Field offset: 0x0

	public bool IsCompleted
	{
		 get { } //Length: 158
	}

	private static ValueTaskAwaiter() { }

	internal ValueTaskAwaiter(ValueTask value) { }

	public bool get_IsCompleted() { }

	[StackTraceHidden]
	public void GetResult() { }

	public override void UnsafeOnCompleted(Action continuation) { }

}

