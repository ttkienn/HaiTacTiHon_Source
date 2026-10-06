namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	public override bool Equals(AnimationClipPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

