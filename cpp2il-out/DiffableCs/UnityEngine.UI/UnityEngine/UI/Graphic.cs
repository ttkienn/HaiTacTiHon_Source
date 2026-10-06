namespace UnityEngine.UI;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public abstract class Graphic : UIBehaviour, ICanvasElement
{
	protected static Material s_DefaultUI; //Field offset: 0x0
	protected static Texture2D s_WhiteTexture; //Field offset: 0x8
	protected static Mesh s_Mesh; //Field offset: 0x10
	private static readonly VertexHelper s_VertexHelper; //Field offset: 0x18
	[FormerlySerializedAs("m_Mat")]
	[SerializeField]
	protected Material m_Material; //Field offset: 0x20
	[SerializeField]
	private Color m_Color; //Field offset: 0x28
	protected bool m_SkipLayoutUpdate; //Field offset: 0x38
	protected bool m_SkipMaterialUpdate; //Field offset: 0x39
	[SerializeField]
	private bool m_RaycastTarget; //Field offset: 0x3A
	private bool m_RaycastTargetCache; //Field offset: 0x3B
	[SerializeField]
	private Vector4 m_RaycastPadding; //Field offset: 0x3C
	private RectTransform m_RectTransform; //Field offset: 0x50
	private CanvasRenderer m_CanvasRenderer; //Field offset: 0x58
	private Canvas m_Canvas; //Field offset: 0x60
	private bool m_VertsDirty; //Field offset: 0x68
	private bool m_MaterialDirty; //Field offset: 0x69
	protected UnityAction m_OnDirtyLayoutCallback; //Field offset: 0x70
	protected UnityAction m_OnDirtyVertsCallback; //Field offset: 0x78
	protected UnityAction m_OnDirtyMaterialCallback; //Field offset: 0x80
	protected Mesh m_CachedMesh; //Field offset: 0x88
	protected Vector2[] m_CachedUvs; //Field offset: 0x90
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; //Field offset: 0x98
	[CompilerGenerated]
	private bool <useLegacyMeshGeneration>k__BackingField; //Field offset: 0xA0

	public Canvas canvas
	{
		 get { } //Length: 108
	}

	public CanvasRenderer canvasRenderer
	{
		 get { } //Length: 155
	}

	public override Color color
	{
		 get { } //Length: 11
		 set { } //Length: 72
	}

	public static Material defaultGraphicMaterial
	{
		 get { } //Length: 242
	}

	public override Material defaultMaterial
	{
		 get { } //Length: 288
	}

	public int depth
	{
		 get { } //Length: 35
	}

	public override Texture mainTexture
	{
		 get { } //Length: 79
	}

	public override Material material
	{
		 get { } //Length: 131
		 set { } //Length: 146
	}

	public override Material materialForRendering
	{
		 get { } //Length: 463
	}

	public Vector4 raycastPadding
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public override bool raycastTarget
	{
		 get { } //Length: 5
		 set { } //Length: 219
	}

	public override RectTransform rectTransform
	{
		 get { } //Length: 85
	}

	protected bool useLegacyMeshGeneration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	protected static Mesh workerMesh
	{
		 get { } //Length: 335
	}

	private static Graphic() { }

	protected Graphic() { }

	private void CacheCanvas() { }

	private static Color CreateColorFromAlpha(float alpha) { }

	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	private void DoLegacyMeshGeneration() { }

	private void DoMeshGeneration() { }

	public Canvas get_canvas() { }

	public CanvasRenderer get_canvasRenderer() { }

	public override Color get_color() { }

	public static Material get_defaultGraphicMaterial() { }

	public override Material get_defaultMaterial() { }

	public int get_depth() { }

	public override Texture get_mainTexture() { }

	public override Material get_material() { }

	public override Material get_materialForRendering() { }

	public Vector4 get_raycastPadding() { }

	public override bool get_raycastTarget() { }

	public override RectTransform get_rectTransform() { }

	[CompilerGenerated]
	protected bool get_useLegacyMeshGeneration() { }

	protected static Mesh get_workerMesh() { }

	public Rect GetPixelAdjustedRect() { }

	public override void GraphicUpdateComplete() { }

	public override void LayoutComplete() { }

	protected virtual void OnBeforeTransformParentChanged() { }

	protected virtual void OnCanvasHierarchyChanged() { }

	public override void OnCullingChanged() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use OnPopulateMesh instead.", True)]
	protected override void OnFillVBO(List<UIVertex> vbo) { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", False)]
	protected override void OnPopulateMesh(Mesh m) { }

	protected virtual void OnRectTransformDimensionsChange() { }

	protected virtual void OnTransformParentChanged() { }

	public Vector2 PixelAdjustPoint(Vector2 point) { }

	public override bool Raycast(Vector2 sp, Camera eventCamera) { }

	public override void Rebuild(CanvasUpdate update) { }

	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	public override void set_color(Color value) { }

	public override void set_material(Material value) { }

	public void set_raycastPadding(Vector4 value) { }

	public override void set_raycastTarget(bool value) { }

	[CompilerGenerated]
	protected void set_useLegacyMeshGeneration(bool value) { }

	public override void SetAllDirty() { }

	public override void SetLayoutDirty() { }

	public override void SetMaterialDirty() { }

	public override void SetNativeSize() { }

	public void SetRaycastDirty() { }

	public override void SetVerticesDirty() { }

	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	protected override void UpdateGeometry() { }

	protected override void UpdateMaterial() { }

}

