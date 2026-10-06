namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable>
{
	private static readonly AnimatorControllerPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimatorControllerPlayable() { }

	internal AnimatorControllerPlayable(PlayableHandle handle) { }

	public override bool Equals(AnimatorControllerPlayable other) { }

	public override PlayableHandle GetHandle() { }

	public void SetHandle(PlayableHandle handle) { }

}

