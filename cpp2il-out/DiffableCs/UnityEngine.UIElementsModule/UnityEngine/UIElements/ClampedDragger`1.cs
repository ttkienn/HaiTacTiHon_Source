namespace UnityEngine.UIElements;

internal class ClampedDragger : Clickable
{
	[Flags]
	internal enum DragDirection
	{
		None = 0,
		LowToHigh = 1,
		HighToLow = 2,
		Free = 4,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action dragging; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action draggingEnded; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DragDirection<T> <dragDirection>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private BaseSlider<T> <slider>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <startMousePosition>k__BackingField; //Field offset: 0x0

	public event Action dragging
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action draggingEnded
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public Vector2 delta
	{
		 get { } //Length: 53
	}

	public DragDirection<T> dragDirection
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 155
	}

	private BaseSlider<T> slider
	{
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private Vector2 startMousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public ClampedDragger`1(BaseSlider<T> slider, Action clickHandler, Action dragHandler) { }

	[CompilerGenerated]
	public void add_dragging(Action value) { }

	[CompilerGenerated]
	public void add_draggingEnded(Action value) { }

	public Vector2 get_delta() { }

	[CompilerGenerated]
	public DragDirection<T> get_dragDirection() { }

	[CompilerGenerated]
	public Vector2 get_startMousePosition() { }

	protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[CompilerGenerated]
	public void remove_dragging(Action value) { }

	[CompilerGenerated]
	public void remove_draggingEnded(Action value) { }

	[CompilerGenerated]
	public void set_dragDirection(DragDirection<T> value) { }

	[CompilerGenerated]
	private void set_slider(BaseSlider<T> value) { }

	[CompilerGenerated]
	private void set_startMousePosition(Vector2 value) { }

}

