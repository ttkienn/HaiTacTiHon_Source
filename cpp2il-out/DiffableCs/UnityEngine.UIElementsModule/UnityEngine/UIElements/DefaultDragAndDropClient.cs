namespace UnityEngine.UIElements;

internal class DefaultDragAndDropClient : DragAndDropData, IDragAndDrop
{
	private readonly Hashtable m_GenericData; //Field offset: 0x10
	private Label m_DraggedInfoLabel; //Field offset: 0x18
	private DragVisualMode m_VisualMode; //Field offset: 0x20
	private IEnumerable<Object> m_UnityObjectReferences; //Field offset: 0x28

	public override DragAndDropData data
	{
		 get { } //Length: 4
	}

	public virtual object source
	{
		 get { } //Length: 72
	}

	public DefaultDragAndDropClient() { }

	public override void AcceptDrag() { }

	public override void DragCleanup() { }

	public override DragAndDropData get_data() { }

	public virtual object get_source() { }

	public virtual object GetGenericData(string key) { }

	public override void SetVisualMode(DragVisualMode mode) { }

	public override void StartDrag(StartDragArgs args, Vector3 pointerPosition) { }

	public override void UpdateDrag(Vector3 pointerPosition) { }

}

