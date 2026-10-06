namespace System.Data;

internal sealed class NewDiffgramGen
{
	internal XmlDocument _doc; //Field offset: 0x10
	internal DataSet _ds; //Field offset: 0x18
	internal DataTable _dt; //Field offset: 0x20
	internal XmlWriter _xmlw; //Field offset: 0x28
	private bool _fBefore; //Field offset: 0x30
	private bool _fErrors; //Field offset: 0x31
	internal Hashtable _rowsOrder; //Field offset: 0x38
	private ArrayList _tables; //Field offset: 0x40
	private bool _writeHierarchy; //Field offset: 0x48

	internal NewDiffgramGen(DataSet ds) { }

	internal NewDiffgramGen(DataTable dt, bool writeHierarchy) { }

	private void CreateTableHierarchy(DataTable dt) { }

	private void DoAssignments(ArrayList tables) { }

	private bool EmptyData() { }

	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	private void GenerateRow(DataRow row) { }

	private void GenerateTable(DataTable table) { }

	private void GenerateTableErrors(DataTable table) { }

	internal static string QualifiedName(string prefix, string name) { }

	internal void Save(XmlWriter xmlw) { }

	internal void Save(XmlWriter xmlw, DataTable table) { }

}

