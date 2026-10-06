namespace System.Data;

[DefaultProperty("ConstraintName")]
public class UniqueConstraint : Constraint
{
	private DataKey _key; //Field offset: 0x38
	private Index _constraintIndex; //Field offset: 0x40
	internal bool _bPrimaryKey; //Field offset: 0x48
	internal string _constraintName; //Field offset: 0x50
	internal String[] _columnNames; //Field offset: 0x58

	internal String[] ColumnNames
	{
		internal get { } //Length: 11
	}

	[ReadOnly(True)]
	public override DataColumn[] Columns
	{
		 get { } //Length: 11
	}

	internal DataColumn[] ColumnsReference
	{
		internal get { } //Length: 5
	}

	internal Index ConstraintIndex
	{
		internal get { } //Length: 5
	}

	internal virtual bool InCollection
	{
		internal set { } //Length: 71
	}

	public bool IsPrimaryKey
	{
		 get { } //Length: 87
	}

	internal DataKey Key
	{
		internal get { } //Length: 5
	}

	[ReadOnly(True)]
	public virtual DataTable Table
	{
		 get { } //Length: 48
	}

	public UniqueConstraint(DataColumn column) { }

	public UniqueConstraint(string name, DataColumn[] columns) { }

	public UniqueConstraint(DataColumn[] columns) { }

	[Browsable(False)]
	public UniqueConstraint(string name, String[] columnNames, bool isPrimaryKey) { }

	public UniqueConstraint(string name, DataColumn[] columns, bool isPrimaryKey) { }

	internal virtual bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	internal virtual bool CanEnableConstraint() { }

	internal virtual void CheckCanAddToCollection(ConstraintCollection constraints) { }

	internal virtual void CheckConstraint(DataRow row, DataRowAction action) { }

	internal virtual void CheckState() { }

	internal virtual Constraint Clone(DataSet destination) { }

	internal virtual Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	internal UniqueConstraint Clone(DataTable table) { }

	internal void ConstraintIndexClear() { }

	internal void ConstraintIndexInitialize() { }

	internal virtual bool ContainsColumn(DataColumn column) { }

	private void Create(string constraintName, DataColumn[] columns) { }

	public virtual bool Equals(object key2) { }

	internal String[] get_ColumnNames() { }

	public override DataColumn[] get_Columns() { }

	internal DataColumn[] get_ColumnsReference() { }

	internal Index get_ConstraintIndex() { }

	public bool get_IsPrimaryKey() { }

	internal DataKey get_Key() { }

	public virtual DataTable get_Table() { }

	public virtual int GetHashCode() { }

	internal virtual bool IsConstraintViolated() { }

	private void NonVirtualCheckState() { }

	internal virtual void set_InCollection(bool value) { }

}

