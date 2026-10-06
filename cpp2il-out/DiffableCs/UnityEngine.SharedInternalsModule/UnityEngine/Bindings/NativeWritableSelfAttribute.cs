namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Method (64))]
[VisibleToOtherModules]
internal sealed class NativeWritableSelfAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <WritableSelf>k__BackingField; //Field offset: 0x10

	public override bool WritableSelf
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public NativeWritableSelfAttribute() { }

	[CompilerGenerated]
	public override void set_WritableSelf(bool value) { }

}

