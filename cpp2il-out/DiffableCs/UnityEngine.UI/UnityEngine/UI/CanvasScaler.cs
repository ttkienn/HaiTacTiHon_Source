namespace UnityEngine.UI;

[AddComponentMenu("Layout/Canvas Scaler", 101)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(Canvas))]
public class CanvasScaler : UIBehaviour
{
	internal enum ScaleMode
	{
		ConstantPixelSize = 0,
		ScaleWithScreenSize = 1,
		ConstantPhysicalSize = 2,
	}

	internal enum ScreenMatchMode
	{
		MatchWidthOrHeight = 0,
		Expand = 1,
		Shrink = 2,
	}

	internal enum Unit
	{
		Centimeters = 0,
		Millimeters = 1,
		Inches = 2,
		Points = 3,
		Picas = 4,
	}

	private const float kLogBase = 2; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Determines how UI elements in the Canvas are scaled.")]
	private ScaleMode m_UiScaleMode; //Field offset: 0x20
	[SerializeField]
	[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
	protected float m_ReferencePixelsPerUnit; //Field offset: 0x24
	[SerializeField]
	[Tooltip("Scales all UI elements in the Canvas by this factor.")]
	protected float m_ScaleFactor; //Field offset: 0x28
	[SerializeField]
	[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
	protected Vector2 m_ReferenceResolution; //Field offset: 0x2C
	[SerializeField]
	[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
	protected ScreenMatchMode m_ScreenMatchMode; //Field offset: 0x34
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
	protected float m_MatchWidthOrHeight; //Field offset: 0x38
	[SerializeField]
	[Tooltip("The physical unit to specify positions and sizes in.")]
	protected Unit m_PhysicalUnit; //Field offset: 0x3C
	[SerializeField]
	[Tooltip("The DPI to assume if the screen DPI is not known.")]
	protected float m_FallbackScreenDPI; //Field offset: 0x40
	[SerializeField]
	[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
	protected float m_DefaultSpriteDPI; //Field offset: 0x44
	[SerializeField]
	[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
	protected float m_DynamicPixelsPerUnit; //Field offset: 0x48
	private Canvas m_Canvas; //Field offset: 0x50
	private float m_PrevScaleFactor; //Field offset: 0x58
	private float m_PrevReferencePixelsPerUnit; //Field offset: 0x5C
	[SerializeField]
	protected bool m_PresetInfoIsWorld; //Field offset: 0x60

	public float defaultSpriteDPI
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float dynamicPixelsPerUnit
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float fallbackScreenDPI
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float matchWidthOrHeight
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Unit physicalUnit
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float referencePixelsPerUnit
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Vector2 referenceResolution
	{
		 get { } //Length: 19
		 set { } //Length: 116
	}

	public float scaleFactor
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public ScreenMatchMode screenMatchMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ScaleMode uiScaleMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	protected CanvasScaler() { }

	private void Canvas_preWillRenderCanvases() { }

	public float get_defaultSpriteDPI() { }

	public float get_dynamicPixelsPerUnit() { }

	public float get_fallbackScreenDPI() { }

	public float get_matchWidthOrHeight() { }

	public Unit get_physicalUnit() { }

	public float get_referencePixelsPerUnit() { }

	public Vector2 get_referenceResolution() { }

	public float get_scaleFactor() { }

	public ScreenMatchMode get_screenMatchMode() { }

	public ScaleMode get_uiScaleMode() { }

	protected override void Handle() { }

	protected override void HandleConstantPhysicalSize() { }

	protected override void HandleConstantPixelSize() { }

	protected override void HandleScaleWithScreenSize() { }

	protected override void HandleWorldCanvas() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void set_defaultSpriteDPI(float value) { }

	public void set_dynamicPixelsPerUnit(float value) { }

	public void set_fallbackScreenDPI(float value) { }

	public void set_matchWidthOrHeight(float value) { }

	public void set_physicalUnit(Unit value) { }

	public void set_referencePixelsPerUnit(float value) { }

	public void set_referenceResolution(Vector2 value) { }

	public void set_scaleFactor(float value) { }

	public void set_screenMatchMode(ScreenMatchMode value) { }

	public void set_uiScaleMode(ScaleMode value) { }

	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }

	protected void SetScaleFactor(float scaleFactor) { }

}

