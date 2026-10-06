namespace System.Data;

internal sealed class ZeroOpNode : ExpressionNode
{
	internal readonly int _op; //Field offset: 0x18

	internal ZeroOpNode(int op) { }

	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	internal virtual object Eval() { }

	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	internal virtual object Eval(Int32[] recordNos) { }

	internal virtual bool HasLocalAggregate() { }

	internal virtual bool HasRemoteAggregate() { }

	internal virtual bool IsConstant() { }

	internal virtual bool IsTableConstant() { }

	internal virtual ExpressionNode Optimize() { }

}

