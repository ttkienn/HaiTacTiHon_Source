namespace UnityEngine.TerrainUtils;

[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainUtility
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public bool onlyAutoConnectedTerrains; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_1
	{
		public Terrain t; //Field offset: 0x10
		public <>c__DisplayClass2_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass2_1() { }

		internal bool <CollectTerrains>b__0(Terrain x) { }

	}


	[RequiredByNativeCode]
	public static void AutoConnect() { }

	internal static void ClearConnectivity() { }

	internal static Dictionary<Int32, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = true) { }

	internal static bool ValidTerrainsExist() { }

}

