namespace System.Data;

internal sealed class XSDSchema : XMLSchema
{
	private sealed class NameType : IComparable
	{
		public readonly string name; //Field offset: 0x10
		public readonly Type type; //Field offset: 0x18

		public NameType(string n, Type t) { }

		public override int CompareTo(object obj) { }

	}

	private static readonly NameType[] s_mapNameTypeXsd; //Field offset: 0x0
	private XmlSchemaSet _schemaSet; //Field offset: 0x10
	private XmlSchemaElement _dsElement; //Field offset: 0x18
	private DataSet _ds; //Field offset: 0x20
	private string _schemaName; //Field offset: 0x28
	private ArrayList _columnExpressions; //Field offset: 0x30
	private Hashtable _constraintNodes; //Field offset: 0x38
	private ArrayList _refTables; //Field offset: 0x40
	private ArrayList _complexTypes; //Field offset: 0x48
	private XmlSchemaObjectCollection _annotations; //Field offset: 0x50
	private XmlSchemaObjectCollection _elements; //Field offset: 0x58
	private Hashtable _attributes; //Field offset: 0x60
	private Hashtable _elementsTable; //Field offset: 0x68
	private Hashtable _attributeGroups; //Field offset: 0x70
	private Hashtable _schemaTypes; //Field offset: 0x78
	private Hashtable _expressions; //Field offset: 0x80
	private Dictionary<DataTable, List`1<DataTable>> _tableDictionary; //Field offset: 0x88
	private Hashtable _udSimpleTypes; //Field offset: 0x90
	private Hashtable _existingSimpleTypeMap; //Field offset: 0x98
	private bool _fromInference; //Field offset: 0xA0

	internal bool FromInference
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	private static XSDSchema() { }

	public XSDSchema() { }

	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	private void CollectElementsAnnotations(XmlSchema schema) { }

	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	internal DataColumn FindField(DataTable table, string field) { }

	private static NameType FindNameType(string name) { }

	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	internal bool get_FromInference() { }

	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	private string GetNamespaceFromPrefix(string prefix) { }

	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	private string GetPrefix(string ns) { }

	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	internal void HandleRelation(XmlElement node, bool fNested) { }

	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	internal DataTable HandleTable(XmlSchemaElement node) { }

	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	internal bool IsTable(XmlSchemaElement node) { }

	internal static bool IsXsdType(string name) { }

	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	private Type ParseDataType(string dt) { }

	internal static string QualifiedName(string name) { }

	internal void set_FromInference(bool value) { }

	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	internal static Rule TranslateRule(string strRule) { }

	public static Type XsdtoClr(string xsdTypeName) { }

}

