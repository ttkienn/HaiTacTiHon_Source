namespace UnityEngine;

[RequiredByNativeCode]
public sealed class AnimationEvent
{
	internal float m_Time; //Field offset: 0x10
	internal string m_FunctionName; //Field offset: 0x18
	internal string m_StringParameter; //Field offset: 0x20
	internal object m_ObjectReferenceParameter; //Field offset: 0x28
	internal float m_FloatParameter; //Field offset: 0x30
	internal int m_IntParameter; //Field offset: 0x34
	internal int m_MessageOptions; //Field offset: 0x38
	internal AnimationEventSource m_Source; //Field offset: 0x3C
	internal AnimationState m_StateSender; //Field offset: 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; //Field offset: 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; //Field offset: 0x6C

	public AnimationEvent() { }

}

