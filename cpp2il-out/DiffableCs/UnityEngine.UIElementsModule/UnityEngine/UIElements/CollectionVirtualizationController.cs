namespace UnityEngine.UIElements;

internal abstract class CollectionVirtualizationController
{
	protected readonly ScrollView m_ScrollView; //Field offset: 0x10

	public abstract IEnumerable<ReusableCollectionItem> activeItems
	{
		 get { } //Length: 0
	}

	public abstract int firstVisibleIndex
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract int visibleItemCount
	{
		 get { } //Length: 0
	}

	protected CollectionVirtualizationController(ScrollView scrollView) { }

	internal abstract void EndDrag(int dropIndex) { }

	public abstract IEnumerable<ReusableCollectionItem> get_activeItems() { }

	public abstract int get_firstVisibleIndex() { }

	public abstract int get_visibleItemCount() { }

	public abstract float GetExpectedContentHeight() { }

	public abstract float GetExpectedItemHeight(int index) { }

	public abstract int GetIndexFromPosition(Vector2 position) { }

	public abstract void OnBlur(VisualElement willFocus) { }

	public abstract void OnFocus(VisualElement leafTarget) { }

	public abstract void OnScroll(Vector2 offset) { }

	public abstract void Refresh(bool rebuild) { }

	public abstract void Resize(Vector2 size) { }

	public abstract void ScrollToItem(int id) { }

	protected abstract void set_firstVisibleIndex(int value) { }

	internal abstract void StartDragItem(ReusableCollectionItem item) { }

	public abstract void UpdateBackground() { }

}

