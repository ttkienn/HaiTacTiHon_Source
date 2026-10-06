namespace UnityEngine.UIElements.UIR;

internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand>
{
	private static readonly int k_ID_MainTex; //Field offset: 0x0
	private static ProfilerMarker s_ImmediateOverheadMarker; //Field offset: 0x8
	internal VisualElement owner; //Field offset: 0x18
	internal RenderChainCommand prev; //Field offset: 0x20
	internal RenderChainCommand next; //Field offset: 0x28
	internal bool closing; //Field offset: 0x30
	internal CommandType type; //Field offset: 0x34
	internal State state; //Field offset: 0x38
	internal MeshHandle mesh; //Field offset: 0x50
	internal int indexOffset; //Field offset: 0x58
	internal int indexCount; //Field offset: 0x5C
	internal Action callback; //Field offset: 0x60

	private static RenderChainCommand() { }

	public RenderChainCommand() { }

	private void Blit(Texture source, RenderTexture destination, float depth) { }

	private static Rect CombineScissorRects(Rect r0, Rect r1) { }

	internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException) { }

	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) { }

	internal void Reset() { }

}

