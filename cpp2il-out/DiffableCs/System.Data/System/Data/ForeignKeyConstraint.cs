namespace System.Data;

[DefaultProperty("ConstraintName")]
public class ForeignKeyConstraint : Constraint
{
	internal Rule _deleteRule; //Field offset: 0x38
	internal Rule _updateRule; //Field offset: 0x3C
	internal AcceptRejectRule _acceptRejectRule; //Field offset: 0x40
	private DataKey _childKey; //Field offset: 0x48
	private DataKey _parentKey; //Field offset: 0x50
	internal string _constraintName; //Field offset: 0x58
	internal String[] _parentColumnNames; //Field offset: 0x60
	internal String[] _childColumnNames; //Field offset: 0x68
	internal string _parentTableName; //Field offset: 0x70

	[DefaultValue(AcceptRejectRule::None (0))]
	public override AcceptRejectRule AcceptRejectRule
	{
		 get { } //Length: 25
		 set { } //Length: 77
	}

	internal String[] ChildColumnNames
	{
		internal get { } //Length: 11
	}

	internal DataKey ChildKey
	{
		internal get { } //Length: 26
	}

	[ReadOnly(True)]
	public override DataColumn[] Columns
	{
		 get { } //Length: 32
	}

	[DefaultValue(Rule::Cascade (1))]
	public override Rule DeleteRule
	{
		 get { } //Length: 25
		 set { } //Length: 77
	}

	internal String[] ParentColumnNames
	{
		internal get { } //Length: 11
	}

	internal DataKey ParentKey
	{
		internal get { } //Length: 26
	}

	[ReadOnly(True)]
	public override DataColumn[] RelatedColumns
	{
		 get { } //Length: 32
	}

	internal DataColumn[] RelatedColumnsReference
	{
		internal get { } //Length: 26
	}

	[ReadOnly(True)]
	public override DataTable RelatedTable
	{
		 get { } //Length: 32
	}

	[ReadOnly(True)]
	public virtual DataTable Table
	{
		 get { } //Length: 32
	}

	[DefaultValue(Rule::Cascade (1))]
	public override Rule UpdateRule
	{
		 get { } //Length: 25
		 set { } //Length: 77
	}

	public ForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	public ForeignKeyConstraint(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Browsable(False)]
	public ForeignKeyConstraint(string constraintName, string parentTableName, String[] parentColumnNames, String[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	internal virtual bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	internal virtual bool CanEnableConstraint() { }

	internal void CascadeCommit(DataRow row) { }

	internal void CascadeDelete(DataRow row) { }

	internal void CascadeRollback(DataRow row) { }

	internal void CascadeUpdate(DataRow row) { }

	internal virtual void CheckCanAddToCollection(ConstraintCollection constraints) { }

	internal void CheckCanClearParentTable(DataTable table) { }

	internal void CheckCanRemoveParentRow(DataRow row) { }

	internal void CheckCascade(DataRow row, DataRowAction action) { }

	internal virtual void CheckConstraint(DataRow childRow, DataRowAction action) { }

	internal virtual void CheckState() { }

	internal virtual Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	internal ForeignKeyConstraint Clone(DataTable destination) { }

	internal virtual Constraint Clone(DataSet destination) { }

	internal virtual bool ContainsColumn(DataColumn column) { }

	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	public virtual bool Equals(object key) { }

	internal DataRelation FindParentRelation() { }

	public override AcceptRejectRule get_AcceptRejectRule() { }

	internal String[] get_ChildColumnNames() { }

	internal DataKey get_ChildKey() { }

	public override DataColumn[] get_Columns() { }

	public override Rule get_DeleteRule() { }

	internal String[] get_ParentColumnNames() { }

	internal DataKey get_ParentKey() { }

	public override DataColumn[] get_RelatedColumns() { }

	internal DataColumn[] get_RelatedColumnsReference() { }

	public override DataTable get_RelatedTable() { }

	public virtual DataTable get_Table() { }

	public override Rule get_UpdateRule() { }

	public virtual int GetHashCode() { }

	internal virtual bool IsConstraintViolated() { }

	internal bool IsKeyNull(Object[] values) { }

	private void NonVirtualCheckState() { }

	public override void set_AcceptRejectRule(AcceptRejectRule value) { }

	public override void set_DeleteRule(Rule value) { }

	public override void set_UpdateRule(Rule value) { }

}

