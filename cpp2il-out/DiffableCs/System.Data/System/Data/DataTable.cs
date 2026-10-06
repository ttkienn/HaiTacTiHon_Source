namespace System.Data;

[DefaultEvent("RowChanging")]
[DefaultProperty("TableName")]
[DesignTimeVisible(False)]
[ToolboxItem(False)]
[XmlSchemaProvider("GetDataTableSchema")]
public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable
{
	public struct DSRowDiffIdUsageSection
	{
		private DataSet _targetDS; //Field offset: 0x0

		internal void Prepare(DataSet ds) { }

	}

	public struct RowDiffIdUsageSection
	{
		private DataTable _targetTable; //Field offset: 0x0

		internal void Prepare(DataTable table) { }

	}

	private static int s_objectTypeCount; //Field offset: 0x0
	private DataSet _dataSet; //Field offset: 0x20
	private DataView _defaultView; //Field offset: 0x28
	internal long _nextRowID; //Field offset: 0x30
	internal readonly DataRowCollection _rowCollection; //Field offset: 0x38
	internal readonly DataColumnCollection _columnCollection; //Field offset: 0x40
	private readonly ConstraintCollection _constraintCollection; //Field offset: 0x48
	private int _elementColumnCount; //Field offset: 0x50
	internal DataRelationCollection _parentRelationsCollection; //Field offset: 0x58
	internal DataRelationCollection _childRelationsCollection; //Field offset: 0x60
	internal readonly RecordManager _recordManager; //Field offset: 0x68
	internal readonly List<Index> _indexes; //Field offset: 0x70
	private List<Index> _shadowIndexes; //Field offset: 0x78
	private int _shadowCount; //Field offset: 0x80
	internal PropertyCollection _extendedProperties; //Field offset: 0x88
	private string _tableName; //Field offset: 0x90
	internal string _tableNamespace; //Field offset: 0x98
	private string _tablePrefix; //Field offset: 0xA0
	internal DataExpression _displayExpression; //Field offset: 0xA8
	internal bool _fNestedInDataset; //Field offset: 0xB0
	private CultureInfo _culture; //Field offset: 0xB8
	private bool _cultureUserSet; //Field offset: 0xC0
	private CompareInfo _compareInfo; //Field offset: 0xC8
	private CompareOptions _compareFlags; //Field offset: 0xD0
	private IFormatProvider _formatProvider; //Field offset: 0xD8
	private StringComparer _hashCodeProvider; //Field offset: 0xE0
	private bool _caseSensitive; //Field offset: 0xE8
	private bool _caseSensitiveUserSet; //Field offset: 0xE9
	internal string _encodedTableName; //Field offset: 0xF0
	internal DataColumn _xmlText; //Field offset: 0xF8
	internal DataColumn _colUnique; //Field offset: 0x100
	internal decimal _minOccurs; //Field offset: 0x108
	internal decimal _maxOccurs; //Field offset: 0x118
	internal bool _repeatableElement; //Field offset: 0x128
	private object _typeName; //Field offset: 0x130
	internal UniqueConstraint _primaryKey; //Field offset: 0x138
	internal IndexField[] _primaryIndex; //Field offset: 0x140
	private DataColumn[] _delayedSetPrimaryKey; //Field offset: 0x148
	private Index _loadIndex; //Field offset: 0x150
	private Index _loadIndexwithOriginalAdded; //Field offset: 0x158
	private Index _loadIndexwithCurrentDeleted; //Field offset: 0x160
	private int _suspendIndexEvents; //Field offset: 0x168
	private bool _inDataLoad; //Field offset: 0x16C
	private bool _schemaLoading; //Field offset: 0x16D
	private bool _enforceConstraints; //Field offset: 0x16E
	internal bool _suspendEnforceConstraints; //Field offset: 0x16F
	protected private bool fInitInProgress; //Field offset: 0x170
	private bool _inLoad; //Field offset: 0x171
	internal bool _fInLoadDiffgram; //Field offset: 0x172
	private byte _isTypedDataTable; //Field offset: 0x173
	private DataRow[] _emptyDataRowArray; //Field offset: 0x178
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; //Field offset: 0x180
	private DataRelation[] _nestedParentRelations; //Field offset: 0x188
	internal List<DataColumn> _dependentColumns; //Field offset: 0x190
	private bool _mergingData; //Field offset: 0x198
	private DataRowChangeEventHandler _onRowChangedDelegate; //Field offset: 0x1A0
	private DataRowChangeEventHandler _onRowChangingDelegate; //Field offset: 0x1A8
	private DataRowChangeEventHandler _onRowDeletingDelegate; //Field offset: 0x1B0
	private DataRowChangeEventHandler _onRowDeletedDelegate; //Field offset: 0x1B8
	private DataColumnChangeEventHandler _onColumnChangedDelegate; //Field offset: 0x1C0
	private DataColumnChangeEventHandler _onColumnChangingDelegate; //Field offset: 0x1C8
	private DataTableClearEventHandler _onTableClearingDelegate; //Field offset: 0x1D0
	private DataTableClearEventHandler _onTableClearedDelegate; //Field offset: 0x1D8
	private DataTableNewRowEventHandler _onTableNewRowDelegate; //Field offset: 0x1E0
	private PropertyChangedEventHandler _onPropertyChangingDelegate; //Field offset: 0x1E8
	private readonly DataRowBuilder _rowBuilder; //Field offset: 0x1F0
	internal readonly List<DataView> _delayedViews; //Field offset: 0x1F8
	private readonly List<DataViewListener> _dataViewListeners; //Field offset: 0x200
	internal Hashtable _rowDiffId; //Field offset: 0x208
	internal readonly ReaderWriterLockSlim _indexesLock; //Field offset: 0x210
	internal int _ukColumnPositionForInference; //Field offset: 0x218
	private SerializationFormat _remotingFormat; //Field offset: 0x21C
	private readonly int _objectID; //Field offset: 0x220

	internal bool AreIndexEventsSuspended
	{
		internal get { } //Length: 11
	}

	public bool CaseSensitive
	{
		 get { } //Length: 8
		 set { } //Length: 186
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public DataRelationCollection ChildRelations
	{
		 get { } //Length: 113
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	public DataColumnCollection Columns
	{
		 get { } //Length: 5
	}

	private CompareInfo CompareInfo
	{
		private get { } //Length: 100
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	public ConstraintCollection Constraints
	{
		 get { } //Length: 5
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public DataSet DataSet
	{
		 get { } //Length: 5
	}

	internal string DisplayExpressionInternal
	{
		internal get { } //Length: 89
	}

	internal int ElementColumnCount
	{
		internal get { } //Length: 4
		internal set { } //Length: 69
	}

	internal string EncodedTableName
	{
		internal get { } //Length: 130
	}

	internal bool EnforceConstraints
	{
		internal get { } //Length: 36
		internal set { } //Length: 60
	}

	[Browsable(False)]
	public PropertyCollection ExtendedProperties
	{
		 get { } //Length: 115
	}

	internal IFormatProvider FormatProvider
	{
		internal get { } //Length: 166
	}

	private bool IsTypedDataTable
	{
		private get { } //Length: 166
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	internal List<Index> LiveIndexes
	{
		internal get { } //Length: 149
	}

	public CultureInfo Locale
	{
		 get { } //Length: 8
		 set { } //Length: 966
	}

	internal decimal MaxOccurs
	{
		internal get { } //Length: 14
		internal set { } //Length: 11
	}

	internal bool MergingData
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	[DefaultValue(50)]
	public int MinimumCapacity
	{
		 get { } //Length: 26
		 set { } //Length: 43
	}

	internal decimal MinOccurs
	{
		internal get { } //Length: 14
		internal set { } //Length: 11
	}

	public string Namespace
	{
		 get { } //Length: 121
		 set { } //Length: 626
	}

	internal bool NeedColumnChangeEvents
	{
		internal get { } //Length: 55
	}

	internal DataRelation[] NestedParentRelations
	{
		internal get { } //Length: 8
	}

	internal int NestedParentsCount
	{
		internal get { } //Length: 605
	}

	internal int ObjectID
	{
		internal get { } //Length: 7
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public DataRelationCollection ParentRelations
	{
		 get { } //Length: 113
	}

	[DefaultValue(null)]
	public string Prefix
	{
		 get { } //Length: 8
		 set { } //Length: 370
	}

	[TypeConverter(typeof(PrimaryKeyTypeConverter))]
	public DataColumn[] PrimaryKey
	{
		 get { } //Length: 94
		 set { } //Length: 1152
	}

	internal int RecordCapacity
	{
		internal get { } //Length: 26
	}

	[DefaultValue(SerializationFormat::Xml (0))]
	public SerializationFormat RemotingFormat
	{
		 get { } //Length: 7
		 set { } //Length: 113
	}

	internal Hashtable RowDiffId
	{
		internal get { } //Length: 117
	}

	[Browsable(False)]
	public DataRowCollection Rows
	{
		 get { } //Length: 5
	}

	internal bool SchemaLoading
	{
		internal get { } //Length: 8
	}

	internal bool SelfNested
	{
		internal get { } //Length: 502
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public virtual ISite Site
	{
		 get { } //Length: 5
	}

	internal bool SuspendEnforceConstraints
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	public string TableName
	{
		 get { } //Length: 8
		 set { } //Length: 1403
	}

	internal XmlQualifiedName TypeName
	{
		internal get { } //Length: 168
		internal set { } //Length: 19
	}

	internal int UKColumnPositionForInference
	{
		internal get { } //Length: 7
		internal set { } //Length: 7
	}

	internal DataColumn XmlText
	{
		internal get { } //Length: 8
		internal set { } //Length: 1498
	}

	public DataTable() { }

	public DataTable(string tableName) { }

	protected DataTable(SerializationInfo info, StreamingContext context) { }

	internal void AddDependentColumn(DataColumn expressionColumn) { }

	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	internal void AddRow(DataRow row, int proposedID) { }

	internal DataColumn AddUniqueKey() { }

	internal DataColumn AddUniqueKey(int position) { }

	internal void CacheNestedParent() { }

	internal void CascadeAll(DataRow row, DataRowAction action) { }

	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	internal void CheckNotModifying(DataRow row) { }

	public void Clear() { }

	internal void Clear(bool clearAll) { }

	internal DataTable Clone(DataSet cloneDS) { }

	public override DataTable Clone() { }

	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	internal void CommitRow(DataRow row) { }

	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	internal int Compare(string s1, string s2) { }

	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	internal DataRow CreateEmptyRow() { }

	protected override DataTable CreateInstance() { }

	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	internal void DeleteRow(DataRow row) { }

	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	internal void DoRaiseNamespaceChange() { }

	internal void EnableConstraints() { }

	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }

	internal void EvaluateDependentExpressions(DataColumn column) { }

	internal void EvaluateExpressions(DataColumn column) { }

	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	internal void EvaluateExpressions() { }

	internal DataRow FindByIndex(Index ndx, Object[] key) { }

	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	private DataRelation[] FindNestedParentRelations() { }

	internal string FormatSortString(IndexField[] indexDesc) { }

	internal void FreeRecord(ref int record) { }

	internal bool get_AreIndexEventsSuspended() { }

	public bool get_CaseSensitive() { }

	public DataRelationCollection get_ChildRelations() { }

	public DataColumnCollection get_Columns() { }

	private CompareInfo get_CompareInfo() { }

	public ConstraintCollection get_Constraints() { }

	public DataSet get_DataSet() { }

	internal string get_DisplayExpressionInternal() { }

	internal int get_ElementColumnCount() { }

	internal string get_EncodedTableName() { }

	internal bool get_EnforceConstraints() { }

	public PropertyCollection get_ExtendedProperties() { }

	internal IFormatProvider get_FormatProvider() { }

	private bool get_IsTypedDataTable() { }

	internal List<Index> get_LiveIndexes() { }

	public CultureInfo get_Locale() { }

	internal decimal get_MaxOccurs() { }

	internal bool get_MergingData() { }

	public int get_MinimumCapacity() { }

	internal decimal get_MinOccurs() { }

	public string get_Namespace() { }

	internal bool get_NeedColumnChangeEvents() { }

	internal DataRelation[] get_NestedParentRelations() { }

	internal int get_NestedParentsCount() { }

	internal int get_ObjectID() { }

	public DataRelationCollection get_ParentRelations() { }

	public string get_Prefix() { }

	public DataColumn[] get_PrimaryKey() { }

	internal int get_RecordCapacity() { }

	public SerializationFormat get_RemotingFormat() { }

	internal Hashtable get_RowDiffId() { }

	public DataRowCollection get_Rows() { }

	internal bool get_SchemaLoading() { }

	internal bool get_SelfNested() { }

	public virtual ISite get_Site() { }

	internal bool get_SuspendEnforceConstraints() { }

	public string get_TableName() { }

	internal XmlQualifiedName get_TypeName() { }

	internal int get_UKColumnPositionForInference() { }

	internal DataColumn get_XmlText() { }

	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	internal List<DataViewListener> GetListeners() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	protected override Type GetRowType() { }

	protected override XmlSchema GetSchema() { }

	internal int GetSpecialHashCode(string name) { }

	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	internal int IndexOf(string s1, string s2) { }

	internal Int32[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	internal void InsertRow(DataRow row, long proposedID) { }

	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	private bool IsEmptyXml(XmlReader reader) { }

	internal bool IsNamespaceInherited() { }

	internal bool IsSuffix(string s1, string s2) { }

	public void Merge(DataTable table) { }

	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	internal bool MoveToElement(XmlReader reader, int depth) { }

	internal DataRow NewEmptyRow() { }

	internal int NewRecord(int sourceRecord) { }

	internal int NewRecord() { }

	internal DataRow NewRow(int record) { }

	public DataRow NewRow() { }

	protected private DataRow[] NewRowArray(int size) { }

	private void NewRowCreated(DataRow row) { }

	protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	internal int NewUninitializedRecord() { }

	private DataRow NewUninitializedRow() { }

	protected private override void OnColumnChanged(DataColumnChangeEventArgs e) { }

	protected private override void OnColumnChanging(DataColumnChangeEventArgs e) { }

	protected override void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	protected override void OnRemoveColumn(DataColumn column) { }

	internal void OnRemoveColumnInternal(DataColumn column) { }

	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	protected override void OnRowChanged(DataRowChangeEventArgs e) { }

	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	protected override void OnRowChanging(DataRowChangeEventArgs e) { }

	protected override void OnRowDeleted(DataRowChangeEventArgs e) { }

	protected override void OnRowDeleting(DataRowChangeEventArgs e) { }

	protected override void OnTableCleared(DataTableClearEventArgs e) { }

	protected override void OnTableClearing(DataTableClearEventArgs e) { }

	protected override void OnTableNewRow(DataTableNewRowEventArgs e) { }

	internal IndexField[] ParseSortString(string sortString) { }

	internal void RaisePropertyChanging(string name) { }

	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	internal void ReadEndElement(XmlReader reader) { }

	internal void ReadXDRSchema(XmlReader reader) { }

	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	private void ReadXmlDiffgram(XmlReader reader) { }

	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	protected override void ReadXmlSerializable(XmlReader reader) { }

	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	internal void RecordChanged(int record) { }

	internal void RecordChanged(Int32[] oldIndex, Int32[] newIndex) { }

	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	internal Int32[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	internal void RemoveRow(DataRow row, bool check) { }

	public override void Reset() { }

	private void ResetConstraints() { }

	internal void ResetIndexes() { }

	internal void ResetInternalIndexes(DataColumn column) { }

	private void RestoreConstraint(bool originalEnforceConstraint) { }

	internal void RestoreIndexEvents(bool forceReset) { }

	private void RestoreShadowIndexes() { }

	internal void RollbackRow(DataRow row) { }

	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	public void set_CaseSensitive(bool value) { }

	internal void set_ElementColumnCount(int value) { }

	internal void set_EnforceConstraints(bool value) { }

	public void set_Locale(CultureInfo value) { }

	internal void set_MaxOccurs(decimal value) { }

	internal void set_MergingData(bool value) { }

	public void set_MinimumCapacity(int value) { }

	internal void set_MinOccurs(decimal value) { }

	public void set_Namespace(string value) { }

	public void set_Prefix(string value) { }

	public void set_PrimaryKey(DataColumn[] value) { }

	public void set_RemotingFormat(SerializationFormat value) { }

	internal void set_SuspendEnforceConstraints(bool value) { }

	public void set_TableName(string value) { }

	internal void set_TypeName(XmlQualifiedName value) { }

	internal void set_UKColumnPositionForInference(int value) { }

	internal void set_XmlText(DataColumn value) { }

	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	internal void SetDataSet(DataSet dataSet) { }

	internal void SetKeyValues(DataKey key, Object[] keyValues, int record) { }

	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = false, bool fireEvent = true, bool suppressEnsurePropertyChanged = false) { }

	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	private void SetShadowIndexes() { }

	internal void ShadowIndexCopy() { }

	internal bool ShouldSerializeCaseSensitive() { }

	internal bool ShouldSerializeLocale() { }

	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	internal void SuspendIndexEvents() { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public virtual string ToString() { }

	internal void UpdatePropertyDescriptorCollectionCache() { }

	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

}

