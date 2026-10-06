namespace UnityEngine.UIElements;

public class DropdownMenuAction : DropdownMenuItem
{
	[Flags]
	internal enum Status
	{
		None = 0,
		Normal = 1,
		Disabled = 2,
		Checked = 4,
		Hidden = 8,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Status <status>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DropdownMenuEventInfo <eventInfo>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private object <userData>k__BackingField; //Field offset: 0x28
	private readonly Action<DropdownMenuAction> actionCallback; //Field offset: 0x30
	private readonly Func<DropdownMenuAction, Status> actionStatusCallback; //Field offset: 0x38

	private DropdownMenuEventInfo eventInfo
	{
		[CompilerGenerated]
		private set { } //Length: 13
	}

	private Status status
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private object userData
	{
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null) { }

	public static Status AlwaysDisabled(DropdownMenuAction a) { }

	public static Status AlwaysEnabled(DropdownMenuAction a) { }

	[CompilerGenerated]
	private void set_eventInfo(DropdownMenuEventInfo value) { }

	[CompilerGenerated]
	private void set_status(Status value) { }

	[CompilerGenerated]
	private void set_userData(object value) { }

	public void UpdateActionStatus(DropdownMenuEventInfo eventInfo) { }

}

