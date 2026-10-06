namespace UnityEngine.Tilemaps;

[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
public struct TileChangeData
{
	private Vector3Int m_Position; //Field offset: 0x0
	private object m_TileAsset; //Field offset: 0x10
	private Color m_Color; //Field offset: 0x18
	private Matrix4x4 m_Transform; //Field offset: 0x28

}

