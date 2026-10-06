namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False, AllowMultiple = False)]
public sealed class IteratorStateMachineAttribute : StateMachineAttribute
{

	public IteratorStateMachineAttribute(Type stateMachineType) { }

}

