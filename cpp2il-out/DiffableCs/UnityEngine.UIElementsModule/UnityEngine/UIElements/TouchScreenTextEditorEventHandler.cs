namespace UnityEngine.UIElements;

internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler
{
	private IVisualElementScheduledItem m_TouchKeyboardPoller; //Field offset: 0x20
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x28
	private bool m_IsClicking; //Field offset: 0x29

	public TouchScreenTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	private void CloseTouchScreenKeyboard() { }

	private void DoPollTouchScreenKeyboard() { }

	public virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	private void OnFocusInEvent() { }

	private void OnFocusOutEvent(FocusOutEvent evt) { }

	private void OnPointerDownEvent() { }

	private void OnPointerUpEvent(PointerUpEvent evt) { }

	private void OpenTouchScreenKeyboard() { }

	private void PollTouchScreenKeyboard() { }

	private void UpdateStringPositionFromKeyboard() { }

}

