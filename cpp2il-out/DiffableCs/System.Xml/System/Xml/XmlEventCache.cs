namespace System.Xml;

internal sealed class XmlEventCache : XmlRawWriter
{
	private struct XmlEvent
	{
		private XmlEventType eventType; //Field offset: 0x0
		private string s1; //Field offset: 0x8
		private string s2; //Field offset: 0x10
		private string s3; //Field offset: 0x18
		private object o; //Field offset: 0x20

		public XmlEventType EventType
		{
			 get { } //Length: 3
		}

		public object Object
		{
			 get { } //Length: 5
		}

		public string String1
		{
			 get { } //Length: 5
		}

		public string String2
		{
			 get { } //Length: 5
		}

		public string String3
		{
			 get { } //Length: 5
		}

		public XmlEventType get_EventType() { }

		public object get_Object() { }

		public string get_String1() { }

		public string get_String2() { }

		public string get_String3() { }

		public void InitEvent(XmlEventType eventType) { }

		public void InitEvent(XmlEventType eventType, string s1) { }

		public void InitEvent(XmlEventType eventType, string s1, string s2) { }

		public void InitEvent(XmlEventType eventType, string s1, string s2, string s3) { }

		public void InitEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

		public void InitEvent(XmlEventType eventType, object o) { }

	}

	private enum XmlEventType
	{
		Unknown = 0,
		DocType = 1,
		StartElem = 2,
		StartAttr = 3,
		EndAttr = 4,
		CData = 5,
		Comment = 6,
		PI = 7,
		Whitespace = 8,
		String = 9,
		Raw = 10,
		EntRef = 11,
		CharEnt = 12,
		SurrCharEnt = 13,
		Base64 = 14,
		BinHex = 15,
		XmlDecl1 = 16,
		XmlDecl2 = 17,
		StartContent = 18,
		EndElem = 19,
		FullEndElem = 20,
		Nmsp = 21,
		EndBase64 = 22,
		Close = 23,
		Flush = 24,
		Dispose = 25,
	}

	private List<XmlEvent[]> pages; //Field offset: 0x28
	private XmlEvent[] pageCurr; //Field offset: 0x30
	private int pageSize; //Field offset: 0x38
	private bool hasRootNode; //Field offset: 0x3C
	private StringConcat singleText; //Field offset: 0x40
	private string baseUri; //Field offset: 0x78

	public XmlEventCache(string baseUri, bool hasRootNode) { }

	private void AddEvent(XmlEventType eventType, object o) { }

	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	private void AddEvent(XmlEventType eventType, string s1, string s2) { }

	private void AddEvent(XmlEventType eventType, string s1) { }

	private void AddEvent(XmlEventType eventType) { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public void EndEvents() { }

	public void EventsToWriter(XmlWriter writer) { }

	public virtual void Flush() { }

	private int NewEvent() { }

	internal virtual void StartElementContent() { }

	private static Byte[] ToBytes(Byte[] buffer, int index, int count) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	internal virtual void WriteEndBase64() { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	public virtual void WriteEntityRef(string name) { }

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteWhitespace(string ws) { }

	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

