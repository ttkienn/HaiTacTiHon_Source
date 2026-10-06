namespace UnityEngine.UIElements;

internal class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	private uint m_Version; //Field offset: 0x20
	private uint m_LastVersion; //Field offset: 0x24

	public virtual ProfilerMarker profilerMarker
	{
		 get { } //Length: 79
	}

	private static VisualTreeHierarchyFlagsUpdater() { }

	public VisualTreeHierarchyFlagsUpdater() { }

	private static void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	private static void DirtyHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags) { }

	public virtual ProfilerMarker get_profilerMarker() { }

	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	public virtual void Update() { }

}

