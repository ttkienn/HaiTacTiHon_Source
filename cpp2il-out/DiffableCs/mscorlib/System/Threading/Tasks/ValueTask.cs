namespace System.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
[IsReadOnly]
public struct ValueTask : IEquatable<ValueTask>
{
	private sealed class ValueTaskSourceAsTask : Task<VoidTaskResult>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal void <.cctor>b__4_0(object state) { }

		}

		private static readonly Action<Object> s_completionAction; //Field offset: 0x0
		private IValueTaskSource _source; //Field offset: 0x58
		private readonly short _token; //Field offset: 0x60

		private static ValueTaskSourceAsTask() { }

		public ValueTaskSourceAsTask(IValueTaskSource source, short token) { }

	}

	private static readonly Task s_canceledTask; //Field offset: 0x0
	internal readonly object _obj; //Field offset: 0x0
	internal readonly short _token; //Field offset: 0x8
	internal readonly bool _continueOnCapturedContext; //Field offset: 0xA

	internal static Task CompletedTask
	{
		internal get { } //Length: 138
	}

	public bool IsCompleted
	{
		 get { } //Length: 237
	}

	private static ValueTask() { }

	public ValueTask(Task task) { }

	public ValueTask(IValueTaskSource source, short token) { }

	private ValueTask(object obj, short token, bool continueOnCapturedContext) { }

	public Task AsTask() { }

	public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ValueTask other) { }

	internal static Task get_CompletedTask() { }

	public bool get_IsCompleted() { }

	public ValueTaskAwaiter GetAwaiter() { }

	public virtual int GetHashCode() { }

	private Task GetTaskForValueTaskSource(IValueTaskSource t) { }

	[StackTraceHidden]
	internal void ThrowIfCompletedUnsuccessfully() { }

}

