namespace System.Runtime.Versioning;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False, Inherited = False)]
public sealed class TargetFrameworkAttribute : Attribute
{
	private string _frameworkName; //Field offset: 0x10
	private string _frameworkDisplayName; //Field offset: 0x18

	public string FrameworkDisplayName
	{
		 set { } //Length: 13
	}

	public TargetFrameworkAttribute(string frameworkName) { }

	public void set_FrameworkDisplayName(string value) { }

}

