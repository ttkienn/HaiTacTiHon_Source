namespace UnityEngine;

public struct ModifiableContactPair
{
	private IntPtr actor; //Field offset: 0x0
	private IntPtr otherActor; //Field offset: 0x8
	private IntPtr shape; //Field offset: 0x10
	private IntPtr otherShape; //Field offset: 0x18
	public Quaternion rotation; //Field offset: 0x20
	public Vector3 position; //Field offset: 0x30
	public Quaternion otherRotation; //Field offset: 0x3C
	public Vector3 otherPosition; //Field offset: 0x4C
	private int numContacts; //Field offset: 0x58
	private IntPtr contacts; //Field offset: 0x60

}

