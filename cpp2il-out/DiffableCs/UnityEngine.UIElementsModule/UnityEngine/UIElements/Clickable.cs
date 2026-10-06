namespace UnityEngine.UIElements;

public class Clickable : PointerManipulator
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<EventBase> clickedWithEventInfo; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action clicked; //Field offset: 0x40
	private readonly long m_Delay; //Field offset: 0x48
	private readonly long m_Interval; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <active>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <lastMousePosition>k__BackingField; //Field offset: 0x5C
	private int m_ActivePointerId; //Field offset: 0x64
	private bool m_AcceptClicksIfDisabled; //Field offset: 0x68
	private IVisualElementScheduledItem m_Repeater; //Field offset: 0x70

	public event Action clicked
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<EventBase> clickedWithEventInfo
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	internal bool acceptClicksIfDisabled
	{
		internal get { } //Length: 5
		internal set { } //Length: 77
	}

	protected bool active
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private InvokePolicy invokePolicy
	{
		private get { } //Length: 11
	}

	public private Vector2 lastMousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public Clickable(Action handler) { }

	public Clickable(Action<EventBase> handler) { }

	public Clickable(Action handler, long delay, long interval) { }

	[CompilerGenerated]
	private void <SimulateSingleClick>b__43_0() { }

	[CompilerGenerated]
	public void add_clicked(Action value) { }

	[CompilerGenerated]
	public void add_clickedWithEventInfo(Action<EventBase> value) { }

	private bool ContainsPointer(int pointerId) { }

	internal bool get_acceptClicksIfDisabled() { }

	[CompilerGenerated]
	protected bool get_active() { }

	private InvokePolicy get_invokePolicy() { }

	[CompilerGenerated]
	public Vector2 get_lastMousePosition() { }

	protected void Invoke(EventBase evt) { }

	private static bool IsNotMouseEvent(int pointerId) { }

	private bool IsRepeatable() { }

	private void OnMouseCaptureOut(MouseCaptureOutEvent evt) { }

	protected void OnMouseDown(MouseDownEvent evt) { }

	protected void OnMouseMove(MouseMoveEvent evt) { }

	protected void OnMouseUp(MouseUpEvent evt) { }

	private void OnPointerCancel(PointerCancelEvent evt) { }

	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	private void OnPointerDown(PointerDownEvent evt) { }

	private void OnPointerMove(PointerMoveEvent evt) { }

	private void OnPointerUp(PointerUpEvent evt) { }

	private void OnTimer(TimerState timerState) { }

	protected override void ProcessCancelEvent(EventBase evt, int pointerId) { }

	protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	protected virtual void RegisterCallbacksOnTarget() { }

	[CompilerGenerated]
	public void remove_clicked(Action value) { }

	[CompilerGenerated]
	public void remove_clickedWithEventInfo(Action<EventBase> value) { }

	internal void set_acceptClicksIfDisabled(bool value) { }

	[CompilerGenerated]
	protected void set_active(bool value) { }

	[CompilerGenerated]
	private void set_lastMousePosition(Vector2 value) { }

	internal void SimulateSingleClick(EventBase evt, int delayMs = 100) { }

	protected virtual void UnregisterCallbacksFromTarget() { }

}

