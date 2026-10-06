namespace System.Runtime.CompilerServices;

public struct AsyncVoidMethodBuilder
{
	private SynchronizationContext m_synchronizationContext; //Field offset: 0x0
	private AsyncMethodBuilderCore m_coreState; //Field offset: 0x8
	private Task m_task; //Field offset: 0x18

	internal Task Task
	{
		internal get { } //Length: 105
	}

	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	public static AsyncVoidMethodBuilder Create() { }

	internal Task get_Task() { }

	private void NotifySynchronizationContextOfCompletion() { }

	public void SetException(Exception exception) { }

	public void SetResult() { }

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[DebuggerStepThrough]
	public void Start(ref TStateMachine stateMachine) { }

}

