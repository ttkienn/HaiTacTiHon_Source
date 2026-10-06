namespace UnityEngine.Tilemaps;

[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeHeader("Modules/Grid/Public/Grid.h")]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
[RequireComponent(typeof(Transform))]
public sealed class Tilemap : GridLayout
{
	[RequiredByNativeCode]
	internal struct SyncTile
	{
		internal Vector3Int m_Position; //Field offset: 0x0
		internal TileBase m_Tile; //Field offset: 0x10
		internal TileData m_TileData; //Field offset: 0x18

	}

	public struct SyncTileCallbackSettings
	{
		internal bool hasSyncTileCallback; //Field offset: 0x0
		internal bool hasPositionsChangedCallback; //Field offset: 0x1
		internal bool isBufferSyncTile; //Field offset: 0x2

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Tilemap, SyncTile[]> tilemapTileChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Tilemap, NativeArray`1<Vector3Int>> tilemapPositionsChanged; //Field offset: 0x8
	private bool m_BufferSyncTile; //Field offset: 0x18

	internal bool bufferSyncTile
	{
		internal get { } //Length: 7
	}

	[RequiredByNativeCode]
	private void DoPositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	[RequiredByNativeCode]
	private void DoSyncTileCallback(SyncTile[] syncTiles) { }

	internal bool get_bufferSyncTile() { }

	[RequiredByNativeCode]
	internal void GetSyncTileCallbackSettings(ref SyncTileCallbackSettings settings) { }

	private void HandlePositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	private void HandleSyncTileCallback(SyncTile[] syncTiles) { }

	internal static bool HasPositionsChangedCallback() { }

	internal static bool HasSyncTileCallback() { }

	[NativeMethod(Name = "RefreshTileAsset")]
	public void RefreshTile(Vector3Int position) { }

	private void RefreshTile_Injected(ref Vector3Int position) { }

	[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = True)]
	internal void RefreshTilesNative(Void* positions, int count) { }

	private void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions) { }

	private void SendTilemapTileChangedCallback(SyncTile[] syncTiles) { }

}

