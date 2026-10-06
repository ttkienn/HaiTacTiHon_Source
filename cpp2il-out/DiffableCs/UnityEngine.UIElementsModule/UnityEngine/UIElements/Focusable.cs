namespace UnityEngine.UIElements;

public abstract class Focusable : CallbackEventHandler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <focusable>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <tabIndex>k__BackingField; //Field offset: 0x24
	private bool m_DelegatesFocus; //Field offset: 0x28
	private bool m_ExcludeFromFocusRing; //Field offset: 0x29

	public override bool canGrabFocus
	{
		 get { } //Length: 5
	}

	public bool delegatesFocus
	{
		 get { } //Length: 7
		 set { } //Length: 4
	}

	internal bool excludeFromFocusRing
	{
		internal get { } //Length: 7
		internal set { } //Length: 208
	}

	public bool focusable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public abstract FocusController focusController
	{
		 get { } //Length: 0
	}

	public int tabIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected Focusable() { }

	public override void Blur() { }

	internal void BlurImmediately() { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(PointerDownEvent), typeof(NavigationMoveEvent)}])]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(PointerDownEvent), typeof(NavigationMoveEvent)}])]
	internal virtual void ExecuteDefaultActionDisabled(EventBase evt) { }

	public override void Focus() { }

	public override bool get_canGrabFocus() { }

	public bool get_delegatesFocus() { }

	internal bool get_excludeFromFocusRing() { }

	[CompilerGenerated]
	public bool get_focusable() { }

	public abstract FocusController get_focusController() { }

	[CompilerGenerated]
	public int get_tabIndex() { }

	private static Focusable GetFirstFocusableChild(VisualElement ve) { }

	private Focusable GetFocusDelegate() { }

	private void ProcessEvent(EventBase evt) { }

	public void set_delegatesFocus(bool value) { }

	internal void set_excludeFromFocusRing(bool value) { }

	[CompilerGenerated]
	public void set_focusable(bool value) { }

	[CompilerGenerated]
	public void set_tabIndex(int value) { }

}

