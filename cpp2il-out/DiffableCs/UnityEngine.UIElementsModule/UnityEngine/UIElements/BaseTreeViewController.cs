namespace UnityEngine.UIElements;

public abstract class BaseTreeViewController : CollectionViewController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public BaseTreeViewController <>4__this; //Field offset: 0x10
		public ReusableTreeViewItem treeItem; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal void <PostInitRegistration>b__0() { }

	}

	private static readonly ProfilerMarker K_ExpandItemByIndex; //Field offset: 0x0
	private static readonly ProfilerMarker k_CreateWrappers; //Field offset: 0x8
	private Dictionary<Int32, TreeItem> m_TreeItems; //Field offset: 0x30
	private List<Int32> m_RootIndices; //Field offset: 0x38
	private List<TreeViewItemWrapper> m_ItemWrappers; //Field offset: 0x40
	private HashSet<Int32> m_TreeItemIdsWithItemWrappers; //Field offset: 0x48
	private List<TreeViewItemWrapper> m_WrapperInsertionList; //Field offset: 0x50

	protected BaseTreeView baseTreeView
	{
		 get { } //Length: 130
	}

	public virtual IList itemsSource
	{
		 get { } //Length: 5
		 set { } //Length: 78
	}

	private static BaseTreeViewController() { }

	protected BaseTreeViewController() { }

	internal override bool CanChangeExpandedState(int id) { }

	public void CollapseItem(int id, bool collapseAllChildren) { }

	public void CollapseItemByIndex(int index, bool collapseAllChildren) { }

	private void CreateWrappers(IEnumerable<Int32> treeViewItemIds, int depth, ref List<TreeViewItemWrapper>& wrappers) { }

	internal bool Exists(int id) { }

	public void ExpandItem(int id, bool expandAllChildren, bool refresh = true) { }

	public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true) { }

	protected BaseTreeView get_baseTreeView() { }

	public virtual IList get_itemsSource() { }

	public abstract IEnumerable<Int32> GetAllItemIds(IEnumerable<Int32> rootIds = null) { }

	public int GetChildIndexForId(int id) { }

	public abstract IEnumerable<Int32> GetChildrenIds(int id) { }

	public IEnumerable<Int32> GetChildrenIdsByIndex(int index) { }

	public virtual int GetIdForIndex(int index) { }

	internal int GetIndentationDepth(int id) { }

	internal int GetIndentationDepthByIndex(int index) { }

	public virtual int GetIndexForId(int id) { }

	public abstract int GetParentId(int id) { }

	public IEnumerable<Int32> GetRootItemIds() { }

	public override bool HasChildren(int id) { }

	public bool HasChildrenByIndex(int index) { }

	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	public bool IsExpanded(int id) { }

	public bool IsExpandedByIndex(int index) { }

	private bool IsIndexValid(int index) { }

	public abstract void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true) { }

	private void OnItemPointerUp(PointerUpEvent evt) { }

	private void OnToggleValueChanged(ChangeEvent<Boolean> evt) { }

	internal void PostInitRegistration(ReusableTreeViewItem treeItem) { }

	internal void RaiseItemParentChanged(int id, int newParentId) { }

	public void RebuildTree() { }

	internal void RegenerateWrappers() { }

	public virtual void set_itemsSource(IList value) { }

}

