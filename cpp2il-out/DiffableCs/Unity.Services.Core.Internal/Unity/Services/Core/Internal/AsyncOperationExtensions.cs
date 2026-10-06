namespace Unity.Services.Core.Internal;

[Extension]
internal static class AsyncOperationExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public TaskCompletionSource<Object> taskCompletionSource; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal void <AsTask>g__CompleteTask|0(IAsyncOperation operation) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public TaskCompletionSource<T> taskCompletionSource; //Field offset: 0x0

		public <>c__DisplayClass3_0`1() { }

		internal void <AsTask>g__CompleteTask|0(IAsyncOperation<T> operation) { }

	}


	[Extension]
	public static Task AsTask(IAsyncOperation self) { }

	[Extension]
	public static Task<T> AsTask(IAsyncOperation<T> self) { }

	[Extension]
	public static AsyncOperationAwaiter GetAwaiter(IAsyncOperation self) { }

	[Extension]
	public static AsyncOperationAwaiter<T> GetAwaiter(IAsyncOperation<T> self) { }

}

