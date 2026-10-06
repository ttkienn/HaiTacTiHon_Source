namespace UnityEngine.UIElements;

internal interface IDragAndDrop
{

	public DragAndDropData data
	{
		 get { } //Length: 0
	}

	public void AcceptDrag() { }

	public void DragCleanup() { }

	public DragAndDropData get_data() { }

	public void SetVisualMode(DragVisualMode visualMode) { }

	public void StartDrag(StartDragArgs args, Vector3 pointerPosition) { }

	public void UpdateDrag(Vector3 pointerPosition) { }

}

