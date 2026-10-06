namespace System.Data;

internal sealed class DataTextWriter : XmlWriter
{
	private XmlWriter _xmltextWriter; //Field offset: 0x18

	internal Stream BaseStream
	{
		internal get { } //Length: 129
	}

	public virtual WriteState WriteState
	{
		 get { } //Length: 42
	}

	private DataTextWriter(XmlWriter w) { }

	public virtual void Close() { }

	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	public virtual void Flush() { }

	internal Stream get_BaseStream() { }

	public virtual WriteState get_WriteState() { }

	public virtual string LookupPrefix(string ns) { }

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

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartDocument() { }

	public virtual void WriteStartDocument(bool standalone) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteWhitespace(string ws) { }

}

