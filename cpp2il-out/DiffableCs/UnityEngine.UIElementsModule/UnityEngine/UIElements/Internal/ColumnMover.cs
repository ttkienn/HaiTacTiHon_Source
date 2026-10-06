namespace UnityEngine.UIElements.Internal;

internal class ColumnMover : PointerManipulator
{
	private float m_StartPos; //Field offset: 0x38
	private float m_LastPos; //Field offset: 0x3C
	private bool m_Active; //Field offset: 0x40
	private bool m_Moving; //Field offset: 0x41
	private bool m_Cancelled; //Field offset: 0x42
	private MultiColumnCollectionHeader m_Header; //Field offset: 0x48
	private VisualElement m_PreviewElement; //Field offset: 0x50
	private MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement; //Field offset: 0x58
	private Column m_ColumnToMove; //Field offset: 0x60
	private float m_ColumnToMovePos; //Field offset: 0x68
	private float m_ColumnToMoveWidth; //Field offset: 0x6C
	private Column m_DestinationColumn; //Field offset: 0x70
	private bool m_MoveBeforeDestination; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ColumnLayout <columnLayout>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<ColumnMover> activeChanged; //Field offset: 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<ColumnMover> movingChanged; //Field offset: 0x90

	public event Action<ColumnMover> activeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public event Action<ColumnMover> movingChanged
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public bool active
	{
		 get { } //Length: 5
		 set { } //Length: 39
	}

	public ColumnLayout columnLayout
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public bool moving
	{
		 get { } //Length: 5
		 set { } //Length: 39
	}

	public ColumnMover() { }

	[CompilerGenerated]
	public void add_activeChanged(Action<ColumnMover> value) { }

	[CompilerGenerated]
	public void add_movingChanged(Action<ColumnMover> value) { }

	private void BeginDragMove(float pos) { }

	internal void DragMove(float pos) { }

	private void EndDragMove(bool cancelled) { }

	public bool get_active() { }

	[CompilerGenerated]
	public ColumnLayout get_columnLayout() { }

	public bool get_moving() { }

	private static bool IsNotMouseEvent(int pointerId) { }

	private void OnKeyDown(KeyDownEvent e) { }

	private void OnMouseCaptureOut(MouseCaptureOutEvent evt) { }

	protected void OnMouseDown(MouseDownEvent evt) { }

	protected void OnMouseMove(MouseMoveEvent evt) { }

	protected void OnMouseUp(MouseUpEvent evt) { }

	private void OnPointerCancel(PointerCancelEvent evt) { }

	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	private void OnPointerDown(PointerDownEvent evt) { }

	private void OnPointerMove(PointerMoveEvent evt) { }

	private void OnPointerUp(PointerUpEvent evt) { }

	protected void ProcessCancelEvent(EventBase evt, int pointerId) { }

	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	private void ProcessMoveEvent(EventBase e, Vector2 localPosition) { }

	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	protected virtual void RegisterCallbacksOnTarget() { }

	[CompilerGenerated]
	public void remove_activeChanged(Action<ColumnMover> value) { }

	[CompilerGenerated]
	public void remove_movingChanged(Action<ColumnMover> value) { }

	public void set_active(bool value) { }

	[CompilerGenerated]
	public void set_columnLayout(ColumnLayout value) { }

	public void set_moving(bool value) { }

	protected virtual void UnregisterCallbacksFromTarget() { }

	private void UpdateMoveLocation() { }

	private void UpdatePreviewPosition() { }

}

