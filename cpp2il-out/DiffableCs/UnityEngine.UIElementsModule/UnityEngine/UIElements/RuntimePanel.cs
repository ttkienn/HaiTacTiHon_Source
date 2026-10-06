namespace UnityEngine.UIElements;

internal class RuntimePanel : BaseRuntimePanel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static EventCallback<FocusEvent, RuntimePanel> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__5_0(FocusEvent e, RuntimePanel p) { }

	}

	internal static readonly EventDispatcher s_EventDispatcher; //Field offset: 0x0
	private readonly PanelSettings m_PanelSettings; //Field offset: 0x1E8

	public override PanelSettings panelSettings
	{
		 get { } //Length: 8
	}

	private static RuntimePanel() { }

	private RuntimePanel(ScriptableObject ownerObject) { }

	public static RuntimePanel Create(ScriptableObject ownerObject) { }

	public override PanelSettings get_panelSettings() { }

	private void OnElementFocus(FocusEvent evt) { }

	public virtual void Update() { }

}

