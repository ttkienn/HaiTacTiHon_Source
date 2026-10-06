namespace UnityEngine.UIElements;

public class MultiColumnListView : BaseListView
{
	internal class UxmlFactory : UxmlFactory<MultiColumnListView, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlBoolAttributeDescription m_SortingEnabled; //Field offset: 0xD8
		private readonly UxmlObjectAttributeDescription<Columns> m_Columns; //Field offset: 0xE0
		private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; //Field offset: 0xE8

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private Columns m_Columns; //Field offset: 0x550
	private bool m_SortingEnabled; //Field offset: 0x558
	private SortColumnDescriptions m_SortColumnDescriptions; //Field offset: 0x560
	private List<SortColumnDescription> m_SortedColumns; //Field offset: 0x568
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action columnSortingChanged; //Field offset: 0x570
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; //Field offset: 0x578

	public private Columns columns
	{
		 get { } //Length: 8
		private set { } //Length: 159
	}

	public private SortColumnDescriptions sortColumnDescriptions
	{
		 get { } //Length: 8
		private set { } //Length: 170
	}

	public bool sortingEnabled
	{
		 set { } //Length: 95
	}

	public MultiColumnListViewController viewController
	{
		 get { } //Length: 136
	}

	public MultiColumnListView() { }

	public MultiColumnListView(Columns columns) { }

	protected virtual CollectionViewController CreateViewController() { }

	virtual void CreateVirtualizationController() { }

	public Columns get_columns() { }

	public SortColumnDescriptions get_sortColumnDescriptions() { }

	public MultiColumnListViewController get_viewController() { }

	private void RaiseColumnSortingChanged() { }

	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

	private void set_columns(Columns value) { }

	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	public void set_sortingEnabled(bool value) { }

	public virtual void SetViewController(CollectionViewController controller) { }

}

