namespace System.Xml;

internal class XmlAsyncCheckWriter : XmlWriter
{
	private readonly XmlWriter coreWriter; //Field offset: 0x18
	private Task lastTask; //Field offset: 0x20

	public virtual WriteState WriteState
	{
		 get { } //Length: 55
	}

	public XmlAsyncCheckWriter(XmlWriter writer) { }

	private void CheckAsync() { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public virtual WriteState get_WriteState() { }

	public virtual string LookupPrefix(string ns) { }

	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	public virtual void WriteEndDocument() { }

	public virtual void WriteEndElement() { }

	public virtual void WriteEntityRef(string name) { }

	public virtual void WriteFullEndElement() { }

	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartDocument(bool standalone) { }

	public virtual void WriteStartDocument() { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteWhitespace(string ws) { }

}

