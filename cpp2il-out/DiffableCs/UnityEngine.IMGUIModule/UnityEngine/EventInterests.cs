namespace UnityEngine;

internal struct EventInterests
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <wantsMouseMove>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; //Field offset: 0x1
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <wantsLessLayoutEvents>k__BackingField; //Field offset: 0x2

	public bool wantsLessLayoutEvents
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public bool wantsMouseEnterLeaveWindow
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool wantsMouseMove
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 3
	}

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_wantsLessLayoutEvents() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_wantsMouseEnterLeaveWindow() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_wantsMouseMove() { }

	[CompilerGenerated]
	public void set_wantsMouseEnterLeaveWindow(bool value) { }

	[CompilerGenerated]
	public void set_wantsMouseMove(bool value) { }

	public bool WantsEvent(EventType type) { }

	public bool WantsLayoutPass(EventType type) { }

}

