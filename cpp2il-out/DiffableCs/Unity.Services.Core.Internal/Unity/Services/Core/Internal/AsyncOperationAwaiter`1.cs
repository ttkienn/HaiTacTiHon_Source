namespace Unity.Services.Core.Internal;

internal struct AsyncOperationAwaiter : IAsyncOperationAwaiter<T>, ICriticalNotifyCompletion, INotifyCompletion
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Action continuation; //Field offset: 0x0

		public <>c__DisplayClass2_0() { }

		internal void <OnCompleted>b__0(IAsyncOperation<T> obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Action continuation; //Field offset: 0x0

		public <>c__DisplayClass3_0() { }

		internal void <UnsafeOnCompleted>b__0(IAsyncOperation<T> obj) { }

	}

	private IAsyncOperation<T> m_Operation; //Field offset: 0x0

	public override bool IsCompleted
	{
		 get { } //Length: 193
	}

	public AsyncOperationAwaiter`1(IAsyncOperation<T> asyncOperation) { }

	public override bool get_IsCompleted() { }

	public override T GetResult() { }

	public override void OnCompleted(Action continuation) { }

	public override void UnsafeOnCompleted(Action continuation) { }

}

