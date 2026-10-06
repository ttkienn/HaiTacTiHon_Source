namespace UnityEngine.UIElements;

internal class Panel : BaseVisualElementPanel
{
	private static ProfilerMarker s_MarkerPickAll; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static LoadResourceFunction <loadResourceFunc>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static TimeMsFunction <TimeSinceStartup>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Panel> beforeAnyRepaint; //Field offset: 0x18
	private VisualElement m_RootContainer; //Field offset: 0xA8
	private VisualTreeUpdater m_VisualTreeUpdater; //Field offset: 0xB0
	private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem; //Field offset: 0xB8
	private string m_PanelName; //Field offset: 0xC0
	private uint m_Version; //Field offset: 0xC8
	private uint m_RepaintVersion; //Field offset: 0xCC
	private uint m_HierarchyVersion; //Field offset: 0xD0
	private ProfilerMarker m_MarkerBeforeUpdate; //Field offset: 0xD8
	private ProfilerMarker m_MarkerUpdate; //Field offset: 0xE0
	private ProfilerMarker m_MarkerLayout; //Field offset: 0xE8
	private ProfilerMarker m_MarkerBindings; //Field offset: 0xF0
	private ProfilerMarker m_MarkerAnimations; //Field offset: 0xF8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventDispatcher <dispatcher>k__BackingField; //Field offset: 0x100
	private TimerEventScheduler m_Scheduler; //Field offset: 0x108
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ScriptableObject <ownerObject>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ContextType <contextType>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private SavePersistentViewData <saveViewData>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private GetViewDataDictionary <getViewDataDictionary>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FocusController <focusController>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventInterests <IMGUIEventInterests>k__BackingField; //Field offset: 0x138
	private bool m_JustReceivedFocus; //Field offset: 0x13B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <IMGUIContainersCount>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; //Field offset: 0x140
	private Shader m_StandardShader; //Field offset: 0x148
	private AtlasBase m_Atlas; //Field offset: 0x150
	private bool m_ValidatingLayout; //Field offset: 0x158

	public virtual AtlasBase atlas
	{
		 get { } //Length: 10
		 set { } //Length: 130
	}

	public virtual ContextType contextType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public virtual EventDispatcher dispatcher
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public virtual FocusController focusController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public virtual GetViewDataDictionary getViewDataDictionary
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	internal virtual uint hierarchyVersion
	{
		internal get { } //Length: 7
	}

	public virtual int IMGUIContainersCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public virtual EventInterests IMGUIEventInterests
	{
		[CompilerGenerated]
		 get { } //Length: 24
		[CompilerGenerated]
		 set { } //Length: 21
	}

	private static LoadResourceFunction loadResourceFunc
	{
		[CompilerGenerated]
		private get { } //Length: 79
	}

	internal string name
	{
		internal get { } //Length: 10
		internal set { } //Length: 43
	}

	public virtual ScriptableObject ownerObject
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public virtual IMGUIContainer rootIMGUIContainer
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual SavePersistentViewData saveViewData
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	internal virtual IScheduler scheduler
	{
		internal get { } //Length: 115
	}

	internal virtual Shader standardShader
	{
		internal get { } //Length: 10
	}

	internal virtual IStylePropertyAnimationSystem styleAnimationSystem
	{
		internal get { } //Length: 8
		internal set { } //Length: 115
	}

	public TimerEventScheduler timerEventScheduler
	{
		 get { } //Length: 115
	}

	private static TimeMsFunction TimeSinceStartup
	{
		[CompilerGenerated]
		private get { } //Length: 79
	}

	internal virtual uint version
	{
		internal get { } //Length: 7
	}

	public virtual VisualElement visualTree
	{
		 get { } //Length: 10
	}

	private static Panel() { }

	public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher) { }

	[CompilerGenerated]
	internal static Vector2Int <Pick>g__PixelOf|101_0(Vector2 p) { }

	public virtual void ApplyStyles() { }

	internal void Blur() { }

	private void CreateMarkers() { }

	internal static long DefaultTimeSinceStartupMs() { }

	protected virtual void Dispose(bool disposing) { }

	internal void Focus() { }

	public virtual AtlasBase get_atlas() { }

	[CompilerGenerated]
	public virtual ContextType get_contextType() { }

	[CompilerGenerated]
	public virtual EventDispatcher get_dispatcher() { }

	[CompilerGenerated]
	public virtual FocusController get_focusController() { }

	[CompilerGenerated]
	public virtual GetViewDataDictionary get_getViewDataDictionary() { }

	internal virtual uint get_hierarchyVersion() { }

	[CompilerGenerated]
	public virtual int get_IMGUIContainersCount() { }

	[CompilerGenerated]
	public virtual EventInterests get_IMGUIEventInterests() { }

	[CompilerGenerated]
	private static LoadResourceFunction get_loadResourceFunc() { }

	internal string get_name() { }

	[CompilerGenerated]
	public virtual ScriptableObject get_ownerObject() { }

	[CompilerGenerated]
	public virtual IMGUIContainer get_rootIMGUIContainer() { }

	[CompilerGenerated]
	public virtual SavePersistentViewData get_saveViewData() { }

	internal virtual IScheduler get_scheduler() { }

	internal virtual Shader get_standardShader() { }

	internal virtual IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	public TimerEventScheduler get_timerEventScheduler() { }

	[CompilerGenerated]
	private static TimeMsFunction get_TimeSinceStartup() { }

	internal virtual uint get_version() { }

	public virtual VisualElement get_visualTree() { }

	internal virtual IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	internal static object LoadResource(string pathName, Type type, float dpiScaling) { }

	internal virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false) { }

	public virtual VisualElement Pick(Vector2 point) { }

	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false) { }

	public virtual VisualElement PickAll(Vector2 point, List<VisualElement> picked) { }

	public virtual void Repaint(Event e) { }

	public virtual void set_atlas(AtlasBase value) { }

	[CompilerGenerated]
	protected virtual void set_contextType(ContextType value) { }

	[CompilerGenerated]
	public virtual void set_dispatcher(EventDispatcher value) { }

	[CompilerGenerated]
	public virtual void set_focusController(FocusController value) { }

	[CompilerGenerated]
	public virtual void set_IMGUIContainersCount(int value) { }

	[CompilerGenerated]
	public virtual void set_IMGUIEventInterests(EventInterests value) { }

	internal void set_name(string value) { }

	[CompilerGenerated]
	protected virtual void set_ownerObject(ScriptableObject value) { }

	internal virtual void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	public static long TimeSinceStartupMs() { }

	public virtual void UpdateAnimations() { }

	public virtual void UpdateBindings() { }

	private void UpdateForRepaint() { }

	public virtual void ValidateFocus() { }

	public virtual void ValidateLayout() { }

}

