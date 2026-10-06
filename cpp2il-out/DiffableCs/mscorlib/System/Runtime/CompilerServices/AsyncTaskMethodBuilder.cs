namespace System.Runtime.CompilerServices;

public struct AsyncTaskMethodBuilder
{
	private static readonly Task<VoidTaskResult> s_cachedCompleted; //Field offset: 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; //Field offset: 0x0

	public Task Task
	{
		 get { } //Length: 90
	}

	private static AsyncTaskMethodBuilder() { }

	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	public static AsyncTaskMethodBuilder Create() { }

	public Task get_Task() { }

	public void SetException(Exception exception) { }

	public void SetResult() { }

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[DebuggerStepThrough]
	public void Start(ref TStateMachine stateMachine) { }

}

