namespace UnityEngine.Tilemaps;

[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
internal struct TileDataNative
{
	private int m_Sprite; //Field offset: 0x0
	private Color m_Color; //Field offset: 0x4
	private Matrix4x4 m_Transform; //Field offset: 0x14
	private int m_GameObject; //Field offset: 0x54
	private TileFlags m_Flags; //Field offset: 0x58
	private ColliderType m_ColliderType; //Field offset: 0x5C

}

