namespace UnityEngine;

internal class TextSelectingUtilities
{
	private enum CharacterType
	{
		LetterLike = 0,
		Symbol = 1,
		Symbol2 = 2,
		WhiteSpace = 3,
		NewLine = 4,
	}

	private enum Direction
	{
		Forward = 0,
		Backward = 1,
	}

	private const int kMoveDownHeight = 5; //Field offset: 0x0
	private static Dictionary<Event, TextSelectOp> s_KeySelectOps; //Field offset: 0x0
	private const char kNewLineChar = '\uA'; //Field offset: 0x0
	public DblClickSnapping dblClickSnap; //Field offset: 0x10
	public int iAltCursorPos; //Field offset: 0x14
	public bool hasHorizontalCursorPos; //Field offset: 0x18
	private bool m_bJustSelected; //Field offset: 0x19
	private bool m_MouseDragSelectsWholeWords; //Field offset: 0x1A
	private int m_DblClickInitPosStart; //Field offset: 0x1C
	private int m_DblClickInitPosEnd; //Field offset: 0x20
	private TextHandle m_TextHandle; //Field offset: 0x28
	private bool m_RevealCursor; //Field offset: 0x30
	private int m_CursorIndex; //Field offset: 0x34
	internal int m_SelectIndex; //Field offset: 0x38
	internal Action OnCursorIndexChange; //Field offset: 0x40
	internal Action OnSelectIndexChange; //Field offset: 0x48
	internal Action OnRevealCursorChange; //Field offset: 0x50

	private int characterCount
	{
		private get { } //Length: 221
	}

	public int cursorIndex
	{
		 get { } //Length: 11
		 set { } //Length: 40
	}

	public bool hasSelection
	{
		 get { } //Length: 56
	}

	private int m_CharacterCount
	{
		private get { } //Length: 38
	}

	private TextElementInfo[] m_TextElementInfos
	{
		private get { } //Length: 39
	}

	public bool revealCursor
	{
		 get { } //Length: 5
		 set { } //Length: 40
	}

	public string selectedText
	{
		 get { } //Length: 260
	}

	public int selectIndex
	{
		 get { } //Length: 11
		 set { } //Length: 40
	}

	public TextSelectingUtilities(TextHandle textHandle) { }

	private int ClampTextIndex(int index) { }

	private CharacterType ClassifyChar(int index) { }

	public void ClearCursorPos() { }

	public void Copy() { }

	public void DblClickSnap(DblClickSnapping snapping) { }

	internal int EnsureValidCodePointIndex(int index) { }

	public void ExpandSelectGraphicalLineEnd() { }

	public void ExpandSelectGraphicalLineStart() { }

	private int FindEndOfClassification(int p, Direction dir) { }

	public int FindEndOfPreviousWord(int p) { }

	private int FindNextSeperator(int startPos) { }

	private int FindPrevSeperator(int startPos) { }

	public int FindStartOfNextWord(int p) { }

	private int get_characterCount() { }

	public int get_cursorIndex() { }

	public bool get_hasSelection() { }

	private int get_m_CharacterCount() { }

	private TextElementInfo[] get_m_TextElementInfos() { }

	public bool get_revealCursor() { }

	public string get_selectedText() { }

	public int get_selectIndex() { }

	private int GetGraphicalLineEnd(int p) { }

	private int GetGraphicalLineStart(int p) { }

	internal bool HandleKeyEvent(Event e) { }

	private int IndexOfEndOfLine(int startIndex) { }

	private void InitKeyActions() { }

	private bool IsValidCodePointIndex(int index) { }

	private static void MapKey(string key, TextSelectOp action) { }

	public void MouseDragSelectsWholeWords(bool on) { }

	protected private void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	public void MoveDown() { }

	public void MoveGraphicalLineEnd() { }

	public void MoveGraphicalLineStart() { }

	public void MoveLeft() { }

	public void MoveLineEnd() { }

	public void MoveLineStart() { }

	public void MoveParagraphBackward() { }

	public void MoveParagraphForward() { }

	public void MoveRight() { }

	public void MoveTextEnd() { }

	public void MoveTextStart() { }

	public void MoveToEndOfPreviousWord() { }

	public void MoveToStartOfNextWord() { }

	public void MoveUp() { }

	public void MoveWordLeft() { }

	public void MoveWordRight() { }

	public int NextCodePointIndex(int index) { }

	public void OnFocus(bool selectAll = true) { }

	private bool PerformOperation(TextSelectOp operation) { }

	public int PreviousCodePointIndex(int index) { }

	public void SelectAll() { }

	public void SelectCurrentParagraph() { }

	public void SelectCurrentWord() { }

	public void SelectDown() { }

	public void SelectGraphicalLineEnd() { }

	public void SelectGraphicalLineStart() { }

	public void SelectLeft() { }

	public void SelectNone() { }

	public void SelectParagraphBackward() { }

	public void SelectParagraphForward() { }

	public void SelectRight() { }

	public void SelectTextEnd() { }

	public void SelectTextStart() { }

	public void SelectToEndOfPreviousWord() { }

	public void SelectToPosition(Vector2 cursorPosition) { }

	public void SelectToStartOfNextWord() { }

	public void SelectUp() { }

	public void SelectWordLeft() { }

	public void SelectWordRight() { }

	public void set_cursorIndex(int value) { }

	public void set_revealCursor(bool value) { }

	public void set_selectIndex(int value) { }

	internal void SetCursorIndexWithoutNotify(int index) { }

	internal void SetSelectIndexWithoutNotify(int index) { }

}

