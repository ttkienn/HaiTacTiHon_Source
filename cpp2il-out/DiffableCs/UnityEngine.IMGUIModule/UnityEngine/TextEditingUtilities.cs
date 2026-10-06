namespace UnityEngine;

internal class TextEditingUtilities
{
	private static Dictionary<Event, TextEditOp> s_KeyEditOps; //Field offset: 0x0
	private TextSelectingUtilities m_TextSelectingUtility; //Field offset: 0x10
	private TextHandle m_TextHandle; //Field offset: 0x18
	private int m_CursorIndexSavedState; //Field offset: 0x20
	internal bool isCompositionActive; //Field offset: 0x24
	private bool m_UpdateImeWindowPosition; //Field offset: 0x25
	public bool multiline; //Field offset: 0x26
	private string m_Text; //Field offset: 0x28

	private int cursorIndex
	{
		private get { } //Length: 33
		private set { } //Length: 59
	}

	private bool hasSelection
	{
		private get { } //Length: 71
	}

	internal bool revealCursor
	{
		internal set { } //Length: 59
	}

	private int selectIndex
	{
		private get { } //Length: 33
		private set { } //Length: 59
	}

	public string text
	{
		 get { } //Length: 7
		 set { } //Length: 112
	}

	public TextEditingUtilities(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	public bool Backspace() { }

	public bool CanPaste() { }

	public bool Cut() { }

	public bool Delete() { }

	public bool DeleteLineBack() { }

	public bool DeleteSelection() { }

	public bool DeleteWordBack() { }

	public bool DeleteWordForward() { }

	public void EnableCursorPreviewState() { }

	public string GeneratePreviewString(bool richText) { }

	private int get_cursorIndex() { }

	private bool get_hasSelection() { }

	private int get_selectIndex() { }

	public string get_text() { }

	[VisibleToOtherModules]
	internal bool HandleKeyEvent(Event e) { }

	private void InitKeyActions() { }

	public void Insert(char c) { }

	private static void MapKey(string key, TextEditOp action) { }

	internal void OnBlur() { }

	public bool Paste() { }

	private void PerformOperation(TextEditOp operation) { }

	private static string ReplaceNewlinesWithSpaces(string value) { }

	public void ReplaceSelection(string replace) { }

	public void RestoreCursorState() { }

	private void set_cursorIndex(int value) { }

	internal void set_revealCursor(bool value) { }

	private void set_selectIndex(int value) { }

	public void set_text(string value) { }

	public void SetImeWindowPosition(Vector2 worldPosition) { }

	public bool ShouldUpdateImeWindowPosition() { }

	internal bool TouchScreenKeyboardShouldBeUsed() { }

	public bool UpdateImeState() { }

}

