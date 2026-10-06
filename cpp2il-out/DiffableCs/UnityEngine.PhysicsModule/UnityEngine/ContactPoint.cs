namespace UnityEngine;

[NativeHeader("Modules/Physics/MessageParameters.h")]
[UsedByNativeCode]
public struct ContactPoint
{
	internal Vector3 m_Point; //Field offset: 0x0
	internal Vector3 m_Normal; //Field offset: 0xC
	internal Vector3 m_Impulse; //Field offset: 0x18
	internal int m_ThisColliderInstanceID; //Field offset: 0x24
	internal int m_OtherColliderInstanceID; //Field offset: 0x28
	internal float m_Separation; //Field offset: 0x2C

}

