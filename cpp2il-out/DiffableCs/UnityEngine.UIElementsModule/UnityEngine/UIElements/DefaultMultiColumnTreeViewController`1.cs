namespace UnityEngine.UIElements;

internal class DefaultMultiColumnTreeViewController : MultiColumnTreeViewController
{
	private TreeDataController<T> m_TreeDataController; //Field offset: 0x0

	public virtual IList itemsSource
	{
		 get { } //Length: 25
		 set { } //Length: 400
	}

	private TreeDataController<T> treeDataController
	{
		private get { } //Length: 131
	}

	public DefaultMultiColumnTreeViewController`1(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	public virtual IList get_itemsSource() { }

	private TreeDataController<T> get_treeDataController() { }

	public virtual IEnumerable<Int32> GetAllItemIds(IEnumerable<Int32> rootIds = null) { }

	public virtual IEnumerable<Int32> GetChildrenIds(int id) { }

	public virtual object GetItemForIndex(int index) { }

	public virtual int GetParentId(int id) { }

	public virtual bool HasChildren(int id) { }

	private bool IsChildOf(int childId, int id) { }

	public virtual void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true) { }

	public virtual void set_itemsSource(IList value) { }

	public override void SetRootItems(IList<TreeViewItemData`1<T>> items) { }

}

