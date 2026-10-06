namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False, AllowMultiple = False)]
public sealed class AsyncStateMachineAttribute : StateMachineAttribute
{

	public AsyncStateMachineAttribute(Type stateMachineType) { }

}

