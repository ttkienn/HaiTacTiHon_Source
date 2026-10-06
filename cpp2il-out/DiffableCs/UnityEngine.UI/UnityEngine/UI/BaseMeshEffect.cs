namespace UnityEngine.UI;

[ExecuteAlways]
public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
{
	private Graphic m_Graphic; //Field offset: 0x20

	protected Graphic graphic
	{
		 get { } //Length: 141
	}

	protected BaseMeshEffect() { }

	protected Graphic get_graphic() { }

	public override void ModifyMesh(Mesh mesh) { }

	public abstract void ModifyMesh(VertexHelper vh) { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

}

