namespace UnityEngine.UIElements;

internal class VisualElementPanelActivator
{
	private IVisualElementPanelActivatable m_Activatable; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isActive>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isDetaching>k__BackingField; //Field offset: 0x19
	private EventCallback<AttachToPanelEvent> m_OnAttachToPanelCallback; //Field offset: 0x20
	private EventCallback<DetachFromPanelEvent> m_OnDetachFromPanelCallback; //Field offset: 0x28

	public private bool isActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool isDetaching
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public VisualElementPanelActivator(IVisualElementPanelActivatable activatable) { }

	[CompilerGenerated]
	public bool get_isActive() { }

	[CompilerGenerated]
	public bool get_isDetaching() { }

	private void OnEnter(AttachToPanelEvent evt) { }

	private void OnLeave(DetachFromPanelEvent evt) { }

	public void SendActivation() { }

	public void SendDeactivation() { }

	[CompilerGenerated]
	private void set_isActive(bool value) { }

	[CompilerGenerated]
	private void set_isDetaching(bool value) { }

	public void SetActive(bool action) { }

}

