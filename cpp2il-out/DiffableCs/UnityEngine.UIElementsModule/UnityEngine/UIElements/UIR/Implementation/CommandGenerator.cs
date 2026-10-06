namespace UnityEngine.UIElements.UIR.Implementation;

[Extension]
internal static class CommandGenerator
{
	private static readonly ProfilerMarker k_GenerateEntries; //Field offset: 0x0
	private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker; //Field offset: 0x8
	private static readonly ProfilerMarker k_GenerateClosingCommandsMarker; //Field offset: 0x10
	private static readonly ProfilerMarker k_NudgeVerticesMarker; //Field offset: 0x18
	private static readonly ProfilerMarker k_UpdateOpacityIdMarker; //Field offset: 0x20
	private static readonly ProfilerMarker k_ComputeTransformMatrixMarker; //Field offset: 0x28
	private static Material s_blitMaterial_LinearToGamma; //Field offset: 0x30
	private static Material s_blitMaterial_GammaToLinear; //Field offset: 0x38
	private static Material s_blitMaterial_NoChange; //Field offset: 0x40
	private static Shader s_blitShader; //Field offset: 0x48

	private static CommandGenerator() { }

	public static void ClosePaintElement(VisualElement ve, ClosingInfo closingInfo, RenderChain renderChain, ref ChainBuilderStats stats) { }

	internal static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, out Matrix4x4 result) { }

	private static Material CreateBlitShader(float colorConversion) { }

	private static void DoUpdateOpacityId(VisualElement ve, RenderChain renderChain, MeshHandle mesh) { }

	private static void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	private static void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	private static Material GetBlitMaterial(RenderTargetMode mode) { }

	private static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform) { }

	private static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) { }

	private static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) { }

	private static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	private static void InvokeGenerateVisualContent(VisualElement ve, MeshGenerationContext ctx) { }

	[Extension]
	private static bool IsParentOrAncestorOf(VisualElement ve, VisualElement child) { }

	public static bool NudgeVerticesToNewSpace(VisualElement ve, RenderChain renderChain, UIRenderDevice device) { }

	public static ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ref ChainBuilderStats stats) { }

	private static void PrepareNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, out IntPtr src, out IntPtr dst, out int count) { }

	public static void ResetCommands(RenderChain renderChain, VisualElement ve) { }

	public static void UpdateOpacityId(VisualElement ve, RenderChain renderChain) { }

	private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex>& verts, out NativeSlice<UInt16>& indices, out ushort indexOffset, ref ChainBuilderStats stats) { }

}

