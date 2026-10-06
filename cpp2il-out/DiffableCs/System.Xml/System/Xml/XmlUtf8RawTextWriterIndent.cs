namespace System.Xml;

internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
{
	protected int indentLevel; //Field offset: 0x90
	protected bool newLineOnAttributes; //Field offset: 0x94
	protected string indentChars; //Field offset: 0x98
	protected bool mixedContent; //Field offset: 0xA0
	private BitStack mixedContentStack; //Field offset: 0xA8
	protected ConformanceLevel conformanceLevel; //Field offset: 0xB0

	public XmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	private void Init(XmlWriterSettings settings) { }

	internal virtual void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	internal virtual void StartElementContent() { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	public virtual void WriteEntityRef(string name) { }

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	private void WriteIndent() { }

	public virtual void WriteProcessingInstruction(string target, string text) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteWhitespace(string ws) { }

}

