namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Field (256))]
[VisibleToOtherModules]
internal class IgnoreAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <DoesNotContributeToSize>k__BackingField; //Field offset: 0x10

	public bool DoesNotContributeToSize
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public IgnoreAttribute() { }

	[CompilerGenerated]
	public void set_DoesNotContributeToSize(bool value) { }

}

