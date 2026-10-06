namespace Unity.Services.Core.Internal;

internal struct AsyncOperationAwaiter : IAsyncOperationAwaiter, ICriticalNotifyCompletion, INotifyCompletion
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Action continuation; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal void <OnCompleted>b__0(IAsyncOperation operation) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Action continuation; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal void <UnsafeOnCompleted>b__0(IAsyncOperation operation) { }

	}

	private IAsyncOperation m_Operation; //Field offset: 0x0

	public override bool IsCompleted
	{
		 get { } //Length: 69
	}

	public AsyncOperationAwaiter(IAsyncOperation asyncOperation) { }

	public override bool get_IsCompleted() { }

	public override void GetResult() { }

	public override void OnCompleted(Action continuation) { }

	public override void UnsafeOnCompleted(Action continuation) { }

}

