namespace System.Data;

internal sealed class XmlDataLoader
{
	private DataSet _dataSet; //Field offset: 0x10
	private XmlToDatasetMap _nodeToSchemaMap; //Field offset: 0x18
	private Hashtable _nodeToRowMap; //Field offset: 0x20
	private Stack _childRowsStack; //Field offset: 0x28
	private Hashtable _htableExcludedNS; //Field offset: 0x30
	private bool _fIsXdr; //Field offset: 0x38
	internal bool _isDiffgram; //Field offset: 0x39
	private XmlElement _topMostNode; //Field offset: 0x40
	private bool _ignoreSchema; //Field offset: 0x48
	private DataTable _dataTable; //Field offset: 0x50
	private bool _isTableLevel; //Field offset: 0x58
	private bool _fromInference; //Field offset: 0x59
	private XmlReader _dataReader; //Field offset: 0x60
	private object _XSD_XMLNS_NS; //Field offset: 0x68
	private object _XDR_SCHEMA; //Field offset: 0x70
	private object _XDRNS; //Field offset: 0x78
	private object _SQL_SYNC; //Field offset: 0x80
	private object _UPDGNS; //Field offset: 0x88
	private object _XSD_SCHEMA; //Field offset: 0x90
	private object _XSDNS; //Field offset: 0x98
	private object _DFFNS; //Field offset: 0xA0
	private object _MSDNS; //Field offset: 0xA8
	private object _DIFFID; //Field offset: 0xB0
	private object _HASCHANGES; //Field offset: 0xB8
	private object _ROWORDER; //Field offset: 0xC0

	internal bool FromInference
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal XmlDataLoader(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	internal XmlDataLoader(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	internal XmlDataLoader(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	internal XmlDataLoader(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	private int CountNonNSAttributes(XmlNode node) { }

	internal bool FColumnElement(XmlElement e) { }

	private bool FExcludedNamespace(string ns) { }

	private bool FIgnoreNamespace(XmlNode node) { }

	private bool FIgnoreNamespace(XmlReader node) { }

	internal bool get_FromInference() { }

	private string GetInitialTextFromNodes(ref XmlNode n) { }

	internal DataRow GetRowFromElement(XmlElement e) { }

	private DataColumn GetTextOnlyColumn(DataRow row) { }

	private string GetValueForTextOnlyColums(XmlNode n) { }

	private void InitNameTable() { }

	internal bool IsTextLikeNode(XmlNodeType n) { }

	internal bool IsTextOnly(DataColumn c) { }

	private void LoadColumn(DataColumn column, Object[] foundColumns) { }

	internal void LoadData(XmlDocument xdoc) { }

	internal void LoadData(XmlReader reader) { }

	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	private void LoadTable(DataTable table, bool isNested) { }

	private void LoadTopMostTable(DataTable table) { }

	private bool ProcessXsdSchema() { }

	internal void set_FromInference(bool value) { }

	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

}

