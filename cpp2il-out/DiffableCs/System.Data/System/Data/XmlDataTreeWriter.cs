namespace System.Data;

internal sealed class XmlDataTreeWriter
{
	private XmlWriter _xmlw; //Field offset: 0x10
	private DataSet _ds; //Field offset: 0x18
	private DataTable _dt; //Field offset: 0x20
	private ArrayList _dTables; //Field offset: 0x28
	private DataTable[] _topLevelTables; //Field offset: 0x30
	private bool _fFromTable; //Field offset: 0x38
	private bool _isDiffgram; //Field offset: 0x39
	private Hashtable _rowsOrder; //Field offset: 0x40
	private bool _writeHierarchy; //Field offset: 0x48

	internal XmlDataTreeWriter(DataSet ds) { }

	internal XmlDataTreeWriter(DataTable dt, bool writeHierarchy) { }

	private void CreateTablesHierarchy(DataTable dt) { }

	private DataTable[] CreateToplevelTables() { }

	private ArrayList GetNestedChildRelations(DataRow row) { }

	internal static bool PreserveSpace(object value) { }

	internal static bool RowHasErrors(DataRow row) { }

	internal void Save(XmlWriter xw, bool writeSchema) { }

	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

}

