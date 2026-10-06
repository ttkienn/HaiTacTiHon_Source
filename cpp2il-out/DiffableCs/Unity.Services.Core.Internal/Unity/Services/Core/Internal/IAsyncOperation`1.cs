namespace Unity.Services.Core.Internal;

internal interface IAsyncOperation : IEnumerator
{

	public event Action<IAsyncOperation`1<T>> Completed
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

	public T Result
	{
		 get { } //Length: 0
	}

	public AsyncOperationStatus Status
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_Completed(Action<IAsyncOperation`1<T>> value) { }

	public Exception get_Exception() { }

	public bool get_IsDone() { }

	public T get_Result() { }

	public AsyncOperationStatus get_Status() { }

	[CompilerGenerated]
	public void remove_Completed(Action<IAsyncOperation`1<T>> value) { }

}

