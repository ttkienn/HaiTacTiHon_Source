namespace System.Data;

[DefaultMember("Item")]
internal abstract class RBTree : IEnumerable
{
	private struct Node
	{
		internal int _selfId; //Field offset: 0x0
		internal int _leftId; //Field offset: 0x0
		internal int _rightId; //Field offset: 0x0
		internal int _parentId; //Field offset: 0x0
		internal int _nextId; //Field offset: 0x0
		internal int _subTreeSize; //Field offset: 0x0
		internal K _keyOfNode; //Field offset: 0x0
		internal NodeColor<K> _nodeColor; //Field offset: 0x0

	}

	private enum NodeColor
	{
		red = 0,
		black = 1,
	}

	[IsReadOnly]
	private struct NodePath
	{
		internal readonly int _nodeID; //Field offset: 0x0
		internal readonly int _mainTreeNodeID; //Field offset: 0x0

		internal NodePath(int nodeID, int mainTreeNodeID) { }

	}

	public struct RBTreeEnumerator : IEnumerator<K>, IDisposable, IEnumerator
	{
		private readonly RBTree<K> _tree; //Field offset: 0x0
		private readonly int _version; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private int _mainTreeNodeId; //Field offset: 0x0
		private K _current; //Field offset: 0x0

		public override K Current
		{
			 get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 94
		}

		internal RBTreeEnumerator(RBTree<K> tree) { }

		internal RBTreeEnumerator(RBTree<K> tree, int position) { }

		public override void Dispose() { }

		public override K get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	private sealed class TreePage
	{
		internal readonly Node<K>[] _slots; //Field offset: 0x0
		internal readonly Int32[] _slotMap; //Field offset: 0x0
		private int _inUseCount; //Field offset: 0x0
		private int _pageId; //Field offset: 0x0
		private int _nextFreeSlotLine; //Field offset: 0x0

		internal int InUseCount
		{
			internal get { } //Length: 4
			internal set { } //Length: 4
		}

		internal int PageId
		{
			internal get { } //Length: 4
			internal set { } //Length: 4
		}

		internal TreePage(int size) { }

		internal int AllocSlot(RBTree<K> tree) { }

		internal int get_InUseCount() { }

		internal int get_PageId() { }

		internal void set_InUseCount(int value) { }

		internal void set_PageId(int value) { }

	}

	private TreePage<K>[] _pageTable; //Field offset: 0x0
	private Int32[] _pageTableMap; //Field offset: 0x0
	private int _inUsePageCount; //Field offset: 0x0
	private int _nextFreePageLine; //Field offset: 0x0
	public int root; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private int _inUseNodeCount; //Field offset: 0x0
	private int _inUseSatelliteTreeCount; //Field offset: 0x0
	private readonly TreeAccessMethod _accessMethod; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 6
	}

	public bool HasDuplicates
	{
		 get { } //Length: 8
	}

	public K Item
	{
		 get { } //Length: 106
	}

	protected RBTree`1(TreeAccessMethod accessMethod) { }

	public int Add(K item) { }

	private TreePage<K> AllocPage(int size) { }

	public void Clear() { }

	private NodeColor<K> color(int nodeId) { }

	protected abstract int CompareNode(K record1, K record2) { }

	protected abstract int CompareSateliteTreeNode(K record1, K record2) { }

	private int ComputeIndexByNode(int nodeId) { }

	private int ComputeIndexWithSatelliteByNode(int nodeId) { }

	private int ComputeNodeByIndex(int x_id, int index) { }

	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }

	public void CopyTo(K[] array, int index) { }

	public void CopyTo(Array array, int index) { }

	private void DecreaseSize(int nodeId) { }

	public K DeleteByIndex(int i) { }

	private void FreeNode(int nodeId) { }

	private void FreePage(TreePage<K> page) { }

	public int get_Count() { }

	public bool get_HasDuplicates() { }

	public K get_Item(int index) { }

	public override IEnumerator GetEnumerator() { }

	public int GetIndexByKey(K key) { }

	public int GetIndexByNode(int node) { }

	private int GetIndexByNodePath(NodePath<K> path) { }

	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }

	private static int GetIntValueFromBitMap(uint bitMap) { }

	private int GetNewNode(K key) { }

	private NodePath<K> GetNodeByIndex(int userIndex) { }

	private NodePath<K> GetNodeByKey(K key) { }

	private void IncreaseSize(int nodeId) { }

	public int IndexOf(int nodeId, K item) { }

	private void InitTree() { }

	public int Insert(int position, K item) { }

	public int Insert(K item) { }

	public int InsertAt(int position, K item, bool append) { }

	public K Key(int nodeId) { }

	public int Left(int nodeId) { }

	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }

	private void MarkPageFree(TreePage<K> page) { }

	private void MarkPageFull(TreePage<K> page) { }

	private int Minimum(int x_id) { }

	public int Next(int nodeId) { }

	public int Parent(int nodeId) { }

	public int RBDelete(int z_id) { }

	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }

	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }

	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }

	private void RecomputeSize(int nodeId) { }

	public void RemoveAt(int position) { }

	public int Right(int nodeId) { }

	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }

	private int SearchSubTree(int root_id, K key) { }

	private void SetColor(int nodeId, NodeColor<K> color) { }

	private void SetKey(int nodeId, K key) { }

	private void SetLeft(int nodeId, int leftNodeId) { }

	private void SetNext(int nodeId, int nextNodeId) { }

	private void SetParent(int nodeId, int parentNodeId) { }

	private void SetRight(int nodeId, int rightNodeId) { }

	private void SetSubTreeSize(int nodeId, int size) { }

	public int SubTreeSize(int nodeId) { }

	private int Successor(int x_id) { }

	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }

	public void UpdateNodeKey(K currentKey, K newKey) { }

}

