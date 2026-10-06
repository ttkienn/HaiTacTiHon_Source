namespace UnityEngine.UIElements;

internal class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	protected readonly BaseListView m_ListView; //Field offset: 0x28

	public ListViewReorderableDragAndDropController(BaseListView view) { }

	public virtual DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	public virtual void OnDrop(IListDragAndDropArgs args) { }

}

