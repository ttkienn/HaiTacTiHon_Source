namespace UnityEngine.Scripting;

[AttributeUsage(1532, Inherited = False)]
[VisibleToOtherModules]
internal class RequiredByNativeCodeAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <Optional>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <GenerateProxy>k__BackingField; //Field offset: 0x19

	public bool GenerateProxy
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Name
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public bool Optional
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RequiredByNativeCodeAttribute() { }

	public RequiredByNativeCodeAttribute(string name) { }

	[CompilerGenerated]
	public void set_GenerateProxy(bool value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_Optional(bool value) { }

}

