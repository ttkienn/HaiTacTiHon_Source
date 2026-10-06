namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable
{

	public BuiltinRuntimeReflectionSystem() { }

	[StaticAccessor("GetReflectionProbes()", Type = StaticAccessorType::Dot (0))]
	private static bool BuiltinUpdate() { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	[RequiredByNativeCode]
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	public override bool TickRealtimeProbes() { }

}

