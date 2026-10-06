namespace System.Xml;

internal class XmlEncodedRawTextWriter : XmlRawWriter
{
	private readonly bool useAsync; //Field offset: 0x28
	protected Byte[] bufBytes; //Field offset: 0x30
	protected Stream stream; //Field offset: 0x38
	protected Encoding encoding; //Field offset: 0x40
	protected XmlCharType xmlCharType; //Field offset: 0x48
	protected int bufPos; //Field offset: 0x50
	protected int textPos; //Field offset: 0x54
	protected int contentPos; //Field offset: 0x58
	protected int cdataPos; //Field offset: 0x5C
	protected int attrEndPos; //Field offset: 0x60
	protected int bufLen; //Field offset: 0x64
	protected bool writeToNull; //Field offset: 0x68
	protected bool hadDoubleBracket; //Field offset: 0x69
	protected bool inAttributeValue; //Field offset: 0x6A
	protected int bufBytesUsed; //Field offset: 0x6C
	protected Char[] bufChars; //Field offset: 0x70
	protected Encoder encoder; //Field offset: 0x78
	protected TextWriter writer; //Field offset: 0x80
	protected bool trackTextContent; //Field offset: 0x88
	protected bool inTextContent; //Field offset: 0x89
	private int lastMarkPos; //Field offset: 0x8C
	private Int32[] textContentMarks; //Field offset: 0x90
	private CharEntityEncoderFallback charEntityFallback; //Field offset: 0x98
	protected NewLineHandling newLineHandling; //Field offset: 0xA0
	protected bool closeOutput; //Field offset: 0xA4
	protected bool omitXmlDeclaration; //Field offset: 0xA5
	protected string newLineChars; //Field offset: 0xA8
	protected bool checkCharacters; //Field offset: 0xB0
	protected XmlStandalone standalone; //Field offset: 0xB4
	protected XmlOutputMethod outputMethod; //Field offset: 0xB8
	protected bool autoXmlDeclaration; //Field offset: 0xBC
	protected bool mergeCDataSections; //Field offset: 0xBD

	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		internal get { } //Length: 3
	}

	protected XmlEncodedRawTextWriter(XmlWriterSettings settings) { }

	public XmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) { }

	public XmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) { }

	protected static Char* AmpEntity(Char* pDst) { }

	protected static Char* CarriageReturnEntity(Char* pDst) { }

	protected void ChangeTextContentMark(bool value) { }

	private static Char* CharEntity(Char* pDst, char ch) { }

	public virtual void Close() { }

	internal void EncodeChar(ref Char* pSrc, Char* pSrcEnd, ref Char* pDst) { }

	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	private static Char* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	public virtual void Flush() { }

	protected override void FlushBuffer() { }

	private void FlushEncoder() { }

	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	private void GrowTextContentMarks() { }

	protected static Char* GtEntity(Char* pDst) { }

	private Char* InvalidXmlChar(int ch, Char* pDst, bool entitize) { }

	protected static Char* LineFeedEntity(Char* pDst) { }

	protected static Char* LtEntity(Char* pDst) { }

	protected static Char* QuoteEntity(Char* pDst) { }

	protected static Char* RawEndCData(Char* pDst) { }

	protected static Char* RawStartCData(Char* pDst) { }

	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	protected void RawText(string s) { }

	internal virtual void StartElementContent() { }

	protected static Char* TabEntity(Char* pDst) { }

	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	public virtual void WriteCData(string text) { }

	protected void WriteCDataSection(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	protected void WriteCommentOrPi(string text, int stopChar) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	public virtual void WriteEndAttribute() { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteEndNamespaceDeclaration() { }

	public virtual void WriteEntityRef(string name) { }

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	protected Char* WriteNewLine(Char* pDst) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteRaw(string data) { }

	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteWhitespace(string ws) { }

	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

