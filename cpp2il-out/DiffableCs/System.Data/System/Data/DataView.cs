namespace System.Data;

[DefaultEvent("PositionChanged")]
[DefaultMember("Item")]
[DefaultProperty("Table")]
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList
{
	private sealed class DataRowReferenceComparer : IEqualityComparer<DataRow>
	{
		internal static readonly DataRowReferenceComparer s_default; //Field offset: 0x0

		private static DataRowReferenceComparer() { }

		private DataRowReferenceComparer() { }

		public override bool Equals(DataRow x, DataRow y) { }

		public override int GetHashCode(DataRow obj) { }

	}

	internal static ListChangedEventArgs s_resetEventArgs; //Field offset: 0x0
	private static int s_objectTypeCount; //Field offset: 0x8
	private DataViewManager _dataViewManager; //Field offset: 0x20
	private DataTable _table; //Field offset: 0x28
	private bool _locked; //Field offset: 0x30
	private Index _index; //Field offset: 0x38
	private Dictionary<String, Index> _findIndexes; //Field offset: 0x40
	private string _sort; //Field offset: 0x48
	private Comparison<DataRow> _comparison; //Field offset: 0x50
	private IFilter _rowFilter; //Field offset: 0x58
	private DataViewRowState _recordStates; //Field offset: 0x60
	private bool _shouldOpen; //Field offset: 0x64
	private bool _open; //Field offset: 0x65
	private bool _allowNew; //Field offset: 0x66
	private bool _allowEdit; //Field offset: 0x67
	private bool _allowDelete; //Field offset: 0x68
	private bool _applyDefaultSort; //Field offset: 0x69
	internal DataRow _addNewRow; //Field offset: 0x70
	private ListChangedEventArgs _addNewMoved; //Field offset: 0x78
	private ListChangedEventHandler _onListChanged; //Field offset: 0x80
	private string _delayedSort; //Field offset: 0x88
	private DataViewRowState _delayedRecordStates; //Field offset: 0x90
	private bool _fInitInProgress; //Field offset: 0x94
	private bool _fEndInitInProgress; //Field offset: 0x95
	private Dictionary<DataRow, DataRowView> _rowViewCache; //Field offset: 0x98
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; //Field offset: 0xA0
	private DataViewListener _dvListener; //Field offset: 0xA8
	private readonly int _objectID; //Field offset: 0xB0

	[DefaultValue(True)]
	public bool AllowDelete
	{
		 get { } //Length: 5
	}

	[DefaultValue(True)]
	public bool AllowEdit
	{
		 get { } //Length: 5
	}

	[DefaultValue(True)]
	public bool AllowNew
	{
		 get { } //Length: 5
	}

	[Browsable(False)]
	public override int Count
	{
		 get { } //Length: 71
	}

	private int CountFromIndex
	{
		private get { } //Length: 43
	}

	[Browsable(False)]
	public DataViewManager DataViewManager
	{
		 get { } //Length: 5
	}

	[Browsable(False)]
	protected bool IsOpen
	{
		 get { } //Length: 5
	}

	public DataRowView Item
	{
		 get { } //Length: 94
	}

	internal int ObjectID
	{
		internal get { } //Length: 7
	}

	[DefaultValue(DataViewRowState::CurrentRows (22))]
	public DataViewRowState RowStateFilter
	{
		 get { } //Length: 4
	}

	[DefaultValue(null)]
	public string Sort
	{
		 get { } //Length: 84
		 set { } //Length: 474
	}

	internal Comparison<DataRow> SortComparison
	{
		internal get { } //Length: 5
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 4
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 94
		private set { } //Length: 39
	}

	private override bool System.ComponentModel.IBindingList.AllowEdit
	{
		private get { } //Length: 5
	}

	private override bool System.ComponentModel.IBindingList.AllowNew
	{
		private get { } //Length: 5
	}

	private override bool System.ComponentModel.IBindingList.AllowRemove
	{
		private get { } //Length: 5
	}

	private override bool System.ComponentModel.IBindingList.IsSorted
	{
		private get { } //Length: 94
	}

	private override ListSortDirection System.ComponentModel.IBindingList.SortDirection
	{
		private get { } //Length: 61
	}

	private override PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
	{
		private get { } //Length: 142
	}

	private override bool System.ComponentModel.IBindingList.SupportsChangeNotification
	{
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.SupportsSearching
	{
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.SupportsSorting
	{
		private get { } //Length: 3
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	[TypeConverter(typeof(DataTableTypeConverter))]
	public DataTable Table
	{
		 get { } //Length: 5
	}

	private static DataView() { }

	internal DataView(DataTable table, bool locked) { }

	public DataView(DataTable table) { }

	public override DataRowView AddNew() { }

	private void CheckOpen() { }

	private void CheckSort(string sort) { }

	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	protected void Close() { }

	protected override void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	private void CopyTo(DataRowView[] array, int index) { }

	public override void CopyTo(Array array, int index) { }

	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	public void Delete(int index) { }

	internal void Delete(DataRow row) { }

	protected virtual void Dispose(bool disposing) { }

	internal void FinishAddNew(bool success) { }

	public bool get_AllowDelete() { }

	public bool get_AllowEdit() { }

	public bool get_AllowNew() { }

	public override int get_Count() { }

	private int get_CountFromIndex() { }

	public DataViewManager get_DataViewManager() { }

	protected bool get_IsOpen() { }

	public DataRowView get_Item(int recordIndex) { }

	internal int get_ObjectID() { }

	public DataViewRowState get_RowStateFilter() { }

	public string get_Sort() { }

	internal Comparison<DataRow> get_SortComparison() { }

	public DataTable get_Table() { }

	public override IEnumerator GetEnumerator() { }

	internal override IFilter GetFilter() { }

	internal Index GetFindIndex(string column, bool keepIndex) { }

	private int GetRecord(int recordIndex) { }

	internal DataRow GetRow(int index) { }

	private DataRowView GetRowView(int record) { }

	private DataRowView GetRowView(DataRow dr) { }

	internal PropertyDescriptor GetSortProperty() { }

	protected override void IndexListChanged(object sender, ListChangedEventArgs e) { }

	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	internal int IndexOf(DataRowView rowview) { }

	private int IndexOfDataRowView(DataRowView rowview) { }

	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	protected override void OnListChanged(ListChangedEventArgs e) { }

	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	protected void Reset() { }

	internal void ResetRowViewCache() { }

	public void set_Sort(string value) { }

	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int recordIndex) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int recordIndex, object value) { }

	private override void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	private override object System.ComponentModel.IBindingList.AddNew() { }

	private override void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	private override int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	private override bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	private override bool System.ComponentModel.IBindingList.get_AllowNew() { }

	private override bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	private override bool System.ComponentModel.IBindingList.get_IsSorted() { }

	private override ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	private override PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	private override bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	private override bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	private override bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	private override void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	private override void System.ComponentModel.IBindingList.RemoveSort() { }

	private override PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	private override string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	internal void UpdateIndex(bool force, bool fireEvent) { }

	protected void UpdateIndex() { }

	protected override void UpdateIndex(bool force) { }

}

