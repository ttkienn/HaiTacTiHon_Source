namespace System.Runtime.CompilerServices;

public interface IAsyncStateMachine
{

	public void MoveNext() { }

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

