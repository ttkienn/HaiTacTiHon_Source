namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
public sealed class DependencyAttribute : Attribute
{
	private string dependentAssembly; //Field offset: 0x10
	private LoadHint loadHint; //Field offset: 0x18

	public DependencyAttribute(string dependentAssemblyArgument, LoadHint loadHintArgument) { }

}

