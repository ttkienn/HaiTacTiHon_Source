namespace System.Runtime.CompilerServices;

public struct AsyncValueTaskMethodBuilder
{
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; //Field offset: 0x0
	private TResult _result; //Field offset: 0x0
	private bool _haveResult; //Field offset: 0x0
	private bool _useBuilder; //Field offset: 0x0

	public ValueTask<TResult> Task
	{
		 get { } //Length: 283
	}

	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	public static AsyncValueTaskMethodBuilder<TResult> Create() { }

	public ValueTask<TResult> get_Task() { }

	public void SetException(Exception exception) { }

	public void SetResult(TResult result) { }

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	public void Start(ref TStateMachine stateMachine) { }

}

