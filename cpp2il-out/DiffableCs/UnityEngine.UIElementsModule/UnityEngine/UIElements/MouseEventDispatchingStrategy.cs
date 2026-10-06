namespace UnityEngine.UIElements;

internal class MouseEventDispatchingStrategy : IEventDispatchingStrategy
{

	public MouseEventDispatchingStrategy() { }

	public override bool CanDispatchEvent(EventBase evt) { }

	public override void DispatchEvent(EventBase evt, IPanel iPanel) { }

	private static bool IsDone(EventBase evt) { }

	private static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel) { }

	private static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel) { }

	private static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel) { }

	private static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel) { }

	private static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, out VisualElement elementUnderMouse) { }

}

