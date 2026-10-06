namespace UnityEngine.UIElements;

public class DropdownMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Status status; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal Status <AppendAction>b__0(DropdownMenuAction e) { }

	}

	private List<DropdownMenuItem> m_MenuItems; //Field offset: 0x10
	private DropdownMenuEventInfo m_DropdownMenuEventInfo; //Field offset: 0x18

	public DropdownMenu() { }

	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null) { }

	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Status status = 1) { }

	public void AppendSeparator(string subMenuPath = null) { }

	public void InsertSeparator(string subMenuPath, int atIndex) { }

	public List<DropdownMenuItem> MenuItems() { }

	public void PrepareForDisplay(EventBase e) { }

}

