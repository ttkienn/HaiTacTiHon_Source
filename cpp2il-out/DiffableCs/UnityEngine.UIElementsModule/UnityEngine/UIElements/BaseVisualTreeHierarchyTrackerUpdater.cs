namespace UnityEngine.UIElements;

internal abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
{
	private enum State
	{
		Waiting = 0,
		TrackingAddOrMove = 1,
		TrackingRemove = 2,
	}

	private State m_State; //Field offset: 0x20
	private VisualElement m_CurrentChangeElement; //Field offset: 0x28
	private VisualElement m_CurrentChangeParent; //Field offset: 0x30

	protected BaseVisualTreeHierarchyTrackerUpdater() { }

	protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	private void ProcessAddOrMove(VisualElement ve) { }

	private void ProcessNewChange(VisualElement ve) { }

	private void ProcessRemove(VisualElement ve) { }

	public virtual void Update() { }

}

