namespace Unity.Services.Core.Internal;

internal class AsyncOperation : IAsyncOperation<T>, IEnumerator
{
	[CompilerGenerated]
	private bool <IsDone>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private AsyncOperationStatus <Status>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Exception <Exception>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private T <Result>k__BackingField; //Field offset: 0x0
	protected Action<IAsyncOperation`1<T>> m_CompletedCallback; //Field offset: 0x0

	public override event Action<IAsyncOperation`1<T>> Completed
	{
		 add { } //Length: 354
		 remove { } //Length: 256
	}

	public override Exception Exception
	{
		[CompilerGenerated]
		 get { } //Length: 42
		[CompilerGenerated]
		 set { } //Length: 101
	}

	public override bool IsDone
	{
		[CompilerGenerated]
		 get { } //Length: 38
		[CompilerGenerated]
		 set { } //Length: 99
	}

	public override T Result
	{
		[CompilerGenerated]
		 get { } //Length: 175
		[CompilerGenerated]
		 set { } //Length: 200
	}

	public override AsyncOperationStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		 set { } //Length: 99
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 3
	}

	public AsyncOperation`1() { }

	public override void add_Completed(Action<IAsyncOperation`1<T>> value) { }

	public void Cancel() { }

	public void Fail(Exception reason) { }

	[CompilerGenerated]
	public override Exception get_Exception() { }

	[CompilerGenerated]
	public override bool get_IsDone() { }

	[CompilerGenerated]
	public override T get_Result() { }

	[CompilerGenerated]
	public override AsyncOperationStatus get_Status() { }

	public override void remove_Completed(Action<IAsyncOperation`1<T>> value) { }

	[CompilerGenerated]
	protected void set_Exception(Exception value) { }

	[CompilerGenerated]
	protected void set_IsDone(bool value) { }

	[CompilerGenerated]
	protected void set_Result(T value) { }

	[CompilerGenerated]
	protected void set_Status(AsyncOperationStatus value) { }

	public void SetInProgress() { }

	public void Succeed(T result) { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

}

