namespace UnityEngine.TerrainUtils;

public class TerrainMap
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public int groupID; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <CreateFromPlacement>b__0(Terrain x) { }

	}

	private Vector3 m_patchSize; //Field offset: 0x10
	private TerrainMapStatusCode m_errorCode; //Field offset: 0x1C
	private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles; //Field offset: 0x20

	public Dictionary<TerrainTileCoord, Terrain> terrainTiles
	{
		 get { } //Length: 5
	}

	public TerrainMap() { }

	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter = null, bool fullValidation = true) { }

	public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter = null, bool fullValidation = true) { }

	public Dictionary<TerrainTileCoord, Terrain> get_terrainTiles() { }

	public Terrain GetTerrain(int tileX, int tileZ) { }

	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	private TerrainMapStatusCode Validate() { }

	private void ValidateTerrain(int tileX, int tileZ) { }

}

