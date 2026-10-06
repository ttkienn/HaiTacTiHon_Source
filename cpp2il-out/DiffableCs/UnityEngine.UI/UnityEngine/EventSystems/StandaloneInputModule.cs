namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Standalone Input Module")]
public class StandaloneInputModule : PointerInputModule
{
	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	internal enum InputMode
	{
		Mouse = 0,
		Buttons = 1,
	}

	private const float doubleClickTime = 0.3; //Field offset: 0x0
	private float m_PrevActionTime; //Field offset: 0x68
	private Vector2 m_LastMoveVector; //Field offset: 0x6C
	private int m_ConsecutiveMoveCount; //Field offset: 0x74
	private Vector2 m_LastMousePosition; //Field offset: 0x78
	private Vector2 m_MousePosition; //Field offset: 0x80
	private GameObject m_CurrentFocusedGameObject; //Field offset: 0x88
	private PointerEventData m_InputPointerEvent; //Field offset: 0x90
	[SerializeField]
	private string m_HorizontalAxis; //Field offset: 0x98
	[SerializeField]
	private string m_VerticalAxis; //Field offset: 0xA0
	[SerializeField]
	private string m_SubmitButton; //Field offset: 0xA8
	[SerializeField]
	private string m_CancelButton; //Field offset: 0xB0
	[SerializeField]
	private float m_InputActionsPerSecond; //Field offset: 0xB8
	[SerializeField]
	private float m_RepeatDelay; //Field offset: 0xBC
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	[HideInInspector]
	[SerializeField]
	private bool m_ForceModuleActive; //Field offset: 0xC0

	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnMobileDevice
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public string cancelButton
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
	public bool forceModuleActive
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public string horizontalAxis
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public float inputActionsPerSecond
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	public InputMode inputMode
	{
		 get { } //Length: 3
	}

	public float repeatDelay
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public string submitButton
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public string verticalAxis
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	protected StandaloneInputModule() { }

	public virtual void ActivateModule() { }

	public virtual void DeactivateModule() { }

	[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
	protected override bool ForceAutoSelect() { }

	public bool get_allowActivationOnMobileDevice() { }

	public string get_cancelButton() { }

	public bool get_forceModuleActive() { }

	public string get_horizontalAxis() { }

	public float get_inputActionsPerSecond() { }

	public InputMode get_inputMode() { }

	public float get_repeatDelay() { }

	public string get_submitButton() { }

	public string get_verticalAxis() { }

	protected GameObject GetCurrentFocusedGameObject() { }

	private Vector2 GetRawMoveVector() { }

	public virtual void Process() { }

	protected void ProcessMouseEvent(int id) { }

	protected void ProcessMouseEvent() { }

	protected void ProcessMousePress(MouseButtonEventData data) { }

	private bool ProcessTouchEvents() { }

	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	protected bool SendMoveEventToSelectedObject() { }

	protected bool SendSubmitEventToSelectedObject() { }

	protected bool SendUpdateEventToSelectedObject() { }

	public void set_allowActivationOnMobileDevice(bool value) { }

	public void set_cancelButton(string value) { }

	public void set_forceModuleActive(bool value) { }

	public void set_horizontalAxis(string value) { }

	public void set_inputActionsPerSecond(float value) { }

	public void set_repeatDelay(float value) { }

	public void set_submitButton(string value) { }

	public void set_verticalAxis(string value) { }

	public virtual bool ShouldActivateModule() { }

	private bool ShouldIgnoreEventsOnNoFocus() { }

	public virtual void UpdateModule() { }

}

