namespace UnityEngine.UI;

public class VertexHelper : IDisposable
{
	private static readonly Vector4 s_DefaultTangent; //Field offset: 0x0
	private static readonly Vector3 s_DefaultNormal; //Field offset: 0x10
	private List<Vector3> m_Positions; //Field offset: 0x10
	private List<Color32> m_Colors; //Field offset: 0x18
	private List<Vector4> m_Uv0S; //Field offset: 0x20
	private List<Vector4> m_Uv1S; //Field offset: 0x28
	private List<Vector4> m_Uv2S; //Field offset: 0x30
	private List<Vector4> m_Uv3S; //Field offset: 0x38
	private List<Vector3> m_Normals; //Field offset: 0x40
	private List<Vector4> m_Tangents; //Field offset: 0x48
	private List<Int32> m_Indices; //Field offset: 0x50
	private bool m_ListsInitalized; //Field offset: 0x58

	public int currentIndexCount
	{
		 get { } //Length: 65
	}

	public int currentVertCount
	{
		 get { } //Length: 799
	}

	private static VertexHelper() { }

	public VertexHelper() { }

	public VertexHelper(Mesh m) { }

	public void AddTriangle(int idx0, int idx1, int idx2) { }

	public void AddUIVertexQuad(UIVertex[] verts) { }

	public void AddUIVertexStream(List<UIVertex> verts, List<Int32> indices) { }

	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	public void AddVert(UIVertex v) { }

	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	public void Clear() { }

	public override void Dispose() { }

	public void FillMesh(Mesh mesh) { }

	public int get_currentIndexCount() { }

	public int get_currentVertCount() { }

	public void GetUIVertexStream(List<UIVertex> stream) { }

	private void InitializeListIfRequired() { }

	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	public void SetUIVertex(UIVertex vertex, int i) { }

}

