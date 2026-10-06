namespace UnityEngine.UIElements;

internal class DefaultEventSystem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DefaultEventSystem, EventBase> <>9__30_0; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "scrollDelta"}])]
		public static Func<Vector3, Vector3, ValueTuple`2<EventModifiers, Vector2>, EventBase> <>9__30_1; //Field offset: 0x10
		public static Func<Vector3, Vector3, Event, EventBase> <>9__30_2; //Field offset: 0x18
		public static Func<Vector3, Vector3, DefaultEventSystem, EventBase> <>9__36_0; //Field offset: 0x20
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"button", "clickCount", "modifiers"}])]
		public static Func<Vector3, Vector3, ValueTuple`3<Int32, Int32, EventModifiers>, EventBase> <>9__36_1; //Field offset: 0x28
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"button", "clickCount", "modifiers"}])]
		public static Func<Vector3, Vector3, ValueTuple`3<Int32, Int32, EventModifiers>, EventBase> <>9__36_2; //Field offset: 0x30
		public static Func<DefaultEventSystem, EventBase> <>9__37_0; //Field offset: 0x38
		public static Func<DefaultEventSystem, EventBase> <>9__37_1; //Field offset: 0x40
		public static Func<DefaultEventSystem, EventBase> <>9__37_2; //Field offset: 0x48
		public static Func<Vector3, Vector3, Touch, EventBase> <>9__45_0; //Field offset: 0x50
		public static Func<Vector3, Vector3, PenData, EventBase> <>9__46_0; //Field offset: 0x58
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"direction", "modifiers", "input"}])]
		public static Func<ValueTuple`3<Direction, EventModifiers, IInput>, EventBase> <>9__53_0; //Field offset: 0x60

		private static <>c() { }

		public <>c() { }

		internal bool <.cctor>b__58_0() { }

		internal EventBase <ProcessMouseEvents>b__36_0(Vector3 panelPosition, Vector3 panelDelta, DefaultEventSystem self) { }

		internal EventBase <ProcessMouseEvents>b__36_1(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<Int32, Int32, EventModifiers> t) { }

		internal EventBase <ProcessMouseEvents>b__36_2(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<Int32, Int32, EventModifiers> t) { }

		internal EventBase <ProcessPenEvents>b__46_0(Vector3 panelPosition, Vector3 panelDelta, PenData _pen) { }

		internal EventBase <ProcessTabEvent>b__53_0(ValueTuple<Direction, EventModifiers, IInput> t) { }

		internal EventBase <ProcessTouchEvents>b__45_0(Vector3 panelPosition, Vector3 panelDelta, Touch _touch) { }

		internal EventBase <SendIMGUIEvents>b__30_0(DefaultEventSystem self) { }

		internal EventBase <SendIMGUIEvents>b__30_1(Vector3 panelPosition, Vector3 _, ValueTuple<EventModifiers, Vector2> t) { }

		internal EventBase <SendIMGUIEvents>b__30_2(Vector3 panelPosition, Vector3 panelDelta, Event evt) { }

		internal EventBase <SendInputEvents>b__37_0(DefaultEventSystem self) { }

		internal EventBase <SendInputEvents>b__37_1(DefaultEventSystem self) { }

		internal EventBase <SendInputEvents>b__37_2(DefaultEventSystem self) { }

	}

	public struct FocusBasedEventSequenceContext : IDisposable
	{
		private DefaultEventSystem es; //Field offset: 0x0

		public FocusBasedEventSequenceContext(DefaultEventSystem es) { }

		public override void Dispose() { }

	}

	public interface IInput
	{

		public bool anyKey
		{
			 get { } //Length: 0
		}

		public float doubleClickTime
		{
			 get { } //Length: 0
		}

		public int mouseButtonCount
		{
			 get { } //Length: 0
		}

		public Vector3 mousePosition
		{
			 get { } //Length: 0
		}

		public bool mousePresent
		{
			 get { } //Length: 0
		}

		public int touchCount
		{
			 get { } //Length: 0
		}

		public float unscaledTime
		{
			 get { } //Length: 0
		}

		public void ClearLastPenContactEvent() { }

		public bool get_anyKey() { }

		public float get_doubleClickTime() { }

		public int get_mouseButtonCount() { }

		public Vector3 get_mousePosition() { }

		public bool get_mousePresent() { }

		public int get_touchCount() { }

		public float get_unscaledTime() { }

		public float GetAxisRaw(string axis) { }

		public bool GetButtonDown(string button) { }

		public PenData GetLastPenContactEvent() { }

		public bool GetMouseButtonDown(int button) { }

		public bool GetMouseButtonUp(int button) { }

		public Touch GetTouch(int index) { }

	}

	private class Input : IInput
	{

		public override bool anyKey
		{
			 get { } //Length: 7
		}

		public override float doubleClickTime
		{
			 get { } //Length: 31
		}

		public override int mouseButtonCount
		{
			 get { } //Length: 6
		}

		public override Vector3 mousePosition
		{
			 get { } //Length: 44
		}

		public override bool mousePresent
		{
			 get { } //Length: 7
		}

		public override int touchCount
		{
			 get { } //Length: 7
		}

		public override float unscaledTime
		{
			 get { } //Length: 7
		}

		public Input() { }

		public override void ClearLastPenContactEvent() { }

		public override bool get_anyKey() { }

		public override float get_doubleClickTime() { }

		public override int get_mouseButtonCount() { }

		public override Vector3 get_mousePosition() { }

		public override bool get_mousePresent() { }

		public override int get_touchCount() { }

		public override float get_unscaledTime() { }

		public override float GetAxisRaw(string axis) { }

		public override bool GetButtonDown(string button) { }

		public override PenData GetLastPenContactEvent() { }

		public override bool GetMouseButtonDown(int button) { }

		public override bool GetMouseButtonUp(int button) { }

		public override Touch GetTouch(int index) { }

	}

	private class NoInput : IInput
	{

		public override bool anyKey
		{
			 get { } //Length: 3
		}

		public override float doubleClickTime
		{
			 get { } //Length: 9
		}

		public override int mouseButtonCount
		{
			 get { } //Length: 3
		}

		public override Vector3 mousePosition
		{
			 get { } //Length: 12
		}

		public override bool mousePresent
		{
			 get { } //Length: 3
		}

		public override int touchCount
		{
			 get { } //Length: 3
		}

		public override float unscaledTime
		{
			 get { } //Length: 4
		}

		public NoInput() { }

		public override void ClearLastPenContactEvent() { }

		public override bool get_anyKey() { }

		public override float get_doubleClickTime() { }

		public override int get_mouseButtonCount() { }

		public override Vector3 get_mousePosition() { }

		public override bool get_mousePresent() { }

		public override int get_touchCount() { }

		public override float get_unscaledTime() { }

		public override float GetAxisRaw(string axis) { }

		public override bool GetButtonDown(string button) { }

		public override PenData GetLastPenContactEvent() { }

		public override bool GetMouseButtonDown(int button) { }

		public override bool GetMouseButtonUp(int button) { }

		public override Touch GetTouch(int index) { }

	}

	internal enum UpdateMode
	{
		Always = 0,
		IgnoreIfAppNotFocused = 1,
	}

	internal static Func<Boolean> IsEditorRemoteConnected; //Field offset: 0x0
	private IInput m_Input; //Field offset: 0x10
	private readonly string m_HorizontalAxis; //Field offset: 0x18
	private readonly string m_VerticalAxis; //Field offset: 0x20
	private readonly string m_SubmitButton; //Field offset: 0x28
	private readonly string m_CancelButton; //Field offset: 0x30
	private readonly float m_InputActionsPerSecond; //Field offset: 0x38
	private readonly float m_RepeatDelay; //Field offset: 0x3C
	private bool m_SendingTouchEvents; //Field offset: 0x40
	private bool m_SendingPenEvent; //Field offset: 0x41
	private Event m_Event; //Field offset: 0x48
	private BaseRuntimePanel m_FocusedPanel; //Field offset: 0x50
	private BaseRuntimePanel m_PreviousFocusedPanel; //Field offset: 0x58
	private Focusable m_PreviousFocusedElement; //Field offset: 0x60
	private EventModifiers m_CurrentModifiers; //Field offset: 0x68
	private int m_LastMousePressButton; //Field offset: 0x6C
	private float m_NextMousePressTime; //Field offset: 0x70
	private int m_LastMouseClickCount; //Field offset: 0x74
	private Vector2 m_LastMousePosition; //Field offset: 0x78
	private bool m_MouseProcessedAtLeastOnce; //Field offset: 0x80
	private int m_ConsecutiveMoveCount; //Field offset: 0x84
	private Vector2 m_LastMoveVector; //Field offset: 0x88
	private float m_PrevActionTime; //Field offset: 0x90
	private bool m_IsMoveFromKeyboard; //Field offset: 0x94

	public BaseRuntimePanel focusedPanel
	{
		 get { } //Length: 5
		 set { } //Length: 81
	}

	internal IInput input
	{
		internal get { } //Length: 63
	}

	private bool isAppFocused
	{
		private get { } //Length: 64
	}

	private static DefaultEventSystem() { }

	public DefaultEventSystem() { }

	internal FocusBasedEventSequenceContext FocusBasedEventSequence() { }

	public BaseRuntimePanel get_focusedPanel() { }

	internal IInput get_input() { }

	private bool get_isAppFocused() { }

	private IInput GetDefaultInput() { }

	private Vector2 GetRawMoveVector() { }

	private static EventBase MakePenEvent(PenData pen, EventModifiers modifiers) { }

	private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers) { }

	internal void OnFocusEvent(RuntimePanel panel, FocusEvent evt) { }

	private void ProcessMouseEvents() { }

	private bool ProcessPenEvents() { }

	private void ProcessTabEvent(Event e, EventModifiers modifiers) { }

	private bool ProcessTouchEvents() { }

	internal void SendFocusBasedEvent(Func<TArg, EventBase> evtFactory, TArg arg) { }

	private void SendIMGUIEvents() { }

	private void SendInputEvents() { }

	private void SendPositionBasedEvent(Vector3 mousePosition, Vector3 delta, int pointerId, Nullable<Int32> targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false) { }

	public void set_focusedPanel(BaseRuntimePanel value) { }

	private bool ShouldIgnoreEventsOnAppNotFocused() { }

	private bool ShouldSendMoveFromInput() { }

	public void Update(UpdateMode updateMode = 0) { }

	private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel) { }

}

