namespace UnityEngine;

[NativeHeader("Runtime/Camera/SharedLightData.h")]
public struct LightBakingOutput
{
	public int probeOcclusionLightIndex; //Field offset: 0x0
	public int occlusionMaskChannel; //Field offset: 0x4
	[NativeName("lightmapBakeMode.lightmapBakeType")]
	public LightmapBakeType lightmapBakeType; //Field offset: 0x8
	[NativeName("lightmapBakeMode.mixedLightingMode")]
	public MixedLightingMode mixedLightingMode; //Field offset: 0xC
	public bool isBaked; //Field offset: 0x10

}

