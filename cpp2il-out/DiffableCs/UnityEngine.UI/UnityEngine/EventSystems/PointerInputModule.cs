namespace UnityEngine.EventSystems;

public abstract class PointerInputModule : BaseInputModule
{
	internal class ButtonState
	{
		private InputButton m_Button; //Field offset: 0x10
		private MouseButtonEventData m_EventData; //Field offset: 0x18

		public InputButton button
		{
			 get { } //Length: 191
			 set { } //Length: 4
		}

		public MouseButtonEventData eventData
		{
			 get { } //Length: 5
			 set { } //Length: 13
		}

		public ButtonState() { }

		public InputButton get_button() { }

		public MouseButtonEventData get_eventData() { }

		public void set_button(InputButton value) { }

		public void set_eventData(MouseButtonEventData value) { }

	}

	internal class MouseButtonEventData
	{
		public FramePressState buttonState; //Field offset: 0x10
		public PointerEventData buttonData; //Field offset: 0x18

		public MouseButtonEventData() { }

		public bool PressedThisFrame() { }

		public bool ReleasedThisFrame() { }

	}

	internal class MouseState
	{
		private List<ButtonState> m_TrackedButtons; //Field offset: 0x10

		public MouseState() { }

		public bool AnyPressesThisFrame() { }

		public bool AnyReleasesThisFrame() { }

		public ButtonState GetButtonState(InputButton button) { }

		public void SetButtonState(InputButton button, FramePressState stateForMouseButton, PointerEventData data) { }

	}

	public const int kMouseLeftId = -1; //Field offset: 0x0
	public const int kMouseRightId = -2; //Field offset: 0x0
	public const int kMouseMiddleId = -3; //Field offset: 0x0
	public const int kFakeTouchesId = -4; //Field offset: 0x0
	protected Dictionary<Int32, PointerEventData> m_PointerData; //Field offset: 0x58
	private readonly MouseState m_MouseState; //Field offset: 0x60

	protected PointerInputModule() { }

	protected void ClearSelection() { }

	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	protected PointerEventData GetLastPointerEventData(int id) { }

	protected override MouseState GetMousePointerEventData() { }

	protected override MouseState GetMousePointerEventData(int id) { }

	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	public virtual bool IsPointerOverGameObject(int pointerId) { }

	protected override void ProcessDrag(PointerEventData pointerEvent) { }

	protected override void ProcessMove(PointerEventData pointerEvent) { }

	protected void RemovePointerData(PointerEventData data) { }

	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	protected FramePressState StateForMouseButton(int buttonId) { }

	public virtual string ToString() { }

}

