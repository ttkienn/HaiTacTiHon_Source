namespace System.Xml;

internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter
{

	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		internal get { } //Length: 3
	}

	public TextUtf8RawTextWriter(Stream stream, XmlWriterSettings settings) { }

	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	internal virtual void StartElementContent() { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	public virtual void WriteEntityRef(string name) { }

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string textBlock) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteWhitespace(string ws) { }

	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

