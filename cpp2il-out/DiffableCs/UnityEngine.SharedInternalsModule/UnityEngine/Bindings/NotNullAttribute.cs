namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Parameter (2048))]
[VisibleToOtherModules]
internal class NotNullAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Exception>k__BackingField; //Field offset: 0x10

	public string Exception
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public NotNullAttribute(string exception = "ArgumentNullException") { }

	[CompilerGenerated]
	public void set_Exception(string value) { }

}

