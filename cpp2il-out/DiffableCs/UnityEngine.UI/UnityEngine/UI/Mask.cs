namespace UnityEngine.UI;

[AddComponentMenu("UI/Mask", 13)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
{
	private RectTransform m_RectTransform; //Field offset: 0x20
	[SerializeField]
	private bool m_ShowMaskGraphic; //Field offset: 0x28
	private Graphic m_Graphic; //Field offset: 0x30
	private Material m_MaskMaterial; //Field offset: 0x38
	private Material m_UnmaskMaterial; //Field offset: 0x40

	public Graphic graphic
	{
		 get { } //Length: 99
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 99
	}

	public bool showMaskGraphic
	{
		 get { } //Length: 5
		 set { } //Length: 221
	}

	protected Mask() { }

	public Graphic get_graphic() { }

	public RectTransform get_rectTransform() { }

	public bool get_showMaskGraphic() { }

	public override Material GetModifiedMaterial(Material baseMaterial) { }

	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	public override bool MaskEnabled() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	[Obsolete("Not used anymore.")]
	public override void OnSiblingGraphicEnabledDisabled() { }

	public void set_showMaskGraphic(bool value) { }

}

