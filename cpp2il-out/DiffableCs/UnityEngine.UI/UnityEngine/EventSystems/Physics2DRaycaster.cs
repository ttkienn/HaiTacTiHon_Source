namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Physics 2D Raycaster")]
[RequireComponent(typeof(Camera))]
public class Physics2DRaycaster : PhysicsRaycaster
{
	private RaycastHit2D[] m_Hits; //Field offset: 0x48

	protected Physics2DRaycaster() { }

	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

}

