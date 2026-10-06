namespace UnityEngine.Bindings;

[AttributeUsage(192)]
[VisibleToOtherModules]
internal class NativeMethodAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <IsThreadSafe>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <IsFreeFunction>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <ThrowsException>k__BackingField; //Field offset: 0x1A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <HasExplicitThis>k__BackingField; //Field offset: 0x1B

	public override bool HasExplicitThis
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool IsFreeFunction
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool IsThreadSafe
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override string Name
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public override bool ThrowsException
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public NativeMethodAttribute() { }

	public NativeMethodAttribute(string name) { }

	public NativeMethodAttribute(string name, bool isFreeFunction) { }

	public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe) { }

	[CompilerGenerated]
	public override void set_HasExplicitThis(bool value) { }

	[CompilerGenerated]
	public override void set_IsFreeFunction(bool value) { }

	[CompilerGenerated]
	public override void set_IsThreadSafe(bool value) { }

	[CompilerGenerated]
	public override void set_Name(string value) { }

	[CompilerGenerated]
	public override void set_ThrowsException(bool value) { }

}

