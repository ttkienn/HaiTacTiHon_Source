namespace UnityEngine.UIElements;

internal abstract class VerticalVirtualizationController : CollectionVirtualizationController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Func<T> <>9__30_0; //Field offset: 0x0
		public static Action<T> <>9__30_1; //Field offset: 0x0
		public static Action<T> <>9__30_2; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal T <.ctor>b__30_0() { }

		internal void <.ctor>b__30_1(T i) { }

		internal void <.ctor>b__30_2(T i) { }

	}

	private readonly ObjectPool<T> m_Pool; //Field offset: 0x0
	protected BaseVerticalCollectionView m_CollectionView; //Field offset: 0x0
	protected List<T> m_ActiveItems; //Field offset: 0x0
	protected T m_DraggedItem; //Field offset: 0x0
	private int m_LastFocusedElementIndex; //Field offset: 0x0
	private List<Int32> m_LastFocusedElementTreeChildIndexes; //Field offset: 0x0
	protected readonly Func<T, Boolean> m_VisibleItemPredicateDelegate; //Field offset: 0x0
	protected List<T> m_ScrollInsertionList; //Field offset: 0x0
	private VisualElement m_EmptyRows; //Field offset: 0x0

	public virtual IEnumerable<ReusableCollectionItem> activeItems
	{
		 get { } //Length: 5
	}

	protected override bool alwaysRebindOnRefresh
	{
		 get { } //Length: 3
	}

	public virtual int firstVisibleIndex
	{
		 get { } //Length: 114
		 set { } //Length: 38
	}

	internal T firstVisibleItem
	{
		internal get { } //Length: 28
	}

	internal int itemsCount
	{
		internal get { } //Length: 88
	}

	protected float lastHeight
	{
		 get { } //Length: 31
	}

	internal T lastVisibleItem
	{
		internal get { } //Length: 28
	}

	protected SerializedVirtualizationData serializedData
	{
		 get { } //Length: 30
	}

	public virtual int visibleItemCount
	{
		 get { } //Length: 28
	}

	protected VerticalVirtualizationController`1(BaseVerticalCollectionView collectionView) { }

	internal virtual void EndDrag(int dropIndex) { }

	public virtual IEnumerable<ReusableCollectionItem> get_activeItems() { }

	protected override bool get_alwaysRebindOnRefresh() { }

	public virtual int get_firstVisibleIndex() { }

	internal T get_firstVisibleItem() { }

	internal int get_itemsCount() { }

	protected float get_lastHeight() { }

	internal T get_lastVisibleItem() { }

	protected SerializedVirtualizationData get_serializedData() { }

	public virtual int get_visibleItemCount() { }

	protected int GetDraggedIndex() { }

	internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }

	private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex) { }

	public virtual void OnBlur(VisualElement willFocus) { }

	private void OnDestroyItem(ReusableCollectionItem item) { }

	public virtual void OnFocus(VisualElement leafTarget) { }

	public virtual void Refresh(bool rebuild) { }

	internal override void ReleaseItem(int activeItemsIndex) { }

	protected virtual void set_firstVisibleIndex(int value) { }

	protected void Setup(T recycledItem, int newIndex) { }

	internal virtual void StartDragItem(ReusableCollectionItem item) { }

	public virtual void UpdateBackground() { }

	protected override bool VisibleItemPredicate(T i) { }

}

