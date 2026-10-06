namespace Unity.Services.Core.Internal;

internal interface IAsyncOperationAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{

	public bool IsCompleted
	{
		 get { } //Length: 0
	}

	public bool get_IsCompleted() { }

	public T GetResult() { }

}

