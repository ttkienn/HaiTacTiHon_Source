namespace System.Xml;

internal class XmlLoader
{
	private XmlDocument doc; //Field offset: 0x10
	private XmlReader reader; //Field offset: 0x18
	private bool preserveWhitespace; //Field offset: 0x20

	public XmlLoader() { }

	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	private string EntitizeName(string name) { }

	internal void ExpandEntity(XmlEntity ent) { }

	internal void ExpandEntityReference(XmlEntityReference eref) { }

	private XmlParserContext GetContext(XmlNode node) { }

	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	private XmlAttribute LoadAttributeNode() { }

	private XmlAttribute LoadAttributeNodeDirect() { }

	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	private XmlDeclaration LoadDeclarationNode() { }

	private XmlAttribute LoadDefaultAttribute() { }

	private void LoadDocSequence(XmlDocument parentDoc) { }

	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	private XmlDocumentType LoadDocumentTypeNode() { }

	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	private XmlNode LoadNode(bool skipOverWhitespace) { }

	private XmlNode LoadNodeDirect() { }

	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }

}

