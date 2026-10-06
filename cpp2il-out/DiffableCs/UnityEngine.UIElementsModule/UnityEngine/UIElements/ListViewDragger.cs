namespace UnityEngine.UIElements;

internal class ListViewDragger : DragEventsProcessor
{
	public struct DragPosition : IEquatable<DragPosition>
	{
		public int insertAtIndex; //Field offset: 0x0
		public int parentId; //Field offset: 0x4
		public int childIndex; //Field offset: 0x8
		public ReusableCollectionItem recycledItem; //Field offset: 0x10
		public DragAndDropPosition dropPosition; //Field offset: 0x18

		public override bool Equals(DragPosition other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	private DragPosition m_LastDragPosition; //Field offset: 0x30
	private VisualElement m_DragHoverBar; //Field offset: 0x50
	private VisualElement m_DragHoverItemMarker; //Field offset: 0x58
	private VisualElement m_DragHoverSiblingMarker; //Field offset: 0x60
	private float m_LeftIndentation; //Field offset: 0x68
	private float m_SiblingBottom; //Field offset: 0x6C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ICollectionDragAndDropController <dragAndDropController>k__BackingField; //Field offset: 0x70

	public ICollectionDragAndDropController dragAndDropController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	protected ScrollView targetScrollView
	{
		 get { } //Length: 33
	}

	protected BaseVerticalCollectionView targetView
	{
		 get { } //Length: 130
	}

	public ListViewDragger(BaseVerticalCollectionView listView) { }

	[CompilerGenerated]
	private void <ApplyDragAndDropUI>g__GeometryChangedCallback|27_0(GeometryChangedEvent e) { }

	private void ApplyDragAndDropUI(DragPosition dragPosition) { }

	protected virtual bool CanStartDrag(Vector3 pointerPosition) { }

	protected virtual void ClearDragAndDropUI(bool dragCancelled) { }

	[CompilerGenerated]
	public ICollectionDragAndDropController get_dragAndDropController() { }

	protected ScrollView get_targetScrollView() { }

	protected BaseVerticalCollectionView get_targetView() { }

	private float GetHoverBarTopPosition(ReusableCollectionItem item) { }

	private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId) { }

	protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition) { }

	private DragVisualMode GetVisualMode(Vector3 pointerPosition, ref DragPosition dragPosition) { }

	private void HandleAutoExpansion(Vector2 pointerPosition) { }

	internal void HandleDragAndScroll(Vector2 pointerPosition) { }

	private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref DragPosition dragPosition, Vector2 pointerPosition) { }

	private void HandleTreePosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	protected DragAndDropArgs MakeDragAndDropArgs(DragPosition dragPosition) { }

	protected private virtual void OnDrop(Vector3 pointerPosition) { }

	private void PlaceHoverBarAt(float top, float indentationPadding = -1, float siblingBottom = -1) { }

	private void PlaceHoverBarAtElement(ReusableCollectionItem item) { }

	[CompilerGenerated]
	public void set_dragAndDropController(ICollectionDragAndDropController value) { }

	protected private virtual StartDragArgs StartDrag(Vector3 pointerPosition) { }

	protected override bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	protected private virtual void UpdateDrag(Vector3 pointerPosition) { }

}

