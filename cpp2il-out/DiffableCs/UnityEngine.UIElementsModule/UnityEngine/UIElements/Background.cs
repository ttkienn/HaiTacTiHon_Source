namespace UnityEngine.UIElements;

public struct Background : IEquatable<Background>
{
	private Texture2D m_Texture; //Field offset: 0x0
	private Sprite m_Sprite; //Field offset: 0x8
	private RenderTexture m_RenderTexture; //Field offset: 0x10
	private VectorImage m_VectorImage; //Field offset: 0x18

	public RenderTexture renderTexture
	{
		 get { } //Length: 7
		 set { } //Length: 169
	}

	public Sprite sprite
	{
		 get { } //Length: 7
		 set { } //Length: 169
	}

	public Texture2D texture
	{
		 get { } //Length: 6
		 set { } //Length: 168
	}

	public VectorImage vectorImage
	{
		 get { } //Length: 7
		 set { } //Length: 169
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(Background other) { }

	internal static Background FromObject(object obj) { }

	public static Background FromRenderTexture(RenderTexture rt) { }

	public static Background FromSprite(Sprite s) { }

	public static Background FromTexture2D(Texture2D t) { }

	public static Background FromVectorImage(VectorImage vi) { }

	public RenderTexture get_renderTexture() { }

	public Sprite get_sprite() { }

	public Texture2D get_texture() { }

	public VectorImage get_vectorImage() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Background lhs, Background rhs) { }

	public static bool op_Inequality(Background lhs, Background rhs) { }

	public void set_renderTexture(RenderTexture value) { }

	public void set_sprite(Sprite value) { }

	public void set_texture(Texture2D value) { }

	public void set_vectorImage(VectorImage value) { }

	public virtual string ToString() { }

}

