namespace UnityEngine.UIElements;

internal class TextEditingManipulator
{
	private TextElement m_TextElement; //Field offset: 0x10
	internal TextEditorEventHandler editingEventHandler; //Field offset: 0x18
	internal TextEditingUtilities editingUtilities; //Field offset: 0x20
	private bool m_TouchScreenTextFieldInitialized; //Field offset: 0x28
	private IVisualElementScheduledItem m_HardwareKeyboardPoller; //Field offset: 0x30

	private bool touchScreenTextFieldChanged
	{
		private get { } //Length: 145
	}

	public TextEditingManipulator(TextElement textElement) { }

	[CompilerGenerated]
	private void <OnFocusInEvent>b__10_0() { }

	internal void ExecuteDefaultActionAtTarget(EventBase evt) { }

	private bool get_touchScreenTextFieldChanged() { }

	private void InitTextEditorEventHandler() { }

	private void OnFocusInEvent(FocusInEvent _) { }

	private void OnFocusOutEvent(FocusOutEvent _) { }

}

