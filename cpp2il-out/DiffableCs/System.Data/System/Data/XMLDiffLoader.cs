namespace System.Data;

internal sealed class XMLDiffLoader
{
	private ArrayList _tables; //Field offset: 0x10
	private DataSet _dataSet; //Field offset: 0x18
	private DataTable _dataTable; //Field offset: 0x20

	public XMLDiffLoader() { }

	private void CreateTablesHierarchy(DataTable dt) { }

	private DataTable GetTable(string tableName, string ns) { }

	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	internal void SkipWhitespaces(XmlReader reader) { }

}

