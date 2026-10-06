namespace System.Xml.Schema;

public sealed class XmlSchemaValidator
{
	private static readonly XmlSchemaDatatype dtQName; //Field offset: 0x0
	private static readonly XmlSchemaDatatype dtCDATA; //Field offset: 0x8
	private static readonly XmlSchemaDatatype dtStringArray; //Field offset: 0x10
	private static XmlSchemaParticle[] EmptyParticleArray; //Field offset: 0x18
	private static XmlSchemaAttribute[] EmptyAttributeArray; //Field offset: 0x20
	internal static Boolean[2] ValidStates; //Field offset: 0x28
	private static String[] MethodNames; //Field offset: 0x30
	private XmlSchemaSet schemaSet; //Field offset: 0x10
	private XmlSchemaValidationFlags validationFlags; //Field offset: 0x18
	private int startIDConstraint; //Field offset: 0x1C
	private bool isRoot; //Field offset: 0x20
	private bool rootHasSchema; //Field offset: 0x21
	private bool attrValid; //Field offset: 0x22
	private bool checkEntity; //Field offset: 0x23
	private SchemaInfo compiledSchemaInfo; //Field offset: 0x28
	private IDtdInfo dtdSchemaInfo; //Field offset: 0x30
	private Hashtable validatedNamespaces; //Field offset: 0x38
	private HWStack validationStack; //Field offset: 0x40
	private ValidationState context; //Field offset: 0x48
	private ValidatorState currentState; //Field offset: 0x50
	private Hashtable attPresence; //Field offset: 0x58
	private SchemaAttDef wildID; //Field offset: 0x60
	private Hashtable IDs; //Field offset: 0x68
	private IdRefNode idRefListHead; //Field offset: 0x70
	private XmlQualifiedName contextQName; //Field offset: 0x78
	private string NsXs; //Field offset: 0x80
	private string NsXsi; //Field offset: 0x88
	private string NsXmlNs; //Field offset: 0x90
	private string NsXml; //Field offset: 0x98
	private XmlSchemaObject partialValidationType; //Field offset: 0xA0
	private StringBuilder textValue; //Field offset: 0xA8
	private ValidationEventHandler eventHandler; //Field offset: 0xB0
	private object validationEventSender; //Field offset: 0xB8
	private XmlNameTable nameTable; //Field offset: 0xC0
	private IXmlLineInfo positionInfo; //Field offset: 0xC8
	private IXmlLineInfo dummyPositionInfo; //Field offset: 0xD0
	private XmlResolver xmlResolver; //Field offset: 0xD8
	private Uri sourceUri; //Field offset: 0xE0
	private string sourceUriString; //Field offset: 0xE8
	private IXmlNamespaceResolver nsResolver; //Field offset: 0xF0
	private XmlSchemaContentProcessing processContents; //Field offset: 0xF8
	private string xsiTypeString; //Field offset: 0x100
	private string xsiNilString; //Field offset: 0x108
	private string xsiSchemaLocationString; //Field offset: 0x110
	private string xsiNoNamespaceSchemaLocationString; //Field offset: 0x118
	private XmlCharType xmlCharType; //Field offset: 0x120

	public event ValidationEventHandler ValidationEventHandler
	{
		 add { } //Length: 171
		 remove { } //Length: 171
	}

	internal XmlSchemaContentType CurrentContentType
	{
		internal get { } //Length: 59
	}

	private bool HasIdentityConstraints
	{
		private get { } //Length: 17
	}

	private bool HasSchema
	{
		private get { } //Length: 71
	}

	public IXmlLineInfo LineInfoProvider
	{
		 set { } //Length: 34
	}

	internal bool ProcessIdentityConstraints
	{
		internal get { } //Length: 8
	}

	internal bool ProcessSchemaHints
	{
		internal get { } //Length: 17
	}

	internal bool ReportValidationWarnings
	{
		internal get { } //Length: 8
	}

	internal XmlSchemaSet SchemaSet
	{
		internal get { } //Length: 5
	}

	public Uri SourceUri
	{
		 set { } //Length: 91
	}

	private bool StrictlyAssessed
	{
		private get { } //Length: 62
	}

	public object ValidationEventSender
	{
		 set { } //Length: 19
	}

	internal XmlSchemaValidationFlags ValidationFlags
	{
		internal get { } //Length: 4
	}

	public XmlResolver XmlResolver
	{
		 set { } //Length: 19
	}

	private static XmlSchemaValidator() { }

	public XmlSchemaValidator(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	private void AddIdentityConstraints() { }

	public void AddSchema(XmlSchema schema) { }

	private void AddXmlNamespaceSchema() { }

	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	internal static string BuildElementName(string localName, string ns) { }

	internal static string BuildElementName(XmlQualifiedName qname) { }

	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	private void CheckElementProperties() { }

	private object CheckElementValue(string stringValue) { }

	private void CheckForwardRefs() { }

	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	internal object CheckMixedValueConstraint(string elementValue) { }

	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	private void ClearPSVI() { }

	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	private void ElementIdentityConstraints() { }

	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	public void EndValidation() { }

	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	private object FindId(string name) { }

	internal XmlSchemaContentType get_CurrentContentType() { }

	private bool get_HasIdentityConstraints() { }

	private bool get_HasSchema() { }

	internal bool get_ProcessIdentityConstraints() { }

	internal bool get_ProcessSchemaHints() { }

	internal bool get_ReportValidationWarnings() { }

	internal XmlSchemaSet get_SchemaSet() { }

	private bool get_StrictlyAssessed() { }

	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	internal string GetConcatenatedValue() { }

	internal string GetDefaultAttributePrefix(string attributeNS) { }

	private XmlSchemaElement GetSchemaElement() { }

	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	private string GetTypeName(SchemaDeclBase decl) { }

	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	private void Init() { }

	public void Initialize() { }

	public void Initialize(XmlSchemaObject partialValidationType) { }

	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	private void LoadSchema(string uri, string url) { }

	private void Pop() { }

	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	private static string PrintNames(ArrayList expected) { }

	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	private void ProcessEntity(string name) { }

	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	private void Push(XmlQualifiedName elementName) { }

	internal static string QNameString(string localName, string ns) { }

	internal void RecompileSchemaSet() { }

	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	private void Reset() { }

	private void SaveTextValue(object value) { }

	private void SendValidationEvent(string code, String[] args, Exception innerException, XmlSeverityType severity) { }

	private void SendValidationEvent(string code) { }

	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	private void SendValidationEvent(string code, string arg1, string arg2) { }

	private void SendValidationEvent(string code, String[] args) { }

	private void SendValidationEvent(string code, String[] args, Exception innerException) { }

	private void SendValidationEvent(XmlSchemaValidationException e) { }

	private void SendValidationEvent(string code, string arg) { }

	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	private void SendValidationEvent(XmlSchemaException e) { }

	public void set_LineInfoProvider(IXmlLineInfo value) { }

	public void set_SourceUri(Uri value) { }

	public void set_ValidationEventSender(object value) { }

	public void set_XmlResolver(XmlResolver value) { }

	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	private void ValidateStartElementIdentityConstraints() { }

	public void ValidateText(XmlValueGetter elementValue) { }

	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

}

