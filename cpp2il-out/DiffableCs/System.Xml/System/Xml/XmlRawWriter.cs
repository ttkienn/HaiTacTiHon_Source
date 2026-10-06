namespace System.Xml;

internal abstract class XmlRawWriter : XmlWriter
{
	protected XmlRawWriterBase64Encoder base64Encoder; //Field offset: 0x18
	protected IXmlNamespaceResolver resolver; //Field offset: 0x20

	internal override IXmlNamespaceResolver NamespaceResolver
	{
		internal set { } //Length: 13
	}

	internal override bool SupportsNamespaceDeclarationInChunks
	{
		internal get { } //Length: 3
	}

	public virtual WriteState WriteState
	{
		 get { } //Length: 95
	}

	protected XmlRawWriter() { }

	internal override void Close(WriteState currentState) { }

	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	public virtual WriteState get_WriteState() { }

	public virtual string LookupPrefix(string ns) { }

	internal override void OnRootElement(ConformanceLevel conformanceLevel) { }

	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	internal abstract void StartElementContent() { }

	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	internal override void WriteEndBase64() { }

	public virtual void WriteEndDocument() { }

	public virtual void WriteEndElement() { }

	internal abstract void WriteEndElement(string prefix, string localName, string ns) { }

	internal override void WriteEndNamespaceDeclaration() { }

	public virtual void WriteFullEndElement() { }

	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	internal abstract void WriteNamespaceDeclaration(string prefix, string ns) { }

	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteStartDocument() { }

	public virtual void WriteStartDocument(bool standalone) { }

	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteWhitespace(string ws) { }

	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	internal override void WriteXmlDeclaration(string xmldecl) { }

}

