namespace UnityEngine.UIElements;

[HelpURL("UIE-Runtime-Panel-Settings")]
public class PanelSettings : ScriptableObject
{
	private class RuntimePanelAccess
	{
		private readonly PanelSettings m_Settings; //Field offset: 0x10
		private BaseRuntimePanel m_RuntimePanel; //Field offset: 0x18

		internal bool isInitialized
		{
			internal get { } //Length: 9
		}

		internal BaseRuntimePanel panel
		{
			internal get { } //Length: 672
		}

		internal RuntimePanelAccess(PanelSettings settings) { }

		private BaseRuntimePanel CreateRelatedRuntimePanel() { }

		internal void DisposePanel() { }

		private void DisposeRelatedPanel() { }

		internal bool get_isInitialized() { }

		internal BaseRuntimePanel get_panel() { }

		internal void MarkPotentiallyEmpty() { }

		internal void SetSortingPriority() { }

		internal void SetTargetDisplay() { }

		internal void SetTargetTexture() { }

	}

	private const int k_DefaultSortingOrder = 0; //Field offset: 0x0
	private const float k_DefaultScaleValue = 1; //Field offset: 0x0
	internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset"; //Field offset: 0x0
	private const float DefaultDpi = 96; //Field offset: 0x0
	[SerializeField]
	private ThemeStyleSheet themeUss; //Field offset: 0x18
	[SerializeField]
	private RenderTexture m_TargetTexture; //Field offset: 0x20
	[SerializeField]
	private PanelScaleMode m_ScaleMode; //Field offset: 0x28
	[SerializeField]
	private float m_ReferenceSpritePixelsPerUnit; //Field offset: 0x2C
	[SerializeField]
	private float m_Scale; //Field offset: 0x30
	[SerializeField]
	private float m_ReferenceDpi; //Field offset: 0x34
	[SerializeField]
	private float m_FallbackDpi; //Field offset: 0x38
	[SerializeField]
	private Vector2Int m_ReferenceResolution; //Field offset: 0x3C
	[SerializeField]
	private PanelScreenMatchMode m_ScreenMatchMode; //Field offset: 0x44
	[Range(0, 1)]
	[SerializeField]
	private float m_Match; //Field offset: 0x48
	[SerializeField]
	private float m_SortingOrder; //Field offset: 0x4C
	[SerializeField]
	private int m_TargetDisplay; //Field offset: 0x50
	[SerializeField]
	private bool m_ClearDepthStencil; //Field offset: 0x54
	[SerializeField]
	private bool m_ClearColor; //Field offset: 0x55
	[SerializeField]
	private Color m_ColorClearValue; //Field offset: 0x58
	private RuntimePanelAccess m_PanelAccess; //Field offset: 0x68
	internal UIDocumentList m_AttachedUIDocumentsList; //Field offset: 0x70
	[HideInInspector]
	[SerializeField]
	private DynamicAtlasSettings m_DynamicAtlasSettings; //Field offset: 0x78
	[HideInInspector]
	[SerializeField]
	private Shader m_AtlasBlitShader; //Field offset: 0x80
	[HideInInspector]
	[SerializeField]
	private Shader m_RuntimeShader; //Field offset: 0x88
	[HideInInspector]
	[SerializeField]
	private Shader m_RuntimeWorldShader; //Field offset: 0x90
	[SerializeField]
	public PanelTextSettings textSettings; //Field offset: 0x98
	private Rect m_TargetRect; //Field offset: 0xA0
	private float m_ResolvedScale; //Field offset: 0xB0
	private StyleSheet m_OldThemeUss; //Field offset: 0xB8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <ScreenDPI>k__BackingField; //Field offset: 0xC0
	private Func<Vector2, Vector2> m_AssignedScreenToPanel; //Field offset: 0xC8

	public bool clearColor
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool clearDepthStencil
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Color colorClearValue
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float depthClearValue
	{
		 get { } //Length: 9
	}

	public DynamicAtlasSettings dynamicAtlasSettings
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public float fallbackDpi
	{
		 get { } //Length: 6
		 set { } //Length: 41
	}

	internal bool isInitialized
	{
		internal get { } //Length: 19
	}

	public float match
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	internal BaseRuntimePanel panel
	{
		internal get { } //Length: 29
	}

	public float referenceDpi
	{
		 get { } //Length: 6
		 set { } //Length: 41
	}

	public Vector2Int referenceResolution
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public float referenceSpritePixelsPerUnit
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public float scale
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public PanelScaleMode scaleMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	private float ScreenDPI
	{
		[CompilerGenerated]
		private get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public PanelScreenMatchMode screenMatchMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float sortingOrder
	{
		 get { } //Length: 6
		 set { } //Length: 65
	}

	public int targetDisplay
	{
		 get { } //Length: 4
		 set { } //Length: 55
	}

	public RenderTexture targetTexture
	{
		 get { } //Length: 5
		 set { } //Length: 90
	}

	public ThemeStyleSheet themeStyleSheet
	{
		 get { } //Length: 7
		 set { } //Length: 40
	}

	internal VisualElement visualTree
	{
		internal get { } //Length: 57
	}

	private PanelSettings() { }

	internal void ApplyPanelSettings() { }

	internal void ApplySortingOrder() { }

	private void ApplyThemeStyleSheet(VisualElement root = null) { }

	internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument) { }

	internal void DetachUIDocument(UIDocument uiDocument) { }

	internal void DisposePanel() { }

	public bool get_clearColor() { }

	public bool get_clearDepthStencil() { }

	public Color get_colorClearValue() { }

	public float get_depthClearValue() { }

	public DynamicAtlasSettings get_dynamicAtlasSettings() { }

	public float get_fallbackDpi() { }

	internal bool get_isInitialized() { }

	public float get_match() { }

	internal BaseRuntimePanel get_panel() { }

	public float get_referenceDpi() { }

	public Vector2Int get_referenceResolution() { }

	public float get_referenceSpritePixelsPerUnit() { }

	public float get_scale() { }

	public PanelScaleMode get_scaleMode() { }

	[CompilerGenerated]
	private float get_ScreenDPI() { }

	public PanelScreenMatchMode get_screenMatchMode() { }

	public float get_sortingOrder() { }

	public int get_targetDisplay() { }

	public RenderTexture get_targetTexture() { }

	public ThemeStyleSheet get_themeStyleSheet() { }

	internal VisualElement get_visualTree() { }

	internal Rect GetDisplayRect() { }

	private void InitializeShaders() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Reset() { }

	internal float ResolveScale(Rect targetRect, float screenDpi) { }

	public void set_clearColor(bool value) { }

	public void set_clearDepthStencil(bool value) { }

	public void set_colorClearValue(Color value) { }

	public void set_dynamicAtlasSettings(DynamicAtlasSettings value) { }

	public void set_fallbackDpi(float value) { }

	public void set_match(float value) { }

	public void set_referenceDpi(float value) { }

	public void set_referenceResolution(Vector2Int value) { }

	public void set_referenceSpritePixelsPerUnit(float value) { }

	public void set_scale(float value) { }

	public void set_scaleMode(PanelScaleMode value) { }

	[CompilerGenerated]
	private void set_ScreenDPI(float value) { }

	public void set_screenMatchMode(PanelScreenMatchMode value) { }

	public void set_sortingOrder(float value) { }

	public void set_targetDisplay(int value) { }

	public void set_targetTexture(RenderTexture value) { }

	public void set_themeStyleSheet(ThemeStyleSheet value) { }

	public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screentoPanelSpaceFunction) { }

	internal void UpdateScreenDPI() { }

}

