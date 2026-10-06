namespace UnityEngine.UIElements;

internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater, IDisposable
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<BaseVisualElementPanel> panelChanged; //Field offset: 0x10
	private BaseVisualElementPanel m_Panel; //Field offset: 0x18

	public event Action<BaseVisualElementPanel> panelChanged
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public override BaseVisualElementPanel panel
	{
		 get { } //Length: 7
		 set { } //Length: 68
	}

	public abstract ProfilerMarker profilerMarker
	{
		 get { } //Length: 0
	}

	public VisualElement visualTree
	{
		 get { } //Length: 42
	}

	protected BaseVisualTreeUpdater() { }

	[CompilerGenerated]
	public void add_panelChanged(Action<BaseVisualElementPanel> value) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override BaseVisualElementPanel get_panel() { }

	public abstract ProfilerMarker get_profilerMarker() { }

	public VisualElement get_visualTree() { }

	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CompilerGenerated]
	public void remove_panelChanged(Action<BaseVisualElementPanel> value) { }

	public override void set_panel(BaseVisualElementPanel value) { }

	public abstract void Update() { }

}

