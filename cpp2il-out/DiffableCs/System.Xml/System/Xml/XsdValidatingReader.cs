namespace System.Xml;

internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver
{
	private enum ValidatingReaderState
	{
		None = 0,
		Init = 1,
		Read = 2,
		OnDefaultAttribute = -1,
		OnReadAttributeValue = -2,
		OnAttribute = 3,
		ClearAttributes = 4,
		ParseInlineSchema = 5,
		ReadAhead = 6,
		OnReadBinaryContent = 7,
		ReaderClosed = 8,
		EOF = 9,
		Error = 10,
	}

	private static Type TypeOfString; //Field offset: 0x0
	private XmlReader coreReader; //Field offset: 0x10
	private IXmlNamespaceResolver coreReaderNSResolver; //Field offset: 0x18
	private IXmlNamespaceResolver thisNSResolver; //Field offset: 0x20
	private XmlSchemaValidator validator; //Field offset: 0x28
	private XmlResolver xmlResolver; //Field offset: 0x30
	private ValidationEventHandler validationEvent; //Field offset: 0x38
	private ValidatingReaderState validationState; //Field offset: 0x40
	private XmlValueGetter valueGetter; //Field offset: 0x48
	private XmlNamespaceManager nsManager; //Field offset: 0x50
	private bool manageNamespaces; //Field offset: 0x58
	private bool processInlineSchema; //Field offset: 0x59
	private bool replayCache; //Field offset: 0x5A
	private ValidatingReaderNodeData cachedNode; //Field offset: 0x60
	private AttributePSVIInfo attributePSVI; //Field offset: 0x68
	private int attributeCount; //Field offset: 0x70
	private int coreReaderAttributeCount; //Field offset: 0x74
	private int currentAttrIndex; //Field offset: 0x78
	private AttributePSVIInfo[] attributePSVINodes; //Field offset: 0x80
	private ArrayList defaultAttributes; //Field offset: 0x88
	private Parser inlineSchemaParser; //Field offset: 0x90
	private object atomicValue; //Field offset: 0x98
	private XmlSchemaInfo xmlSchemaInfo; //Field offset: 0xA0
	private string originalAtomicValueString; //Field offset: 0xA8
	private XmlNameTable coreReaderNameTable; //Field offset: 0xB0
	private XsdCachingReader cachingReader; //Field offset: 0xB8
	private ValidatingReaderNodeData textNode; //Field offset: 0xC0
	private string NsXmlNs; //Field offset: 0xC8
	private string NsXs; //Field offset: 0xD0
	private string NsXsi; //Field offset: 0xD8
	private string XsiType; //Field offset: 0xE0
	private string XsiNil; //Field offset: 0xE8
	private string XsdSchema; //Field offset: 0xF0
	private string XsiSchemaLocation; //Field offset: 0xF8
	private string XsiNoNamespaceSchemaLocation; //Field offset: 0x100
	private XmlCharType xmlCharType; //Field offset: 0x108
	private IXmlLineInfo lineInfo; //Field offset: 0x110
	private ReadContentAsBinaryHelper readBinaryHelper; //Field offset: 0x118
	private ValidatingReaderState savedState; //Field offset: 0x120

	public virtual int AttributeCount
	{
		 get { } //Length: 4
	}

	private XmlSchemaInfo AttributeSchemaInfo
	{
		private get { } //Length: 27
	}

	public virtual string BaseURI
	{
		 get { } //Length: 42
	}

	public virtual int Depth
	{
		 get { } //Length: 65
	}

	public virtual bool EOF
	{
		 get { } //Length: 42
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 55
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 42
	}

	public override int LineNumber
	{
		 get { } //Length: 84
	}

	public override int LinePosition
	{
		 get { } //Length: 84
	}

	public virtual string LocalName
	{
		 get { } //Length: 66
	}

	public virtual string Name
	{
		 get { } //Length: 308
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 66
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 8
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 158
	}

	public virtual string Prefix
	{
		 get { } //Length: 66
	}

	public virtual char QuoteChar
	{
		 get { } //Length: 42
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 55
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 4
	}

	public virtual XmlReaderSettings Settings
	{
		 get { } //Length: 213
	}

	private override bool System.Xml.Schema.IXmlSchemaInfo.IsDefault
	{
		private get { } //Length: 137
	}

	private override bool System.Xml.Schema.IXmlSchemaInfo.IsNil
	{
		private get { } //Length: 73
	}

	private override XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType
	{
		private get { } //Length: 433
	}

	private override XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute
	{
		private get { } //Length: 76
	}

	private override XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement
	{
		private get { } //Length: 95
	}

	private override XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType
	{
		private get { } //Length: 95
	}

	private override XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity
	{
		private get { } //Length: 183
	}

	public virtual string Value
	{
		 get { } //Length: 66
	}

	public virtual Type ValueType
	{
		 get { } //Length: 208
	}

	public virtual string XmlLang
	{
		 get { } //Length: 42
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 42
	}

	internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	private void ClearAttributesInfo() { }

	public virtual void Close() { }

	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	public virtual int get_AttributeCount() { }

	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	public virtual string get_BaseURI() { }

	public virtual int get_Depth() { }

	public virtual bool get_EOF() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual char get_QuoteChar() { }

	public virtual ReadState get_ReadState() { }

	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	public virtual XmlReaderSettings get_Settings() { }

	public virtual string get_Value() { }

	public virtual Type get_ValueType() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string GetAttribute(int i) { }

	public virtual string GetAttribute(string name, string namespaceURI) { }

	public virtual string GetAttribute(string name) { }

	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	private AttributePSVIInfo GetAttributePSVI(string name) { }

	private XsdCachingReader GetCachingReader() { }

	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	private void GetIsDefault() { }

	private void GetMemberType() { }

	private string GetOriginalAtomicValueStringOfElement() { }

	private object GetStringValue() { }

	public override bool HasLineInfo() { }

	private void Init() { }

	private bool IsXSDRoot(string localName, string ns) { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual void MoveToAttribute(int i) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	private void ProcessElementEvent() { }

	private void ProcessEndElementEvent() { }

	private void ProcessInlineSchema() { }

	private void ProcessReaderEvent() { }

	public virtual bool Read() { }

	private void ReadAheadForMemberType() { }

	public virtual bool ReadAttributeValue() { }

	public virtual void ResolveEntity() { }

	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	public virtual void Skip() { }

	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	private override bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	private override bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	private override XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	private override XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	private override XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	private override XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	private override XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	private void ValidateAttributes() { }

}

