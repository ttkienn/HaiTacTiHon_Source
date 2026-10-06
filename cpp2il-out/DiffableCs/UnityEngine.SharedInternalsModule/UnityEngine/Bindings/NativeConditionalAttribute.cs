namespace UnityEngine.Bindings;

[AttributeUsage(204)]
[VisibleToOtherModules]
internal class NativeConditionalAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Condition>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <Enabled>k__BackingField; //Field offset: 0x18

	public string Condition
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public bool Enabled
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public NativeConditionalAttribute(string condition) { }

	[CompilerGenerated]
	public void set_Condition(string value) { }

	[CompilerGenerated]
	public void set_Enabled(bool value) { }

}

