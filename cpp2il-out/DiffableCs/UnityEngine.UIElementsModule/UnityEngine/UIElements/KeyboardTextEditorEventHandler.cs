namespace UnityEngine.UIElements;

internal class KeyboardTextEditorEventHandler : TextEditorEventHandler
{
	private readonly Event m_ImguiEvent; //Field offset: 0x20
	internal bool m_Changed; //Field offset: 0x28

	public KeyboardTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	public virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	private void OnBlur(BlurEvent _) { }

	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	private void OnFocus(FocusEvent _) { }

	private void OnKeyDown(KeyDownEvent evt) { }

	private void OnNavigationEvent(NavigationEventBase<TEvent> evt) { }

	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	private void UpdateLabel() { }

}

