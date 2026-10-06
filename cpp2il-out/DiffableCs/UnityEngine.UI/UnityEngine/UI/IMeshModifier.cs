namespace UnityEngine.UI;

public interface IMeshModifier
{

	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", False)]
	public void ModifyMesh(Mesh mesh) { }

	public void ModifyMesh(VertexHelper verts) { }

}

