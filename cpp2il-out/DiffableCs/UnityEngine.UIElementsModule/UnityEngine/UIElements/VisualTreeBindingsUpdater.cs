namespace UnityEngine.UIElements;

internal class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
{
	private static readonly PropertyName s_BindingRequestObjectVEPropertyName; //Field offset: 0x0
	private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName; //Field offset: 0x4
	private static readonly string s_Description; //Field offset: 0x8
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x10
	private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker; //Field offset: 0x18
	private static ProfilerMarker s_MarkerUpdate; //Field offset: 0x20
	private static ProfilerMarker s_MarkerPoll; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <disableBindingsThrottling>k__BackingField; //Field offset: 0x30
	private readonly HashSet<VisualElement> m_ElementsWithBindings; //Field offset: 0x38
	private readonly HashSet<VisualElement> m_ElementsToAdd; //Field offset: 0x40
	private readonly HashSet<VisualElement> m_ElementsToRemove; //Field offset: 0x48
	private long m_LastUpdateTime; //Field offset: 0x50
	private HashSet<VisualElement> m_ElementsToBind; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Dictionary<Object, Object> <temporaryObjectCache>k__BackingField; //Field offset: 0x60
	private List<IBinding> updatedBindings; //Field offset: 0x68

	public static bool disableBindingsThrottling
	{
		[CompilerGenerated]
		 get { } //Length: 79
	}

	public virtual ProfilerMarker profilerMarker
	{
		 get { } //Length: 79
	}

	public Dictionary<Object, Object> temporaryObjectCache
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static VisualTreeBindingsUpdater() { }

	public VisualTreeBindingsUpdater() { }

	private static long CurrentTime() { }

	[CompilerGenerated]
	public static bool get_disableBindingsThrottling() { }

	public virtual ProfilerMarker get_profilerMarker() { }

	[CompilerGenerated]
	public Dictionary<Object, Object> get_temporaryObjectCache() { }

	public static IBinding GetAdditionalBinding(VisualElement ve) { }

	private IBinding GetBindingObjectFromElement(VisualElement ve) { }

	protected virtual void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	public void PerformTrackingOperations() { }

	private void StartTracking(VisualElement ve) { }

	private void StartTrackingRecursive(VisualElement ve) { }

	private void StopTracking(VisualElement ve) { }

	private void StopTrackingRecursive(VisualElement ve) { }

	public virtual void Update() { }

	private void UpdateBindings() { }

}

