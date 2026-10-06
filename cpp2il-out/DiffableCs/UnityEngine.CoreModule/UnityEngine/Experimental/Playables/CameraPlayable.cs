namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
[NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("CameraPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct CameraPlayable : IEquatable<CameraPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	public override bool Equals(CameraPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

