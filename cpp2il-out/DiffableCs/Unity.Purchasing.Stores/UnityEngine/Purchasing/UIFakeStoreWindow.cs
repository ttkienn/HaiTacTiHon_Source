namespace UnityEngine.Purchasing;

internal class UIFakeStoreWindow : MonoBehaviour
{
	private const float k_MenuScreenRatio = 0.6; //Field offset: 0x0
	private string m_QueryText; //Field offset: 0x20
	private string m_OkText; //Field offset: 0x28
	private string m_CancelText; //Field offset: 0x30
	private string m_LastSelectedOptionText; //Field offset: 0x38
	private Action m_OnOk; //Field offset: 0x40
	private Action m_OnCancel; //Field offset: 0x48
	private Action<Int32> m_OnDropdown; //Field offset: 0x50
	private bool m_CancelEnabled; //Field offset: 0x58
	private bool m_DropdownEnabled; //Field offset: 0x59
	private bool m_DoDropdown; //Field offset: 0x5A
	private readonly UIFakeStoreDropdown m_Dropdown; //Field offset: 0x60
	private Vector2 scrollPosition; //Field offset: 0x68

	public UIFakeStoreWindow() { }

	internal void AssignCallbacks(Action onOk, Action onCancel, Action<Int32> onDropdown) { }

	internal void ConfigureDropdownOptions(List<String> options) { }

	internal void ConfigureMainDialogText(string queryText, string okText, string cancelText) { }

	private Rect CreateCenteredWindowRect() { }

	private void DoDropDown() { }

	private void DoMainGUI(int windowID) { }

	private void OnCancelClicked() { }

	private void OnDropdown(int index, string selectionText) { }

	private void OnGUI() { }

	private void OnOkClicked() { }

}

