namespace UnityEngine.UIElements;

internal class DynamicHeightVirtualizationController : VerticalVirtualizationController<T>
{
	[IsReadOnly]
	private struct ContentHeightCacheInfo
	{
		public readonly float sum; //Field offset: 0x0
		public readonly int count; //Field offset: 0x0

		public ContentHeightCacheInfo(float sum, int count) { }

	}

	private enum ScrollDirection
	{
		Idle = 0,
		Up = 1,
		Down = 2,
	}

	private enum VirtualizationChange
	{
		None = 0,
		Resize = 1,
		Scroll = 2,
		ForcedScroll = 3,
	}

	private int m_HighestCachedIndex; //Field offset: 0x0
	private IVisualElementScheduledItem m_ScrollScheduledItem; //Field offset: 0x0
	private IVisualElementScheduledItem m_ScheduledItem; //Field offset: 0x0
	private Action<ReusableCollectionItem> m_GeometryChangedCallback; //Field offset: 0x0
	private Action m_ScrollResetCallback; //Field offset: 0x0
	private Action m_ScrollCallback; //Field offset: 0x0
	private Action m_FillCallback; //Field offset: 0x0
	private float m_MinimumItemHeight; //Field offset: 0x0
	private float m_AccumulatedHeight; //Field offset: 0x0
	private Vector2 m_DelayedScrollOffset; //Field offset: 0x0
	private ScrollDirection<T> m_ScrollDirection; //Field offset: 0x0
	private VirtualizationChange<T> m_LastChange; //Field offset: 0x0
	private bool m_StickToBottom; //Field offset: 0x0
	private int m_ForcedLastVisibleItem; //Field offset: 0x0
	private int m_ForcedFirstVisibleItem; //Field offset: 0x0
	private readonly HashSet<Int32> m_WaitingCache; //Field offset: 0x0
	private readonly Dictionary<Int32, ContentHeightCacheInfo<T>> m_ContentHeightCache; //Field offset: 0x0
	private readonly Dictionary<Int32, Single> m_ItemHeightCache; //Field offset: 0x0
	private IVisualElementScheduledItem m_ScrollResetScheduledItem; //Field offset: 0x0
	private Predicate<Int32> m_IndexOutOfBoundsPredicate; //Field offset: 0x0

	protected virtual bool alwaysRebindOnRefresh
	{
		 get { } //Length: 3
	}

	private int anchoredIndex
	{
		private get { } //Length: 47
		private set { } //Length: 79
	}

	private float anchorOffset
	{
		private get { } //Length: 49
		private set { } //Length: 83
	}

	private float contentHeight
	{
		private get { } //Length: 49
		private set { } //Length: 393
	}

	private float contentPadding
	{
		private get { } //Length: 49
		private set { } //Length: 393
	}

	private float defaultExpectedHeight
	{
		private get { } //Length: 159
	}

	private float viewportMaxOffset
	{
		private get { } //Length: 108
	}

	public DynamicHeightVirtualizationController`1(BaseVerticalCollectionView collectionView) { }

	private void ApplyScrollViewUpdate(bool dimensionsOnly = false) { }

	private void CleanItemHeightCache() { }

	private void CycleItems(int firstIndex) { }

	internal virtual void EndDrag(int dropIndex) { }

	private void Fill() { }

	protected virtual bool get_alwaysRebindOnRefresh() { }

	private int get_anchoredIndex() { }

	private float get_anchorOffset() { }

	private float get_contentHeight() { }

	private float get_contentPadding() { }

	private float get_defaultExpectedHeight() { }

	private float get_viewportMaxOffset() { }

	private ContentHeightCacheInfo<T> GetCachedContentHeight(int index) { }

	private float GetContentHeightForIndex(int lastIndex) { }

	public virtual float GetExpectedContentHeight() { }

	public virtual float GetExpectedItemHeight(int index) { }

	private int GetFirstVisibleItem(float offset) { }

	public virtual int GetIndexFromPosition(Vector2 position) { }

	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }

	private void HideItem(int activeItemsIndex) { }

	private bool IsIndexOutOfBounds(int i) { }

	private void MarkWaitingForLayout(T item) { }

	private bool NeedsFill() { }

	private void OnRecycledItemGeometryChanged(ReusableCollectionItem item) { }

	public virtual void OnScroll(Vector2 scrollOffset) { }

	private void OnScrollUpdate() { }

	public virtual void Refresh(bool rebuild) { }

	private void RegisterItemHeight(int index, float height) { }

	internal virtual void ReleaseItem(int activeItemsIndex) { }

	private void ResetScroll() { }

	public virtual void Resize(Vector2 size) { }

	private void ScheduleFill() { }

	private void ScheduleScroll() { }

	private void ScheduleScrollDirectionReset() { }

	public virtual void ScrollToItem(int index) { }

	private void set_anchoredIndex(int value) { }

	private void set_anchorOffset(float value) { }

	private void set_contentHeight(float value) { }

	private void set_contentPadding(float value) { }

	internal virtual void StartDragItem(ReusableCollectionItem item) { }

	private void UnregisterItemHeight(int index) { }

	private void UpdateAnchor() { }

	private bool UpdateRegisteredHeight(ReusableCollectionItem item) { }

	private void UpdateScrollViewContainer(float previousHeight, float newHeight) { }

}

