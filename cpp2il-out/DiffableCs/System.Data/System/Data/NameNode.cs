namespace System.Data;

internal sealed class NameNode : ExpressionNode
{
	internal string _name; //Field offset: 0x18
	internal bool _found; //Field offset: 0x20
	internal DataColumn _column; //Field offset: 0x28

	internal virtual bool IsSqlColumn
	{
		internal get { } //Length: 106
	}

	internal NameNode(DataTable table, Char[] text, int start, int pos) { }

	internal NameNode(DataTable table, string name) { }

	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	internal virtual bool DependsOn(DataColumn column) { }

	internal virtual object Eval() { }

	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	internal virtual object Eval(Int32[] records) { }

	internal virtual bool get_IsSqlColumn() { }

	internal virtual bool HasLocalAggregate() { }

	internal virtual bool HasRemoteAggregate() { }

	internal virtual bool IsConstant() { }

	internal virtual bool IsTableConstant() { }

	internal virtual ExpressionNode Optimize() { }

	internal static string ParseName(Char[] text, int start, int pos) { }

}

