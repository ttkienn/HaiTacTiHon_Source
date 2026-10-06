namespace UnityEngine.UIElements;

[IsReadOnly]
internal struct CanStartDragArgs
{
	public readonly VisualElement draggedElement; //Field offset: 0x0
	public readonly int id; //Field offset: 0x8
	public readonly IEnumerable<Int32> selectedIds; //Field offset: 0x10

	internal CanStartDragArgs(VisualElement draggedElement, int id, IEnumerable<Int32> selectedIds) { }

}

