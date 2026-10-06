namespace UnityEngine.UI;

[AddComponentMenu("UI/Image", 11)]
[RequireComponent(typeof(CanvasRenderer))]
public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
{
	internal enum FillMethod
	{
		Horizontal = 0,
		Vertical = 1,
		Radial90 = 2,
		Radial180 = 3,
		Radial360 = 4,
	}

	internal enum Origin180
	{
		Bottom = 0,
		Left = 1,
		Top = 2,
		Right = 3,
	}

	internal enum Origin360
	{
		Bottom = 0,
		Right = 1,
		Top = 2,
		Left = 3,
	}

	internal enum Origin90
	{
		BottomLeft = 0,
		TopLeft = 1,
		TopRight = 2,
		BottomRight = 3,
	}

	internal enum OriginHorizontal
	{
		Left = 0,
		Right = 1,
	}

	internal enum OriginVertical
	{
		Bottom = 0,
		Top = 1,
	}

	internal enum Type
	{
		Simple = 0,
		Sliced = 1,
		Tiled = 2,
		Filled = 3,
	}

	protected static Material s_ETC1DefaultUI; //Field offset: 0x0
	private static readonly Vector2[] s_VertScratch; //Field offset: 0x8
	private static readonly Vector2[] s_UVScratch; //Field offset: 0x10
	private static readonly Vector3[] s_Xy; //Field offset: 0x18
	private static readonly Vector3[] s_Uv; //Field offset: 0x20
	private static List<Image> m_TrackedTexturelessImages; //Field offset: 0x28
	private static bool s_Initialized; //Field offset: 0x30
	[FormerlySerializedAs("m_Frame")]
	[SerializeField]
	private Sprite m_Sprite; //Field offset: 0xE0
	private Sprite m_OverrideSprite; //Field offset: 0xE8
	[SerializeField]
	private Type m_Type; //Field offset: 0xF0
	[SerializeField]
	private bool m_PreserveAspect; //Field offset: 0xF4
	[SerializeField]
	private bool m_FillCenter; //Field offset: 0xF5
	[SerializeField]
	private FillMethod m_FillMethod; //Field offset: 0xF8
	[Range(0, 1)]
	[SerializeField]
	private float m_FillAmount; //Field offset: 0xFC
	[SerializeField]
	private bool m_FillClockwise; //Field offset: 0x100
	[SerializeField]
	private int m_FillOrigin; //Field offset: 0x104
	private float m_AlphaHitTestMinimumThreshold; //Field offset: 0x108
	private bool m_Tracked; //Field offset: 0x10C
	[SerializeField]
	private bool m_UseSpriteMesh; //Field offset: 0x10D
	[SerializeField]
	private float m_PixelsPerUnitMultiplier; //Field offset: 0x110
	private float m_CachedReferencePixelsPerUnit; //Field offset: 0x114

	private Sprite activeSprite
	{
		private get { } //Length: 122
	}

	public float alphaHitTestMinimumThreshold
	{
		 get { } //Length: 9
		 set { } //Length: 345
	}

	public static Material defaultETC1GraphicMaterial
	{
		 get { } //Length: 242
	}

	[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
	public float eventAlphaThreshold
	{
		 get { } //Length: 17
		 set { } //Length: 354
	}

	public float fillAmount
	{
		 get { } //Length: 9
		 set { } //Length: 133
	}

	public bool fillCenter
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public bool fillClockwise
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public FillMethod fillMethod
	{
		 get { } //Length: 7
		 set { } //Length: 111
	}

	public int fillOrigin
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public override float flexibleHeight
	{
		 get { } //Length: 9
	}

	public override float flexibleWidth
	{
		 get { } //Length: 9
	}

	public bool hasBorder
	{
		 get { } //Length: 232
	}

	public override int layoutPriority
	{
		 get { } //Length: 3
	}

	public virtual Texture mainTexture
	{
		 get { } //Length: 394
	}

	public virtual Material material
	{
		 get { } //Length: 537
		 set { } //Length: 146
	}

	public override float minHeight
	{
		 get { } //Length: 4
	}

	public override float minWidth
	{
		 get { } //Length: 4
	}

	protected float multipliedPixelsPerUnit
	{
		 get { } //Length: 30
	}

	public Sprite overrideSprite
	{
		 get { } //Length: 7
		 set { } //Length: 113
	}

	public float pixelsPerUnit
	{
		 get { } //Length: 318
	}

	public float pixelsPerUnitMultiplier
	{
		 get { } //Length: 9
		 set { } //Length: 42
	}

	public override float preferredHeight
	{
		 get { } //Length: 259
	}

	public override float preferredWidth
	{
		 get { } //Length: 259
	}

	public bool preserveAspect
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public Sprite sprite
	{
		 get { } //Length: 8
		 set { } //Length: 743
	}

	public Type type
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public bool useSpriteMesh
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	private static Image() { }

	protected Image() { }

	[CompilerGenerated]
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	[CompilerGenerated]
	private bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1() { }

	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	public override void CalculateLayoutInputHorizontal() { }

	public override void CalculateLayoutInputVertical() { }

	public void DisableSpriteOptimizations() { }

	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	private void GenerateSlicedSprite(VertexHelper toFill) { }

	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	private void GenerateTiledSprite(VertexHelper toFill) { }

	private Sprite get_activeSprite() { }

	public float get_alphaHitTestMinimumThreshold() { }

	public static Material get_defaultETC1GraphicMaterial() { }

	public float get_eventAlphaThreshold() { }

	public float get_fillAmount() { }

	public bool get_fillCenter() { }

	public bool get_fillClockwise() { }

	public FillMethod get_fillMethod() { }

	public int get_fillOrigin() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	public bool get_hasBorder() { }

	public override int get_layoutPriority() { }

	public virtual Texture get_mainTexture() { }

	public virtual Material get_material() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	protected float get_multipliedPixelsPerUnit() { }

	public Sprite get_overrideSprite() { }

	public float get_pixelsPerUnit() { }

	public float get_pixelsPerUnitMultiplier() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	public bool get_preserveAspect() { }

	public Sprite get_sprite() { }

	public Type get_type() { }

	public bool get_useSpriteMesh() { }

	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	protected virtual void OnCanvasHierarchyChanged() { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	public void set_alphaHitTestMinimumThreshold(float value) { }

	public void set_eventAlphaThreshold(float value) { }

	public void set_fillAmount(float value) { }

	public void set_fillCenter(bool value) { }

	public void set_fillClockwise(bool value) { }

	public void set_fillMethod(FillMethod value) { }

	public void set_fillOrigin(int value) { }

	public virtual void set_material(Material value) { }

	public void set_overrideSprite(Sprite value) { }

	public void set_pixelsPerUnitMultiplier(float value) { }

	public void set_preserveAspect(bool value) { }

	public void set_sprite(Sprite value) { }

	public void set_type(Type value) { }

	public void set_useSpriteMesh(bool value) { }

	public virtual void SetNativeSize() { }

	private static void TrackImage(Image g) { }

	private void TrackSprite() { }

	private static void UnTrackImage(Image g) { }

	protected virtual void UpdateMaterial() { }

}

