namespace System.Data;

[DefaultMember("Item")]
[DefaultProperty("ColumnName")]
[DesignTimeVisible(False)]
[ToolboxItem(False)]
public class DataColumn : MarshalByValueComponent
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private bool _allowNull; //Field offset: 0x20
	private string _caption; //Field offset: 0x28
	private string _columnName; //Field offset: 0x30
	private Type _dataType; //Field offset: 0x38
	private StorageType _storageType; //Field offset: 0x40
	internal object _defaultValue; //Field offset: 0x48
	private DataSetDateTime _dateTimeMode; //Field offset: 0x50
	private DataExpression _expression; //Field offset: 0x58
	private int _maxLength; //Field offset: 0x60
	private int _ordinal; //Field offset: 0x64
	private bool _readOnly; //Field offset: 0x68
	internal Index _sortIndex; //Field offset: 0x70
	internal DataTable _table; //Field offset: 0x78
	private bool _unique; //Field offset: 0x80
	internal MappingType _columnMapping; //Field offset: 0x84
	internal int _hashCode; //Field offset: 0x88
	internal int _errors; //Field offset: 0x8C
	private bool _isSqlType; //Field offset: 0x90
	private bool _implementsINullable; //Field offset: 0x91
	private bool _implementsIChangeTracking; //Field offset: 0x92
	private bool _implementsIRevertibleChangeTracking; //Field offset: 0x93
	private bool _implementsIXMLSerializable; //Field offset: 0x94
	private bool _defaultValueIsNull; //Field offset: 0x95
	internal List<DataColumn> _dependentColumns; //Field offset: 0x98
	internal PropertyCollection _extendedProperties; //Field offset: 0xA0
	private DataStorage _storage; //Field offset: 0xA8
	private AutoIncrementValue _autoInc; //Field offset: 0xB0
	internal string _columnUri; //Field offset: 0xB8
	private string _columnPrefix; //Field offset: 0xC0
	internal string _encodedColumnName; //Field offset: 0xC8
	internal SimpleType _simpleType; //Field offset: 0xD0
	private readonly int _objectID; //Field offset: 0xD8
	[CompilerGenerated]
	private string <XmlDataType>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; //Field offset: 0xE8

	[DefaultValue(True)]
	public bool AllowDBNull
	{
		 get { } //Length: 5
		 set { } //Length: 332
	}

	internal AutoIncrementValue AutoInc
	{
		internal get { } //Length: 259
	}

	[DefaultValue(False)]
	[RefreshProperties(RefreshProperties::All (1))]
	public bool AutoIncrement
	{
		 get { } //Length: 25
		 set { } //Length: 497
	}

	internal object AutoIncrementCurrent
	{
		internal get { } //Length: 107
		internal set { } //Length: 416
	}

	[DefaultValue(0)]
	public long AutoIncrementSeed
	{
		 get { } //Length: 40
		 set { } //Length: 254
	}

	[DefaultValue(1)]
	public long AutoIncrementStep
	{
		 get { } //Length: 43
		 set { } //Length: 257
	}

	public string Caption
	{
		 get { } //Length: 17
		 set { } //Length: 220
	}

	[DefaultValue(MappingType::Element (1))]
	public override MappingType ColumnMapping
	{
		 get { } //Length: 7
		 set { } //Length: 740
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	public string ColumnName
	{
		 get { } //Length: 5
		 set { } //Length: 1038
	}

	internal bool Computed
	{
		internal get { } //Length: 9
	}

	internal DataExpression DataExpression
	{
		internal get { } //Length: 5
	}

	[DefaultValue(typeof(string)]
	[RefreshProperties(RefreshProperties::All (1))]
	[TypeConverter(typeof(ColumnTypeConverter))]
	public Type DataType
	{
		 get { } //Length: 5
		 set { } //Length: 2955
	}

	[DefaultValue(DataSetDateTime::UnspecifiedLocal (3))]
	[RefreshProperties(RefreshProperties::All (1))]
	public DataSetDateTime DateTimeMode
	{
		 get { } //Length: 4
		 set { } //Length: 378
	}

	[TypeConverter(typeof(DefaultValueTypeConverter))]
	public object DefaultValue
	{
		 get { } //Length: 368
		 set { } //Length: 772
	}

	internal bool DefaultValueIsNull
	{
		internal get { } //Length: 8
	}

	internal string EncodedColumnName
	{
		internal get { } //Length: 127
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	public string Expression
	{
		 get { } //Length: 73
		 set { } //Length: 1991
	}

	[Browsable(False)]
	public PropertyCollection ExtendedProperties
	{
		 get { } //Length: 115
	}

	internal IFormatProvider FormatProvider
	{
		internal get { } //Length: 93
	}

	internal bool HasData
	{
		internal get { } //Length: 12
	}

	internal bool ImplementsIChangeTracking
	{
		internal get { } //Length: 8
	}

	internal bool ImplementsINullable
	{
		internal get { } //Length: 8
	}

	internal bool ImplementsIRevertibleChangeTracking
	{
		internal get { } //Length: 8
	}

	internal bool ImplementsIXMLSerializable
	{
		internal get { } //Length: 8
	}

	internal bool IsCustomType
	{
		internal get { } //Length: 104
	}

	internal bool IsSqlType
	{
		internal get { } //Length: 8
	}

	internal bool IsValueType
	{
		internal get { } //Length: 30
	}

	internal object Item
	{
		internal get { } //Length: 45
		internal set { } //Length: 410
	}

	internal CultureInfo Locale
	{
		internal get { } //Length: 94
	}

	[DefaultValue(-1)]
	public int MaxLength
	{
		 get { } //Length: 4
		 set { } //Length: 1009
	}

	public string Namespace
	{
		 get { } //Length: 115
		 set { } //Length: 415
	}

	internal int ObjectID
	{
		internal get { } //Length: 7
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public int Ordinal
	{
		 get { } //Length: 4
	}

	[DefaultValue(null)]
	public string Prefix
	{
		 get { } //Length: 8
		 set { } //Length: 370
	}

	[DefaultValue(False)]
	public bool ReadOnly
	{
		 get { } //Length: 5
		 set { } //Length: 218
	}

	internal SimpleType SimpleType
	{
		internal get { } //Length: 8
		internal set { } //Length: 88
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Index SortIndex
	{
		private get { } //Length: 224
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public DataTable Table
	{
		 get { } //Length: 5
	}

	[DefaultValue(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public bool Unique
	{
		 get { } //Length: 8
		 set { } //Length: 1048
	}

	internal string XmlDataType
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 19
	}

	public DataColumn() { }

	public DataColumn(string columnName, Type dataType) { }

	public DataColumn(string columnName, Type dataType, string expr, MappingType type) { }

	internal void AddDependentColumn(DataColumn expressionColumn) { }

	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	internal bool CheckMaxLength() { }

	internal void CheckMaxLength(DataRow dr) { }

	protected private void CheckNotAllowNull() { }

	internal void CheckNullable(DataRow row) { }

	protected void CheckUnique() { }

	internal DataColumn Clone() { }

	internal int Compare(int record1, int record2) { }

	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	internal int CompareValueTo(int record1, object value) { }

	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	internal string ConvertObjectToXml(object value) { }

	internal object ConvertValue(object value) { }

	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	internal object ConvertXmlToObject(string s) { }

	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	internal void FreeRecord(int record) { }

	public bool get_AllowDBNull() { }

	internal AutoIncrementValue get_AutoInc() { }

	public bool get_AutoIncrement() { }

	internal object get_AutoIncrementCurrent() { }

	public long get_AutoIncrementSeed() { }

	public long get_AutoIncrementStep() { }

	public string get_Caption() { }

	public override MappingType get_ColumnMapping() { }

	public string get_ColumnName() { }

	internal bool get_Computed() { }

	internal DataExpression get_DataExpression() { }

	public Type get_DataType() { }

	public DataSetDateTime get_DateTimeMode() { }

	public object get_DefaultValue() { }

	internal bool get_DefaultValueIsNull() { }

	internal string get_EncodedColumnName() { }

	public string get_Expression() { }

	public PropertyCollection get_ExtendedProperties() { }

	internal IFormatProvider get_FormatProvider() { }

	internal bool get_HasData() { }

	internal bool get_ImplementsIChangeTracking() { }

	internal bool get_ImplementsINullable() { }

	internal bool get_ImplementsIRevertibleChangeTracking() { }

	internal bool get_ImplementsIXMLSerializable() { }

	internal bool get_IsCustomType() { }

	internal bool get_IsSqlType() { }

	internal bool get_IsValueType() { }

	internal object get_Item(int record) { }

	internal CultureInfo get_Locale() { }

	public int get_MaxLength() { }

	public string get_Namespace() { }

	internal int get_ObjectID() { }

	public int get_Ordinal() { }

	public string get_Prefix() { }

	public bool get_ReadOnly() { }

	internal SimpleType get_SimpleType() { }

	private Index get_SortIndex() { }

	public DataTable get_Table() { }

	public bool get_Unique() { }

	[CompilerGenerated]
	internal string get_XmlDataType() { }

	internal object GetAggregateValue(Int32[] records, AggregateType kind) { }

	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	private DataRow GetDataRow(int index) { }

	internal object GetEmptyColumnStore(int recordCount) { }

	private int GetStringLength(int record) { }

	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

	internal void Init(int record) { }

	internal void InitializeRecord(int record) { }

	private void InsureStorage() { }

	internal void InternalUnique(bool value) { }

	internal static bool IsAutoIncrementType(Type dataType) { }

	internal bool IsInRelation() { }

	internal bool IsMaxLengthViolated() { }

	internal bool IsNotAllowDBNullViolated() { }

	internal bool IsValueCustomTypeInstance(object value) { }

	protected override void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	internal void OnSetDataSet() { }

	protected private void RaisePropertyChanging(string name) { }

	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	public void set_AllowDBNull(bool value) { }

	public void set_AutoIncrement(bool value) { }

	internal void set_AutoIncrementCurrent(object value) { }

	public void set_AutoIncrementSeed(long value) { }

	public void set_AutoIncrementStep(long value) { }

	public void set_Caption(string value) { }

	public override void set_ColumnMapping(MappingType value) { }

	public void set_ColumnName(string value) { }

	public void set_DataType(Type value) { }

	public void set_DateTimeMode(DataSetDateTime value) { }

	public void set_DefaultValue(object value) { }

	public void set_Expression(string value) { }

	internal void set_Item(int record, object value) { }

	public void set_MaxLength(int value) { }

	public void set_Namespace(string value) { }

	public void set_Prefix(string value) { }

	public void set_ReadOnly(bool value) { }

	internal void set_SimpleType(SimpleType value) { }

	public void set_Unique(bool value) { }

	[CompilerGenerated]
	internal void set_XmlDataType(string value) { }

	internal void SetCapacity(int capacity) { }

	private void SetMaxLengthSimpleType() { }

	internal void SetOrdinalInternal(int ordinal) { }

	internal void SetStorage(object store, BitArray nullbits) { }

	internal void SetTable(DataTable table) { }

	internal void SetValue(int record, object value) { }

	public virtual string ToString() { }

	private void UpdateColumnType(Type type, StorageType typeCode) { }

}

