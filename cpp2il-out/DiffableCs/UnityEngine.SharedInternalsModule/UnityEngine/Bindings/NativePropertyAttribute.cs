namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Property (128))]
[VisibleToOtherModules]
internal class NativePropertyAttribute : NativeMethodAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TargetType <TargetType>k__BackingField; //Field offset: 0x20

	public TargetType TargetType
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public NativePropertyAttribute() { }

	public NativePropertyAttribute(string name) { }

	public NativePropertyAttribute(string name, bool isFree, TargetType targetType) { }

	public NativePropertyAttribute(string name, bool isFree, TargetType targetType, bool isThreadSafe) { }

	[CompilerGenerated]
	public void set_TargetType(TargetType value) { }

}

