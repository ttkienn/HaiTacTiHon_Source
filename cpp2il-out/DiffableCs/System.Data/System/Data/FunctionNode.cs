namespace System.Data;

internal sealed class FunctionNode : ExpressionNode
{
	private static readonly Function[] s_funcs; //Field offset: 0x0
	internal readonly string _name; //Field offset: 0x18
	internal readonly int _info; //Field offset: 0x20
	internal int _argumentCount; //Field offset: 0x24
	internal ExpressionNode[] _arguments; //Field offset: 0x28
	[Nullable(2)]
	private readonly TypeLimiter _capturedLimiter; //Field offset: 0x30

	internal FunctionId Aggregate
	{
		internal get { } //Length: 147
	}

	internal bool IsAggregate
	{
		internal get { } //Length: 583
	}

	private static FunctionNode() { }

	internal FunctionNode(DataTable table, string name) { }

	internal void AddArgument(ExpressionNode argument) { }

	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	internal void Check() { }

	internal virtual bool DependsOn(DataColumn column) { }

	internal virtual object Eval() { }

	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	internal virtual object Eval(Int32[] recordNos) { }

	private object EvalFunction(FunctionId id, Object[] argumentValues, DataRow row, DataRowVersion version) { }

	internal FunctionId get_Aggregate() { }

	internal bool get_IsAggregate() { }

	private Type GetDataType(ExpressionNode node) { }

	internal virtual bool HasLocalAggregate() { }

	internal virtual bool HasRemoteAggregate() { }

	internal virtual bool IsConstant() { }

	internal virtual bool IsTableConstant() { }

	internal virtual ExpressionNode Optimize() { }

}

