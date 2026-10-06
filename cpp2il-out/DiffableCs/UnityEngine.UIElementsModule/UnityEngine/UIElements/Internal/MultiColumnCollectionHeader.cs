namespace UnityEngine.UIElements.Internal;

internal class MultiColumnCollectionHeader : VisualElement, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public Column column; //Field offset: 0x10
		public MultiColumnCollectionHeader <>4__this; //Field offset: 0x18

		public <>c__DisplayClass65_0() { }

		internal void <OnContextualMenuManipulator>b__1(DropdownMenuAction a) { }

		internal Status <OnContextualMenuManipulator>b__2(DropdownMenuAction a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public Column column; //Field offset: 0x10

		public <>c__DisplayClass71_0() { }

		internal bool <UpdateSortColumnDescriptionsOnClick>b__0(SortColumnDescription d) { }

	}

	public class ColumnData
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private MultiColumnHeaderColumn <control>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private MultiColumnHeaderColumnResizeHandle <resizeHandle>k__BackingField; //Field offset: 0x18

		public MultiColumnHeaderColumn control
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 13
		}

		public MultiColumnHeaderColumnResizeHandle resizeHandle
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 13
		}

		public ColumnData() { }

		[CompilerGenerated]
		public MultiColumnHeaderColumn get_control() { }

		[CompilerGenerated]
		public MultiColumnHeaderColumnResizeHandle get_resizeHandle() { }

		[CompilerGenerated]
		public void set_control(MultiColumnHeaderColumn value) { }

		[CompilerGenerated]
		public void set_resizeHandle(MultiColumnHeaderColumnResizeHandle value) { }

	}

	private struct SortedColumnState
	{
		public SortColumnDescription columnDesc; //Field offset: 0x0
		public SortDirection direction; //Field offset: 0x8

		public SortedColumnState(SortColumnDescription desc, SortDirection dir) { }

	}

	private class ViewState
	{
		private struct ColumnState
		{
			public int index; //Field offset: 0x0
			public string name; //Field offset: 0x8
			public float actualWidth; //Field offset: 0x10
			public Length width; //Field offset: 0x14
			public bool visible; //Field offset: 0x1C

		}

		[SerializeField]
		private bool m_HasPersistedData; //Field offset: 0x10
		[SerializeField]
		private List<SortColumnDescription> m_SortDescriptions; //Field offset: 0x18
		[SerializeField]
		private List<ColumnState> m_OrderedColumnStates; //Field offset: 0x20

		public ViewState() { }

		internal void Apply(MultiColumnCollectionHeader header) { }

		internal void Save(MultiColumnCollectionHeader header) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string columnContainerUssClassName; //Field offset: 0x8
	public static readonly string handleContainerUssClassName; //Field offset: 0x10
	public static readonly string reorderableUssClassName; //Field offset: 0x18
	private bool m_SortingEnabled; //Field offset: 0x3C8
	private List<SortColumnDescription> m_SortedColumns; //Field offset: 0x3D0
	private SortColumnDescriptions m_SortDescriptions; //Field offset: 0x3D8
	private List<SortedColumnState> m_OldSortedColumnStates; //Field offset: 0x3E0
	private bool m_SortingUpdatesTemporarilyDisabled; //Field offset: 0x3E8
	private ViewState m_ViewState; //Field offset: 0x3F0
	private bool m_ApplyingViewState; //Field offset: 0x3F8
	private bool m_DoLayoutScheduled; //Field offset: 0x3F9
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Dictionary<Column, ColumnData> <columnDataMap>k__BackingField; //Field offset: 0x400
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly ColumnLayout <columnLayout>k__BackingField; //Field offset: 0x408
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly VisualElement <columnContainer>k__BackingField; //Field offset: 0x410
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly VisualElement <resizeHandleContainer>k__BackingField; //Field offset: 0x418
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Columns <columns>k__BackingField; //Field offset: 0x420
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Int32, Single> columnResized; //Field offset: 0x428
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action columnSortingChanged; //Field offset: 0x430
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent; //Field offset: 0x438
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action viewDataRestored; //Field offset: 0x440

	public event Action<Int32, Single> columnResized
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public event Action columnSortingChanged
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	internal event Action viewDataRestored
	{
		[CompilerGenerated]
		internal add { } //Length: 162
		[CompilerGenerated]
		internal remove { } //Length: 162
	}

	public VisualElement columnContainer
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Dictionary<Column, ColumnData> columnDataMap
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ColumnLayout columnLayout
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Columns columns
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	internal bool isApplyingViewState
	{
		internal get { } //Length: 8
	}

	public VisualElement resizeHandleContainer
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private SortColumnDescriptions sortDescriptions
	{
		 get { } //Length: 8
		private set { } //Length: 175
	}

	public IEnumerable<SortColumnDescription> sortedColumns
	{
		 get { } //Length: 8
	}

	public bool sortingEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 51
	}

	private static MultiColumnCollectionHeader() { }

	public MultiColumnCollectionHeader(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[CompilerGenerated]
	private void <OnContextualMenuManipulator>b__65_0(DropdownMenuAction a) { }

	[CompilerGenerated]
	public void add_columnResized(Action<Int32, Single> value) { }

	[CompilerGenerated]
	public void add_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	public void add_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[CompilerGenerated]
	internal void add_viewDataRestored(Action value) { }

	private void ApplyColumnSorting() { }

	private void CleanupColumnData(ColumnData data) { }

	public override void Dispose() { }

	private void DoLayout() { }

	[CompilerGenerated]
	public VisualElement get_columnContainer() { }

	[CompilerGenerated]
	public Dictionary<Column, ColumnData> get_columnDataMap() { }

	[CompilerGenerated]
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	public Columns get_columns() { }

	internal bool get_isApplyingViewState() { }

	[CompilerGenerated]
	public VisualElement get_resizeHandleContainer() { }

	public SortColumnDescriptions get_sortDescriptions() { }

	public IEnumerable<SortColumnDescription> get_sortedColumns() { }

	public bool get_sortingEnabled() { }

	private void OnColumnAdded(Column column) { }

	private void OnColumnAdded(Column column, int index) { }

	private void OnColumnChanged(Column column, ColumnDataType type) { }

	private void OnColumnClicked(EventBase evt) { }

	private void OnColumnControlGeometryChanged(GeometryChangedEvent evt) { }

	private void OnColumnRemoved(Column column) { }

	private void OnColumnReordered(Column column, int from, int to) { }

	private void OnColumnResized(Column column) { }

	private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt) { }

	private void OnGeometryChanged(GeometryChangedEvent e) { }

	private void OnMoveManipulatorActivated(ColumnMover mover) { }

	internal virtual void OnViewDataReady() { }

	private void RaiseColumnResized(int columnIndex) { }

	private void RaiseColumnSortingChanged() { }

	[CompilerGenerated]
	public void remove_columnResized(Action<Int32, Single> value) { }

	[CompilerGenerated]
	public void remove_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	public void remove_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[CompilerGenerated]
	internal void remove_viewDataRestored(Action value) { }

	private void ResizeToFit() { }

	private void SaveViewState() { }

	private void ScheduleDoLayout() { }

	public void ScrollHorizontally(float horizontalOffset) { }

	protected private void set_sortDescriptions(SortColumnDescriptions value) { }

	public void set_sortingEnabled(bool value) { }

	private void UpdateColumnControls() { }

	private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers) { }

	private void UpdateSortedColumns() { }

	private void UpdateSortingStatus() { }

}

