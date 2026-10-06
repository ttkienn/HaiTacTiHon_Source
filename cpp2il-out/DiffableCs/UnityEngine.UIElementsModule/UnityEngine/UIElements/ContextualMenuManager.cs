namespace UnityEngine.UIElements;

public abstract class ContextualMenuManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <displayMenuHandledOSX>k__BackingField; //Field offset: 0x10

	internal bool displayMenuHandledOSX
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	protected ContextualMenuManager() { }

	public void DisplayMenu(EventBase triggerEvent, IEventHandler target) { }

	public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler) { }

	protected private abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent) { }

	[CompilerGenerated]
	internal bool get_displayMenuHandledOSX() { }

	[CompilerGenerated]
	internal void set_displayMenuHandledOSX(bool value) { }

}

