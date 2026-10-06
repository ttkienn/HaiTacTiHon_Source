namespace System.Net;

internal class WebCompletionSource
{
	[CompilerGenerated]
	private struct <WaitForCompletion>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public WebCompletionSource<T> <>4__this; //Field offset: 0x0
		private ConfiguredTaskAwaiter<Result<T>> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public class Result
	{
		[CompilerGenerated]
		private readonly Status<T> <Status>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly ExceptionDispatchInfo <Error>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly T <Argument>k__BackingField; //Field offset: 0x0

		public T Argument
		{
			[CompilerGenerated]
			 get { } //Length: 11
		}

		public ExceptionDispatchInfo Error
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public Status<T> Status
		{
			[CompilerGenerated]
			 get { } //Length: 191
		}

		public bool Success
		{
			 get { } //Length: 8
		}

		public Result(T argument) { }

		public Result(Status<T> state, ExceptionDispatchInfo error) { }

		[CompilerGenerated]
		public T get_Argument() { }

		[CompilerGenerated]
		public ExceptionDispatchInfo get_Error() { }

		[CompilerGenerated]
		public Status<T> get_Status() { }

		public bool get_Success() { }

	}

	public enum Status
	{
		Running = 0,
		Completed = 1,
		Canceled = 2,
		Faulted = 3,
	}

	private TaskCompletionSource<Result<T>> completion; //Field offset: 0x0
	private Result<T> currentResult; //Field offset: 0x0

	internal Result<T> CurrentResult
	{
		internal get { } //Length: 5
	}

	internal Task Task
	{
		internal get { } //Length: 27
	}

	public WebCompletionSource`1(bool runAsync = true) { }

	internal Result<T> get_CurrentResult() { }

	internal Task get_Task() { }

	public void ThrowOnError() { }

	public bool TrySetCanceled() { }

	public bool TrySetCanceled(OperationCanceledException error) { }

	public bool TrySetCompleted(T argument) { }

	public bool TrySetCompleted() { }

	public bool TrySetException(Exception error) { }

	[AsyncStateMachine(typeof(<WaitForCompletion>d__15))]
	public Task<T> WaitForCompletion() { }

}

