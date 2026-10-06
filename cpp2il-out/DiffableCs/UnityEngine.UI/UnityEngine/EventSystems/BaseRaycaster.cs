namespace UnityEngine.EventSystems;

public abstract class BaseRaycaster : UIBehaviour
{
	private BaseRaycaster m_RootRaycaster; //Field offset: 0x20

	public abstract Camera eventCamera
	{
		 get { } //Length: 0
	}

	[Obsolete("Please use sortOrderPriority and renderOrderPriority", False)]
	public override int priority
	{
		 get { } //Length: 3
	}

	public override int renderOrderPriority
	{
		 get { } //Length: 6
	}

	public BaseRaycaster rootRaycaster
	{
		 get { } //Length: 178
	}

	public override int sortOrderPriority
	{
		 get { } //Length: 6
	}

	protected BaseRaycaster() { }

	public abstract Camera get_eventCamera() { }

	public override int get_priority() { }

	public override int get_renderOrderPriority() { }

	public BaseRaycaster get_rootRaycaster() { }

	public override int get_sortOrderPriority() { }

	protected virtual void OnCanvasHierarchyChanged() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnTransformParentChanged() { }

	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	public virtual string ToString() { }

}

