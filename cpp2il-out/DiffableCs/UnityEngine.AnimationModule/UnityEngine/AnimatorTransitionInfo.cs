namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
public struct AnimatorTransitionInfo
{
	[NativeName("fullPathHash")]
	private int m_FullPath; //Field offset: 0x0
	[NativeName("userNameHash")]
	private int m_UserName; //Field offset: 0x4
	[NativeName("nameHash")]
	private int m_Name; //Field offset: 0x8
	[NativeName("hasFixedDuration")]
	private bool m_HasFixedDuration; //Field offset: 0xC
	[NativeName("duration")]
	private float m_Duration; //Field offset: 0x10
	[NativeName("normalizedTime")]
	private float m_NormalizedTime; //Field offset: 0x14
	[NativeName("anyState")]
	private bool m_AnyState; //Field offset: 0x18
	[NativeName("transitionType")]
	private int m_TransitionType; //Field offset: 0x1C

}

