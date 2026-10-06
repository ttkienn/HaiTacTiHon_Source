namespace UnityEngine.UIElements;

public abstract class EventBase : IDisposable
{
	[Flags]
	public enum EventPropagation
	{
		None = 0,
		Bubbles = 1,
		TricklesDown = 2,
		Cancellable = 4,
		SkipDisabledElements = 8,
		IgnoreCompositeRoots = 16,
	}

	[Flags]
	private enum LifeCycleStatus
	{
		None = 0,
		PropagationStopped = 1,
		ImmediatePropagationStopped = 2,
		DefaultPrevented = 4,
		Dispatching = 8,
		Pooled = 16,
		IMGUIEventIsValid = 32,
		StopDispatch = 64,
		PropagateToIMGUI = 128,
		Dispatched = 512,
		Processed = 1024,
		ProcessedByFocusController = 2048,
	}

	private static long s_LastTypeId; //Field offset: 0x0
	private static ulong s_NextEventId; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly EventCategory <eventCategory>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private long <timestamp>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ulong <eventId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ulong <triggerEventId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventPropagation <propagation>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PropagationPaths <path>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LifeCycleStatus <lifeCycleStatus>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IEventHandler <leafTarget>k__BackingField; //Field offset: 0x48
	private IEventHandler m_Target; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly List<IEventHandler> <skipElements>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PropagationPhase <propagationPhase>k__BackingField; //Field offset: 0x60
	private IEventHandler m_CurrentTarget; //Field offset: 0x68
	private Event m_ImguiEvent; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <originalMousePosition>k__BackingField; //Field offset: 0x78

	public bool bubbles
	{
		 get { } //Length: 10
	}

	internal bool bubblesOrTricklesDown
	{
		internal get { } //Length: 8
	}

	public internal override IEventHandler currentTarget
	{
		 get { } //Length: 7
		internal set { } //Length: 301
	}

	public internal bool dispatch
	{
		 get { } //Length: 10
		internal set { } //Length: 25
	}

	private bool dispatched
	{
		private get { } //Length: 13
		private set { } //Length: 27
	}

	internal EventCategory eventCategory
	{
		[CompilerGenerated]
		internal get { } //Length: 191
	}

	internal ulong eventId
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public override long eventTypeId
	{
		 get { } //Length: 8
	}

	internal bool ignoreCompositeRoots
	{
		internal get { } //Length: 10
		internal set { } //Length: 25
	}

	public Event imguiEvent
	{
		 get { } //Length: 16
		 set { } //Length: 199
	}

	private bool imguiEventIsValid
	{
		private get { } //Length: 10
		private set { } //Length: 25
	}

	public private bool isDefaultPrevented
	{
		 get { } //Length: 10
		private set { } //Length: 25
	}

	public private bool isImmediatePropagationStopped
	{
		 get { } //Length: 10
		private set { } //Length: 25
	}

	public private bool isPropagationStopped
	{
		 get { } //Length: 10
		private set { } //Length: 25
	}

