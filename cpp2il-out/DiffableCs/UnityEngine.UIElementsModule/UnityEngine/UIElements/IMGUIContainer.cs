namespace UnityEngine.UIElements;

public class IMGUIContainer : VisualElement, IDisposable
{
	private struct GUIGlobals
	{
		public Matrix4x4 matrix; //Field offset: 0x0
		public Color color; //Field offset: 0x40
		public Color contentColor; //Field offset: 0x50
		public Color backgroundColor; //Field offset: 0x60
		public bool enabled; //Field offset: 0x70
		public bool changed; //Field offset: 0x71
		public int displayIndex; //Field offset: 0x74

	}

	internal class UxmlFactory : UxmlFactory<IMGUIContainer, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{

		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	internal static readonly string ussFoldoutChildDepthClassName; //Field offset: 0x8
	internal static readonly List<String> ussFoldoutChildDepthClassNames; //Field offset: 0x10
	private static readonly ProfilerMarker k_OnGUIMarker; //Field offset: 0x18
	private static readonly ProfilerMarker k_ImmediateCallbackMarker; //Field offset: 0x20
	private static Event s_DefaultMeasureEvent; //Field offset: 0x28
	private static Event s_MeasureEvent; //Field offset: 0x30
	private static Event s_CurrentEvent; //Field offset: 0x38
	private Action m_OnGUIHandler; //Field offset: 0x3C8
	private ObjectGUIState m_ObjectGUIState; //Field offset: 0x3D0
	internal bool useOwnerObjectGUIState; //Field offset: 0x3D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Rect <lastWorldClip>k__BackingField; //Field offset: 0x3DC
	private bool m_CullingEnabled; //Field offset: 0x3EC
	private bool m_IsFocusDelegated; //Field offset: 0x3ED
	private bool m_RefreshCachedLayout; //Field offset: 0x3EE
	private LayoutCache m_Cache; //Field offset: 0x3F0
	private Rect m_CachedClippingRect; //Field offset: 0x3F8
	private Matrix4x4 m_CachedTransform; //Field offset: 0x408
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ContextType <contextType>k__BackingField; //Field offset: 0x448
	private bool lostFocus; //Field offset: 0x44C
	private bool receivedFocus; //Field offset: 0x44D
	private FocusChangeDirection focusChangeDirection; //Field offset: 0x450
	private bool hasFocusableControls; //Field offset: 0x458
	private int newKeyboardFocusControlID; //Field offset: 0x45C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; //Field offset: 0x460
	private GUIGlobals m_GUIGlobals; //Field offset: 0x464

	private LayoutCache cache
	{
		private get { } //Length: 123
	}

	public virtual bool canGrabFocus
	{
		 get { } //Length: 41
	}

	public ContextType contextType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool cullingEnabled
	{
		 get { } //Length: 10
	}

	internal bool focusOnlyIfHasFocusableControls
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	internal ObjectGUIState guiState
	{
		internal get { } //Length: 168
	}

	internal Rect lastWorldClip
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 11
	}

	private float layoutMeasuredHeight
	{
		private get { } //Length: 44
	}

	private float layoutMeasuredWidth
	{
		private get { } //Length: 44
	}

	public Action onGUIHandler
	{
		 get { } //Length: 10
		 set { } //Length: 100
	}

	private static IMGUIContainer() { }

	public IMGUIContainer(Action onGUIHandler) { }

	public IMGUIContainer() { }

	[CompilerGenerated]
	private void <DoOnGUI>b__56_0() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposeManaged) { }

	private void DoIMGUIRepaint() { }

	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(BlurEvent), typeof(FocusEvent), typeof(DetachFromPanelEvent), typeof(AttachToPanelEvent)}])]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	private LayoutCache get_cache() { }

	public virtual bool get_canGrabFocus() { }

	[CompilerGenerated]
	public ContextType get_contextType() { }

	public bool get_cullingEnabled() { }

	[CompilerGenerated]
	internal bool get_focusOnlyIfHasFocusableControls() { }

	internal ObjectGUIState get_guiState() { }

	[CompilerGenerated]
	internal Rect get_lastWorldClip() { }

	private float get_layoutMeasuredHeight() { }

	private float get_layoutMeasuredWidth() { }

	public Action get_onGUIHandler() { }

	private Rect GetCurrentClipRect() { }

	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	private bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	private bool IsContainerCapturingTheMouse() { }

	private static bool IsDockAreaMouseUp(EventBase evt) { }

	private bool IsEventInsideLocalWindow(EventBase evt) { }

	private bool IsLocalEvent(EventBase evt) { }

	public void MarkDirtyLayout() { }

	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	internal void ProcessEvent(EventBase evt) { }

	private void RestoreGlobals() { }

	private void SaveGlobals() { }

	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true, bool verifyBounds = true) { }

	private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	[CompilerGenerated]
	public void set_contextType(ContextType value) { }

	[CompilerGenerated]
	internal void set_lastWorldClip(Rect value) { }

	public void set_onGUIHandler(Action value) { }

	private void SetFoldoutDepthClass() { }

	private bool VerifyBounds(EventBase evt) { }

}

