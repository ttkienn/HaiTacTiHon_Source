namespace System.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder`1))]
[IsReadOnly]
public struct ValueTask : IEquatable<ValueTask`1<TResult>>
{
	private sealed class ValueTaskSourceAsTask : Task<TResult>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c<TResult> <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal void <.cctor>b__4_0(object state) { }

		}

		private static readonly Action<Object> s_completionAction; //Field offset: 0x0
		private IValueTaskSource<TResult> _source; //Field offset: 0x0
		private readonly short _token; //Field offset: 0x0

		private static ValueTaskSourceAsTask() { }

		public ValueTaskSourceAsTask(IValueTaskSource<TResult> source, short token) { }

	}

	private static Task<TResult> s_canceledTask; //Field offset: 0x0
	internal readonly object _obj; //Field offset: 0x0
	internal readonly TResult _result; //Field offset: 0x0
	internal readonly short _token; //Field offset: 0x0
	internal readonly bool _continueOnCapturedContext; //Field offset: 0x0

	public bool IsCompleted
	{
		 get { } //Length: 252
	}

	public bool IsCompletedSuccessfully
	{
		 get { } //Length: 253
	}

	public TResult Result
	{
		 get { } //Length: 272
	}

	public ValueTask`1(TResult result) { }

	public ValueTask`1(Task<TResult> task) { }

	public ValueTask`1(IValueTaskSource<TResult> source, short token) { }

	private ValueTask`1(object obj, TResult result, short token, bool continueOnCapturedContext) { }

	public Task<TResult> AsTask() { }

	public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ValueTask<TResult> other) { }

	public bool get_IsCompleted() { }

	public bool get_IsCompletedSuccessfully() { }

	public TResult get_Result() { }

	public ValueTaskAwaiter<TResult> GetAwaiter() { }

	public virtual int GetHashCode() { }

	private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t) { }

	public virtual string ToString() { }

}

