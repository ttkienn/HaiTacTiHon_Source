namespace System.Data;

internal class BinaryNode : ExpressionNode
{
	private enum DataTypePrecedence
	{
		SqlDateTime = 25,
		DateTimeOffset = 24,
		DateTime = 23,
		TimeSpan = 20,
		SqlDouble = 19,
		Double = 18,
		SqlSingle = 17,
		Single = 16,
		SqlDecimal = 15,
		Decimal = 14,
		SqlMoney = 13,
		UInt64 = 12,
		SqlInt64 = 11,
		Int64 = 10,
		UInt32 = 9,
		SqlInt32 = 8,
		Int32 = 7,
		UInt16 = 6,
		SqlInt16 = 5,
		Int16 = 4,
		Byte = 3,
		SqlByte = 2,
		SByte = 1,
		Error = 0,
		SqlBoolean = -1,
		Boolean = -2,
		SqlGuid = -3,
		SqlString = -4,
		String = -5,
		SqlXml = -6,
		SqlChars = -7,
		Char = -8,
		SqlBytes = -9,
		SqlBinary = -10,
	}

	internal int _op; //Field offset: 0x18
	internal ExpressionNode _left; //Field offset: 0x20
	internal ExpressionNode _right; //Field offset: 0x28

	internal BinaryNode(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	internal virtual bool DependsOn(DataColumn column) { }

	internal virtual object Eval() { }

	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	internal virtual object Eval(Int32[] recordNos) { }

	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, Int32[] recordNos) { }

	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, Int32[] recordNos) { }

	private DataTypePrecedence GetPrecedence(StorageType storageType) { }

	private static StorageType GetPrecedenceType(DataTypePrecedence code) { }

	internal virtual bool HasLocalAggregate() { }

	internal virtual bool HasRemoteAggregate() { }

	internal virtual bool IsConstant() { }

	private bool IsMixed(StorageType left, StorageType right) { }

	private bool IsMixedSql(StorageType left, StorageType right) { }

	internal virtual bool IsTableConstant() { }

	internal virtual ExpressionNode Optimize() { }

	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	private int SqlResultType(int typeCode) { }

}

