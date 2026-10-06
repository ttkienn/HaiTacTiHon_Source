namespace UnityEngine;

[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
[RequiredByNativeCode(Optional = False, GenerateProxy = True)]
public struct ContactPoint2D
{
	[NativeName("point")]
	private Vector2 m_Point; //Field offset: 0x0
	[NativeName("normal")]
	private Vector2 m_Normal; //Field offset: 0x8
	[NativeName("relativeVelocity")]
	private Vector2 m_RelativeVelocity; //Field offset: 0x10
	[NativeName("separation")]
	private float m_Separation; //Field offset: 0x18
	[NativeName("normalImpulse")]
	private float m_NormalImpulse; //Field offset: 0x1C
	[NativeName("tangentImpulse")]
	private float m_TangentImpulse; //Field offset: 0x20
	[NativeName("collider")]
	private int m_Collider; //Field offset: 0x24
	[NativeName("otherCollider")]
	private int m_OtherCollider; //Field offset: 0x28
	[NativeName("rigidbody")]
	private int m_Rigidbody; //Field offset: 0x2C
	[NativeName("otherRigidbody")]
	private int m_OtherRigidbody; //Field offset: 0x30
	[NativeName("enabled")]
	private int m_Enabled; //Field offset: 0x34

}

