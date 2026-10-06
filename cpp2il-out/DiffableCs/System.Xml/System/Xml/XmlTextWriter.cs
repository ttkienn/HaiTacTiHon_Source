namespace System.Xml;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public class XmlTextWriter : XmlWriter
{
	private struct Namespace
	{
		internal string prefix; //Field offset: 0x0
		internal string ns; //Field offset: 0x8
		internal bool declared; //Field offset: 0x10
		internal int prevNsIndex; //Field offset: 0x14

		internal void Set(string prefix, string ns, bool declared) { }

	}

	private enum NamespaceState
	{
		Uninitialized = 0,
		NotDeclaredButInScope = 1,
		DeclaredButNotWrittenOut = 2,
		DeclaredAndWrittenOut = 3,
	}

	private enum SpecialAttr
	{
		None = 0,
		XmlSpace = 1,
		XmlLang = 2,
		XmlNs = 3,
	}

	private enum State
	{
		Start = 0,
		Prolog = 1,
		PostDTD = 2,
		Element = 3,
		Attribute = 4,
		Content = 5,
		AttrOnly = 6,
		Epilog = 7,
		Error = 8,
		Closed = 9,
	}

	private struct TagInfo
	{
		internal string name; //Field offset: 0x0
		internal string prefix; //Field offset: 0x8
		internal string defaultNs; //Field offset: 0x10
		internal NamespaceState defaultNsState; //Field offset: 0x18
		internal XmlSpace xmlSpace; //Field offset: 0x1C
		internal string xmlLang; //Field offset: 0x20
		internal int prevNsTop; //Field offset: 0x28
		internal int prefixCount; //Field offset: 0x2C
		internal bool mixed; //Field offset: 0x30

		internal void Init(int nsTop) { }

	}

	private enum Token
	{
		PI = 0,
		Doctype = 1,
		Comment = 2,
		CData = 3,
		StartElement = 4,
		EndElement = 5,
		LongEndElement = 6,
		StartAttribute = 7,
		EndAttribute = 8,
		Content = 9,
		Base64 = 10,
		RawData = 11,
		Whitespace = 12,
		Empty = 13,
	}

	private static String[] stateName; //Field offset: 0x0
	private static String[] tokenName; //Field offset: 0x8
	private static readonly State[] stateTableDefault; //Field offset: 0x10
	private static readonly State[] stateTableDocument; //Field offset: 0x18
	private TextWriter textWriter; //Field offset: 0x18
	private XmlTextEncoder xmlEncoder; //Field offset: 0x20
	private Encoding encoding; //Field offset: 0x28
	private Formatting formatting; //Field offset: 0x30
	private bool indented; //Field offset: 0x34
	private int indentation; //Field offset: 0x38
	private char indentChar; //Field offset: 0x3C
	private TagInfo[] stack; //Field offset: 0x40
	private int top; //Field offset: 0x48
	private State[] stateTable; //Field offset: 0x50
	private State currentState; //Field offset: 0x58
	private Token lastToken; //Field offset: 0x5C
	private XmlTextWriterBase64Encoder base64Encoder; //Field offset: 0x60
	private char quoteChar; //Field offset: 0x68
	private char curQuoteChar; //Field offset: 0x6A
	private bool namespaces; //Field offset: 0x6C
	private SpecialAttr specialAttr; //Field offset: 0x70
	private string prefixForXmlNs; //Field offset: 0x78
	private bool flush; //Field offset: 0x80
	private Namespace[] nsStack; //Field offset: 0x88
	private int nsTop; //Field offset: 0x90
	private Dictionary<String, Int32> nsHashtable; //Field offset: 0x98
	private bool useNsHashtable; //Field offset: 0xA0
	private XmlCharType xmlCharType; //Field offset: 0xA8

	public Stream BaseStream
	{
		 get { } //Length: 142
	}

	public Formatting Formatting
	{
		 set { } //Length: 13
	}

	public bool Namespaces
	{
		 set { } //Length: 123
	}

	public char QuoteChar
	{
		 set { } //Length: 149
	}

	public virtual WriteState WriteState
	{
		 get { } //Length: 68
	}

	private static XmlTextWriter() { }

	public XmlTextWriter(TextWriter w) { }

	internal XmlTextWriter() { }

	public XmlTextWriter(Stream w, Encoding encoding) { }

	public XmlTextWriter(string filename, Encoding encoding) { }

	private void AddNamespace(string prefix, string ns, bool declared) { }

	private void AddToNamespaceHashtable(int namespaceIndex) { }

	private void AutoComplete(Token token) { }

	private void AutoCompleteAll() { }

	public virtual void Close() { }

	private string FindPrefix(string ns) { }

	public virtual void Flush() { }

	private void FlushEncoders() { }

	private string GeneratePrefix() { }

	public Stream get_BaseStream() { }

	public virtual WriteState get_WriteState() { }

	private void HandleSpecialAttribute() { }

	private void Indent(bool beforeEndElement) { }

	private void InternalWriteEndElement(bool longFormat) { }

	private void InternalWriteProcessingInstruction(string name, string text) { }

	private int LookupNamespace(string prefix) { }

	private int LookupNamespaceInCurrentScope(string prefix) { }

	public virtual string LookupPrefix(string ns) { }

	private void PopNamespaces(int indexFrom, int indexTo) { }

	private void PushNamespace(string prefix, string ns, bool declared) { }

	private void PushStack() { }

	public void set_Formatting(Formatting value) { }

	public void set_Namespaces(bool value) { }

	public void set_QuoteChar(char value) { }

	private void StartDocument(int standalone) { }

	private void ValidateName(string name, bool isNCName) { }

	private void VerifyPrefixXml(string prefix, string ns) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	private void WriteEndAttributeQuote() { }

	public virtual void WriteEndDocument() { }

	public virtual void WriteEndElement() { }

	private void WriteEndStartTag(bool empty) { }

	public virtual void WriteEntityRef(string name) { }

	public virtual void WriteFullEndElement() { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartDocument(bool standalone) { }

	public virtual void WriteStartDocument() { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteWhitespace(string ws) { }

}

