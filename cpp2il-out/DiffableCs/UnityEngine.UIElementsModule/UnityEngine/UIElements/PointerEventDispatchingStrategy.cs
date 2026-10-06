namespace UnityEngine.UIElements;

internal class PointerEventDispatchingStrategy : IEventDispatchingStrategy
{

	public PointerEventDispatchingStrategy() { }

	public override bool CanDispatchEvent(EventBase evt) { }

	public override void DispatchEvent(EventBase evt, IPanel panel) { }

	private static void SendEventToTarget(EventBase evt, IPanel panel) { }

	private static void SetBestTargetForEvent(EventBase evt, IPanel panel) { }

	private static void UpdateElementUnderPointer(EventBase evt, IPanel panel, out VisualElement elementUnderPointer) { }

}

