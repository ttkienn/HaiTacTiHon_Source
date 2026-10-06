namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1))]
public sealed class DefaultDependencyAttribute : Attribute
{
	private LoadHint loadHint; //Field offset: 0x10

	public DefaultDependencyAttribute(LoadHint loadHintArgument) { }

}

