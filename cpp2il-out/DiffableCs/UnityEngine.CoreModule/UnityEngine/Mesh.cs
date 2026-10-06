namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[RequiredByNativeCode]
public sealed class Mesh : object
{
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[StaticAccessor("MeshDataBindings", StaticAccessorType::DoubleColon (2))]
	internal struct MeshData
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_Ptr; //Field offset: 0x0

	}


	internal bool canAccess
	{
		[NativeMethod("CanAccessFromScript")]
		internal get { } //Length: 51
	}

	public Color32[] colors32
	{
		 get { } //Length: 80
	}

	public Vector3[] normals
	{
		 get { } //Length: 62
	}

	public int subMeshCount
	{
		[NativeMethod(Name = "GetSubMeshCount")]
		 get { } //Length: 51
	}

	public Vector4[] tangents
	{
		 get { } //Length: 62
	}

	public int vertexCount
	{
		[NativeMethod("GetVertexCount")]
		 get { } //Length: 51
	}

	public Vector3[] vertices
	{
		 get { } //Length: 59
	}

	[RequiredByNativeCode]
	public Mesh() { }

	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	[ExcludeFromDocs]
	public void Clear() { }

	[NativeMethod("Clear")]
	private void ClearImpl(bool keepVertexLayout) { }

	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	[NativeMethod("CanAccessFromScript")]
	internal bool get_canAccess() { }

	public Color32[] get_colors32() { }

	public Vector3[] get_normals() { }

	[NativeMethod(Name = "GetSubMeshCount")]
	public int get_subMeshCount() { }

	public Vector4[] get_tangents() { }

	[NativeMethod("GetVertexCount")]
	public int get_vertexCount() { }

	public Vector3[] get_vertices() { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = True)]
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	[ExcludeFromDocs]
	public Int32[] GetIndices(int submesh) { }

	public Int32[] GetIndices(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = True)]
	private Int32[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }

	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	public void GetUVs(int channel, List<Vector4> uvs) { }

	private void GetUVsImpl(int uvIndex, List<T> uvs, int dim) { }

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunction("MeshScripting::CreateMesh")]
	private static void Internal_Create(Mesh mono) { }

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	private void PrintErrorCantAccessIndices() { }

	public void RecalculateBounds(MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void RecalculateBounds() { }

	[NativeMethod("RecalculateBounds")]
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	public void SetColors(List<Color32> inColors) { }

	[ExcludeFromDocs]
	public void SetColors(List<Color32> inColors, int start, int length) { }

	public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	private void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	private void SetListForChannel(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	public void SetNormals(List<Vector3> inNormals) { }

	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	public void SetTangents(List<Vector4> inTangents) { }

	[ExcludeFromDocs]
	public void SetTriangles(List<Int32> triangles, int submesh) { }

	public void SetTriangles(List<Int32> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(List<Int32> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector4> uvs) { }

	private void SetUvsImpl(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	public void SetVertices(List<Vector3> inVertices) { }

	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

}

