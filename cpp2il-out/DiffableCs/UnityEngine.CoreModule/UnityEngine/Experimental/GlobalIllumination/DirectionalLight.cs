namespace UnityEngine.Experimental.GlobalIllumination;

public struct DirectionalLight
{
	public int instanceID; //Field offset: 0x0
	public bool shadow; //Field offset: 0x4
	public LightMode mode; //Field offset: 0x5
	public Vector3 position; //Field offset: 0x8
	public Quaternion orientation; //Field offset: 0x14
	public LinearColor color; //Field offset: 0x24
	public LinearColor indirectColor; //Field offset: 0x34
	public float penumbraWidthRadian; //Field offset: 0x44
	[Obsolete("Directional lights support cookies now. In order to position the cookie projection in the world, a position and full orientation are necessary. Use the position and orientation members instead of the direction parameter.", True)]
	public Vector3 direction; //Field offset: 0x48

}

