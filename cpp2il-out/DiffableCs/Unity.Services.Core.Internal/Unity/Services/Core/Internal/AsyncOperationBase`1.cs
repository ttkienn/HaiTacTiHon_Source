namespace Unity.Services.Core.Internal;

internal abstract class AsyncOperationBase : CustomYieldInstruction, IAsyncOperation<T>, IEnumerator, INotifyCompletion
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Action continuation; //Field offset: 0x0

		public <>c__DisplayClass19_0() { }

		internal void <OnCompleted>b__0(IAsyncOperation<T> op) { }

	}

	private Action<IAsyncOperation`1<T>> m_CompletedCallback; //Field offset: 0x0

	public override event Action<IAsyncOperation`1<T>> Completed
	{
		 add { } //Length: 334
		 remove { } //Length: 233
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

	public abstract T Result
	{
		 get { } //Length: 0
	}

	public abstract AsyncOperationStatus Status
	{
		 get { } //Length: 0
	}

	protected AsyncOperationBase`1() { }

	public override void add_Completed(Action<IAsyncOperation`1<T>> value) { }

	protected void DidComplete() { }

	public abstract Exception get_Exception() { }

	public abstract bool get_IsCompleted() { }

	public override bool get_IsDone() { }

	public virtual bool get_keepWaiting() { }

	public abstract T get_Result() { }

	public abstract AsyncOperationStatus get_Status() { }

	public abstract AsyncOperationBase<T> GetAwaiter() { }

	public abstract T GetResult() { }

	public override void OnCompleted(Action continuation) { }

	public override void remove_Completed(Action<IAsyncOperation`1<T>> value) { }

}

