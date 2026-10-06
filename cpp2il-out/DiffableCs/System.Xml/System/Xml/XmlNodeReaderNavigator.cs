namespace System.Xml;

internal class XmlNodeReaderNavigator
{
	public struct VirtualAttribute
	{
		internal string name; //Field offset: 0x0
		internal string value; //Field offset: 0x8

		internal VirtualAttribute(string name, string value) { }

	}

	private XmlNode curNode; //Field offset: 0x10
	private XmlNode elemNode; //Field offset: 0x18
	private XmlNode logNode; //Field offset: 0x20
	private int attrIndex; //Field offset: 0x28
	private int logAttrIndex; //Field offset: 0x2C
	private XmlNameTable nameTable; //Field offset: 0x30
	private XmlDocument doc; //Field offset: 0x38
	private int nAttrInd; //Field offset: 0x40
	private int nDeclarationAttrCount; //Field offset: 0x44
	private int nDocTypeAttrCount; //Field offset: 0x48
	private int nLogLevel; //Field offset: 0x4C
	private int nLogAttrInd; //Field offset: 0x50
	private bool bLogOnAttrVal; //Field offset: 0x54
	private bool bCreatedOnAttribute; //Field offset: 0x55
	internal VirtualAttribute[] decNodeAttributes; //Field offset: 0x58
	internal VirtualAttribute[] docTypeNodeAttributes; //Field offset: 0x60
	private bool bOnAttrVal; //Field offset: 0x68

	public int AttributeCount
	{
		 get { } //Length: 327
	}

	public string BaseURI
	{
		 get { } //Length: 42
	}

	internal bool CreatedOnAttribute
	{
		internal get { } //Length: 5
	}

	public XmlDocument Document
	{
		 get { } //Length: 5
	}

	public bool IsDefault
	{
		 get { } //Length: 174
	}

	public bool IsEmptyElement
	{
		 get { } //Length: 157
	}

	private bool IsOnDeclOrDocType
	{
		private get { } //Length: 60
	}

	public string LocalName
	{
		 get { } //Length: 96
	}

	public string Name
	{
		 get { } //Length: 104
	}

	public string NamespaceURI
	{
		 get { } //Length: 42
	}

	public XmlNameTable NameTable
	{
		 get { } //Length: 5
	}

	public XmlNodeType NodeType
	{
		 get { } //Length: 65
	}

	public string Prefix
	{
		 get { } //Length: 42
	}

	public IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 42
	}

	public string Value
	{
		 get { } //Length: 668
	}

	public string XmlLang
	{
		 get { } //Length: 42
	}

	public XmlSpace XmlSpace
	{
		 get { } //Length: 42
	}

	public XmlNodeReaderNavigator(XmlNode node) { }

	private void CheckIndexCondition(int attributeIndex) { }

	internal string DefaultLookupNamespace(string prefix) { }

	public int get_AttributeCount() { }

	public string get_BaseURI() { }

	internal bool get_CreatedOnAttribute() { }

	public XmlDocument get_Document() { }

	public bool get_IsDefault() { }

	public bool get_IsEmptyElement() { }

	private bool get_IsOnDeclOrDocType() { }

	public string get_LocalName() { }

	public string get_Name() { }

	public string get_NamespaceURI() { }

	public XmlNameTable get_NameTable() { }

	public XmlNodeType get_NodeType() { }

	public string get_Prefix() { }

	public IXmlSchemaInfo get_SchemaInfo() { }

	public string get_Value() { }

	public string get_XmlLang() { }

	public XmlSpace get_XmlSpace() { }

	public string GetAttribute(int attributeIndex) { }

	public string GetAttribute(string name) { }

	public string GetAttribute(string name, string ns) { }

	private string GetAttributeFromElement(XmlElement elem, string name) { }

	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	public int GetDecAttrInd(string name) { }

	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	public string GetDeclarationAttr(int i) { }

	public int GetDocTypeAttrInd(string name) { }

	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	public string GetDocumentTypeAttr(int i) { }

	internal IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	private void InitDecAttr() { }

	private void InitDocTypeAttr() { }

	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	public void LogMove(int level) { }

	public string LookupNamespace(string prefix) { }

	internal string LookupPrefix(string namespaceName) { }

	public bool MoveToAttribute(string name) { }

	public bool MoveToAttribute(string name, string namespaceURI) { }

	public void MoveToAttribute(int attributeIndex) { }

	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	public bool MoveToElement() { }

	public bool MoveToFirstChild() { }

	public bool MoveToNext() { }

	public bool MoveToNextAttribute(ref int level) { }

	private bool MoveToNextSibling(XmlNode node) { }

	public bool MoveToParent() { }

	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	public void ResetToAttribute(ref int level) { }

	public void RollBackMove(ref int level) { }

}

