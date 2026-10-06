namespace UnityEngine.VFX;

[RequiredByNativeCode]
public struct VFXBatchedEffectInfo
{
	public VisualEffectAsset vfxAsset; //Field offset: 0x0
	public uint activeBatchCount; //Field offset: 0x8
	public uint inactiveBatchCount; //Field offset: 0xC
	public uint activeInstanceCount; //Field offset: 0x10
	public uint unbatchedInstanceCount; //Field offset: 0x14
	public uint totalInstanceCapacity; //Field offset: 0x18
	public uint maxInstancePerBatchCapacity; //Field offset: 0x1C
	public ulong totalGPUSizeInBytes; //Field offset: 0x20
	public ulong totalCPUSizeInBytes; //Field offset: 0x28

}

