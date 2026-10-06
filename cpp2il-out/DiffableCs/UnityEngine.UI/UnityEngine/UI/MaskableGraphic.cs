namespace UnityEngine.UI;

public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
{
	internal class CullStateChangedEvent : UnityEvent<Boolean>
	{

		public CullStateChangedEvent() { }

	}

	protected bool m_ShouldRecalculateStencil; //Field offset: 0xA8
	protected Material m_MaskMaterial; //Field offset: 0xB0
	private RectMask2D m_ParentMask; //Field offset: 0xB8
	[SerializeField]
	private bool m_Maskable; //Field offset: 0xC0
	private bool m_IsMaskingGraphic; //Field offset: 0xC1
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Not used anymore.", True)]
	protected bool m_IncludeForMasking; //Field offset: 0xC2
	[SerializeField]
	private CullStateChangedEvent m_OnCullStateChanged; //Field offset: 0xC8
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Not used anymore", True)]
	protected bool m_ShouldRecalculate; //Field offset: 0xD0
	protected int m_StencilValue; //Field offset: 0xD4
	private readonly Vector3[] m_Corners; //Field offset: 0xD8

	public bool isMaskingGraphic
	{
		 get { } //Length: 8
		 set { } //Length: 15
	}

	public bool maskable
	{
		 get { } //Length: 8
		 set { } //Length: 42
	}

	public CullStateChangedEvent onCullStateChanged
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	private Rect rootCanvasRect
	{
		private get { } //Length: 746
	}

	protected MaskableGraphic() { }

	public override void Cull(Rect clipRect, bool validRect) { }

	public bool get_isMaskingGraphic() { }

	public bool get_maskable() { }

	public CullStateChangedEvent get_onCullStateChanged() { }

	private Rect get_rootCanvasRect() { }

	public override Material GetModifiedMaterial(Material baseMaterial) { }

	protected virtual void OnCanvasHierarchyChanged() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnTransformParentChanged() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Not used anymore.", True)]
	public override void ParentMaskStateChanged() { }

	public override void RecalculateClipping() { }

	public override void RecalculateMasking() { }

	public void set_isMaskingGraphic(bool value) { }

	public void set_maskable(bool value) { }

	public void set_onCullStateChanged(CullStateChangedEvent value) { }

	public override void SetClipRect(Rect clipRect, bool validRect) { }

	public override void SetClipSoftness(Vector2 clipSoftness) { }

	private override GameObject UnityEngine.UI.IClippable.get_gameObject() { }

	private void UpdateClipParent() { }

	private void UpdateCull(bool cull) { }

}

