namespace System.Runtime.CompilerServices;

public struct AsyncTaskMethodBuilder
{
	internal static readonly Task<TResult> s_defaultResultTask; //Field offset: 0x0
	private AsyncMethodBuilderCore m_coreState; //Field offset: 0x0
	private Task<TResult> m_task; //Field offset: 0x0

	public Task<TResult> Task
	{
		 get { } //Length: 169
	}

	private static AsyncTaskMethodBuilder`1() { }

	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	public static AsyncTaskMethodBuilder<TResult> Create() { }

	public Task<TResult> get_Task() { }

	internal static Task<TResult> GetTaskForResult(TResult result) { }

	public void SetException(Exception exception) { }

	public void SetResult(TResult result) { }

	internal void SetResult(Task<TResult> completedTask) { }

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[DebuggerStepThrough]
	public void Start(ref TStateMachine stateMachine) { }

}

