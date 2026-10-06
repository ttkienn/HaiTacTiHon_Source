namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[UsedByNativeCode]
internal struct BatchRendererCullingOutput
{
	public JobHandle cullingJobsFence; //Field offset: 0x0
	public Matrix4x4 localToWorldMatrix; //Field offset: 0x10
	public Plane* cullingPlanes; //Field offset: 0x50
	public int cullingPlaneCount; //Field offset: 0x58
	public int receiverPlaneOffset; //Field offset: 0x5C
	public int receiverPlaneCount; //Field offset: 0x60
	public CullingSplit* cullingSplits; //Field offset: 0x68
	public int cullingSplitCount; //Field offset: 0x70
	public BatchCullingViewType viewType; //Field offset: 0x74
	public BatchCullingProjectionType projectionType; //Field offset: 0x78
	public BatchCullingFlags cullingFlags; //Field offset: 0x7C
	public ulong viewID; //Field offset: 0x80
	public uint cullingLayerMask; //Field offset: 0x88
	public ulong sceneCullingMask; //Field offset: 0x90
	public BatchCullingOutputDrawCommands* drawCommands; //Field offset: 0x98

}

