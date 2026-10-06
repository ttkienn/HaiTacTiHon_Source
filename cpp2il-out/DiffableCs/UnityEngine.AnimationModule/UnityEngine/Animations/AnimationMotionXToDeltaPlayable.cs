namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", StaticAccessorType::DoubleColon (2))]
internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable>
{
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationMotionXToDeltaPlayable() { }

	private AnimationMotionXToDeltaPlayable(PlayableHandle handle) { }

	public override bool Equals(AnimationMotionXToDeltaPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

