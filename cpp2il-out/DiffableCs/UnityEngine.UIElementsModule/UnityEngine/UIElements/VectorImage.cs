namespace UnityEngine.UIElements;

public class VectorImage : ScriptableObject
{
	[SerializeField]
	internal int version; //Field offset: 0x18
	[SerializeField]
	internal Texture2D atlas; //Field offset: 0x20
	[SerializeField]
	internal VectorImageVertex[] vertices; //Field offset: 0x28
	[SerializeField]
	internal UInt16[] indices; //Field offset: 0x30
	[SerializeField]
	internal GradientSettings[] settings; //Field offset: 0x38
	[SerializeField]
	internal Vector2 size; //Field offset: 0x40

	public float height
	{
		 get { } //Length: 6
	}

	public float width
	{
		 get { } //Length: 6
	}

	public VectorImage() { }

	public float get_height() { }

	public float get_width() { }

}

