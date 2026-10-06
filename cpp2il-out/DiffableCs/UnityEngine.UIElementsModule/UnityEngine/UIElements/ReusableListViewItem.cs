namespace UnityEngine.UIElements;

internal class ReusableListViewItem : ReusableCollectionItem
{
	private VisualElement m_Container; //Field offset: 0x48
	private VisualElement m_DragHandle; //Field offset: 0x50
	private VisualElement m_ItemContainer; //Field offset: 0x58

	public virtual VisualElement rootElement
	{
		 get { } //Length: 14
	}

	public ReusableListViewItem() { }

	public virtual void DetachElement() { }

	public virtual VisualElement get_rootElement() { }

	public void Init(VisualElement item, bool usesAnimatedDragger) { }

	public virtual void PreAttachElement() { }

	public virtual void SetDragGhost(bool dragGhost) { }

	public void UpdateDragHandle(bool needsDragHandle) { }

	protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger) { }

}

