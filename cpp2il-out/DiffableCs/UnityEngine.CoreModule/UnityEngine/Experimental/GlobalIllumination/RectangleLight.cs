namespace UnityEngine.Experimental.GlobalIllumination;

public struct RectangleLight
{
	public int instanceID; //Field offset: 0x0
	public bool shadow; //Field offset: 0x4
	public LightMode mode; //Field offset: 0x5
	public Vector3 position; //Field offset: 0x8
	public Quaternion orientation; //Field offset: 0x14
	public LinearColor color; //Field offset: 0x24
	public LinearColor indirectColor; //Field offset: 0x34
	public float range; //Field offset: 0x44
	public float width; //Field offset: 0x48
	public float height; //Field offset: 0x4C
	public FalloffType falloff; //Field offset: 0x50

}

