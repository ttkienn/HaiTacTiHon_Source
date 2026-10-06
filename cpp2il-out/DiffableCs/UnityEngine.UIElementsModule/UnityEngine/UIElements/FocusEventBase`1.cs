namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Focus (10))]
public abstract class FocusEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Focusable <relatedTarget>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FocusChangeDirection <direction>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FocusController <focusController>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <IsFocusDelegated>k__BackingField; //Field offset: 0x0

	public private override FocusChangeDirection direction
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	protected private FocusController focusController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal bool IsFocusDelegated
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private override Focusable relatedTarget
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	protected FocusEventBase`1() { }

	[CompilerGenerated]
	public override FocusChangeDirection get_direction() { }

	[CompilerGenerated]
	protected FocusController get_focusController() { }

	[CompilerGenerated]
	internal bool get_IsFocusDelegated() { }

	[CompilerGenerated]
	public override Focusable get_relatedTarget() { }

	public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	private void set_direction(FocusChangeDirection value) { }

	[CompilerGenerated]
	private void set_focusController(FocusController value) { }

	[CompilerGenerated]
	private void set_IsFocusDelegated(bool value) { }

	[CompilerGenerated]
	private void set_relatedTarget(Focusable value) { }

}

