namespace UnityEngine.UIElements;

[IsReadOnly]
internal struct SetupDragAndDropArgs
{
	public readonly VisualElement draggedElement; //Field offset: 0x0
	public readonly IEnumerable<Int32> selectedIds; //Field offset: 0x8
	public readonly StartDragArgs startDragArgs; //Field offset: 0x10

	internal SetupDragAndDropArgs(VisualElement draggedElement, IEnumerable<Int32> selectedIds, StartDragArgs startDragArgs) { }

}

