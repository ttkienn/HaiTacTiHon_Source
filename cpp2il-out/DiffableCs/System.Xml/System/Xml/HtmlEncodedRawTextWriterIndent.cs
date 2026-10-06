namespace System.Xml;

internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter
{
	private int indentLevel; //Field offset: 0xF0
	private int endBlockPos; //Field offset: 0xF4
	private string indentChars; //Field offset: 0xF8
	private bool newLineOnAttributes; //Field offset: 0x100

	public HtmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings) { }

	public HtmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	protected virtual void FlushBuffer() { }

	private void Init(XmlWriterSettings settings) { }

	internal virtual void StartElementContent() { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	private void WriteIndent() { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

}

