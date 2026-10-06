namespace UnityEngine.UIElements;

[IsReadOnly]
internal struct TreeData
{
	private readonly IList<Int32> m_RootItemIds; //Field offset: 0x0
	private readonly Dictionary<Int32, TreeViewItemData`1<T>> m_Tree; //Field offset: 0x0
	private readonly Dictionary<Int32, Int32> m_ParentIds; //Field offset: 0x0
	private readonly Dictionary<Int32, List`1<Int32>> m_ChildrenIds; //Field offset: 0x0

	public IEnumerable<Int32> rootItemIds
	{
		 get { } //Length: 4
	}

	public TreeData`1(IList<TreeViewItemData`1<T>> rootItems) { }

	private void AddItemToParent(TreeViewItemData<T> item, int parentId, int childIndex) { }

	private void BuildTree(IEnumerable<TreeViewItemData`1<T>> items, bool isRoot) { }

	public IEnumerable<Int32> get_rootItemIds() { }

	public TreeViewItemData<T> GetDataForId(int id) { }

	public int GetParentId(int id) { }

	public bool HasAncestor(int childId, int ancestorId) { }

	public void Move(int id, int newParentId, int childIndex) { }

	private void RefreshTree(IList<TreeViewItemData`1<T>> rootItems) { }

	private void RemoveFromParent(int id, int parentId) { }

	private void UpdateParentTree(TreeViewItemData<T> current) { }

}

