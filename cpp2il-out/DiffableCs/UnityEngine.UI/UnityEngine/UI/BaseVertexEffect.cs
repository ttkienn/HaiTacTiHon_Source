namespace UnityEngine.UI;

[Obsolete("Use BaseMeshEffect instead", True)]
public abstract class BaseVertexEffect
{

	protected BaseVertexEffect() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", True)]
	public abstract void ModifyVertices(List<UIVertex> vertices) { }

}

