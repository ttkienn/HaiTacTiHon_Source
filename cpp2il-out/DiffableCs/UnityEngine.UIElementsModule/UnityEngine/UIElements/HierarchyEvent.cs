namespace UnityEngine.UIElements;

internal sealed class HierarchyEvent : MulticastDelegate
{

	public HierarchyEvent(object object, IntPtr method) { }

	public override void Invoke(VisualElement ve, HierarchyChangeType changeType) { }

}

