namespace UnityEngine.UI;

[AddComponentMenu("UI/Rect Mask 2D", 14)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
{
	private readonly RectangularVertexClipper m_VertexClipper; //Field offset: 0x20
	private RectTransform m_RectTransform; //Field offset: 0x28
	private HashSet<MaskableGraphic> m_MaskableTargets; //Field offset: 0x30
	private HashSet<IClippable> m_ClipTargets; //Field offset: 0x38
	private bool m_ShouldRecalculateClipRects; //Field offset: 0x40
	private List<RectMask2D> m_Clippers; //Field offset: 0x48
	private Rect m_LastClipRectCanvasSpace; //Field offset: 0x50
	private bool m_ForceClip; //Field offset: 0x60
	[SerializeField]
	private Vector4 m_Padding; //Field offset: 0x64
	[SerializeField]
	private Vector2Int m_Softness; //Field offset: 0x74
	private Canvas m_Canvas; //Field offset: 0x80
	private Vector3[] m_Corners; //Field offset: 0x88

	internal Canvas Canvas
	{
		internal get { } //Length: 356
	}

	public Rect canvasRect
	{
		 get { } //Length: 180
	}

	public Vector4 padding
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 99
	}

	private Rect rootCanvasRect
	{
		private get { } //Length: 489
	}

	public Vector2Int softness
	{
		 get { } //Length: 5
		 set { } //Length: 37
	}

	protected RectMask2D() { }

	public void AddClippable(IClippable clippable) { }

	internal Canvas get_Canvas() { }

	public Rect get_canvasRect() { }

	public Vector4 get_padding() { }

	public RectTransform get_rectTransform() { }

	private Rect get_rootCanvasRect() { }

	public Vector2Int get_softness() { }

	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	protected virtual void OnCanvasHierarchyChanged() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnTransformParentChanged() { }

	public override void PerformClipping() { }

	public void RemoveClippable(IClippable clippable) { }

	public void set_padding(Vector4 value) { }

	public void set_softness(Vector2Int value) { }

	public override void UpdateClipSoftness() { }

}

