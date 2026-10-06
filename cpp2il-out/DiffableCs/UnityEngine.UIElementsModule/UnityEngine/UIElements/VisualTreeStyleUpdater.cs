namespace UnityEngine.UIElements;

internal class VisualTreeStyleUpdater : BaseVisualTreeUpdater
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	private HashSet<VisualElement> m_ApplyStyleUpdateList; //Field offset: 0x20
	private HashSet<VisualElement> m_TransitionPropertyUpdateList; //Field offset: 0x28
	private bool m_IsApplyingStyles; //Field offset: 0x30
	private uint m_Version; //Field offset: 0x34
	private uint m_LastVersion; //Field offset: 0x38
	private VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x48

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public virtual ProfilerMarker profilerMarker
	{
		 get { } //Length: 79
	}

	private static VisualTreeStyleUpdater() { }

	public VisualTreeStyleUpdater() { }

	private void ApplyStyles() { }

	protected virtual void Dispose(bool disposing) { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	public virtual ProfilerMarker get_profilerMarker() { }

	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	public virtual void Update() { }

}

