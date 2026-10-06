namespace UnityEngine.UIElements;

internal class UIRRepaintUpdater : BaseVisualTreeUpdater
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	private BaseVisualElementPanel attachedPanel; //Field offset: 0x20
	internal RenderChain renderChain; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <drawStats>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <breakBatches>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x32

	public bool breakBatches
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool drawStats
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual ProfilerMarker profilerMarker
	{
		 get { } //Length: 79
	}

	private static UIRRepaintUpdater() { }

	public UIRRepaintUpdater() { }

	private void AttachToPanel() { }

	protected override RenderChain CreateRenderChain() { }

	internal void DestroyRenderChain() { }

	private void DetachFromPanel() { }

	protected virtual void Dispose(bool disposing) { }

	[CompilerGenerated]
	public bool get_breakBatches() { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	[CompilerGenerated]
	public bool get_drawStats() { }

	public virtual ProfilerMarker get_profilerMarker() { }

	private void InitRenderChain() { }

	private static void OnGraphicsResourcesRecreate(bool recreate) { }

	private void OnPanelAtlasChanged() { }

	private void OnPanelChanged(BaseVisualElementPanel obj) { }

	private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) { }

	private void OnPanelStandardShaderChanged() { }

	private void OnPanelStandardWorldSpaceShaderChanged() { }

	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	private void ResetAllElementsDataRecursive(VisualElement ve) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	public virtual void Update() { }

}

