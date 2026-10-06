namespace System.Threading.Tasks;

[IsReadOnly]
internal struct ForceAsyncAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task _task; //Field offset: 0x0

	public bool IsCompleted
	{
		 get { } //Length: 3
	}

	internal ForceAsyncAwaiter(Task task) { }

	public bool get_IsCompleted() { }

	public ForceAsyncAwaiter GetAwaiter() { }

	public void GetResult() { }

	public override void UnsafeOnCompleted(Action action) { }

}

