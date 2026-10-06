namespace UnityEngine;

[AttributeUsage(12, Inherited = False)]
[VisibleToOtherModules]
internal sealed class NativeClassAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <QualifiedNativeName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Declaration>k__BackingField; //Field offset: 0x18

	private string Declaration
	{
		[CompilerGenerated]
		private set { } //Length: 13
	}

	private string QualifiedNativeName
	{
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public NativeClassAttribute(string qualifiedCppName) { }

	public NativeClassAttribute(string qualifiedCppName, string declaration) { }

	[CompilerGenerated]
	private void set_Declaration(string value) { }

	[CompilerGenerated]
	private void set_QualifiedNativeName(string value) { }

}

