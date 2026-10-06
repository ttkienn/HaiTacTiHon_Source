namespace System.Xml;

internal class QueryOutputWriter : XmlRawWriter
{
	private XmlRawWriter wrapped; //Field offset: 0x28
	private bool inCDataSection; //Field offset: 0x30
	private Dictionary<XmlQualifiedName, Int32> lookupCDataElems; //Field offset: 0x38
	private BitStack bitsCData; //Field offset: 0x40
	private XmlQualifiedName qnameCData; //Field offset: 0x48
	private bool outputDocType; //Field offset: 0x50
	private bool checkWellFormedDoc; //Field offset: 0x51
	private bool hasDocElem; //Field offset: 0x52
	private bool inAttr; //Field offset: 0x53
	private string systemId; //Field offset: 0x58
	private string publicId; //Field offset: 0x60
	private int depth; //Field offset: 0x68

	internal virtual IXmlNamespaceResolver NamespaceResolver
	{
		internal set { } //Length: 76
	}

	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		internal get { } //Length: 42
	}

	public QueryOutputWriter(XmlRawWriter writer, XmlWriterSettings settings) { }

	public virtual void Close() { }

	private void EndCDataSection() { }

	public virtual void Flush() { }

	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	private bool StartCDataSection() { }

	internal virtual void StartElementContent() { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteEndNamespaceDeclaration() { }

	public virtual void WriteEntityRef(string name) { }

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteWhitespace(string ws) { }

	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

