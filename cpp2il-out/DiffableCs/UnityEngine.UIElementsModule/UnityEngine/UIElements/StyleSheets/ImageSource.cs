namespace UnityEngine.UIElements.StyleSheets;

internal struct ImageSource
{
	public Texture2D texture; //Field offset: 0x0
	public Sprite sprite; //Field offset: 0x8
	public VectorImage vectorImage; //Field offset: 0x10
	public RenderTexture renderTexture; //Field offset: 0x18

	public bool IsNull() { }

}

