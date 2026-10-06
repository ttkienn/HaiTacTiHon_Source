namespace UnityEngine.UIElements;

internal class VisualTreeViewDataUpdater : BaseVisualTreeUpdater
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	private HashSet<VisualElement> m_UpdateList; //Field offset: 0x20
	private HashSet<VisualElement> m_ParentList; //Field offset: 0x28
	private uint m_Version; //Field offset: 0x30
	private uint m_LastVersion; //Field offset: 0x34

	public virtual ProfilerMarker profilerMarker
	{
		 get { } //Length: 330
	}

	private static VisualTreeViewDataUpdater() { }

	public VisualTreeViewDataUpdater() { }

	public virtual ProfilerMarker get_profilerMarker() { }

	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	private void PropagateToParents(VisualElement ve) { }

	public virtual void Update() { }

	private void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence) { }

}

