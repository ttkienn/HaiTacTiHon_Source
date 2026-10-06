namespace UnityEngine.UIElements;

public abstract class BaseTreeView : BaseVerticalCollectionView
{
	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlBoolAttributeDescription m_AutoExpand; //Field offset: 0xB0

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string itemUssClassName; //Field offset: 0x8
	public static readonly string itemToggleUssClassName; //Field offset: 0x10
	public static readonly string itemIndentsContainerUssClassName; //Field offset: 0x18
	public static readonly string itemIndentUssClassName; //Field offset: 0x20
	public static readonly string itemContentContainerUssClassName; //Field offset: 0x28
	private bool m_AutoExpand; //Field offset: 0x4C0
	[SerializeField]
	private List<Int32> m_ExpandedItemIds; //Field offset: 0x4C8

	public bool autoExpand
	{
		 get { } //Length: 8
		 set { } //Length: 52
	}

	internal List<Int32> expandedItemIds
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	public IList itemsSource
	{
		 get { } //Length: 48
	}

	public BaseTreeViewController viewController
	{
		 get { } //Length: 133
	}

	private static BaseTreeView() { }

	public BaseTreeView() { }

	public BaseTreeView(int itemHeight) { }

	[CompilerGenerated]
	private int <SetSelectionInternalById>b__47_0(int id) { }

	public void CollapseItem(int id, bool collapseAllChildren = false) { }

	private void CollapseItemByIndex(int index, bool collapseAll) { }

	internal virtual ICollectionDragAndDropController CreateDragAndDropController() { }

	virtual void CreateVirtualizationController() { }

	public void ExpandItem(int id, bool expandAllChildren = false) { }

	private void ExpandItemByIndex(int index, bool expandAll) { }

	public bool get_autoExpand() { }

	internal List<Int32> get_expandedItemIds() { }

	public IList get_itemsSource() { }

	public BaseTreeViewController get_viewController() { }

	private int GetItemIndex(int id, bool expand = false) { }

	virtual bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	public bool IsExpanded(int id) { }

	private bool IsExpandedByIndex(int index) { }

	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	private void OnTreeViewPointerUp(PointerUpEvent evt) { }

	internal virtual void OnViewDataReady() { }

	public void set_autoExpand(bool value) { }

	internal void set_expandedItemIds(List<Int32> value) { }

	public void SetSelectionById(int id) { }

	public void SetSelectionById(IEnumerable<Int32> ids) { }

	internal void SetSelectionInternalById(IEnumerable<Int32> ids, bool sendNotification) { }

	public virtual void SetViewController(CollectionViewController controller) { }

}

