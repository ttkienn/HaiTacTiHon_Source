namespace UnityEngine;

public struct PenData
{
	public Vector2 position; //Field offset: 0x0
	public Vector2 tilt; //Field offset: 0x8
	public PenStatus penStatus; //Field offset: 0x10
	public float twist; //Field offset: 0x14
	public float pressure; //Field offset: 0x18
	public PenEventType contactType; //Field offset: 0x1C
	public Vector2 deltaPos; //Field offset: 0x20

}

