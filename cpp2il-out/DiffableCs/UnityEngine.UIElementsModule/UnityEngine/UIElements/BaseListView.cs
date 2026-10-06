namespace UnityEngine.UIElements;

public abstract class BaseListView : BaseVerticalCollectionView
{
	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader; //Field offset: 0xB0
		private readonly UxmlStringAttributeDescription m_HeaderTitle; //Field offset: 0xB8
		private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter; //Field offset: 0xC0
		private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode; //Field offset: 0xC8
		private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize; //Field offset: 0xD0

		protected UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private static readonly string k_SizeFieldLabel; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x8
	public static readonly string itemUssClassName; //Field offset: 0x10
	public static readonly string emptyLabelUssClassName; //Field offset: 0x18
	public static readonly string overMaxMultiEditLimitClassName; //Field offset: 0x20
	public static readonly string reorderableUssClassName; //Field offset: 0x28
	public static readonly string reorderableItemUssClassName; //Field offset: 0x30
	public static readonly string reorderableItemContainerUssClassName; //Field offset: 0x38
	public static readonly string reorderableItemHandleUssClassName; //Field offset: 0x40
	public static readonly string reorderableItemHandleBarUssClassName; //Field offset: 0x48
	public static readonly string footerUssClassName; //Field offset: 0x50
	public static readonly string foldoutHeaderUssClassName; //Field offset: 0x58
	public static readonly string arraySizeFieldUssClassName; //Field offset: 0x60
	public static readonly string arraySizeFieldWithHeaderUssClassName; //Field offset: 0x68
	public static readonly string arraySizeFieldWithFooterUssClassName; //Field offset: 0x70
	public static readonly string listViewWithHeaderUssClassName; //Field offset: 0x78
	public static readonly string listViewWithFooterUssClassName; //Field offset: 0x80
	public static readonly string scrollViewWithFooterUssClassName; //Field offset: 0x88
	public static readonly string footerAddButtonName; //Field offset: 0x90
	public static readonly string footerRemoveButtonName; //Field offset: 0x98
	private static readonly string k_EmptyListStr; //Field offset: 0xA0
	private bool m_ShowBoundCollectionSize; //Field offset: 0x4C0
	private bool m_ShowFoldoutHeader; //Field offset: 0x4C1
	private string m_HeaderTitle; //Field offset: 0x4C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Int32>> itemsAdded; //Field offset: 0x4D0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Int32>> itemsRemoved; //Field offset: 0x4D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action itemsSourceSizeChanged; //Field offset: 0x4E0
	private Label m_ListViewLabel; //Field offset: 0x4E8
	private Foldout m_Foldout; //Field offset: 0x4F0
	private TextField m_ArraySizeField; //Field offset: 0x4F8
	private bool m_IsOverMultiEditLimit; //Field offset: 0x500
	private VisualElement m_Footer; //Field offset: 0x508
	private Button m_AddButton; //Field offset: 0x510
	private Button m_RemoveButton; //Field offset: 0x518
	private Action<IEnumerable`1<Int32>> m_ItemAddedCallback; //Field offset: 0x520
	private Action<IEnumerable`1<Int32>> m_ItemRemovedCallback; //Field offset: 0x528
	private Action m_ItemsSourceSizeChangedCallback; //Field offset: 0x530
	private ListViewReorderMode m_ReorderMode; //Field offset: 0x538
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action reorderModeChanged; //Field offset: 0x540
	private string m_MaxMultiEditStr; //Field offset: 0x548

	internal event Action reorderModeChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 162
		[CompilerGenerated]
		internal remove { } //Length: 162
	}

	internal VisualElement footer
	{
		internal get { } //Length: 8
	}

	public string headerTitle
	{
		 set { } //Length: 71
	}

	public ListViewReorderMode reorderMode
	{
		 get { } //Length: 7
		 set { } //Length: 91
	}

	public bool showAddRemoveFooter
	{
		 get { } //Length: 12
		 set { } //Length: 8
	}

	public bool showBoundCollectionSize
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public bool showFoldoutHeader
	{
		 get { } //Length: 8
		 set { } //Length: 695
	}

	public BaseListViewController viewController
	{
		 get { } //Length: 133
	}

	private static BaseListView() { }

	public BaseListView() { }

	[CompilerGenerated]
	private void <OnAddClicked>b__38_0() { }

	[CompilerGenerated]
	internal void add_reorderModeChanged(Action value) { }

	private void AddItems(int itemCount) { }

	internal virtual ICollectionDragAndDropController CreateDragAndDropController() { }

	internal virtual ListViewDragger CreateDragger() { }

	virtual void CreateVirtualizationController() { }

	private void EnableFooter(bool enabled) { }

	internal VisualElement get_footer() { }

	public ListViewReorderMode get_reorderMode() { }

	public bool get_showAddRemoveFooter() { }

	public bool get_showBoundCollectionSize() { }

	public bool get_showFoldoutHeader() { }

	public BaseListViewController get_viewController() { }

	virtual bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	private void OnAddClicked() { }

	private void OnArraySizeFieldChanged(ChangeEvent<String> evt) { }

	private void OnItemAdded(IEnumerable<Int32> indices) { }

	private void OnItemsRemoved(IEnumerable<Int32> indices) { }

	private void OnItemsSourceSizeChanged() { }

	private void OnRemoveClicked() { }

	virtual void PostRefresh() { }

	[CompilerGenerated]
	internal void remove_reorderModeChanged(Action value) { }

	public void set_headerTitle(string value) { }

	public void set_reorderMode(ListViewReorderMode value) { }

	public void set_showAddRemoveFooter(bool value) { }

	public void set_showBoundCollectionSize(bool value) { }

	public void set_showFoldoutHeader(bool value) { }

	internal void SetupArraySizeField() { }

	public virtual void SetViewController(CollectionViewController controller) { }

	internal void UpdateArraySizeField() { }

	internal void UpdateListViewLabel() { }

}

