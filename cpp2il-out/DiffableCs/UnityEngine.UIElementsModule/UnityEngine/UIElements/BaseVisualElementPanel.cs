namespace UnityEngine.UIElements;

internal abstract class BaseVisualElementPanel : IPanel, IDisposable, IGroupBox
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<BaseVisualElementPanel> panelDisposed; //Field offset: 0x10
	private UIElementsBridge m_UIElementsBridge; //Field offset: 0x18
	private float m_Scale; //Field offset: 0x20
	internal YogaConfig yogaConfig; //Field offset: 0x28
	private float m_PixelsPerPoint; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <referenceSpritePixelsPerUnit>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PanelClearSettings <clearSettings>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <duringLayoutPhase>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RepaintData <repaintData>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ICursorManager <cursorManager>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ContextualMenuManager <contextualMenuManager>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x68
	internal ElementUnderPointer m_TopElementUnderPointers; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action standardShaderChanged; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action standardWorldSpaceShaderChanged; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action atlasChanged; //Field offset: 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Material> updateMaterial; //Field offset: 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private HierarchyEvent hierarchyChanged; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IPanel> beforeUpdate; //Field offset: 0xA0

	internal event Action atlasChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 162
		[CompilerGenerated]
		internal remove { } //Length: 162
	}

	internal event HierarchyEvent hierarchyChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 162
		[CompilerGenerated]
		internal remove { } //Length: 162
	}

	internal event Action<BaseVisualElementPanel> panelDisposed
	{
		[CompilerGenerated]
		internal add { } //Length: 172
		[CompilerGenerated]
		internal remove { } //Length: 172
	}

	internal event Action standardShaderChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 158
		[CompilerGenerated]
		internal remove { } //Length: 158
	}

	internal event Action standardWorldSpaceShaderChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 162
		[CompilerGenerated]
		internal remove { } //Length: 162
	}

	public abstract AtlasBase atlas
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	internal PanelClearSettings clearSettings
	{
		[CompilerGenerated]
		internal get { } //Length: 17
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public abstract ContextType contextType
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public internal override ContextualMenuManager contextualMenuManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	internal override ICursorManager cursorManager
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public abstract EventDispatcher dispatcher
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	internal bool disposed
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal bool duringLayoutPhase
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public abstract FocusController focusController
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract GetViewDataDictionary getViewDataDictionary
	{
		 get { } //Length: 0
	}

	internal abstract uint hierarchyVersion
	{
		internal get { } //Length: 0
	}

	public abstract int IMGUIContainersCount
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract EventInterests IMGUIEventInterests
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract ScriptableObject ownerObject
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	internal float pixelsPerPoint
	{
		internal set { } //Length: 168
	}

	public float referenceSpritePixelsPerUnit
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	internal override RepaintData repaintData
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public abstract IMGUIContainer rootIMGUIContainer
	{
		 get { } //Length: 0
	}

	public abstract SavePersistentViewData saveViewData
	{
		 get { } //Length: 0
	}

	internal float scale
	{
		internal get { } //Length: 8
		internal set { } //Length: 168
	}

	public float scaledPixelsPerPoint
	{
		 get { } //Length: 13
	}

	internal abstract IScheduler scheduler
	{
		internal get { } //Length: 0
	}

	internal abstract Shader standardShader
	{
		internal get { } //Length: 0
	}

	internal override Shader standardWorldSpaceShader
	{
		internal get { } //Length: 5
	}

	internal abstract IStylePropertyAnimationSystem styleAnimationSystem
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	internal UIElementsBridge uiElementsBridge
	{
		internal get { } //Length: 102
	}

	internal abstract uint version
	{
		internal get { } //Length: 0
	}

	public abstract VisualElement visualTree
	{
		 get { } //Length: 0
	}

	protected BaseVisualElementPanel() { }

	[CompilerGenerated]
	internal void add_atlasChanged(Action value) { }

	[CompilerGenerated]
	internal void add_hierarchyChanged(HierarchyEvent value) { }

	[CompilerGenerated]
	internal void add_panelDisposed(Action<BaseVisualElementPanel> value) { }

	[CompilerGenerated]
	internal void add_standardShaderChanged(Action value) { }

	[CompilerGenerated]
	internal void add_standardWorldSpaceShaderChanged(Action value) { }

	public abstract void ApplyStyles() { }

	internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent) { }

	internal void CommitElementUnderPointers() { }

	internal override IGenericMenu CreateMenu() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public abstract AtlasBase get_atlas() { }

	[CompilerGenerated]
	internal PanelClearSettings get_clearSettings() { }

	public abstract ContextType get_contextType() { }

	[CompilerGenerated]
	public override ContextualMenuManager get_contextualMenuManager() { }

	[CompilerGenerated]
	internal override ICursorManager get_cursorManager() { }

	public abstract EventDispatcher get_dispatcher() { }

	[CompilerGenerated]
	internal bool get_disposed() { }

	[CompilerGenerated]
	internal bool get_duringLayoutPhase() { }

	public abstract FocusController get_focusController() { }

	public abstract GetViewDataDictionary get_getViewDataDictionary() { }

	internal abstract uint get_hierarchyVersion() { }

	public abstract int get_IMGUIContainersCount() { }

	public abstract EventInterests get_IMGUIEventInterests() { }

	public abstract ScriptableObject get_ownerObject() { }

	[CompilerGenerated]
	public float get_referenceSpritePixelsPerUnit() { }

	[CompilerGenerated]
	internal override RepaintData get_repaintData() { }

	public abstract IMGUIContainer get_rootIMGUIContainer() { }

	public abstract SavePersistentViewData get_saveViewData() { }

	internal float get_scale() { }

	public float get_scaledPixelsPerPoint() { }

	internal abstract IScheduler get_scheduler() { }

	internal abstract Shader get_standardShader() { }

	internal override Shader get_standardWorldSpaceShader() { }

	internal abstract IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	internal UIElementsBridge get_uiElementsBridge() { }

	internal abstract uint get_version() { }

	public abstract VisualElement get_visualTree() { }

	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	protected void InvokeAtlasChanged() { }

	internal void InvokeBeforeUpdate() { }

	internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) { }

	internal void InvokeUpdateMaterial(Material mat) { }

	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag) { }

	public abstract VisualElement Pick(Vector2 point) { }

	public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked) { }

	internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent) { }

	[CompilerGenerated]
	internal void remove_atlasChanged(Action value) { }

	[CompilerGenerated]
	internal void remove_hierarchyChanged(HierarchyEvent value) { }

	[CompilerGenerated]
	internal void remove_panelDisposed(Action<BaseVisualElementPanel> value) { }

	[CompilerGenerated]
	internal void remove_standardShaderChanged(Action value) { }

	[CompilerGenerated]
	internal void remove_standardWorldSpaceShaderChanged(Action value) { }

	public abstract void Repaint(Event e) { }

	internal void SendEvent(EventBase e, DispatchMode dispatchMode = 1) { }

	public abstract void set_atlas(AtlasBase value) { }

	[CompilerGenerated]
	internal void set_clearSettings(PanelClearSettings value) { }

	protected abstract void set_contextType(ContextType value) { }

	[CompilerGenerated]
	internal void set_contextualMenuManager(ContextualMenuManager value) { }

	[CompilerGenerated]
	internal override void set_cursorManager(ICursorManager value) { }

	public abstract void set_dispatcher(EventDispatcher value) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	[CompilerGenerated]
	internal void set_duringLayoutPhase(bool value) { }

	public abstract void set_focusController(FocusController value) { }

	public abstract void set_IMGUIContainersCount(int value) { }

	public abstract void set_IMGUIEventInterests(EventInterests value) { }

	protected abstract void set_ownerObject(ScriptableObject value) { }

	internal void set_pixelsPerPoint(float value) { }

	[CompilerGenerated]
	public void set_referenceSpritePixelsPerUnit(float value) { }

	[CompilerGenerated]
	internal override void set_repaintData(RepaintData value) { }

	internal void set_scale(float value) { }

	internal abstract void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	public override void Update() { }

	public abstract void UpdateAnimations() { }

	public abstract void UpdateBindings() { }

	internal void UpdateElementUnderPointers() { }

	public abstract void ValidateFocus() { }

	public abstract void ValidateLayout() { }

}

