namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class FieldMouseDragger : BaseFieldMouseDragger
{
	private readonly IValueField<T> m_DrivenField; //Field offset: 0x0
	private VisualElement m_DragElement; //Field offset: 0x0
	private Rect m_DragHotZone; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <dragging>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private T <startValue>k__BackingField; //Field offset: 0x0

	public bool dragging
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public T startValue
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public FieldMouseDragger`1(IValueField<T> drivenField) { }

	private bool CanStartDrag(int button, Vector2 localPosition) { }

	[CompilerGenerated]
	public bool get_dragging() { }

	[CompilerGenerated]
	public T get_startValue() { }

	private void ProcessDownEvent(EventBase evt) { }

	private void ProcessMoveEvent(bool shiftKey, bool altKey, Vector2 deltaPosition) { }

	private void ProcessUpEvent(EventBase evt, int pointerId) { }

	[CompilerGenerated]
	public void set_dragging(bool value) { }

	[CompilerGenerated]
	public void set_startValue(T value) { }

	public virtual void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	private void UpdateValueOnKeyDown(KeyDownEvent evt) { }

	private void UpdateValueOnPointerDown(PointerDownEvent evt) { }

	private void UpdateValueOnPointerMove(PointerMoveEvent evt) { }

	private void UpdateValueOnPointerUp(PointerUpEvent evt) { }

}

