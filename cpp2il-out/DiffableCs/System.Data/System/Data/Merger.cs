namespace System.Data;

internal sealed class Merger
{
	private DataSet _dataSet; //Field offset: 0x10
	private DataTable _dataTable; //Field offset: 0x18
	private bool _preserveChanges; //Field offset: 0x20
	private MissingSchemaAction _missingSchemaAction; //Field offset: 0x24
	private bool _isStandAlonetable; //Field offset: 0x28
	private bool _IgnoreNSforTableLookup; //Field offset: 0x29

	internal Merger(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	internal Merger(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	private DataKey GetSrcKey(DataTable src, DataTable dst) { }

	private void MergeConstraints(DataSet source) { }

	private void MergeConstraints(DataTable table) { }

	internal void MergeDataSet(DataSet source) { }

	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	private void MergeRelation(DataRelation relation) { }

	private DataTable MergeSchema(DataTable table) { }

	internal void MergeTable(DataTable src) { }

	private void MergeTable(DataTable src, DataTable dst) { }

	private void MergeTableData(DataTable src) { }

}

