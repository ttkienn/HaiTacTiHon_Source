namespace UnityEngine.UIElements;

[Extension]
internal static class MeshGenerationContextUtils
{
	internal struct BorderParams
	{
		public Rect rect; //Field offset: 0x0
		public Color playmodeTintColor; //Field offset: 0x10
		public Color leftColor; //Field offset: 0x20
		public Color topColor; //Field offset: 0x30
		public Color rightColor; //Field offset: 0x40
		public Color bottomColor; //Field offset: 0x50
		public float leftWidth; //Field offset: 0x60
		public float topWidth; //Field offset: 0x64
		public float rightWidth; //Field offset: 0x68
		public float bottomWidth; //Field offset: 0x6C
		public Vector2 topLeftRadius; //Field offset: 0x70
		public Vector2 topRightRadius; //Field offset: 0x78
		public Vector2 bottomRightRadius; //Field offset: 0x80
		public Vector2 bottomLeftRadius; //Field offset: 0x88
		public Material material; //Field offset: 0x90
		internal ColorPage leftColorPage; //Field offset: 0x98
		internal ColorPage topColorPage; //Field offset: 0xA0
		internal ColorPage rightColorPage; //Field offset: 0xA8
		internal ColorPage bottomColorPage; //Field offset: 0xB0

		internal NativeBorderParams ToNativeParams() { }

	}

	internal struct RectangleParams
	{
		public Rect rect; //Field offset: 0x0
		public Rect uv; //Field offset: 0x10
		public Color color; //Field offset: 0x20
		public Rect subRect; //Field offset: 0x30
		public Rect backgroundRepeatRect; //Field offset: 0x40
		public BackgroundPosition backgroundPositionX; //Field offset: 0x50
		public BackgroundPosition backgroundPositionY; //Field offset: 0x5C
		public BackgroundRepeat backgroundRepeat; //Field offset: 0x68
		public BackgroundSize backgroundSize; //Field offset: 0x70
		public Texture texture; //Field offset: 0x88
		public Sprite sprite; //Field offset: 0x90
		public VectorImage vectorImage; //Field offset: 0x98
		public Material material; //Field offset: 0xA0
		public ScaleMode scaleMode; //Field offset: 0xA8
		public Color playmodeTintColor; //Field offset: 0xAC
		public Vector2 topLeftRadius; //Field offset: 0xBC
		public Vector2 topRightRadius; //Field offset: 0xC4
		public Vector2 bottomRightRadius; //Field offset: 0xCC
		public Vector2 bottomLeftRadius; //Field offset: 0xD4
		public Vector2 contentSize; //Field offset: 0xDC
		public Vector2 textureSize; //Field offset: 0xE4
		public int leftSlice; //Field offset: 0xEC
		public int topSlice; //Field offset: 0xF0
		public int rightSlice; //Field offset: 0xF4
		public int bottomSlice; //Field offset: 0xF8
		public float sliceScale; //Field offset: 0xFC
		internal Rect spriteGeomRect; //Field offset: 0x100
		public Vector4 rectInset; //Field offset: 0x110
		internal ColorPage colorPage; //Field offset: 0x120
		internal MeshFlags meshFlags; //Field offset: 0x128

		private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) { }

		private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) { }

		private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation) { }

		private static Rect ComputeGeomRect(Sprite sprite) { }

		private static Rect ComputeUVRect(Sprite sprite) { }

		internal bool HasRadius(float epsilon) { }

		internal bool HasSlices(float epsilon) { }

		public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, ContextType panelContext, bool hasRadius, ref Vector4 slices, bool useForRepeat = false) { }

		public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, ContextType panelContext) { }

		public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, ContextType panelContext) { }

		internal static Rect RectIntersection(Rect a, Rect b) { }

		internal NativeRectParams ToNativeParams(Rect uvRegion) { }

	}


	public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref RectangleParams rectParams) { }

	private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length) { }

	public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight) { }

	[Extension]
	public static void Rectangle(MeshGenerationContext mgc, RectangleParams rectParams) { }

	[Extension]
	public static void Text(MeshGenerationContext mgc, TextElement te) { }

}

