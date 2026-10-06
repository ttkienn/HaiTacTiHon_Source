namespace System.Xml.Schema;

internal class BaseValidator
{
	private XmlSchemaCollection schemaCollection; //Field offset: 0x10
	private IValidationEventHandling eventHandling; //Field offset: 0x18
	private XmlNameTable nameTable; //Field offset: 0x20
	private SchemaNames schemaNames; //Field offset: 0x28
	private PositionInfo positionInfo; //Field offset: 0x30
	private XmlResolver xmlResolver; //Field offset: 0x38
	private Uri baseUri; //Field offset: 0x40
	protected SchemaInfo schemaInfo; //Field offset: 0x48
	protected XmlValidatingReaderImpl reader; //Field offset: 0x50
	protected XmlQualifiedName elementName; //Field offset: 0x58
	protected ValidationState context; //Field offset: 0x60
	protected StringBuilder textValue; //Field offset: 0x68
	protected string textString; //Field offset: 0x70
	protected bool hasSibling; //Field offset: 0x78
	protected bool checkDatatype; //Field offset: 0x79

	public Uri BaseUri
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public IDtdInfo DtdInfo
	{
		 set { } //Length: 232
	}

	public ValidationEventHandler EventHandler
	{
		 get { } //Length: 120
	}

	public XmlNameTable NameTable
	{
		 get { } //Length: 5
	}

	public PositionInfo PositionInfo
	{
		 get { } //Length: 5
	}

	public override bool PreserveWhitespace
	{
		 get { } //Length: 3
	}

	public XmlValidatingReaderImpl Reader
	{
		 get { } //Length: 5
	}

	public XmlSchemaCollection SchemaCollection
	{
		 get { } //Length: 5
	}

	public SchemaInfo SchemaInfo
	{
		 get { } //Length: 5
	}

	public SchemaNames SchemaNames
	{
		 get { } //Length: 173
	}

	public XmlResolver XmlResolver
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public BaseValidator(BaseValidator other) { }

	public BaseValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	public override void CompleteValidation() { }

	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	public override object FindId(string name) { }

	public Uri get_BaseUri() { }

	public ValidationEventHandler get_EventHandler() { }

	public XmlNameTable get_NameTable() { }

	public PositionInfo get_PositionInfo() { }

	public override bool get_PreserveWhitespace() { }

	public XmlValidatingReaderImpl get_Reader() { }

	public XmlSchemaCollection get_SchemaCollection() { }

	public SchemaInfo get_SchemaInfo() { }

	public SchemaNames get_SchemaNames() { }

	public XmlResolver get_XmlResolver() { }

	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	private void SaveTextValue(string value) { }

	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	protected void SendValidationEvent(XmlSchemaException e) { }

	protected void SendValidationEvent(string code, string arg) { }

	protected void SendValidationEvent(string code, String[] args) { }

	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	protected void SendValidationEvent(string code, String[] args, XmlSeverityType severity) { }

	protected void SendValidationEvent(string code) { }

	public void set_BaseUri(Uri value) { }

	public void set_DtdInfo(IDtdInfo value) { }

	public void set_XmlResolver(XmlResolver value) { }

	public override void Validate() { }

	public void ValidateText() { }

	public void ValidateWhitespace() { }

}

