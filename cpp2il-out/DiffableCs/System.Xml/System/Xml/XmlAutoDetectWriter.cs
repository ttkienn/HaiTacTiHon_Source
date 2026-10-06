namespace System.Xml;

internal class XmlAutoDetectWriter : XmlRawWriter
{
	private XmlRawWriter wrapped; //Field offset: 0x28
	private OnRemoveWriter onRemove; //Field offset: 0x30
	private XmlWriterSettings writerSettings; //Field offset: 0x38
	private XmlEventCache eventCache; //Field offset: 0x40
	private TextWriter textWriter; //Field offset: 0x48
	private Stream strm; //Field offset: 0x50

	internal virtual IXmlNamespaceResolver NamespaceResolver
	{
		internal set { } //Length: 87
	}

	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		internal get { } //Length: 42
	}

	private XmlAutoDetectWriter(XmlWriterSettings writerSettings) { }

	public XmlAutoDetectWriter(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	public XmlAutoDetectWriter(Stream strm, XmlWriterSettings writerSettings) { }

	public virtual void Close() { }

	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }

	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	public virtual void Flush() { }

	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	private static bool IsHtmlTag(string tagName) { }

	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	internal virtual void StartElementContent() { }

	private bool TextBlockCreatesWriter(string textBlock) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

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

	public virtual void WriteValue(string value) { }

	public virtual void WriteWhitespace(string ws) { }

	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

