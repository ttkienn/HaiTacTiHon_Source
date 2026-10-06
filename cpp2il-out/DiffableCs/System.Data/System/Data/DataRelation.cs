namespace System.Data;

[DefaultProperty("RelationName")]
[TypeConverter(typeof(RelationshipConverter))]
public class DataRelation
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private DataSet _dataSet; //Field offset: 0x10
	internal PropertyCollection _extendedProperties; //Field offset: 0x18
	internal string _relationName; //Field offset: 0x20
	private DataKey _childKey; //Field offset: 0x28
	private DataKey _parentKey; //Field offset: 0x30
	private UniqueConstraint _parentKeyConstraint; //Field offset: 0x38
	private ForeignKeyConstraint _childKeyConstraint; //Field offset: 0x40
	internal String[] _parentColumnNames; //Field offset: 0x48
	internal String[] _childColumnNames; //Field offset: 0x50
	internal string _parentTableName; //Field offset: 0x58
	internal string _childTableName; //Field offset: 0x60
	internal string _parentTableNamespace; //Field offset: 0x68
	internal string _childTableNamespace; //Field offset: 0x70
	internal bool _nested; //Field offset: 0x78
	internal bool _createConstraints; //Field offset: 0x79
	private bool _checkMultipleNested; //Field offset: 0x7A
	private readonly int _objectID; //Field offset: 0x7C
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; //Field offset: 0x80

	internal bool CheckMultipleNested
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal String[] ChildColumnNames
	{
		internal get { } //Length: 11
	}

	public override DataColumn[] ChildColumns
	{
		 get { } //Length: 32
	}

	internal DataColumn[] ChildColumnsReference
	{
		internal get { } //Length: 26
	}

	internal DataKey ChildKey
	{
		internal get { } //Length: 26
	}

	public override ForeignKeyConstraint ChildKeyConstraint
	{
		 get { } //Length: 26
	}

	public override DataTable ChildTable
	{
		 get { } //Length: 61
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public override DataSet DataSet
	{
		 get { } //Length: 26
	}

	[Browsable(False)]
	public PropertyCollection ExtendedProperties
	{
		 get { } //Length: 106
	}

	[DefaultValue(False)]
	public override bool Nested
	{
		 get { } //Length: 26
		 set { } //Length: 3918
	}

	internal int ObjectID
	{
		internal get { } //Length: 4
	}

	internal String[] ParentColumnNames
	{
		internal get { } //Length: 11
	}

	public override DataColumn[] ParentColumns
	{
		 get { } //Length: 32
	}

	internal DataColumn[] ParentColumnsReference
	{
		internal get { } //Length: 5
	}

	internal DataKey ParentKey
	{
		internal get { } //Length: 26
	}

	public override UniqueConstraint ParentKeyConstraint
	{
		 get { } //Length: 26
	}

	public override DataTable ParentTable
	{
		 get { } //Length: 61
	}

	[DefaultValue(null)]
	public override string RelationName
	{
		 get { } //Length: 26
	}

	public DataRelation(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	[Browsable(False)]
	public DataRelation(string relationName, string parentTableName, string childTableName, String[] parentColumnNames, String[] childColumnNames, bool nested) { }

	[Browsable(False)]
	public DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, String[] parentColumnNames, String[] childColumnNames, bool nested) { }

	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	internal void CheckNestedRelations() { }

	internal void CheckState() { }

	protected void CheckStateForProperty() { }

	internal DataRelation Clone(DataSet destination) { }

	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	internal bool get_CheckMultipleNested() { }

	internal String[] get_ChildColumnNames() { }

	public override DataColumn[] get_ChildColumns() { }

	internal DataColumn[] get_ChildColumnsReference() { }

	internal DataKey get_ChildKey() { }

	public override ForeignKeyConstraint get_ChildKeyConstraint() { }

	public override DataTable get_ChildTable() { }

	public override DataSet get_DataSet() { }

	public PropertyCollection get_ExtendedProperties() { }

	public override bool get_Nested() { }

	internal int get_ObjectID() { }

	internal String[] get_ParentColumnNames() { }

	public override DataColumn[] get_ParentColumns() { }

	internal DataColumn[] get_ParentColumnsReference() { }

	internal DataKey get_ParentKey() { }

	public override UniqueConstraint get_ParentKeyConstraint() { }

	public override DataTable get_ParentTable() { }

	public override string get_RelationName() { }

	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	private bool IsAutoGenerated(DataColumn col) { }

	private static bool IsKeyNull(Object[] values) { }

	protected private void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	protected private void RaisePropertyChanging(string name) { }

	internal void set_CheckMultipleNested(bool value) { }

	public override void set_Nested(bool value) { }

	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	internal void SetDataSet(DataSet dataSet) { }

	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	public virtual string ToString() { }

	internal void ValidateMultipleNestedRelations() { }

}

