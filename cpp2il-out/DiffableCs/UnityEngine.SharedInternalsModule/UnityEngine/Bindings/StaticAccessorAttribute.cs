namespace UnityEngine.Bindings;

[AttributeUsage(204)]
[VisibleToOtherModules]
internal class StaticAccessorAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private StaticAccessorType <Type>k__BackingField; //Field offset: 0x18

	public string Name
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public StaticAccessorType Type
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[VisibleToOtherModules]
	internal StaticAccessorAttribute(string name) { }

	public StaticAccessorAttribute(string name, StaticAccessorType type) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_Type(StaticAccessorType value) { }

}

