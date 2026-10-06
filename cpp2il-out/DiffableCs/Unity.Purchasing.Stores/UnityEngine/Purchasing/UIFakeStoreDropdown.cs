namespace UnityEngine.Purchasing;

internal class UIFakeStoreDropdown
{
	private List<String> m_Options; //Field offset: 0x10
	private Action<Int32, String> m_OnDropdown; //Field offset: 0x18
	private Vector2 scrollPosition; //Field offset: 0x20

	public UIFakeStoreDropdown() { }

	public void DoPopup(int windowID) { }

	private void OnOptionSelected(int optionIndex) { }

	internal void SetOptions(List<String> options) { }

	internal void SetSelectionAction(Action<Int32, String> onDropdown) { }

}

