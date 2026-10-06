namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[UsedByNativeCode]
public struct CullingSplit
{
	public Vector3 sphereCenter; //Field offset: 0x0
	public float sphereRadius; //Field offset: 0xC
	public int cullingPlaneOffset; //Field offset: 0x10
	public int cullingPlaneCount; //Field offset: 0x14
	public float cascadeBlendCullingFactor; //Field offset: 0x18
	public float nearPlane; //Field offset: 0x1C
	public Matrix4x4 cullingMatrix; //Field offset: 0x20

}

