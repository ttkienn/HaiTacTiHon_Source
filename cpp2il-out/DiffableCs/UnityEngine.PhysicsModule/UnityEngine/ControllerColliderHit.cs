namespace UnityEngine;

[RequiredByNativeCode]
public class ControllerColliderHit
{
	internal CharacterController m_Controller; //Field offset: 0x10
	internal Collider m_Collider; //Field offset: 0x18
	internal Vector3 m_Point; //Field offset: 0x20
	internal Vector3 m_Normal; //Field offset: 0x2C
	internal Vector3 m_MoveDirection; //Field offset: 0x38
	internal float m_MoveLength; //Field offset: 0x44
	internal int m_Push; //Field offset: 0x48

}

