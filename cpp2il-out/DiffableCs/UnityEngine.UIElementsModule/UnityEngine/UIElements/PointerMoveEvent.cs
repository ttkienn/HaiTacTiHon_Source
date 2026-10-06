namespace UnityEngine.UIElements;

[EventCategory(EventCategory::PointerMove (2))]
public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PointerMoveEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isHandledByDraggable>k__BackingField; //Field offset: 0x110

	internal bool isHandledByDraggable
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	private static PointerMoveEvent() { }

	public PointerMoveEvent() { }

	[CompilerGenerated]
	internal bool get_isHandledByDraggable() { }

	protected virtual void Init() { }

	private void LocalInit() { }

	protected private virtual void PostDispatch(IPanel panel) { }

	[CompilerGenerated]
	internal void set_isHandledByDraggable(bool value) { }

}

