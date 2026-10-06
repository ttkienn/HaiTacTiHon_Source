namespace UnityEngine.Rendering;

public abstract class RenderPipeline
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x10

	public private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal void Dispose() { }

	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	public bool get_disposed() { }

	internal void InternalProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras) { }

	protected override void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras) { }

	protected override void Render(ScriptableRenderContext context, List<Camera> cameras) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

}

