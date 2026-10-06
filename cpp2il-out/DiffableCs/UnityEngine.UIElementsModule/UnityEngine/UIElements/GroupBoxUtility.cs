namespace UnityEngine.UIElements;

[Extension]
internal static class GroupBoxUtility
{
	private static Dictionary<IGroupBox, IGroupManager> s_GroupManagers; //Field offset: 0x0
	private static Dictionary<IGroupBoxOption, IGroupManager> s_GroupOptionManagerCache; //Field offset: 0x8
	private static readonly Type k_GenericGroupBoxType; //Field offset: 0x10

	private static GroupBoxUtility() { }

	private static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox) { }

	private static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt) { }

	[Extension]
	public static void OnOptionSelected(T selectedOption) { }

	private static void OnPanelDestroyed(BaseVisualElementPanel panel) { }

	[Extension]
	public static void RegisterGroupBoxOption(T option) { }

	[Extension]
	public static void UnregisterGroupBoxOption(T option) { }

}

