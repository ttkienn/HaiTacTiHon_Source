namespace Unity.Services.Core.Internal;

internal abstract class AsyncOperationBase : CustomYieldInstruction, IAsyncOperation, IEnumerator, INotifyCompletion
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public Action continuation; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal void <OnCompleted>b__0(IAsyncOperation op) { }

	}

	private Action<IAsyncOperation> m_CompletedCallback; //Field offset: 0x10

	public override event Action<IAsyncOperation> Completed
	{
		 add { } //Length: 240
		 remove { } //Length: 175
	}

	public abstract Exception Exception
	{
		 get { } //Length: 0
	}

	public abstract bool IsCompleted
	{
		 get { } //Length: 0
	}

	public override bool IsDone
	{
		 get { } //Length: 20
	}

	public virtual bool keepWaiting
	{
		 get { } //Length: 33
	}

	public abstract AsyncOperationStatus Status
	{
		 get { } //Length: 0
	}

	protected AsyncOperationBase() { }

	public override void add_Completed(Action<IAsyncOperation> value) { }

	protected void DidComplete() { }

	public abstract Exception get_Exception() { }

	public abstract bool get_IsCompleted() { }

	public override bool get_IsDone() { }

	public virtual bool get_keepWaiting() { }

	public abstract AsyncOperationStatus get_Status() { }

	public abstract AsyncOperationBase GetAwaiter() { }

	public abstract void GetResult() { }

	public override void OnCompleted(Action continuation) { }

	public override void remove_Completed(Action<IAsyncOperation> value) { }

}

