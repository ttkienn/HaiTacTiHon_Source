namespace Unity.Services.Core.Internal;

internal class AsyncOperation : IAsyncOperation, IEnumerator
{
	[CompilerGenerated]
	private bool <IsDone>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private AsyncOperationStatus <Status>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Exception <Exception>k__BackingField; //Field offset: 0x18
	protected Action<IAsyncOperation> m_CompletedCallback; //Field offset: 0x20

	public override event Action<IAsyncOperation> Completed
	{
		 add { } //Length: 220
		 remove { } //Length: 175
	}

	public override Exception Exception
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public override bool IsDone
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override AsyncOperationStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 3
	}

	public AsyncOperation() { }

	public override void add_Completed(Action<IAsyncOperation> value) { }

	public void Cancel() { }

	public void Fail(Exception reason) { }

	[CompilerGenerated]
	public override Exception get_Exception() { }

	[CompilerGenerated]
	public override bool get_IsDone() { }

	[CompilerGenerated]
	public override AsyncOperationStatus get_Status() { }

	public override void remove_Completed(Action<IAsyncOperation> value) { }

	[CompilerGenerated]
	protected void set_Exception(Exception value) { }

	[CompilerGenerated]
	protected void set_IsDone(bool value) { }

	[CompilerGenerated]
	protected void set_Status(AsyncOperationStatus value) { }

	public void SetInProgress() { }

	public void Succeed() { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

}

