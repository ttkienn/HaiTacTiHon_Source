namespace UnityEngine.UIElements.UIR;

internal static class MeshBuilder
{
	public struct AllocMeshData
	{
		public sealed class Allocator : MulticastDelegate
		{

			public Allocator(object object, IntPtr method) { }

			public override MeshWriteData Invoke(uint vertexCount, uint indexCount, ref AllocMeshData allocatorData) { }

		}

		internal Allocator alloc; //Field offset: 0x0
		internal Texture texture; //Field offset: 0x8
		internal TextureId svgTexture; //Field offset: 0x10
		internal Material material; //Field offset: 0x18
		internal MeshFlags flags; //Field offset: 0x20
		internal BMPAlloc colorAlloc; //Field offset: 0x24

		internal MeshWriteData Allocate(uint vertexCount, uint indexCount) { }

	}

	private static ProfilerMarker s_VectorGraphics9Slice; //Field offset: 0x0
	private static ProfilerMarker s_VectorGraphicsSplitTriangle; //Field offset: 0x8
	private static ProfilerMarker s_VectorGraphicsScaleTriangle; //Field offset: 0x10
	private static ProfilerMarker s_VectorGraphicsStretch; //Field offset: 0x18
	internal static readonly int s_MaxTextMeshVertices; //Field offset: 0x20

	private static MeshBuilder() { }

	private static Vertex ConvertTextVertexToUIRVertex(MeshInfo info, int index, Vector2 offset, VertexFlags flags = 1, bool isDynamicColor = false) { }

	private static int LimitTextVertices(int vertexCount, bool logTruncation = true) { }

	internal static void MakeText(MeshInfo meshInfo, Vector2 offset, AllocMeshData meshAlloc, VertexFlags flags = 1, bool isDynamicColor = false) { }

}

