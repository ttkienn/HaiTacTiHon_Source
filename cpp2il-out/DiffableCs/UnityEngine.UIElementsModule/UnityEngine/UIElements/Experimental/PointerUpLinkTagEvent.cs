namespace UnityEngine.UIElements.Experimental;

public class PointerUpLinkTagEvent : PointerEventBase<PointerUpLinkTagEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PointerUpLinkTagEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <linkID>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <linkText>k__BackingField; //Field offset: 0x118

	private string linkID
	{
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private string linkText
	{
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private static PointerUpLinkTagEvent() { }

	public PointerUpLinkTagEvent() { }

	public static PointerUpLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	private void set_linkID(string value) { }

	[CompilerGenerated]
	private void set_linkText(string value) { }

}

