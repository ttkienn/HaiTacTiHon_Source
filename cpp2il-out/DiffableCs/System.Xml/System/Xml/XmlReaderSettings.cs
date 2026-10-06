namespace System.Xml;

public sealed class XmlReaderSettings
{
	private static Nullable<Boolean> s_enableLegacyXmlSettings; //Field offset: 0x0
	private bool useAsync; //Field offset: 0x10
	private XmlNameTable nameTable; //Field offset: 0x18
	private XmlResolver xmlResolver; //Field offset: 0x20
	private int lineNumberOffset; //Field offset: 0x28
	private int linePositionOffset; //Field offset: 0x2C
	private ConformanceLevel conformanceLevel; //Field offset: 0x30
	private bool checkCharacters; //Field offset: 0x34
	private long maxCharactersInDocument; //Field offset: 0x38
	private long maxCharactersFromEntities; //Field offset: 0x40
	private bool ignoreWhitespace; //Field offset: 0x48
	private bool ignorePIs; //Field offset: 0x49
	private bool ignoreComments; //Field offset: 0x4A
	private DtdProcessing dtdProcessing; //Field offset: 0x4C
	private ValidationType validationType; //Field offset: 0x50
	private XmlSchemaValidationFlags validationFlags; //Field offset: 0x54
	private XmlSchemaSet schemas; //Field offset: 0x58
	private ValidationEventHandler valEventHandler; //Field offset: 0x60
	private bool closeInput; //Field offset: 0x68
	private bool isReadOnly; //Field offset: 0x69
	[CompilerGenerated]
	private bool <IsXmlResolverSet>k__BackingField; //Field offset: 0x6A

	public bool Async
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public bool CheckCharacters
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public bool CloseInput
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public ConformanceLevel ConformanceLevel
	{
		 get { } //Length: 4
		 set { } //Length: 152
	}

	public DtdProcessing DtdProcessing
	{
		 get { } //Length: 4
		 set { } //Length: 152
	}

	public bool IgnoreComments
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public bool IgnoreProcessingInstructions
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public bool IgnoreWhitespace
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	internal bool IsXmlResolverSet
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public int LineNumberOffset
	{
		 get { } //Length: 4
		 set { } //Length: 75
	}

	public int LinePositionOffset
	{
		 get { } //Length: 4
		 set { } //Length: 75
	}

	public long MaxCharactersFromEntities
	{
		 get { } //Length: 5
		 set { } //Length: 154
	}

	public long MaxCharactersInDocument
	{
		 get { } //Length: 5
		 set { } //Length: 154
	}

	public XmlNameTable NameTable
	{
		 get { } //Length: 5
		 set { } //Length: 88
	}

	internal bool ReadOnly
	{
		internal set { } //Length: 4
	}

	public XmlSchemaSet Schemas
	{
		 get { } //Length: 105
		 set { } //Length: 88
	}

	public XmlSchemaValidationFlags ValidationFlags
	{
		 get { } //Length: 4
		 set { } //Length: 152
	}

	public ValidationType ValidationType
	{
		 get { } //Length: 4
		 set { } //Length: 152
	}

	public XmlResolver XmlResolver
	{
		 set { } //Length: 93
	}

	public XmlReaderSettings() { }

	internal XmlReader AddValidation(XmlReader reader) { }

	private void CheckReadOnly(string propertyName) { }

	public XmlReaderSettings Clone() { }

	private static XmlResolver CreateDefaultResolver() { }

	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	internal static bool EnableLegacyXmlSettings() { }

	public bool get_Async() { }

	public bool get_CheckCharacters() { }

	public bool get_CloseInput() { }

	public ConformanceLevel get_ConformanceLevel() { }

	public DtdProcessing get_DtdProcessing() { }

	public bool get_IgnoreComments() { }

	public bool get_IgnoreProcessingInstructions() { }

	public bool get_IgnoreWhitespace() { }

	[CompilerGenerated]
	internal bool get_IsXmlResolverSet() { }

	public int get_LineNumberOffset() { }

	public int get_LinePositionOffset() { }

	public long get_MaxCharactersFromEntities() { }

	public long get_MaxCharactersInDocument() { }

	public XmlNameTable get_NameTable() { }

	public XmlSchemaSet get_Schemas() { }

	public XmlSchemaValidationFlags get_ValidationFlags() { }

	public ValidationType get_ValidationType() { }

	internal ValidationEventHandler GetEventHandler() { }

	internal XmlResolver GetXmlResolver() { }

	internal XmlResolver GetXmlResolver_CheckConfig() { }

	private void Initialize(XmlResolver resolver) { }

	private void Initialize() { }

	public void set_Async(bool value) { }

	public void set_CheckCharacters(bool value) { }

	public void set_CloseInput(bool value) { }

	public void set_ConformanceLevel(ConformanceLevel value) { }

	public void set_DtdProcessing(DtdProcessing value) { }

	public void set_IgnoreComments(bool value) { }

	public void set_IgnoreProcessingInstructions(bool value) { }

	public void set_IgnoreWhitespace(bool value) { }

	[CompilerGenerated]
	internal void set_IsXmlResolverSet(bool value) { }

	public void set_LineNumberOffset(int value) { }

	public void set_LinePositionOffset(int value) { }

	public void set_MaxCharactersFromEntities(long value) { }

	public void set_MaxCharactersInDocument(long value) { }

	public void set_NameTable(XmlNameTable value) { }

	internal void set_ReadOnly(bool value) { }

	public void set_Schemas(XmlSchemaSet value) { }

	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	public void set_ValidationType(ValidationType value) { }

	public void set_XmlResolver(XmlResolver value) { }

}

