namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
public abstract class TileBase : ScriptableObject
{

	protected TileBase() { }

	[RequiredByNativeCode]
	public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation) { }

	[RequiredByNativeCode]
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	public override void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	[RequiredByNativeCode]
	private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser) { }

}

