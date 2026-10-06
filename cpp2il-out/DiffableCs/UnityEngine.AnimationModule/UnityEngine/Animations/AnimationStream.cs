namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
[RequiredByNativeCode]
public struct AnimationStream
{
	private uint m_AnimatorBindingsVersion; //Field offset: 0x0
	private IntPtr constant; //Field offset: 0x8
	private IntPtr input; //Field offset: 0x10
	private IntPtr output; //Field offset: 0x18
	private IntPtr workspace; //Field offset: 0x20
	private IntPtr inputStreamAccessor; //Field offset: 0x28
	private IntPtr animationHandleBinder; //Field offset: 0x30

}

