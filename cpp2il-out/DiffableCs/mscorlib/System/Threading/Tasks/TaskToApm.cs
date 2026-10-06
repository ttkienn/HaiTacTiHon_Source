namespace System.Threading.Tasks;

internal static class TaskToApm
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public AsyncCallback callback; //Field offset: 0x10
		public IAsyncResult asyncResult; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal void <InvokeCallbackWhenTaskCompletes>b__0() { }

	}

	private sealed class TaskWrapperAsyncResult : IAsyncResult
	{
		internal readonly Task Task; //Field offset: 0x10
		private readonly object _state; //Field offset: 0x18
		private readonly bool _completedSynchronously; //Field offset: 0x20

		private override object System.IAsyncResult.AsyncState
		{
			private get { } //Length: 5
		}

		private override WaitHandle System.IAsyncResult.AsyncWaitHandle
		{
			private get { } //Length: 188
		}

		private override bool System.IAsyncResult.CompletedSynchronously
		{
			private get { } //Length: 5
		}

		private override bool System.IAsyncResult.IsCompleted
		{
			private get { } //Length: 92
		}

		internal TaskWrapperAsyncResult(Task task, object state, bool completedSynchronously) { }

		private override object System.IAsyncResult.get_AsyncState() { }

		private override WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

		private override bool System.IAsyncResult.get_CompletedSynchronously() { }

		private override bool System.IAsyncResult.get_IsCompleted() { }

	}


	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	public static void End(IAsyncResult asyncResult) { }

	public static TResult End(IAsyncResult asyncResult) { }

	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }

}

