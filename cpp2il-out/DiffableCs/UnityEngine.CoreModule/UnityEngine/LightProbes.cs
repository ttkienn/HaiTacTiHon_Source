namespace UnityEngine;

[NativeHeader("Runtime/Export/Graphics/Graphics.bindings.h")]
public sealed class LightProbes : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action lightProbesUpdated; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action tetrahedralizationCompleted; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action needsRetetrahedralization; //Field offset: 0x10

	[RequiredByNativeCode]
	private static void Internal_CallLightProbesUpdatedFunction() { }

	[RequiredByNativeCode]
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }

	[RequiredByNativeCode]
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

}

