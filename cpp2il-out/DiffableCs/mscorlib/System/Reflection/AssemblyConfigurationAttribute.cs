namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
public sealed class AssemblyConfigurationAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Configuration>k__BackingField; //Field offset: 0x10

	public AssemblyConfigurationAttribute(string configuration) { }

}

