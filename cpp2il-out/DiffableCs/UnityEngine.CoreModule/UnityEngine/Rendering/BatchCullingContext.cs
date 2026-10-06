namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[UsedByNativeCode]
public struct BatchCullingContext
{
	public readonly NativeArray<Plane> cullingPlanes; //Field offset: 0x0
	public readonly NativeArray<CullingSplit> cullingSplits; //Field offset: 0x10
	public readonly LODParameters lodParameters; //Field offset: 0x20
	public readonly Matrix4x4 localToWorldMatrix; //Field offset: 0x3C
	public readonly BatchCullingViewType viewType; //Field offset: 0x7C
	public readonly BatchCullingProjectionType projectionType; //Field offset: 0x80
	public readonly BatchCullingFlags cullingFlags; //Field offset: 0x84
	public readonly BatchPackedCullingViewID viewID; //Field offset: 0x88
	public readonly uint cullingLayerMask; //Field offset: 0x90
	public readonly ulong sceneCullingMask; //Field offset: 0x98
	[Obsolete("BatchCullingContext.isOrthographic is deprecated. Use BatchCullingContext.projectionType instead.")]
	public readonly byte isOrthographic; //Field offset: 0xA0
	public readonly int receiverPlaneOffset; //Field offset: 0xA4
	public readonly int receiverPlaneCount; //Field offset: 0xA8

	internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, int inReceiverPlaneOffset, int inReceiverPlaneCount) { }

}

