namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable>
{
	private static readonly AnimationScriptPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationScriptPlayable() { }

	internal AnimationScriptPlayable(PlayableHandle handle) { }

	public override bool Equals(AnimationScriptPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

