namespace System.Data;

internal abstract class ExpressionNode
{
	private DataTable _table; //Field offset: 0x10

	internal IFormatProvider FormatProvider
	{
		internal get { } //Length: 93
	}

	internal override bool IsSqlColumn
	{
		internal get { } //Length: 3
	}

	protected DataTable table
	{
		 get { } //Length: 5
	}

	protected ExpressionNode(DataTable table) { }

	internal abstract void Bind(DataTable table, List<DataColumn> list) { }

	protected void BindTable(DataTable table) { }

	internal override bool DependsOn(DataColumn column) { }

	internal abstract object Eval() { }

	internal abstract object Eval(DataRow row, DataRowVersion version) { }

	internal abstract object Eval(Int32[] recordNos) { }

	internal IFormatProvider get_FormatProvider() { }

	internal override bool get_IsSqlColumn() { }

	protected DataTable get_table() { }

	internal abstract bool HasLocalAggregate() { }

	internal abstract bool HasRemoteAggregate() { }

	internal abstract bool IsConstant() { }

	internal static bool IsFloat(StorageType type) { }

	internal static bool IsFloatSql(StorageType type) { }

	internal static bool IsInteger(StorageType type) { }

	internal static bool IsIntegerSql(StorageType type) { }

	internal static bool IsNumeric(StorageType type) { }

	internal static bool IsNumericSql(StorageType type) { }

	internal static bool IsSigned(StorageType type) { }

	internal static bool IsSignedSql(StorageType type) { }

	internal abstract bool IsTableConstant() { }

	internal static bool IsUnsigned(StorageType type) { }

	internal static bool IsUnsignedSql(StorageType type) { }

	internal abstract ExpressionNode Optimize() { }

}

