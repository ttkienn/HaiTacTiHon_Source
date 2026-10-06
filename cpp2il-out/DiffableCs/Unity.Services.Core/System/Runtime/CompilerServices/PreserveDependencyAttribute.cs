namespace System.Runtime.CompilerServices;

[AttributeUsage(352, AllowMultiple = True)]
internal sealed class PreserveDependencyAttribute : Attribute
{
	[CompilerGenerated]
	private string <Condition>k__BackingField; //Field offset: 0x10

	public string Condition
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public PreserveDependencyAttribute(string memberSignature) { }

	public PreserveDependencyAttribute(string memberSignature, string typeName) { }

	public PreserveDependencyAttribute(string memberSignature, string typeName, string assembly) { }

	[CompilerGenerated]
	public string get_Condition() { }

	[CompilerGenerated]
	public void set_Condition(string value) { }

}

