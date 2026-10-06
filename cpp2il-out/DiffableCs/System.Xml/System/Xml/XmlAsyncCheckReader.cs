namespace System.Xml;

[DefaultMember("Item")]
internal class XmlAsyncCheckReader : XmlReader
{
	private readonly XmlReader coreReader; //Field offset: 0x10
	private Task lastTask; //Field offset: 0x18

	public virtual int AttributeCount
	{
		 get { } //Length: 55
	}

	public virtual string BaseURI
	{
		 get { } //Length: 55
	}

	public virtual bool CanReadValueChunk
	{
		 get { } //Length: 55
	}

	public virtual bool CanResolveEntity
	{
		 get { } //Length: 55
	}

	internal XmlReader CoreReader
	{
		internal get { } //Length: 5
	}

	public virtual int Depth
	{
		 get { } //Length: 55
	}

	internal virtual IDtdInfo DtdInfo
	{
		internal get { } //Length: 55
	}

	public virtual bool EOF
	{
		 get { } //Length: 55
	}

	public virtual bool HasAttributes
	{
		 get { } //Length: 55
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 55
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 55
	}

	public virtual string LocalName
	{
		 get { } //Length: 55
	}

	public virtual string Name
	{
		 get { } //Length: 55
	}

	internal virtual XmlNamespaceManager NamespaceManager
	{
		internal get { } //Length: 55
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 55
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 55
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 55
	}

	public virtual string Prefix
	{
		 get { } //Length: 55
	}

	public virtual char QuoteChar
	{
		 get { } //Length: 55
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 55
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 55
	}

	public virtual XmlReaderSettings Settings
	{
		 get { } //Length: 249
	}

	public virtual string Value
	{
		 get { } //Length: 55
	}

	public virtual Type ValueType
	{
		 get { } //Length: 55
	}

	public virtual string XmlLang
	{
		 get { } //Length: 55
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 55
	}

	public XmlAsyncCheckReader(XmlReader reader) { }

	private void CheckAsync() { }

	public virtual void Close() { }

	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual bool get_CanReadValueChunk() { }

	public virtual bool get_CanResolveEntity() { }

	internal XmlReader get_CoreReader() { }

	public virtual int get_Depth() { }

	internal virtual IDtdInfo get_DtdInfo() { }

	public virtual bool get_EOF() { }

	public virtual bool get_HasAttributes() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	internal virtual XmlNamespaceManager get_NamespaceManager() { }

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

	public virtual string GetAttribute(string name, string namespaceURI) { }

	public virtual string GetAttribute(int i) { }

	public virtual string GetAttribute(string name) { }

	public virtual bool IsStartElement(string localname, string ns) { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual void MoveToAttribute(int i) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual XmlNodeType MoveToContent() { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	public virtual string ReadElementString() { }

	public virtual void ReadEndElement() { }

	public virtual string ReadInnerXml() { }

	public virtual void ReadStartElement() { }

	public virtual string ReadString() { }

	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	public virtual void ResolveEntity() { }

	public virtual void Skip() { }

}

