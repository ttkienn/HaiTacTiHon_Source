namespace UnityEngine.UIElements;

internal class TextSelectingManipulator
{
	private const int k_DragThresholdSqr = 16; //Field offset: 0x0
	internal TextSelectingUtilities m_SelectingUtilities; //Field offset: 0x10
	private bool selectAllOnMouseUp; //Field offset: 0x18
	private TextElement m_TextElement; //Field offset: 0x20
	private Vector2 m_ClickStartPosition; //Field offset: 0x28
	private bool m_Dragged; //Field offset: 0x30
	private bool m_IsClicking; //Field offset: 0x31
	private int m_ConsecutiveMouseDownCount; //Field offset: 0x34
	private long m_LastMouseDownTimeStamp; //Field offset: 0x38
	private readonly Event m_ImguiEvent; //Field offset: 0x40

	internal int cursorIndex
	{
		internal get { } //Length: 22
		internal set { } //Length: 30
	}

	internal bool isClicking
	{
		internal get { } //Length: 5
		internal set { } //Length: 9
	}

	internal int selectIndex
	{
		internal get { } //Length: 22
		internal set { } //Length: 30
	}

	public TextSelectingManipulator(TextElement textElement) { }

	internal void ExecuteDefaultActionAtTarget(EventBase evt) { }

	internal int get_cursorIndex() { }

	internal bool get_isClicking() { }

	internal int get_selectIndex() { }

	internal bool HasFocus() { }

	internal bool HasSelection() { }

	private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current) { }

	private void OnBlurEvent(BlurEvent evt) { }

	private void OnCursorIndexChange() { }

	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	private void OnFocusEvent(FocusEvent evt) { }

	private void OnKeyDown(KeyDownEvent evt) { }

	private void OnPointerDownEvent(PointerDownEvent evt) { }

	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	private void OnPointerUpEvent(PointerUpEvent evt) { }

	private void OnRevealCursor() { }

	private void OnSelectIndexChange() { }

	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	internal bool RevealCursor() { }

	internal void set_cursorIndex(int value) { }

	internal void set_isClicking(bool value) { }

	internal void set_selectIndex(int value) { }

}

