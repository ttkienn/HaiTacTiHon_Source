namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
public sealed class AssemblyFileVersionAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; //Field offset: 0x10

	public AssemblyFileVersionAttribute(string version) { }

}

