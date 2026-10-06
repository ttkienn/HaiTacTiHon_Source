namespace UnityEngine.Tilemaps;

[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
public struct TileData
{
	internal static readonly TileData Default; //Field offset: 0x0
	private int m_Sprite; //Field offset: 0x0
	private Color m_Color; //Field offset: 0x4
	private Matrix4x4 m_Transform; //Field offset: 0x14
	private int m_GameObject; //Field offset: 0x54
	private TileFlags m_Flags; //Field offset: 0x58
	private ColliderType m_ColliderType; //Field offset: 0x5C

	public ColliderType colliderType
	{
		 set { } //Length: 4
	}

	public Color color
	{
		 set { } //Length: 8
	}

	public TileFlags flags
	{
		 set { } //Length: 4
	}

	public GameObject gameObject
	{
		 set { } //Length: 132
	}

	public Sprite sprite
	{
		 set { } //Length: 130
	}

	public Matrix4x4 transform
	{
		 set { } //Length: 32
	}

	private static TileData() { }

	private static TileData CreateDefault() { }

	public void set_colliderType(ColliderType value) { }

	public void set_color(Color value) { }

	public void set_flags(TileFlags value) { }

	public void set_gameObject(GameObject value) { }

	public void set_sprite(Sprite value) { }

	public void set_transform(Matrix4x4 value) { }

}

