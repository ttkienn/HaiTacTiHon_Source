namespace UnityEngine;

[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
public sealed class ReflectionProbe : Behaviour
{
	internal enum ReflectionProbeEvent
	{
		ReflectionProbeAdded = 0,
		ReflectionProbeRemoved = 1,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged; //Field offset: 0x0
	private static Dictionary<Int32, Action`1<Texture>> registeredDefaultReflectionSetActions; //Field offset: 0x8
	private static List<Action`1<Texture>> registeredDefaultReflectionTextureActions; //Field offset: 0x10

	private static ReflectionProbe() { }

	[RequiredByNativeCode]
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCode]
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

}

