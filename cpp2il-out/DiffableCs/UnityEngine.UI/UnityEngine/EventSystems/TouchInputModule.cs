namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Touch Input Module")]
[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
public class TouchInputModule : PointerInputModule
{
	private Vector2 m_LastMousePosition; //Field offset: 0x68
	private Vector2 m_MousePosition; //Field offset: 0x70
	private PointerEventData m_InputPointerEvent; //Field offset: 0x78
	[FormerlySerializedAs("m_AllowActivationOnStandalone")]
	[SerializeField]
	private bool m_ForceModuleActive; //Field offset: 0x80

	[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnStandalone
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool forceModuleActive
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	protected TouchInputModule() { }

	public virtual void DeactivateModule() { }

	private void FakeTouches() { }

	public bool get_allowActivationOnStandalone() { }

	public bool get_forceModuleActive() { }

	public virtual bool IsModuleSupported() { }

	public virtual void Process() { }

	private void ProcessTouchEvents() { }

	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	public void set_allowActivationOnStandalone(bool value) { }

	public void set_forceModuleActive(bool value) { }

	public virtual bool ShouldActivateModule() { }

	public virtual string ToString() { }

	public virtual void UpdateModule() { }

	private bool UseFakeInput() { }

}

