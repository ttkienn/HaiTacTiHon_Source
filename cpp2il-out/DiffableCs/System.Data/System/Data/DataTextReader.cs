namespace System.Data;

internal sealed class DataTextReader : XmlReader
{
	private XmlReader _xmlreader; //Field offset: 0x10

	public virtual int AttributeCount
	{
		 get { } //Length: 42
	}

	public virtual string BaseURI
	{
		 get { } //Length: 42
	}

	public virtual bool CanReadValueChunk
	{
		 get { } //Length: 42
	}

	public virtual bool CanResolveEntity
	{
		 get { } //Length: 42
	}

	public virtual int Depth
	{
		 get { } //Length: 42
	}

	public virtual bool EOF
	{
		 get { } //Length: 42
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 42
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 42
	}

	public virtual string LocalName
	{
		 get { } //Length: 42
	}

	public virtual string Name
	{
		 get { } //Length: 42
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 42
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 42
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 42
	}

	public virtual string Prefix
	{
		 get { } //Length: 42
	}

	public virtual char QuoteChar
	{
		 get { } //Length: 42
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 42
	}

	public virtual XmlReaderSettings Settings
	{
		 get { } //Length: 42
	}

	public virtual string Value
	{
		 get { } //Length: 42
	}

	public virtual string XmlLang
	{
		 get { } //Length: 42
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 42
	}

	private DataTextReader(XmlReader input) { }

	public virtual void Close() { }

	internal static XmlReader CreateReader(XmlReader xr) { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual bool get_CanReadValueChunk() { }

	public virtual bool get_CanResolveEntity() { }

	public virtual int get_Depth() { }

	public virtual bool get_EOF() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual char get_QuoteChar() { }

	public virtual ReadState get_ReadState() { }

	public virtual XmlReaderSettings get_Settings() { }

	public virtual string get_Value() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string GetAttribute(string localName, string namespaceURI) { }

	public virtual string GetAttribute(int i) { }

	public virtual string GetAttribute(string name) { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual void MoveToAttribute(int i) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	public virtual string ReadString() { }

	public virtual void ResolveEntity() { }

	public virtual void Skip() { }

}

