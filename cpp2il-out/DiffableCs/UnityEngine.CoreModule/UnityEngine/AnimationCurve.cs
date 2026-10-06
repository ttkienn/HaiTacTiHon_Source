namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
[RequiredByNativeCode]
public class AnimationCurve : IEquatable<AnimationCurve>
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public AnimationCurve(Keyframe[] keys) { }

	[RequiredByNativeCode]
	public AnimationCurve() { }

	public virtual bool Equals(object o) { }

	public override bool Equals(AnimationCurve other) { }

	protected virtual void Finalize() { }

	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = True, IsThreadSafe = True)]
	public virtual int GetHashCode() { }

	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = True, IsThreadSafe = True)]
	private bool Internal_Equals(IntPtr other) { }

}

