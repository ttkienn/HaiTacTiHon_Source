namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False, AllowMultiple = False)]
public class StateMachineAttribute : Attribute
{
	[CompilerGenerated]
	private readonly Type <StateMachineType>k__BackingField; //Field offset: 0x10

	public Type StateMachineType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public StateMachineAttribute(Type stateMachineType) { }

	[CompilerGenerated]
	public Type get_StateMachineType() { }

}

