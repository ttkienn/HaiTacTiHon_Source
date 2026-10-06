namespace UnityEngine.Rendering;

public static class RenderPipelineManager
{
	internal static RenderPipelineAsset s_CurrentPipelineAsset; //Field offset: 0x0
	private static List<Camera> s_Cameras; //Field offset: 0x8
	private static string s_CurrentPipelineType; //Field offset: 0x10
	private static RenderPipeline s_CurrentPipeline; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineTypeChanged; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineCreated; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineDisposed; //Field offset: 0x38

	public private static RenderPipeline currentPipeline
	{
		 get { } //Length: 79
		private set { } //Length: 240
	}

	private static RenderPipelineManager() { }

	[RequiredByNativeCode]
	internal static void CleanupRenderPipeline() { }

	[RequiredByNativeCode]
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, object renderRequest) { }

	public static RenderPipeline get_currentPipeline() { }

	[RequiredByNativeCode]
	private static string GetCurrentPipelineAssetType() { }

	[RequiredByNativeCode]
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	private static bool IsPipelineRequireCreation() { }

	[RequiredByNativeCode]
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	[RequiredByNativeCode]
	internal static void OnActiveRenderPipelineTypeChanged() { }

	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	private static void set_currentPipeline(RenderPipeline value) { }

}

