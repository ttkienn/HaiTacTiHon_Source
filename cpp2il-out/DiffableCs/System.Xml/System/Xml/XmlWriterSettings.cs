namespace System.Xml;

public sealed class XmlWriterSettings
{
	private bool useAsync; //Field offset: 0x10
	private Encoding encoding; //Field offset: 0x18
	private bool omitXmlDecl; //Field offset: 0x20
	private NewLineHandling newLineHandling; //Field offset: 0x24
	private string newLineChars; //Field offset: 0x28
	private TriState indent; //Field offset: 0x30
	private string indentChars; //Field offset: 0x38
	private bool newLineOnAttributes; //Field offset: 0x40
	private bool closeOutput; //Field offset: 0x41
	private NamespaceHandling namespaceHandling; //Field offset: 0x44
	private ConformanceLevel conformanceLevel; //Field offset: 0x48
	private bool checkCharacters; //Field offset: 0x4C
	private bool writeEndDocumentOnClose; //Field offset: 0x4D
	private XmlOutputMethod outputMethod; //Field offset: 0x50
	private List<XmlQualifiedName> cdataSections; //Field offset: 0x58
	private bool doNotEscapeUriAttributes; //Field offset: 0x60
	private bool mergeCDataSections; //Field offset: 0x61
	private string mediaType; //Field offset: 0x68
	private string docTypeSystem; //Field offset: 0x70
	private string docTypePublic; //Field offset: 0x78
	private XmlStandalone standalone; //Field offset: 0x80
	private bool autoXmlDecl; //Field offset: 0x84
	private bool isReadOnly; //Field offset: 0x85

	public bool Async
	{
		 get { } //Length: 5
	}

	internal bool AutoXmlDeclaration
	{
		internal get { } //Length: 8
	}

	internal List<XmlQualifiedName> CDataSectionElements
	{
		internal get { } //Length: 5
	}

	public bool CheckCharacters
	{
		 get { } //Length: 5
	}

	public bool CloseOutput
	{
		 get { } //Length: 5
	}

	public ConformanceLevel ConformanceLevel
	{
		 get { } //Length: 4
		 set { } //Length: 152
	}

	internal string DocTypePublic
	{
		internal get { } //Length: 5
	}

	internal string DocTypeSystem
	{
		internal get { } //Length: 5
	}

	public bool DoNotEscapeUriAttributes
	{
		 get { } //Length: 5
	}

	public Encoding Encoding
	{
		 get { } //Length: 5
	}

	public bool Indent
	{
		 get { } //Length: 8
		 set { } //Length: 86
	}

	public string IndentChars
	{
		 get { } //Length: 5
	}

	internal TriState IndentInternal
	{
		internal get { } //Length: 4
	}

	internal bool IsQuerySpecific
	{
		internal get { } //Length: 95
	}

	internal string MediaType
	{
		internal get { } //Length: 5
	}

	internal bool MergeCDataSections
	{
		internal get { } //Length: 5
	}

	public NamespaceHandling NamespaceHandling
	{
		 get { } //Length: 4
		 set { } //Length: 152
	}

	public string NewLineChars
	{
		 get { } //Length: 5
	}

	public NewLineHandling NewLineHandling
	{
		 get { } //Length: 4
	}

	public bool NewLineOnAttributes
	{
		 get { } //Length: 5
	}

	public bool OmitXmlDeclaration
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public internal XmlOutputMethod OutputMethod
	{
		 get { } //Length: 4
		internal set { } //Length: 4
	}

	internal bool ReadOnly
	{
		internal set { } //Length: 7
	}

	internal XmlStandalone Standalone
	{
		internal get { } //Length: 7
	}

	public bool WriteEndDocumentOnClose
	{
		 get { } //Length: 5
	}

	public XmlWriterSettings() { }

	private void CheckReadOnly(string propertyName) { }

	public XmlWriterSettings Clone() { }

	internal XmlWriter CreateWriter(TextWriter output) { }

	internal XmlWriter CreateWriter(Stream output) { }

	public bool get_Async() { }

	internal bool get_AutoXmlDeclaration() { }

	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	public bool get_CheckCharacters() { }

	public bool get_CloseOutput() { }

	public ConformanceLevel get_ConformanceLevel() { }

	internal string get_DocTypePublic() { }

	internal string get_DocTypeSystem() { }

	public bool get_DoNotEscapeUriAttributes() { }

	public Encoding get_Encoding() { }

	public bool get_Indent() { }

	public string get_IndentChars() { }

	internal TriState get_IndentInternal() { }

	internal bool get_IsQuerySpecific() { }

	internal string get_MediaType() { }

	internal bool get_MergeCDataSections() { }

	public NamespaceHandling get_NamespaceHandling() { }

	public string get_NewLineChars() { }

	public NewLineHandling get_NewLineHandling() { }

	public bool get_NewLineOnAttributes() { }

	public bool get_OmitXmlDeclaration() { }

	public XmlOutputMethod get_OutputMethod() { }

	internal XmlStandalone get_Standalone() { }

	public bool get_WriteEndDocumentOnClose() { }

	private void Initialize() { }

	public void set_ConformanceLevel(ConformanceLevel value) { }

	public void set_Indent(bool value) { }

	public void set_NamespaceHandling(NamespaceHandling value) { }

	public void set_OmitXmlDeclaration(bool value) { }

	internal void set_OutputMethod(XmlOutputMethod value) { }

	internal void set_ReadOnly(bool value) { }

}

