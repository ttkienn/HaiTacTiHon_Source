namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Tooltip (15))]
public class TooltipEvent : EventBase<TooltipEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TooltipEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <tooltip>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Rect <rect>k__BackingField; //Field offset: 0x90

	public Rect rect
	{
		[CompilerGenerated]
		 set { } //Length: 11
	}

	public string tooltip
	{
		[CompilerGenerated]
		 set { } //Length: 19
	}

	private static TooltipEvent() { }

	public TooltipEvent() { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	public void set_rect(Rect value) { }

	[CompilerGenerated]
	public void set_tooltip(string value) { }

}

