namespace UnityEngine.UI;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use IMeshModifier instead", True)]
public interface IVertexModifier
{

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", True)]
	public void ModifyVertices(List<UIVertex> verts) { }

}

