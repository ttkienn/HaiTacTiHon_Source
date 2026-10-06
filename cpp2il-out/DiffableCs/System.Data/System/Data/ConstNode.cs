namespace System.Data;

internal sealed class ConstNode : ExpressionNode
{
	internal readonly object _val; //Field offset: 0x18

	internal ConstNode(DataTable table, ValueType type, object constant) { }

	internal ConstNode(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	internal virtual object Eval() { }

	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	internal virtual object Eval(Int32[] recordNos) { }

	internal virtual bool HasLocalAggregate() { }

	internal virtual bool HasRemoteAggregate() { }

	internal virtual bool IsConstant() { }

	internal virtual bool IsTableConstant() { }

	internal virtual ExpressionNode Optimize() { }

	private object SmallestDecimal(object constant) { }

	private object SmallestNumeric(object constant) { }

}

