namespace UnityEngine.UIElements;

[EventCategory(EventCategory::ChangePanel (11))]
public abstract class PanelChangedEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IPanel <originPanel>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IPanel <destinationPanel>k__BackingField; //Field offset: 0x0

	public private IPanel destinationPanel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private IPanel originPanel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	protected PanelChangedEventBase`1() { }

	[CompilerGenerated]
	public IPanel get_destinationPanel() { }

	[CompilerGenerated]
	public IPanel get_originPanel() { }

	public static T GetPooled(IPanel originPanel, IPanel destinationPanel) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	private void set_destinationPanel(IPanel value) { }

	[CompilerGenerated]
	private void set_originPanel(IPanel value) { }

}

