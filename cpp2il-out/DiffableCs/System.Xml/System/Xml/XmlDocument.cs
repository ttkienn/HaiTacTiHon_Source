namespace System.Xml;

public class XmlDocument : XmlNode
{
	internal static EmptyEnumerator EmptyEnumerator; //Field offset: 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; //Field offset: 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; //Field offset: 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; //Field offset: 0x18
	private XmlImplementation implementation; //Field offset: 0x18
	private DomNameTable domNameTable; //Field offset: 0x20
	private XmlLinkedNode lastChild; //Field offset: 0x28
	private XmlNamedNodeMap entities; //Field offset: 0x30
	private Hashtable htElementIdMap; //Field offset: 0x38
	private Hashtable htElementIDAttrDecl; //Field offset: 0x40
	private SchemaInfo schemaInfo; //Field offset: 0x48
	private XmlSchemaSet schemas; //Field offset: 0x50
	private bool reportValidity; //Field offset: 0x58
	private bool actualLoadingStatus; //Field offset: 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; //Field offset: 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; //Field offset: 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; //Field offset: 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; //Field offset: 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; //Field offset: 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; //Field offset: 0x88
	internal bool fEntRefNodesPresent; //Field offset: 0x90
	internal bool fCDataNodesPresent; //Field offset: 0x91
	private bool preserveWhitespace; //Field offset: 0x92
	private bool isLoading; //Field offset: 0x93
	internal string strDocumentName; //Field offset: 0x98
	internal string strDocumentFragmentName; //Field offset: 0xA0
	internal string strCommentName; //Field offset: 0xA8
	internal string strTextName; //Field offset: 0xB0
	internal string strCDataSectionName; //Field offset: 0xB8
	internal string strEntityName; //Field offset: 0xC0
	internal string strID; //Field offset: 0xC8
	internal string strXmlns; //Field offset: 0xD0
	internal string strXml; //Field offset: 0xD8
	internal string strSpace; //Field offset: 0xE0
	internal string strLang; //Field offset: 0xE8
	internal string strEmpty; //Field offset: 0xF0
	internal string strNonSignificantWhitespaceName; //Field offset: 0xF8
	internal string strSignificantWhitespaceName; //Field offset: 0x100
	internal string strReservedXmlns; //Field offset: 0x108
	internal string strReservedXml; //Field offset: 0x110
	internal string baseURI; //Field offset: 0x118
	private XmlResolver resolver; //Field offset: 0x120
	internal bool bSetResolver; //Field offset: 0x128
	internal object objLock; //Field offset: 0x130

	internal bool ActualLoadingStatus
	{
		internal get { } //Length: 5
	}

	public virtual string BaseURI
	{
		 get { } //Length: 8
	}

	internal bool CanReportValidity
	{
		internal get { } //Length: 5
	}

	internal override XmlDeclaration Declaration
	{
		internal get { } //Length: 176
	}

	public XmlElement DocumentElement
	{
		 get { } //Length: 130
	}

	public override XmlDocumentType DocumentType
	{
		 get { } //Length: 130
	}

	internal SchemaInfo DtdSchemaInfo
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal string Encoding
	{
		internal get { } //Length: 42
	}

	internal XmlNamedNodeMap Entities
	{
		internal get { } //Length: 109
		internal set { } //Length: 13
	}

	internal bool HasSetResolver
	{
		internal get { } //Length: 8
	}

	public XmlImplementation Implementation
	{
		 get { } //Length: 5
	}

	public virtual string InnerText
	{
		 set { } //Length: 95
	}

	public virtual string InnerXml
	{
		 set { } //Length: 20
	}

	internal virtual bool IsContainer
	{
		internal get { } //Length: 3
	}

	internal bool IsLoading
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 3
	}

	internal virtual XmlLinkedNode LastNode
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	public virtual string LocalName
	{
		 get { } //Length: 8
	}

	public virtual string Name
	{
		 get { } //Length: 8
	}

	public XmlNameTable NameTable
	{
		 get { } //Length: 27
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public virtual XmlDocument OwnerDocument
	{
		 get { } //Length: 3
	}

	public virtual XmlNode ParentNode
	{
		 get { } //Length: 3
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 286
	}

	public XmlSchemaSet Schemas
	{
		 set { } //Length: 13
	}

	internal string Standalone
	{
		internal get { } //Length: 42
	}

	internal string Version
	{
		internal get { } //Length: 42
	}

	public override XmlResolver XmlResolver
	{
		 set { } //Length: 330
	}

	private static XmlDocument() { }

	protected private XmlDocument(XmlImplementation imp) { }

	public XmlDocument() { }

	public XmlDocument(XmlNameTable nt) { }

	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	internal void AddDefaultAttributes(XmlElement elem) { }

	internal void AddElementWithId(string id, XmlElement elem) { }

	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	internal static void CheckName(string name) { }

	public virtual XmlNode CloneNode(bool deep) { }

	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	public XmlAttribute CreateAttribute(string name) { }

	public override XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	public override XmlCDataSection CreateCDataSection(string data) { }

	public override XmlComment CreateComment(string data) { }

	protected private override XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	public override XmlDocumentFragment CreateDocumentFragment() { }

	public override XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	public XmlElement CreateElement(string name) { }

	public override XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	public override XmlEntityReference CreateEntityReference(string name) { }

	public override XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	public override XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	public override XmlText CreateTextNode(string text) { }

	public override XmlWhitespace CreateWhitespace(string text) { }

	public override XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	internal bool get_ActualLoadingStatus() { }

	public virtual string get_BaseURI() { }

	internal bool get_CanReportValidity() { }

	internal override XmlDeclaration get_Declaration() { }

	public XmlElement get_DocumentElement() { }

	public override XmlDocumentType get_DocumentType() { }

	internal SchemaInfo get_DtdSchemaInfo() { }

	internal string get_Encoding() { }

	internal XmlNamedNodeMap get_Entities() { }

	internal bool get_HasSetResolver() { }

	public XmlImplementation get_Implementation() { }

	internal virtual bool get_IsContainer() { }

	internal bool get_IsLoading() { }

	public virtual bool get_IsReadOnly() { }

	internal virtual XmlLinkedNode get_LastNode() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual XmlDocument get_OwnerDocument() { }

	public virtual XmlNode get_ParentNode() { }

	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	internal string get_Standalone() { }

	internal string get_Version() { }

	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	internal XmlEntity GetEntityNode(string name) { }

	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	internal XmlResolver GetResolver() { }

	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	internal virtual bool IsValidChildType(XmlNodeType type) { }

	public override void Load(XmlReader reader) { }

	public override void LoadXml(string xml) { }

	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	public override XmlNode ReadNode(XmlReader reader) { }

	internal void RemoveElementWithId(string id, XmlElement elem) { }

	public override void Save(XmlWriter w) { }

	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	internal void set_Entities(XmlNamedNodeMap value) { }

	public virtual void set_InnerText(string value) { }

	public virtual void set_InnerXml(string value) { }

	internal void set_IsLoading(bool value) { }

	internal virtual void set_LastNode(XmlLinkedNode value) { }

	public void set_Schemas(XmlSchemaSet value) { }

	public override void set_XmlResolver(XmlResolver value) { }

	internal void SetBaseURI(string inBaseURI) { }

	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	private XmlTextReader SetupReader(XmlTextReader tr) { }

	public virtual void WriteContentTo(XmlWriter xw) { }

	public virtual void WriteTo(XmlWriter w) { }

}

