namespace System.Resources;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False)]
public sealed class NeutralResourcesLanguageAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <CultureName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly UltimateResourceFallbackLocation <Location>k__BackingField; //Field offset: 0x18

	public string CultureName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public UltimateResourceFallbackLocation Location
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public NeutralResourcesLanguageAttribute(string cultureName) { }

	[CompilerGenerated]
	public string get_CultureName() { }

	[CompilerGenerated]
	public UltimateResourceFallbackLocation get_Location() { }

}

