namespace UnityEngine.TextCore.Text;

internal struct MeshInfo
{
	private static readonly Color32 k_DefaultColor; //Field offset: 0x0
	private static readonly Vector3 k_DefaultNormal; //Field offset: 0x4
	private static readonly Vector4 k_DefaultTangent; //Field offset: 0x10
	public int vertexCount; //Field offset: 0x0
	public Vector3[] vertices; //Field offset: 0x8
	public Vector3[] normals; //Field offset: 0x10
	public Vector4[] tangents; //Field offset: 0x18
	public Vector4[] uvs0; //Field offset: 0x20
	public Vector2[] uvs2; //Field offset: 0x28
	public Color32[] colors32; //Field offset: 0x30
	public Int32[] triangles; //Field offset: 0x38
	public Material material; //Field offset: 0x40
	internal GlyphRenderMode glyphRenderMode; //Field offset: 0x48

	private static MeshInfo() { }

	public MeshInfo(int size) { }

	internal void Clear(bool uploadChanges) { }

	internal void ClearUnusedVertices() { }

	internal void ResizeMeshInfo(int size) { }

	internal void SortGeometry(VertexSortingOrder order) { }

	internal void SwapVertexData(int src, int dst) { }

}

