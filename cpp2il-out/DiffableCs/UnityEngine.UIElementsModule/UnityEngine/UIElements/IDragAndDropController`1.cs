namespace UnityEngine.UIElements;

internal interface IDragAndDropController
{

	public bool CanStartDrag(IEnumerable<Int32> itemIds) { }

	public void DragCleanup() { }

	public IEnumerable<Int32> GetSortedSelectedIds() { }

	public void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	public DragVisualMode HandleDragAndDrop(TArgs args) { }

	public void OnDrop(TArgs args) { }

	public StartDragArgs SetupDragAndDrop(IEnumerable<Int32> itemIds, bool skipText = false) { }

}

