namespace System.Data;

internal sealed class UnaryNode : ExpressionNode
{
	internal readonly int _op; //Field offset: 0x18
	internal ExpressionNode _right; //Field offset: 0x20

	internal UnaryNode(DataTable table, int op, ExpressionNode right) { }

	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	internal virtual bool DependsOn(DataColumn column) { }

	internal virtual object Eval() { }

	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	internal virtual object Eval(Int32[] recordNos) { }

	private object EvalUnaryOp(int op, object vl) { }

	internal virtual bool HasLocalAggregate() { }

	internal virtual bool HasRemoteAggregate() { }

	internal virtual bool IsConstant() { }

	internal virtual bool IsTableConstant() { }

	internal virtual ExpressionNode Optimize() { }

}

