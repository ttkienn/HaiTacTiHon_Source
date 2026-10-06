namespace UnityEngine;

[IsReadOnly]
[UsedByNativeCode]
public struct ContactPair
{
	internal readonly int m_ColliderID; //Field offset: 0x0
	internal readonly int m_OtherColliderID; //Field offset: 0x4
	internal readonly IntPtr m_StartPtr; //Field offset: 0x8
	internal readonly uint m_NbPoints; //Field offset: 0x10
	internal readonly CollisionPairFlags m_Flags; //Field offset: 0x14
	internal readonly CollisionPairEventFlags m_Events; //Field offset: 0x16
	internal readonly Vector3 m_ImpulseSum; //Field offset: 0x18

	public Collider Collider
	{
		 get { } //Length: 114
	}

	internal bool HasRemovedCollider
	{
		internal get { } //Length: 20
	}

	public bool IsCollisionEnter
	{
		 get { } //Length: 8
	}

	public bool IsCollisionExit
	{
		 get { } //Length: 8
	}

	public bool IsCollisionStay
	{
		 get { } //Length: 8
	}

	public Collider OtherCollider
	{
		 get { } //Length: 116
	}

	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	private static int ExtractContactsArray_Injected(ref ContactPair _unity_self, ContactPoint[] managedContainer, bool flipped) { }

	public Collider get_Collider() { }

	internal bool get_HasRemovedCollider() { }

	public bool get_IsCollisionEnter() { }

	public bool get_IsCollisionExit() { }

	public bool get_IsCollisionStay() { }

	public Collider get_OtherCollider() { }

}

