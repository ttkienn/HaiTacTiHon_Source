namespace System.Data;

internal sealed class XDRSchema : XMLSchema
{
	private sealed class NameType : IComparable
	{
		public string name; //Field offset: 0x10
		public Type type; //Field offset: 0x18

		public NameType(string n, Type t) { }

		public override int CompareTo(object obj) { }

	}

	private static readonly Char[] s_colonArray; //Field offset: 0x0
	private static NameType[] s_mapNameTypeXdr; //Field offset: 0x8
	private static NameType s_enumerationNameType; //Field offset: 0x10
	internal string _schemaName; //Field offset: 0x10
	internal string _schemaUri; //Field offset: 0x18
	internal XmlElement _schemaRoot; //Field offset: 0x20
	internal DataSet _ds; //Field offset: 0x28

	private static XDRSchema() { }

	internal XDRSchema(DataSet ds, bool fInline) { }

	private static NameType FindNameType(string name) { }

	internal XmlElement FindTypeNode(XmlElement node) { }

	internal string GetInstanceName(XmlElement node) { }

	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	internal void HandleColumn(XmlElement node, DataTable table) { }

	internal DataTable HandleTable(XmlElement node) { }

	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	internal bool IsTextOnlyContent(XmlElement node) { }

	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	private Type ParseDataType(string dt, string dtValues) { }

}

