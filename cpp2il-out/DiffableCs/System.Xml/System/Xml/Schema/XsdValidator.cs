namespace System.Xml.Schema;

internal sealed class XsdValidator : BaseValidator
{
	private static readonly XmlSchemaDatatype dtCDATA; //Field offset: 0x0
	private static readonly XmlSchemaDatatype dtQName; //Field offset: 0x8
	private static readonly XmlSchemaDatatype dtStringArray; //Field offset: 0x10
	private int startIDConstraint; //Field offset: 0x80
	private HWStack validationStack; //Field offset: 0x88
	private Hashtable attPresence; //Field offset: 0x90
	private XmlNamespaceManager nsManager; //Field offset: 0x98
	private bool bManageNamespaces; //Field offset: 0xA0
	private Hashtable IDs; //Field offset: 0xA8
	private IdRefNode idRefListHead; //Field offset: 0xB0
	private Parser inlineSchemaParser; //Field offset: 0xB8
	private XmlSchemaContentProcessing processContents; //Field offset: 0xC0
	private string NsXmlNs; //Field offset: 0xC8
	private string NsXs; //Field offset: 0xD0
	private string NsXsi; //Field offset: 0xD8
	private string XsiType; //Field offset: 0xE0
	private string XsiNil; //Field offset: 0xE8
	private string XsiSchemaLocation; //Field offset: 0xF0
	private string XsiNoNamespaceSchemaLocation; //Field offset: 0xF8
	private string XsdSchema; //Field offset: 0x100

	private bool HasIdentityConstraints
	{
		private get { } //Length: 901
	}

	private bool HasSchema
	{
		private get { } //Length: 30
	}

	private bool IsInlineSchemaStarted
	{
		private get { } //Length: 12
	}

	public virtual bool PreserveWhitespace
	{
		 get { } //Length: 59
	}

	private static XsdValidator() { }

	internal XsdValidator(BaseValidator validator) { }

	internal XsdValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	internal void AddID(string name, object node) { }

	private void AddIdentityConstraints() { }

	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	private void CheckForwardRefs() { }

	private void CheckValue(string value, SchemaAttDef attdef) { }

	public virtual void CompleteValidation() { }

	private void ElementIdentityConstraints() { }

	private void EndElementIdentityConstraints() { }

	private SchemaElementDecl FastGetElementDecl(object particle) { }

	public virtual object FindId(string name) { }

	private bool get_HasIdentityConstraints() { }

	private bool get_HasSchema() { }

	private bool get_IsInlineSchemaStarted() { }

	public virtual bool get_PreserveWhitespace() { }

	private void Init() { }

	public bool IsXSDRoot(string localName, string ns) { }

	private void LoadSchema(string uri, string url) { }

	private void LoadSchemaFromLocation(string uri, string url) { }

	private void Pop() { }

	private void ProcessElement(object particle) { }

	private void ProcessInlineSchema() { }

	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	private void Push(XmlQualifiedName elementName) { }

	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	private object UnWrapUnion(object typedValue) { }

	public virtual void Validate() { }

	private object ValidateChildElement() { }

	private void ValidateElement() { }

	private void ValidateEndElement() { }

	private void ValidateEndStartElement() { }

	private void ValidateStartElement() { }

	private void ValidateStartElementIdentityConstraints() { }

}

