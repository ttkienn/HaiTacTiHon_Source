namespace UnityEngine.UIElements;

public class Image : VisualElement
{
	internal class UxmlFactory : UxmlFactory<Image, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{

		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	private static CustomStyleProperty<Texture2D> s_ImageProperty; //Field offset: 0x8
	private static CustomStyleProperty<Sprite> s_SpriteProperty; //Field offset: 0x10
	private static CustomStyleProperty<VectorImage> s_VectorImageProperty; //Field offset: 0x18
	private static CustomStyleProperty<String> s_ScaleModeProperty; //Field offset: 0x20
	private static CustomStyleProperty<Color> s_TintColorProperty; //Field offset: 0x28
	private ScaleMode m_ScaleMode; //Field offset: 0x3C8
	private Texture m_Image; //Field offset: 0x3D0
	private Sprite m_Sprite; //Field offset: 0x3D8
	private VectorImage m_VectorImage; //Field offset: 0x3E0
	private Rect m_UV; //Field offset: 0x3E8
	private Color m_TintColor; //Field offset: 0x3F8
	internal bool m_ImageIsInline; //Field offset: 0x408
	private bool m_ScaleModeIsInline; //Field offset: 0x409
	private bool m_TintColorIsInline; //Field offset: 0x40A

	public Texture image
	{
		 get { } //Length: 8
		 set { } //Length: 221
	}

	public ScaleMode scaleMode
	{
		 get { } //Length: 7
	}

	public Rect sourceRect
	{
		 get { } //Length: 37
	}

	public Sprite sprite
	{
		 get { } //Length: 8
		 set { } //Length: 221
	}

	public Color tintColor
	{
		 get { } //Length: 14
	}

	public Rect uv
	{
		 get { } //Length: 14
		 set { } //Length: 85
	}

	public VectorImage vectorImage
	{
		 get { } //Length: 8
		 set { } //Length: 221
	}

	private static Image() { }

	public Image() { }

	private void ClearProperty() { }

	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	public Texture get_image() { }

	public ScaleMode get_scaleMode() { }

	public Rect get_sourceRect() { }

	public Sprite get_sprite() { }

	public Color get_tintColor() { }

	public Rect get_uv() { }

	public VectorImage get_vectorImage() { }

	private Rect GetSourceRect() { }

	private Vector2 GetTextureDisplaySize(Sprite sprite) { }

	private Vector2 GetTextureDisplaySize(Texture texture) { }

	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	private void ReadCustomProperties(ICustomStyle customStyleProvider) { }

	public void set_image(Texture value) { }

	public void set_sprite(Sprite value) { }

	public void set_uv(Rect value) { }

	public void set_vectorImage(VectorImage value) { }

	private void SetProperty(T0 src, ref T0 dst, ref T1 alt0, ref T2 alt1) { }

	private void SetScaleMode(ScaleMode mode) { }

	private void SetTintColor(Color color) { }

}

