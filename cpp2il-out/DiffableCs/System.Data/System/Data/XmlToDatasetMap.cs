namespace System.Data;

internal sealed class XmlToDatasetMap
{
	private sealed class TableSchemaInfo
	{
		public DataTable TableSchema; //Field offset: 0x10
		public XmlNodeIdHashtable ColumnsSchemaMap; //Field offset: 0x18

		public TableSchemaInfo(DataTable tableSchema) { }

	}

	private sealed class XmlNodeIdentety
	{
		public string LocalName; //Field offset: 0x10
		public string NamespaceURI; //Field offset: 0x18

		public XmlNodeIdentety(string localName, string namespaceURI) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	[DefaultMember("Item")]
	public sealed class XmlNodeIdHashtable : Hashtable
	{
		private XmlNodeIdentety _id; //Field offset: 0x50

		public object Item
		{
			 get { } //Length: 171
		}

		public object Item
		{
			 get { } //Length: 171
		}

		public object Item
		{
			 get { } //Length: 143
		}

		public object Item
		{
			 get { } //Length: 150
		}

		public XmlNodeIdHashtable(int capacity) { }

		public object get_Item(XmlNode node) { }

		public object get_Item(XmlReader dataReader) { }

		public object get_Item(DataTable table) { }

		public object get_Item(string name) { }

	}

	private XmlNodeIdHashtable _tableSchemaMap; //Field offset: 0x10
	private TableSchemaInfo _lastTableSchemaInfo; //Field offset: 0x18

	public XmlToDatasetMap(DataSet dataSet, XmlNameTable nameTable) { }

	public XmlToDatasetMap(XmlNameTable nameTable, DataSet dataSet) { }

	public XmlToDatasetMap(DataTable dataTable, XmlNameTable nameTable) { }

	public XmlToDatasetMap(XmlNameTable nameTable, DataTable dataTable) { }

	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlNodeIdHashtable columns) { }

	private TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	private TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

	internal static bool IsMappedColumn(DataColumn c) { }

}

