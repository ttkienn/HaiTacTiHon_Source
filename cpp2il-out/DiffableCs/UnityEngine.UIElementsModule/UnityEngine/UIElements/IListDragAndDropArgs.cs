namespace UnityEngine.UIElements;

internal interface IListDragAndDropArgs
{

	public int childIndex
	{
		 get { } //Length: 0
	}

	public DragAndDropData dragAndDropData
	{
		 get { } //Length: 0
	}

	public DragAndDropPosition dragAndDropPosition
	{
		 get { } //Length: 0
	}

	public int insertAtIndex
	{
		 get { } //Length: 0
	}

	public int parentId
	{
		 get { } //Length: 0
	}

	public int get_childIndex() { }

	public DragAndDropData get_dragAndDropData() { }

	public DragAndDropPosition get_dragAndDropPosition() { }

	public int get_insertAtIndex() { }

	public int get_parentId() { }

}

