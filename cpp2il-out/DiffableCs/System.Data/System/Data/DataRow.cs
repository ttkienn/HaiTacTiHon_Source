namespace System.Data;

[DefaultMember("Item")]
public class DataRow
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private readonly DataTable _table; //Field offset: 0x10
	private readonly DataColumnCollection _columns; //Field offset: 0x18
	internal int _oldRecord; //Field offset: 0x20
	internal int _newRecord; //Field offset: 0x24
	internal int _tempRecord; //Field offset: 0x28
	internal long _rowID; //Field offset: 0x30
	internal DataRowAction _action; //Field offset: 0x38
	internal bool _inChangingEvent; //Field offset: 0x3C
	internal bool _inDeletingEvent; //Field offset: 0x3D
	internal bool _inCascade; //Field offset: 0x3E
	private DataColumn _lastChangedColumn; //Field offset: 0x40
	private int _countColumnChange; //Field offset: 0x48
	private DataError _error; //Field offset: 0x50
	private int _rbTreeNodeId; //Field offset: 0x58
	internal readonly int _objectID; //Field offset: 0x5C

	public bool HasErrors
	{
		 get { } //Length: 61
	}

	internal bool HasPropertyChanged
	{
		internal get { } //Length: 8
	}

	public string Item
	{
		 set { } //Length: 146
	}

	public object Item
	{
		 get { } //Length: 257
		 set { } //Length: 1203
	}

	public object Item
	{
		 get { } //Length: 210
	}

	public Object[] ItemArray
	{
		 set { } //Length: 1247
	}

	internal DataColumn LastChangedColumn
	{
		internal get { } //Length: 14
		internal set { } //Length: 16
	}

	internal int RBTreeNodeId
	{
		internal get { } //Length: 4
		internal set { } //Length: 163
	}

	public string RowError
	{
		 get { } //Length: 81
		 set { } //Length: 543
	}

	internal long rowID
	{
		internal get { } //Length: 5
		internal set { } //Length: 57
	}

	public DataRowState RowState
	{
		 get { } //Length: 424
	}

	public DataTable Table
	{
		 get { } //Length: 5
	}

	protected private DataRow(DataRowBuilder builder) { }

	public void AcceptChanges() { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public void BeginEdit() { }

	private bool BeginEditInternal() { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public void CancelEdit() { }

	private void CheckColumn(DataColumn column) { }

	internal void CheckForLoops(DataRelation rel) { }

	internal void CheckInTable() { }

	internal void ClearError(DataColumn column) { }

	public void ClearErrors() { }

	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

	public void Delete() { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public void EndEdit() { }

	public bool get_HasErrors() { }

	internal bool get_HasPropertyChanged() { }

	public object get_Item(DataColumn column) { }

	public object get_Item(DataColumn column, DataRowVersion version) { }

	internal DataColumn get_LastChangedColumn() { }

	internal int get_RBTreeNodeId() { }

	public string get_RowError() { }

	internal long get_rowID() { }

	public DataRowState get_RowState() { }

	public DataTable get_Table() { }

	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	public DataRow[] GetChildRows(DataRelation relation) { }

	public string GetColumnError(DataColumn column) { }

	public DataColumn[] GetColumnsInError() { }

	internal Object[] GetColumnValues(DataColumn[] columns) { }

	internal Object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	internal int GetCurrentRecordNo() { }

	internal DataColumn GetDataColumn(string columnName) { }

	internal int GetDefaultRecord() { }

	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	internal Object[] GetKeyValues(DataKey key) { }

	internal Object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	internal int GetNestedParentCount() { }

	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	internal int GetOriginalRecordNo() { }

	public DataRow GetParentRow(DataRelation relation) { }

	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	public DataRow[] GetParentRows(DataRelation relation) { }

	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	private int GetProposedRecordNo() { }

	internal int GetRecordFromVersion(DataRowVersion version) { }

	internal DataViewRowState GetRecordState(int record) { }

	internal bool HasKeyChanged(DataKey key) { }

	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	public bool HasVersion(DataRowVersion version) { }

	internal bool HaveValuesChanged(DataColumn[] columns) { }

	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	public void RejectChanges() { }

	internal void ResetLastChangedColumn() { }

	private void RowErrorChanged() { }

	public void set_Item(string columnName, object value) { }

	public void set_Item(DataColumn column, object value) { }

	public void set_ItemArray(Object[] value) { }

	internal void set_LastChangedColumn(DataColumn value) { }

	internal void set_RBTreeNodeId(int value) { }

	public void set_RowError(string value) { }

	internal void set_rowID(long value) { }

	public void SetColumnError(DataColumn column, string error) { }

	public void SetColumnError(int columnIndex, string error) { }

	internal void SetKeyValues(DataKey key, Object[] keyValues) { }

	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	internal void SetParentRowToDBNull(DataRelation relation) { }

	internal void SetParentRowToDBNull() { }

}

