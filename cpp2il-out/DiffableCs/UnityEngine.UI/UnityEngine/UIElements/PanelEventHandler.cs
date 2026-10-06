namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent, IPointerClickHandler
{
	private class PointerEvent : IPointerEvent
	{
		[CompilerGenerated]
		private int <pointerId>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <pointerType>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private bool <isPrimary>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private int <button>k__BackingField; //Field offset: 0x24
		[CompilerGenerated]
		private int <pressedButtons>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private Vector3 <position>k__BackingField; //Field offset: 0x2C
		[CompilerGenerated]
		private Vector3 <localPosition>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private Vector3 <deltaPosition>k__BackingField; //Field offset: 0x44
		[CompilerGenerated]
		private float <deltaTime>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		private int <clickCount>k__BackingField; //Field offset: 0x54
		[CompilerGenerated]
		private float <pressure>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private float <tangentialPressure>k__BackingField; //Field offset: 0x5C
		[CompilerGenerated]
		private float <altitudeAngle>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private float <azimuthAngle>k__BackingField; //Field offset: 0x64
		[CompilerGenerated]
		private float <twist>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private Vector2 <tilt>k__BackingField; //Field offset: 0x6C
		[CompilerGenerated]
		private PenStatus <penStatus>k__BackingField; //Field offset: 0x74
		[CompilerGenerated]
		private Vector2 <radius>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		private EventModifiers <modifiers>k__BackingField; //Field offset: 0x88

		public override bool actionKey
		{
			 get { } //Length: 134
		}

		public private override float altitudeAngle
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public override bool altKey
		{
			 get { } //Length: 11
		}

		public private override float azimuthAngle
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private override int button
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private override int clickCount
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public override bool commandKey
		{
			 get { } //Length: 11
		}

		public override bool ctrlKey
		{
			 get { } //Length: 11
		}

		public private override Vector3 deltaPosition
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public private override float deltaTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private override bool isPrimary
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private override Vector3 localPosition
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public private override EventModifiers modifiers
		{
			[CompilerGenerated]
			 get { } //Length: 7
			[CompilerGenerated]
			private set { } //Length: 155
		}

		public private override PenStatus penStatus
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private override int pointerId
		{
			[CompilerGenerated]
			 get { } //Length: 191
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private override string pointerType
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 13
		}

		public private override Vector3 position
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public private override int pressedButtons
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private override float pressure
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private override Vector2 radius
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 5
		}

		public private override Vector2 radiusVariance
		{
			[CompilerGenerated]
			 get { } //Length: 25
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public override bool shiftKey
		{
			 get { } //Length: 11
		}

		public private override float tangentialPressure
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private override Vector2 tilt
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 5
		}

		public private override float twist
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public PointerEvent() { }

		[CompilerGenerated]
		internal static bool <Read>g__InRange|90_0(int i, int start, int count) { }

		public override bool get_actionKey() { }

		[CompilerGenerated]
		public override float get_altitudeAngle() { }

		public override bool get_altKey() { }

		[CompilerGenerated]
		public override float get_azimuthAngle() { }

		[CompilerGenerated]
		public override int get_button() { }

		[CompilerGenerated]
		public override int get_clickCount() { }

		public override bool get_commandKey() { }

		public override bool get_ctrlKey() { }

		[CompilerGenerated]
		public override Vector3 get_deltaPosition() { }

		[CompilerGenerated]
		public override float get_deltaTime() { }

		[CompilerGenerated]
		public override bool get_isPrimary() { }

		[CompilerGenerated]
		public override Vector3 get_localPosition() { }

		[CompilerGenerated]
		public override EventModifiers get_modifiers() { }

		[CompilerGenerated]
		public override PenStatus get_penStatus() { }

		[CompilerGenerated]
		public override int get_pointerId() { }

		[CompilerGenerated]
		public override string get_pointerType() { }

		[CompilerGenerated]
		public override Vector3 get_position() { }

		[CompilerGenerated]
		public override int get_pressedButtons() { }

		[CompilerGenerated]
		public override float get_pressure() { }

		[CompilerGenerated]
		public override Vector2 get_radius() { }

		[CompilerGenerated]
		public override Vector2 get_radiusVariance() { }

		public override bool get_shiftKey() { }

		[CompilerGenerated]
		public override float get_tangentialPressure() { }

		[CompilerGenerated]
		public override Vector2 get_tilt() { }

		[CompilerGenerated]
		public override float get_twist() { }

		public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType) { }

		[CompilerGenerated]
		private void set_altitudeAngle(float value) { }

		[CompilerGenerated]
		private void set_azimuthAngle(float value) { }

		[CompilerGenerated]
		private void set_button(int value) { }

		[CompilerGenerated]
		private void set_clickCount(int value) { }

		[CompilerGenerated]
		private void set_deltaPosition(Vector3 value) { }

		[CompilerGenerated]
		private void set_deltaTime(float value) { }

		[CompilerGenerated]
		private void set_isPrimary(bool value) { }

		[CompilerGenerated]
		private void set_localPosition(Vector3 value) { }

		[CompilerGenerated]
		private void set_modifiers(EventModifiers value) { }

		[CompilerGenerated]
		private void set_penStatus(PenStatus value) { }

		[CompilerGenerated]
		private void set_pointerId(int value) { }

		[CompilerGenerated]
		private void set_pointerType(string value) { }

		[CompilerGenerated]
		private void set_position(Vector3 value) { }

		[CompilerGenerated]
		private void set_pressedButtons(int value) { }

		[CompilerGenerated]
		private void set_pressure(float value) { }

		[CompilerGenerated]
		private void set_radius(Vector2 value) { }

		[CompilerGenerated]
		private void set_radiusVariance(Vector2 value) { }

		[CompilerGenerated]
		private void set_tangentialPressure(float value) { }

		[CompilerGenerated]
		private void set_tilt(Vector2 value) { }

		[CompilerGenerated]
		private void set_twist(float value) { }

		public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride) { }

	}

	private enum PointerEventType
	{
		Default = 0,
		Down = 1,
		Up = 2,
	}

	private static EventModifiers s_Modifiers; //Field offset: 0x0
	private BaseRuntimePanel m_Panel; //Field offset: 0x20
	private readonly PointerEvent m_PointerEvent; //Field offset: 0x28
	private float m_LastClickTime; //Field offset: 0x30
	private bool m_Selecting; //Field offset: 0x34
	private Event m_Event; //Field offset: 0x38

	private Focusable currentFocusedElement
	{
		private get { } //Length: 63
	}

	private EventSystem eventSystem
	{
		private get { } //Length: 218
	}

	private bool isCurrentFocusedPanel
	{
		private get { } //Length: 206
	}

	public override IPanel panel
	{
		 get { } //Length: 5
		 set { } //Length: 153
	}

	private GameObject selectableGameObject
	{
		private get { } //Length: 18
	}

	public PanelEventHandler() { }

	private Focusable get_currentFocusedElement() { }

	private EventSystem get_eventSystem() { }

	private bool get_isCurrentFocusedPanel() { }

	public override IPanel get_panel() { }

	private GameObject get_selectableGameObject() { }

	private void LateUpdate() { }

	public override void OnCancel(BaseEventData eventData) { }

	public override void OnDeselect(BaseEventData eventData) { }

	protected virtual void OnDisable() { }

	private void OnElementBlur(BlurEvent e) { }

	private void OnElementFocus(FocusEvent e) { }

	protected virtual void OnEnable() { }

	public override void OnMove(AxisEventData eventData) { }

	private void OnPanelDestroyed() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerMove(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public override void OnScroll(PointerEventData eventData) { }

	public override void OnSelect(BaseEventData eventData) { }

	public override void OnSubmit(BaseEventData eventData) { }

	private void ProcessImguiEvents(Focusable target) { }

	private void ProcessKeyboardEvent(Event e, Focusable target) { }

	private void ProcessTabEvent(Event e, Focusable target) { }

	private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType = 0) { }

	private void RegisterCallbacks() { }

	private void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	private void SendEvent(EventBase e, Event sourceEvent) { }

	private void SendKeyDownEvent(Event e, Focusable target) { }

	private void SendKeyUpEvent(Event e, Focusable target) { }

	private void SendTabEvent(Event e, Direction direction, Focusable target) { }

	public override void set_panel(IPanel value) { }

	private void UnregisterCallbacks() { }

	internal void Update() { }

}

