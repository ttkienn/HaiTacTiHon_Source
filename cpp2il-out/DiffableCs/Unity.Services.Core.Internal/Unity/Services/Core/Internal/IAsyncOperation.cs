namespace Unity.Services.Core.Internal;

internal interface IAsyncOperation : IEnumerator
{

	public event Action<IAsyncOperation> Completed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public Exception Exception
	{
		 get { } //Length: 0
	}

	public bool IsDone
	{
		 get { } //Length: 0
	}

	public AsyncOperationStatus Status
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_Completed(Action<IAsyncOperation> value) { }

	public Exception get_Exception() { }

	public bool get_IsDone() { }

	public AsyncOperationStatus get_Status() { }

	[CompilerGenerated]
	public void remove_Completed(Action<IAsyncOperation> value) { }

}

