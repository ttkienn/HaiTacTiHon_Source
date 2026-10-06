namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("TextureMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct TextureMixerPlayable : IEquatable<TextureMixerPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	public override bool Equals(TextureMixerPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