	internal IEventHandler leafTarget
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	private LifeCycleStatus lifeCycleStatus
	{
		[CompilerGenerated]
		private get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Vector2 originalMousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	internal PropagationPaths path
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	protected bool pooled
	{
		 get { } //Length: 10
		 set { } //Length: 25
	}

	internal bool processed
	{
		internal get { } //Length: 13
		private set { } //Length: 27
	}

	internal bool processedByFocusController
	{
		internal get { } //Length: 13
		internal set { } //Length: 27
	}

	internal bool propagateToIMGUI
	{
		internal get { } //Length: 13
		internal set { } //Length: 27
	}

	internal EventPropagation propagation
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public internal PropagationPhase propagationPhase
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal bool skipDisabledElements
	{
		internal get { } //Length: 10
		internal set { } //Length: 25
	}

	internal List<IEventHandler> skipElements
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal bool stopDispatch
	{
		internal get { } //Length: 10
		internal set { } //Length: 25
	}

	public IEventHandler target
	{
		 get { } //Length: 7
		 set { } //Length: 63
	}

	public private long timestamp
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public bool tricklesDown
	{
		 get { } //Length: 10
	}

	private ulong triggerEventId
	{
		[CompilerGenerated]
		private set { } //Length: 5
	}

	internal EventBase(EventCategory category) { }

	protected EventBase() { }

	internal abstract void Acquire() { }

	public abstract void Dispose() { }

	public bool get_bubbles() { }

	internal bool get_bubblesOrTricklesDown() { }

	public override IEventHandler get_currentTarget() { }

	public bool get_dispatch() { }

	private bool get_dispatched() { }

	[CompilerGenerated]
	internal EventCategory get_eventCategory() { }

	[CompilerGenerated]
	internal ulong get_eventId() { }

	public override long get_eventTypeId() { }

	internal bool get_ignoreCompositeRoots() { }

	public Event get_imguiEvent() { }

	private bool get_imguiEventIsValid() { }

	public bool get_isDefaultPrevented() { }

	public bool get_isImmediatePropagationStopped() { }

	public bool get_isPropagationStopped() { }

	[CompilerGenerated]
	internal IEventHandler get_leafTarget() { }

	[CompilerGenerated]
	private LifeCycleStatus get_lifeCycleStatus() { }

	[CompilerGenerated]
	public Vector2 get_originalMousePosition() { }

	[CompilerGenerated]
	internal PropagationPaths get_path() { }

	protected bool get_pooled() { }

	internal bool get_processed() { }

	internal bool get_processedByFocusController() { }

	internal bool get_propagateToIMGUI() { }

	[CompilerGenerated]
	internal EventPropagation get_propagation() { }

	[CompilerGenerated]
	public PropagationPhase get_propagationPhase() { }

	internal bool get_skipDisabledElements() { }

	[CompilerGenerated]
	internal List<IEventHandler> get_skipElements() { }

	internal bool get_stopDispatch() { }

	public IEventHandler get_target() { }

	[CompilerGenerated]
	public long get_timestamp() { }

	public bool get_tricklesDown() { }

	protected override void Init() { }

	private void LocalInit() { }

	internal void MarkReceivedByDispatcher() { }

	protected private override void PostDispatch(IPanel panel) { }

	[Obsolete("Override PostDispatch(IPanel panel) instead.")]
	protected override void PostDispatch() { }

	[Obsolete("Override PreDispatch(IPanel panel) instead.")]
	protected override void PreDispatch() { }

	protected private override void PreDispatch(IPanel panel) { }

	public void PreventDefault() { }

	protected static long RegisterEventType() { }

	internal override void set_currentTarget(IEventHandler value) { }

	internal void set_dispatch(bool value) { }

	private void set_dispatched(bool value) { }

	[CompilerGenerated]
	private void set_eventId(ulong value) { }

	internal void set_ignoreCompositeRoots(bool value) { }

	protected void set_imguiEvent(Event value) { }

	private void set_imguiEventIsValid(bool value) { }

	private void set_isDefaultPrevented(bool value) { }

	private void set_isImmediatePropagationStopped(bool value) { }

	private void set_isPropagationStopped(bool value) { }

	[CompilerGenerated]
	private void set_leafTarget(IEventHandler value) { }

	[CompilerGenerated]
	private void set_lifeCycleStatus(LifeCycleStatus value) { }

	[CompilerGenerated]
	private void set_originalMousePosition(Vector2 value) { }

	[CompilerGenerated]
	internal void set_path(PropagationPaths value) { }

	protected void set_pooled(bool value) { }

	private void set_processed(bool value) { }

	internal void set_processedByFocusController(bool value) { }

	internal void set_propagateToIMGUI(bool value) { }

	[CompilerGenerated]
	internal void set_propagation(EventPropagation value) { }

	[CompilerGenerated]
	internal void set_propagationPhase(PropagationPhase value) { }

	internal void set_skipDisabledElements(bool value) { }

	internal void set_stopDispatch(bool value) { }

	public void set_target(IEventHandler value) { }

	[CompilerGenerated]
	private void set_timestamp(long value) { }

	[CompilerGenerated]
	private void set_triggerEventId(ulong value) { }

	internal void SetTriggerEventId(ulong id) { }

	internal bool Skip(IEventHandler h) { }

	public void StopImmediatePropagation() { }

	public void StopPropagation() { }

}

