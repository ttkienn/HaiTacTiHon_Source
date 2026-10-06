namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AudioClipPlayable : IEquatable<AudioClipPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	public override bool Equals(AudioClipPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

