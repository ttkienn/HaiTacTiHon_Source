namespace UnityEngine;

[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[UsedByNativeCode]
public sealed class TerrainData : object
{
	private enum BoundaryValueType
	{
		MaxHeightmapRes = 0,
		MinDetailResPerPatch = 1,
		MaxDetailResPerPatch = 2,
		MaxDetailPatchCount = 3,
		MaxCoveragePerRes = 4,
		MinAlphamapRes = 5,
		MaxAlphamapRes = 6,
		MinBaseMapRes = 7,
		MaxBaseMapRes = 8,
	}

	internal static readonly int k_MaximumResolution; //Field offset: 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; //Field offset: 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; //Field offset: 0x8
	internal static readonly int k_MaximumDetailPatchCount; //Field offset: 0xC
	internal static readonly int k_MinimumAlphamapResolution; //Field offset: 0x10
	internal static readonly int k_MaximumAlphamapResolution; //Field offset: 0x14
	internal static readonly int k_MinimumBaseMapResolution; //Field offset: 0x18
	internal static readonly int k_MaximumBaseMapResolution; //Field offset: 0x1C

	public Vector3 size
	{
		[NativeName("GetHeightmap().GetSize")]
		 get { } //Length: 77
	}

	internal Terrain[] users
	{
		internal get { } //Length: 51
	}

	private static TerrainData() { }

	public TerrainData() { }

	[NativeName("GetHeightmap().GetSize")]
	public Vector3 get_size() { }

	private void get_size_Injected(out Vector3 ret) { }

	internal Terrain[] get_users() { }

	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	[RequiredByNativeCode]
	internal float GetAlphamapResolutionInternal() { }

	[StaticAccessor("TerrainDataScriptingInterface", StaticAccessorType::DoubleColon (2))]
	[ThreadSafe]
	private static int GetBoundaryValue(BoundaryValueType type) { }

	[FreeFunction("TerrainDataScriptingInterface::Create")]
	private static void Internal_Create(TerrainData terrainData) { }

}

