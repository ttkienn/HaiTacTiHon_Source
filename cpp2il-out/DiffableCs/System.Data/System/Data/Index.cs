namespace System.Data;

internal sealed class Index
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DataViewListener, DataViewListener, Boolean> <>9__22_0; //Field offset: 0x8
		public static Action<DataViewListener, DataViewListener, ListChangedEventArgs, Boolean, Boolean> <>9__85_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__22_0(DataViewListener listener) { }

		internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_0
	{
		public ListChangedType changedType; //Field offset: 0x10

		public <>c__DisplayClass86_0() { }

		internal void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }

	}

	private sealed class IndexTree : RBTree<Int32>
	{
		private readonly Index _index; //Field offset: 0x40

		internal IndexTree(Index index) { }

		protected virtual int CompareNode(int record1, int record2) { }

		protected virtual int CompareSateliteTreeNode(int record1, int record2) { }

	}

	private static int s_objectTypeCount; //Field offset: 0x0
	private readonly DataTable _table; //Field offset: 0x10
	internal readonly IndexField[] _indexFields; //Field offset: 0x18
	private readonly Comparison<DataRow> _comparison; //Field offset: 0x20
	private readonly DataViewRowState _recordStates; //Field offset: 0x28
	private WeakReference _rowFilter; //Field offset: 0x30
	private IndexTree _records; //Field offset: 0x38
	private int _recordCount; //Field offset: 0x40
	private int _refCount; //Field offset: 0x44
	private Listeners<DataViewListener> _listeners; //Field offset: 0x48
	private bool _suspendEvents; //Field offset: 0x50
	private readonly bool _isSharable; //Field offset: 0x51
	private readonly bool _hasRemoteAggregate; //Field offset: 0x52
	private readonly int _objectID; //Field offset: 0x54

	private bool DoListChanged
	{
		private get { } //Length: 105
	}

	public bool HasDuplicates
	{
		 get { } //Length: 68
	}

	internal bool HasRemoteAggregate
	{
		internal get { } //Length: 5
	}

	internal int ObjectID
	{
		internal get { } //Length: 4
	}

	public int RecordCount
	{
		 get { } //Length: 4
	}

	public DataViewRowState RecordStates
	{
		 get { } //Length: 4
	}

	public int RefCount
	{
		 get { } //Length: 4
	}

	public IFilter RowFilter
	{
		 get { } //Length: 129
	}

	internal DataTable Table
	{
		internal get { } //Length: 5
	}

	public Index(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	public Index(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	private Index(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	private bool AcceptRecord(int record, IFilter filter) { }

	private bool AcceptRecord(int record) { }

	public void AddRef() { }

	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	public bool CheckUnique() { }

	private int CompareDataRows(int record1, int record2) { }

	private int CompareDuplicateRecords(int record1, int record2) { }

	private int CompareRecords(int record1, int record2) { }

	private int CompareRecordToKey(int record1, Object[] vals) { }

	private void DeleteRecord(int recordIndex) { }

	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	public void DeleteRecordFromIndex(int recordIndex) { }

	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	private int FindNodeByKey(object originalKey) { }

	private int FindNodeByKeyRecord(int record) { }

	private int FindNodeByKeys(Object[] originalKey) { }

	public Range FindRecords(Object[] key) { }

	public Range FindRecords(object key) { }

	internal void FireResetEvent() { }

	private bool get_DoListChanged() { }

	public bool get_HasDuplicates() { }

	internal bool get_HasRemoteAggregate() { }

	internal int get_ObjectID() { }

	public int get_RecordCount() { }

	public DataViewRowState get_RecordStates() { }

	public int get_RefCount() { }

	public IFilter get_RowFilter() { }

	internal DataTable get_Table() { }

	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	public RBTreeEnumerator<Int32> GetEnumerator(int startIndex) { }

	private int GetIndex(int record, int changeRecord) { }

	public int GetIndex(int record) { }

	private Range GetRangeFromNode(int nodeId) { }

	public int GetRecord(int recordIndex) { }

	private static int GetReplaceAction(DataViewRowState oldState) { }

	public DataRow GetRow(int i) { }

	public DataRow[] GetRows(Object[] values) { }

	public DataRow[] GetRows(Range range) { }

	public Object[] GetUniqueKeyValues() { }

	private void GetUniqueKeyValues(List<Object[]> list, int curNodeId) { }

	internal static int IndexOfReference(List<T> list, T item) { }

	private void InitRecords(IFilter filter) { }

	private int InsertRecord(int record, bool fireEvent) { }

	public int InsertRecordToIndex(int record) { }

	public bool IsKeyInIndex(object key) { }

	public bool IsKeyInIndex(Object[] key) { }

	public bool IsKeyRecordInIndex(int record) { }

	internal void ListChangedAdd(DataViewListener listener) { }

	internal void ListChangedRemove(DataViewListener listener) { }

	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	private void OnListChanged(ListChangedType changedType, int index) { }

	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	private void OnListChanged(ListChangedEventArgs e) { }

	public void RecordChanged(int record) { }

	public void RecordChanged(int oldIndex, int newIndex) { }

	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	public int RemoveRef() { }

	public void Reset() { }

}

