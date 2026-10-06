namespace System.Data;

internal sealed class AggregateNode : ExpressionNode
{
	private readonly AggregateType _type; //Field offset: 0x18
	private readonly Aggregate _aggregate; //Field offset: 0x1C
	private readonly bool _local; //Field offset: 0x20
	private readonly string _relationName; //Field offset: 0x28
	private readonly string _columnName; //Field offset: 0x30
	private DataTable _childTable; //Field offset: 0x38
	private DataColumn _column; //Field offset: 0x40
	private DataRelation _relation; //Field offset: 0x48

	internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName) { }

	internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	internal virtual bool DependsOn(DataColumn column) { }

	internal virtual object Eval() { }

	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	internal virtual object Eval(Int32[] records) { }

	internal virtual bool HasLocalAggregate() { }

	internal virtual bool HasRemoteAggregate() { }

	internal virtual bool IsConstant() { }

	internal virtual bool IsTableConstant() { }

	internal virtual ExpressionNode Optimize() { }

}

