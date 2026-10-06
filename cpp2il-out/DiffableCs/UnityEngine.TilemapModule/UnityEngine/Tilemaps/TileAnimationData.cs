namespace UnityEngine.Tilemaps;

[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
public struct TileAnimationData
{
	private Sprite[] m_AnimatedSprites; //Field offset: 0x0
	private float m_AnimationSpeed; //Field offset: 0x8
	private float m_AnimationStartTime; //Field offset: 0xC
	private TileAnimationFlags m_Flags; //Field offset: 0x10

}

