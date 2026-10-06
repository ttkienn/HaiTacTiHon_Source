namespace UnityEngine.UIElements;

public class ContextualMenuManipulator : MouseManipulator
{
	private Action<ContextualMenuPopulateEvent> m_MenuBuilder; //Field offset: 0x30

	public ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder) { }

	private void DoDisplayMenu(EventBase evt) { }

	private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt) { }

	private void OnKeyUpEvent(KeyUpEvent evt) { }

	private void OnMouseDownEventOSX(MouseDownEvent evt) { }

	private void OnMouseUpDownEvent(IMouseEvent evt) { }

	private void OnMouseUpEventOSX(MouseUpEvent evt) { }

	protected virtual void RegisterCallbacksOnTarget() { }

	protected virtual void UnregisterCallbacksFromTarget() { }

}

