namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
public sealed class AssemblyInformationalVersionAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <InformationalVersion>k__BackingField; //Field offset: 0x10

	public AssemblyInformationalVersionAttribute(string informationalVersion) { }

}

