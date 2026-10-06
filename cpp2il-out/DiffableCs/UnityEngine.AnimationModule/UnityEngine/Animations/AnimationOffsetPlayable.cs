namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationOffsetPlayableBindings", StaticAccessorType::DoubleColon (2))]
internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable>
{
	private static readonly AnimationOffsetPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationOffsetPlayable() { }

	internal AnimationOffsetPlayable(PlayableHandle handle) { }

	public override bool Equals(AnimationOffsetPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

