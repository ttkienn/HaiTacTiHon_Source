namespace UnityEngine.Experimental.U2D;

[NativeHeader("Runtime/2D/Renderer/SpriteRendererGroup.h")]
[RequiredByNativeCode]
internal struct SpriteIntermediateRendererInfo
{
	public int SpriteID; //Field offset: 0x0
	public int TextureID; //Field offset: 0x4
	public int MaterialID; //Field offset: 0x8
	public Color Color; //Field offset: 0xC
	public Matrix4x4 Transform; //Field offset: 0x1C
	public Bounds Bounds; //Field offset: 0x5C
	public int Layer; //Field offset: 0x74
	public int SortingLayer; //Field offset: 0x78
	public int SortingOrder; //Field offset: 0x7C
	public ulong SceneCullingMask; //Field offset: 0x80
	public IntPtr IndexData; //Field offset: 0x88
	public IntPtr VertexData; //Field offset: 0x90
	public int IndexCount; //Field offset: 0x98
	public int VertexCount; //Field offset: 0x9C
	public int ShaderChannelMask; //Field offset: 0xA0

}

