namespace System.Xml.Schema;

internal sealed class Parser
{
	private SchemaType schemaType; //Field offset: 0x10
	private XmlNameTable nameTable; //Field offset: 0x18
	private SchemaNames schemaNames; //Field offset: 0x20
	private ValidationEventHandler eventHandler; //Field offset: 0x28
	private XmlNamespaceManager namespaceManager; //Field offset: 0x30
	private XmlReader reader; //Field offset: 0x38
	private PositionInfo positionInfo; //Field offset: 0x40
	private bool isProcessNamespaces; //Field offset: 0x48
	private int schemaXmlDepth; //Field offset: 0x4C
	private int markupDepth; //Field offset: 0x50
	private SchemaBuilder builder; //Field offset: 0x58
	private XmlSchema schema; //Field offset: 0x60
	private SchemaInfo xdrSchema; //Field offset: 0x68
	private XmlResolver xmlResolver; //Field offset: 0x70
	private XmlDocument dummyDocument; //Field offset: 0x78
	private bool processMarkup; //Field offset: 0x80
	private XmlNode parentNode; //Field offset: 0x88
	private XmlNamespaceManager annotationNSManager; //Field offset: 0x90
	private string xmlns; //Field offset: 0x98
	private XmlCharType xmlCharType; //Field offset: 0xA0

	public SchemaInfo XdrSchema
	{
		 get { } //Length: 5
	}

	internal XmlResolver XmlResolver
	{
		internal set { } //Length: 13
	}

	public XmlSchema XmlSchema
	{
		 get { } //Length: 5
	}

	public Parser(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	public SchemaType FinishParsing() { }

	public SchemaInfo get_XdrSchema() { }

	public XmlSchema get_XmlSchema() { }

	private XmlAttribute LoadAttributeNode() { }

	private XmlElement LoadElementNode(bool root) { }

	private XmlEntityReference LoadEntityReferenceInAttribute() { }

	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	public bool ParseReaderNode() { }

	private void ProcessAppInfoDocMarkup(bool root) { }

	internal void set_XmlResolver(XmlResolver value) { }

	public void StartParsing(XmlReader reader, string targetNamespace) { }

}

