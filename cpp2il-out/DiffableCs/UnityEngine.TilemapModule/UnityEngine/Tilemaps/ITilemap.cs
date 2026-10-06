namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
public class ITilemap
{
	internal static ITilemap s_Instance; //Field offset: 0x0
	internal Tilemap m_Tilemap; //Field offset: 0x10
	internal bool m_AddToList; //Field offset: 0x18
	internal int m_RefreshCount; //Field offset: 0x1C
	internal NativeArray<Vector3Int> m_RefreshPos; //Field offset: 0x20

	internal ITilemap() { }

	[RequiredByNativeCode]
	private static ITilemap CreateInstance() { }

	[RequiredByNativeCode]
	private static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr) { }

	[RequiredByNativeCode]
	private static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr) { }

	public void RefreshTile(Vector3Int position) { }

}

