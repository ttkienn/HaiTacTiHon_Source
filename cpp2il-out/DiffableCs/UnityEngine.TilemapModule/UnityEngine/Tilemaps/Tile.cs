namespace UnityEngine.Tilemaps;

[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
[RequiredByNativeCode]
public class Tile : TileBase
{
	internal enum ColliderType
	{
		None = 0,
		Sprite = 1,
		Grid = 2,
	}

	[SerializeField]
	private Sprite m_Sprite; //Field offset: 0x18
	[SerializeField]
	private Color m_Color; //Field offset: 0x20
	[SerializeField]
	private Matrix4x4 m_Transform; //Field offset: 0x30
	[SerializeField]
	private GameObject m_InstancedGameObject; //Field offset: 0x70
	[SerializeField]
	private TileFlags m_Flags; //Field offset: 0x78
	[SerializeField]
	private ColliderType m_ColliderType; //Field offset: 0x7C

	public ColliderType colliderType
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public Color color
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public TileFlags flags
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public GameObject gameObject
	{
		 get { } //Length: 7
		 set { } //Length: 13
	}

	public Sprite sprite
	{
		 get { } //Length: 7
		 set { } //Length: 13
	}

	public Matrix4x4 transform
	{
		 get { } //Length: 35
		 set { } //Length: 32
	}

	public Tile() { }

	public ColliderType get_colliderType() { }

	public Color get_color() { }

	public TileFlags get_flags() { }

	public GameObject get_gameObject() { }

	public Sprite get_sprite() { }

	public Matrix4x4 get_transform() { }

	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	public void set_colliderType(ColliderType value) { }

	public void set_color(Color value) { }

	public void set_flags(TileFlags value) { }

	public void set_gameObject(GameObject value) { }

	public void set_sprite(Sprite value) { }

	public void set_transform(Matrix4x4 value) { }

}

