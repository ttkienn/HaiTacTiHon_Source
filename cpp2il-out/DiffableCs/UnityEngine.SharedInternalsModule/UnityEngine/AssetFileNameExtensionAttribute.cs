namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
[VisibleToOtherModules]
internal sealed class AssetFileNameExtensionAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <preferredExtension>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly IEnumerable<String> <otherExtensions>k__BackingField; //Field offset: 0x18

	public AssetFileNameExtensionAttribute(string preferredExtension, String[] otherExtensions) { }

}

