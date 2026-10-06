namespace System.Data;

[IsReadOnly]
internal struct DataKey
{
	private readonly DataColumn[] _columns; //Field offset: 0x0

	internal DataColumn[] ColumnsReference
	{
		internal get { } //Length: 4
	}

	internal bool HasValue
	{
		internal get { } //Length: 8
	}

	internal DataTable Table
	{
		internal get { } //Length: 47
	}

	internal DataKey(DataColumn[] columns, bool copyColumns) { }

	internal void CheckState() { }

	internal bool ColumnsEqual(DataKey key) { }

	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	internal bool ContainsColumn(DataColumn column) { }

	public virtual bool Equals(object value) { }

	internal bool Equals(DataKey value) { }

	internal DataColumn[] get_ColumnsReference() { }

	internal bool get_HasValue() { }

	internal DataTable get_Table() { }

	internal String[] GetColumnNames() { }

	public virtual int GetHashCode() { }

	internal IndexField[] GetIndexDesc() { }

	internal Object[] GetKeyValues(int record) { }

	internal Index GetSortIndex() { }

	internal Index GetSortIndex(DataViewRowState recordStates) { }

	internal bool RecordsEqual(int record1, int record2) { }

	internal DataColumn[] ToArray() { }

}

