namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
public abstract class TextAsset : ScriptableObject
{
	[SerializeField]
	internal string m_Version; //Field offset: 0x18
	internal int m_InstanceID; //Field offset: 0x20
	internal int m_HashCode; //Field offset: 0x24
	[FormerlySerializedAs("material")]
	[SerializeField]
	internal Material m_Material; //Field offset: 0x28
	internal int m_MaterialHashCode; //Field offset: 0x30

	public int hashCode
	{
		 get { } //Length: 50
		 set { } //Length: 4
	}

	public int instanceID
	{
		 get { } //Length: 40
	}

	public Material material
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public int materialHashCode
	{
		 get { } //Length: 146
		 set { } //Length: 4
	}

	public internal string version
	{
		 get { } //Length: 7
		internal set { } //Length: 13
	}

	protected TextAsset() { }

	public int get_hashCode() { }

	public int get_instanceID() { }

	public Material get_material() { }

	public int get_materialHashCode() { }

	public string get_version() { }

	public void set_hashCode(int value) { }

	public void set_material(Material value) { }

	public void set_materialHashCode(int value) { }

	internal void set_version(string value) { }

}

