namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable>
{
	private static readonly AnimationMixerPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationMixerPlayable() { }

	internal AnimationMixerPlayable(PlayableHandle handle) { }

	public override bool Equals(AnimationMixerPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

