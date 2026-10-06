namespace UnityEngine;

[NativeHeader("TerrainScriptingClasses.h")]
[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
[NativeHeader("Modules/Terrain/Public/Terrain.h")]
[StaticAccessor("GetITerrainManager()", StaticAccessorType::Arrow (1))]
[UsedByNativeCode]
public sealed class Terrain : Behaviour
{

	[NativeProperty("ActiveTerrainsScriptingArray")]
	public static Terrain[] activeTerrains
	{
		 get { } //Length: 42
	}

	public bool allowAutoConnect
	{
		 get { } //Length: 51
	}

	public int groupingID
	{
		 get { } //Length: 51
	}

	public TerrainData terrainData
	{
		 get { } //Length: 51
	}

	public Terrain() { }

	public static Terrain[] get_activeTerrains() { }

	public bool get_allowAutoConnect() { }

	public int get_groupingID() { }

	public TerrainData get_terrainData() { }

	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

}

